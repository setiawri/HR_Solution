﻿namespace HR_Desktop.Admin
{
    partial class MasterData_v1_WorkshiftTemplates_Form
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
            this.iddl_DayOfWeek = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
            this.itxt_Notes = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Clients = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_WorkshiftCategories = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Name = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.idtp_Start = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.in_DurationMinutes = new LIBUtil.Desktop.UserControls.InputControl_Numeric();
            this.gbPayRates = new System.Windows.Forms.GroupBox();
            this.dgvBankAccounts = new System.Windows.Forms.DataGridView();
            this.col_dgvAttendancePayRates_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvAttendancePayRates_AttendanceStatuses_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvBankAccounts_AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dgvBankAccounts_Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAttendancePayRates = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlActionButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scInputLeft)).BeginInit();
            this.scInputLeft.Panel1.SuspendLayout();
            this.scInputLeft.Panel2.SuspendLayout();
            this.scInputLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scInputRight)).BeginInit();
            this.scInputRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scInputContainer)).BeginInit();
            this.scInputContainer.Panel1.SuspendLayout();
            this.scInputContainer.Panel2.SuspendLayout();
            this.scInputContainer.SuspendLayout();
            this.pnlQuickSearch.SuspendLayout();
            this.gbPayRates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(805, 34);
            // 
            // lnkClearQuickSearch
            // 
            this.lnkClearQuickSearch.TabStop = false;
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Location = new System.Drawing.Point(0, 252);
            this.pnlActionButtons.Margin = new System.Windows.Forms.Padding(5);
            this.pnlActionButtons.Size = new System.Drawing.Size(805, 28);
            // 
            // scInputLeft
            // 
            this.scInputLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // scInputLeft.Panel1
            // 
            this.scInputLeft.Panel1.Controls.Add(this.itxt_WorkshiftCategories);
            this.scInputLeft.Panel1.Controls.Add(this.in_DurationMinutes);
            this.scInputLeft.Panel1.Controls.Add(this.idtp_Start);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Name);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Clients);
            this.scInputLeft.Panel1.Controls.Add(this.iddl_DayOfWeek);
            // 
            // scInputLeft.Panel2
            // 
            this.scInputLeft.Panel2.Controls.Add(this.gbPayRates);
            this.scInputLeft.Panel2.Controls.Add(this.itxt_Notes);
            this.scInputLeft.Size = new System.Drawing.Size(574, 220);
            this.scInputLeft.SplitterWidth = 4;
            // 
            // scInputRight
            // 
            this.scInputRight.Margin = new System.Windows.Forms.Padding(5);
            this.scInputRight.Size = new System.Drawing.Size(224, 220);
            this.scInputRight.SplitterWidth = 7;
            // 
            // scMain
            // 
            this.scMain.Margin = new System.Windows.Forms.Padding(5);
            this.scMain.Size = new System.Drawing.Size(805, 750);
            this.scMain.SplitterDistance = 280;
            this.scMain.SplitterWidth = 6;
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Margin = new System.Windows.Forms.Padding(5);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnAttendancePayRates);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(5);
            this.pnlButtons.Size = new System.Drawing.Size(805, 32);
            this.pnlButtons.Controls.SetChildIndex(this.btnSearch, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnUpdate, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnLog, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnAdd, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnAttendancePayRates, 0);
            // 
            // scInputContainer
            // 
            this.scInputContainer.Margin = new System.Windows.Forms.Padding(5);
            this.scInputContainer.Size = new System.Drawing.Size(805, 220);
            this.scInputContainer.SplitterDistance = 574;
            this.scInputContainer.SplitterWidth = 7;
            // 
            // btnLog
            // 
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // pnlQuickSearch
            // 
            this.pnlQuickSearch.Margin = new System.Windows.Forms.Padding(5);
            this.pnlQuickSearch.Size = new System.Drawing.Size(765, 34);
            // 
            // iddl_DayOfWeek
            // 
            this.iddl_DayOfWeek.DisableTextInput = false;
            this.iddl_DayOfWeek.HideFilter = true;
            this.iddl_DayOfWeek.HideUpdateLink = true;
            this.iddl_DayOfWeek.LabelText = "*Day";
            this.iddl_DayOfWeek.Location = new System.Drawing.Point(5, 180);
            this.iddl_DayOfWeek.Margin = new System.Windows.Forms.Padding(5);
            this.iddl_DayOfWeek.Name = "iddl_DayOfWeek";
            this.iddl_DayOfWeek.SelectedIndex = -1;
            this.iddl_DayOfWeek.SelectedItem = null;
            this.iddl_DayOfWeek.SelectedItemText = "";
            this.iddl_DayOfWeek.SelectedValue = null;
            this.iddl_DayOfWeek.ShowDropdownlistOnly = false;
            this.iddl_DayOfWeek.Size = new System.Drawing.Size(121, 53);
            this.iddl_DayOfWeek.TabIndex = 0;
            // 
            // itxt_Notes
            // 
            this.itxt_Notes.IsBrowseMode = false;
            this.itxt_Notes.LabelText = "Notes";
            this.itxt_Notes.Location = new System.Drawing.Point(1, 10);
            this.itxt_Notes.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Notes.MaxLength = 32767;
            this.itxt_Notes.MultiLine = true;
            this.itxt_Notes.Name = "itxt_Notes";
            this.itxt_Notes.PasswordChar = '\0';
            this.itxt_Notes.RowCount = 3;
            this.itxt_Notes.ShowDeleteButton = false;
            this.itxt_Notes.ShowTextboxOnly = false;
            this.itxt_Notes.Size = new System.Drawing.Size(424, 87);
            this.itxt_Notes.TabIndex = 4;
            this.itxt_Notes.ValueText = "";
            // 
            // itxt_Clients
            // 
            this.itxt_Clients.IsBrowseMode = true;
            this.itxt_Clients.LabelText = "*Client";
            this.itxt_Clients.Location = new System.Drawing.Point(5, 10);
            this.itxt_Clients.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Clients.MaxLength = 32767;
            this.itxt_Clients.MultiLine = false;
            this.itxt_Clients.Name = "itxt_Clients";
            this.itxt_Clients.PasswordChar = '\0';
            this.itxt_Clients.RowCount = 1;
            this.itxt_Clients.ShowDeleteButton = false;
            this.itxt_Clients.ShowTextboxOnly = false;
            this.itxt_Clients.Size = new System.Drawing.Size(321, 50);
            this.itxt_Clients.TabIndex = 7;
            this.itxt_Clients.ValueText = "";
            this.itxt_Clients.isBrowseMode_Clicked += new System.EventHandler(this.itxt_Clients_isBrowseMode_Clicked);
            // 
            // itxt_WorkshiftCategories
            // 
            this.itxt_WorkshiftCategories.IsBrowseMode = true;
            this.itxt_WorkshiftCategories.LabelText = "*Category";
            this.itxt_WorkshiftCategories.Location = new System.Drawing.Point(5, 123);
            this.itxt_WorkshiftCategories.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_WorkshiftCategories.MaxLength = 32767;
            this.itxt_WorkshiftCategories.MultiLine = false;
            this.itxt_WorkshiftCategories.Name = "itxt_WorkshiftCategories";
            this.itxt_WorkshiftCategories.PasswordChar = '\0';
            this.itxt_WorkshiftCategories.RowCount = 1;
            this.itxt_WorkshiftCategories.ShowDeleteButton = true;
            this.itxt_WorkshiftCategories.ShowTextboxOnly = false;
            this.itxt_WorkshiftCategories.Size = new System.Drawing.Size(321, 50);
            this.itxt_WorkshiftCategories.TabIndex = 8;
            this.itxt_WorkshiftCategories.ValueText = "";
            this.itxt_WorkshiftCategories.isBrowseMode_Clicked += new System.EventHandler(this.itxt_WorkshiftCategories_isBrowseMode_Clicked);
            // 
            // itxt_Name
            // 
            this.itxt_Name.IsBrowseMode = false;
            this.itxt_Name.LabelText = "*Name";
            this.itxt_Name.Location = new System.Drawing.Point(5, 66);
            this.itxt_Name.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Name.MaxLength = 32767;
            this.itxt_Name.MultiLine = false;
            this.itxt_Name.Name = "itxt_Name";
            this.itxt_Name.PasswordChar = '\0';
            this.itxt_Name.RowCount = 1;
            this.itxt_Name.ShowDeleteButton = false;
            this.itxt_Name.ShowTextboxOnly = false;
            this.itxt_Name.Size = new System.Drawing.Size(321, 50);
            this.itxt_Name.TabIndex = 9;
            this.itxt_Name.ValueText = "";
            // 
            // idtp_Start
            // 
            this.idtp_Start.Checked = true;
            this.idtp_Start.CustomFormat = "HH:mm";
            this.idtp_Start.DefaultCheckedValue = false;
            this.idtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_Start.LabelText = "*Start";
            this.idtp_Start.Location = new System.Drawing.Point(133, 180);
            this.idtp_Start.Margin = new System.Windows.Forms.Padding(5);
            this.idtp_Start.Name = "idtp_Start";
            this.idtp_Start.ShowCheckBox = false;
            this.idtp_Start.ShowUpAndDown = true;
            this.idtp_Start.Size = new System.Drawing.Size(93, 53);
            this.idtp_Start.TabIndex = 0;
            this.idtp_Start.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.idtp_Start.ValueTimeSpan = System.TimeSpan.Parse("00:00:00");
            // 
            // in_DurationMinutes
            // 
            this.in_DurationMinutes.Checked = false;
            this.in_DurationMinutes.DecimalPlaces = 0;
            this.in_DurationMinutes.HideUpDown = false;
            this.in_DurationMinutes.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.in_DurationMinutes.LabelText = "*Minutes";
            this.in_DurationMinutes.Location = new System.Drawing.Point(233, 180);
            this.in_DurationMinutes.Margin = new System.Windows.Forms.Padding(5);
            this.in_DurationMinutes.MaximumValue = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.in_DurationMinutes.MinimumValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.in_DurationMinutes.Name = "in_DurationMinutes";
            this.in_DurationMinutes.ShowAllowDecimalCheckbox = false;
            this.in_DurationMinutes.ShowCheckbox = false;
            this.in_DurationMinutes.ShowTextboxOnly = false;
            this.in_DurationMinutes.Size = new System.Drawing.Size(93, 53);
            this.in_DurationMinutes.TabIndex = 0;
            this.in_DurationMinutes.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // gbPayRates
            // 
            this.gbPayRates.Controls.Add(this.dgvBankAccounts);
            this.gbPayRates.Location = new System.Drawing.Point(1, 106);
            this.gbPayRates.Margin = new System.Windows.Forms.Padding(4);
            this.gbPayRates.Name = "gbPayRates";
            this.gbPayRates.Padding = new System.Windows.Forms.Padding(4, 4, 4, 6);
            this.gbPayRates.Size = new System.Drawing.Size(424, 159);
            this.gbPayRates.TabIndex = 10;
            this.gbPayRates.TabStop = false;
            this.gbPayRates.Text = "Pay Rates";
            // 
            // dgvBankAccounts
            // 
            this.dgvBankAccounts.AllowUserToAddRows = false;
            this.dgvBankAccounts.AllowUserToDeleteRows = false;
            this.dgvBankAccounts.AllowUserToResizeRows = false;
            this.dgvBankAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvBankAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBankAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBankAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dgvAttendancePayRates_Id,
            this.col_dgvAttendancePayRates_AttendanceStatuses_Name,
            this.col_dgvBankAccounts_AccountNumber,
            this.col_dgvBankAccounts_Notes});
            this.dgvBankAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBankAccounts.Location = new System.Drawing.Point(4, 19);
            this.dgvBankAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBankAccounts.MultiSelect = false;
            this.dgvBankAccounts.Name = "dgvBankAccounts";
            this.dgvBankAccounts.RowHeadersVisible = false;
            this.dgvBankAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBankAccounts.Size = new System.Drawing.Size(416, 134);
            this.dgvBankAccounts.TabIndex = 5;
            // 
            // col_dgvAttendancePayRates_Id
            // 
            this.col_dgvAttendancePayRates_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_dgvAttendancePayRates_Id.HeaderText = "Id";
            this.col_dgvAttendancePayRates_Id.Name = "col_dgvAttendancePayRates_Id";
            this.col_dgvAttendancePayRates_Id.Visible = false;
            // 
            // col_dgvAttendancePayRates_AttendanceStatuses_Name
            // 
            this.col_dgvAttendancePayRates_AttendanceStatuses_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_dgvAttendancePayRates_AttendanceStatuses_Name.HeaderText = "Status";
            this.col_dgvAttendancePayRates_AttendanceStatuses_Name.MinimumWidth = 40;
            this.col_dgvAttendancePayRates_AttendanceStatuses_Name.Name = "col_dgvAttendancePayRates_AttendanceStatuses_Name";
            this.col_dgvAttendancePayRates_AttendanceStatuses_Name.Width = 40;
            // 
            // col_dgvBankAccounts_AccountNumber
            // 
            this.col_dgvBankAccounts_AccountNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.col_dgvBankAccounts_AccountNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_dgvBankAccounts_AccountNumber.HeaderText = "Amount";
            this.col_dgvBankAccounts_AccountNumber.MinimumWidth = 55;
            this.col_dgvBankAccounts_AccountNumber.Name = "col_dgvBankAccounts_AccountNumber";
            this.col_dgvBankAccounts_AccountNumber.Width = 55;
            // 
            // col_dgvBankAccounts_Notes
            // 
            this.col_dgvBankAccounts_Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_dgvBankAccounts_Notes.HeaderText = "Notes";
            this.col_dgvBankAccounts_Notes.MinimumWidth = 30;
            this.col_dgvBankAccounts_Notes.Name = "col_dgvBankAccounts_Notes";
            // 
            // btnAttendancePayRates
            // 
            this.btnAttendancePayRates.Location = new System.Drawing.Point(402, 2);
            this.btnAttendancePayRates.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttendancePayRates.Name = "btnAttendancePayRates";
            this.btnAttendancePayRates.Size = new System.Drawing.Size(100, 28);
            this.btnAttendancePayRates.TabIndex = 5;
            this.btnAttendancePayRates.Text = "PAY RATE";
            this.btnAttendancePayRates.UseVisualStyleBackColor = true;
            this.btnAttendancePayRates.Click += new System.EventHandler(this.btnAttendancePayRates_Click);
            // 
            // MasterData_v1_WorkshiftTemplates_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 750);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MasterData_v1_WorkshiftTemplates_Form";
            this.Text = "WORKSHIFT TEMPLATES";
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.panel1.ResumeLayout(false);
            this.pnlActionButtons.ResumeLayout(false);
            this.scInputLeft.Panel1.ResumeLayout(false);
            this.scInputLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scInputLeft)).EndInit();
            this.scInputLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scInputRight)).EndInit();
            this.scInputRight.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.scInputContainer.Panel1.ResumeLayout(false);
            this.scInputContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scInputContainer)).EndInit();
            this.scInputContainer.ResumeLayout(false);
            this.pnlQuickSearch.ResumeLayout(false);
            this.pnlQuickSearch.PerformLayout();
            this.gbPayRates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Notes;
        private LIBUtil.Desktop.UserControls.InputControl_Dropdownlist iddl_DayOfWeek;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Clients;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_WorkshiftCategories;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Name;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_Start;
        private LIBUtil.Desktop.UserControls.InputControl_Numeric in_DurationMinutes;
        private System.Windows.Forms.GroupBox gbPayRates;
        protected System.Windows.Forms.DataGridView dgvBankAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendancePayRates_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvAttendancePayRates_AttendanceStatuses_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvBankAccounts_AccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dgvBankAccounts_Notes;
        protected System.Windows.Forms.Button btnAttendancePayRates;
    }
}