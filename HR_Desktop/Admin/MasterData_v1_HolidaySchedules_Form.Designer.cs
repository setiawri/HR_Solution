namespace HR_Desktop.Admin
{
    partial class MasterData_v1_HolidaySchedules_Form
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
            this.itxt_Notes = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.idtp_StartDate = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.itxt_DurationDays = new LIBUtil.Desktop.UserControls.InputControl_Numeric();
            this.itxt_Description = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Clients = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
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
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(514, 28);
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Location = new System.Drawing.Point(0, 237);
            this.pnlActionButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActionButtons.Size = new System.Drawing.Size(514, 23);
            // 
            // scInputLeft
            // 
            this.scInputLeft.Margin = new System.Windows.Forms.Padding(2);
            // 
            // scInputLeft.Panel1
            // 
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Clients);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_DurationDays);
            this.scInputLeft.Panel1.Controls.Add(this.idtp_StartDate);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Description);
            // 
            // scInputLeft.Panel2
            // 
            this.scInputLeft.Panel2.Controls.Add(this.itxt_Notes);
            this.scInputLeft.Size = new System.Drawing.Size(500, 211);
            this.scInputLeft.SplitterWidth = 3;
            // 
            // scInputRight
            // 
            this.scInputRight.Margin = new System.Windows.Forms.Padding(4);
            this.scInputRight.Size = new System.Drawing.Size(25, 211);
            this.scInputRight.SplitterWidth = 5;
            // 
            // scMain
            // 
            this.scMain.Margin = new System.Windows.Forms.Padding(4);
            this.scMain.Size = new System.Drawing.Size(514, 609);
            this.scMain.SplitterDistance = 260;
            this.scMain.SplitterWidth = 5;
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Margin = new System.Windows.Forms.Padding(4);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Size = new System.Drawing.Size(514, 26);
            // 
            // scInputContainer
            // 
            this.scInputContainer.Margin = new System.Windows.Forms.Padding(4);
            this.scInputContainer.Size = new System.Drawing.Size(514, 211);
            this.scInputContainer.SplitterWidth = 5;
            // 
            // btnLog
            // 
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // pnlQuickSearch
            // 
            this.pnlQuickSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pnlQuickSearch.Size = new System.Drawing.Size(484, 28);
            // 
            // itxt_Notes
            // 
            this.itxt_Notes.IsBrowseMode = false;
            this.itxt_Notes.LabelText = "Notes";
            this.itxt_Notes.Location = new System.Drawing.Point(3, 7);
            this.itxt_Notes.MaxLength = 32767;
            this.itxt_Notes.MultiLine = true;
            this.itxt_Notes.Name = "itxt_Notes";
            this.itxt_Notes.PasswordChar = '\0';
            this.itxt_Notes.RowCount = 3;
            this.itxt_Notes.ShowDeleteButton = false;
            this.itxt_Notes.ShowTextboxOnly = false;
            this.itxt_Notes.Size = new System.Drawing.Size(232, 71);
            this.itxt_Notes.TabIndex = 4;
            this.itxt_Notes.ValueText = "";
            // 
            // idtp_StartDate
            // 
            this.idtp_StartDate.Checked = false;
            this.idtp_StartDate.CustomFormat = "";
            this.idtp_StartDate.DefaultCheckedValue = false;
            this.idtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.idtp_StartDate.LabelText = "*Date";
            this.idtp_StartDate.Location = new System.Drawing.Point(4, 49);
            this.idtp_StartDate.Name = "idtp_StartDate";
            this.idtp_StartDate.ShowCheckBox = false;
            this.idtp_StartDate.ShowUpAndDown = false;
            this.idtp_StartDate.Size = new System.Drawing.Size(241, 41);
            this.idtp_StartDate.TabIndex = 11;
            this.idtp_StartDate.Value = null;
            this.idtp_StartDate.ValueTimeSpan = null;
            // 
            // itxt_DurationDays
            // 
            this.itxt_DurationDays.Checked = false;
            this.itxt_DurationDays.DecimalPlaces = 0;
            this.itxt_DurationDays.HideUpDown = false;
            this.itxt_DurationDays.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itxt_DurationDays.LabelText = "Duration (Days)";
            this.itxt_DurationDays.Location = new System.Drawing.Point(4, 90);
            this.itxt_DurationDays.MaximumValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.itxt_DurationDays.MinimumValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.itxt_DurationDays.Name = "itxt_DurationDays";
            this.itxt_DurationDays.ShowCheckbox = false;
            this.itxt_DurationDays.ShowTextboxOnly = false;
            this.itxt_DurationDays.Size = new System.Drawing.Size(241, 41);
            this.itxt_DurationDays.TabIndex = 12;
            this.itxt_DurationDays.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // itxt_Description
            // 
            this.itxt_Description.IsBrowseMode = false;
            this.itxt_Description.LabelText = "*Description";
            this.itxt_Description.Location = new System.Drawing.Point(4, 131);
            this.itxt_Description.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Description.MaxLength = 32767;
            this.itxt_Description.MultiLine = true;
            this.itxt_Description.Name = "itxt_Description";
            this.itxt_Description.PasswordChar = '\0';
            this.itxt_Description.RowCount = 3;
            this.itxt_Description.ShowDeleteButton = false;
            this.itxt_Description.ShowTextboxOnly = false;
            this.itxt_Description.Size = new System.Drawing.Size(241, 71);
            this.itxt_Description.TabIndex = 8;
            this.itxt_Description.ValueText = "";
            // 
            // itxt_Clients
            // 
            this.itxt_Clients.IsBrowseMode = true;
            this.itxt_Clients.LabelText = "*Clients";
            this.itxt_Clients.Location = new System.Drawing.Point(4, 8);
            this.itxt_Clients.MaxLength = 32767;
            this.itxt_Clients.MultiLine = false;
            this.itxt_Clients.Name = "itxt_Clients";
            this.itxt_Clients.PasswordChar = '\0';
            this.itxt_Clients.RowCount = 1;
            this.itxt_Clients.ShowDeleteButton = true;
            this.itxt_Clients.ShowTextboxOnly = false;
            this.itxt_Clients.Size = new System.Drawing.Size(241, 41);
            this.itxt_Clients.TabIndex = 13;
            this.itxt_Clients.ValueText = "";
            this.itxt_Clients.isBrowseMode_Clicked += new System.EventHandler(this.itxt_Clients_isBrowseMode_Clicked);
            // 
            // MasterData_v1_HolidaySchedules_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 609);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MasterData_v1_HolidaySchedules_Form";
            this.Text = "HOLIDAYS";
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
            this.ResumeLayout(false);

        }

        #endregion
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Notes;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_StartDate;
        private LIBUtil.Desktop.UserControls.InputControl_Numeric itxt_DurationDays;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Description;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Clients;
    }
}