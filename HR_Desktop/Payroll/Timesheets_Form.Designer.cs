namespace HR_Desktop.Payroll
{
    partial class Timesheets_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.ptFilterAttendance = new LIBUtil.Desktop.UserControls.PanelToggle();
            this.pnlFilterAttendance = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idtp_FilterAttendance_Out = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.idtp_FilterAttendance_StartDate = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.idtp_FilterAttendance_EndDate = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.btnFilterAttendance = new System.Windows.Forms.Button();
            this.iddl_DayOfWeek = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
            this.idtp_FilterAttendance_In = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idtp_EffectiveTimestampIn = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.idtp_EffectiveTimestampOut = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.itxt_Workshift = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Attendance_Client = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.iddl_AttendanceStatuses = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
            this.btnSubmitAttendance = new System.Windows.Forms.Button();
            this.itxt_Notes = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.idtp_TimestampIn = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.idtp_TimestampOut = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.pnlEmployees = new System.Windows.Forms.Panel();
            this.ptFilterEmployee = new LIBUtil.Desktop.UserControls.PanelToggle();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.pnlFilterEmployees = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkFilterEmployeeByName = new System.Windows.Forms.CheckBox();
            this.itxt_FilterEmployee_UserAccounts_Name = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkFilterEmployeesByClient = new System.Windows.Forms.CheckBox();
            this.itxt_FilterEmployee_Client = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.idtp_FilterEmployee_StartDate = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.idtp_FilterEmployee_EndDate = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.btnFilterEmployees = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvEmployees_UserAccounts_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvEmployees_Clients_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvEmployees_UserAccounts_Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendance_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendance_In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendance_Out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendance_EffectiveIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendance_EffectiveOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendances_EffectiveWorkHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendances_PayableAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendance_Approved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_dgvAttendance_Rejected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_dgvAttendance_Flag1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_dgvAttendance_Flag2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_dgvAttendance_Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlContainer.SuspendLayout();
            this.pnlFilterAttendance.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.pnlEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.pnlFilterEmployees.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.ptFilterAttendance);
            this.pnlContainer.Controls.Add(this.dgvAttendance);
            this.pnlContainer.Controls.Add(this.pnlFilterAttendance);
            this.pnlContainer.Controls.Add(this.pnlEmployees);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1084, 511);
            this.pnlContainer.TabIndex = 0;
            // 
            // ptFilterAttendance
            // 
            this.ptFilterAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptFilterAttendance.BackColor = System.Drawing.SystemColors.Control;
            this.ptFilterAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptFilterAttendance.InitialArrowDirection = System.Windows.Forms.ArrowDirection.Up;
            this.ptFilterAttendance.Location = new System.Drawing.Point(1064, 147);
            this.ptFilterAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.ptFilterAttendance.Name = "ptFilterAttendance";
            this.ptFilterAttendance.Size = new System.Drawing.Size(20, 20);
            this.ptFilterAttendance.TabIndex = 6;
            this.ptFilterAttendance.TogglePanel = this.pnlFilterAttendance;
            // 
            // pnlFilterAttendance
            // 
            this.pnlFilterAttendance.Controls.Add(this.groupBox2);
            this.pnlFilterAttendance.Controls.Add(this.groupBox1);
            this.pnlFilterAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterAttendance.Location = new System.Drawing.Point(275, 0);
            this.pnlFilterAttendance.Name = "pnlFilterAttendance";
            this.pnlFilterAttendance.Size = new System.Drawing.Size(809, 145);
            this.pnlFilterAttendance.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.idtp_FilterAttendance_Out);
            this.groupBox2.Controls.Add(this.idtp_FilterAttendance_StartDate);
            this.groupBox2.Controls.Add(this.idtp_FilterAttendance_EndDate);
            this.groupBox2.Controls.Add(this.btnFilterAttendance);
            this.groupBox2.Controls.Add(this.iddl_DayOfWeek);
            this.groupBox2.Controls.Add(this.idtp_FilterAttendance_In);
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 138);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FILTER";
            // 
            // idtp_FilterAttendance_Out
            // 
            this.idtp_FilterAttendance_Out.Checked = false;
            this.idtp_FilterAttendance_Out.CustomFormat = "HH:mm";
            this.idtp_FilterAttendance_Out.DefaultCheckedValue = false;
            this.idtp_FilterAttendance_Out.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_FilterAttendance_Out.LabelText = "OUT";
            this.idtp_FilterAttendance_Out.Location = new System.Drawing.Point(7, 52);
            this.idtp_FilterAttendance_Out.Margin = new System.Windows.Forms.Padding(4);
            this.idtp_FilterAttendance_Out.Name = "idtp_FilterAttendance_Out";
            this.idtp_FilterAttendance_Out.ShowCheckBox = true;
            this.idtp_FilterAttendance_Out.ShowUpAndDown = true;
            this.idtp_FilterAttendance_Out.Size = new System.Drawing.Size(73, 41);
            this.idtp_FilterAttendance_Out.TabIndex = 9;
            this.idtp_FilterAttendance_Out.TabStop = false;
            this.idtp_FilterAttendance_Out.Value = null;
            this.idtp_FilterAttendance_Out.ValueTimeSpan = null;
            // 
            // idtp_FilterAttendance_StartDate
            // 
            this.idtp_FilterAttendance_StartDate.Checked = false;
            this.idtp_FilterAttendance_StartDate.CustomFormat = "dd/MM/yyyy";
            this.idtp_FilterAttendance_StartDate.DefaultCheckedValue = false;
            this.idtp_FilterAttendance_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_FilterAttendance_StartDate.LabelText = "Start";
            this.idtp_FilterAttendance_StartDate.Location = new System.Drawing.Point(83, 11);
            this.idtp_FilterAttendance_StartDate.Margin = new System.Windows.Forms.Padding(4);
            this.idtp_FilterAttendance_StartDate.Name = "idtp_FilterAttendance_StartDate";
            this.idtp_FilterAttendance_StartDate.ShowCheckBox = false;
            this.idtp_FilterAttendance_StartDate.ShowUpAndDown = false;
            this.idtp_FilterAttendance_StartDate.Size = new System.Drawing.Size(99, 41);
            this.idtp_FilterAttendance_StartDate.TabIndex = 14;
            this.idtp_FilterAttendance_StartDate.TabStop = false;
            this.idtp_FilterAttendance_StartDate.Value = null;
            this.idtp_FilterAttendance_StartDate.ValueTimeSpan = null;
            // 
            // idtp_FilterAttendance_EndDate
            // 
            this.idtp_FilterAttendance_EndDate.Checked = false;
            this.idtp_FilterAttendance_EndDate.CustomFormat = "dd/MM/yyyy";
            this.idtp_FilterAttendance_EndDate.DefaultCheckedValue = false;
            this.idtp_FilterAttendance_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_FilterAttendance_EndDate.LabelText = "End";
            this.idtp_FilterAttendance_EndDate.Location = new System.Drawing.Point(83, 52);
            this.idtp_FilterAttendance_EndDate.Margin = new System.Windows.Forms.Padding(4);
            this.idtp_FilterAttendance_EndDate.Name = "idtp_FilterAttendance_EndDate";
            this.idtp_FilterAttendance_EndDate.ShowCheckBox = false;
            this.idtp_FilterAttendance_EndDate.ShowUpAndDown = false;
            this.idtp_FilterAttendance_EndDate.Size = new System.Drawing.Size(99, 41);
            this.idtp_FilterAttendance_EndDate.TabIndex = 15;
            this.idtp_FilterAttendance_EndDate.TabStop = false;
            this.idtp_FilterAttendance_EndDate.Value = null;
            this.idtp_FilterAttendance_EndDate.ValueTimeSpan = null;
            // 
            // btnFilterAttendance
            // 
            this.btnFilterAttendance.Location = new System.Drawing.Point(109, 112);
            this.btnFilterAttendance.Name = "btnFilterAttendance";
            this.btnFilterAttendance.Size = new System.Drawing.Size(73, 23);
            this.btnFilterAttendance.TabIndex = 12;
            this.btnFilterAttendance.TabStop = false;
            this.btnFilterAttendance.Text = "FILTER";
            this.btnFilterAttendance.UseVisualStyleBackColor = true;
            this.btnFilterAttendance.Click += new System.EventHandler(this.btnFilterAttendance_Click);
            // 
            // iddl_DayOfWeek
            // 
            this.iddl_DayOfWeek.DisableTextInput = false;
            this.iddl_DayOfWeek.HideFilter = true;
            this.iddl_DayOfWeek.HideUpdateLink = true;
            this.iddl_DayOfWeek.LabelText = "Day";
            this.iddl_DayOfWeek.Location = new System.Drawing.Point(7, 93);
            this.iddl_DayOfWeek.Margin = new System.Windows.Forms.Padding(4);
            this.iddl_DayOfWeek.Name = "iddl_DayOfWeek";
            this.iddl_DayOfWeek.SelectedItem = null;
            this.iddl_DayOfWeek.SelectedValue = null;
            this.iddl_DayOfWeek.ShowDropdownlistOnly = false;
            this.iddl_DayOfWeek.Size = new System.Drawing.Size(95, 41);
            this.iddl_DayOfWeek.TabIndex = 11;
            this.iddl_DayOfWeek.TabStop = false;
            // 
            // idtp_FilterAttendance_In
            // 
            this.idtp_FilterAttendance_In.Checked = false;
            this.idtp_FilterAttendance_In.CustomFormat = "HH:mm";
            this.idtp_FilterAttendance_In.DefaultCheckedValue = false;
            this.idtp_FilterAttendance_In.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_FilterAttendance_In.LabelText = "IN";
            this.idtp_FilterAttendance_In.Location = new System.Drawing.Point(7, 11);
            this.idtp_FilterAttendance_In.Margin = new System.Windows.Forms.Padding(4);
            this.idtp_FilterAttendance_In.Name = "idtp_FilterAttendance_In";
            this.idtp_FilterAttendance_In.ShowCheckBox = true;
            this.idtp_FilterAttendance_In.ShowUpAndDown = true;
            this.idtp_FilterAttendance_In.Size = new System.Drawing.Size(73, 41);
            this.idtp_FilterAttendance_In.TabIndex = 8;
            this.idtp_FilterAttendance_In.TabStop = false;
            this.idtp_FilterAttendance_In.Value = null;
            this.idtp_FilterAttendance_In.ValueTimeSpan = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.itxt_Notes);
            this.groupBox1.Controls.Add(this.idtp_EffectiveTimestampOut);
            this.groupBox1.Controls.Add(this.idtp_EffectiveTimestampIn);
            this.groupBox1.Controls.Add(this.idtp_TimestampOut);
            this.groupBox1.Controls.Add(this.itxt_Workshift);
            this.groupBox1.Controls.Add(this.itxt_Attendance_Client);
            this.groupBox1.Controls.Add(this.idtp_TimestampIn);
            this.groupBox1.Controls.Add(this.iddl_AttendanceStatuses);
            this.groupBox1.Controls.Add(this.btnSubmitAttendance);
            this.groupBox1.Location = new System.Drawing.Point(194, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ATTENDANCE";
            // 
            // idtp_EffectiveTimestampIn
            // 
            this.idtp_EffectiveTimestampIn.Checked = false;
            this.idtp_EffectiveTimestampIn.CustomFormat = "dd/MM/yyyy HH:mm";
            this.idtp_EffectiveTimestampIn.DefaultCheckedValue = false;
            this.idtp_EffectiveTimestampIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_EffectiveTimestampIn.LabelText = "Effective IN";
            this.idtp_EffectiveTimestampIn.Location = new System.Drawing.Point(7, 94);
            this.idtp_EffectiveTimestampIn.Margin = new System.Windows.Forms.Padding(4);
            this.idtp_EffectiveTimestampIn.Name = "idtp_EffectiveTimestampIn";
            this.idtp_EffectiveTimestampIn.ShowCheckBox = false;
            this.idtp_EffectiveTimestampIn.ShowUpAndDown = false;
            this.idtp_EffectiveTimestampIn.Size = new System.Drawing.Size(133, 41);
            this.idtp_EffectiveTimestampIn.TabIndex = 5;
            this.idtp_EffectiveTimestampIn.Value = null;
            this.idtp_EffectiveTimestampIn.ValueTimeSpan = null;
            // 
            // idtp_EffectiveTimestampOut
            // 
            this.idtp_EffectiveTimestampOut.Checked = false;
            this.idtp_EffectiveTimestampOut.CustomFormat = "dd/MM/yyyy HH:mm";
            this.idtp_EffectiveTimestampOut.DefaultCheckedValue = false;
            this.idtp_EffectiveTimestampOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_EffectiveTimestampOut.LabelText = "Effective OUT";
            this.idtp_EffectiveTimestampOut.Location = new System.Drawing.Point(148, 94);
            this.idtp_EffectiveTimestampOut.Margin = new System.Windows.Forms.Padding(4);
            this.idtp_EffectiveTimestampOut.Name = "idtp_EffectiveTimestampOut";
            this.idtp_EffectiveTimestampOut.ShowCheckBox = false;
            this.idtp_EffectiveTimestampOut.ShowUpAndDown = false;
            this.idtp_EffectiveTimestampOut.Size = new System.Drawing.Size(133, 41);
            this.idtp_EffectiveTimestampOut.TabIndex = 6;
            this.idtp_EffectiveTimestampOut.Value = null;
            this.idtp_EffectiveTimestampOut.ValueTimeSpan = null;
            // 
            // itxt_Workshift
            // 
            this.itxt_Workshift.IsBrowseMode = true;
            this.itxt_Workshift.LabelText = "Workshift";
            this.itxt_Workshift.Location = new System.Drawing.Point(166, 11);
            this.itxt_Workshift.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Workshift.MaxLength = 32767;
            this.itxt_Workshift.MultiLine = false;
            this.itxt_Workshift.Name = "itxt_Workshift";
            this.itxt_Workshift.PasswordChar = '\0';
            this.itxt_Workshift.RowCount = 1;
            this.itxt_Workshift.ShowDeleteButton = true;
            this.itxt_Workshift.ShowTextboxOnly = false;
            this.itxt_Workshift.Size = new System.Drawing.Size(160, 41);
            this.itxt_Workshift.TabIndex = 1;
            this.itxt_Workshift.ValueText = "";
            this.itxt_Workshift.isBrowseMode_Clicked += new System.EventHandler(this.itxt_Workshift_isBrowseMode_Clicked);
            // 
            // itxt_Attendance_Client
            // 
            this.itxt_Attendance_Client.IsBrowseMode = true;
            this.itxt_Attendance_Client.LabelText = "*Client";
            this.itxt_Attendance_Client.Location = new System.Drawing.Point(6, 11);
            this.itxt_Attendance_Client.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Attendance_Client.MaxLength = 32767;
            this.itxt_Attendance_Client.MultiLine = false;
            this.itxt_Attendance_Client.Name = "itxt_Attendance_Client";
            this.itxt_Attendance_Client.PasswordChar = '\0';
            this.itxt_Attendance_Client.RowCount = 1;
            this.itxt_Attendance_Client.ShowDeleteButton = true;
            this.itxt_Attendance_Client.ShowTextboxOnly = false;
            this.itxt_Attendance_Client.Size = new System.Drawing.Size(160, 41);
            this.itxt_Attendance_Client.TabIndex = 0;
            this.itxt_Attendance_Client.ValueText = "";
            this.itxt_Attendance_Client.isBrowseMode_Clicked += new System.EventHandler(this.itxt_Attendance_Client_isBrowseMode_Clicked);
            // 
            // iddl_AttendanceStatuses
            // 
            this.iddl_AttendanceStatuses.DisableTextInput = false;
            this.iddl_AttendanceStatuses.HideFilter = true;
            this.iddl_AttendanceStatuses.HideUpdateLink = true;
            this.iddl_AttendanceStatuses.LabelText = "*Status";
            this.iddl_AttendanceStatuses.Location = new System.Drawing.Point(327, 11);
            this.iddl_AttendanceStatuses.Margin = new System.Windows.Forms.Padding(4);
            this.iddl_AttendanceStatuses.Name = "iddl_AttendanceStatuses";
            this.iddl_AttendanceStatuses.SelectedItem = null;
            this.iddl_AttendanceStatuses.SelectedValue = null;
            this.iddl_AttendanceStatuses.ShowDropdownlistOnly = false;
            this.iddl_AttendanceStatuses.Size = new System.Drawing.Size(111, 41);
            this.iddl_AttendanceStatuses.TabIndex = 2;
            // 
            // btnSubmitAttendance
            // 
            this.btnSubmitAttendance.Location = new System.Drawing.Point(326, 112);
            this.btnSubmitAttendance.Name = "btnSubmitAttendance";
            this.btnSubmitAttendance.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitAttendance.TabIndex = 8;
            this.btnSubmitAttendance.Text = "SUBMIT";
            this.btnSubmitAttendance.UseVisualStyleBackColor = true;
            this.btnSubmitAttendance.Click += new System.EventHandler(this.btnSubmitAttendance_Click);
            // 
            // itxt_Notes
            // 
            this.itxt_Notes.IsBrowseMode = false;
            this.itxt_Notes.LabelText = "Notes";
            this.itxt_Notes.Location = new System.Drawing.Point(289, 52);
            this.itxt_Notes.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Notes.MaxLength = 32767;
            this.itxt_Notes.MultiLine = true;
            this.itxt_Notes.Name = "itxt_Notes";
            this.itxt_Notes.PasswordChar = '\0';
            this.itxt_Notes.RowCount = 2;
            this.itxt_Notes.ShowDeleteButton = false;
            this.itxt_Notes.ShowTextboxOnly = false;
            this.itxt_Notes.Size = new System.Drawing.Size(148, 56);
            this.itxt_Notes.TabIndex = 7;
            this.itxt_Notes.TabStop = false;
            this.itxt_Notes.ValueText = "";
            // 
            // idtp_TimestampIn
            // 
            this.idtp_TimestampIn.Checked = false;
            this.idtp_TimestampIn.CustomFormat = "dd/MM/yyyy HH:mm";
            this.idtp_TimestampIn.DefaultCheckedValue = false;
            this.idtp_TimestampIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_TimestampIn.LabelText = "IN";
            this.idtp_TimestampIn.Location = new System.Drawing.Point(7, 52);
            this.idtp_TimestampIn.Margin = new System.Windows.Forms.Padding(4);
            this.idtp_TimestampIn.Name = "idtp_TimestampIn";
            this.idtp_TimestampIn.ShowCheckBox = false;
            this.idtp_TimestampIn.ShowUpAndDown = false;
            this.idtp_TimestampIn.Size = new System.Drawing.Size(133, 41);
            this.idtp_TimestampIn.TabIndex = 3;
            this.idtp_TimestampIn.Value = null;
            this.idtp_TimestampIn.ValueTimeSpan = null;
            this.idtp_TimestampIn.ValueChanged += new System.EventHandler(this.idtp_TimestampIn_ValueChanged);
            // 
            // idtp_TimestampOut
            // 
            this.idtp_TimestampOut.Checked = false;
            this.idtp_TimestampOut.CustomFormat = "dd/MM/yyyy HH:mm";
            this.idtp_TimestampOut.DefaultCheckedValue = false;
            this.idtp_TimestampOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_TimestampOut.LabelText = "OUT";
            this.idtp_TimestampOut.Location = new System.Drawing.Point(148, 52);
            this.idtp_TimestampOut.Margin = new System.Windows.Forms.Padding(4);
            this.idtp_TimestampOut.Name = "idtp_TimestampOut";
            this.idtp_TimestampOut.ShowCheckBox = false;
            this.idtp_TimestampOut.ShowUpAndDown = false;
            this.idtp_TimestampOut.Size = new System.Drawing.Size(133, 41);
            this.idtp_TimestampOut.TabIndex = 4;
            this.idtp_TimestampOut.Value = null;
            this.idtp_TimestampOut.ValueTimeSpan = null;
            this.idtp_TimestampOut.ValueChanged += new System.EventHandler(this.idtp_TimestampOut_ValueChanged);
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AllowUserToResizeRows = false;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgvAttendance_Id,
            this.col_dgvAttendance_In,
            this.col_dgvAttendance_Out,
            this.col_dgvAttendance_EffectiveIn,
            this.col_dgvAttendance_EffectiveOut,
            this.col_dgvAttendances_EffectiveWorkHours,
            this.col_dgvAttendances_PayableAmount,
            this.col_dgvAttendance_Approved,
            this.col_dgvAttendance_Rejected,
            this.col_dgvAttendance_Flag1,
            this.col_dgvAttendance_Flag2,
            this.col_dgvAttendance_Notes});
            this.dgvAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttendance.Location = new System.Drawing.Point(275, 145);
            this.dgvAttendance.MultiSelect = false;
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(809, 366);
            this.dgvAttendance.TabIndex = 4;
            this.dgvAttendance.TabStop = false;
            this.dgvAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_CellContentClick);
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.Controls.Add(this.ptFilterEmployee);
            this.pnlEmployees.Controls.Add(this.dgvEmployees);
            this.pnlEmployees.Controls.Add(this.pnlFilterEmployees);
            this.pnlEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEmployees.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(275, 511);
            this.pnlEmployees.TabIndex = 5;
            // 
            // ptFilterEmployee
            // 
            this.ptFilterEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptFilterEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.ptFilterEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptFilterEmployee.InitialArrowDirection = System.Windows.Forms.ArrowDirection.Up;
            this.ptFilterEmployee.Location = new System.Drawing.Point(255, 147);
            this.ptFilterEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.ptFilterEmployee.Name = "ptFilterEmployee";
            this.ptFilterEmployee.Size = new System.Drawing.Size(20, 20);
            this.ptFilterEmployee.TabIndex = 7;
            this.ptFilterEmployee.TogglePanel = this.pnlFilterAttendance;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AllowUserToResizeRows = false;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.col_dgvEmployees_UserAccounts_Id,
            this.col_dgvEmployees_Clients_Id,
            this.col_dgvEmployees_UserAccounts_Fullname});
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 145);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(275, 366);
            this.dgvEmployees.TabIndex = 5;
            this.dgvEmployees.TabStop = false;
            this.dgvEmployees.SelectionChanged += new System.EventHandler(this.dgvEmployees_SelectionChanged);
            // 
            // pnlFilterEmployees
            // 
            this.pnlFilterEmployees.Controls.Add(this.groupBox4);
            this.pnlFilterEmployees.Controls.Add(this.groupBox3);
            this.pnlFilterEmployees.Controls.Add(this.btnFilterEmployees);
            this.pnlFilterEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterEmployees.Location = new System.Drawing.Point(0, 0);
            this.pnlFilterEmployees.Name = "pnlFilterEmployees";
            this.pnlFilterEmployees.Size = new System.Drawing.Size(275, 145);
            this.pnlFilterEmployees.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.chkFilterEmployeeByName);
            this.groupBox4.Controls.Add(this.itxt_FilterEmployee_UserAccounts_Name);
            this.groupBox4.Location = new System.Drawing.Point(165, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(107, 66);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // chkFilterEmployeeByName
            // 
            this.chkFilterEmployeeByName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFilterEmployeeByName.AutoSize = true;
            this.chkFilterEmployeeByName.Location = new System.Drawing.Point(92, 8);
            this.chkFilterEmployeeByName.Name = "chkFilterEmployeeByName";
            this.chkFilterEmployeeByName.Size = new System.Drawing.Size(15, 14);
            this.chkFilterEmployeeByName.TabIndex = 7;
            this.chkFilterEmployeeByName.TabStop = false;
            this.chkFilterEmployeeByName.UseVisualStyleBackColor = true;
            this.chkFilterEmployeeByName.CheckedChanged += new System.EventHandler(this.chkFilterEmployees_CheckedChanged);
            // 
            // itxt_FilterEmployee_UserAccounts_Name
            // 
            this.itxt_FilterEmployee_UserAccounts_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itxt_FilterEmployee_UserAccounts_Name.IsBrowseMode = false;
            this.itxt_FilterEmployee_UserAccounts_Name.LabelText = "Employee";
            this.itxt_FilterEmployee_UserAccounts_Name.Location = new System.Drawing.Point(4, 11);
            this.itxt_FilterEmployee_UserAccounts_Name.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_FilterEmployee_UserAccounts_Name.MaxLength = 32767;
            this.itxt_FilterEmployee_UserAccounts_Name.MultiLine = false;
            this.itxt_FilterEmployee_UserAccounts_Name.Name = "itxt_FilterEmployee_UserAccounts_Name";
            this.itxt_FilterEmployee_UserAccounts_Name.PasswordChar = '\0';
            this.itxt_FilterEmployee_UserAccounts_Name.RowCount = 1;
            this.itxt_FilterEmployee_UserAccounts_Name.ShowDeleteButton = false;
            this.itxt_FilterEmployee_UserAccounts_Name.ShowTextboxOnly = false;
            this.itxt_FilterEmployee_UserAccounts_Name.Size = new System.Drawing.Size(98, 41);
            this.itxt_FilterEmployee_UserAccounts_Name.TabIndex = 10;
            this.itxt_FilterEmployee_UserAccounts_Name.TabStop = false;
            this.itxt_FilterEmployee_UserAccounts_Name.ValueText = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkFilterEmployeesByClient);
            this.groupBox3.Controls.Add(this.itxt_FilterEmployee_Client);
            this.groupBox3.Controls.Add(this.idtp_FilterEmployee_StartDate);
            this.groupBox3.Controls.Add(this.idtp_FilterEmployee_EndDate);
            this.groupBox3.Location = new System.Drawing.Point(3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 139);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // chkFilterEmployeesByClient
            // 
            this.chkFilterEmployeesByClient.AutoSize = true;
            this.chkFilterEmployeesByClient.Location = new System.Drawing.Point(143, 8);
            this.chkFilterEmployeesByClient.Name = "chkFilterEmployeesByClient";
            this.chkFilterEmployeesByClient.Size = new System.Drawing.Size(15, 14);
            this.chkFilterEmployeesByClient.TabIndex = 7;
            this.chkFilterEmployeesByClient.TabStop = false;
            this.chkFilterEmployeesByClient.UseVisualStyleBackColor = true;
            this.chkFilterEmployeesByClient.CheckedChanged += new System.EventHandler(this.chkFilterEmployees_CheckedChanged);
            // 
            // itxt_FilterEmployee_Client
            // 
            this.itxt_FilterEmployee_Client.IsBrowseMode = true;
            this.itxt_FilterEmployee_Client.LabelText = "Client";
            this.itxt_FilterEmployee_Client.Location = new System.Drawing.Point(6, 11);
            this.itxt_FilterEmployee_Client.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_FilterEmployee_Client.MaxLength = 32767;
            this.itxt_FilterEmployee_Client.MultiLine = false;
            this.itxt_FilterEmployee_Client.Name = "itxt_FilterEmployee_Client";
            this.itxt_FilterEmployee_Client.PasswordChar = '\0';
            this.itxt_FilterEmployee_Client.RowCount = 1;
            this.itxt_FilterEmployee_Client.ShowDeleteButton = true;
            this.itxt_FilterEmployee_Client.ShowTextboxOnly = false;
            this.itxt_FilterEmployee_Client.Size = new System.Drawing.Size(146, 41);
            this.itxt_FilterEmployee_Client.TabIndex = 9;
            this.itxt_FilterEmployee_Client.TabStop = false;
            this.itxt_FilterEmployee_Client.ValueText = "";
            this.itxt_FilterEmployee_Client.isBrowseMode_Clicked += new System.EventHandler(this.itxt_Client_isBrowseMode_Clicked);
            // 
            // idtp_FilterEmployee_StartDate
            // 
            this.idtp_FilterEmployee_StartDate.Checked = false;
            this.idtp_FilterEmployee_StartDate.CustomFormat = "dd/MM/yyyy";
            this.idtp_FilterEmployee_StartDate.DefaultCheckedValue = false;
            this.idtp_FilterEmployee_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_FilterEmployee_StartDate.LabelText = "Start";
            this.idtp_FilterEmployee_StartDate.Location = new System.Drawing.Point(7, 52);
            this.idtp_FilterEmployee_StartDate.Margin = new System.Windows.Forms.Padding(4);
            this.idtp_FilterEmployee_StartDate.Name = "idtp_FilterEmployee_StartDate";
            this.idtp_FilterEmployee_StartDate.ShowCheckBox = false;
            this.idtp_FilterEmployee_StartDate.ShowUpAndDown = false;
            this.idtp_FilterEmployee_StartDate.Size = new System.Drawing.Size(146, 41);
            this.idtp_FilterEmployee_StartDate.TabIndex = 12;
            this.idtp_FilterEmployee_StartDate.TabStop = false;
            this.idtp_FilterEmployee_StartDate.Value = null;
            this.idtp_FilterEmployee_StartDate.ValueTimeSpan = null;
            // 
            // idtp_FilterEmployee_EndDate
            // 
            this.idtp_FilterEmployee_EndDate.Checked = false;
            this.idtp_FilterEmployee_EndDate.CustomFormat = "dd/MM/yyyy";
            this.idtp_FilterEmployee_EndDate.DefaultCheckedValue = false;
            this.idtp_FilterEmployee_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_FilterEmployee_EndDate.LabelText = "End";
            this.idtp_FilterEmployee_EndDate.Location = new System.Drawing.Point(7, 93);
            this.idtp_FilterEmployee_EndDate.Margin = new System.Windows.Forms.Padding(4);
            this.idtp_FilterEmployee_EndDate.Name = "idtp_FilterEmployee_EndDate";
            this.idtp_FilterEmployee_EndDate.ShowCheckBox = false;
            this.idtp_FilterEmployee_EndDate.ShowUpAndDown = false;
            this.idtp_FilterEmployee_EndDate.Size = new System.Drawing.Size(146, 41);
            this.idtp_FilterEmployee_EndDate.TabIndex = 13;
            this.idtp_FilterEmployee_EndDate.TabStop = false;
            this.idtp_FilterEmployee_EndDate.Value = null;
            this.idtp_FilterEmployee_EndDate.ValueTimeSpan = null;
            // 
            // btnFilterEmployees
            // 
            this.btnFilterEmployees.Location = new System.Drawing.Point(181, 116);
            this.btnFilterEmployees.Name = "btnFilterEmployees";
            this.btnFilterEmployees.Size = new System.Drawing.Size(75, 23);
            this.btnFilterEmployees.TabIndex = 11;
            this.btnFilterEmployees.TabStop = false;
            this.btnFilterEmployees.Text = "FILTER";
            this.btnFilterEmployees.UseVisualStyleBackColor = true;
            this.btnFilterEmployees.Click += new System.EventHandler(this.btnFilterEmployees_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 22;
            // 
            // col_dgvEmployees_UserAccounts_Id
            // 
            this.col_dgvEmployees_UserAccounts_Id.HeaderText = "UserAccounts_Id";
            this.col_dgvEmployees_UserAccounts_Id.Name = "col_dgvEmployees_UserAccounts_Id";
            this.col_dgvEmployees_UserAccounts_Id.ReadOnly = true;
            this.col_dgvEmployees_UserAccounts_Id.Visible = false;
            this.col_dgvEmployees_UserAccounts_Id.Width = 5;
            // 
            // col_dgvEmployees_Clients_Id
            // 
            this.col_dgvEmployees_Clients_Id.HeaderText = "Clients_Id";
            this.col_dgvEmployees_Clients_Id.Name = "col_dgvEmployees_Clients_Id";
            this.col_dgvEmployees_Clients_Id.ReadOnly = true;
            this.col_dgvEmployees_Clients_Id.Visible = false;
            this.col_dgvEmployees_Clients_Id.Width = 5;
            // 
            // col_dgvEmployees_UserAccounts_Fullname
            // 
            this.col_dgvEmployees_UserAccounts_Fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_dgvEmployees_UserAccounts_Fullname.HeaderText = "Employee";
            this.col_dgvEmployees_UserAccounts_Fullname.MinimumWidth = 60;
            this.col_dgvEmployees_UserAccounts_Fullname.Name = "col_dgvEmployees_UserAccounts_Fullname";
            this.col_dgvEmployees_UserAccounts_Fullname.ReadOnly = true;
            this.col_dgvEmployees_UserAccounts_Fullname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_dgvEmployees_UserAccounts_Fullname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_dgvAttendance_Id
            // 
            this.col_dgvAttendance_Id.HeaderText = "Id";
            this.col_dgvAttendance_Id.Name = "col_dgvAttendance_Id";
            this.col_dgvAttendance_Id.ReadOnly = true;
            this.col_dgvAttendance_Id.Visible = false;
            // 
            // col_dgvAttendance_In
            // 
            this.col_dgvAttendance_In.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "MM/dd/yy HH:mm";
            this.col_dgvAttendance_In.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_dgvAttendance_In.HeaderText = "IN";
            this.col_dgvAttendance_In.MinimumWidth = 30;
            this.col_dgvAttendance_In.Name = "col_dgvAttendance_In";
            this.col_dgvAttendance_In.ReadOnly = true;
            this.col_dgvAttendance_In.Width = 30;
            // 
            // col_dgvAttendance_Out
            // 
            this.col_dgvAttendance_Out.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "MM/dd/yy HH:mm";
            this.col_dgvAttendance_Out.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_dgvAttendance_Out.HeaderText = "OUT";
            this.col_dgvAttendance_Out.MinimumWidth = 35;
            this.col_dgvAttendance_Out.Name = "col_dgvAttendance_Out";
            this.col_dgvAttendance_Out.ReadOnly = true;
            this.col_dgvAttendance_Out.Width = 35;
            // 
            // col_dgvAttendance_EffectiveIn
            // 
            this.col_dgvAttendance_EffectiveIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "MM/dd/yy HH:mm";
            this.col_dgvAttendance_EffectiveIn.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_dgvAttendance_EffectiveIn.HeaderText = "Effective IN";
            this.col_dgvAttendance_EffectiveIn.MinimumWidth = 100;
            this.col_dgvAttendance_EffectiveIn.Name = "col_dgvAttendance_EffectiveIn";
            this.col_dgvAttendance_EffectiveIn.ReadOnly = true;
            // 
            // col_dgvAttendance_EffectiveOut
            // 
            this.col_dgvAttendance_EffectiveOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "MM/dd/yy HH:mm";
            this.col_dgvAttendance_EffectiveOut.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_dgvAttendance_EffectiveOut.HeaderText = "Effective OUT";
            this.col_dgvAttendance_EffectiveOut.MinimumWidth = 100;
            this.col_dgvAttendance_EffectiveOut.Name = "col_dgvAttendance_EffectiveOut";
            this.col_dgvAttendance_EffectiveOut.ReadOnly = true;
            // 
            // col_dgvAttendances_EffectiveWorkHours
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.col_dgvAttendances_EffectiveWorkHours.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_dgvAttendances_EffectiveWorkHours.HeaderText = "Hours";
            this.col_dgvAttendances_EffectiveWorkHours.Name = "col_dgvAttendances_EffectiveWorkHours";
            this.col_dgvAttendances_EffectiveWorkHours.ReadOnly = true;
            // 
            // col_dgvAttendances_PayableAmount
            // 
            this.col_dgvAttendances_PayableAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.col_dgvAttendances_PayableAmount.DefaultCellStyle = dataGridViewCellStyle7;
            this.col_dgvAttendances_PayableAmount.HeaderText = "Payable";
            this.col_dgvAttendances_PayableAmount.MinimumWidth = 50;
            this.col_dgvAttendances_PayableAmount.Name = "col_dgvAttendances_PayableAmount";
            this.col_dgvAttendances_PayableAmount.ReadOnly = true;
            this.col_dgvAttendances_PayableAmount.Width = 50;
            // 
            // col_dgvAttendance_Approved
            // 
            this.col_dgvAttendance_Approved.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendance_Approved.HeaderText = "OK";
            this.col_dgvAttendance_Approved.MinimumWidth = 30;
            this.col_dgvAttendance_Approved.Name = "col_dgvAttendance_Approved";
            this.col_dgvAttendance_Approved.Width = 30;
            // 
            // col_dgvAttendance_Rejected
            // 
            this.col_dgvAttendance_Rejected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendance_Rejected.HeaderText = "Rejected";
            this.col_dgvAttendance_Rejected.MinimumWidth = 55;
            this.col_dgvAttendance_Rejected.Name = "col_dgvAttendance_Rejected";
            this.col_dgvAttendance_Rejected.Width = 55;
            // 
            // col_dgvAttendance_Flag1
            // 
            this.col_dgvAttendance_Flag1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendance_Flag1.HeaderText = "Flag1";
            this.col_dgvAttendance_Flag1.MinimumWidth = 40;
            this.col_dgvAttendance_Flag1.Name = "col_dgvAttendance_Flag1";
            this.col_dgvAttendance_Flag1.Width = 40;
            // 
            // col_dgvAttendance_Flag2
            // 
            this.col_dgvAttendance_Flag2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendance_Flag2.HeaderText = "Flag2";
            this.col_dgvAttendance_Flag2.MinimumWidth = 40;
            this.col_dgvAttendance_Flag2.Name = "col_dgvAttendance_Flag2";
            this.col_dgvAttendance_Flag2.Width = 40;
            // 
            // col_dgvAttendance_Notes
            // 
            this.col_dgvAttendance_Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_dgvAttendance_Notes.HeaderText = "Notes";
            this.col_dgvAttendance_Notes.MinimumWidth = 40;
            this.col_dgvAttendance_Notes.Name = "col_dgvAttendance_Notes";
            this.col_dgvAttendance_Notes.ReadOnly = true;
            // 
            // Timesheets_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.pnlContainer);
            this.Name = "Timesheets_Form";
            this.Text = "TIMESHEET";
            this.Load += new System.EventHandler(this.Form_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlFilterAttendance.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.pnlEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.pnlFilterEmployees.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        protected System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Panel pnlFilterAttendance;
        private System.Windows.Forms.Panel pnlEmployees;
        protected System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Panel pnlFilterEmployees;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_FilterEmployee_Client;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Notes;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_TimestampOut;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_TimestampIn;
        private LIBUtil.Desktop.UserControls.PanelToggle ptFilterAttendance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubmitAttendance;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_FilterAttendance_In;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_FilterAttendance_Out;
        private LIBUtil.Desktop.UserControls.InputControl_Numeric in_DurationMinutes;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_FilterEmployee_UserAccounts_Name;
        private System.Windows.Forms.Button btnFilterEmployees;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_FilterEmployee_StartDate;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_FilterEmployee_EndDate;
        private LIBUtil.Desktop.UserControls.PanelToggle ptFilterEmployee;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkFilterEmployeesByClient;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkFilterEmployeeByName;
        private System.Windows.Forms.Button btnFilterAttendance;
        private LIBUtil.Desktop.UserControls.InputControl_Dropdownlist iddl_AttendanceStatuses;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Attendance_Client;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Workshift;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_FilterAttendance_StartDate;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_FilterAttendance_EndDate;
        private LIBUtil.Desktop.UserControls.InputControl_Dropdownlist iddl_DayOfWeek;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_EffectiveTimestampIn;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_EffectiveTimestampOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvEmployees_UserAccounts_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvEmployees_Clients_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvEmployees_UserAccounts_Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendance_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendance_In;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendance_Out;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendance_EffectiveIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendance_EffectiveOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendances_EffectiveWorkHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendances_PayableAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_dgvAttendance_Approved;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_dgvAttendance_Rejected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_dgvAttendance_Flag1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_dgvAttendance_Flag2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendance_Notes;
    }
}