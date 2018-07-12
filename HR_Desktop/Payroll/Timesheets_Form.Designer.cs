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
            this.pnlFilterEmployees = new System.Windows.Forms.Panel();
            this.ptFilterAttendance = new LIBUtil.Desktop.UserControls.PanelToggle();
            this.pnlFilterAttendance = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFilterAttendance = new System.Windows.Forms.Button();
            this.iddl_DayOfWeek = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
            this.idtp_FilterAttendance_In = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.idtp_FilterAttendance_Out = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubmitAttendance = new System.Windows.Forms.Button();
            this.itxt_Notes = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.idtp_TimestampIn = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.idtp_TimestampOut = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.col_dgvAttendance_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendance_In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendance_Out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendance_Flag1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_dgvAttendance_Flag2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_dgvAttendance_Approved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_dgvAttendance_Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEmployees = new System.Windows.Forms.Panel();
            this.ptFilterEmployee = new LIBUtil.Desktop.UserControls.PanelToggle();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvEmployees_UserAccounts_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvEmployees_Clients_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvEmployees_UserAccounts_Fullname = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_dgvEmployees_Clients_CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkFilterEmployeeByName = new System.Windows.Forms.CheckBox();
            this.itxt_FilterEmployee_UserAccounts_Name = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkFilterEmployeesByClient = new System.Windows.Forms.CheckBox();
            this.itxt_FilterEmployee_Client = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.idtp_FilterEmployee_StartDate = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.idtp_FilterEmployee_EndDate = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.btnFilterEmployees = new System.Windows.Forms.Button();
            this.pnlFilterEmployees.SuspendLayout();
            this.pnlFilterAttendance.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.pnlEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilterEmployees
            // 
            this.pnlFilterEmployees.Controls.Add(this.ptFilterAttendance);
            this.pnlFilterEmployees.Controls.Add(this.dgvAttendance);
            this.pnlFilterEmployees.Controls.Add(this.pnlFilterAttendance);
            this.pnlFilterEmployees.Controls.Add(this.pnlEmployees);
            this.pnlFilterEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilterEmployees.Location = new System.Drawing.Point(0, 0);
            this.pnlFilterEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFilterEmployees.Name = "pnlFilterEmployees";
            this.pnlFilterEmployees.Size = new System.Drawing.Size(1184, 612);
            this.pnlFilterEmployees.TabIndex = 0;
            // 
            // ptFilterAttendance
            // 
            this.ptFilterAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptFilterAttendance.BackColor = System.Drawing.SystemColors.Control;
            this.ptFilterAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptFilterAttendance.InitialArrowDirection = System.Windows.Forms.ArrowDirection.Up;
            this.ptFilterAttendance.Location = new System.Drawing.Point(1157, 160);
            this.ptFilterAttendance.Margin = new System.Windows.Forms.Padding(5);
            this.ptFilterAttendance.Name = "ptFilterAttendance";
            this.ptFilterAttendance.Size = new System.Drawing.Size(26, 24);
            this.ptFilterAttendance.TabIndex = 6;
            this.ptFilterAttendance.TogglePanel = this.pnlFilterAttendance;
            // 
            // pnlFilterAttendance
            // 
            this.pnlFilterAttendance.Controls.Add(this.groupBox2);
            this.pnlFilterAttendance.Controls.Add(this.groupBox1);
            this.pnlFilterAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterAttendance.Location = new System.Drawing.Point(431, 0);
            this.pnlFilterAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFilterAttendance.Name = "pnlFilterAttendance";
            this.pnlFilterAttendance.Size = new System.Drawing.Size(753, 171);
            this.pnlFilterAttendance.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnFilterAttendance);
            this.groupBox2.Controls.Add(this.iddl_DayOfWeek);
            this.groupBox2.Controls.Add(this.idtp_FilterAttendance_In);
            this.groupBox2.Controls.Add(this.idtp_FilterAttendance_Out);
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(272, 162);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FILTER";
            // 
            // btnFilterAttendance
            // 
            this.btnFilterAttendance.Location = new System.Drawing.Point(87, 127);
            this.btnFilterAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterAttendance.Name = "btnFilterAttendance";
            this.btnFilterAttendance.Size = new System.Drawing.Size(100, 28);
            this.btnFilterAttendance.TabIndex = 12;
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
            this.iddl_DayOfWeek.Location = new System.Drawing.Point(8, 69);
            this.iddl_DayOfWeek.Margin = new System.Windows.Forms.Padding(5);
            this.iddl_DayOfWeek.Name = "iddl_DayOfWeek";
            this.iddl_DayOfWeek.SelectedItem = null;
            this.iddl_DayOfWeek.SelectedValue = null;
            this.iddl_DayOfWeek.ShowDropdownlistOnly = false;
            this.iddl_DayOfWeek.Size = new System.Drawing.Size(97, 50);
            this.iddl_DayOfWeek.TabIndex = 11;
            // 
            // idtp_FilterAttendance_In
            // 
            this.idtp_FilterAttendance_In.CustomFormat = "HH:mm";
            this.idtp_FilterAttendance_In.DefaultCheckedValue = false;
            this.idtp_FilterAttendance_In.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_FilterAttendance_In.LabelText = "IN";
            this.idtp_FilterAttendance_In.Location = new System.Drawing.Point(8, 17);
            this.idtp_FilterAttendance_In.Margin = new System.Windows.Forms.Padding(5);
            this.idtp_FilterAttendance_In.Name = "idtp_FilterAttendance_In";
            this.idtp_FilterAttendance_In.ShowCheckBox = true;
            this.idtp_FilterAttendance_In.ShowUpAndDown = false;
            this.idtp_FilterAttendance_In.Size = new System.Drawing.Size(97, 50);
            this.idtp_FilterAttendance_In.TabIndex = 8;
            this.idtp_FilterAttendance_In.Value = null;
            this.idtp_FilterAttendance_In.ValueTimeSpan = null;
            // 
            // idtp_FilterAttendance_Out
            // 
            this.idtp_FilterAttendance_Out.CustomFormat = "HH:mm";
            this.idtp_FilterAttendance_Out.DefaultCheckedValue = false;
            this.idtp_FilterAttendance_Out.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_FilterAttendance_Out.LabelText = "OUT";
            this.idtp_FilterAttendance_Out.Location = new System.Drawing.Point(113, 17);
            this.idtp_FilterAttendance_Out.Margin = new System.Windows.Forms.Padding(5);
            this.idtp_FilterAttendance_Out.Name = "idtp_FilterAttendance_Out";
            this.idtp_FilterAttendance_Out.ShowCheckBox = true;
            this.idtp_FilterAttendance_Out.ShowUpAndDown = false;
            this.idtp_FilterAttendance_Out.Size = new System.Drawing.Size(97, 50);
            this.idtp_FilterAttendance_Out.TabIndex = 9;
            this.idtp_FilterAttendance_Out.Value = null;
            this.idtp_FilterAttendance_Out.ValueTimeSpan = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSubmitAttendance);
            this.groupBox1.Controls.Add(this.itxt_Notes);
            this.groupBox1.Controls.Add(this.idtp_TimestampIn);
            this.groupBox1.Controls.Add(this.idtp_TimestampOut);
            this.groupBox1.Location = new System.Drawing.Point(283, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(465, 162);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendance";
            // 
            // btnSubmitAttendance
            // 
            this.btnSubmitAttendance.Location = new System.Drawing.Point(55, 118);
            this.btnSubmitAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitAttendance.Name = "btnSubmitAttendance";
            this.btnSubmitAttendance.Size = new System.Drawing.Size(100, 28);
            this.btnSubmitAttendance.TabIndex = 9;
            this.btnSubmitAttendance.Text = "SUBMIT";
            this.btnSubmitAttendance.UseVisualStyleBackColor = true;
            this.btnSubmitAttendance.Click += new System.EventHandler(this.btnSubmitAttendance_Click);
            // 
            // itxt_Notes
            // 
            this.itxt_Notes.IsBrowseMode = false;
            this.itxt_Notes.LabelText = "Notes";
            this.itxt_Notes.Location = new System.Drawing.Point(197, 9);
            this.itxt_Notes.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Notes.MaxLength = 32767;
            this.itxt_Notes.MultiLine = true;
            this.itxt_Notes.Name = "itxt_Notes";
            this.itxt_Notes.PasswordChar = '\0';
            this.itxt_Notes.RowCount = 6;
            this.itxt_Notes.ShowDeleteButton = false;
            this.itxt_Notes.ShowTextboxOnly = false;
            this.itxt_Notes.Size = new System.Drawing.Size(259, 135);
            this.itxt_Notes.TabIndex = 8;
            this.itxt_Notes.TabStop = false;
            this.itxt_Notes.ValueText = "";
            // 
            // idtp_TimestampIn
            // 
            this.idtp_TimestampIn.CustomFormat = "dd/MM/yyyy HH:mm";
            this.idtp_TimestampIn.DefaultCheckedValue = false;
            this.idtp_TimestampIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_TimestampIn.LabelText = "IN";
            this.idtp_TimestampIn.Location = new System.Drawing.Point(9, 14);
            this.idtp_TimestampIn.Margin = new System.Windows.Forms.Padding(5);
            this.idtp_TimestampIn.Name = "idtp_TimestampIn";
            this.idtp_TimestampIn.ShowCheckBox = false;
            this.idtp_TimestampIn.ShowUpAndDown = false;
            this.idtp_TimestampIn.Size = new System.Drawing.Size(177, 50);
            this.idtp_TimestampIn.TabIndex = 6;
            this.idtp_TimestampIn.Value = null;
            this.idtp_TimestampIn.ValueTimeSpan = null;
            // 
            // idtp_TimestampOut
            // 
            this.idtp_TimestampOut.CustomFormat = "dd/MM/yyyy HH:mm";
            this.idtp_TimestampOut.DefaultCheckedValue = false;
            this.idtp_TimestampOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_TimestampOut.LabelText = "OUT";
            this.idtp_TimestampOut.Location = new System.Drawing.Point(9, 60);
            this.idtp_TimestampOut.Margin = new System.Windows.Forms.Padding(5);
            this.idtp_TimestampOut.Name = "idtp_TimestampOut";
            this.idtp_TimestampOut.ShowCheckBox = false;
            this.idtp_TimestampOut.ShowUpAndDown = false;
            this.idtp_TimestampOut.Size = new System.Drawing.Size(177, 50);
            this.idtp_TimestampOut.TabIndex = 7;
            this.idtp_TimestampOut.Value = null;
            this.idtp_TimestampOut.ValueTimeSpan = null;
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AllowUserToResizeRows = false;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgvAttendance_Id,
            this.col_dgvAttendance_In,
            this.col_dgvAttendance_Out,
            this.col_dgvAttendance_Flag1,
            this.col_dgvAttendance_Flag2,
            this.col_dgvAttendance_Approved,
            this.col_dgvAttendance_Notes});
            this.dgvAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttendance.Location = new System.Drawing.Point(431, 171);
            this.dgvAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAttendance.MultiSelect = false;
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(753, 441);
            this.dgvAttendance.TabIndex = 4;
            this.dgvAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_CellContentClick);
            // 
            // col_dgvAttendance_Id
            // 
            this.col_dgvAttendance_Id.HeaderText = "Id";
            this.col_dgvAttendance_Id.Name = "col_dgvAttendance_Id";
            this.col_dgvAttendance_Id.Visible = false;
            // 
            // col_dgvAttendance_In
            // 
            this.col_dgvAttendance_In.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy HH:mm";
            this.col_dgvAttendance_In.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_dgvAttendance_In.HeaderText = "In";
            this.col_dgvAttendance_In.MinimumWidth = 30;
            this.col_dgvAttendance_In.Name = "col_dgvAttendance_In";
            this.col_dgvAttendance_In.Width = 30;
            // 
            // col_dgvAttendance_Out
            // 
            this.col_dgvAttendance_Out.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "dd/MM/yyyy HH:mm";
            this.col_dgvAttendance_Out.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_dgvAttendance_Out.HeaderText = "Out";
            this.col_dgvAttendance_Out.MinimumWidth = 35;
            this.col_dgvAttendance_Out.Name = "col_dgvAttendance_Out";
            this.col_dgvAttendance_Out.Width = 35;
            // 
            // col_dgvAttendance_Flag1
            // 
            this.col_dgvAttendance_Flag1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendance_Flag1.HeaderText = "Flag 1";
            this.col_dgvAttendance_Flag1.MinimumWidth = 60;
            this.col_dgvAttendance_Flag1.Name = "col_dgvAttendance_Flag1";
            this.col_dgvAttendance_Flag1.Width = 60;
            // 
            // col_dgvAttendance_Flag2
            // 
            this.col_dgvAttendance_Flag2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendance_Flag2.HeaderText = "Flag 2";
            this.col_dgvAttendance_Flag2.MinimumWidth = 60;
            this.col_dgvAttendance_Flag2.Name = "col_dgvAttendance_Flag2";
            this.col_dgvAttendance_Flag2.Width = 60;
            // 
            // col_dgvAttendance_Approved
            // 
            this.col_dgvAttendance_Approved.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendance_Approved.HeaderText = "Approved";
            this.col_dgvAttendance_Approved.MinimumWidth = 70;
            this.col_dgvAttendance_Approved.Name = "col_dgvAttendance_Approved";
            this.col_dgvAttendance_Approved.Width = 70;
            // 
            // col_dgvAttendance_Notes
            // 
            this.col_dgvAttendance_Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_dgvAttendance_Notes.HeaderText = "Notes";
            this.col_dgvAttendance_Notes.MinimumWidth = 40;
            this.col_dgvAttendance_Notes.Name = "col_dgvAttendance_Notes";
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.Controls.Add(this.ptFilterEmployee);
            this.pnlEmployees.Controls.Add(this.dgvEmployees);
            this.pnlEmployees.Controls.Add(this.panel4);
            this.pnlEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEmployees.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(431, 612);
            this.pnlEmployees.TabIndex = 5;
            // 
            // ptFilterEmployee
            // 
            this.ptFilterEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptFilterEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.ptFilterEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptFilterEmployee.InitialArrowDirection = System.Windows.Forms.ArrowDirection.Up;
            this.ptFilterEmployee.Location = new System.Drawing.Point(404, 197);
            this.ptFilterEmployee.Margin = new System.Windows.Forms.Padding(5);
            this.ptFilterEmployee.Name = "ptFilterEmployee";
            this.ptFilterEmployee.Size = new System.Drawing.Size(26, 24);
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
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.col_dgvEmployees_UserAccounts_Id,
            this.col_dgvEmployees_Clients_Id,
            this.col_dgvEmployees_UserAccounts_Fullname,
            this.col_dgvEmployees_Clients_CompanyName});
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 197);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(431, 415);
            this.dgvEmployees.TabIndex = 5;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // col_dgvEmployees_UserAccounts_Id
            // 
            this.col_dgvEmployees_UserAccounts_Id.HeaderText = "UserAccounts_Id";
            this.col_dgvEmployees_UserAccounts_Id.Name = "col_dgvEmployees_UserAccounts_Id";
            this.col_dgvEmployees_UserAccounts_Id.Visible = false;
            this.col_dgvEmployees_UserAccounts_Id.Width = 5;
            // 
            // col_dgvEmployees_Clients_Id
            // 
            this.col_dgvEmployees_Clients_Id.HeaderText = "Clients_Id";
            this.col_dgvEmployees_Clients_Id.Name = "col_dgvEmployees_Clients_Id";
            this.col_dgvEmployees_Clients_Id.Visible = false;
            this.col_dgvEmployees_Clients_Id.Width = 5;
            // 
            // col_dgvEmployees_UserAccounts_Fullname
            // 
            this.col_dgvEmployees_UserAccounts_Fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_dgvEmployees_UserAccounts_Fullname.HeaderText = "Employee";
            this.col_dgvEmployees_UserAccounts_Fullname.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.col_dgvEmployees_UserAccounts_Fullname.MinimumWidth = 60;
            this.col_dgvEmployees_UserAccounts_Fullname.Name = "col_dgvEmployees_UserAccounts_Fullname";
            // 
            // col_dgvEmployees_Clients_CompanyName
            // 
            this.col_dgvEmployees_Clients_CompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvEmployees_Clients_CompanyName.HeaderText = "Company";
            this.col_dgvEmployees_Clients_CompanyName.MinimumWidth = 80;
            this.col_dgvEmployees_Clients_CompanyName.Name = "col_dgvEmployees_Clients_CompanyName";
            this.col_dgvEmployees_Clients_CompanyName.Width = 80;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox4);
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Controls.Add(this.btnFilterEmployees);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(431, 197);
            this.panel4.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkFilterEmployeeByName);
            this.groupBox4.Controls.Add(this.itxt_FilterEmployee_UserAccounts_Name);
            this.groupBox4.Location = new System.Drawing.Point(220, 5);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(207, 103);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // chkFilterEmployeeByName
            // 
            this.chkFilterEmployeeByName.AutoSize = true;
            this.chkFilterEmployeeByName.Location = new System.Drawing.Point(3, 10);
            this.chkFilterEmployeeByName.Margin = new System.Windows.Forms.Padding(4);
            this.chkFilterEmployeeByName.Name = "chkFilterEmployeeByName";
            this.chkFilterEmployeeByName.Size = new System.Drawing.Size(18, 17);
            this.chkFilterEmployeeByName.TabIndex = 7;
            this.chkFilterEmployeeByName.UseVisualStyleBackColor = true;
            this.chkFilterEmployeeByName.CheckedChanged += new System.EventHandler(this.chkFilterEmployees_CheckedChanged);
            // 
            // itxt_FilterEmployee_UserAccounts_Name
            // 
            this.itxt_FilterEmployee_UserAccounts_Name.IsBrowseMode = false;
            this.itxt_FilterEmployee_UserAccounts_Name.LabelText = "Employee";
            this.itxt_FilterEmployee_UserAccounts_Name.Location = new System.Drawing.Point(5, 25);
            this.itxt_FilterEmployee_UserAccounts_Name.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_FilterEmployee_UserAccounts_Name.MaxLength = 32767;
            this.itxt_FilterEmployee_UserAccounts_Name.MultiLine = false;
            this.itxt_FilterEmployee_UserAccounts_Name.Name = "itxt_FilterEmployee_UserAccounts_Name";
            this.itxt_FilterEmployee_UserAccounts_Name.PasswordChar = '\0';
            this.itxt_FilterEmployee_UserAccounts_Name.RowCount = 1;
            this.itxt_FilterEmployee_UserAccounts_Name.ShowDeleteButton = false;
            this.itxt_FilterEmployee_UserAccounts_Name.ShowTextboxOnly = false;
            this.itxt_FilterEmployee_UserAccounts_Name.Size = new System.Drawing.Size(195, 50);
            this.itxt_FilterEmployee_UserAccounts_Name.TabIndex = 10;
            this.itxt_FilterEmployee_UserAccounts_Name.ValueText = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkFilterEmployeesByClient);
            this.groupBox3.Controls.Add(this.itxt_FilterEmployee_Client);
            this.groupBox3.Controls.Add(this.idtp_FilterEmployee_StartDate);
            this.groupBox3.Controls.Add(this.idtp_FilterEmployee_EndDate);
            this.groupBox3.Location = new System.Drawing.Point(4, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(212, 187);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // chkFilterEmployeesByClient
            // 
            this.chkFilterEmployeesByClient.AutoSize = true;
            this.chkFilterEmployeesByClient.Location = new System.Drawing.Point(3, 10);
            this.chkFilterEmployeesByClient.Margin = new System.Windows.Forms.Padding(4);
            this.chkFilterEmployeesByClient.Name = "chkFilterEmployeesByClient";
            this.chkFilterEmployeesByClient.Size = new System.Drawing.Size(18, 17);
            this.chkFilterEmployeesByClient.TabIndex = 7;
            this.chkFilterEmployeesByClient.UseVisualStyleBackColor = true;
            this.chkFilterEmployeesByClient.CheckedChanged += new System.EventHandler(this.chkFilterEmployees_CheckedChanged);
            // 
            // itxt_FilterEmployee_Client
            // 
            this.itxt_FilterEmployee_Client.IsBrowseMode = true;
            this.itxt_FilterEmployee_Client.LabelText = "*Client";
            this.itxt_FilterEmployee_Client.Location = new System.Drawing.Point(9, 25);
            this.itxt_FilterEmployee_Client.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_FilterEmployee_Client.MaxLength = 32767;
            this.itxt_FilterEmployee_Client.MultiLine = false;
            this.itxt_FilterEmployee_Client.Name = "itxt_FilterEmployee_Client";
            this.itxt_FilterEmployee_Client.PasswordChar = '\0';
            this.itxt_FilterEmployee_Client.RowCount = 1;
            this.itxt_FilterEmployee_Client.ShowDeleteButton = true;
            this.itxt_FilterEmployee_Client.ShowTextboxOnly = false;
            this.itxt_FilterEmployee_Client.Size = new System.Drawing.Size(195, 50);
            this.itxt_FilterEmployee_Client.TabIndex = 9;
            this.itxt_FilterEmployee_Client.ValueText = "";
            this.itxt_FilterEmployee_Client.isBrowseMode_Clicked += new System.EventHandler(this.itxt_FilterEmployee_Client_isBrowseMode_Clicked);
            // 
            // idtp_FilterEmployee_StartDate
            // 
            this.idtp_FilterEmployee_StartDate.CustomFormat = "dd/MM/yyyy";
            this.idtp_FilterEmployee_StartDate.DefaultCheckedValue = false;
            this.idtp_FilterEmployee_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_FilterEmployee_StartDate.LabelText = "Start";
            this.idtp_FilterEmployee_StartDate.Location = new System.Drawing.Point(9, 74);
            this.idtp_FilterEmployee_StartDate.Margin = new System.Windows.Forms.Padding(5);
            this.idtp_FilterEmployee_StartDate.Name = "idtp_FilterEmployee_StartDate";
            this.idtp_FilterEmployee_StartDate.ShowCheckBox = false;
            this.idtp_FilterEmployee_StartDate.ShowUpAndDown = false;
            this.idtp_FilterEmployee_StartDate.Size = new System.Drawing.Size(195, 50);
            this.idtp_FilterEmployee_StartDate.TabIndex = 12;
            this.idtp_FilterEmployee_StartDate.Value = null;
            this.idtp_FilterEmployee_StartDate.ValueTimeSpan = null;
            // 
            // idtp_FilterEmployee_EndDate
            // 
            this.idtp_FilterEmployee_EndDate.CustomFormat = "dd/MM/yyyy";
            this.idtp_FilterEmployee_EndDate.DefaultCheckedValue = false;
            this.idtp_FilterEmployee_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_FilterEmployee_EndDate.LabelText = "End";
            this.idtp_FilterEmployee_EndDate.Location = new System.Drawing.Point(9, 123);
            this.idtp_FilterEmployee_EndDate.Margin = new System.Windows.Forms.Padding(5);
            this.idtp_FilterEmployee_EndDate.Name = "idtp_FilterEmployee_EndDate";
            this.idtp_FilterEmployee_EndDate.ShowCheckBox = false;
            this.idtp_FilterEmployee_EndDate.ShowUpAndDown = false;
            this.idtp_FilterEmployee_EndDate.Size = new System.Drawing.Size(195, 50);
            this.idtp_FilterEmployee_EndDate.TabIndex = 13;
            this.idtp_FilterEmployee_EndDate.Value = null;
            this.idtp_FilterEmployee_EndDate.ValueTimeSpan = null;
            // 
            // btnFilterEmployees
            // 
            this.btnFilterEmployees.Location = new System.Drawing.Point(281, 134);
            this.btnFilterEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterEmployees.Name = "btnFilterEmployees";
            this.btnFilterEmployees.Size = new System.Drawing.Size(100, 28);
            this.btnFilterEmployees.TabIndex = 11;
            this.btnFilterEmployees.Text = "FILTER";
            this.btnFilterEmployees.UseVisualStyleBackColor = true;
            this.btnFilterEmployees.Click += new System.EventHandler(this.btnFilterEmployees_Click);
            // 
            // Timesheets_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 612);
            this.Controls.Add(this.pnlFilterEmployees);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Timesheets_Form";
            this.Text = "TIMESHEET";
            this.Load += new System.EventHandler(this.Form_Load);
            this.pnlFilterEmployees.ResumeLayout(false);
            this.pnlFilterAttendance.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.pnlEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilterEmployees;
        protected System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Panel pnlFilterAttendance;
        private System.Windows.Forms.Panel pnlEmployees;
        protected System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Panel panel4;
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
        private LIBUtil.Desktop.UserControls.InputControl_Dropdownlist iddl_DayOfWeek;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvEmployees_UserAccounts_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvEmployees_Clients_Id;
        private System.Windows.Forms.DataGridViewLinkColumn col_dgvEmployees_UserAccounts_Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvEmployees_Clients_CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendance_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendance_In;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendance_Out;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_dgvAttendance_Flag1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_dgvAttendance_Flag2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_dgvAttendance_Approved;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendance_Notes;
    }
}