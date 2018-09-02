namespace HR_Desktop.Admin
{
    partial class MasterData_v1_Workshifts_Form
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
            this.iddl_DayOfWeek = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
            this.itxt_Notes = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Clients = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_WorkshiftCategories = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Name = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.idtp_Start = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.in_DurationMinutes = new LIBUtil.Desktop.UserControls.InputControl_Numeric();
            this.gb_Template = new System.Windows.Forms.GroupBox();
            this.itxt_WorkshiftTemplate = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_UserAccounts = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
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
            this.gb_Template.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(919, 34);
            // 
            // lnkClearQuickSearch
            // 
            this.lnkClearQuickSearch.TabStop = false;
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Location = new System.Drawing.Point(0, 252);
            this.pnlActionButtons.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlActionButtons.Size = new System.Drawing.Size(919, 28);
            // 
            // scInputLeft
            // 
            this.scInputLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // scInputLeft.Panel1
            // 
            this.scInputLeft.Panel1.Controls.Add(this.gb_Template);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_UserAccounts);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Name);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Clients);
            // 
            // scInputLeft.Panel2
            // 
            this.scInputLeft.Panel2.Controls.Add(this.itxt_WorkshiftCategories);
            this.scInputLeft.Panel2.Controls.Add(this.itxt_Notes);
            this.scInputLeft.Panel2.Controls.Add(this.iddl_DayOfWeek);
            this.scInputLeft.Panel2.Controls.Add(this.in_DurationMinutes);
            this.scInputLeft.Panel2.Controls.Add(this.idtp_Start);
            this.scInputLeft.Size = new System.Drawing.Size(500, 220);
            this.scInputLeft.SplitterWidth = 4;
            // 
            // scInputRight
            // 
            this.scInputRight.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.scInputRight.Size = new System.Drawing.Size(412, 220);
            this.scInputRight.SplitterWidth = 7;
            // 
            // scMain
            // 
            this.scMain.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.scMain.Size = new System.Drawing.Size(919, 750);
            this.scMain.SplitterDistance = 280;
            this.scMain.SplitterWidth = 6;
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnAttendancePayRates);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlButtons.Size = new System.Drawing.Size(919, 32);
            this.pnlButtons.Controls.SetChildIndex(this.btnSearch, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnUpdate, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnLog, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnAdd, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnAttendancePayRates, 0);
            // 
            // scInputContainer
            // 
            this.scInputContainer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.scInputContainer.Size = new System.Drawing.Size(919, 220);
            this.scInputContainer.SplitterWidth = 7;
            // 
            // btnLog
            // 
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // pnlQuickSearch
            // 
            this.pnlQuickSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlQuickSearch.Size = new System.Drawing.Size(879, 34);
            // 
            // iddl_DayOfWeek
            // 
            this.iddl_DayOfWeek.DisableTextInput = false;
            this.iddl_DayOfWeek.HideFilter = true;
            this.iddl_DayOfWeek.HideUpdateLink = true;
            this.iddl_DayOfWeek.LabelText = "*Day";
            this.iddl_DayOfWeek.Location = new System.Drawing.Point(5, 64);
            this.iddl_DayOfWeek.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.iddl_DayOfWeek.Name = "iddl_DayOfWeek";
            this.iddl_DayOfWeek.SelectedIndex = -1;
            this.iddl_DayOfWeek.SelectedItem = null;
            this.iddl_DayOfWeek.SelectedItemText = "";
            this.iddl_DayOfWeek.SelectedValue = null;
            this.iddl_DayOfWeek.ShowDropdownlistOnly = false;
            this.iddl_DayOfWeek.Size = new System.Drawing.Size(121, 50);
            this.iddl_DayOfWeek.TabIndex = 1;
            // 
            // itxt_Notes
            // 
            this.itxt_Notes.IsBrowseMode = false;
            this.itxt_Notes.LabelText = "Notes";
            this.itxt_Notes.Location = new System.Drawing.Point(6, 124);
            this.itxt_Notes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.itxt_Notes.MaxLength = 32767;
            this.itxt_Notes.MultiLine = true;
            this.itxt_Notes.Name = "itxt_Notes";
            this.itxt_Notes.PasswordChar = '\0';
            this.itxt_Notes.RowCount = 3;
            this.itxt_Notes.ShowDeleteButton = false;
            this.itxt_Notes.ShowTextboxOnly = false;
            this.itxt_Notes.Size = new System.Drawing.Size(321, 87);
            this.itxt_Notes.TabIndex = 5;
            this.itxt_Notes.ValueText = "";
            // 
            // itxt_Clients
            // 
            this.itxt_Clients.IsBrowseMode = true;
            this.itxt_Clients.LabelText = "*Client";
            this.itxt_Clients.Location = new System.Drawing.Point(5, 10);
            this.itxt_Clients.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.itxt_Clients.MaxLength = 32767;
            this.itxt_Clients.MultiLine = false;
            this.itxt_Clients.Name = "itxt_Clients";
            this.itxt_Clients.PasswordChar = '\0';
            this.itxt_Clients.RowCount = 1;
            this.itxt_Clients.ShowDeleteButton = false;
            this.itxt_Clients.ShowTextboxOnly = false;
            this.itxt_Clients.Size = new System.Drawing.Size(321, 50);
            this.itxt_Clients.TabIndex = 0;
            this.itxt_Clients.ValueText = "";
            this.itxt_Clients.isBrowseMode_Clicked += new System.EventHandler(this.itxt_Clients_isBrowseMode_Clicked);
            this.itxt_Clients.onTextChanged += new System.EventHandler(this.itxt_Clients_onTextChanged);
            // 
            // itxt_WorkshiftCategories
            // 
            this.itxt_WorkshiftCategories.IsBrowseMode = true;
            this.itxt_WorkshiftCategories.LabelText = "*Category";
            this.itxt_WorkshiftCategories.Location = new System.Drawing.Point(5, 9);
            this.itxt_WorkshiftCategories.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.itxt_WorkshiftCategories.MaxLength = 32767;
            this.itxt_WorkshiftCategories.MultiLine = false;
            this.itxt_WorkshiftCategories.Name = "itxt_WorkshiftCategories";
            this.itxt_WorkshiftCategories.PasswordChar = '\0';
            this.itxt_WorkshiftCategories.RowCount = 1;
            this.itxt_WorkshiftCategories.ShowDeleteButton = true;
            this.itxt_WorkshiftCategories.ShowTextboxOnly = false;
            this.itxt_WorkshiftCategories.Size = new System.Drawing.Size(321, 50);
            this.itxt_WorkshiftCategories.TabIndex = 0;
            this.itxt_WorkshiftCategories.ValueText = "";
            this.itxt_WorkshiftCategories.isBrowseMode_Clicked += new System.EventHandler(this.itxt_WorkshiftCategories_isBrowseMode_Clicked);
            // 
            // itxt_Name
            // 
            this.itxt_Name.IsBrowseMode = false;
            this.itxt_Name.LabelText = "*Name";
            this.itxt_Name.Location = new System.Drawing.Point(5, 185);
            this.itxt_Name.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.itxt_Name.MaxLength = 32767;
            this.itxt_Name.MultiLine = false;
            this.itxt_Name.Name = "itxt_Name";
            this.itxt_Name.PasswordChar = '\0';
            this.itxt_Name.RowCount = 1;
            this.itxt_Name.ShowDeleteButton = false;
            this.itxt_Name.ShowTextboxOnly = false;
            this.itxt_Name.Size = new System.Drawing.Size(321, 50);
            this.itxt_Name.TabIndex = 3;
            this.itxt_Name.ValueText = "";
            // 
            // idtp_Start
            // 
            this.idtp_Start.Checked = true;
            this.idtp_Start.CustomFormat = "HH:mm";
            this.idtp_Start.DefaultCheckedValue = false;
            this.idtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_Start.LabelText = "*Start";
            this.idtp_Start.Location = new System.Drawing.Point(133, 64);
            this.idtp_Start.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.idtp_Start.Name = "idtp_Start";
            this.idtp_Start.ShowCheckBox = false;
            this.idtp_Start.ShowUpAndDown = true;
            this.idtp_Start.Size = new System.Drawing.Size(100, 50);
            this.idtp_Start.TabIndex = 2;
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
            this.in_DurationMinutes.Location = new System.Drawing.Point(240, 65);
            this.in_DurationMinutes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.in_DurationMinutes.Size = new System.Drawing.Size(87, 50);
            this.in_DurationMinutes.TabIndex = 3;
            this.in_DurationMinutes.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // gb_Template
            // 
            this.gb_Template.Controls.Add(this.itxt_WorkshiftTemplate);
            this.gb_Template.Enabled = false;
            this.gb_Template.Location = new System.Drawing.Point(5, 68);
            this.gb_Template.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_Template.Name = "gb_Template";
            this.gb_Template.Padding = new System.Windows.Forms.Padding(7, 4, 7, 6);
            this.gb_Template.Size = new System.Drawing.Size(321, 52);
            this.gb_Template.TabIndex = 1;
            this.gb_Template.TabStop = false;
            this.gb_Template.Text = "TEMPLATES";
            // 
            // itxt_WorkshiftTemplate
            // 
            this.itxt_WorkshiftTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itxt_WorkshiftTemplate.IsBrowseMode = true;
            this.itxt_WorkshiftTemplate.LabelText = "Templates";
            this.itxt_WorkshiftTemplate.Location = new System.Drawing.Point(7, 19);
            this.itxt_WorkshiftTemplate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.itxt_WorkshiftTemplate.MaxLength = 32767;
            this.itxt_WorkshiftTemplate.MultiLine = false;
            this.itxt_WorkshiftTemplate.Name = "itxt_WorkshiftTemplate";
            this.itxt_WorkshiftTemplate.PasswordChar = '\0';
            this.itxt_WorkshiftTemplate.RowCount = 1;
            this.itxt_WorkshiftTemplate.ShowDeleteButton = true;
            this.itxt_WorkshiftTemplate.ShowTextboxOnly = true;
            this.itxt_WorkshiftTemplate.Size = new System.Drawing.Size(307, 27);
            this.itxt_WorkshiftTemplate.TabIndex = 0;
            this.itxt_WorkshiftTemplate.ValueText = "";
            this.itxt_WorkshiftTemplate.isBrowseMode_Clicked += new System.EventHandler(this.itxt_WorkshiftTemplate_isBrowseMode_Clicked);
            // 
            // itxt_UserAccounts
            // 
            this.itxt_UserAccounts.IsBrowseMode = true;
            this.itxt_UserAccounts.LabelText = "*Employee";
            this.itxt_UserAccounts.Location = new System.Drawing.Point(5, 126);
            this.itxt_UserAccounts.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.itxt_UserAccounts.MaxLength = 32767;
            this.itxt_UserAccounts.MultiLine = false;
            this.itxt_UserAccounts.Name = "itxt_UserAccounts";
            this.itxt_UserAccounts.PasswordChar = '\0';
            this.itxt_UserAccounts.RowCount = 1;
            this.itxt_UserAccounts.ShowDeleteButton = true;
            this.itxt_UserAccounts.ShowTextboxOnly = false;
            this.itxt_UserAccounts.Size = new System.Drawing.Size(321, 50);
            this.itxt_UserAccounts.TabIndex = 2;
            this.itxt_UserAccounts.ValueText = "";
            this.itxt_UserAccounts.isBrowseMode_Clicked += new System.EventHandler(this.itxt_UserAccounts_isBrowseMode_Clicked);
            // 
            // btnAttendancePayRates
            // 
            this.btnAttendancePayRates.Location = new System.Drawing.Point(403, 2);
            this.btnAttendancePayRates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAttendancePayRates.Name = "btnAttendancePayRates";
            this.btnAttendancePayRates.Size = new System.Drawing.Size(100, 28);
            this.btnAttendancePayRates.TabIndex = 4;
            this.btnAttendancePayRates.Text = "PAY RATE";
            this.btnAttendancePayRates.UseVisualStyleBackColor = true;
            this.btnAttendancePayRates.Click += new System.EventHandler(this.btnAttendancePayRates_Click);
            // 
            // MasterData_v1_Workshifts_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 750);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MasterData_v1_Workshifts_Form";
            this.Text = "WORKSHIFTS";
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
            this.gb_Template.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gb_Template;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_WorkshiftTemplate;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_UserAccounts;
        protected System.Windows.Forms.Button btnAttendancePayRates;
    }
}