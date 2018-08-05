namespace HR_Desktop.Payroll
{
    partial class Payments_Main_Form
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
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.iddl_Target_BankAccounts = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
            this.iddl_Source_BankAccounts = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
            this.btnFilter = new System.Windows.Forms.Button();
            this.idtp_EndDate = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.idtp_StartDate = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.itxt_Payrolls = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Employee_UserAccount = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.dgvPaymentItems = new System.Windows.Forms.DataGridView();
            this.col_dgvPaymentItems_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPaymentItems_Payrolls_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPaymentItems_Employee_UserAccounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPaymentItems_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPaymentItems_Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.col_dgvPayments_Approved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_dgvPayments_Rejected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_dgvPayments_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPayments_No = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_dgvPayments_Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPayments_Source_BankAccounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPayments_Target_BankAccounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPayments_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPayments_ConfirmationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPayments_Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Margin = new System.Windows.Forms.Padding(4);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.iddl_Target_BankAccounts);
            this.scMain.Panel1.Controls.Add(this.iddl_Source_BankAccounts);
            this.scMain.Panel1.Controls.Add(this.btnFilter);
            this.scMain.Panel1.Controls.Add(this.idtp_EndDate);
            this.scMain.Panel1.Controls.Add(this.idtp_StartDate);
            this.scMain.Panel1.Controls.Add(this.pbRefresh);
            this.scMain.Panel1.Controls.Add(this.btnLog);
            this.scMain.Panel1.Controls.Add(this.itxt_Payrolls);
            this.scMain.Panel1.Controls.Add(this.itxt_Employee_UserAccount);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.dgvPaymentItems);
            this.scMain.Panel2.Controls.Add(this.dgvPayments);
            this.scMain.Size = new System.Drawing.Size(794, 444);
            this.scMain.SplitterDistance = 189;
            this.scMain.SplitterWidth = 5;
            this.scMain.TabIndex = 0;
            // 
            // iddl_Target_BankAccounts
            // 
            this.iddl_Target_BankAccounts.DisableTextInput = false;
            this.iddl_Target_BankAccounts.HideFilter = true;
            this.iddl_Target_BankAccounts.HideUpdateLink = true;
            this.iddl_Target_BankAccounts.LabelText = "Target Account";
            this.iddl_Target_BankAccounts.Location = new System.Drawing.Point(4, 93);
            this.iddl_Target_BankAccounts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iddl_Target_BankAccounts.Name = "iddl_Target_BankAccounts";
            this.iddl_Target_BankAccounts.SelectedItem = null;
            this.iddl_Target_BankAccounts.SelectedValue = null;
            this.iddl_Target_BankAccounts.ShowDropdownlistOnly = false;
            this.iddl_Target_BankAccounts.Size = new System.Drawing.Size(240, 48);
            this.iddl_Target_BankAccounts.TabIndex = 21;
            // 
            // iddl_Source_BankAccounts
            // 
            this.iddl_Source_BankAccounts.DisableTextInput = false;
            this.iddl_Source_BankAccounts.HideFilter = true;
            this.iddl_Source_BankAccounts.HideUpdateLink = true;
            this.iddl_Source_BankAccounts.LabelText = "Source Account";
            this.iddl_Source_BankAccounts.Location = new System.Drawing.Point(5, 40);
            this.iddl_Source_BankAccounts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iddl_Source_BankAccounts.Name = "iddl_Source_BankAccounts";
            this.iddl_Source_BankAccounts.SelectedItem = null;
            this.iddl_Source_BankAccounts.SelectedValue = null;
            this.iddl_Source_BankAccounts.ShowDropdownlistOnly = false;
            this.iddl_Source_BankAccounts.Size = new System.Drawing.Size(240, 48);
            this.iddl_Source_BankAccounts.TabIndex = 20;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(83, 316);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(79, 28);
            this.btnFilter.TabIndex = 19;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // idtp_EndDate
            // 
            this.idtp_EndDate.Checked = false;
            this.idtp_EndDate.CustomFormat = "dd/MM/yy";
            this.idtp_EndDate.DefaultCheckedValue = false;
            this.idtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_EndDate.LabelText = "End";
            this.idtp_EndDate.Location = new System.Drawing.Point(129, 246);
            this.idtp_EndDate.Margin = new System.Windows.Forms.Padding(5);
            this.idtp_EndDate.Name = "idtp_EndDate";
            this.idtp_EndDate.ShowCheckBox = true;
            this.idtp_EndDate.ShowUpAndDown = false;
            this.idtp_EndDate.Size = new System.Drawing.Size(116, 50);
            this.idtp_EndDate.TabIndex = 18;
            this.idtp_EndDate.Value = null;
            this.idtp_EndDate.ValueTimeSpan = null;
            this.idtp_EndDate.ValueChanged += new System.EventHandler(this.idtp_Date_ValueChanged);
            // 
            // idtp_StartDate
            // 
            this.idtp_StartDate.Checked = true;
            this.idtp_StartDate.CustomFormat = "dd/MM/yy";
            this.idtp_StartDate.DefaultCheckedValue = false;
            this.idtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_StartDate.LabelText = "Start";
            this.idtp_StartDate.Location = new System.Drawing.Point(5, 246);
            this.idtp_StartDate.Margin = new System.Windows.Forms.Padding(5);
            this.idtp_StartDate.Name = "idtp_StartDate";
            this.idtp_StartDate.ShowCheckBox = true;
            this.idtp_StartDate.ShowUpAndDown = false;
            this.idtp_StartDate.Size = new System.Drawing.Size(116, 50);
            this.idtp_StartDate.TabIndex = 18;
            this.idtp_StartDate.Value = new System.DateTime(1753, 1, 1, 14, 52, 33, 253);
            this.idtp_StartDate.ValueTimeSpan = System.TimeSpan.Parse("14:52:33.2530000");
            this.idtp_StartDate.ValueChanged += new System.EventHandler(this.idtp_Date_ValueChanged);
            // 
            // pbRefresh
            // 
            this.pbRefresh.BackColor = System.Drawing.Color.Transparent;
            this.pbRefresh.BackgroundImage = global::HR_Desktop.Properties.Resources.refresh;
            this.pbRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRefresh.Location = new System.Drawing.Point(189, 4);
            this.pbRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(33, 28);
            this.pbRefresh.TabIndex = 9;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(4, 4);
            this.btnLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(100, 28);
            this.btnLog.TabIndex = 9;
            this.btnLog.Text = "LOG";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // itxt_Payrolls
            // 
            this.itxt_Payrolls.IsBrowseMode = true;
            this.itxt_Payrolls.LabelText = "Payroll";
            this.itxt_Payrolls.Location = new System.Drawing.Point(5, 196);
            this.itxt_Payrolls.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Payrolls.MaxLength = 32767;
            this.itxt_Payrolls.MultiLine = false;
            this.itxt_Payrolls.Name = "itxt_Payrolls";
            this.itxt_Payrolls.PasswordChar = '\0';
            this.itxt_Payrolls.RowCount = 1;
            this.itxt_Payrolls.ShowDeleteButton = true;
            this.itxt_Payrolls.ShowTextboxOnly = false;
            this.itxt_Payrolls.Size = new System.Drawing.Size(240, 50);
            this.itxt_Payrolls.TabIndex = 10;
            this.itxt_Payrolls.ValueText = "";
            this.itxt_Payrolls.isBrowseMode_Clicked += new System.EventHandler(this.itxt_Payrolls_isBrowseMode_Clicked);
            // 
            // itxt_Employee_UserAccount
            // 
            this.itxt_Employee_UserAccount.IsBrowseMode = true;
            this.itxt_Employee_UserAccount.LabelText = "Employee";
            this.itxt_Employee_UserAccount.Location = new System.Drawing.Point(5, 145);
            this.itxt_Employee_UserAccount.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Employee_UserAccount.MaxLength = 32767;
            this.itxt_Employee_UserAccount.MultiLine = false;
            this.itxt_Employee_UserAccount.Name = "itxt_Employee_UserAccount";
            this.itxt_Employee_UserAccount.PasswordChar = '\0';
            this.itxt_Employee_UserAccount.RowCount = 1;
            this.itxt_Employee_UserAccount.ShowDeleteButton = true;
            this.itxt_Employee_UserAccount.ShowTextboxOnly = false;
            this.itxt_Employee_UserAccount.Size = new System.Drawing.Size(240, 50);
            this.itxt_Employee_UserAccount.TabIndex = 9;
            this.itxt_Employee_UserAccount.ValueText = "";
            this.itxt_Employee_UserAccount.isBrowseMode_Clicked += new System.EventHandler(this.itxt_UserAccounts_isBrowseMode_Clicked);
            // 
            // dgvPaymentItems
            // 
            this.dgvPaymentItems.AllowUserToAddRows = false;
            this.dgvPaymentItems.AllowUserToDeleteRows = false;
            this.dgvPaymentItems.AllowUserToResizeRows = false;
            this.dgvPaymentItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPaymentItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvPaymentItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaymentItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgvPaymentItems_Id,
            this.col_dgvPaymentItems_Payrolls_No,
            this.col_dgvPaymentItems_Employee_UserAccounts,
            this.col_dgvPaymentItems_Amount,
            this.col_dgvPaymentItems_Notes});
            this.dgvPaymentItems.Location = new System.Drawing.Point(0, 221);
            this.dgvPaymentItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPaymentItems.MultiSelect = false;
            this.dgvPaymentItems.Name = "dgvPaymentItems";
            this.dgvPaymentItems.RowHeadersVisible = false;
            this.dgvPaymentItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentItems.Size = new System.Drawing.Size(599, 223);
            this.dgvPaymentItems.TabIndex = 9;
            // 
            // col_dgvPaymentItems_Id
            // 
            this.col_dgvPaymentItems_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvPaymentItems_Id.HeaderText = "Id";
            this.col_dgvPaymentItems_Id.Name = "col_dgvPaymentItems_Id";
            this.col_dgvPaymentItems_Id.ReadOnly = true;
            this.col_dgvPaymentItems_Id.Visible = false;
            // 
            // col_dgvPaymentItems_Payrolls_No
            // 
            this.col_dgvPaymentItems_Payrolls_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvPaymentItems_Payrolls_No.HeaderText = "Payroll";
            this.col_dgvPaymentItems_Payrolls_No.MinimumWidth = 50;
            this.col_dgvPaymentItems_Payrolls_No.Name = "col_dgvPaymentItems_Payrolls_No";
            this.col_dgvPaymentItems_Payrolls_No.Width = 50;
            // 
            // col_dgvPaymentItems_Employee_UserAccounts
            // 
            this.col_dgvPaymentItems_Employee_UserAccounts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvPaymentItems_Employee_UserAccounts.HeaderText = "Employee";
            this.col_dgvPaymentItems_Employee_UserAccounts.MinimumWidth = 60;
            this.col_dgvPaymentItems_Employee_UserAccounts.Name = "col_dgvPaymentItems_Employee_UserAccounts";
            this.col_dgvPaymentItems_Employee_UserAccounts.Width = 60;
            // 
            // col_dgvPaymentItems_Amount
            // 
            this.col_dgvPaymentItems_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.col_dgvPaymentItems_Amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_dgvPaymentItems_Amount.HeaderText = "Amount";
            this.col_dgvPaymentItems_Amount.MinimumWidth = 50;
            this.col_dgvPaymentItems_Amount.Name = "col_dgvPaymentItems_Amount";
            this.col_dgvPaymentItems_Amount.ReadOnly = true;
            this.col_dgvPaymentItems_Amount.Width = 50;
            // 
            // col_dgvPaymentItems_Notes
            // 
            this.col_dgvPaymentItems_Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_dgvPaymentItems_Notes.HeaderText = "Notes";
            this.col_dgvPaymentItems_Notes.MinimumWidth = 50;
            this.col_dgvPaymentItems_Notes.Name = "col_dgvPaymentItems_Notes";
            this.col_dgvPaymentItems_Notes.ReadOnly = true;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AllowUserToResizeRows = false;
            this.dgvPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgvPayments_Approved,
            this.col_dgvPayments_Rejected,
            this.col_dgvPayments_Id,
            this.col_dgvPayments_No,
            this.col_dgvPayments_Timestamp,
            this.col_dgvPayments_Source_BankAccounts,
            this.col_dgvPayments_Target_BankAccounts,
            this.col_dgvPayments_Amount,
            this.col_dgvPayments_ConfirmationNumber,
            this.col_dgvPayments_Notes});
            this.dgvPayments.Location = new System.Drawing.Point(0, 0);
            this.dgvPayments.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(599, 223);
            this.dgvPayments.TabIndex = 8;
            this.dgvPayments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayments_CellContentClick);
            this.dgvPayments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayments_CellDoubleClick);
            // 
            // col_dgvPayments_Approved
            // 
            this.col_dgvPayments_Approved.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvPayments_Approved.HeaderText = "OK";
            this.col_dgvPayments_Approved.MinimumWidth = 30;
            this.col_dgvPayments_Approved.Name = "col_dgvPayments_Approved";
            this.col_dgvPayments_Approved.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_dgvPayments_Approved.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_dgvPayments_Approved.Width = 30;
            // 
            // col_dgvPayments_Rejected
            // 
            this.col_dgvPayments_Rejected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvPayments_Rejected.HeaderText = "X";
            this.col_dgvPayments_Rejected.MinimumWidth = 30;
            this.col_dgvPayments_Rejected.Name = "col_dgvPayments_Rejected";
            this.col_dgvPayments_Rejected.Width = 30;
            // 
            // col_dgvPayments_Id
            // 
            this.col_dgvPayments_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvPayments_Id.HeaderText = "Id";
            this.col_dgvPayments_Id.Name = "col_dgvPayments_Id";
            this.col_dgvPayments_Id.ReadOnly = true;
            this.col_dgvPayments_Id.Visible = false;
            // 
            // col_dgvPayments_No
            // 
            this.col_dgvPayments_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvPayments_No.HeaderText = "No";
            this.col_dgvPayments_No.MinimumWidth = 30;
            this.col_dgvPayments_No.Name = "col_dgvPayments_No";
            this.col_dgvPayments_No.ReadOnly = true;
            this.col_dgvPayments_No.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_dgvPayments_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_dgvPayments_No.Width = 30;
            // 
            // col_dgvPayments_Timestamp
            // 
            this.col_dgvPayments_Timestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yy HH:mm";
            this.col_dgvPayments_Timestamp.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_dgvPayments_Timestamp.HeaderText = "Date";
            this.col_dgvPayments_Timestamp.MinimumWidth = 40;
            this.col_dgvPayments_Timestamp.Name = "col_dgvPayments_Timestamp";
            this.col_dgvPayments_Timestamp.ReadOnly = true;
            this.col_dgvPayments_Timestamp.Width = 40;
            // 
            // col_dgvPayments_Source_BankAccounts
            // 
            this.col_dgvPayments_Source_BankAccounts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvPayments_Source_BankAccounts.HeaderText = "Source";
            this.col_dgvPayments_Source_BankAccounts.MinimumWidth = 50;
            this.col_dgvPayments_Source_BankAccounts.Name = "col_dgvPayments_Source_BankAccounts";
            this.col_dgvPayments_Source_BankAccounts.Width = 50;
            // 
            // col_dgvPayments_Target_BankAccounts
            // 
            this.col_dgvPayments_Target_BankAccounts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvPayments_Target_BankAccounts.HeaderText = "Target";
            this.col_dgvPayments_Target_BankAccounts.MinimumWidth = 50;
            this.col_dgvPayments_Target_BankAccounts.Name = "col_dgvPayments_Target_BankAccounts";
            this.col_dgvPayments_Target_BankAccounts.Width = 50;
            // 
            // col_dgvPayments_Amount
            // 
            this.col_dgvPayments_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.col_dgvPayments_Amount.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_dgvPayments_Amount.HeaderText = "Amount";
            this.col_dgvPayments_Amount.MinimumWidth = 50;
            this.col_dgvPayments_Amount.Name = "col_dgvPayments_Amount";
            this.col_dgvPayments_Amount.ReadOnly = true;
            this.col_dgvPayments_Amount.Width = 50;
            // 
            // col_dgvPayments_ConfirmationNumber
            // 
            this.col_dgvPayments_ConfirmationNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvPayments_ConfirmationNumber.HeaderText = "Confirmation Number";
            this.col_dgvPayments_ConfirmationNumber.MinimumWidth = 70;
            this.col_dgvPayments_ConfirmationNumber.Name = "col_dgvPayments_ConfirmationNumber";
            this.col_dgvPayments_ConfirmationNumber.Width = 70;
            // 
            // col_dgvPayments_Notes
            // 
            this.col_dgvPayments_Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_dgvPayments_Notes.HeaderText = "Notes";
            this.col_dgvPayments_Notes.MinimumWidth = 30;
            this.col_dgvPayments_Notes.Name = "col_dgvPayments_Notes";
            this.col_dgvPayments_Notes.ReadOnly = true;
            // 
            // Payments_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 444);
            this.Controls.Add(this.scMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Payments_Main_Form";
            this.Text = "PAYMENTS";
            this.Load += new System.EventHandler(this.Form_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        protected System.Windows.Forms.DataGridView dgvPayments;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Employee_UserAccount;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Payrolls;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.PictureBox pbRefresh;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_StartDate;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_EndDate;
        private System.Windows.Forms.Button btnFilter;
        private LIBUtil.Desktop.UserControls.InputControl_Dropdownlist iddl_Source_BankAccounts;
        private LIBUtil.Desktop.UserControls.InputControl_Dropdownlist iddl_Target_BankAccounts;
        protected System.Windows.Forms.DataGridView dgvPaymentItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPaymentItems_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPaymentItems_Payrolls_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPaymentItems_Employee_UserAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPaymentItems_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPaymentItems_Notes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_dgvPayments_Approved;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_dgvPayments_Rejected;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPayments_Id;
        private System.Windows.Forms.DataGridViewLinkColumn col_dgvPayments_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPayments_Timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPayments_Source_BankAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPayments_Target_BankAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPayments_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPayments_ConfirmationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPayments_Notes;
    }
}