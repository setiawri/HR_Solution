using System;
using System.Windows.Forms;

using HR_LIB.HR;
using LIBUtil;
using LOGIN;
namespace HR_Desktop.Payroll
{
    public partial class Timesheets_Form2 : Form
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

        public Timesheets_Form2() : this(null) { }
        public Timesheets_Form2(Guid? id) { InitializeComponent(); }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            this.ShowIcon = false;
            setupControlsBasedOnRoles();

            iddl_DayOfWeek.populate(typeof(DayOfWeek));
            AttendanceStatus.populateDropDownList(iddl_AttendanceStatuses, false);

            chkFilterEmployeesByClient.Checked = true;

            idtp_FilterEmployee_StartDate.Value = DateTime.Today.AddMonths(-3);
            idtp_FilterEmployee_EndDate.Value = DateTime.Today;

            idtp_FilterAttendance_StartDate.Value = DateTime.Today.AddMonths(-3);
            idtp_FilterAttendance_EndDate.Value = DateTime.Today;

            idtp_TimestampIn.Value = DateTime.Now;
            idtp_TimestampOut.Value = DateTime.Now;

            dgvEmployees.AutoGenerateColumns = false;
            col_dgvEmployees_UserAccounts_Id.DataPropertyName = Workshift.COL_DB_UserAccounts_Id;
            col_dgvEmployees_UserAccounts_Fullname.DataPropertyName = Workshift.COL_UserAccounts_Fullname;
            col_dgvEmployees_Clients_Id.DataPropertyName = Workshift.COL_DB_Clients_Id;

            dgvAttendance.AutoGenerateColumns = false;
            col_dgvAttendance_Id.DataPropertyName = Attendance.COL_DB_Id;
            col_dgvAttendance_In.DataPropertyName = Attendance.COL_DB_TimestampIn;
            col_dgvAttendance_Out.DataPropertyName = Attendance.COL_DB_TimestampOut;
            col_dgvAttendance_EffectiveIn.DataPropertyName = Attendance.COL_DB_EffectiveTimestampIn;
            col_dgvAttendance_EffectiveOut.DataPropertyName = Attendance.COL_DB_EffectiveTimestampOut;
            col_dgvAttendances_EffectiveWorkHours.DataPropertyName = Attendance.COL_EffectiveWorkHours;
            col_dgvAttendance_Flag1.DataPropertyName = Attendance.COL_DB_Flag1;
            col_dgvAttendance_Flag2.DataPropertyName = Attendance.COL_DB_Flag2;
            col_dgvAttendance_Approved.DataPropertyName = Attendance.COL_DB_Approved;
            col_dgvAttendance_Rejected.DataPropertyName = Attendance.COL_DB_Rejected;
            col_dgvAttendance_Notes.DataPropertyName = Attendance.COL_DB_Notes;
            col_dgvAttendance_PayrollItems_Id.DataPropertyName = Attendance.COL_DB_PayrollItems_Id;

            pnlFilterAttendance.Enabled = false;
        }

        private void setupControlsBasedOnRoles()
        {

        }

        private void populateData()
        {
            if (isValidToPopulateData())
            {
                pnlFilterAttendance.Enabled = false;
                dgvAttendance.DataSource = null;

                if (chkFilterEmployeesByClient.Checked)
                    Util.setGridviewDataSource(dgvEmployees, true, true, Workshift.getEmployeeByClientOrName(itxt_FilterEmployee_Client.ValueGuid, idtp_FilterEmployee_StartDate.ValueAsStartDateFilter, idtp_FilterEmployee_EndDate.ValueAsEndDateFilter,null));
                else if(chkFilterEmployeeByName.Checked)
                    Util.setGridviewDataSource(dgvEmployees, true, true, Workshift.getEmployeeByClientOrName(null, null, null, itxt_FilterEmployee_UserAccounts_Name.ValueText));

                if(dgvEmployees.Rows.Count > 0)
                    populateDgvAttendance();
            }
        }

        private bool isValidToPopulateData()
        {
            return true;
        }

        private void populateDgvAttendance()
        {
            if (dgvEmployees.Rows.Count > 0)
            {
                pnlFilterAttendance.Enabled = true;
                Util.setGridviewDataSource(dgvAttendance, true, true,
                    Attendance.get(
                        null,
                        (Guid)Util.getSelectedRowValue(dgvEmployees, col_dgvEmployees_UserAccounts_Id),
                        itxt_FilterEmployee_Client.ValueGuid,
                        null,
                        Util.wrapNullable<int?>(iddl_DayOfWeek.SelectedValue),
                        idtp_FilterAttendance_StartDate.ValueAsStartDateFilter,
                        idtp_FilterAttendance_EndDate.ValueAsEndDateFilter,
                        idtp_FilterAttendance_In.ValueTimeSpan,
                        idtp_FilterAttendance_Out.ValueTimeSpan,
                        null, 
                        null
                    ));
            }
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
        
        private void itxt_Client_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new Admin.MasterData_v1_Clients_Form(FormModes.Browse, null), ref sender);
            if(itxt_FilterEmployee_Client.ValueGuid != null)
                itxt_Attendance_Client.setValue(itxt_FilterEmployee_Client.ValueText, (Guid)itxt_FilterEmployee_Client.ValueGuid);
        }

        private void itxt_Attendance_Client_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new Admin.MasterData_v1_Clients_Form(FormModes.Browse, (Guid)Util.getSelectedRowValue(dgvEmployees, col_dgvEmployees_UserAccounts_Id)), ref sender);   
        }


        private void btnFilterEmployees_Click(object sender, EventArgs e)
        {
            populateData();
        }

        private void btnSubmitAttendance_Click(object sender, EventArgs e)
        {
            Attendance.add(UserAccount.LoggedInAccount.Id,
                (Guid)Util.getSelectedRowValue(dgvEmployees, col_dgvEmployees_UserAccounts_Id),
                itxt_Attendance_Client.ValueGuid,
                itxt_Workshift.ValueGuid,
                (DateTime)idtp_TimestampIn.Value,
                (DateTime)idtp_TimestampOut.Value,
                (DateTime)idtp_EffectiveTimestampIn.Value,
                (DateTime)idtp_EffectiveTimestampOut.Value,
                itxt_Notes.ValueText,
                (Guid)iddl_AttendanceStatuses.SelectedValue);

            populateDgvAttendance();
        }

        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Util.getSelectedRowValue(dgvAttendance,col_dgvAttendance_PayrollItems_Id) != null)
            {
                populateDgvAttendance();
            }
            else if (Util.isColumnMatch(sender, e, col_dgvAttendance_Flag1))
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
            else if (Util.isColumnMatch(sender, e, col_dgvAttendance_Rejected))
            {
                Attendance.updateRejectedStatus(UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgvAttendance, col_dgvAttendance_Id), !Util.getCheckboxValue(sender, e));
                populateDgvAttendance();
            }
            
        }

        private void btnFilterAttendance_Click(object sender, EventArgs e)
        {
            populateDgvAttendance();
        }

        private void itxt_Workshift_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new Admin.MasterData_v1_Workshifts_Form(FormModes.Browse, itxt_Attendance_Client.ValueGuid), ref sender);
        }

        private void idtp_TimestampIn_ValueChanged(object sender, EventArgs e)
        {
            idtp_EffectiveTimestampIn.Value = idtp_TimestampIn.Value;
        }

        private void idtp_TimestampOut_ValueChanged(object sender, EventArgs e)
        {
            idtp_EffectiveTimestampOut.Value = idtp_TimestampOut.Value;
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            iddl_DayOfWeek.reset();
            idtp_FilterAttendance_In.reset();
            idtp_FilterAttendance_Out.reset();
            populateDgvAttendance();
        }

        private void btnAddAttendance_Click(object sender, EventArgs e)
        {
            Util.displayForm(null, new Admin.MasterData_v1_Attendances_Form());
            populateDgvAttendance();
        }


        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
