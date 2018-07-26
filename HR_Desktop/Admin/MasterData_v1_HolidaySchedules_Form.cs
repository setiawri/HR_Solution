using System;
using System.Windows.Forms;

using LIBUtil;
using LOGIN;
using LOGGING;
using HR_LIB.HR;

namespace HR_Desktop.Admin
{
    public partial class MasterData_v1_HolidaySchedules_Form : LIBUtil.Desktop.Forms.MasterData_v1_Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private const bool FORM_SHOWDATAONLOAD = true;

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private DataGridViewColumn col_dgv_StartDate;
        private DataGridViewColumn col_dgv_DurationDays;
        private DataGridViewColumn col_dgv_Description;
        private DataGridViewColumn col_dgv_Notes;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public MasterData_v1_HolidaySchedules_Form() : this(FormModes.Add) { }
        public MasterData_v1_HolidaySchedules_Form(FormModes startingMode) : base(startingMode, FORM_SHOWDATAONLOAD)
        {
            InitializeComponent();
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
            setColumnsDataPropertyNames(HolidaySchedule.COL_DB_Id, HolidaySchedule.COL_DB_Active, null, null, null, null);

            col_dgv_StartDate = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_StartDate", idtp_StartDate.LabelText, HolidaySchedule.COL_DB_StartDate, true, true, "dd/MMM/yyyy", true, false, 60, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_DurationDays = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_DurationDays", itxt_DurationDays.LabelText, HolidaySchedule.COL_DB_DurationDays, true, true, "", true, false, 70, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Description = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Description", itxt_Description.LabelText, HolidaySchedule.COL_DB_Description, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Notes", itxt_Notes.LabelText, HolidaySchedule.COL_DB_Notes, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        protected override void additionalSettings() { }

        protected override void clearInputFields()
        {
            idtp_StartDate.reset();
            itxt_DurationDays.reset();
            itxt_Description.reset();
            itxt_Notes.reset();
        }

        protected override bool isValidToPopulateGridViewDataSource()
        {
            return true;
        }

        protected override System.Data.DataView loadGridviewDataSource()
        {

            return HolidaySchedule.get(chkIncludeInactive.Checked,
                    null,
                    idtp_StartDate.Value,
                    itxt_DurationDays.ValueInt,
                    itxt_Description.ValueText,
                    itxt_Notes.ValueText
                    ).DefaultView;
        }

        protected override void populateInputFields()
        {
            HolidaySchedule obj = new HolidaySchedule(selectedRowID());
            idtp_StartDate.Value = obj.StartDate;
            itxt_DurationDays.Value = obj.DurationDays;
            itxt_Description.ValueText = obj.Description;
            itxt_Notes.ValueText = obj.Notes;
        }

        protected override void update()
        {
            HolidaySchedule.update(UserAccount.LoggedInAccount.Id,
                selectedRowID(),
                (DateTime)idtp_StartDate.Value,
                itxt_DurationDays.ValueInt,
                itxt_Description.ValueText,
                itxt_Notes.ValueText
                );
        }

        protected override void updateActiveStatus(Guid id, Boolean activeStatus)
        {
            HolidaySchedule.updateActiveStatus(UserAccount.LoggedInAccount.Id, id, activeStatus);
        }

        protected override void add()
        {
            HolidaySchedule.add(UserAccount.LoggedInAccount.Id,
                (DateTime)idtp_StartDate.Value,
                itxt_DurationDays.ValueInt,
                itxt_Description.ValueText,
                itxt_Notes.ValueText
                );
        }

        protected override Boolean isInputFieldsValid()
        {
            Util.sanitize(itxt_Description, itxt_Notes);
            if (idtp_StartDate.Value == null)
                return idtp_StartDate.ValueError("Please choose a date");
            else if (itxt_DurationDays.ValueInt == 0)
                return itxt_DurationDays.isValueError("Please fill duration of holiday");
            else if (string.IsNullOrEmpty(itxt_Description.ValueText))
                return itxt_Description.isValueError("Please fill description of holiday");
            else if ((Mode != FormModes.Update && HolidaySchedule.isCombinationExist(null, (DateTime)idtp_StartDate.Value, itxt_Description.ValueText))
                    || (Mode == FormModes.Update && HolidaySchedule.isCombinationExist(selectedRowID(), (DateTime)idtp_StartDate.Value, itxt_Description.ValueText)))
                return itxt_DurationDays.isValueError("HolidaySchedule combination exists. Please change the date/description");

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
            return string.Format("{0} - {1}",
                Util.getSelectedRowValue(dgv, col_dgv_StartDate),
                Util.getSelectedRowValue(dgv, col_dgv_Description)
                );
        }


        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            base.btnUpdate_Click(sender, e);
        }


        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
