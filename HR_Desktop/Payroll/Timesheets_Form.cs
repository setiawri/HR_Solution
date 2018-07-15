using System;
using System.Windows.Forms;

using HR_LIB.HR;
using LIBUtil;
using LOGIN;
namespace HR_Desktop.Payroll
{
    public partial class Timesheets_Form : Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region PROPERTIES

        #endregion PROPERTIES
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Timesheets_Form() : this(null) { }
        public Timesheets_Form(Guid? id) { InitializeComponent(); }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            this.ShowIcon = false;
            setupControlsBasedOnRoles();

            iddl_DayOfWeek.populate(typeof(DayOfWeek));

            chkFilterEmployeesByClient.Checked = true;
            idtp_FilterEmployee_StartDate.Value = DateTime.Today.AddMonths(-3);
            idtp_FilterEmployee_EndDate.Value = DateTime.Today;

            dgvEmployees.AutoGenerateColumns = false;
            col_dgvEmployees_UserAccounts_Id.DataPropertyName = Workshift.COL_DB_UserAccounts_Id;
            col_dgvEmployees_UserAccounts_Fullname.DataPropertyName = Workshift.COL_UserAccounts_Fullname;
            col_dgvEmployees_Clients_Id.DataPropertyName = Workshift.COL_DB_Clients_Id;
            col_dgvEmployees_Clients_CompanyName.DataPropertyName = Workshift.COL_Clients_CompanyName;

            dgvAttendance.AutoGenerateColumns = false;
            col_dgvAttendance_Id.DataPropertyName = Attendance.COL_DB_Id;
            col_dgvAttendance_In.DataPropertyName = Attendance.COL_DB_TimestampIn;
            col_dgvAttendance_Out.DataPropertyName = Attendance.COL_DB_TimestampOut;
            col_dgvAttendance_Flag1.DataPropertyName = Attendance.COL_DB_Flag1;
            col_dgvAttendance_Flag2.DataPropertyName = Attendance.COL_DB_Flag2;
            col_dgvAttendance_Approved.DataPropertyName = Attendance.COL_DB_Approved;
            col_dgvAttendance_Notes.DataPropertyName = Attendance.COL_DB_Notes;

        }

        private void setupControlsBasedOnRoles()
        {

        }

        private void populateData()
        {
            if (isValidToPopulateData())
            {
                if(chkFilterEmployeesByClient.Checked)
                    Util.setGridviewDataSource(dgvEmployees, true, true, Workshift.getEmployeeByClientOrName(itxt_FilterEmployee_Client.ValueGuid, idtp_FilterEmployee_StartDate.ValueAsStartDateFilter, idtp_FilterEmployee_EndDate.ValueAsEndDateFilter,null));
                else if(chkFilterEmployeeByName.Checked)
                    Util.setGridviewDataSource(dgvEmployees, true, true, Workshift.getEmployeeByClientOrName(null, null, null, itxt_FilterEmployee_UserAccounts_Name.ValueText));
            }
        }

        private bool isValidToPopulateData()
        {
            return true;
        }

        private void populateDgvAttendance()
        {
            Util.setGridviewDataSource(dgvAttendance, true, true, 
                Attendance.get(
                    null,
                    (Guid)Util.getSelectedRowValue(dgvEmployees, col_dgvEmployees_UserAccounts_Id), 
                    Util.wrapNullable<int?>(iddl_DayOfWeek.SelectedValue), 
                    idtp_FilterAttendance_In.ValueTimeSpan, 
                    idtp_FilterAttendance_Out.ValueTimeSpan, 
                    null
                ));
        }

        private void resetData()
        {

        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        private void Form_Load(object sender, EventArgs e)
        {
            setupControls();
            populateData();
        }

        private void chkFilterEmployees_CheckedChanged(object sender, EventArgs e)
        {
            if(sender == chkFilterEmployeesByClient)
                chkFilterEmployeeByName.Checked = !chkFilterEmployeesByClient.Checked;
            else
                chkFilterEmployeesByClient.Checked = !chkFilterEmployeeByName.Checked;

            itxt_FilterEmployee_Client.Enabled = chkFilterEmployeesByClient.Checked;
            idtp_FilterEmployee_StartDate.Enabled = chkFilterEmployeesByClient.Checked;
            idtp_FilterEmployee_EndDate.Enabled = chkFilterEmployeesByClient.Checked;

            itxt_FilterEmployee_UserAccounts_Name.Enabled = chkFilterEmployeeByName.Checked;
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Util.isColumnMatch(sender, e, col_dgvEmployees_UserAccounts_Fullname))
            {
                iddl_DayOfWeek.reset();
                idtp_FilterAttendance_In.reset();
                idtp_FilterAttendance_Out.reset();
                populateDgvAttendance();
            }
        }

        private void itxt_Client_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new Admin.MasterData_v1_Clients_Form(FormModes.Browse), ref sender);
            itxt_Attendance_Client.setValue(itxt_FilterEmployee_Client.ValueText, (Guid)itxt_FilterEmployee_Client.ValueGuid);
        }

        private void btnFilterEmployees_Click(object sender, EventArgs e)
        {
            populateData();
        }

        private void btnSubmitAttendance_Click(object sender, EventArgs e)
        {
            Attendance.add(UserAccount.LoggedInAccount.Id,
                (Guid)Util.getSelectedRowValue(dgvEmployees, col_dgvEmployees_UserAccounts_Id),
                (DateTime)idtp_TimestampIn.Value,
                (DateTime)idtp_TimestampOut.Value,
                itxt_Notes.ValueText);

            populateDgvAttendance();
        }

        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Util.isColumnMatch(sender, e, col_dgvAttendance_Flag1))
            {
                Attendance.updateFlag1Status(UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgvAttendance, col_dgvAttendance_Id), !Util.getCheckboxValue(sender, e));
                populateDgvAttendance();
            }
            else if (Util.isColumnMatch(sender, e, col_dgvAttendance_Flag2))
            {
                Attendance.updateFlag2Status(UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgvAttendance, col_dgvAttendance_Id), !Util.getCheckboxValue(sender, e));
                populateDgvAttendance();
            }
            else if (Util.isColumnMatch(sender, e, col_dgvAttendance_Approved))
            {
                Attendance.updateApprovedStatus(UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgvAttendance, col_dgvAttendance_Id), !Util.getCheckboxValue(sender, e));
                populateDgvAttendance();
            }
        }

        private void btnFilterAttendance_Click(object sender, EventArgs e)
        {
            populateDgvAttendance();
        }

        private void itxt_Workshift_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new Admin.MasterData_v1_Workshifts_Form(FormModes.Browse), ref sender);
        }

        private void idtp_TimestampIn_ValueChanged(object sender, EventArgs e)
        {
            idtp_EffectiveTimestampIn.Value = idtp_TimestampIn.Value;
        }

        private void idtp_TimestampOut_ValueChanged(object sender, EventArgs e)
        {
            idtp_EffectiveTimestampOut.Value = idtp_TimestampOut.Value;
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
