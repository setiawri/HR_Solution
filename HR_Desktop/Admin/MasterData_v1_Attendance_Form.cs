using System;
using System.Windows.Forms;

using LIBUtil;
using LOGIN;
using LOGGING;
using HR_LIB.HR;

namespace HR_Desktop.Admin
{
    public partial class MasterData_v1_Attendance_Form : LIBUtil.Desktop.Forms.MasterData_v1_Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private const bool FORM_SHOWDATAONLOAD = true;

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private DataGridViewColumn col_dgv_UserAccounts_FullName;
        private DataGridViewColumn col_dgv_TimestampIn;
        private DataGridViewColumn col_dgv_TimestampOut;
        private DataGridViewColumn col_dgv_Flag1;
        private DataGridViewColumn col_dgv_Flag2;
        private DataGridViewColumn col_dgv_Approved;
        private DataGridViewColumn col_dgv_Notes;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public MasterData_v1_Attendance_Form() : this(FormModes.Add) { }
        public MasterData_v1_Attendance_Form(FormModes startingMode) : base(startingMode, FORM_SHOWDATAONLOAD) { InitializeComponent(); }

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

            col_dgv_UserAccounts_FullName = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_UserAccounts_FullName", itxt_UserAccount.LabelText, Attendance.COL_UserAccounts_Fullname, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_TimestampIn = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_TimestampIn", idtp_TimestampIn.LabelText, Attendance.COL_DB_TimestampIn, true, @"dd/MM/yy  HH:mm", true, false, 30, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_TimestampOut = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_TimestampOut", idtp_TimestampOut.LabelText, Attendance.COL_DB_TimestampOut, true, @"dd/MM/yy  HH:mm", true, false, 30, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Flag1 = base.addColumn<DataGridViewCheckBoxCell>(dgv, "col_dgv_Flag1", Attendance.COL_DB_Flag1, Attendance.COL_DB_Flag1, true, "", true, false, 50, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Flag2 = base.addColumn<DataGridViewCheckBoxCell>(dgv, "col_dgv_Flag2", Attendance.COL_DB_Flag2, Attendance.COL_DB_Flag2, true, "", true, false, 50, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Approved = base.addColumn<DataGridViewCheckBoxCell>(dgv, "col_dgv_Approved", Attendance.COL_DB_Approved, Attendance.COL_DB_Approved, true, "", true, false, 60, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Notes = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Notes", itxt_Notes.LabelText, Attendance.COL_DB_Notes, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            ptInputPanel.PerformClick();
        }

        protected override void additionalSettings() { }

        protected override void clearInputFields()
        {
            itxt_UserAccount.reset();
            itxt_UserAccount.Enabled = true;
            idtp_TimestampIn.Value = DateTime.Now;
            idtp_TimestampOut.Value = DateTime.Now;
            itxt_Notes.reset();
        }

        protected override bool isValidToPopulateGridViewDataSource()
        {
            return true;
        }

        protected override System.Data.DataView loadGridviewDataSource()
        {
            return Attendance.get(null,
                itxt_UserAccount.ValueGuid,
                itxt_Notes.ValueText
                ).DefaultView;
        }

        protected override void populateInputFields()
        {
            Attendance obj = new Attendance(selectedRowID());
            itxt_UserAccount.setValue(obj.UserAccounts_Fullname, obj.UserAccounts_Id);
            idtp_TimestampIn.Value = obj.TimestampIn;
            idtp_TimestampOut.Value = obj.TimestampOut;
            itxt_Notes.ValueText = obj.Notes;
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
                (DateTime)idtp_TimestampIn.Value,
                (DateTime)idtp_TimestampOut.Value,
                itxt_Notes.ValueText);
        }

        protected override Boolean isInputFieldsValid()
        {
            Util.sanitize(itxt_Notes);
            if (itxt_UserAccount.ValueGuid == null)
                return itxt_UserAccount.isValueError("Please select a User");
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
                Attendance.updateFlag1Status(UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgv, col_dgv_Id), !Util.getCheckboxValue(sender, e));
                populateGridViewDataSource(true);
            }
            else if (Util.isColumnMatch(sender, e, col_dgv_Flag2))
            {
                Attendance.updateFlag2Status(UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgv, col_dgv_Id), !Util.getCheckboxValue(sender, e));
                populateGridViewDataSource(true);
            }
            else if (Util.isColumnMatch(sender, e, col_dgv_Approved))
            {
                Attendance.updateApprovedStatus(UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgv, col_dgv_Id), !Util.getCheckboxValue(sender, e));
                populateGridViewDataSource(true);
            }
            base.virtual_dgv_CellContentClick(sender, e);
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
            var form = new LOGIN.MasterData_v1_UserAccounts_Form(FormModes.Browse, false);
            Util.displayForm(null, form);
            if (form.DialogResult == DialogResult.OK)
                itxt_UserAccount.setValue(form.BrowsedItemSelectionDescription, form.BrowsedItemSelectionId);
        }

        private void idtp_TimestampIn_Load(object sender, EventArgs e)
        {

        }

        private void idtp_TimestampOut_Load(object sender, EventArgs e)
        {

        }

        private void itxt_Notes_isBrowseMode_Clicked(object sender, EventArgs e)
        {

        }

        private void idtp_TimestampIn_ValueChanged(object sender, EventArgs e)
        {
            idtp_TimestampOut.Value = idtp_TimestampIn.Value;
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
