﻿using System;
using System.Windows.Forms;

using LIBUtil;
using LOGIN;
using LOGGING;
using HR_LIB.HR;

namespace HR_Desktop.Admin
{
    public partial class MasterData_v1_BankAccounts_Form : LIBUtil.Desktop.Forms.MasterData_v1_Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private const bool FORM_SHOWDATAONLOAD = true;

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private DataGridViewColumn col_dgv_Name;
        private DataGridViewColumn col_dgv_Owner_Clients;
        private DataGridViewColumn col_dgv_Owner_UserAccounts;
        private DataGridViewColumn col_dgv_BankName;
        private DataGridViewColumn col_dgv_AccountNumber;
        private DataGridViewColumn col_dgv_Notes;
        private DataGridViewColumn col_dgv_Internal;

        private bool _internal;
        private Guid? _Owner_RefId;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public MasterData_v1_BankAccounts_Form() : this(FormModes.Add, null, null) { }
        public MasterData_v1_BankAccounts_Form(FormModes startingMode, bool? @internal, Guid? Owner_RefId) : base(startingMode, FORM_SHOWDATAONLOAD)
        {
            InitializeComponent();
            if(@internal != null)
                _internal = (bool)@internal;

            if (Owner_RefId != null)
                _Owner_RefId = Owner_RefId;
        }
        
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
            setColumnsDataPropertyNames(BankAccount.COL_DB_Id, BankAccount.COL_DB_Active, null, null, null, null);

            col_dgv_Name = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Name", itxt_Name.LabelText, BankAccount.COL_DB_Name, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Owner_Clients = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Owner_Clients", rbClient.Text, BankAccount.COL_Clients_CompanyName, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Owner_UserAccounts = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Owner_UserAccounts", rbUserAccount.Text, BankAccount.COL_UserAccounts_Fullname, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_BankName = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_BankName", itxt_BankName.LabelText, BankAccount.COL_DB_BankName, true, true, "", true, false, 70, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_AccountNumber = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_AccountNumber", itxt_AccountNumber.LabelText, BankAccount.COL_DB_AccountNumber, true, true, "", true, false, 70, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Notes", itxt_Notes.LabelText, BankAccount.COL_DB_Notes, true, true, "", true, false, 30, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Internal = base.addColumn<DataGridViewCheckBoxCell>(dgv, "col_dgv_Internal", "Internal", BankAccount.COL_DB_Internal, true, true, "", false, true, 50, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        protected override void additionalSettings() { }

        protected override void clearInputFields()
        {
            rbClient.Checked = false;
            rbUserAccount.Checked = false;
            itxt_Name.reset();
            itxt_Owner_Ref.reset();
            itxt_BankName.reset();
            itxt_AccountNumber.reset();
            itxt_Notes.reset();
        }

        protected override bool isValidToPopulateGridViewDataSource()
        {
            return true;
        }

        protected override System.Data.DataView loadGridviewDataSource()
        {

            return BankAccount.get(chkIncludeInactive.Checked,
                    null,
                    getFilterValue<string>(itxt_Name),
                    getFilterValue<Guid?>(itxt_Owner_Ref),
                    getFilterValue<string>(itxt_BankName),
                    getFilterValue<string>(itxt_AccountNumber),
                    getFilterValue<string>(itxt_Notes),
                    _internal, null
                    ).DefaultView;
        }

        protected override void populateInputFields()
        {
            BankAccount obj = new BankAccount(selectedRowID());
            itxt_Name.ValueText = obj.Name;
            if (!string.IsNullOrEmpty(obj.Clients_CompanyName))
            {
                rbClient.Checked = true;
                itxt_Owner_Ref.setValue(obj.Clients_CompanyName, obj.Owner_RefId);      
            }
            else
            {
                rbUserAccount.Checked = true;
                itxt_Owner_Ref.setValue(obj.UserAccounts_Fullname, obj.Owner_RefId);   
            }
            itxt_BankName.ValueText = obj.BankName;
            itxt_AccountNumber.ValueText = obj.AccountNumber;
            itxt_Notes.ValueText = obj.Notes;
        }

        protected override void update()
        {
            BankAccount.update(UserAccount.LoggedInAccount.Id,
                selectedRowID(),
                itxt_Name.ValueText,
                (Guid)itxt_Owner_Ref.ValueGuid,
                itxt_BankName.ValueText,
                itxt_AccountNumber.ValueText,
                itxt_Notes.ValueText
                );
        }

        protected override void updateActiveStatus(Guid id, Boolean activeStatus)
        {
            BankAccount.updateActiveStatus(UserAccount.LoggedInAccount.Id, id, activeStatus);
        }

        protected override void add()
        {
            BankAccount.add(UserAccount.LoggedInAccount.Id,
                itxt_Name.ValueText,
                (Guid)itxt_Owner_Ref.ValueGuid,
                itxt_BankName.ValueText,
                itxt_AccountNumber.ValueText,
                itxt_Notes.ValueText
                );
        }

        protected override Boolean isInputFieldsValid()
        {
            Util.sanitize(itxt_Name, itxt_BankName, itxt_AccountNumber,  itxt_Notes);
            if (string.IsNullOrEmpty(itxt_Name.ValueText))
                return itxt_Name.isValueError("Please fill a Name");
            else if (itxt_Owner_Ref.ValueGuid == null)
                return itxt_Owner_Ref.isValueError("Please select an Owner (Client/User)");
            else if (string.IsNullOrEmpty(itxt_BankName.ValueText))
                return itxt_BankName.isValueError("Please fill Bank name");
            else if (string.IsNullOrEmpty(itxt_AccountNumber.ValueText))
                return itxt_AccountNumber.isValueError("Please fill account number");
            else if ((Mode != FormModes.Update && BankAccount.isCombinationExist(null,(Guid)itxt_Owner_Ref.ValueGuid, itxt_AccountNumber.ValueText))
                    || (Mode == FormModes.Update && BankAccount.isCombinationExist(selectedRowID(), (Guid)itxt_Owner_Ref.ValueGuid, itxt_AccountNumber.ValueText)))
                return itxt_Name.isValueError("BankAccount combination exists. Please change Owner/Account Number.");

            return true;
        }

        protected override void btnLog_Click(object sender, EventArgs e)
        {
            Util.displayForm(null, new LOGGING.ActivityLogs_Form(UserAccount.LoggedInAccount,selectedRowID()));
            txtQuickSearch.Focus();
        }

        protected override void updateDefaultRow(Guid id) { }

        protected override string getSelectedItemDescription(int rowIndex)
        {
            return string.Format("{0} - {1} {2} - {3}",
                Util.getSelectedRowValue(dgv, col_dgv_Name),
                Util.getSelectedRowValue(dgv, col_dgv_Owner_Clients),
                Util.getSelectedRowValue(dgv, col_dgv_Owner_UserAccounts),
                Util.getSelectedRowValue(dgv, col_dgv_AccountNumber)
                );
        }

        protected override void virtual_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Util.isColumnMatch(sender, e, col_dgv_Internal))
            {
                BankAccount.updateInternalStatus(UserAccount.LoggedInAccount.Id, selectedRowID(), !Util.getCheckboxValue(sender, e));
                populateGridViewDataSource(true);
            }
        }


        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            base.btnUpdate_Click(sender, e);
        }

        private void itxt_Owner_Ref_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            if (rbClient.Checked)
                LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new Admin.MasterData_v1_Clients_Form(FormModes.Browse, null), ref sender);
            else if (rbUserAccount.Checked)
                LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new LOGIN.MasterData_v1_UserAccounts_Form(FormModes.Browse, false), ref sender);
            else
                itxt_Owner_Ref.isValueError("Please choose Client/User");
        }

        private void rbOwner_CheckedChanged(object sender, EventArgs e)
        {
            itxt_Owner_Ref.reset();
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            if (_Owner_RefId != null)
            {
                FormModes originalMode = Mode;

                //open input container
                if (scMain.Panel1Collapsed)
                    ptInputPanel.toggle();

                //change mode to filter
                btnSearch.PerformClick();

                //set filter values to control
                rbClient.Checked = true;
                itxt_Owner_Ref.setValue(new Client((Guid)_Owner_RefId).CompanyName, (Guid)_Owner_RefId);
                if (String.IsNullOrEmpty(itxt_Owner_Ref.ValueText))
                {
                    rbUserAccount.Checked = true;
                    itxt_Owner_Ref.setValue(new UserAccount((Guid)_Owner_RefId).Fullname, (Guid)_Owner_RefId);

                }

                //save filter values
                btnSubmit.PerformClick();

                //change mode to original state
                Mode = originalMode;
            }
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
