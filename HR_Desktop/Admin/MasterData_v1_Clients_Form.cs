using System;
using System.Data;
using System.Windows.Forms;

using LIBUtil;
using LOGIN;
using LOGGING;
using HR_LIB.HR;

namespace HR_Desktop.Admin
{
    public partial class MasterData_v1_Clients_Form : LIBUtil.Desktop.Forms.MasterData_v1_Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private const bool FORM_SHOWDATAONLOAD = true;

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private DataGridViewColumn col_dgv_CompanyName;
        private DataGridViewColumn col_dgv_Address;
        private DataGridViewColumn col_dgv_BillingAddress;
        private DataGridViewColumn col_dgv_ContactPersonName;
        private DataGridViewColumn col_dgv_Phone1;
        private DataGridViewColumn col_dgv_Phone2;
        private DataGridViewColumn col_dgv_NPWP;
        private DataGridViewColumn col_dgv_NPWPAddress;
        private DataGridViewColumn col_dgv_Notes;

        private Guid? _UserAccounts_Id = null;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public MasterData_v1_Clients_Form() : this(FormModes.Add, null) { }
        public MasterData_v1_Clients_Form(FormModes startingMode, Guid? Employee_Id) : base(startingMode, FORM_SHOWDATAONLOAD)
        {
            InitializeComponent();
            if (Employee_Id != null)
                    _UserAccounts_Id = (Guid)Employee_Id;

        }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region OVERRIDE METHODS

        protected override void setupControlsBasedOnRoles()
        {

        }

        protected override void setupFields()
        {
            setColumnsDataPropertyNames(Client.COL_DB_Id, Client.COL_DB_Active, null, null, null, null);

            col_dgv_CompanyName = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_CompanyName", itxt_CompanyName.LabelText, Client.COL_DB_CompanyName, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Address = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Address", itxt_Address.LabelText, Client.COL_DB_Address, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_BillingAddress = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_BillingAddress", itxt_BillingAddress.LabelText, Client.COL_DB_BillingAddress, true, "", true, false, 100, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_ContactPersonName = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_ContactPersonName", itxt_ContactPersonName.LabelText, Client.COL_DB_ContactPersonName, true, "", true, true, 40, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Phone1 = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Phone1", itxt_Phone1.LabelText, Client.COL_DB_Phone1, true, "", true, false, 55, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Phone2 = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Phone2", itxt_Phone2.LabelText, Client.COL_DB_Phone2, true, "", true, false, 55, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_NPWP = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_NPWP", itxt_NPWP.LabelText, Client.COL_DB_NPWP, true, "", true, true, 40, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_NPWPAddress = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_NPWPAddress", itxt_NPWPAddress.LabelText, Client.COL_DB_NPWPAddress, true, "", true, false, 110, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Notes", itxt_Notes.LabelText, Client.COL_DB_Notes, true, "", false, true, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (Mode == FormModes.Browse)
                btnProfile.Visible = false;

            ptInputPanel.PerformClick();
        }

        protected override void additionalSettings()
        {

        }

        protected override void clearInputFields()
        {
            itxt_CompanyName.reset();
            itxt_Address.reset();
            itxt_BillingAddress.reset();
            itxt_ContactPersonName.reset();
            itxt_Phone1.reset();
            itxt_Phone2.reset();
            itxt_NPWP.reset();
            itxt_NPWPAddress.reset();
            itxt_Notes.reset();
        }

        protected override bool isValidToPopulateGridViewDataSource() { return true; }

        protected override System.Data.DataView loadGridviewDataSource()
        {
                return Client.get(chkIncludeInactive.Checked, null, itxt_CompanyName.ValueText, itxt_Address.ValueText, itxt_BillingAddress.ValueText,
                    itxt_ContactPersonName.ValueText, itxt_Phone1.ValueText, itxt_Phone2.ValueText, itxt_NPWP.ValueText, itxt_NPWPAddress.ValueText,
                    itxt_Notes.ValueText, _UserAccounts_Id).DefaultView;
        }

        protected override void populateInputFields()
        {
            Client obj = new Client(selectedRowID());
            itxt_CompanyName.ValueText = obj.CompanyName;
            itxt_Address.ValueText = obj.Address;
            itxt_BillingAddress.ValueText = obj.BillingAddress;
            itxt_ContactPersonName.ValueText = obj.ContactPersonName;
            itxt_Phone1.ValueText = obj.Phone1;
            itxt_Phone2.ValueText = obj.Phone2;
            itxt_NPWP.ValueText = obj.NPWP;
            itxt_NPWPAddress.ValueText = obj.NPWPAddress;
            itxt_Notes.ValueText = obj.Notes;

        }

        protected override void update()
        {
            Client.update(UserAccount.LoggedInAccount.Id, selectedRowID(), itxt_CompanyName.ValueText, itxt_Address.ValueText,
                itxt_BillingAddress.ValueText, itxt_ContactPersonName.ValueText, itxt_Phone1.ValueText, itxt_Phone2.ValueText,
                itxt_NPWP.ValueText, itxt_NPWPAddress.ValueText, itxt_Notes.ValueText);
        }

        protected override void add()
        {
            Client.add(UserAccount.LoggedInAccount.Id, itxt_CompanyName.ValueText, itxt_Address.ValueText,
                itxt_BillingAddress.ValueText, itxt_ContactPersonName.ValueText, itxt_Phone1.ValueText, itxt_Phone2.ValueText,
                itxt_NPWP.ValueText, itxt_NPWPAddress.ValueText, itxt_Notes.ValueText);
        }

        protected override Boolean isInputFieldsValid()
        {
            Util.sanitize(itxt_CompanyName, itxt_Address, itxt_BillingAddress, itxt_ContactPersonName, itxt_Phone1, itxt_Phone2, itxt_NPWP, itxt_NPWPAddress, itxt_Notes);
            if (string.IsNullOrEmpty(itxt_CompanyName.ValueText))
                return itxt_CompanyName.isValueError("Please fill Company Name");
            else if ((Mode != FormModes.Update && Client.isCompanyNameExist(itxt_CompanyName.ValueText, null))
                || (Mode == FormModes.Update && Client.isCompanyNameExist(itxt_CompanyName.ValueText, selectedRowID())))
                return itxt_CompanyName.isValueError("Company Name is already in the list");

            return true;
        }

        protected override void updateActiveStatus(Guid id, Boolean activeStatus)
        {
            Client.updateActiveStatus(UserAccount.LoggedInAccount.Id, id, activeStatus);
        }

        protected override void updateDefaultRow(Guid id) { }

        protected override string getSelectedItemDescription(int rowIndex)
        {
            return string.Format("{0}",
                Util.getSelectedRowValue(dgv, col_dgv_CompanyName)
                );
        }

        protected override void btnLog_Click(object sender, EventArgs e)
        {
            Util.displayForm(null, new LOGGING.ActivityLogs_Form(UserAccount.LoggedInAccount, selectedRowID()));
            txtQuickSearch.Focus();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Util.displayForm(null, new Admin.Clients_Profile_Form(selectedRowID()));
        }

        #endregion
        /*******************************************************************************************************/
        #region METHODS

        #endregion
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
