using System;
using System.Data;
using System.Windows.Forms;

using LIBUtil;

namespace LOGIN
{
    public partial class MasterData_v1_UserAccounts_Form : LIBUtil.Desktop.Forms.MasterData_v1_Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private bool _showCurrentUserAccountInfoOnly = false;

        private const bool FORM_SHOWDATAONLOAD = true;

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private DataGridViewColumn col_dgv_Username;
        private DataGridViewColumn col_dgv_Firstname;
        private DataGridViewColumn col_dgv_Lastname;
        private DataGridViewColumn col_dgv_Birthday;
        private DataGridViewColumn col_dgv_Address1;
        private DataGridViewColumn col_dgv_Address2;
        private DataGridViewColumn col_dgv_Email;
        private DataGridViewColumn col_dgv_Phone1;
        private DataGridViewColumn col_dgv_Phone2;
        private DataGridViewColumn col_dgv_Notes;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public MasterData_v1_UserAccounts_Form() : this(FormModes.Add, false) { }
        public MasterData_v1_UserAccounts_Form(bool showCurrentUserAccountInfoOnly) : this(FormModes.Add, showCurrentUserAccountInfoOnly) { }
        public MasterData_v1_UserAccounts_Form(FormModes startingMode, bool showCurrentUserAccountInfoOnly) : base(startingMode, FORM_SHOWDATAONLOAD) 
        { 
            InitializeComponent();
            
            _showCurrentUserAccountInfoOnly = showCurrentUserAccountInfoOnly;
        }
        
        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region OVERRIDE METHODS

        protected override void setupControlsBasedOnRoles() 
        {
            HR_LIB.Helper.hideIfNoAccess(UserAccount.LoggedInAccount, btnRoles, false, UserAccountAccessEnum.UserAccountRoles_AddUpdate);
            HR_LIB.Helper.hideIfNoAccess(UserAccount.LoggedInAccount, col_dgv_Active, false, UserAccountAccessEnum.UserAccountRoles_AddUpdate);
        }

        protected override void setupFields()
        {
            setColumnsDataPropertyNames(UserAccount.COL_DB_Id, UserAccount.COL_DB_Active, null, null, null, null);

            col_dgv_Username = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Username", itxt_Username.LabelText, UserAccount.COL_DB_Username, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            itxt_Username.MaxLength = UserAccount.USERNAME_MAXLENGTH;
            col_dgv_Firstname = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Firstname", itxt_Firstname.LabelText, UserAccount.COL_DB_Firstname, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Lastname = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Lastname", itxt_Lastname.LabelText, UserAccount.COL_DB_Lastname, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Birthday = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Birthday", idtp_Birthdate.LabelText, UserAccount.COL_DB_Birthdate, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Address1 = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Address1", itxt_Address1.LabelText, UserAccount.COL_DB_Address1, true, "", true, true, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Address2 = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Address2", itxt_Address2.LabelText, UserAccount.COL_DB_Address2, true, "", true, true, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Phone1 = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Phone1", itxt_Phone1.LabelText, UserAccount.COL_DB_Phone1, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Phone2 = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Phone2", itxt_Phone2.LabelText, UserAccount.COL_DB_Phone2, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Email = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Email", itxt_Email.LabelText, UserAccount.COL_DB_Email, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Notes", itxt_Notes.LabelText, UserAccount.COL_DB_Notes, true, "", false, true, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            UserAccountRole.populateCheckedListBox(clbUserAccountRoles, false, UserAccount.LoggedInAccount.Special || UserAccount.IsCreateAccount);
        }

        protected override void additionalSettings()
        {
            if (_showCurrentUserAccountInfoOnly)
            {
                scInputContainer.Enabled = false;
                pnlButtons.Visible = false;
                scMain.SplitterDistance -= pnlButtons.Height;

                pnlActionButtons.Visible = false;
                scMain.SplitterDistance -= pnlActionButtons.Height;

                scMain.Panel2.Hide();
                this.Height -= scMain.Panel2.Height;

                Mode = FormModes.Update;
            }
        }

        protected override void clearInputFields()
        {
            itxt_Username.reset();
            itxt_Firstname.reset();
            itxt_Lastname.reset();
            idtp_Birthdate.reset();
            itxt_Address1.reset();
            itxt_Email.reset();
            itxt_Phone1.reset();
            itxt_Phone2.reset();
            itxt_Identification.reset();
            itxt_Height.reset();
            itxt_Weight.reset();
            itxt_Notes.reset();
            LIBUtil.Desktop.UserControls.InputControl_CheckedListBox.clearCheckedItems(clbUserAccountRoles);
        }

        protected override bool isValidToPopulateGridViewDataSource() { return true; }

        protected override System.Data.DataView loadGridviewDataSource()
        {
            DataView dataview;
            if (_showCurrentUserAccountInfoOnly)
                dataview = UserAccount.get(true, UserAccount.LoggedInAccount.Id, null, null, null, null, null, null, null, null, null, null, null, null, null).DefaultView;
            else
                dataview = UserAccount.get(chkIncludeInactive.Checked, null, itxt_Username.ValueText, itxt_Firstname.ValueText, itxt_Lastname.ValueText, 
                    itxt_Address1.ValueText, itxt_Address2.ValueText, itxt_Phone1.ValueText, itxt_Phone2.ValueText, itxt_Email.ValueText, idtp_Birthdate.Value, itxt_Identification.ValueText, itxt_Height.ValueInt, itxt_Weight.ValueInt, itxt_Notes.ValueText).DefaultView;

            btnTutorSchedule.Enabled = dataview.Count > 0;

            return dataview;
        }

        protected override void populateInputFields()
        {
            UserAccount obj = new UserAccount(selectedRowID());
            itxt_Username.ValueText = obj.Username;
            itxt_Firstname.ValueText = obj.Firstname;
            itxt_Lastname.ValueText = obj.Lastname;
            idtp_Birthdate.Value = obj.Birthdate;
            itxt_Address1.ValueText = obj.Address1;
            itxt_Address2.ValueText = obj.Address2;
            itxt_Email.ValueText = obj.Email;
            itxt_Phone1.ValueText = obj.Phone1;
            itxt_Phone2.ValueText = obj.Phone2;
            itxt_Identification.ValueText = obj.Identification;
            itxt_Height.Value = obj.Height;
            itxt_Weight.Value = obj.Weight;
            itxt_Notes.ValueText = obj.Notes;

            LIBUtil.Desktop.UserControls.InputControl_CheckedListBox.clearCheckedItems(clbUserAccountRoles);
            foreach (DataRow row in UserAccountRoleAssignment.getByUserAccountId(obj.Id).Rows)
            {
                for (int i=0; i<clbUserAccountRoles.Items.Count; i++)
                {
                    DataRowView item = (DataRowView)clbUserAccountRoles.Items[i];
                    if (item[UserAccountRole.COL_DB_Id].ToString() == row[UserAccountRoleAssignment.COL_DB_UserAccountRoles_Id].ToString())
                        clbUserAccountRoles.SetItemChecked(i, true);
                }
            }
        }

        protected override void update()
        {
            UserAccount.update(UserAccount.LoggedInAccount.Id, selectedRowID(), itxt_Username.ValueText, itxt_Firstname.ValueText, itxt_Lastname.ValueText,
                itxt_Address1.ValueText, itxt_Address2.ValueText, itxt_Phone1.ValueText, itxt_Phone2.ValueText, itxt_Email.ValueText, idtp_Birthdate.Value, itxt_Identification.ValueText, itxt_Height.ValueInt, itxt_Weight.ValueInt, itxt_Notes.ValueText,
                LIBUtil.Desktop.UserControls.InputControl_CheckedListBox.copySelectionToList<Guid?>(clbUserAccountRoles, UserAccountRole.COL_DB_Id));
        }

        protected override void add()
        {
            Clipboard.SetText(UserAccount.add(UserAccount.LoggedInAccount.Id, itxt_Username.ValueText, HR_LIB.Settings.TEMPORARY_PASSWORD, itxt_Firstname.ValueText, itxt_Lastname.ValueText,
                itxt_Address1.ValueText, itxt_Address2.ValueText, itxt_Phone1.ValueText, itxt_Phone2.ValueText, itxt_Email.ValueText, idtp_Birthdate.Value, itxt_Identification.ValueText, itxt_Height.ValueInt, itxt_Weight.ValueInt, itxt_Notes.ValueText,
                LIBUtil.Desktop.UserControls.InputControl_CheckedListBox.copySelectionToList<Guid?>(clbUserAccountRoles, UserAccountRole.COL_DB_Id)).ToString());
        }

        protected override Boolean isInputFieldsValid()
        {
            if (string.IsNullOrEmpty(itxt_Username.ValueText))
                return itxt_Username.isValueError("Please provide username");
            else if (itxt_Username.Length < 5)
                return itxt_Username.isValueError("Username must be at least 5 characters long");
            else if ((Mode != FormModes.Update && UserAccount.isUsernameExist(itxt_Username.ValueText, null))
                || (Mode == FormModes.Update && UserAccount.isUsernameExist(itxt_Username.ValueText, selectedRowID())))
                return itxt_Username.isValueError("Username is already in the list");
            //else if (_inputDDLStates.SelectedValue == null)
            //    return _inputDDLStates.SelectedValueError("Please select a state listed in the drop down list");

            return true;
        }

        protected override void updateActiveStatus(Guid id, Boolean activeStatus)
        {
            UserAccount.updateActiveStatus(UserAccount.LoggedInAccount.Id, id, activeStatus);
        }

        protected override void updateDefaultRow(Guid id) { }

        protected override void updateCheckbox1Column(Guid id, Boolean newValue) { }

        protected override string getSelectedItemDescription(int rowIndex)
        {
            return ((DataView)dgv.DataSource)[rowIndex][UserAccount.COL_Fullname].ToString();
        }

        protected override void btnLog_Click(object sender, EventArgs e)
        {
            Util.displayForm(null, new LOGGING.ActivityLogs_Form(UserAccount.LoggedInAccount, selectedRowID()));
            txtQuickSearch.Focus();
        }

        #endregion
        /*******************************************************************************************************/
        #region METHODS

        #endregion
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        private void btnRoles_Click(object sender, EventArgs e)
        {
            Util.displayForm(null, new LOGIN.MasterData_v1_UserAccountRoles_Form());
            UserAccountRole.populateCheckedListBox(clbUserAccountRoles, false, true);
        }

        private void btnTutorSchedule_Click(object sender, EventArgs e)
        {

        }

        //private void lnkUpdateStates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    Tools.displayForm(new MasterData.States_Form(FormMode.New));
        //    State.populateDropDownList(_inputDDLStates.Dropdownlist, false, true);
        //}

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
