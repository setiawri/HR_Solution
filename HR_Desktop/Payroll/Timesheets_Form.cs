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

        protected CheckBox _headerCheckbox;

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
            AttendanceStatus.populateDropDownList(iddl_AttendanceStatuses, false);

            idtp_FilterAttendance_StartDate.Value = DateTime.Today.AddMonths(-3);
            idtp_FilterAttendance_EndDate.Value = DateTime.Today;

            dgvAttendance.AutoGenerateColumns = false;
            col_dgvAttendances_Id.DataPropertyName = Attendance.COL_DB_Id;
            col_dgvAttendances_In.DataPropertyName = Attendance.COL_DB_TimestampIn;
            col_dgvAttendances_Out.DataPropertyName = Attendance.COL_DB_TimestampOut;
            col_dgvAttendances_EffectiveIn.DataPropertyName = Attendance.COL_DB_EffectiveTimestampIn;
            col_dgvAttendances_EffectiveOut.DataPropertyName = Attendance.COL_DB_EffectiveTimestampOut;
            col_dgvAttendances_EffectiveWorkHours.DataPropertyName = Attendance.COL_EffectiveWorkHours;
            col_dgvAttendances_Flag1.DataPropertyName = Attendance.COL_DB_Flag1;
            col_dgvAttendances_Flag2.DataPropertyName = Attendance.COL_DB_Flag2;
            col_dgvAttendances_Approved.DataPropertyName = Attendance.COL_DB_Approved;
            col_dgvAttendances_Rejected.DataPropertyName = Attendance.COL_DB_Rejected;
            col_dgvAttendances_Notes.DataPropertyName = Attendance.COL_DB_Notes;
            col_dgvAttendances_PayrollItems_Id.DataPropertyName = Attendance.COL_DB_PayrollItems_Id;
            col_dgvAttendances_Employee_UserAccounts_Fullname.DataPropertyName = Attendance.COL_UserAccounts_Fullname;
            col_dgvAttendances_Clients_Name.DataPropertyName = Attendance.COL_Clients_CompanyName;
            col_dgvAttendances_Workshifts_DayOfWeek.DataPropertyName = Attendance.COL_Workshifts_DayOfWeek_Name;
        }

        private void setupControlsBasedOnRoles()
        {

        }

        private void populateData()
        {
            if (isValidToPopulateData())
            {
                populateDgvAttendance();
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
                    itxt_UserAccount.ValueGuid,
                    itxt_FilterEmployee_Client.ValueGuid,
                    null,
                    Util.wrapNullable<int?>(iddl_DayOfWeek.SelectedValue),
                    idtp_FilterAttendance_StartDate.ValueAsStartDateFilter,
                    idtp_FilterAttendance_EndDate.ValueAsEndDateFilter,
                    idtp_FilterAttendance_In.ValueTimeSpan,
                    idtp_FilterAttendance_Out.ValueTimeSpan,
                    null,
                    (Guid?)(iddl_AttendanceStatuses.SelectedValue)
                ));

            if (_headerCheckbox != null) _headerCheckbox.Checked = false;
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

        private void itxt_UserAccount_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new LOGIN.MasterData_v1_UserAccounts_Form(FormModes.Browse, false), ref sender);
        }

        private void itxt_FilterEmployee_Client_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new Admin.MasterData_v1_Clients_Form(FormModes.Browse, itxt_UserAccount.ValueGuid), ref sender);   
        }

        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Util.getSelectedRowValue(dgvAttendance,col_dgvAttendances_PayrollItems_Id) != null)
            {
                populateDgvAttendance();
            }
            else if (Util.isColumnMatch(sender, e, col_dgvAttendances_Flag1))
            {
                Attendance.updateFlag1Status(UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgvAttendance, col_dgvAttendances_Id), !Util.getCheckboxValue(sender, e));
                populateDgvAttendance();
            }
            else if (Util.isColumnMatch(sender, e, col_dgvAttendances_Flag2))
            {
                Attendance.updateFlag2Status(UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgvAttendance, col_dgvAttendances_Id), !Util.getCheckboxValue(sender, e));
                populateDgvAttendance();
            }
            else if (Util.isColumnMatch(sender, e, col_dgvAttendances_Approved))
            {
                Attendance.updateApprovedStatus(UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgvAttendance, col_dgvAttendances_Id), !Util.getCheckboxValue(sender, e));
                populateDgvAttendance();
            }
            else if (Util.isColumnMatch(sender, e, col_dgvAttendances_Rejected))
            {
                Attendance.updateRejectedStatus(UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgvAttendance, col_dgvAttendances_Id), !Util.getCheckboxValue(sender, e));
                populateDgvAttendance();
            }
            
        }

        private void btnFilterAttendance_Click(object sender, EventArgs e)
        {
            populateDgvAttendance();
        }

        private void btnAddAttendance_Click(object sender, EventArgs e)
        {
            Util.displayForm(null, new Admin.MasterData_v1_Attendances_Form());
            populateDgvAttendance();
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            _headerCheckbox = Util.addHeaderCheckbox(dgvAttendance, col_dgvAttendance_Checkbox, "_headerCheckbox", selectCheckboxHeader_CheckedChanged);
        }
        
        private void selectCheckboxHeader_CheckedChanged(object sender, EventArgs e)
        {
            Util.toggleCheckboxColumn(dgvAttendance, col_dgvAttendance_Checkbox, _headerCheckbox);
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
