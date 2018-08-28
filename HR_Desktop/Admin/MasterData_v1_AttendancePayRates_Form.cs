using System;
using System.Windows.Forms;

using LIBUtil;
using LOGIN;
using LOGGING;
using HR_LIB.HR;

namespace HR_Desktop.Admin
{
    public partial class MasterData_v1_AttendancePayRates_Form : LIBUtil.Desktop.Forms.MasterData_v1_Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private const bool FORM_SHOWDATAONLOAD = true;
        private Guid? _RefId;
        private string _RefName;

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private DataGridViewColumn col_dgv_Workshifts_Name;
        private DataGridViewColumn col_dgv_WorkshiftTemplates_Name;
        private DataGridViewColumn col_dgv_AttendanceStatuses_Name;
        private DataGridViewColumn col_dgv_Amount;
        private DataGridViewColumn col_dgv_Notes;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public MasterData_v1_AttendancePayRates_Form() : this(FormModes.Add, null, null) { }
        public MasterData_v1_AttendancePayRates_Form(FormModes startingMode, Guid? RefId, string RefName) : base(startingMode, FORM_SHOWDATAONLOAD)
        {
            InitializeComponent();
            _RefId = RefId;
            _RefName = RefName;
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
            setColumnsDataPropertyNames(AttendancePayRate.COL_DB_Id, AttendancePayRate.COL_DB_Active, null, null, null, null);
            col_dgv_WorkshiftTemplates_Name = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Workshifts_Name", "Templates", AttendancePayRate.COL_WorkshiftTemplates_Name, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Workshifts_Name = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Workshifts_Name", "Workshifts", AttendancePayRate.COL_Workshifts_Name, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_AttendanceStatuses_Name = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_AttendanceStatuses_Name", iddl_AttendanceStatuses.LabelText, AttendancePayRate.COL_AttendanceStatuses_Name, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Amount = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Amount", in_Amount.LabelText, AttendancePayRate.COL_DB_Amount, true, true, "N0", true, false, 50, DataGridViewContentAlignment.MiddleRight);
            col_dgv_Notes = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Notes", itxt_Notes.LabelText, AttendancePayRate.COL_DB_Notes, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            AttendanceStatus.populateDropDownList(iddl_AttendanceStatuses, false);
            if(_RefId != null)
                itxt_Ref.setValue(_RefName,(Guid)_RefId);
        }

        protected override void additionalSettings() { }

        protected override void clearInputFields()
        {
            itxt_Ref.Enabled = true;
            itxt_Ref.reset();
            iddl_AttendanceStatuses.Enabled = true;
            iddl_AttendanceStatuses.reset();
            in_Amount.reset();
            itxt_Notes.reset();
        }

        protected override bool isValidToPopulateGridViewDataSource()
        {
            return true;
        }

        protected override System.Data.DataView loadGridviewDataSource()
        {
            return AttendancePayRate.get(chkIncludeInactive.Checked, null,
                    getFilterValue<Guid?>(itxt_Ref),
                    getFilterValue<Guid?>(iddl_AttendanceStatuses),
                    getFilterValue<decimal>(in_Amount),
                    getFilterValue<string>(itxt_Notes)
                    ).DefaultView;
        }

        protected override void populateInputFields()
        {
            AttendancePayRate obj = new AttendancePayRate(selectedRowID());

            itxt_Ref.setValue(obj.Workshifts_Name, obj.RefId);
            if(string.IsNullOrEmpty(itxt_Ref.ValueText))
                itxt_Ref.setValue(obj.WorkshiftTemplates_Name, obj.RefId);
            iddl_AttendanceStatuses.SelectedValue = obj.AttendanceStatuses_Id;
            in_Amount.Value = obj.Amount;
            itxt_Notes.ValueText = obj.Notes;
        }

        protected override void update()
        {
            AttendancePayRate.update(UserAccount.LoggedInAccount.Id,
                selectedRowID(),
                in_Amount.Value,
                itxt_Notes.ValueText);
        }

        protected override void add()
        {
            AttendancePayRate.add(UserAccount.LoggedInAccount.Id,
                (Guid)itxt_Ref.ValueGuid,
                (Guid)iddl_AttendanceStatuses.SelectedValue,
                in_Amount.Value,
                itxt_Notes.ValueText);
        }

        protected override Boolean isInputFieldsValid()
        {
            Util.sanitize(itxt_Notes);
            if (itxt_Ref.ValueGuid == null)
                return itxt_Ref.isValueError("Please select a Templates / Workshifts");
            else if (!iddl_AttendanceStatuses.hasSelectedValue())
                return iddl_AttendanceStatuses.SelectedValueError("Please select a Status");
            else if ((Mode != FormModes.Update && AttendancePayRate.isCombinationExist(null,(Guid)itxt_Ref.ValueGuid, (Guid)iddl_AttendanceStatuses.SelectedValue))
                    || (Mode == FormModes.Update && AttendancePayRate.isCombinationExist(selectedRowID(), (Guid)itxt_Ref.ValueGuid, (Guid)iddl_AttendanceStatuses.SelectedValue)))
                return itxt_Ref.isValueError("AttendancePayRate combination exists. Please change Ref/Attendance Status.");

            return true;
        }

        protected override void updateActiveStatus(Guid id, Boolean activeStatus)
        {
            AttendancePayRate.updateActiveStatus(UserAccount.LoggedInAccount.Id, id, activeStatus);
        }

        protected override void btnLog_Click(object sender, EventArgs e)
        {
            Util.displayForm(null, new LOGGING.ActivityLogs_Form(UserAccount.LoggedInAccount,selectedRowID()));
            txtQuickSearch.Focus();
        }

        protected override void updateDefaultRow(Guid id) { }

        protected override string getSelectedItemDescription(int rowIndex)
        {
            string RefName = (string)Util.getSelectedRowValue(dgv, col_dgv_Workshifts_Name);

            if (String.IsNullOrEmpty(RefName))
                RefName = (string)Util.getSelectedRowValue(dgv, col_dgv_WorkshiftTemplates_Name);


            return string.Format("{0} - {1} - {2}",
                RefName,
                Util.getSelectedRowValue(dgv, col_dgv_AttendanceStatuses_Name),
                Util.getSelectedRowValue(dgv, col_dgv_Amount)
                );
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            itxt_Ref.Enabled = false;
            iddl_AttendanceStatuses.Enabled = false;

            base.btnUpdate_Click(sender, e);
        }


        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
