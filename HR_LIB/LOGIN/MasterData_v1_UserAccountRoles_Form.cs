using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using LIBUtil;

namespace LOGIN
{
    public partial class MasterData_v1_UserAccountRoles_Form : LIBUtil.Desktop.Forms.MasterData_v1_Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private const bool FORM_SHOWDATAONLOAD = true;

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private DataGridViewColumn col_dgv_Name;
        private DataGridViewColumn col_dgv_Notes;
        private DataGridViewColumn col_dgv_Special;
        Dictionary<UserAccountAccessEnum, CheckBox> _userAccountAccessDictionary = new Dictionary<UserAccountAccessEnum, CheckBox>();

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public MasterData_v1_UserAccountRoles_Form() : this(FormModes.Add) { }
        public MasterData_v1_UserAccountRoles_Form(FormModes startingMode) : base(startingMode, FORM_SHOWDATAONLOAD) { InitializeComponent(); }
        
        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private List<int> getSelectedUserAccountAccessEnum()
        {
            List<int> selected = new List<int>();

            foreach(object obj in pnlUserAccountAccesses.Controls)
                if(obj.GetType() == typeof(CheckBox) && ((CheckBox)obj).Checked)
                {
                    CheckBox chk = (CheckBox)obj;
                    var aa = _userAccountAccessDictionary.FirstOrDefault(x => x.Value == obj).Key;
                    int enumId = (int)aa;

                    selected.Add(enumId);
                }

            return selected;
        }

        private void clearUserAccountAccessTree()
        {
            chkSelectAll.Checked = false;
            foreach (object obj in pnlUserAccountAccesses.Controls)
                if (obj.GetType() == typeof(CheckBox))
                    ((CheckBox)obj).Checked = false;
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region OVERRIDE METHODS

        protected override void setupFields()
        {
            setColumnsDataPropertyNames(UserAccountRole.COL_DB_Id, UserAccountRole.COL_DB_Active, null, null, null, null);

            col_dgv_Name = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Name", itxt_Name.LabelText, UserAccountRole.COL_DB_Name, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Notes", itxt_Notes.LabelText, UserAccountRole.COL_DB_Notes, true, "", false, true, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_dgv_Special = base.addColumn<DataGridViewCheckBoxCell>(dgv, "col_dgv_Special", "Special", UserAccountRole.COL_DB_Special, true, "", false, true, 50, DataGridViewContentAlignment.MiddleCenter);

            _userAccountAccessDictionary.Add(UserAccountAccessEnum.UserAccounts_View, chkUserAccountView);
            _userAccountAccessDictionary.Add(UserAccountAccessEnum.UserAccounts_AddUpdate, chkUserAccountAddUpdate);
            _userAccountAccessDictionary.Add(UserAccountAccessEnum.UserAccountRoles_AddUpdate, chkUserAccountRolesAddUpdate);
            
            _userAccountAccessDictionary.Add(UserAccountAccessEnum.Finance_ConfirmPayments, chkUserFinancialConfirmPayments);

            _userAccountAccessDictionary.Add(UserAccountAccessEnum.FinancialReports_View, chkUserFinancialReportView);
            _userAccountAccessDictionary.Add(UserAccountAccessEnum.FinancialReports_Add, chkUserFinancialReportAdd);
            _userAccountAccessDictionary.Add(UserAccountAccessEnum.FinancialReports_Update, chkUserFinancialReportUpdate);
        }

        protected override void additionalSettings() { }

        protected override void clearInputFields()
        {
            itxt_Name.reset();
            itxt_Notes.reset();
            clearUserAccountAccessTree();
        }

        protected override bool isValidToPopulateGridViewDataSource()
        {
            return true; 
        }

        protected override System.Data.DataView loadGridviewDataSource()
        {
            return UserAccountRole.get(chkIncludeInactive.Checked, true, null, itxt_Name.ValueText, itxt_Notes.ValueText).DefaultView;
        }
        
        protected override void populateInputFields()
        {
            UserAccountRole obj = new UserAccountRole(selectedRowID());
            itxt_Name.ValueText = obj.Name;
            itxt_Notes.ValueText = obj.Notes;

            //populate access tree
            clearUserAccountAccessTree();
            DataTable accesses = UserAccountAccessRoleAssignment.getByUserAccountRoleId(obj.Id);
            CheckBox checkbox;
            foreach(DataRow row in accesses.Rows)
            {
                _userAccountAccessDictionary.TryGetValue(Util.parseEnum<UserAccountAccessEnum>(row[UserAccountAccessRoleAssignment.COL_DB_UserAccountAccess_EnumId]), out checkbox);
                checkbox.Checked = true;
            }
        }

        protected override void update()
        {
            UserAccountRole.update(UserAccount.LoggedInAccount.Id, selectedRowID(), itxt_Name.ValueText, itxt_Notes.ValueText, getSelectedUserAccountAccessEnum());
        }

        protected override void add()
        {
            UserAccountRole.add(UserAccount.LoggedInAccount.Id, itxt_Name.ValueText, itxt_Notes.ValueText, getSelectedUserAccountAccessEnum());
        }

        protected override Boolean isInputFieldsValid()
        {
            if (string.IsNullOrEmpty(itxt_Name.ValueText))
                return itxt_Name.isValueError("Please provide name");
            //else if ((Mode != FormMode.Update && City.isNameExist(_inputTxtName.ValueText, null))
            //    || (Mode == FormMode.Update && City.isNameExist(_inputTxtName.ValueText, selectedRowID())))
            //    return _inputTxtName.TextError("Name is already in the list");
            //else if (_inputDDLStates.SelectedValue == null)
            //    return _inputDDLStates.SelectedValueError("Please select a state listed in the drop down list");

            return true;
        }

        protected override void updateActiveStatus(Guid id, Boolean activeStatus)
        {
            UserAccountRole.updateActiveStatus(UserAccount.LoggedInAccount.Id, id, activeStatus);
        }
        
        protected override void btnLog_Click(object sender, EventArgs e)
        {
            Util.displayForm(null, new LOGGING.ActivityLogs_Form(UserAccount.LoggedInAccount, selectedRowID()));
            txtQuickSearch.Focus();
        }

        protected override void updateDefaultRow(Guid id) { }

        protected override void virtual_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Util.isColumnMatch(sender, e, col_dgv_Special))
            {
                UserAccountRole.updateSpecialStatus(UserAccount.LoggedInAccount.Id, selectedRowID(), !Util.getCheckboxValue(sender, e));
                populateGridViewDataSource(true);
            }
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS       

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            foreach (Control control in pnlUserAccountAccesses.Controls)
            {
                if (control.GetType() == typeof(CheckBox) && control != checkbox)
                {
                    ((CheckBox)control).Checked = checkbox.Checked;
                }
            }
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
