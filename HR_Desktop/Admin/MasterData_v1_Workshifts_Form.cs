﻿using System;
using System.Windows.Forms;

using LIBUtil;
using LOGIN;
using LOGGING;
using HR_LIB.HR;

namespace HR_Desktop.Admin
{
    public partial class MasterData_v1_Workshifts_Form : LIBUtil.Desktop.Forms.MasterData_v1_Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private const bool FORM_SHOWDATAONLOAD = true;

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private DataGridViewColumn col_dgv_Name;
        private DataGridViewColumn col_dgv_Clients_CompanyName;
        private DataGridViewColumn col_dgv_WorkshiftCategories_Name;
        private DataGridViewColumn col_dgv_DayOfWeek;
        private DataGridViewColumn col_dgv_Start;
        private DataGridViewColumn col_dgv_End;
        private DataGridViewColumn col_dgv_Notes;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public MasterData_v1_Workshifts_Form() : this(FormModes.Add) { }
        public MasterData_v1_Workshifts_Form(FormModes startingMode) : base(startingMode, FORM_SHOWDATAONLOAD) { InitializeComponent(); }

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

            iddl_DayOfWeek.populate(typeof(DayOfWeek));
            iddl_Start.populateWithTime(0, 0, 23, 0, 60, Workshift.COL_DB_Start, @"{0:h\:mm}");
            iddl_End.populateWithTime(0, 0, 23, 0, 60, Workshift.COL_DB_End, @"{0:h\:mm}");

            setColumnsDataPropertyNames(Workshift.COL_DB_Id, Workshift.COL_DB_Active, null, null, null, null);

            col_dgv_Name = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Name", itxt_Name.LabelText, Workshift.COL_DB_Name, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Clients_CompanyName = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Clients_CompanyName", itxt_Clients.LabelText, Workshift.COL_Clients_CompanyName, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_WorkshiftCategories_Name = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_WorkshiftCategories_Name", itxt_WorkshiftCategories.LabelText, Workshift.COL_WorkshiftCategories_Name, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_DayOfWeek = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_DayOfWeek", iddl_DayOfWeek.LabelText, Workshift.COL_DayOfWeekName, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Start = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Start", iddl_Start.LabelText, Workshift.COL_DB_Start, true, @"h\:mm", true, false, 50, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_End = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_End", iddl_End.LabelText, Workshift.COL_DB_End, true, @"h\:mm", true, false, 50, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Notes = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Notes", itxt_Notes.LabelText, Workshift.COL_DB_Notes, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void additionalSettings() { }

        protected override void clearInputFields()
        {
            itxt_Name.reset();
            itxt_Clients.Enabled = true;
            itxt_Clients.reset();
            itxt_WorkshiftCategories.Enabled = true;
            itxt_WorkshiftCategories.reset();
            iddl_DayOfWeek.Enabled = true;
            iddl_DayOfWeek.reset();
            iddl_Start.Enabled = true;
            iddl_Start.reset();
            iddl_End.Enabled = true;
            iddl_End.reset();
            itxt_Notes.reset();
        }

        protected override bool isValidToPopulateGridViewDataSource()
        {
            return true;
        }

        protected override System.Data.DataView loadGridviewDataSource()
        {
            return Workshift.get(chkIncludeInactive.Checked, null,
                itxt_Name.ValueText,
                itxt_Clients.ValueGuid,
                itxt_WorkshiftCategories.ValueGuid,
                Util.wrapNullable<int?>(iddl_DayOfWeek.SelectedValue),
                Util.wrapNullable<string>(iddl_Start.SelectedValue),
                Util.wrapNullable<string>(iddl_End.SelectedValue),
                Util.wrapNullable<string>(itxt_Notes.ValueText)
                ).DefaultView;
        }

        protected override void populateInputFields()
        {
            Workshift obj = new Workshift(selectedRowID());
            itxt_Name.ValueText = obj.Name;
            itxt_Clients.setValue(obj.Clients_CompanyName, obj.Clients_Id);
            itxt_WorkshiftCategories.setValue(obj.WorkshiftCategories_Name, obj.WorkshiftCategories_Id);
            iddl_DayOfWeek.SelectedItem = obj.DayOfWeek;
            iddl_Start.SelectedValue = obj.Start.ToString(@"h\:mm");
            iddl_End.SelectedValue = obj.End.ToString(@"h\:mm");
            itxt_Notes.ValueText = obj.Notes;
        }

        protected override void update()
        {
            Workshift.update(UserAccount.LoggedInAccount.Id,
                selectedRowID(),
                itxt_Name.ValueText,
                (Guid)itxt_WorkshiftCategories.ValueGuid,
                (DayOfWeek)iddl_DayOfWeek.SelectedValue,
                iddl_Start.SelectedValue.ToString(),
                iddl_End.SelectedValue.ToString(),
                itxt_Notes.ValueText);
        }

        protected override void add()
        {
            Workshift.add(UserAccount.LoggedInAccount.Id,
                itxt_Name.ValueText,
                (Guid)itxt_Clients.ValueGuid,
                (Guid)itxt_WorkshiftCategories.ValueGuid,
                (DayOfWeek)iddl_DayOfWeek.SelectedValue,
                iddl_Start.SelectedValue.ToString(),
                iddl_End.SelectedValue.ToString(),
                itxt_Notes.ValueText);
        }

        protected override Boolean isInputFieldsValid()
        {
            Util.sanitize(itxt_Name, itxt_Notes);
            if (string.IsNullOrEmpty(itxt_Name.ValueText))
                return itxt_Name.isValueError("Please fill Workshift Name");
            else if (itxt_Clients.ValueGuid == null)
                return itxt_Clients.isValueError("Please select a Client");
            else if (itxt_WorkshiftCategories.ValueGuid == null)
                return itxt_WorkshiftCategories.isValueError("Please select a Workshift Category");
            else if (!iddl_DayOfWeek.hasSelectedValue())
                return iddl_DayOfWeek.SelectedValueError("Please select the day.");
            else if (!iddl_Start.hasSelectedValue())
                return iddl_Start.SelectedValueError("Please select start time.");
            else if (!iddl_End.hasSelectedValue())
                return iddl_End.SelectedValueError("Please select end time.");
            else if (!iddl_End.isValidEndTime(iddl_Start))
                return iddl_End.SelectedValueError("Invalid End Time. Must be later than Start Time");
            else if ((Mode != FormModes.Update && Workshift.isCombinationExist(null,itxt_Name.ValueText, (Guid)itxt_Clients.ValueGuid, Util.parseEnum<DayOfWeek>(iddl_DayOfWeek.SelectedValue), iddl_Start.SelectedValue.ToString()))
                    || (Mode == FormModes.Update && Workshift.isCombinationExist(selectedRowID(), itxt_Name.ValueText, (Guid)itxt_Clients.ValueGuid, Util.parseEnum<DayOfWeek>(iddl_DayOfWeek.SelectedValue), iddl_Start.SelectedValue.ToString())))
                return iddl_DayOfWeek.SelectedValueError("Workshift combination exists. Please change Name/Client/Day/Start.");

            return true;
        }

        protected override void updateActiveStatus(Guid id, Boolean activeStatus)
        {
            Workshift.updateActiveStatus(UserAccount.LoggedInAccount.Id, id, activeStatus);
        }

        protected override void btnLog_Click(object sender, EventArgs e)
        {
            Util.displayForm(null, new LOGGING.ActivityLogs_Form(UserAccount.LoggedInAccount,selectedRowID()));
            txtQuickSearch.Focus();
        }

        protected override void updateDefaultRow(Guid id) { }

        protected override string getSelectedItemDescription(int rowIndex)
        {
            return string.Format("{0} - {1} Day : {2} Shift : {3} - {4}",
                Util.getSelectedRowValue(dgv, col_dgv_Name),
                Util.getSelectedRowValue(dgv, col_dgv_Clients_CompanyName),
                Util.getSelectedRowValue(dgv, col_dgv_DayOfWeek),
                Util.getSelectedRowValue(dgv, col_dgv_Start),
                Util.getSelectedRowValue(dgv, col_dgv_End)
                );
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            itxt_Clients.Enabled = false;

            base.btnUpdate_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Workshift.delete(UserAccount.LoggedInAccount.Id, selectedRowID());
            populateGridViewDataSource(true);
        }

        private void itxt_Clients_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            var form = new Admin.MasterData_v1_Clients_Form(FormModes.Browse);
            Util.displayForm(null, form);
            if (form.DialogResult == DialogResult.OK)
                itxt_Clients.setValue(form.BrowsedItemSelectionDescription, form.BrowsedItemSelectionId);
        }

        private void itxt_WorkshiftCategories_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            var form = new Admin.MasterData_v1_WorkshiftCategories_Form(FormModes.Browse);
            Util.displayForm(null, form);
            if (form.DialogResult == DialogResult.OK)
                itxt_WorkshiftCategories.setValue(form.BrowsedItemSelectionDescription, form.BrowsedItemSelectionId);
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}