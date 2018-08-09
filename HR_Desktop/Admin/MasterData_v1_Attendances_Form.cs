using System;
using System.Windows.Forms;

using LIBUtil;
using LOGIN;
using LOGGING;
using HR_LIB.HR;

namespace HR_Desktop.Admin
{
    public partial class MasterData_v1_Attendances_Form : LIBUtil.Desktop.Forms.MasterData_v1_Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private const bool FORM_SHOWDATAONLOAD = true;

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private DataGridViewColumn col_dgv_UserAccounts_FullName;
        private DataGridViewColumn col_dgv_Clients_CompanyName;
        private DataGridViewColumn col_dgv_Workshifts_Name;
        private DataGridViewColumn col_dgv_Workshifts_Start;
        private DataGridViewColumn col_dgv_Workshifts_Duration;
        private DataGridViewColumn col_dgv_Workshifts_DayOfWeek;
        private DataGridViewColumn col_dgv_AttendanceStatuses;
        private DataGridViewColumn col_dgv_TimestampIn;
        private DataGridViewColumn col_dgv_TimestampOut;
        private DataGridViewColumn col_dgv_EffectiveTimestampIn;
        private DataGridViewColumn col_dgv_EffectiveTimestampOut;
        private DataGridViewColumn col_dgv_Flag1;
        private DataGridViewColumn col_dgv_Flag2;
        private DataGridViewColumn col_dgv_Approved;
        private DataGridViewColumn col_dgv_Notes;
        private DataGridViewColumn col_dgv_PayrollItems_Id;
        private DataGridViewColumn col_dgv_Payrolls_No;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public MasterData_v1_Attendances_Form() : this(FormModes.Add) { }
        public MasterData_v1_Attendances_Form(FormModes startingMode) : base(startingMode, FORM_SHOWDATAONLOAD) { InitializeComponent(); }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS
        #endregion METHODS
        /*******************************************************************************************************/
        #region OVERRIDE METHODS

        protected override void setupControlsBasedOnRoles()
        {
        }

        protected override void setupFields()
        {
            disableFieldActive();
            idtp_TimestampIn.Value = DateTime.Now;
            idtp_TimestampOut.Value = DateTime.Now;

            setColumnsDataPropertyNames(Attendance.COL_DB_Id, null, null, null, null, null);
            dgv.AutoGenerateColumns = false;
            col_dgv_UserAccounts_FullName = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_UserAccounts_FullName", itxt_UserAccount.LabelText, Attendance.COL_UserAccounts_Fullname, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Clients_CompanyName = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Clients_CompanyName", itxt_Client.LabelText, Attendance.COL_Clients_CompanyName, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Workshifts_Name = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Workshifts_Name", itxt_Workshift.LabelText, Attendance.COL_Workshifts_Name, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Workshifts_DayOfWeek = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Workshifts_DayOfWeek", "Day Of Week", Attendance.COL_Workshifts_DayOfWeek_Name, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Workshifts_Start = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Workshifts_Start", "Start", Attendance.COL_DB_Workshifts_Start, true, true, @"HH:mm", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Workshifts_Duration = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Workshifts_Duration", "Duration", Attendance.COL_DB_Workshifts_DurationMinutes, true, true, "", true, false, 40, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_AttendanceStatuses = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_AttendanceStatuses", iddl_AttendanceStatuses.LabelText, Attendance.COL_AttendanceStatuses_Name, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_TimestampIn = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_TimestampIn", idtp_TimestampIn.LabelText, Attendance.COL_DB_TimestampIn, true, true, @"dd/MM/yy  HH:mm", true, false, 30, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_TimestampOut = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_TimestampOut", idtp_TimestampOut.LabelText, Attendance.COL_DB_TimestampOut, true, true, @"dd/MM/yy  HH:mm", true, false, 30, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_EffectiveTimestampIn = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_EffectiveTimestampIn", idtp_EffectiveTimestampIn.LabelText, Attendance.COL_DB_EffectiveTimestampIn, true, true, @"dd/MM/yy  HH:mm", true, false, 30, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_EffectiveTimestampOut = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_EffectiveTimestampOut", idtp_EffectiveTimestampOut.LabelText, Attendance.COL_DB_EffectiveTimestampOut, true, true, @"dd/MM/yy  HH:mm", true, false, 30, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Flag1 = base.addColumn<DataGridViewCheckBoxCell>(dgv, "col_dgv_Flag1", Attendance.COL_DB_Flag1, Attendance.COL_DB_Flag1, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Flag2 = base.addColumn<DataGridViewCheckBoxCell>(dgv, "col_dgv_Flag2", Attendance.COL_DB_Flag2, Attendance.COL_DB_Flag2, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Approved = base.addColumn<DataGridViewCheckBoxCell>(dgv, "col_dgv_Approved", Attendance.COL_DB_Approved, Attendance.COL_DB_Approved, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_PayrollItems_Id = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_PayrollItems_Id", "", Attendance.COL_DB_PayrollItems_Id, false, false, "", false, false, 30, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Payrolls_No = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Payrolls_No", "Payrolls", Attendance.COL_Payrolls_No, false, true, "", false, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Notes", itxt_Notes.LabelText, Attendance.COL_DB_Notes, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ptInputPanel.PerformClick();

            AttendanceStatus.populateDropDownList(iddl_AttendanceStatuses, false);
        }

        protected override void additionalSettings() { }

        protected override void clearInputFields()
        {
            itxt_UserAccount.reset();
            itxt_UserAccount.Enabled = true;
            itxt_Client.reset();
            itxt_Client.Enabled = true;
            itxt_Workshift.reset();
            itxt_Workshift.Enabled = true;
            iddl_AttendanceStatuses.reset();
            iddl_AttendanceStatuses.Enabled = true;
            idtp_TimestampIn.Value = DateTime.Now;
            idtp_TimestampIn.Enabled = true;
            idtp_TimestampOut.Value = DateTime.Now;
            idtp_TimestampOut.Enabled = true;
            idtp_EffectiveTimestampIn.Value = DateTime.Now;
            idtp_EffectiveTimestampIn.Enabled = true;
            idtp_EffectiveTimestampOut.Value = DateTime.Now;
            idtp_EffectiveTimestampOut.Enabled = true;
            itxt_Notes.reset();
        }

        protected override bool isValidToPopulateGridViewDataSource()
        {
            return true;
        }

        protected override System.Data.DataView loadGridviewDataSource()
        {            
            return Attendance.get(
                itxt_UserAccount.ValueGuid,
                itxt_Client.ValueGuid,
                itxt_Workshift.ValueGuid,
                null, null, null, null, null, null,
                itxt_Notes.ValueText,
                (Guid?)iddl_AttendanceStatuses.SelectedValue
                ).DefaultView;
        }

        protected override void populateInputFields()
        {
            Attendance obj = new Attendance(selectedRowID());

            itxt_UserAccount.setValue(obj.UserAccounts_Fullname, obj.UserAccounts_Id);
            itxt_Client.setValue(obj.Clients_CompanyName, obj.Clients_Id);
            itxt_Workshift.setValue(obj.Workshifts_Name, obj.Workshifts_Id);
            iddl_AttendanceStatuses.SelectedValue = obj.AttendanceStatuses_Name;
            idtp_TimestampIn.Value = obj.TimestampIn;
            idtp_TimestampOut.Value = obj.TimestampOut;
            idtp_EffectiveTimestampIn.Value = obj.EffectiveTimestampIn;
            idtp_EffectiveTimestampOut.Value = obj.EffectiveTimestampOut;
            itxt_Notes.ValueText = obj.Notes;

            if (obj.PayrollItems_Id != null)
            {
                itxt_UserAccount.Enabled = false;
                itxt_Client.Enabled = false;
                itxt_Workshift.Enabled = false;
                iddl_AttendanceStatuses.Enabled = false;
                idtp_TimestampIn.Enabled = false;
                idtp_TimestampOut.Enabled = false;
                idtp_EffectiveTimestampIn.Enabled = false;
                idtp_EffectiveTimestampOut.Enabled = false;
                itxt_Notes.Enabled = false;
            }
            
        }

        protected override void update()
        {
            Attendance.update(UserAccount.LoggedInAccount.Id,
                selectedRowID(),
                (DateTime)idtp_TimestampIn.Value,
                (DateTime)idtp_TimestampOut.Value,
                itxt_Notes.ValueText);
        }

        protected override void add()
        {   
            Attendance.add(UserAccount.LoggedInAccount.Id,
                (Guid)itxt_UserAccount.ValueGuid,
                (Guid)itxt_Client.ValueGuid,
                (Guid?)itxt_Workshift.ValueGuid,
                (DateTime)idtp_TimestampIn.Value,
                (DateTime)idtp_TimestampOut.Value,
                (DateTime?)idtp_EffectiveTimestampIn.Value,
                (DateTime?)idtp_EffectiveTimestampOut.Value,
                itxt_Notes.ValueText,
                (Guid)iddl_AttendanceStatuses.SelectedValue);
        }

        protected override Boolean isInputFieldsValid()
        {
            Util.sanitize(itxt_Notes);
            if (itxt_UserAccount.ValueGuid == null)
                return itxt_UserAccount.isValueError("Please select a User");
            else if (itxt_Client.ValueGuid == null)
                return itxt_Client.isValueError("Please select a Client");
            else if (!iddl_AttendanceStatuses.hasSelectedValue())
                return iddl_AttendanceStatuses.SelectedValueError("Please select Attendance Status");
            else if (idtp_TimestampIn.Value == null)
                return idtp_TimestampIn.ValueError("Please fill Timestamp In");
            else if (idtp_TimestampOut.Value == null)
                return idtp_TimestampOut.ValueError("Please fill Timestamp Out");
            else if ((Mode != FormModes.Update && Attendance.isCombinationExist(null, (Guid)itxt_UserAccount.ValueGuid, (DateTime)idtp_TimestampIn.Value))
                    || (Mode == FormModes.Update && Attendance.isCombinationExist(selectedRowID(), (Guid)itxt_UserAccount.ValueGuid, (DateTime)idtp_TimestampIn.Value)))
                return itxt_UserAccount.isValueError("Attendance combination exists. Please change User/Timestamp In.");

            return true;
        }

        protected override void btnLog_Click(object sender, EventArgs e)
        {
            Util.displayForm(null, new LOGGING.ActivityLogs_Form(UserAccount.LoggedInAccount, selectedRowID()));
            txtQuickSearch.Focus();
        }

        protected override void updateDefaultRow(Guid id) { }

        protected override string getSelectedItemDescription(int rowIndex)
        {
            return string.Format("{0} - In :{1} Out : {2}",
                Util.getSelectedRowValue(dgv, col_dgv_UserAccounts_FullName),
                Util.getSelectedRowValue(dgv, col_dgv_TimestampIn),
                Util.getSelectedRowValue(dgv, col_dgv_TimestampOut)
                );
        }

        protected override void virtual_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Util.isColumnMatch(sender, e, col_dgv_Flag1))
            {
                if(isValidToUpdate())
                    Attendance.updateFlag1Status(UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgv, col_dgv_Id), !Util.getCheckboxValue(sender, e));
                    populateGridViewDataSource(true);
            }
            else if (Util.isColumnMatch(sender, e, col_dgv_Flag2))
            {
                if (isValidToUpdate())
                    Attendance.updateFlag2Status(UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgv, col_dgv_Id), !Util.getCheckboxValue(sender, e));
                    populateGridViewDataSource(true);
            }
            else if (Util.isColumnMatch(sender, e, col_dgv_Approved))
            {
                if (isValidToUpdate())
                    Attendance.updateApprovedStatus(UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgv, col_dgv_Id), !Util.getCheckboxValue(sender, e));
                    populateGridViewDataSource(true);
            }
            base.virtual_dgv_CellContentClick(sender, e);
        }

        private bool isValidToUpdate()
        {
            return (Util.getSelectedRowValue(dgv, col_dgv_PayrollItems_Id) == null);
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            itxt_UserAccount.Enabled = false;
            base.btnUpdate_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Attendance.delete(UserAccount.LoggedInAccount.Id, selectedRowID());
            populateGridViewDataSource(true);
        }

        private void itxt_UserAccount_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new LOGIN.MasterData_v1_UserAccounts_Form(FormModes.Browse, false), ref sender);
        }
        
        private void idtp_TimestampIn_ValueChanged(object sender, EventArgs e)
        {
            idtp_TimestampOut.Value = idtp_TimestampIn.Value;
        }

        private void itxt_Client_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new Admin.MasterData_v1_Clients_Form(FormModes.Browse, itxt_UserAccount.ValueGuid), ref sender);
        }

        private void itxt_Workshift_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new Admin.MasterData_v1_Workshifts_Form(FormModes.Browse, itxt_Client.ValueGuid), ref sender);
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
