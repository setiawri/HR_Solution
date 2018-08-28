using System;
using System.Windows.Forms;

using LIBUtil;
using LOGIN;
using LOGGING;
using HR_LIB.HR;

namespace HR_Desktop.Admin
{
    public partial class MasterData_v1_WorkshiftTemplates_Form : LIBUtil.Desktop.Forms.MasterData_v1_Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private const bool FORM_SHOWDATAONLOAD = true;
        private Guid? _Clients_Id = null;
        public Guid? BrowsedItemSelectionValue = null;


        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private DataGridViewColumn col_dgv_Name;
        private DataGridViewColumn col_dgv_Clients_CompanyName;
        private DataGridViewColumn col_dgv_WorkshiftCategories_Name;
        private DataGridViewColumn col_dgv_DayOfWeek;
        private DataGridViewColumn col_dgv_Start;
        private DataGridViewColumn col_dgv_Duration;
        private DataGridViewColumn col_dgv_PayableAmount;
        private DataGridViewColumn col_dgv_Notes;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public MasterData_v1_WorkshiftTemplates_Form() : this(FormModes.Add, null) { }
        public MasterData_v1_WorkshiftTemplates_Form(FormModes startingMode, Guid? Clients_Id) : base(startingMode, FORM_SHOWDATAONLOAD)
        {
            InitializeComponent();
            if (Clients_Id != null)
                _Clients_Id = Clients_Id;

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
            iddl_DayOfWeek.populate(typeof(DayOfWeek));

            setColumnsDataPropertyNames(WorkshiftTemplate.COL_DB_Id, WorkshiftTemplate.COL_DB_Active, null, null, null, null);

            col_dgv_Name = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Name", itxt_Name.LabelText, WorkshiftTemplate.COL_DB_Name, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Clients_CompanyName = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Clients_CompanyName", itxt_Clients.LabelText, WorkshiftTemplate.COL_Clients_CompanyName, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_WorkshiftCategories_Name = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_WorkshiftCategories_Name", itxt_WorkshiftCategories.LabelText, WorkshiftTemplate.COL_WorkshiftCategories_Name, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_DayOfWeek = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_DayOfWeek", iddl_DayOfWeek.LabelText, WorkshiftTemplate.COL_DayOfWeekName, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Start = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Start", idtp_Start.LabelText, WorkshiftTemplate.COL_DB_Start, true, true, @"h\:mm", true, false, 50, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Duration = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Duration", in_DurationMinutes.LabelText, WorkshiftTemplate.COL_DB_DurationMinutes, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_PayableAmount = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_PayableAmount", in_PayableAmount.LabelText, WorkshiftTemplate.COL_DB_PayableAmount, true, true, "N0", true, false, 50, DataGridViewContentAlignment.MiddleRight);
            col_dgv_Notes = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Notes", itxt_Notes.LabelText, WorkshiftTemplate.COL_DB_Notes, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            ptInputPanel.PerformClick();
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
            idtp_Start.Enabled = true;
            idtp_Start.reset();
            in_DurationMinutes.Enabled = true;
            in_DurationMinutes.reset();
            in_PayableAmount.Enabled = true;
            in_PayableAmount.reset();
            itxt_Notes.reset();
        }

        protected override bool isValidToPopulateGridViewDataSource()
        {
            return true;
        }

        protected override System.Data.DataView loadGridviewDataSource()
        {
            if (_Clients_Id != null)
                return WorkshiftTemplate.get(chkIncludeInactive.Checked, null, null,
                    _Clients_Id, null, null, null, null, null, null
                    ).DefaultView;

            return WorkshiftTemplate.get(chkIncludeInactive.Checked, null,
                    getFilterValue<string>(itxt_Name),
                    getFilterValue<Guid?>(itxt_Clients),
                    getFilterValue<Guid?>(itxt_WorkshiftCategories),
                    getFilterValue<int?>(iddl_DayOfWeek),
                    getFilterValue<TimeSpan?>(idtp_Start),
                    getFilterValue<int?>(in_DurationMinutes),
                    getFilterValue<decimal>(in_PayableAmount),
                    getFilterValue<string>(itxt_Notes)
                    ).DefaultView;
        }

        protected override void populateInputFields()
        {
            WorkshiftTemplate obj = new WorkshiftTemplate(selectedRowID());
            itxt_Name.ValueText = obj.Name;
            itxt_Clients.setValue(obj.Clients_CompanyName, obj.Clients_Id);
            itxt_WorkshiftCategories.setValue(obj.WorkshiftCategories_Name, obj.WorkshiftCategories_Id);
            iddl_DayOfWeek.SelectedItem = obj.DayOfWeek;
            idtp_Start.ValueTimeSpan = obj.Start;
            in_DurationMinutes.Value = obj.DurationMinutes;
            in_PayableAmount.Value = obj.PayableAmount;
            itxt_Notes.ValueText = obj.Notes;
        }

        protected override void update()
        {
            WorkshiftTemplate.update(UserAccount.LoggedInAccount.Id,
                selectedRowID(),
                itxt_Name.ValueText,
                (Guid)itxt_WorkshiftCategories.ValueGuid,
                (DayOfWeek)iddl_DayOfWeek.SelectedValue,
                idtp_Start.ValueTimeSpan.ToString(),
                in_DurationMinutes.ValueInt,
                in_PayableAmount.Value,
                itxt_Notes.ValueText);
        }

        protected override void add()
        {
            WorkshiftTemplate.add(UserAccount.LoggedInAccount.Id,
                itxt_Name.ValueText,
                (Guid)itxt_Clients.ValueGuid,
                (Guid)itxt_WorkshiftCategories.ValueGuid,
                (DayOfWeek)iddl_DayOfWeek.SelectedValue,
                idtp_Start.ValueTimeSpan.ToString(),
                in_DurationMinutes.ValueInt,
                in_PayableAmount.Value,
                itxt_Notes.ValueText);
        }

        protected override Boolean isInputFieldsValid()
        {
            Util.sanitize(itxt_Name, itxt_Notes);
            if (string.IsNullOrEmpty(itxt_Name.ValueText))
                return itxt_Name.isValueError("Please fill WorkshiftTemplate Name");
            else if (itxt_Clients.ValueGuid == null)
                return itxt_Clients.isValueError("Please select a Client");
            else if (itxt_WorkshiftCategories.ValueGuid == null)
                return itxt_WorkshiftCategories.isValueError("Please select a WorkshiftTemplate Category");
            else if (!iddl_DayOfWeek.hasSelectedValue())
                return iddl_DayOfWeek.SelectedValueError("Please select the day.");
            else if ((Mode != FormModes.Update && WorkshiftTemplate.isCombinationExist(null,itxt_Name.ValueText, (Guid)itxt_Clients.ValueGuid, Util.parseEnum<DayOfWeek>(iddl_DayOfWeek.SelectedValue), idtp_Start.ValueTimeSpan.ToString()))
                    || (Mode == FormModes.Update && WorkshiftTemplate.isCombinationExist(selectedRowID(), itxt_Name.ValueText, (Guid)itxt_Clients.ValueGuid, Util.parseEnum<DayOfWeek>(iddl_DayOfWeek.SelectedValue), idtp_Start.ValueTimeSpan.ToString())))
                return iddl_DayOfWeek.SelectedValueError("WorkshiftTemplate combination exists. Please change Name/Client/Day/Start.");

            return true;
        }

        protected override void updateActiveStatus(Guid id, Boolean activeStatus)
        {
            WorkshiftTemplate.updateActiveStatus(UserAccount.LoggedInAccount.Id, id, activeStatus);
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
                Util.getSelectedRowValue(dgv, col_dgv_Duration)
                );
        }

        protected override void dgv_CellDoubleClick()
        {
            BrowsedItemSelectionValue = Util.getSelectedRowID(dgv, col_dgv_Id);
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
            WorkshiftTemplate.delete(UserAccount.LoggedInAccount.Id, selectedRowID());
            populateGridViewDataSource(true);
        }

        private void itxt_Clients_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new Admin.MasterData_v1_Clients_Form(FormModes.Browse, null), ref sender);
        }

        private void itxt_WorkshiftCategories_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new Admin.MasterData_v1_WorkshiftCategories_Form(FormModes.Browse), ref sender);
        }

        private void btnAttendancePayRates_Click(object sender, EventArgs e)
        {
            Util.displayForm(null, new Admin.MasterData_v1_AttendancePayRates_Form(FormModes.Add, Util.getSelectedRowID(dgv, col_dgv_Id), (string)Util.getSelectedRowValue(dgv, col_dgv_Name)));
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
