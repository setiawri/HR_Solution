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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFilterAttendance = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itxt_UserAccount = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.idtp_FilterAttendance_In = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.idtp_FilterAttendance_Out = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.btnFilterAttendance = new System.Windows.Forms.Button();
            this.iddl_AttendanceStatuses = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
            this.iddl_DayOfWeek = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
            this.idtp_FilterAttendance_StartDate = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.itxt_FilterEmployee_Client = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.idtp_FilterAttendance_EndDate = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.btnAddAttendance = new System.Windows.Forms.Button();
            this.btnGeneratePayroll = new System.Windows.Forms.Button();
            this.dgvAttendances = new System.Windows.Forms.DataGridView();
            this.col_dgvAttendances_Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_dgvAttendances_Employee_UserAccounts_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendances_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendances_Payrolls_HasPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendances_PayrollItems_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendances_Employee_UserAccounts_Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendances_Clients_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendances_Workshifts_DayOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendances_In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendances_Out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendances_EffectiveIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendances_EffectiveOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendances_EffectiveWorkHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendances_PayRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendances_Approved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_dgvAttendances_Rejected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_dgvAttendances_Flag1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_dgvAttendances_Flag2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_dgvAttendances_Payrolls_No = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_dgvAttendances_Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pnlFilterAttendance.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendances)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilterAttendance
            // 
            this.pnlFilterAttendance.Controls.Add(this.groupBox1);
            this.pnlFilterAttendance.Controls.Add(this.btnAddAttendance);
            this.pnlFilterAttendance.Controls.Add(this.btnGeneratePayroll);
            this.pnlFilterAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterAttendance.Location = new System.Drawing.Point(0, 0);
            this.pnlFilterAttendance.Name = "pnlFilterAttendance";
            this.pnlFilterAttendance.Size = new System.Drawing.Size(1028, 139);
            this.pnlFilterAttendance.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.itxt_UserAccount);
            this.groupBox1.Controls.Add(this.idtp_FilterAttendance_In);
            this.groupBox1.Controls.Add(this.btnFilterAttendance);
            this.groupBox1.Controls.Add(this.idtp_FilterAttendance_Out);
            this.groupBox1.Controls.Add(this.iddl_AttendanceStatuses);
            this.groupBox1.Controls.Add(this.iddl_DayOfWeek);
            this.groupBox1.Controls.Add(this.idtp_FilterAttendance_StartDate);
            this.groupBox1.Controls.Add(this.itxt_FilterEmployee_Client);
            this.groupBox1.Controls.Add(this.idtp_FilterAttendance_EndDate);
            this.groupBox1.Location = new System.Drawing.Point(155, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 129);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTER";
            // 
            // itxt_UserAccount
            // 
            this.itxt_UserAccount.IsBrowseMode = true;
            this.itxt_UserAccount.LabelText = "Employee";
            this.itxt_UserAccount.Location = new System.Drawing.Point(7, 12);
            this.itxt_UserAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itxt_UserAccount.MaxLength = 32767;
            this.itxt_UserAccount.MultiLine = false;
            this.itxt_UserAccount.Name = "itxt_UserAccount";
            this.itxt_UserAccount.PasswordChar = '\0';
            this.itxt_UserAccount.RowCount = 1;
            this.itxt_UserAccount.ShowDeleteButton = true;
            this.itxt_UserAccount.ShowTextboxOnly = false;
            this.itxt_UserAccount.Size = new System.Drawing.Size(146, 41);
            this.itxt_UserAccount.TabIndex = 13;
            this.itxt_UserAccount.TabStop = false;
            this.itxt_UserAccount.ValueText = "";
            this.itxt_UserAccount.isBrowseMode_Clicked += new System.EventHandler(this.itxt_UserAccount_isBrowseMode_Clicked);
            // 
            // idtp_FilterAttendance_In
            // 
            this.idtp_FilterAttendance_In.Checked = false;
            this.idtp_FilterAttendance_In.CustomFormat = "HH:mm";
            this.idtp_FilterAttendance_In.DefaultCheckedValue = false;
            this.idtp_FilterAttendance_In.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_FilterAttendance_In.LabelText = "IN";
            this.idtp_FilterAttendance_In.Location = new System.Drawing.Point(268, 12);
            this.idtp_FilterAttendance_In.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idtp_FilterAttendance_In.Name = "idtp_FilterAttendance_In";
            this.idtp_FilterAttendance_In.ShowCheckBox = true;
            this.idtp_FilterAttendance_In.ShowUpAndDown = true;
            this.idtp_FilterAttendance_In.Size = new System.Drawing.Size(73, 41);
            this.idtp_FilterAttendance_In.TabIndex = 8;
            this.idtp_FilterAttendance_In.TabStop = false;
            this.idtp_FilterAttendance_In.Value = null;
            this.idtp_FilterAttendance_In.ValueTimeSpan = null;
            // 
            // idtp_FilterAttendance_Out
            // 
            this.idtp_FilterAttendance_Out.Checked = false;
            this.idtp_FilterAttendance_Out.CustomFormat = "HH:mm";
            this.idtp_FilterAttendance_Out.DefaultCheckedValue = false;
            this.idtp_FilterAttendance_Out.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_FilterAttendance_Out.LabelText = "OUT";
            this.idtp_FilterAttendance_Out.Location = new System.Drawing.Point(268, 53);
            this.idtp_FilterAttendance_Out.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idtp_FilterAttendance_Out.Name = "idtp_FilterAttendance_Out";
            this.idtp_FilterAttendance_Out.ShowCheckBox = true;
            this.idtp_FilterAttendance_Out.ShowUpAndDown = true;
            this.idtp_FilterAttendance_Out.Size = new System.Drawing.Size(73, 41);
            this.idtp_FilterAttendance_Out.TabIndex = 9;
            this.idtp_FilterAttendance_Out.TabStop = false;
            this.idtp_FilterAttendance_Out.Value = null;
            this.idtp_FilterAttendance_Out.ValueTimeSpan = null;
            // 
            // btnFilterAttendance
            // 
            this.btnFilterAttendance.Location = new System.Drawing.Point(98, 97);
            this.btnFilterAttendance.Name = "btnFilterAttendance";
            this.btnFilterAttendance.Size = new System.Drawing.Size(73, 23);
            this.btnFilterAttendance.TabIndex = 12;
            this.btnFilterAttendance.TabStop = false;
            this.btnFilterAttendance.Text = "FILTER";
            this.btnFilterAttendance.UseVisualStyleBackColor = true;
            this.btnFilterAttendance.Click += new System.EventHandler(this.btnFilterAttendance_Click);
            // 
            // iddl_AttendanceStatuses
            // 
            this.iddl_AttendanceStatuses.DisableTextInput = false;
            this.iddl_AttendanceStatuses.HideFilter = true;
            this.iddl_AttendanceStatuses.HideUpdateLink = true;
            this.iddl_AttendanceStatuses.LabelText = "Status";
            this.iddl_AttendanceStatuses.Location = new System.Drawing.Point(349, 53);
            this.iddl_AttendanceStatuses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iddl_AttendanceStatuses.Name = "iddl_AttendanceStatuses";
            this.iddl_AttendanceStatuses.SelectedIndex = -1;
            this.iddl_AttendanceStatuses.SelectedItem = null;
            this.iddl_AttendanceStatuses.SelectedItemText = "";
            this.iddl_AttendanceStatuses.SelectedValue = null;
            this.iddl_AttendanceStatuses.ShowDropdownlistOnly = false;
            this.iddl_AttendanceStatuses.Size = new System.Drawing.Size(111, 41);
            this.iddl_AttendanceStatuses.TabIndex = 2;
            // 
            // iddl_DayOfWeek
            // 
            this.iddl_DayOfWeek.DisableTextInput = false;
            this.iddl_DayOfWeek.HideFilter = true;
            this.iddl_DayOfWeek.HideUpdateLink = true;
            this.iddl_DayOfWeek.LabelText = "Day";
            this.iddl_DayOfWeek.Location = new System.Drawing.Point(349, 12);
            this.iddl_DayOfWeek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iddl_DayOfWeek.Name = "iddl_DayOfWeek";
            this.iddl_DayOfWeek.SelectedIndex = -1;
            this.iddl_DayOfWeek.SelectedItem = null;
            this.iddl_DayOfWeek.SelectedItemText = "";
            this.iddl_DayOfWeek.SelectedValue = null;
            this.iddl_DayOfWeek.ShowDropdownlistOnly = false;
            this.iddl_DayOfWeek.Size = new System.Drawing.Size(111, 41);
            this.iddl_DayOfWeek.TabIndex = 11;
            this.iddl_DayOfWeek.TabStop = false;
            // 
            // idtp_FilterAttendance_StartDate
            // 
            this.idtp_FilterAttendance_StartDate.Checked = true;
            this.idtp_FilterAttendance_StartDate.CustomFormat = "dd/MM/yyyy";
            this.idtp_FilterAttendance_StartDate.DefaultCheckedValue = false;
            this.idtp_FilterAttendance_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_FilterAttendance_StartDate.LabelText = "Start";
            this.idtp_FilterAttendance_StartDate.Location = new System.Drawing.Point(161, 12);
            this.idtp_FilterAttendance_StartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idtp_FilterAttendance_StartDate.Name = "idtp_FilterAttendance_StartDate";
            this.idtp_FilterAttendance_StartDate.ShowCheckBox = false;
            this.idtp_FilterAttendance_StartDate.ShowUpAndDown = false;
            this.idtp_FilterAttendance_StartDate.Size = new System.Drawing.Size(99, 41);
            this.idtp_FilterAttendance_StartDate.TabIndex = 14;
            this.idtp_FilterAttendance_StartDate.TabStop = false;
            this.idtp_FilterAttendance_StartDate.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.idtp_FilterAttendance_StartDate.ValueTimeSpan = System.TimeSpan.Parse("00:00:00");
            // 
            // itxt_FilterEmployee_Client
            // 
            this.itxt_FilterEmployee_Client.IsBrowseMode = true;
            this.itxt_FilterEmployee_Client.LabelText = "Client";
            this.itxt_FilterEmployee_Client.Location = new System.Drawing.Point(7, 53);
            this.itxt_FilterEmployee_Client.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.itxt_FilterEmployee_Client.isBrowseMode_Clicked += new System.EventHandler(this.itxt_FilterEmployee_Client_isBrowseMode_Clicked);
            // 
            // idtp_FilterAttendance_EndDate
            // 
            this.idtp_FilterAttendance_EndDate.Checked = true;
            this.idtp_FilterAttendance_EndDate.CustomFormat = "dd/MM/yyyy";
            this.idtp_FilterAttendance_EndDate.DefaultCheckedValue = false;
            this.idtp_FilterAttendance_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_FilterAttendance_EndDate.LabelText = "End";
            this.idtp_FilterAttendance_EndDate.Location = new System.Drawing.Point(161, 53);
            this.idtp_FilterAttendance_EndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idtp_FilterAttendance_EndDate.Name = "idtp_FilterAttendance_EndDate";
            this.idtp_FilterAttendance_EndDate.ShowCheckBox = false;
            this.idtp_FilterAttendance_EndDate.ShowUpAndDown = false;
            this.idtp_FilterAttendance_EndDate.Size = new System.Drawing.Size(99, 41);
            this.idtp_FilterAttendance_EndDate.TabIndex = 15;
            this.idtp_FilterAttendance_EndDate.TabStop = false;
            this.idtp_FilterAttendance_EndDate.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.idtp_FilterAttendance_EndDate.ValueTimeSpan = System.TimeSpan.Parse("00:00:00");
            // 
            // btnAddAttendance
            // 
            this.btnAddAttendance.Location = new System.Drawing.Point(3, 110);
            this.btnAddAttendance.Name = "btnAddAttendance";
            this.btnAddAttendance.Size = new System.Drawing.Size(146, 23);
            this.btnAddAttendance.TabIndex = 16;
            this.btnAddAttendance.Text = "ADD ATTENDANCE";
            this.btnAddAttendance.UseVisualStyleBackColor = true;
            this.btnAddAttendance.Click += new System.EventHandler(this.btnAddAttendance_Click);
            // 
            // btnGeneratePayroll
            // 
            this.btnGeneratePayroll.Location = new System.Drawing.Point(3, 81);
            this.btnGeneratePayroll.Name = "btnGeneratePayroll";
            this.btnGeneratePayroll.Size = new System.Drawing.Size(146, 23);
            this.btnGeneratePayroll.TabIndex = 9;
            this.btnGeneratePayroll.Text = "GENERATE PAYROLL";
            this.btnGeneratePayroll.UseVisualStyleBackColor = true;
            this.btnGeneratePayroll.Click += new System.EventHandler(this.btnGeneratePayroll_Click);
            // 
            // dgvAttendances
            // 
            this.dgvAttendances.AllowUserToAddRows = false;
            this.dgvAttendances.AllowUserToDeleteRows = false;
            this.dgvAttendances.AllowUserToResizeRows = false;
            this.dgvAttendances.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendances.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttendances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgvAttendances_Checkbox,
            this.col_dgvAttendances_Employee_UserAccounts_Id,
            this.col_dgvAttendances_Id,
            this.col_dgvAttendances_Payrolls_HasPayment,
            this.col_dgvAttendances_PayrollItems_Id,
            this.col_dgvAttendances_Employee_UserAccounts_Fullname,
            this.col_dgvAttendances_Clients_Name,
            this.col_dgvAttendances_Workshifts_DayOfWeek,
            this.col_dgvAttendances_In,
            this.col_dgvAttendances_Out,
            this.col_dgvAttendances_EffectiveIn,
            this.col_dgvAttendances_EffectiveOut,
            this.col_dgvAttendances_EffectiveWorkHours,
            this.col_dgvAttendances_PayRate,
            this.col_dgvAttendances_Approved,
            this.col_dgvAttendances_Rejected,
            this.col_dgvAttendances_Flag1,
            this.col_dgvAttendances_Flag2,
            this.col_dgvAttendances_Payrolls_No,
            this.col_dgvAttendances_Notes});
            this.dgvAttendances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttendances.Location = new System.Drawing.Point(0, 139);
            this.dgvAttendances.MultiSelect = false;
            this.dgvAttendances.Name = "dgvAttendances";
            this.dgvAttendances.RowHeadersVisible = false;
            this.dgvAttendances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendances.Size = new System.Drawing.Size(1028, 372);
            this.dgvAttendances.TabIndex = 4;
            this.dgvAttendances.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendances_CellContentClick);
            // 
            // col_dgvAttendances_Checkbox
            // 
            this.col_dgvAttendances_Checkbox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendances_Checkbox.HeaderText = "";
            this.col_dgvAttendances_Checkbox.MinimumWidth = 30;
            this.col_dgvAttendances_Checkbox.Name = "col_dgvAttendances_Checkbox";
            this.col_dgvAttendances_Checkbox.ReadOnly = true;
            this.col_dgvAttendances_Checkbox.Width = 30;
            // 
            // col_dgvAttendances_Employee_UserAccounts_Id
            // 
            this.col_dgvAttendances_Employee_UserAccounts_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendances_Employee_UserAccounts_Id.HeaderText = "Employee_UserAccounts_Id";
            this.col_dgvAttendances_Employee_UserAccounts_Id.Name = "col_dgvAttendances_Employee_UserAccounts_Id";
            this.col_dgvAttendances_Employee_UserAccounts_Id.Visible = false;
            this.col_dgvAttendances_Employee_UserAccounts_Id.Width = 5;
            // 
            // col_dgvAttendances_Id
            // 
            this.col_dgvAttendances_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendances_Id.HeaderText = "Id";
            this.col_dgvAttendances_Id.Name = "col_dgvAttendances_Id";
            this.col_dgvAttendances_Id.ReadOnly = true;
            this.col_dgvAttendances_Id.Visible = false;
            this.col_dgvAttendances_Id.Width = 5;
            // 
            // col_dgvAttendances_Payrolls_HasPayment
            // 
            this.col_dgvAttendances_Payrolls_HasPayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendances_Payrolls_HasPayment.HeaderText = "HasPayment";
            this.col_dgvAttendances_Payrolls_HasPayment.MinimumWidth = 30;
            this.col_dgvAttendances_Payrolls_HasPayment.Name = "col_dgvAttendances_Payrolls_HasPayment";
            this.col_dgvAttendances_Payrolls_HasPayment.Visible = false;
            this.col_dgvAttendances_Payrolls_HasPayment.Width = 30;
            // 
            // col_dgvAttendances_PayrollItems_Id
            // 
            this.col_dgvAttendances_PayrollItems_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendances_PayrollItems_Id.HeaderText = "PayrollItems_Id";
            this.col_dgvAttendances_PayrollItems_Id.Name = "col_dgvAttendances_PayrollItems_Id";
            this.col_dgvAttendances_PayrollItems_Id.Visible = false;
            this.col_dgvAttendances_PayrollItems_Id.Width = 5;
            // 
            // col_dgvAttendances_Employee_UserAccounts_Fullname
            // 
            this.col_dgvAttendances_Employee_UserAccounts_Fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendances_Employee_UserAccounts_Fullname.HeaderText = "Employee";
            this.col_dgvAttendances_Employee_UserAccounts_Fullname.MinimumWidth = 65;
            this.col_dgvAttendances_Employee_UserAccounts_Fullname.Name = "col_dgvAttendances_Employee_UserAccounts_Fullname";
            this.col_dgvAttendances_Employee_UserAccounts_Fullname.Width = 65;
            // 
            // col_dgvAttendances_Clients_Name
            // 
            this.col_dgvAttendances_Clients_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendances_Clients_Name.HeaderText = "Clients";
            this.col_dgvAttendances_Clients_Name.MinimumWidth = 50;
            this.col_dgvAttendances_Clients_Name.Name = "col_dgvAttendances_Clients_Name";
            this.col_dgvAttendances_Clients_Name.Width = 50;
            // 
            // col_dgvAttendances_Workshifts_DayOfWeek
            // 
            this.col_dgvAttendances_Workshifts_DayOfWeek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendances_Workshifts_DayOfWeek.HeaderText = "Day";
            this.col_dgvAttendances_Workshifts_DayOfWeek.MinimumWidth = 40;
            this.col_dgvAttendances_Workshifts_DayOfWeek.Name = "col_dgvAttendances_Workshifts_DayOfWeek";
            this.col_dgvAttendances_Workshifts_DayOfWeek.Width = 40;
            // 
            // col_dgvAttendances_In
            // 
            this.col_dgvAttendances_In.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "MM/dd/yy HH:mm";
            this.col_dgvAttendances_In.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_dgvAttendances_In.HeaderText = "IN";
            this.col_dgvAttendances_In.MinimumWidth = 30;
            this.col_dgvAttendances_In.Name = "col_dgvAttendances_In";
            this.col_dgvAttendances_In.ReadOnly = true;
            this.col_dgvAttendances_In.Width = 30;
            // 
            // col_dgvAttendances_Out
            // 
            this.col_dgvAttendances_Out.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "MM/dd/yy HH:mm";
            this.col_dgvAttendances_Out.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_dgvAttendances_Out.HeaderText = "OUT";
            this.col_dgvAttendances_Out.MinimumWidth = 40;
            this.col_dgvAttendances_Out.Name = "col_dgvAttendances_Out";
            this.col_dgvAttendances_Out.ReadOnly = true;
            this.col_dgvAttendances_Out.Width = 40;
            // 
            // col_dgvAttendances_EffectiveIn
            // 
            this.col_dgvAttendances_EffectiveIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "MM/dd/yy HH:mm";
            this.col_dgvAttendances_EffectiveIn.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_dgvAttendances_EffectiveIn.HeaderText = "Effective IN";
            this.col_dgvAttendances_EffectiveIn.MinimumWidth = 120;
            this.col_dgvAttendances_EffectiveIn.Name = "col_dgvAttendances_EffectiveIn";
            this.col_dgvAttendances_EffectiveIn.ReadOnly = true;
            this.col_dgvAttendances_EffectiveIn.Width = 120;
            // 
            // col_dgvAttendances_EffectiveOut
            // 
            this.col_dgvAttendances_EffectiveOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "MM/dd/yy HH:mm";
            this.col_dgvAttendances_EffectiveOut.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_dgvAttendances_EffectiveOut.HeaderText = "Effective OUT";
            this.col_dgvAttendances_EffectiveOut.MinimumWidth = 130;
            this.col_dgvAttendances_EffectiveOut.Name = "col_dgvAttendances_EffectiveOut";
            this.col_dgvAttendances_EffectiveOut.ReadOnly = true;
            this.col_dgvAttendances_EffectiveOut.Width = 130;
            // 
            // col_dgvAttendances_EffectiveWorkHours
            // 
            this.col_dgvAttendances_EffectiveWorkHours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.col_dgvAttendances_EffectiveWorkHours.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_dgvAttendances_EffectiveWorkHours.HeaderText = "Hours";
            this.col_dgvAttendances_EffectiveWorkHours.MinimumWidth = 40;
            this.col_dgvAttendances_EffectiveWorkHours.Name = "col_dgvAttendances_EffectiveWorkHours";
            this.col_dgvAttendances_EffectiveWorkHours.ReadOnly = true;
            this.col_dgvAttendances_EffectiveWorkHours.Width = 40;
            // 
            // col_dgvAttendances_PayRate
            // 
            this.col_dgvAttendances_PayRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            this.col_dgvAttendances_PayRate.DefaultCellStyle = dataGridViewCellStyle7;
            this.col_dgvAttendances_PayRate.HeaderText = "PayRate";
            this.col_dgvAttendances_PayRate.MinimumWidth = 60;
            this.col_dgvAttendances_PayRate.Name = "col_dgvAttendances_PayRate";
            this.col_dgvAttendances_PayRate.Width = 60;
            // 
            // col_dgvAttendances_Approved
            // 
            this.col_dgvAttendances_Approved.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendances_Approved.HeaderText = "OK";
            this.col_dgvAttendances_Approved.MinimumWidth = 30;
            this.col_dgvAttendances_Approved.Name = "col_dgvAttendances_Approved";
            this.col_dgvAttendances_Approved.Width = 30;
            // 
            // col_dgvAttendances_Rejected
            // 
            this.col_dgvAttendances_Rejected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendances_Rejected.HeaderText = "NO";
            this.col_dgvAttendances_Rejected.MinimumWidth = 30;
            this.col_dgvAttendances_Rejected.Name = "col_dgvAttendances_Rejected";
            this.col_dgvAttendances_Rejected.Width = 30;
            // 
            // col_dgvAttendances_Flag1
            // 
            this.col_dgvAttendances_Flag1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendances_Flag1.HeaderText = "Flag1";
            this.col_dgvAttendances_Flag1.MinimumWidth = 40;
            this.col_dgvAttendances_Flag1.Name = "col_dgvAttendances_Flag1";
            this.col_dgvAttendances_Flag1.Width = 40;
            // 
            // col_dgvAttendances_Flag2
            // 
            this.col_dgvAttendances_Flag2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendances_Flag2.HeaderText = "Flag2";
            this.col_dgvAttendances_Flag2.MinimumWidth = 40;
            this.col_dgvAttendances_Flag2.Name = "col_dgvAttendances_Flag2";
            this.col_dgvAttendances_Flag2.Width = 40;
            // 
            // col_dgvAttendances_Payrolls_No
            // 
            this.col_dgvAttendances_Payrolls_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendances_Payrolls_No.HeaderText = "Payrolls";
            this.col_dgvAttendances_Payrolls_No.MinimumWidth = 50;
            this.col_dgvAttendances_Payrolls_No.Name = "col_dgvAttendances_Payrolls_No";
            this.col_dgvAttendances_Payrolls_No.Width = 50;
            // 
            // col_dgvAttendances_Notes
            // 
            this.col_dgvAttendances_Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_dgvAttendances_Notes.HeaderText = "Notes";
            this.col_dgvAttendances_Notes.MinimumWidth = 40;
            this.col_dgvAttendances_Notes.Name = "col_dgvAttendances_Notes";
            this.col_dgvAttendances_Notes.ReadOnly = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "not in payroll";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Timesheets_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 511);
            this.Controls.Add(this.dgvAttendances);
            this.Controls.Add(this.pnlFilterAttendance);
            this.Name = "Timesheets_Form";
            this.Text = "TIMESHEET";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.pnlFilterAttendance.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendances)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.DataGridView dgvAttendances;
        private System.Windows.Forms.Panel pnlFilterAttendance;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_FilterEmployee_Client;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_FilterAttendance_In;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_FilterAttendance_Out;
        private System.Windows.Forms.Button btnFilterAttendance;
        private LIBUtil.Desktop.UserControls.InputControl_Dropdownlist iddl_AttendanceStatuses;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_FilterAttendance_StartDate;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_FilterAttendance_EndDate;
        private LIBUtil.Desktop.UserControls.InputControl_Dropdownlist iddl_DayOfWeek;
        private System.Windows.Forms.Button btnGeneratePayroll;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_UserAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddAttendance;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_dgvAttendances_Checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendances_Employee_UserAccounts_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendances_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendances_Payrolls_HasPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendances_PayrollItems_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendances_Employee_UserAccounts_Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendances_Clients_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendances_Workshifts_DayOfWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendances_In;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendances_Out;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendances_EffectiveIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendances_EffectiveOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendances_EffectiveWorkHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendances_PayRate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_dgvAttendances_Approved;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_dgvAttendances_Rejected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_dgvAttendances_Flag1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_dgvAttendances_Flag2;
        private System.Windows.Forms.DataGridViewLinkColumn col_dgvAttendances_Payrolls_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendances_Notes;
    }
}