﻿using System;
using System.Windows.Forms;
using LIBUtil;
using HR_LIB.HR;
using LOGIN;

namespace HR_Desktop.Admin
{
    public partial class MasterData_v1_AttendanceStatuses_Form : LIBUtil.Desktop.Forms.MasterData_v1_Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private const bool FORM_SHOWDATAONLOAD = true;

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private DataGridViewColumn col_dgv_Name;
        private DataGridViewColumn col_dgv_Notes;
        private DataGridViewColumn col_dgv_IsReplace;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public MasterData_v1_AttendanceStatuses_Form() : this(FormModes.Add) { }
        public MasterData_v1_AttendanceStatuses_Form(FormModes startingMode) : base(startingMode, FORM_SHOWDATAONLOAD) { InitializeComponent(); }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        #endregion METHODS
        /*******************************************************************************************************/
        #region OVERRIDE METHODS

        protected override void setupFields()
        {

            setColumnsDataPropertyNames(AttendanceStatus.COL_DB_Id, AttendanceStatus.COL_DB_Active, null, null, null, null);
            col_dgv_Name = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Name", itxt_Name.LabelText, AttendanceStatus.COL_DB_Name, true, true, "", true, false, null, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Notes", itxt_Notes.LabelText, AttendanceStatus.COL_DB_Notes, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_IsReplace = base.addColumn<DataGridViewCheckBoxCell>(dgv, "col_dgv_IsReplace", "Replace", AttendanceStatus.COL_DB_IsReplace, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            ptInputPanel.PerformClick();
        }

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
            return AttendanceStatus.get(chkIncludeInactive.Checked, null,
                getFilterValue<string>(itxt_Name),
                getFilterValue<string>(itxt_Notes)
                ).DefaultView;

        }

        protected override void populateInputFields()
        {
            AttendanceStatus obj = new AttendanceStatus(selectedRowID());
            itxt_Name.ValueText = obj.Name;
            itxt_Notes.ValueText = obj.Notes;
        }

        protected override void update()
        {
            AttendanceStatus.update(UserAccount.LoggedInAccount.Id,
                selectedRowID(),
                itxt_Name.ValueText,
                itxt_Notes.ValueText);
        }

        protected override void add()
        {
            AttendanceStatus.add(UserAccount.LoggedInAccount.Id,
                itxt_Name.ValueText,
                itxt_Notes.ValueText);
        }

        protected override Boolean isInputFieldsValid()
        {
            Util.sanitize(itxt_Name, itxt_Notes);
            if (string.IsNullOrEmpty(itxt_Name.ValueText))
                return itxt_Name.isValueError("Please provide name");
            else if ((Mode != FormModes.Update && AttendanceStatus.isNameExist(null, itxt_Name.ValueText))
                    || (Mode == FormModes.Update && AttendanceStatus.isNameExist(selectedRowID(), itxt_Name.ValueText)))
                return itxt_Name.isValueError("Name is already in the list.");
            return true;
        }

        protected override void updateActiveStatus(Guid id, Boolean activeStatus)
        {
            AttendanceStatus.updateActiveStatus(UserAccount.LoggedInAccount.Id, id, activeStatus);
        }


        protected override void btnLog_Click(object sender, EventArgs e)
        {
            Util.displayForm(null, new LOGGING.ActivityLogs_Form(UserAccount.LoggedInAccount, selectedRowID()));
            txtQuickSearch.Focus();
        }

        protected override string getSelectedItemDescription(int rowIndex)
        {
            return string.Format("{0}",
                Util.getSelectedRowValue(dgv, col_dgv_Name)
                );
        }

        protected override void virtual_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Util.isColumnMatch(sender, e, col_dgv_IsReplace))
            {
                AttendanceStatus.updateReplaceStatus(UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgv, col_dgv_Id), !Util.getCheckboxValue(sender, e));
                populateGridViewDataSource(true);
            }
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
