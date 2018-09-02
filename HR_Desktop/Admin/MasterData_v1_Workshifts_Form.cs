using System;
using System.Windows.Forms;

using LIBUtil;
using LIBUtil.Desktop.UserControls;
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
        private DataGridViewColumn col_dgv_UserAccounts_Fullname;
        private DataGridViewColumn col_dgv_WorkshiftTemplates_Name;
        private DataGridViewColumn col_dgv_WorkshiftCategories_Name;
        private DataGridViewColumn col_dgv_DayOfWeek;
        private DataGridViewColumn col_dgv_Start;
        private DataGridViewColumn col_dgv_Duration;
        private DataGridViewColumn col_dgv_Notes;

        private Guid? _Clients_Id = null;
        private Guid? _UserAccounts_Id = null;
        private int? _DayOfWeek = null;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public MasterData_v1_Workshifts_Form() : this(FormModes.Add, null, null, null) { }
        public MasterData_v1_Workshifts_Form(FormModes startingMode, Guid? Clients_Id, Guid? UserAccounts_Id, int? DayOfWeek) : base(startingMode, FORM_SHOWDATAONLOAD)
        {
            InitializeComponent();

            if (Clients_Id != null)
                _Clients_Id = Clients_Id;

            if (UserAccounts_Id != null)
                _UserAccounts_Id = UserAccounts_Id;

            if (DayOfWeek != null)
                _DayOfWeek = DayOfWeek;
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
            //iddl_Start.populateWithTime(0, 0, 23, 0, 60, Workshift.COL_DB_Start, @"{0:h\:mm}");
            //iddl_End.populateWithTime(0, 0, 23, 0, 60, Workshift.COL_DB_End, @"{0:h\:mm}");

            setColumnsDataPropertyNames(Workshift.COL_DB_Id, Workshift.COL_DB_Active, null, null, null, null);

            col_dgv_Clients_CompanyName = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Clients_CompanyName", itxt_Clients.LabelText, Workshift.COL_Clients_CompanyName, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_UserAccounts_Fullname = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_UserAccounts_Fullname", itxt_UserAccounts.LabelText, Workshift.COL_UserAccounts_Fullname, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Name = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Name", itxt_Name.LabelText, Workshift.COL_DB_Name, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_WorkshiftTemplates_Name = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_WorkshiftTemplates_Name", itxt_WorkshiftTemplate.LabelText, Workshift.COL_WorkshiftTemplates_Name, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_WorkshiftCategories_Name = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_WorkshiftCategories_Name", itxt_WorkshiftCategories.LabelText, Workshift.COL_WorkshiftCategories_Name, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_DayOfWeek = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_DayOfWeek", iddl_DayOfWeek.LabelText, Workshift.COL_DayOfWeekName, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Start = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Start", idtp_Start.LabelText, Workshift.COL_DB_Start, true, true, @"h\:mm", true, false, 50, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Duration = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Duration", in_DurationMinutes.LabelText, Workshift.COL_DB_DurationMinutes, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Notes = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Notes", itxt_Notes.LabelText, Workshift.COL_DB_Notes, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            ptInputPanel.PerformClick();
        }

        protected override void additionalSettings() { }

        protected override void clearInputFields()
        {
            itxt_Name.reset();
            gb_Template.Enabled = false;
            itxt_WorkshiftTemplate.reset();
            itxt_Clients.Enabled = true;
            itxt_Clients.reset();
            itxt_UserAccounts.reset();
            itxt_WorkshiftCategories.Enabled = true;
            itxt_WorkshiftCategories.reset();
            iddl_DayOfWeek.Enabled = true;
            iddl_DayOfWeek.reset();
            idtp_Start.Enabled = true;
            idtp_Start.reset();
            in_DurationMinutes.Enabled = true;
            in_DurationMinutes.reset();
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
                    getFilterValue<Guid?>(itxt_Clients),
                    getFilterValue<Guid?>(itxt_UserAccounts),
                    getFilterValue<Guid?>(itxt_WorkshiftTemplate),
                    getFilterValue<Guid?>(itxt_WorkshiftCategories),
                    getFilterValue<int?>(iddl_DayOfWeek),
                    getFilterValue<TimeSpan?>(idtp_Start),
                    getFilterValue<int?>(in_DurationMinutes),
                    getFilterValue<string>(itxt_Notes)
                    ).DefaultView;
        }

        protected override void updateInputPanelControls()
        {
            in_DurationMinutes.ShowCheckbox = (Mode == FormModes.Search);

            idtp_Start.ShowCheckBox = (Mode == FormModes.Search);
            //this is a quick fix to a bug where the value keeps get set to current time when ShowCheckBox value is set
            idtp_Start.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
        }

        protected override void populateInputFields()
        {
            Workshift obj = new Workshift(selectedRowID());
            itxt_Name.ValueText = obj.Name;
            itxt_Clients.setValue(obj.Clients_CompanyName, obj.Clients_Id);
            itxt_UserAccounts.setValue(obj.UserAccounts_Fullname, obj.UserAccounts_Id);
            itxt_WorkshiftCategories.setValue(obj.WorkshiftCategories_Name, obj.WorkshiftCategories_Id);
            iddl_DayOfWeek.SelectedItem = obj.DayOfWeek;
            idtp_Start.ValueTimeSpan = obj.Start;
            in_DurationMinutes.Value = obj.DurationMinutes;
            itxt_Notes.ValueText = obj.Notes;
            if(!string.IsNullOrEmpty(obj.WorkshiftTemplates_Name))
                itxt_WorkshiftTemplate.setValue(obj.WorkshiftTemplates_Name, (Guid)obj.WorkshiftTemplates_Id);

        }

        protected override void update()
        {
            Workshift.update(UserAccount.LoggedInAccount.Id,
                selectedRowID(),
                itxt_Name.ValueText,
                (Guid)itxt_UserAccounts.ValueGuid,
                itxt_WorkshiftTemplate.ValueGuid,
                (Guid)itxt_WorkshiftCategories.ValueGuid,
                (DayOfWeek)iddl_DayOfWeek.SelectedValue,
                idtp_Start.ValueTimeSpan.ToString(),
                in_DurationMinutes.ValueInt,
                itxt_Notes.ValueText);
        }

        protected override void add()
        {
            Workshift.add(UserAccount.LoggedInAccount.Id,
                itxt_Name.ValueText,
                (Guid)itxt_Clients.ValueGuid,
                (Guid)itxt_UserAccounts.ValueGuid,
                itxt_WorkshiftTemplate.ValueGuid,
                (Guid)itxt_WorkshiftCategories.ValueGuid,
                (DayOfWeek)iddl_DayOfWeek.SelectedValue,
                idtp_Start.ValueTimeSpan.ToString(),
                in_DurationMinutes.ValueInt,
                itxt_Notes.ValueText);
        }

        protected override Boolean isInputFieldsValid()
        {
            Util.sanitize(itxt_Name, itxt_Notes);
            if (string.IsNullOrEmpty(itxt_Name.ValueText))
                return itxt_Name.isValueError("Please fill Workshift Name");
            else if (itxt_Clients.ValueGuid == null)
                return itxt_Clients.isValueError("Please select a Client");
            else if (itxt_UserAccounts.ValueGuid == null)
                return itxt_UserAccounts.isValueError("Please select a User");
            else if (itxt_WorkshiftCategories.ValueGuid == null)
                return itxt_WorkshiftCategories.isValueError("Please select a Workshift Category");
            else if (!iddl_DayOfWeek.hasSelectedValue())
                return iddl_DayOfWeek.SelectedValueError("Please select the day.");
            else if ((Mode != FormModes.Update && Workshift.isCombinationExist(null,itxt_Name.ValueText, (Guid)itxt_Clients.ValueGuid, (Guid)itxt_UserAccounts.ValueGuid, Util.parseEnum<DayOfWeek>(iddl_DayOfWeek.SelectedValue), idtp_Start.ValueTimeSpan.ToString()))
                    || (Mode == FormModes.Update && Workshift.isCombinationExist(selectedRowID(), itxt_Name.ValueText, (Guid)itxt_Clients.ValueGuid, (Guid)itxt_UserAccounts.ValueGuid, Util.parseEnum<DayOfWeek>(iddl_DayOfWeek.SelectedValue), idtp_Start.ValueTimeSpan.ToString())))
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
                Util.getSelectedRowValue(dgv, col_dgv_Duration)
                );
        }

        private void populateInputFieldsWorkshiftTemplate()
        {
            WorkshiftTemplate obj = new WorkshiftTemplate((Guid)itxt_WorkshiftTemplate.ValueGuid);
            itxt_Name.ValueText = obj.Name;
            itxt_Clients.setValue(obj.Clients_CompanyName, obj.Clients_Id);
            itxt_WorkshiftCategories.setValue(obj.WorkshiftCategories_Name, obj.WorkshiftCategories_Id);
            iddl_DayOfWeek.SelectedItem = obj.DayOfWeek;
            idtp_Start.ValueTimeSpan = obj.Start;
            in_DurationMinutes.Value = obj.DurationMinutes;
        }

        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            itxt_Clients.Enabled = false;

            base.btnUpdate_Click(sender, e);
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Workshift.delete(UserAccount.LoggedInAccount.Id, selectedRowID());
            populateGridViewDataSource(true);
        }

        private void itxt_Clients_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            InputControl_Textbox.browseForm(new MasterData_v1_Clients_Form(FormModes.Browse, null), ref sender);
        }

        private void itxt_WorkshiftCategories_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            InputControl_Textbox.browseForm(new MasterData_v1_WorkshiftCategories_Form(FormModes.Browse), ref sender);
        }

        private void itxt_WorkshiftTemplate_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            Admin.MasterData_v1_WorkshiftTemplates_Form form;
            form = (MasterData_v1_WorkshiftTemplates_Form)InputControl_Textbox.browseForm(new MasterData_v1_WorkshiftTemplates_Form(FormModes.Browse, itxt_Clients.ValueGuid, null), ref sender);
            if(form.BrowsedItemSelectionId != null)
            {
                itxt_WorkshiftTemplate.ValueGuid = form.BrowsedItemSelectionId;
                populateInputFieldsWorkshiftTemplate();
            }
        }

        private void itxt_UserAccounts_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new LOGIN.MasterData_v1_UserAccounts_Form(FormModes.Browse, false), ref sender);
        }

        private void itxt_Clients_onTextChanged(object sender, EventArgs e)
        {
            gb_Template.Enabled = itxt_Clients.ValueGuid != null && Mode == FormModes.Add;
        }

        private void btnAttendancePayRates_Click(object sender, EventArgs e)
        {
            Util.displayForm(null, new Admin.MasterData_v1_AttendancePayRates_Form(FormModes.Add, Util.getSelectedRowID(dgv, col_dgv_Id), (string)Util.getSelectedRowValue(dgv, col_dgv_Name)));
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            if (_UserAccounts_Id != null || _Clients_Id != null || _DayOfWeek != null)
            {
                FormModes originalMode = Mode;

                //open input container
                if (scMain.Panel1Collapsed)
                    ptInputPanel.toggle();

                //change mode to filter
                btnSearch.PerformClick();

                //set filter values to controls
                if (_UserAccounts_Id != null)
                    itxt_UserAccounts.setValue(new UserAccount((Guid)_UserAccounts_Id).Fullname, (Guid)_UserAccounts_Id);

                if (_Clients_Id != null)
                    itxt_Clients.setValue(new Client((Guid)_Clients_Id).CompanyName, (Guid)_Clients_Id);

                if (_DayOfWeek != null)
                    iddl_DayOfWeek.SelectedItem = (DayOfWeek)_DayOfWeek; ;

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
