﻿using System;
using System.Windows.Forms;
using System.Drawing;

using LIBUtil;
using LOGIN;
using LOGGING;
using HR_LIB.HR;

namespace HR_Desktop.Admin
{
    public partial class MasterData_v1_Attendances_Form : LIBUtil.Desktop.Forms.MasterData_v1_Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        private const bool FORM_SHOWDATAONLOAD = true;

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private DataGridViewColumn col_dgv_UserAccounts_FullName;
        private DataGridViewColumn col_dgv_Clients_CompanyName;
        private DataGridViewColumn col_dgv_hasWorkshifts_Id;
        private DataGridViewColumn col_dgv_Workshifts_Name;
        private DataGridViewColumn col_dgv_Workshifts_Start;
        private DataGridViewColumn col_dgv_Workshifts_Duration;
        private DataGridViewColumn col_dgv_Workshifts_DayOfWeek;
        private DataGridViewColumn col_dgv_AttendanceStatuses;
        private DataGridViewColumn col_dgv_TimestampIn;
        private DataGridViewColumn col_dgv_TimestampOut;
        private DataGridViewColumn col_dgv_EffectiveTimestampIn;
        private DataGridViewColumn col_dgv_EffectiveTimestampOut;
        private DataGridViewColumn col_dgv_Flag1;
        private DataGridViewColumn col_dgv_Flag2;
        private DataGridViewColumn col_dgv_Approved;
        private DataGridViewColumn col_dgv_Rejected;
        private DataGridViewColumn col_dgv_Notes;
        private DataGridViewColumn col_dgv_PayrollItems_Id;
        private DataGridViewColumn col_dgv_Payrolls_No;
        private DataGridViewColumn col_dgv_HasPayment;
        private DataGridViewColumn col_dgv_Replacement_Attendances_Id;
        private DataGridViewColumn col_dgv_Replacement_Attendances_Fullname;

        private bool _IsFinishPopulateAttendanceStatuses = false;
        private Guid? _Id = null;
        private Guid? _Clients_Id = null;
        private Guid? _Workshifts_Id = null;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public MasterData_v1_Attendances_Form() : this(FormModes.Add, null, null, null) { }
        public MasterData_v1_Attendances_Form(FormModes startingMode, Guid? Id, Guid? Clients_Id, Guid? Workshifts_Id) : base(startingMode, FORM_SHOWDATAONLOAD)
        {
            InitializeComponent();

            _Id = Id;
            _Clients_Id = Clients_Id;
            _Workshifts_Id = Workshifts_Id;

        }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private bool isValidToUpdate()
        {   //valid to update if hasPayment = false and approved = false and rejected = false
            return (!(bool)Util.getSelectedRowValue(dgv, col_dgv_HasPayment)
                    & !(bool)Util.getSelectedRowValue(dgv, col_dgv_Approved)
                    & !(bool)Util.getSelectedRowValue(dgv, col_dgv_Rejected)
                 );
        }
        #endregion METHODS
        /*******************************************************************************************************/
        #region OVERRIDE METHODS

        protected override void setupControlsBasedOnRoles()
        {
        }

        protected override void setupFields()
        {
            disableFieldActive();
            idtp_TimestampIn.Value = DateTime.Now;
            idtp_TimestampOut.Value = DateTime.Now;

            setColumnsDataPropertyNames(Attendance.COL_DB_Id, null, null, null, null, null);
            dgv.AutoGenerateColumns = false;
            col_dgv_UserAccounts_FullName = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_UserAccounts_FullName", itxt_UserAccount.LabelText, Attendance.COL_UserAccounts_Fullname, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Clients_CompanyName = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Clients_CompanyName", itxt_Client.LabelText, Attendance.COL_Clients_CompanyName, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_hasWorkshifts_Id = base.addColumn<DataGridViewCheckBoxCell>(dgv, "col_dgv_hasWorkshifts_Id", itxt_Workshift.LabelText, Attendance.COL_HasWorkshifts_Id, true, false, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Workshifts_Name = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Workshifts_Name", itxt_Workshift.LabelText, Attendance.COL_Workshifts_Name, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Workshifts_DayOfWeek = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Workshifts_DayOfWeek", "Day Of Week", Attendance.COL_Workshifts_DayOfWeek_Name, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Workshifts_Start = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Workshifts_Start", "Start", Attendance.COL_DB_Workshifts_Start, true, true, @"HH:mm", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Workshifts_Duration = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Workshifts_Duration", "Duration", Attendance.COL_DB_Workshifts_DurationMinutes, true, true, "", true, false, 45, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_AttendanceStatuses = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_AttendanceStatuses", iddl_AttendanceStatuses.LabelText, Attendance.COL_AttendanceStatuses_Name, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_TimestampIn = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_TimestampIn", idtp_TimestampIn.LabelText, Attendance.COL_DB_TimestampIn, true, true, @"dd/MM/yy  HH:mm", true, false, 30, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_TimestampOut = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_TimestampOut", idtp_TimestampOut.LabelText, Attendance.COL_DB_TimestampOut, true, true, @"dd/MM/yy  HH:mm", true, false, 30, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_EffectiveTimestampIn = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_EffectiveTimestampIn", idtp_EffectiveTimestampIn.LabelText, Attendance.COL_DB_EffectiveTimestampIn, true, true, @"dd/MM/yy  HH:mm", true, false, 30, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_EffectiveTimestampOut = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_EffectiveTimestampOut", idtp_EffectiveTimestampOut.LabelText, Attendance.COL_DB_EffectiveTimestampOut, true, true, @"dd/MM/yy  HH:mm", true, false, 30, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Flag1 = base.addColumn<DataGridViewCheckBoxCell>(dgv, "col_dgv_Flag1", Attendance.COL_DB_Flag1, Attendance.COL_DB_Flag1, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Flag2 = base.addColumn<DataGridViewCheckBoxCell>(dgv, "col_dgv_Flag2", Attendance.COL_DB_Flag2, Attendance.COL_DB_Flag2, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Approved = base.addColumn<DataGridViewCheckBoxCell>(dgv, "col_dgv_Approved", Attendance.COL_DB_Approved, Attendance.COL_DB_Approved, true, true, "", true, false, 60, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Rejected = base.addColumn<DataGridViewCheckBoxCell>(dgv, "col_dgv_Rejected", Attendance.COL_DB_Rejected, Attendance.COL_DB_Rejected, true, false, "", true, false, 30, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_PayrollItems_Id = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_PayrollItems_Id", "", Attendance.COL_DB_PayrollItems_Id, false, false, "", false, false, 30, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Payrolls_No = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Payrolls_No", "Payrolls", Attendance.COL_Payrolls_No, false, true, "", false, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_HasPayment = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_HasPayment", "HasPayment", Attendance.COL_Payrolls_HasPayment, false, false, "", false, false, 30, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Replacement_Attendances_Id = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Replacement_Attendances_Id", itxt_ReplacementAttendance.LabelText, Attendance.COL_DB_Replacement_Attendances_Id, true, false, "", true, false, 30, DataGridViewContentAlignment.MiddleCenter);

            // note :
            //Saya pakai method addLinkColumn agar bisa melakukan format Link (seperti yang di Form Timesheet) 
            //Saya coba pakai method addColumn biasa, tidak ada pilihan untuk setting LinkBehavior dll.

            //col_dgv_Replacement_Attendances_Fullname = base.addColumn<DataGridViewLinkCell>(dgv, "col_dgv_Replacement_Attendances_Fullname", "Replacement", Attendance.COL_Replacement_Attendances_Fullname, true, true, "", true, false, 100, DataGridViewContentAlignment.MiddleCenter);
            col_dgv_Replacement_Attendances_Fullname = addLinkColumn(dgv, "col_dgv_Replacement_Attendances_Fullname", "Replacement", Attendance.COL_Replacement_Attendances_Fullname, 100, DataGridViewAutoSizeColumnMode.None, DataGridViewContentAlignment.MiddleCenter);

            col_dgv_Notes = base.addColumn<DataGridViewTextBoxCell>(dgv, "col_dgv_Notes", itxt_Notes.LabelText, Attendance.COL_DB_Notes, true, true, "", true, false, 50, DataGridViewContentAlignment.MiddleLeft);
            col_dgv_Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            ptInputPanel.PerformClick();


            AttendanceStatus.populateDropDownList(iddl_AttendanceStatuses, false);
            _IsFinishPopulateAttendanceStatuses = true;
        }


        private DataGridViewColumn addLinkColumn(DataGridView dgv, string columnName, string headerText, string dataPropertyName, int minimumWidth, DataGridViewAutoSizeColumnMode autoSizeMode, DataGridViewContentAlignment alignment)
        {
            DataGridViewLinkColumn col = new DataGridViewLinkColumn();
            col.Name = columnName;
            col.HeaderText = headerText;
            col.DataPropertyName = dataPropertyName;
            col.MinimumWidth = minimumWidth;
            col.DefaultCellStyle.Alignment = alignment;
            col.LinkBehavior = LinkBehavior.HoverUnderline;
            col.ActiveLinkColor = Color.Lime;
            col.LinkColor = Color.Lime;
            col.VisitedLinkColor = Color.Lime;
            col.SortMode = DataGridViewColumnSortMode.Automatic;
            col.AutoSizeMode = autoSizeMode;

            dgv.Columns.Add(col);

            return col;
        } 

        protected override void additionalSettings() { }

        protected override void clearInputFields()
        {
            itxt_UserAccount.reset();
            itxt_UserAccount.Enabled = true;
            itxt_Client.reset();
            itxt_Client.Enabled = true;
            itxt_Workshift.reset();
            itxt_Workshift.Enabled = true;
            iddl_AttendanceStatuses.reset();
            iddl_AttendanceStatuses.Enabled = true;
            itxt_ReplacementAttendance.reset();
            itxt_ReplacementAttendance.Enabled = true;
            itxt_ReplacementAttendance.Visible = false;
            idtp_TimestampIn.Value = DateTime.Now;
            idtp_TimestampIn.Enabled = true;
            idtp_TimestampOut.Value = DateTime.Now;
            idtp_TimestampOut.Enabled = true;
            idtp_EffectiveTimestampIn.Value = DateTime.Now;
            idtp_EffectiveTimestampIn.Enabled = true;
            idtp_EffectiveTimestampOut.Value = DateTime.Now;
            idtp_EffectiveTimestampOut.Enabled = true;
            itxt_Notes.reset();

        }

        protected override bool isValidToPopulateGridViewDataSource()
        {
            return true;
        }

        protected override System.Data.DataView loadGridviewDataSource()
        {            
            return Attendance.get(
                _Id, 
                getFilterValue<Guid?>(itxt_UserAccount),
                getFilterValue<Guid?>(itxt_Client),
                getFilterValue<Guid?>(itxt_Workshift),
                null, null, null, null, null,
                getFilterValue<string>(itxt_Notes),
                getFilterValue<Guid?>(iddl_AttendanceStatuses),
                getFilterValue<Guid?>(itxt_ReplacementAttendance)
                ).DefaultView;
        }

        protected override void populateInputFields()
        {
            Attendance obj = new Attendance(selectedRowID());

            itxt_UserAccount.setValue(obj.UserAccounts_Fullname, obj.UserAccounts_Id);
            itxt_Client.setValue(obj.Clients_CompanyName, obj.Clients_Id);
            itxt_Workshift.setValue(obj.Workshifts_Name, obj.Workshifts_Id);
            iddl_AttendanceStatuses.SelectedValue = obj.AttendanceStatuses_Id;
            if(obj.Replacement_Attendances_Id != null)
                itxt_ReplacementAttendance.setValue(obj.Replacement_Attendances_Fullname, (Guid)obj.Replacement_Attendances_Id);
            idtp_TimestampIn.Value = obj.TimestampIn;
            idtp_TimestampOut.Value = obj.TimestampOut;
            idtp_EffectiveTimestampIn.Value = obj.EffectiveTimestampIn;
            idtp_EffectiveTimestampOut.Value = obj.EffectiveTimestampOut;
            itxt_Notes.ValueText = obj.Notes;

            //valid to update if hasPayment = false and approved = false and rejected = false
            if (obj.Payrolls_HasPayment || obj.Approved || obj.Rejected )
            {
                itxt_UserAccount.Enabled = false;
                itxt_Client.Enabled = false;
                itxt_Workshift.Enabled = false;
                iddl_AttendanceStatuses.Enabled = false;
                itxt_ReplacementAttendance.Enabled = false;
                idtp_TimestampIn.Enabled = false;
                idtp_TimestampOut.Enabled = false;
                idtp_EffectiveTimestampIn.Enabled = false;
                idtp_EffectiveTimestampOut.Enabled = false;
                itxt_Notes.Enabled = false;
            }
        }

        protected override void update()
        {
            Attendance.update(UserAccount.LoggedInAccount.Id,
                selectedRowID(),
                (Guid)itxt_Client.ValueGuid,
                itxt_Workshift.ValueGuid,
                (DateTime)idtp_TimestampIn.Value,
                (DateTime)idtp_TimestampOut.Value,
                (DateTime)idtp_EffectiveTimestampIn.Value,
                (DateTime)idtp_EffectiveTimestampOut.Value,
                itxt_Notes.ValueText,
                (Guid)iddl_AttendanceStatuses.SelectedValue,
                (Guid?)itxt_ReplacementAttendance.ValueGuid
                );
        }

        protected override void add()
        {   
            Attendance.add(UserAccount.LoggedInAccount.Id,
                (Guid)itxt_UserAccount.ValueGuid,
                (Guid)itxt_Client.ValueGuid,
                (Guid?)itxt_Workshift.ValueGuid,
                (DateTime)idtp_TimestampIn.Value,
                (DateTime)idtp_TimestampOut.Value,
                (DateTime?)idtp_EffectiveTimestampIn.Value,
                (DateTime?)idtp_EffectiveTimestampOut.Value,
                itxt_Notes.ValueText,
                (Guid)iddl_AttendanceStatuses.SelectedValue,
                (Guid?)itxt_ReplacementAttendance.ValueGuid
                );
        }

        protected override Boolean isInputFieldsValid()
        {
            Util.sanitize(itxt_Notes);
            if (itxt_UserAccount.ValueGuid == null)
                return itxt_UserAccount.isValueError("Please select a User");
            else if (itxt_Client.ValueGuid == null)
                return itxt_Client.isValueError("Please select a Client");
            else if (itxt_Workshift.ValueGuid == null)
                return itxt_Workshift.isValueError("Please select a Workshift");
            else if (!iddl_AttendanceStatuses.hasSelectedValue())
                return iddl_AttendanceStatuses.SelectedValueError("Please select Attendance Status");
            else if (idtp_TimestampIn.Value == null)
                return idtp_TimestampIn.ValueError("Please fill Timestamp In");
            else if (idtp_TimestampOut.Value == null)
                return idtp_TimestampOut.ValueError("Please fill Timestamp Out");
            else if ((Mode != FormModes.Update && Attendance.isCombinationExist(null, (Guid)itxt_UserAccount.ValueGuid, (DateTime)idtp_TimestampIn.Value))
                    || (Mode == FormModes.Update && Attendance.isCombinationExist(selectedRowID(), (Guid)itxt_UserAccount.ValueGuid, (DateTime)idtp_TimestampIn.Value)))
                return itxt_UserAccount.isValueError("Attendance combination exists. Please change User/Timestamp In.");

            return true;
        }

        protected override void btnLog_Click(object sender, EventArgs e)
        {
            Util.displayForm(null, new LOGGING.ActivityLogs_Form(UserAccount.LoggedInAccount, selectedRowID()));
            txtQuickSearch.Focus();
        }

        protected override void updateDefaultRow(Guid id) { }

        protected override string getSelectedItemDescription(int rowIndex)
        {
            return string.Format("{0} - In :{1} Out : {2}",
                Util.getSelectedRowValue(dgv, col_dgv_UserAccounts_FullName),
                Util.getSelectedRowValue(dgv, col_dgv_TimestampIn),
                Util.getSelectedRowValue(dgv, col_dgv_TimestampOut)
                );
        }

        protected override void virtual_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Util.isColumnMatch(sender, e, col_dgv_Flag1))
            {
                if(isValidToUpdate())
                    Attendance.updateFlag1Status(UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgv, col_dgv_Id), !Util.getCheckboxValue(sender, e));
                    populateGridViewDataSource(true);
            }
            else if (Util.isColumnMatch(sender, e, col_dgv_Flag2))
            {
                if (isValidToUpdate())
                    Attendance.updateFlag2Status(UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgv, col_dgv_Id), !Util.getCheckboxValue(sender, e));
                    populateGridViewDataSource(true);
            }
            else if (Util.isColumnMatch(sender, e, col_dgv_Approved))
            {
                if (isValidToUpdate())
                    Attendance.updateApprovedStatus(UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgv, col_dgv_Id), !Util.getCheckboxValue(sender, e));
                    populateGridViewDataSource(true);
            }
            else if(Util.isColumnMatch(sender, e, col_dgv_Replacement_Attendances_Fullname))
                LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new Admin.MasterData_v1_Attendances_Form(FormModes.Browse, (Guid?)Util.getSelectedRowValue(dgv, col_dgv_Replacement_Attendances_Id), null, null), ref sender);

            base.virtual_dgv_CellContentClick(sender, e);
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            itxt_UserAccount.Enabled = false;
            base.btnUpdate_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Attendance.delete(UserAccount.LoggedInAccount.Id, selectedRowID());
            populateGridViewDataSource(true);
        }

        private void itxt_UserAccount_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new LOGIN.MasterData_v1_UserAccounts_Form(FormModes.Browse, false), ref sender);
        }
        
        private void idtp_TimestampIn_ValueChanged(object sender, EventArgs e)
        {
            idtp_TimestampOut.Value = idtp_TimestampIn.Value;
        }

        private void itxt_Client_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new Admin.MasterData_v1_Clients_Form(FormModes.Browse, itxt_UserAccount.ValueGuid), ref sender);
        }

        private void itxt_Workshift_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new Admin.MasterData_v1_Workshifts_Form(FormModes.Browse, itxt_Client.ValueGuid, itxt_UserAccount.ValueGuid, null), ref sender);
        }

        private void idtp_TimestampIn_ValueChanged_1(object sender, EventArgs e)
        {
            idtp_EffectiveTimestampIn.Value = idtp_TimestampIn.Value;
        }

        private void idtp_TimestampOut_ValueChanged(object sender, EventArgs e)
        {
            idtp_EffectiveTimestampOut.Value = idtp_TimestampOut.Value;
        }


        private void iddl_AttendanceStatuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_IsFinishPopulateAttendanceStatuses && iddl_AttendanceStatuses.hasSelectedValue())
            {
                AttendanceStatus attendanceStatus = new AttendanceStatus((Guid)iddl_AttendanceStatuses.SelectedValue);
                if (attendanceStatus.IsReplace)
                    itxt_ReplacementAttendance.Visible = true;
                else
                    itxt_ReplacementAttendance.Visible = false;
            }
        }

        private void itxt_ReplacementAttendance_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            LIBUtil.Desktop.UserControls.InputControl_Textbox.browseForm(new Admin.MasterData_v1_Attendances_Form(FormModes.Browse, null, itxt_Client.ValueGuid, itxt_Workshift.ValueGuid), ref sender);
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            if (_Clients_Id != null || _Workshifts_Id != null)
            {
                FormModes originalMode = Mode;

                //open input container
                if (scMain.Panel1Collapsed)
                    ptInputPanel.toggle();

                //change mode to filter
                btnSearch.PerformClick();

                //set filter values to control
                if(_Clients_Id != null)
                    itxt_Client.setValue(new Client((Guid)_Clients_Id).CompanyName, (Guid)_Clients_Id);
                if (_Workshifts_Id != null)
                    itxt_Workshift.setValue(new Workshift((Guid)_Workshifts_Id).Name, (Guid)_Workshifts_Id);

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
