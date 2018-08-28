using System;
using System.Windows.Forms;
using LIBUtil;
using HR_LIB.HR;
using LOGIN;

namespace HR_Desktop.Admin
{
    public partial class MasterData_v1_WorkshiftCategories_Form : LIBUtil.Desktop.Forms.MasterData_v1_Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private const bool FORM_SHOWDATAONLOAD = true;

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private DataGridViewColumn col_dgv_Name;
        private DataGridViewColumn col_dgv_Notes;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public MasterData_v1_WorkshiftCategories_Form() : this(FormModes.Add) { }
        public MasterData_v1_WorkshiftCategories_Form(FormModes startingMode) : base(startingMode, FORM_SHOWDATAONLOAD) { InitializeComponent(); }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        #endregion METHODS
        /*******************************************************************************************************/
        #region OVERRIDE METHODS

        protected override void setupFields()
        {

            setColumnsDataPropertyNames(WorkshiftCategory.COL_DB_Id, WorkshiftCategory.COL_DB_Active, null, null, null, null);
            col_dgv_Name = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Name", itxt_Name.LabelText, WorkshiftCategory.COL_DB_Name, true, true, "", true, false, null, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Notes", itxt_Notes.LabelText, WorkshiftCategory.COL_DB_Notes, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            ptInputPanel.PerformClick();
        }

        protected override void additionalSettings() { }

        protected override void clearInputFields()
        {
            itxt_Name.reset();
            itxt_Notes.reset();
        }

        protected override bool isValidToPopulateGridViewDataSource()
        {
            return true;
        }

        protected override System.Data.DataView loadGridviewDataSource()
        {
            return WorkshiftCategory.get(chkIncludeInactive.Checked, null,
                getFilterValue<string>(itxt_Name),
                getFilterValue<string>(itxt_Notes)
            ).DefaultView;

        }

        protected override void populateInputFields()
        {
            WorkshiftCategory obj = new WorkshiftCategory(selectedRowID());
            itxt_Name.ValueText = obj.Name;
            itxt_Notes.ValueText = obj.Notes;
        }

        protected override void update()
        {
            WorkshiftCategory.update(UserAccount.LoggedInAccount.Id,
                selectedRowID(),
                itxt_Name.ValueText,
                itxt_Notes.ValueText);
        }

        protected override void add()
        {
            WorkshiftCategory.add(UserAccount.LoggedInAccount.Id,
                itxt_Name.ValueText,
                itxt_Notes.ValueText);
        }

        protected override Boolean isInputFieldsValid()
        {
            Util.sanitize(itxt_Name, itxt_Notes);
            if (string.IsNullOrEmpty(itxt_Name.ValueText))
                return itxt_Name.isValueError("Please provide name");
            else if ((Mode != FormModes.Update && WorkshiftCategory.isNameExist(null, itxt_Name.ValueText))
                    || (Mode == FormModes.Update && WorkshiftCategory.isNameExist(selectedRowID(), itxt_Name.ValueText)))
                return itxt_Name.isValueError("Name is already in the list.");
            return true;
        }

        protected override void updateActiveStatus(Guid id, Boolean activeStatus)
        {
            WorkshiftCategory.updateActiveStatus(UserAccount.LoggedInAccount.Id, id, activeStatus);
        }


        protected override void btnLog_Click(object sender, EventArgs e)
        {
            Util.displayForm(null, new LOGGING.ActivityLogs_Form(UserAccount.LoggedInAccount, selectedRowID()));
            txtQuickSearch.Focus();
        }

        protected override void updateDefaultRow(Guid id) { }

        protected override string getSelectedItemDescription(int rowIndex)
        {
            return string.Format("{0}",
                Util.getSelectedRowValue(dgv, col_dgv_Name)
                );
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
