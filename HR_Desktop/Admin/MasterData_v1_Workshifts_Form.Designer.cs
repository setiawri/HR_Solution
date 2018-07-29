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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(567, 28);
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Location = new System.Drawing.Point(0, 227);
            this.pnlActionButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActionButtons.Size = new System.Drawing.Size(567, 23);
            // 
            // scInputLeft
            // 
            this.scInputLeft.Margin = new System.Windows.Forms.Padding(2);
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
            this.scInputLeft.Panel2.Controls.Add(this.itxt_Notes);
            this.scInputLeft.Panel2.Controls.Add(this.itxt_WorkshiftCategories);
            this.scInputLeft.Panel2.Controls.Add(this.iddl_DayOfWeek);
            this.scInputLeft.Panel2.Controls.Add(this.in_DurationMinutes);
            this.scInputLeft.Panel2.Controls.Add(this.idtp_Start);
            this.scInputLeft.Size = new System.Drawing.Size(500, 201);
            this.scInputLeft.SplitterWidth = 3;
            // 
            // scInputRight
            // 
            this.scInputRight.Margin = new System.Windows.Forms.Padding(4);
            this.scInputRight.Size = new System.Drawing.Size(62, 201);
            this.scInputRight.SplitterWidth = 5;
            // 
            // scMain
            // 
            this.scMain.Margin = new System.Windows.Forms.Padding(4);
            this.scMain.Size = new System.Drawing.Size(567, 609);
            this.scMain.SplitterDistance = 250;
            this.scMain.SplitterWidth = 5;
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Margin = new System.Windows.Forms.Padding(4);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Size = new System.Drawing.Size(567, 26);
            // 
            // scInputContainer
            // 
            this.scInputContainer.Margin = new System.Windows.Forms.Padding(4);
            this.scInputContainer.Size = new System.Drawing.Size(567, 201);
            this.scInputContainer.SplitterWidth = 5;
            // 
            // btnLog
            // 
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // pnlQuickSearch
            // 
            this.pnlQuickSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pnlQuickSearch.Size = new System.Drawing.Size(537, 28);
            // 
            // iddl_DayOfWeek
            // 
            this.iddl_DayOfWeek.DisableTextInput = false;
            this.iddl_DayOfWeek.HideFilter = true;
            this.iddl_DayOfWeek.HideUpdateLink = true;
            this.iddl_DayOfWeek.LabelText = "*Day";
            this.iddl_DayOfWeek.Location = new System.Drawing.Point(4, 49);
            this.iddl_DayOfWeek.Margin = new System.Windows.Forms.Padding(4);
            this.iddl_DayOfWeek.Name = "iddl_DayOfWeek";
            this.iddl_DayOfWeek.SelectedItem = null;
            this.iddl_DayOfWeek.SelectedValue = null;
            this.iddl_DayOfWeek.ShowDropdownlistOnly = false;
            this.iddl_DayOfWeek.Size = new System.Drawing.Size(91, 41);
            this.iddl_DayOfWeek.TabIndex = 0;
            // 
            // itxt_Notes
            // 
            this.itxt_Notes.IsBrowseMode = false;
            this.itxt_Notes.LabelText = "Notes";
            this.itxt_Notes.Location = new System.Drawing.Point(4, 90);
            this.itxt_Notes.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Notes.MaxLength = 32767;
            this.itxt_Notes.MultiLine = true;
            this.itxt_Notes.Name = "itxt_Notes";
            this.itxt_Notes.PasswordChar = '\0';
            this.itxt_Notes.RowCount = 4;
            this.itxt_Notes.ShowDeleteButton = false;
            this.itxt_Notes.ShowTextboxOnly = false;
            this.itxt_Notes.Size = new System.Drawing.Size(241, 86);
            this.itxt_Notes.TabIndex = 4;
            this.itxt_Notes.ValueText = "";
            // 
            // itxt_Clients
            // 
            this.itxt_Clients.IsBrowseMode = true;
            this.itxt_Clients.LabelText = "*Client";
            this.itxt_Clients.Location = new System.Drawing.Point(4, 8);
            this.itxt_Clients.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Clients.MaxLength = 32767;
            this.itxt_Clients.MultiLine = false;
            this.itxt_Clients.Name = "itxt_Clients";
            this.itxt_Clients.PasswordChar = '\0';
            this.itxt_Clients.RowCount = 1;
            this.itxt_Clients.ShowDeleteButton = false;
            this.itxt_Clients.ShowTextboxOnly = false;
            this.itxt_Clients.Size = new System.Drawing.Size(241, 41);
            this.itxt_Clients.TabIndex = 7;
            this.itxt_Clients.ValueText = "";
            this.itxt_Clients.isBrowseMode_Clicked += new System.EventHandler(this.itxt_Clients_isBrowseMode_Clicked);
            // 
            // itxt_WorkshiftCategories
            // 
            this.itxt_WorkshiftCategories.IsBrowseMode = true;
            this.itxt_WorkshiftCategories.LabelText = "*Category";
            this.itxt_WorkshiftCategories.Location = new System.Drawing.Point(4, 8);
            this.itxt_WorkshiftCategories.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_WorkshiftCategories.MaxLength = 32767;
            this.itxt_WorkshiftCategories.MultiLine = false;
            this.itxt_WorkshiftCategories.Name = "itxt_WorkshiftCategories";
            this.itxt_WorkshiftCategories.PasswordChar = '\0';
            this.itxt_WorkshiftCategories.RowCount = 1;
            this.itxt_WorkshiftCategories.ShowDeleteButton = true;
            this.itxt_WorkshiftCategories.ShowTextboxOnly = false;
            this.itxt_WorkshiftCategories.Size = new System.Drawing.Size(241, 41);
            this.itxt_WorkshiftCategories.TabIndex = 8;
            this.itxt_WorkshiftCategories.ValueText = "";
            this.itxt_WorkshiftCategories.isBrowseMode_Clicked += new System.EventHandler(this.itxt_WorkshiftCategories_isBrowseMode_Clicked);
            // 
            // itxt_Name
            // 
            this.itxt_Name.IsBrowseMode = false;
            this.itxt_Name.LabelText = "*Name";
            this.itxt_Name.Location = new System.Drawing.Point(4, 132);
            this.itxt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Name.MaxLength = 32767;
            this.itxt_Name.MultiLine = false;
            this.itxt_Name.Name = "itxt_Name";
            this.itxt_Name.PasswordChar = '\0';
            this.itxt_Name.RowCount = 1;
            this.itxt_Name.ShowDeleteButton = false;
            this.itxt_Name.ShowTextboxOnly = false;
            this.itxt_Name.Size = new System.Drawing.Size(241, 41);
            this.itxt_Name.TabIndex = 9;
            this.itxt_Name.ValueText = "";
            // 
            // idtp_Start
            // 
            this.idtp_Start.Checked = false;
            this.idtp_Start.CustomFormat = "HH:mm";
            this.idtp_Start.DefaultCheckedValue = false;
            this.idtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_Start.LabelText = "*Start";
            this.idtp_Start.Location = new System.Drawing.Point(100, 49);
            this.idtp_Start.Margin = new System.Windows.Forms.Padding(4);
            this.idtp_Start.Name = "idtp_Start";
            this.idtp_Start.ShowCheckBox = false;
            this.idtp_Start.ShowUpAndDown = true;
            this.idtp_Start.Size = new System.Drawing.Size(70, 41);
            this.idtp_Start.TabIndex = 0;
            this.idtp_Start.Value = null;
            this.idtp_Start.ValueTimeSpan = null;
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
            this.in_DurationMinutes.Location = new System.Drawing.Point(175, 49);
            this.in_DurationMinutes.Margin = new System.Windows.Forms.Padding(4);
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
            this.in_DurationMinutes.ShowCheckbox = false;
            this.in_DurationMinutes.ShowTextboxOnly = false;
            this.in_DurationMinutes.Size = new System.Drawing.Size(70, 41);
            this.in_DurationMinutes.TabIndex = 0;
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
            this.gb_Template.Location = new System.Drawing.Point(4, 51);
            this.gb_Template.Name = "gb_Template";
            this.gb_Template.Padding = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.gb_Template.Size = new System.Drawing.Size(241, 42);
            this.gb_Template.TabIndex = 5;
            this.gb_Template.TabStop = false;
            this.gb_Template.Text = "TEMPLATES";
            // 
            // itxt_WorkshiftTemplate
            // 
            this.itxt_WorkshiftTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itxt_WorkshiftTemplate.IsBrowseMode = true;
            this.itxt_WorkshiftTemplate.LabelText = "Template";
            this.itxt_WorkshiftTemplate.Location = new System.Drawing.Point(5, 16);
            this.itxt_WorkshiftTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_WorkshiftTemplate.MaxLength = 32767;
            this.itxt_WorkshiftTemplate.MultiLine = false;
            this.itxt_WorkshiftTemplate.Name = "itxt_WorkshiftTemplate";
            this.itxt_WorkshiftTemplate.PasswordChar = '\0';
            this.itxt_WorkshiftTemplate.RowCount = 1;
            this.itxt_WorkshiftTemplate.ShowDeleteButton = true;
            this.itxt_WorkshiftTemplate.ShowTextboxOnly = true;
            this.itxt_WorkshiftTemplate.Size = new System.Drawing.Size(231, 21);
            this.itxt_WorkshiftTemplate.TabIndex = 8;
            this.itxt_WorkshiftTemplate.ValueText = "";
            this.itxt_WorkshiftTemplate.isBrowseMode_Clicked += new System.EventHandler(this.itxt_WorkshiftTemplate_isBrowseMode_Clicked);
            // 
            // itxt_UserAccounts
            // 
            this.itxt_UserAccounts.IsBrowseMode = true;
            this.itxt_UserAccounts.LabelText = "*Employee";
            this.itxt_UserAccounts.Location = new System.Drawing.Point(4, 91);
            this.itxt_UserAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_UserAccounts.MaxLength = 32767;
            this.itxt_UserAccounts.MultiLine = false;
            this.itxt_UserAccounts.Name = "itxt_UserAccounts";
            this.itxt_UserAccounts.PasswordChar = '\0';
            this.itxt_UserAccounts.RowCount = 1;
            this.itxt_UserAccounts.ShowDeleteButton = true;
            this.itxt_UserAccounts.ShowTextboxOnly = false;
            this.itxt_UserAccounts.Size = new System.Drawing.Size(241, 41);
            this.itxt_UserAccounts.TabIndex = 10;
            this.itxt_UserAccounts.ValueText = "";
            this.itxt_UserAccounts.isBrowseMode_Clicked += new System.EventHandler(this.itxt_UserAccounts_isBrowseMode_Clicked);
            // 
            // MasterData_v1_Workshifts_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 609);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MasterData_v1_Workshifts_Form";
            this.Text = "WORKSHIFTS";
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
    }
}