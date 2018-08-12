namespace HR_Desktop.Payroll
{
    partial class Payrolls_Main_Form
    {
        /// <summary>
        //// <summary>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.scSaleInvoices = new System.Windows.Forms.SplitContainer();
            this.btnFilter = new System.Windows.Forms.Button();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.itxt_Employee_UserAccount = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.idtp_EndDate = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.idtp_StartDate = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_add = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_log = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_payments = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPayrolls = new System.Windows.Forms.DataGridView();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.scDetails = new System.Windows.Forms.SplitContainer();
            this.dgvPayrollItems = new System.Windows.Forms.DataGridView();
            this.col_dgvPayrollItems_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPayrollItems_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPayrollItems_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPayrollItems_Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbRefreshCalculation = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.col_dgvPayrolls_Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_dgvPayrolls_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPayrolls_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPayrolls_Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPayrolls_UserAccounts_Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvPayrolls_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scSaleInvoices)).BeginInit();
            this.scSaleInvoices.Panel1.SuspendLayout();
            this.scSaleInvoices.Panel2.SuspendLayout();
            this.scSaleInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayrolls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scDetails)).BeginInit();
            this.scDetails.Panel1.SuspendLayout();
            this.scDetails.Panel2.SuspendLayout();
            this.scDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayrollItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefreshCalculation)).BeginInit();
            this.SuspendLayout();
            // 
            // scSaleInvoices
            // 
            this.scSaleInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSaleInvoices.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scSaleInvoices.IsSplitterFixed = true;
            this.scSaleInvoices.Location = new System.Drawing.Point(0, 0);
            this.scSaleInvoices.Margin = new System.Windows.Forms.Padding(4);
            this.scSaleInvoices.Name = "scSaleInvoices";
            // 
            // scSaleInvoices.Panel1
            // 
            this.scSaleInvoices.Panel1.Controls.Add(this.btnFilter);
            this.scSaleInvoices.Panel1.Controls.Add(this.pbRefresh);
            this.scSaleInvoices.Panel1.Controls.Add(this.itxt_Employee_UserAccount);
            this.scSaleInvoices.Panel1.Controls.Add(this.idtp_EndDate);
            this.scSaleInvoices.Panel1.Controls.Add(this.idtp_StartDate);
            this.scSaleInvoices.Panel1.Controls.Add(this.menuStrip1);
            // 
            // scSaleInvoices.Panel2
            // 
            this.scSaleInvoices.Panel2.Controls.Add(this.dgvPayrolls);
            this.scSaleInvoices.Size = new System.Drawing.Size(1011, 245);
            this.scSaleInvoices.SplitterDistance = 200;
            this.scSaleInvoices.SplitterWidth = 1;
            this.scSaleInvoices.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(96, 170);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 27);
            this.btnFilter.TabIndex = 21;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // pbRefresh
            // 
            this.pbRefresh.BackColor = System.Drawing.Color.Transparent;
            this.pbRefresh.BackgroundImage = global::HR_Desktop.Properties.Resources.refresh;
            this.pbRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRefresh.Location = new System.Drawing.Point(227, 33);
            this.pbRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(33, 28);
            this.pbRefresh.TabIndex = 10;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // itxt_Employee_UserAccount
            // 
            this.itxt_Employee_UserAccount.IsBrowseMode = true;
            this.itxt_Employee_UserAccount.LabelText = "Employee";
            this.itxt_Employee_UserAccount.Location = new System.Drawing.Point(4, 43);
            this.itxt_Employee_UserAccount.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Employee_UserAccount.MaxLength = 32767;
            this.itxt_Employee_UserAccount.MultiLine = false;
            this.itxt_Employee_UserAccount.Name = "itxt_Employee_UserAccount";
            this.itxt_Employee_UserAccount.PasswordChar = '\0';
            this.itxt_Employee_UserAccount.RowCount = 1;
            this.itxt_Employee_UserAccount.ShowDeleteButton = true;
            this.itxt_Employee_UserAccount.ShowTextboxOnly = false;
            this.itxt_Employee_UserAccount.Size = new System.Drawing.Size(255, 50);
            this.itxt_Employee_UserAccount.TabIndex = 16;
            this.itxt_Employee_UserAccount.ValueText = "";
            this.itxt_Employee_UserAccount.isBrowseMode_Clicked += new System.EventHandler(this.itxt_UserAccount_isBrowseMode_Clicked);
            // 
            // idtp_EndDate
            // 
            this.idtp_EndDate.Checked = false;
            this.idtp_EndDate.CustomFormat = "dd/MM/yy";
            this.idtp_EndDate.DefaultCheckedValue = false;
            this.idtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_EndDate.LabelText = "End";
            this.idtp_EndDate.Location = new System.Drawing.Point(137, 103);
            this.idtp_EndDate.Margin = new System.Windows.Forms.Padding(5);
            this.idtp_EndDate.Name = "idtp_EndDate";
            this.idtp_EndDate.ShowCheckBox = true;
            this.idtp_EndDate.ShowUpAndDown = false;
            this.idtp_EndDate.Size = new System.Drawing.Size(123, 50);
            this.idtp_EndDate.TabIndex = 19;
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
            this.idtp_StartDate.Location = new System.Drawing.Point(5, 103);
            this.idtp_StartDate.Margin = new System.Windows.Forms.Padding(5);
            this.idtp_StartDate.Name = "idtp_StartDate";
            this.idtp_StartDate.ShowCheckBox = true;
            this.idtp_StartDate.ShowUpAndDown = false;
            this.idtp_StartDate.Size = new System.Drawing.Size(123, 50);
            this.idtp_StartDate.TabIndex = 18;
            this.idtp_StartDate.Value = new System.DateTime(1753, 1, 1, 17, 39, 17, 439);
            this.idtp_StartDate.ValueTimeSpan = System.TimeSpan.Parse("17:39:17.4390000");
            this.idtp_StartDate.ValueChanged += new System.EventHandler(this.idtp_Date_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_add,
            this.menu_log,
            this.menu_payments});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(200, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_add
            // 
            this.menu_add.Name = "menu_add";
            this.menu_add.Size = new System.Drawing.Size(53, 24);
            this.menu_add.Text = "ADD";
            // 
            // menu_log
            // 
            this.menu_log.Name = "menu_log";
            this.menu_log.Size = new System.Drawing.Size(48, 24);
            this.menu_log.Text = "LOG";
            this.menu_log.Click += new System.EventHandler(this.menu_log_Click);
            // 
            // menu_payments
            // 
            this.menu_payments.Name = "menu_payments";
            this.menu_payments.Size = new System.Drawing.Size(93, 24);
            this.menu_payments.Text = "PAYMENTS";
            this.menu_payments.Click += new System.EventHandler(this.menu_payment_Click);
            // 
            // dgvPayrolls
            // 
            this.dgvPayrolls.AllowUserToAddRows = false;
            this.dgvPayrolls.AllowUserToDeleteRows = false;
            this.dgvPayrolls.AllowUserToResizeRows = false;
            this.dgvPayrolls.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayrolls.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayrolls.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPayrolls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayrolls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgvPayrolls_Selected,
            this.col_dgvPayrolls_Id,
            this.col_dgvPayrolls_No,
            this.col_dgvPayrolls_Timestamp,
            this.col_dgvPayrolls_UserAccounts_Fullname,
            this.col_dgvPayrolls_Amount});
            this.dgvPayrolls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayrolls.Location = new System.Drawing.Point(0, 0);
            this.dgvPayrolls.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPayrolls.MultiSelect = false;
            this.dgvPayrolls.Name = "dgvPayrolls";
            this.dgvPayrolls.RowHeadersVisible = false;
            this.dgvPayrolls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayrolls.Size = new System.Drawing.Size(810, 245);
            this.dgvPayrolls.TabIndex = 8;
            this.dgvPayrolls.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayrolls_CellContentClick);
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Margin = new System.Windows.Forms.Padding(4);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.scSaleInvoices);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scDetails);
            this.scMain.Size = new System.Drawing.Size(1011, 469);
            this.scMain.SplitterDistance = 245;
            this.scMain.SplitterWidth = 1;
            this.scMain.TabIndex = 1;
            // 
            // scDetails
            // 
            this.scDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scDetails.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scDetails.IsSplitterFixed = true;
            this.scDetails.Location = new System.Drawing.Point(0, 0);
            this.scDetails.Margin = new System.Windows.Forms.Padding(4);
            this.scDetails.Name = "scDetails";
            // 
            // scDetails.Panel1
            // 
            this.scDetails.Panel1.Controls.Add(this.dgvPayrollItems);
            // 
            // scDetails.Panel2
            // 
            this.scDetails.Panel2.Controls.Add(this.pbRefreshCalculation);
            this.scDetails.Panel2.Controls.Add(this.label1);
            this.scDetails.Panel2.Controls.Add(this.lblTotalAmount);
            this.scDetails.Panel2.Controls.Add(this.btnPayment);
            this.scDetails.Size = new System.Drawing.Size(1011, 223);
            this.scDetails.SplitterDistance = 852;
            this.scDetails.SplitterWidth = 1;
            this.scDetails.TabIndex = 0;
            // 
            // dgvPayrollItems
            // 
            this.dgvPayrollItems.AllowUserToAddRows = false;
            this.dgvPayrollItems.AllowUserToDeleteRows = false;
            this.dgvPayrollItems.AllowUserToResizeRows = false;
            this.dgvPayrollItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayrollItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayrollItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPayrollItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayrollItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgvPayrollItems_Id,
            this.col_dgvPayrollItems_Description,
            this.col_dgvPayrollItems_Amount,
            this.col_dgvPayrollItems_Notes});
            this.dgvPayrollItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayrollItems.Location = new System.Drawing.Point(0, 0);
            this.dgvPayrollItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPayrollItems.MultiSelect = false;
            this.dgvPayrollItems.Name = "dgvPayrollItems";
            this.dgvPayrollItems.RowHeadersVisible = false;
            this.dgvPayrollItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayrollItems.Size = new System.Drawing.Size(852, 223);
            this.dgvPayrollItems.TabIndex = 11;
            // 
            // col_dgvPayrollItems_Id
            // 
            this.col_dgvPayrollItems_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvPayrollItems_Id.HeaderText = "Id";
            this.col_dgvPayrollItems_Id.Name = "col_dgvPayrollItems_Id";
            this.col_dgvPayrollItems_Id.ReadOnly = true;
            this.col_dgvPayrollItems_Id.Visible = false;
            // 
            // col_dgvPayrollItems_Description
            // 
            this.col_dgvPayrollItems_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvPayrollItems_Description.HeaderText = "Description";
            this.col_dgvPayrollItems_Description.MinimumWidth = 80;
            this.col_dgvPayrollItems_Description.Name = "col_dgvPayrollItems_Description";
            this.col_dgvPayrollItems_Description.ReadOnly = true;
            this.col_dgvPayrollItems_Description.Width = 80;
            // 
            // col_dgvPayrollItems_Amount
            // 
            this.col_dgvPayrollItems_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            this.col_dgvPayrollItems_Amount.DefaultCellStyle = dataGridViewCellStyle10;
            this.col_dgvPayrollItems_Amount.HeaderText = "Amount";
            this.col_dgvPayrollItems_Amount.MinimumWidth = 60;
            this.col_dgvPayrollItems_Amount.Name = "col_dgvPayrollItems_Amount";
            this.col_dgvPayrollItems_Amount.ReadOnly = true;
            this.col_dgvPayrollItems_Amount.Width = 60;
            // 
            // col_dgvPayrollItems_Notes
            // 
            this.col_dgvPayrollItems_Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_dgvPayrollItems_Notes.HeaderText = "Notes";
            this.col_dgvPayrollItems_Notes.MinimumWidth = 60;
            this.col_dgvPayrollItems_Notes.Name = "col_dgvPayrollItems_Notes";
            // 
            // pbRefreshCalculation
            // 
            this.pbRefreshCalculation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRefreshCalculation.BackColor = System.Drawing.Color.Transparent;
            this.pbRefreshCalculation.BackgroundImage = global::HR_Desktop.Properties.Resources.refresh;
            this.pbRefreshCalculation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRefreshCalculation.Location = new System.Drawing.Point(100, 72);
            this.pbRefreshCalculation.Margin = new System.Windows.Forms.Padding(4);
            this.pbRefreshCalculation.Name = "pbRefreshCalculation";
            this.pbRefreshCalculation.Size = new System.Drawing.Size(33, 28);
            this.pbRefreshCalculation.TabIndex = 11;
            this.pbRefreshCalculation.TabStop = false;
            this.pbRefreshCalculation.Click += new System.EventHandler(this.pbRefreshCalculation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Location = new System.Drawing.Point(25, 18);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(133, 28);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "lblTotalAmount";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayment.Location = new System.Drawing.Point(141, 72);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(100, 28);
            this.btnPayment.TabIndex = 0;
            this.btnPayment.Text = "PAY";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // col_dgvPayrolls_Selected
            // 
            this.col_dgvPayrolls_Selected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvPayrolls_Selected.HeaderText = "";
            this.col_dgvPayrolls_Selected.MinimumWidth = 30;
            this.col_dgvPayrolls_Selected.Name = "col_dgvPayrolls_Selected";
            this.col_dgvPayrolls_Selected.ReadOnly = true;
            this.col_dgvPayrolls_Selected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_dgvPayrolls_Selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_dgvPayrolls_Selected.Width = 30;
            // 
            // col_dgvPayrolls_Id
            // 
            this.col_dgvPayrolls_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvPayrolls_Id.HeaderText = "Id";
            this.col_dgvPayrolls_Id.Name = "col_dgvPayrolls_Id";
            this.col_dgvPayrolls_Id.ReadOnly = true;
            this.col_dgvPayrolls_Id.Visible = false;
            this.col_dgvPayrolls_Id.Width = 5;
            // 
            // col_dgvPayrolls_No
            // 
            this.col_dgvPayrolls_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvPayrolls_No.HeaderText = "No";
            this.col_dgvPayrolls_No.MinimumWidth = 30;
            this.col_dgvPayrolls_No.Name = "col_dgvPayrolls_No";
            this.col_dgvPayrolls_No.Width = 30;
            // 
            // col_dgvPayrolls_Timestamp
            // 
            this.col_dgvPayrolls_Timestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "dd/MM/yy HH:mm";
            this.col_dgvPayrolls_Timestamp.DefaultCellStyle = dataGridViewCellStyle7;
            this.col_dgvPayrolls_Timestamp.HeaderText = "Date";
            this.col_dgvPayrolls_Timestamp.MinimumWidth = 40;
            this.col_dgvPayrolls_Timestamp.Name = "col_dgvPayrolls_Timestamp";
            this.col_dgvPayrolls_Timestamp.ReadOnly = true;
            this.col_dgvPayrolls_Timestamp.Width = 40;
            // 
            // col_dgvPayrolls_UserAccounts_Fullname
            // 
            this.col_dgvPayrolls_UserAccounts_Fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_dgvPayrolls_UserAccounts_Fullname.HeaderText = "Employee";
            this.col_dgvPayrolls_UserAccounts_Fullname.MinimumWidth = 55;
            this.col_dgvPayrolls_UserAccounts_Fullname.Name = "col_dgvPayrolls_UserAccounts_Fullname";
            this.col_dgvPayrolls_UserAccounts_Fullname.ReadOnly = true;
            // 
            // col_dgvPayrolls_Amount
            // 
            this.col_dgvPayrolls_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            this.col_dgvPayrolls_Amount.DefaultCellStyle = dataGridViewCellStyle8;
            this.col_dgvPayrolls_Amount.HeaderText = "Amount";
            this.col_dgvPayrolls_Amount.MinimumWidth = 50;
            this.col_dgvPayrolls_Amount.Name = "col_dgvPayrolls_Amount";
            this.col_dgvPayrolls_Amount.ReadOnly = true;
            this.col_dgvPayrolls_Amount.Width = 50;
            // 
            // Payrolls_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 469);
            this.Controls.Add(this.scMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Payrolls_Main_Form";
            this.Text = "PAYROLL";
            this.Load += new System.EventHandler(this.Form_Load);
            this.scSaleInvoices.Panel1.ResumeLayout(false);
            this.scSaleInvoices.Panel1.PerformLayout();
            this.scSaleInvoices.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSaleInvoices)).EndInit();
            this.scSaleInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayrolls)).EndInit();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scDetails.Panel1.ResumeLayout(false);
            this.scDetails.Panel2.ResumeLayout(false);
            this.scDetails.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scDetails)).EndInit();
            this.scDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayrollItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefreshCalculation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scSaleInvoices;
        protected System.Windows.Forms.DataGridView dgvPayrolls;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_log;
        private System.Windows.Forms.ToolStripMenuItem menu_add;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.SplitContainer scDetails;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menu_payments;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.PictureBox pbRefreshCalculation;
        protected LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Employee_UserAccount;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_EndDate;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_StartDate;
        private System.Windows.Forms.Button btnFilter;
        protected System.Windows.Forms.DataGridView dgvPayrollItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPayrollItems_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPayrollItems_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPayrollItems_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPayrollItems_Notes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_dgvPayrolls_Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPayrolls_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPayrolls_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPayrolls_Timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPayrolls_UserAccounts_Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvPayrolls_Amount;
    }
}