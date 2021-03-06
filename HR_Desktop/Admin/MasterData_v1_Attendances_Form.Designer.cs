﻿namespace HR_Desktop.Admin
{
    partial class MasterData_v1_Attendances_Form
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
            this.itxt_UserAccount = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.idtp_EffectiveTimestampOut = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.idtp_EffectiveTimestampIn = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.idtp_TimestampOut = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.idtp_TimestampIn = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.itxt_Client = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Workshift = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.iddl_AttendanceStatuses = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
            this.itxt_ReplacementAttendance = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1552, 34);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // lnkClearQuickSearch
            // 
            this.lnkClearQuickSearch.Location = new System.Drawing.Point(244, 10);
            this.lnkClearQuickSearch.TabStop = false;
            // 
            // chkIncludeInactive
            // 
            this.chkIncludeInactive.Location = new System.Drawing.Point(269, 7);
            this.chkIncludeInactive.Margin = new System.Windows.Forms.Padding(5);
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Location = new System.Drawing.Point(0, 252);
            this.pnlActionButtons.Margin = new System.Windows.Forms.Padding(5);
            this.pnlActionButtons.Size = new System.Drawing.Size(1552, 28);
            // 
            // scInputLeft
            // 
            this.scInputLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // scInputLeft.Panel1
            // 
            this.scInputLeft.Panel1.Controls.Add(this.iddl_AttendanceStatuses);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Workshift);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Client);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_UserAccount);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_ReplacementAttendance);
            // 
            // scInputLeft.Panel2
            // 
            this.scInputLeft.Panel2.Controls.Add(this.idtp_TimestampOut);
            this.scInputLeft.Panel2.Controls.Add(this.idtp_TimestampIn);
            this.scInputLeft.Panel2.Controls.Add(this.idtp_EffectiveTimestampOut);
            this.scInputLeft.Panel2.Controls.Add(this.idtp_EffectiveTimestampIn);
            this.scInputLeft.Panel2.Controls.Add(this.itxt_Notes);
            this.scInputLeft.Size = new System.Drawing.Size(500, 220);
            this.scInputLeft.SplitterDistance = 220;
            this.scInputLeft.SplitterWidth = 4;
            // 
            // scInputRight
            // 
            this.scInputRight.Margin = new System.Windows.Forms.Padding(5);
            this.scInputRight.Size = new System.Drawing.Size(1045, 220);
            this.scInputRight.SplitterWidth = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.TabStop = false;
            // 
            // scMain
            // 
            this.scMain.Margin = new System.Windows.Forms.Padding(5);
            this.scMain.Size = new System.Drawing.Size(1552, 750);
            this.scMain.SplitterDistance = 280;
            this.scMain.SplitterWidth = 10;
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Location = new System.Drawing.Point(105, 5);
            this.txtQuickSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtQuickSearch.TabStop = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(5);
            this.pnlButtons.Size = new System.Drawing.Size(1552, 32);
            // 
            // scInputContainer
            // 
            this.scInputContainer.Margin = new System.Windows.Forms.Padding(5);
            this.scInputContainer.Size = new System.Drawing.Size(1552, 220);
            this.scInputContainer.SplitterWidth = 7;
            // 
            // btnLog
            // 
            this.btnLog.TabStop = false;
            // 
            // ptInputPanel
            // 
            this.ptInputPanel.TabStop = false;
            // 
            // pnlQuickSearch
            // 
            this.pnlQuickSearch.Margin = new System.Windows.Forms.Padding(5);
            this.pnlQuickSearch.Size = new System.Drawing.Size(1512, 34);
            // 
            // itxt_Notes
            // 
            this.itxt_Notes.IsBrowseMode = false;
            this.itxt_Notes.LabelText = "Notes";
            this.itxt_Notes.Location = new System.Drawing.Point(3, 121);
            this.itxt_Notes.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Notes.MaxLength = 32767;
            this.itxt_Notes.MultiLine = true;
            this.itxt_Notes.Name = "itxt_Notes";
            this.itxt_Notes.PasswordChar = '\0';
            this.itxt_Notes.RowCount = 5;
            this.itxt_Notes.ShowDeleteButton = false;
            this.itxt_Notes.ShowTextboxOnly = false;
            this.itxt_Notes.Size = new System.Drawing.Size(364, 102);
            this.itxt_Notes.TabIndex = 4;
            this.itxt_Notes.TabStop = false;
            this.itxt_Notes.ValueText = "";
            // 
            // itxt_UserAccount
            // 
            this.itxt_UserAccount.IsBrowseMode = true;
            this.itxt_UserAccount.LabelText = "*Employee";
            this.itxt_UserAccount.Location = new System.Drawing.Point(5, 10);
            this.itxt_UserAccount.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_UserAccount.MaxLength = 32767;
            this.itxt_UserAccount.MultiLine = false;
            this.itxt_UserAccount.Name = "itxt_UserAccount";
            this.itxt_UserAccount.PasswordChar = '\0';
            this.itxt_UserAccount.RowCount = 1;
            this.itxt_UserAccount.ShowDeleteButton = true;
            this.itxt_UserAccount.ShowTextboxOnly = false;
            this.itxt_UserAccount.Size = new System.Drawing.Size(277, 50);
            this.itxt_UserAccount.TabIndex = 0;
            this.itxt_UserAccount.TabStop = false;
            this.itxt_UserAccount.ValueText = "";
            this.itxt_UserAccount.isBrowseMode_Clicked += new System.EventHandler(this.itxt_UserAccount_isBrowseMode_Clicked);
            // 
            // idtp_EffectiveTimestampOut
            // 
            this.idtp_EffectiveTimestampOut.Checked = true;
            this.idtp_EffectiveTimestampOut.CustomFormat = "dd/MM/yyyy HH:mm";
            this.idtp_EffectiveTimestampOut.DefaultCheckedValue = false;
            this.idtp_EffectiveTimestampOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_EffectiveTimestampOut.LabelText = "Effective OUT";
            this.idtp_EffectiveTimestampOut.Location = new System.Drawing.Point(189, 60);
            this.idtp_EffectiveTimestampOut.Margin = new System.Windows.Forms.Padding(5);
            this.idtp_EffectiveTimestampOut.Name = "idtp_EffectiveTimestampOut";
            this.idtp_EffectiveTimestampOut.ShowCheckBox = false;
            this.idtp_EffectiveTimestampOut.ShowUpAndDown = false;
            this.idtp_EffectiveTimestampOut.Size = new System.Drawing.Size(177, 50);
            this.idtp_EffectiveTimestampOut.TabIndex = 8;
            this.idtp_EffectiveTimestampOut.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.idtp_EffectiveTimestampOut.ValueTimeSpan = System.TimeSpan.Parse("00:00:00");
            // 
            // idtp_EffectiveTimestampIn
            // 
            this.idtp_EffectiveTimestampIn.Checked = true;
            this.idtp_EffectiveTimestampIn.CustomFormat = "dd/MM/yyyy HH:mm";
            this.idtp_EffectiveTimestampIn.DefaultCheckedValue = false;
            this.idtp_EffectiveTimestampIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_EffectiveTimestampIn.LabelText = "Effective IN";
            this.idtp_EffectiveTimestampIn.Location = new System.Drawing.Point(3, 60);
            this.idtp_EffectiveTimestampIn.Margin = new System.Windows.Forms.Padding(5);
            this.idtp_EffectiveTimestampIn.Name = "idtp_EffectiveTimestampIn";
            this.idtp_EffectiveTimestampIn.ShowCheckBox = false;
            this.idtp_EffectiveTimestampIn.ShowUpAndDown = false;
            this.idtp_EffectiveTimestampIn.Size = new System.Drawing.Size(177, 50);
            this.idtp_EffectiveTimestampIn.TabIndex = 7;
            this.idtp_EffectiveTimestampIn.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.idtp_EffectiveTimestampIn.ValueTimeSpan = System.TimeSpan.Parse("00:00:00");
            // 
            // idtp_TimestampOut
            // 
            this.idtp_TimestampOut.Checked = true;
            this.idtp_TimestampOut.CustomFormat = "dd/MM/yyyy HH:mm";
            this.idtp_TimestampOut.DefaultCheckedValue = false;
            this.idtp_TimestampOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_TimestampOut.LabelText = "OUT";
            this.idtp_TimestampOut.Location = new System.Drawing.Point(191, 6);
            this.idtp_TimestampOut.Margin = new System.Windows.Forms.Padding(5);
            this.idtp_TimestampOut.Name = "idtp_TimestampOut";
            this.idtp_TimestampOut.ShowCheckBox = false;
            this.idtp_TimestampOut.ShowUpAndDown = false;
            this.idtp_TimestampOut.Size = new System.Drawing.Size(177, 50);
            this.idtp_TimestampOut.TabIndex = 10;
            this.idtp_TimestampOut.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.idtp_TimestampOut.ValueTimeSpan = System.TimeSpan.Parse("00:00:00");
            this.idtp_TimestampOut.ValueChanged += new System.EventHandler(this.idtp_TimestampOut_ValueChanged);
            // 
            // idtp_TimestampIn
            // 
            this.idtp_TimestampIn.Checked = true;
            this.idtp_TimestampIn.CustomFormat = "dd/MM/yyyy HH:mm";
            this.idtp_TimestampIn.DefaultCheckedValue = false;
            this.idtp_TimestampIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_TimestampIn.LabelText = "IN";
            this.idtp_TimestampIn.Location = new System.Drawing.Point(3, 6);
            this.idtp_TimestampIn.Margin = new System.Windows.Forms.Padding(5);
            this.idtp_TimestampIn.Name = "idtp_TimestampIn";
            this.idtp_TimestampIn.ShowCheckBox = false;
            this.idtp_TimestampIn.ShowUpAndDown = false;
            this.idtp_TimestampIn.Size = new System.Drawing.Size(177, 50);
            this.idtp_TimestampIn.TabIndex = 9;
            this.idtp_TimestampIn.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.idtp_TimestampIn.ValueTimeSpan = System.TimeSpan.Parse("00:00:00");
            this.idtp_TimestampIn.ValueChanged += new System.EventHandler(this.idtp_TimestampIn_ValueChanged_1);
            // 
            // itxt_Client
            // 
            this.itxt_Client.IsBrowseMode = true;
            this.itxt_Client.LabelText = "*Client";
            this.itxt_Client.Location = new System.Drawing.Point(5, 60);
            this.itxt_Client.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Client.MaxLength = 32767;
            this.itxt_Client.MultiLine = false;
            this.itxt_Client.Name = "itxt_Client";
            this.itxt_Client.PasswordChar = '\0';
            this.itxt_Client.RowCount = 1;
            this.itxt_Client.ShowDeleteButton = true;
            this.itxt_Client.ShowTextboxOnly = false;
            this.itxt_Client.Size = new System.Drawing.Size(277, 50);
            this.itxt_Client.TabIndex = 1;
            this.itxt_Client.ValueText = "";
            this.itxt_Client.isBrowseMode_Clicked += new System.EventHandler(this.itxt_Client_isBrowseMode_Clicked);
            // 
            // itxt_Workshift
            // 
            this.itxt_Workshift.IsBrowseMode = true;
            this.itxt_Workshift.LabelText = "*Workshift";
            this.itxt_Workshift.Location = new System.Drawing.Point(5, 111);
            this.itxt_Workshift.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Workshift.MaxLength = 32767;
            this.itxt_Workshift.MultiLine = false;
            this.itxt_Workshift.Name = "itxt_Workshift";
            this.itxt_Workshift.PasswordChar = '\0';
            this.itxt_Workshift.RowCount = 1;
            this.itxt_Workshift.ShowDeleteButton = true;
            this.itxt_Workshift.ShowTextboxOnly = false;
            this.itxt_Workshift.Size = new System.Drawing.Size(277, 50);
            this.itxt_Workshift.TabIndex = 2;
            this.itxt_Workshift.ValueText = "";
            this.itxt_Workshift.isBrowseMode_Clicked += new System.EventHandler(this.itxt_Workshift_isBrowseMode_Clicked);
            // 
            // iddl_AttendanceStatuses
            // 
            this.iddl_AttendanceStatuses.DisableTextInput = false;
            this.iddl_AttendanceStatuses.HideFilter = true;
            this.iddl_AttendanceStatuses.HideUpdateLink = true;
            this.iddl_AttendanceStatuses.LabelText = "*Status";
            this.iddl_AttendanceStatuses.Location = new System.Drawing.Point(5, 161);
            this.iddl_AttendanceStatuses.Margin = new System.Windows.Forms.Padding(5);
            this.iddl_AttendanceStatuses.Name = "iddl_AttendanceStatuses";
            this.iddl_AttendanceStatuses.SelectedIndex = -1;
            this.iddl_AttendanceStatuses.SelectedItem = null;
            this.iddl_AttendanceStatuses.SelectedItemText = "";
            this.iddl_AttendanceStatuses.SelectedValue = null;
            this.iddl_AttendanceStatuses.ShowDropdownlistOnly = false;
            this.iddl_AttendanceStatuses.Size = new System.Drawing.Size(273, 50);
            this.iddl_AttendanceStatuses.TabIndex = 3;
            this.iddl_AttendanceStatuses.SelectedIndexChanged += new System.EventHandler(this.iddl_AttendanceStatuses_SelectedIndexChanged);
            // 
            // itxt_ReplacementAttendance
            // 
            this.itxt_ReplacementAttendance.IsBrowseMode = true;
            this.itxt_ReplacementAttendance.LabelText = "Replacement Attendance";
            this.itxt_ReplacementAttendance.Location = new System.Drawing.Point(5, 216);
            this.itxt_ReplacementAttendance.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_ReplacementAttendance.MaxLength = 32767;
            this.itxt_ReplacementAttendance.MultiLine = false;
            this.itxt_ReplacementAttendance.Name = "itxt_ReplacementAttendance";
            this.itxt_ReplacementAttendance.PasswordChar = '\0';
            this.itxt_ReplacementAttendance.RowCount = 1;
            this.itxt_ReplacementAttendance.ShowDeleteButton = true;
            this.itxt_ReplacementAttendance.ShowTextboxOnly = false;
            this.itxt_ReplacementAttendance.Size = new System.Drawing.Size(277, 50);
            this.itxt_ReplacementAttendance.TabIndex = 4;
            this.itxt_ReplacementAttendance.ValueText = "";
            this.itxt_ReplacementAttendance.Visible = false;
            this.itxt_ReplacementAttendance.isBrowseMode_Clicked += new System.EventHandler(this.itxt_ReplacementAttendance_isBrowseMode_Clicked);
            // 
            // MasterData_v1_Attendances_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 750);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MasterData_v1_Attendances_Form";
            this.Text = "ATTENDANCE";
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
            this.ResumeLayout(false);

        }

        #endregion
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_UserAccount;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Notes;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_EffectiveTimestampOut;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_EffectiveTimestampIn;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_TimestampOut;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_TimestampIn;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Client;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Workshift;
        private LIBUtil.Desktop.UserControls.InputControl_Dropdownlist iddl_AttendanceStatuses;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_ReplacementAttendance;
    }
}