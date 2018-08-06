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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFilterAttendance = new System.Windows.Forms.Panel();
            this.idtp_FilterAttendance_Out = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.idtp_FilterAttendance_StartDate = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.idtp_FilterAttendance_EndDate = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.btnFilterAttendance = new System.Windows.Forms.Button();
            this.iddl_DayOfWeek = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
            this.idtp_FilterAttendance_In = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.iddl_AttendanceStatuses = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.col_dgvAttendance_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendance_PayrollItems_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.itxt_FilterEmployee_Client = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.btnAddAttendance = new System.Windows.Forms.Button();
            this.itxt_UserAccount = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.pnlFilterAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilterAttendance
            // 
            this.pnlFilterAttendance.Controls.Add(this.idtp_FilterAttendance_Out);
            this.pnlFilterAttendance.Controls.Add(this.itxt_UserAccount);
            this.pnlFilterAttendance.Controls.Add(this.idtp_FilterAttendance_StartDate);
            this.pnlFilterAttendance.Controls.Add(this.btnAddAttendance);
            this.pnlFilterAttendance.Controls.Add(this.idtp_FilterAttendance_EndDate);
            this.pnlFilterAttendance.Controls.Add(this.itxt_FilterEmployee_Client);
            this.pnlFilterAttendance.Controls.Add(this.iddl_DayOfWeek);
            this.pnlFilterAttendance.Controls.Add(this.iddl_AttendanceStatuses);
            this.pnlFilterAttendance.Controls.Add(this.btnFilterAttendance);
            this.pnlFilterAttendance.Controls.Add(this.idtp_FilterAttendance_In);
            this.pnlFilterAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterAttendance.Location = new System.Drawing.Point(0, 0);
            this.pnlFilterAttendance.Name = "pnlFilterAttendance";
            this.pnlFilterAttendance.Size = new System.Drawing.Size(1028, 139);
            this.pnlFilterAttendance.TabIndex = 1;
            // 
            // idtp_FilterAttendance_Out
            // 
            this.idtp_FilterAttendance_Out.Checked = false;
            this.idtp_FilterAttendance_Out.CustomFormat = "HH:mm";
            this.idtp_FilterAttendance_Out.DefaultCheckedValue = false;
            this.idtp_FilterAttendance_Out.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_FilterAttendance_Out.LabelText = "OUT";
            this.idtp_FilterAttendance_Out.Location = new System.Drawing.Point(265, 45);
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
            // idtp_FilterAttendance_StartDate
            // 
            this.idtp_FilterAttendance_StartDate.Checked = false;
            this.idtp_FilterAttendance_StartDate.CustomFormat = "dd/MM/yyyy";
            this.idtp_FilterAttendance_StartDate.DefaultCheckedValue = false;
            this.idtp_FilterAttendance_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_FilterAttendance_StartDate.LabelText = "Start";
            this.idtp_FilterAttendance_StartDate.Location = new System.Drawing.Point(158, 4);
            this.idtp_FilterAttendance_StartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.idtp_FilterAttendance_EndDate.Location = new System.Drawing.Point(158, 45);
            this.idtp_FilterAttendance_EndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnFilterAttendance.Location = new System.Drawing.Point(156, 108);
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
            this.iddl_DayOfWeek.Location = new System.Drawing.Point(346, 4);
            this.iddl_DayOfWeek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iddl_DayOfWeek.Name = "iddl_DayOfWeek";
            this.iddl_DayOfWeek.SelectedItem = null;
            this.iddl_DayOfWeek.SelectedValue = null;
            this.iddl_DayOfWeek.ShowDropdownlistOnly = false;
            this.iddl_DayOfWeek.Size = new System.Drawing.Size(111, 41);
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
            this.idtp_FilterAttendance_In.Location = new System.Drawing.Point(265, 4);
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
            // iddl_AttendanceStatuses
            // 
            this.iddl_AttendanceStatuses.DisableTextInput = false;
            this.iddl_AttendanceStatuses.HideFilter = true;
            this.iddl_AttendanceStatuses.HideUpdateLink = true;
            this.iddl_AttendanceStatuses.LabelText = "Status";
            this.iddl_AttendanceStatuses.Location = new System.Drawing.Point(346, 45);
            this.iddl_AttendanceStatuses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iddl_AttendanceStatuses.Name = "iddl_AttendanceStatuses";
            this.iddl_AttendanceStatuses.SelectedItem = null;
            this.iddl_AttendanceStatuses.SelectedValue = null;
            this.iddl_AttendanceStatuses.ShowDropdownlistOnly = false;
            this.iddl_AttendanceStatuses.Size = new System.Drawing.Size(111, 41);
            this.iddl_AttendanceStatuses.TabIndex = 2;
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AllowUserToResizeRows = false;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgvAttendance_Id,
            this.col_dgvAttendance_PayrollItems_Id,
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
            this.dgvAttendance.Location = new System.Drawing.Point(0, 139);
            this.dgvAttendance.MultiSelect = false;
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(1028, 372);
            this.dgvAttendance.TabIndex = 4;
            this.dgvAttendance.TabStop = false;
            this.dgvAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_CellContentClick);
            // 
            // col_dgvAttendance_Id
            // 
            this.col_dgvAttendance_Id.HeaderText = "Id";
            this.col_dgvAttendance_Id.Name = "col_dgvAttendance_Id";
            this.col_dgvAttendance_Id.ReadOnly = true;
            this.col_dgvAttendance_Id.Visible = false;
            // 
            // col_dgvAttendance_PayrollItems_Id
            // 
            this.col_dgvAttendance_PayrollItems_Id.HeaderText = "PayrollItems_Id";
            this.col_dgvAttendance_PayrollItems_Id.Name = "col_dgvAttendance_PayrollItems_Id";
            this.col_dgvAttendance_PayrollItems_Id.Visible = false;
            // 
            // col_dgvAttendance_In
            // 
            this.col_dgvAttendance_In.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Format = "MM/dd/yy HH:mm";
            this.col_dgvAttendance_In.DefaultCellStyle = dataGridViewCellStyle16;
            this.col_dgvAttendance_In.HeaderText = "IN";
            this.col_dgvAttendance_In.MinimumWidth = 30;
            this.col_dgvAttendance_In.Name = "col_dgvAttendance_In";
            this.col_dgvAttendance_In.ReadOnly = true;
            this.col_dgvAttendance_In.Width = 30;
            // 
            // col_dgvAttendance_Out
            // 
            this.col_dgvAttendance_Out.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Format = "MM/dd/yy HH:mm";
            this.col_dgvAttendance_Out.DefaultCellStyle = dataGridViewCellStyle17;
            this.col_dgvAttendance_Out.HeaderText = "OUT";
            this.col_dgvAttendance_Out.MinimumWidth = 35;
            this.col_dgvAttendance_Out.Name = "col_dgvAttendance_Out";
            this.col_dgvAttendance_Out.ReadOnly = true;
            this.col_dgvAttendance_Out.Width = 35;
            // 
            // col_dgvAttendance_EffectiveIn
            // 
            this.col_dgvAttendance_EffectiveIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Format = "MM/dd/yy HH:mm";
            this.col_dgvAttendance_EffectiveIn.DefaultCellStyle = dataGridViewCellStyle18;
            this.col_dgvAttendance_EffectiveIn.HeaderText = "Effective IN";
            this.col_dgvAttendance_EffectiveIn.MinimumWidth = 100;
            this.col_dgvAttendance_EffectiveIn.Name = "col_dgvAttendance_EffectiveIn";
            this.col_dgvAttendance_EffectiveIn.ReadOnly = true;
            // 
            // col_dgvAttendance_EffectiveOut
            // 
            this.col_dgvAttendance_EffectiveOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Format = "MM/dd/yy HH:mm";
            this.col_dgvAttendance_EffectiveOut.DefaultCellStyle = dataGridViewCellStyle19;
            this.col_dgvAttendance_EffectiveOut.HeaderText = "Effective OUT";
            this.col_dgvAttendance_EffectiveOut.MinimumWidth = 100;
            this.col_dgvAttendance_EffectiveOut.Name = "col_dgvAttendance_EffectiveOut";
            this.col_dgvAttendance_EffectiveOut.ReadOnly = true;
            // 
            // col_dgvAttendances_EffectiveWorkHours
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N2";
            this.col_dgvAttendances_EffectiveWorkHours.DefaultCellStyle = dataGridViewCellStyle20;
            this.col_dgvAttendances_EffectiveWorkHours.HeaderText = "Hours";
            this.col_dgvAttendances_EffectiveWorkHours.Name = "col_dgvAttendances_EffectiveWorkHours";
            this.col_dgvAttendances_EffectiveWorkHours.ReadOnly = true;
            // 
            // col_dgvAttendances_PayableAmount
            // 
            this.col_dgvAttendances_PayableAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "N2";
            this.col_dgvAttendances_PayableAmount.DefaultCellStyle = dataGridViewCellStyle21;
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
            // itxt_FilterEmployee_Client
            // 
            this.itxt_FilterEmployee_Client.IsBrowseMode = true;
            this.itxt_FilterEmployee_Client.LabelText = "Client";
            this.itxt_FilterEmployee_Client.Location = new System.Drawing.Point(4, 45);
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
            this.itxt_FilterEmployee_Client.isBrowseMode_Clicked += new System.EventHandler(this.itxt_Client_isBrowseMode_Clicked);
            // 
            // btnAddAttendance
            // 
            this.btnAddAttendance.Location = new System.Drawing.Point(4, 108);
            this.btnAddAttendance.Name = "btnAddAttendance";
            this.btnAddAttendance.Size = new System.Drawing.Size(146, 23);
            this.btnAddAttendance.TabIndex = 9;
            this.btnAddAttendance.Text = "ADD ATTENDANCE";
            this.btnAddAttendance.UseVisualStyleBackColor = true;
            this.btnAddAttendance.Click += new System.EventHandler(this.btnAddAttendance_Click);
            // 
            // itxt_UserAccount
            // 
            this.itxt_UserAccount.IsBrowseMode = true;
            this.itxt_UserAccount.LabelText = "Employee";
            this.itxt_UserAccount.Location = new System.Drawing.Point(4, 4);
            this.itxt_UserAccount.Margin = new System.Windows.Forms.Padding(4);
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
            // Timesheets_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 511);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.pnlFilterAttendance);
            this.Name = "Timesheets_Form";
            this.Text = "TIMESHEET";
            this.Load += new System.EventHandler(this.Form_Load);
            this.pnlFilterAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Panel pnlFilterAttendance;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_FilterEmployee_Client;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_FilterAttendance_In;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_FilterAttendance_Out;
        private LIBUtil.Desktop.UserControls.InputControl_Numeric in_DurationMinutes;
        private System.Windows.Forms.Button btnFilterAttendance;
        private LIBUtil.Desktop.UserControls.InputControl_Dropdownlist iddl_AttendanceStatuses;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_FilterAttendance_StartDate;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_FilterAttendance_EndDate;
        private LIBUtil.Desktop.UserControls.InputControl_Dropdownlist iddl_DayOfWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendance_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendance_PayrollItems_Id;
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
        private System.Windows.Forms.Button btnAddAttendance;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_UserAccount;
    }
}