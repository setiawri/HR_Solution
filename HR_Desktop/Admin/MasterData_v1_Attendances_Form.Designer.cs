namespace HR_Desktop.Admin
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
            this.panel1.Size = new System.Drawing.Size(1028, 28);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // lnkClearQuickSearch
            // 
            this.lnkClearQuickSearch.Location = new System.Drawing.Point(183, 8);
            this.lnkClearQuickSearch.TabStop = false;
            // 
            // chkIncludeInactive
            // 
            this.chkIncludeInactive.Location = new System.Drawing.Point(202, 6);
            this.chkIncludeInactive.Margin = new System.Windows.Forms.Padding(4);
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Location = new System.Drawing.Point(0, 237);
            this.pnlActionButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActionButtons.Size = new System.Drawing.Size(1028, 23);
            // 
            // scInputLeft
            // 
            this.scInputLeft.Margin = new System.Windows.Forms.Padding(2);
            // 
            // scInputLeft.Panel1
            // 
            this.scInputLeft.Panel1.Controls.Add(this.iddl_AttendanceStatuses);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Workshift);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Client);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_UserAccount);
            // 
            // scInputLeft.Panel2
            // 
            this.scInputLeft.Panel2.Controls.Add(this.idtp_TimestampOut);
            this.scInputLeft.Panel2.Controls.Add(this.idtp_TimestampIn);
            this.scInputLeft.Panel2.Controls.Add(this.idtp_EffectiveTimestampOut);
            this.scInputLeft.Panel2.Controls.Add(this.idtp_EffectiveTimestampIn);
            this.scInputLeft.Panel2.Controls.Add(this.itxt_Notes);
            this.scInputLeft.Size = new System.Drawing.Size(500, 211);
            this.scInputLeft.SplitterDistance = 220;
            this.scInputLeft.SplitterWidth = 3;
            // 
            // scInputRight
            // 
            this.scInputRight.Margin = new System.Windows.Forms.Padding(4);
            this.scInputRight.Size = new System.Drawing.Size(523, 211);
            this.scInputRight.SplitterWidth = 3;
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
            this.btnSearch.Text = "FILTER";
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
            this.scMain.Margin = new System.Windows.Forms.Padding(4);
            this.scMain.Size = new System.Drawing.Size(1028, 609);
            this.scMain.SplitterDistance = 260;
            this.scMain.SplitterWidth = 8;
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Location = new System.Drawing.Point(79, 4);
            this.txtQuickSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuickSearch.TabStop = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Size = new System.Drawing.Size(1028, 26);
            // 
            // scInputContainer
            // 
            this.scInputContainer.Margin = new System.Windows.Forms.Padding(4);
            this.scInputContainer.Size = new System.Drawing.Size(1028, 211);
            this.scInputContainer.SplitterWidth = 5;
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
            this.pnlQuickSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pnlQuickSearch.Size = new System.Drawing.Size(998, 28);
            // 
            // itxt_Notes
            // 
            this.itxt_Notes.IsBrowseMode = false;
            this.itxt_Notes.LabelText = "Notes";
            this.itxt_Notes.Location = new System.Drawing.Point(2, 98);
            this.itxt_Notes.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Notes.MaxLength = 32767;
            this.itxt_Notes.MultiLine = true;
            this.itxt_Notes.Name = "itxt_Notes";
            this.itxt_Notes.PasswordChar = '\0';
            this.itxt_Notes.RowCount = 5;
            this.itxt_Notes.ShowDeleteButton = false;
            this.itxt_Notes.ShowTextboxOnly = false;
            this.itxt_Notes.Size = new System.Drawing.Size(273, 83);
            this.itxt_Notes.TabIndex = 4;
            this.itxt_Notes.TabStop = false;
            this.itxt_Notes.ValueText = "";
            // 
            // itxt_UserAccount
            // 
            this.itxt_UserAccount.IsBrowseMode = true;
            this.itxt_UserAccount.LabelText = "*Employee";
            this.itxt_UserAccount.Location = new System.Drawing.Point(4, 8);
            this.itxt_UserAccount.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_UserAccount.MaxLength = 32767;
            this.itxt_UserAccount.MultiLine = false;
            this.itxt_UserAccount.Name = "itxt_UserAccount";
            this.itxt_UserAccount.PasswordChar = '\0';
            this.itxt_UserAccount.RowCount = 1;
            this.itxt_UserAccount.ShowDeleteButton = true;
            this.itxt_UserAccount.ShowTextboxOnly = false;
            this.itxt_UserAccount.Size = new System.Drawing.Size(208, 41);
            this.itxt_UserAccount.TabIndex = 0;
            this.itxt_UserAccount.TabStop = false;
            this.itxt_UserAccount.ValueText = "";
            this.itxt_UserAccount.isBrowseMode_Clicked += new System.EventHandler(this.itxt_UserAccount_isBrowseMode_Clicked);
            // 
            // idtp_EffectiveTimestampOut
            // 
            this.idtp_EffectiveTimestampOut.Checked = false;
            this.idtp_EffectiveTimestampOut.CustomFormat = "dd/MM/yyyy HH:mm";
            this.idtp_EffectiveTimestampOut.DefaultCheckedValue = false;
            this.idtp_EffectiveTimestampOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_EffectiveTimestampOut.LabelText = "Effective OUT";
            this.idtp_EffectiveTimestampOut.Location = new System.Drawing.Point(142, 49);
            this.idtp_EffectiveTimestampOut.Margin = new System.Windows.Forms.Padding(4);
            this.idtp_EffectiveTimestampOut.Name = "idtp_EffectiveTimestampOut";
            this.idtp_EffectiveTimestampOut.ShowCheckBox = false;
            this.idtp_EffectiveTimestampOut.ShowUpAndDown = false;
            this.idtp_EffectiveTimestampOut.Size = new System.Drawing.Size(133, 41);
            this.idtp_EffectiveTimestampOut.TabIndex = 8;
            this.idtp_EffectiveTimestampOut.Value = null;
            this.idtp_EffectiveTimestampOut.ValueTimeSpan = null;
            // 
            // idtp_EffectiveTimestampIn
            // 
            this.idtp_EffectiveTimestampIn.Checked = false;
            this.idtp_EffectiveTimestampIn.CustomFormat = "dd/MM/yyyy HH:mm";
            this.idtp_EffectiveTimestampIn.DefaultCheckedValue = false;
            this.idtp_EffectiveTimestampIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_EffectiveTimestampIn.LabelText = "Effective IN";
            this.idtp_EffectiveTimestampIn.Location = new System.Drawing.Point(2, 49);
            this.idtp_EffectiveTimestampIn.Margin = new System.Windows.Forms.Padding(4);
            this.idtp_EffectiveTimestampIn.Name = "idtp_EffectiveTimestampIn";
            this.idtp_EffectiveTimestampIn.ShowCheckBox = false;
            this.idtp_EffectiveTimestampIn.ShowUpAndDown = false;
            this.idtp_EffectiveTimestampIn.Size = new System.Drawing.Size(133, 41);
            this.idtp_EffectiveTimestampIn.TabIndex = 7;
            this.idtp_EffectiveTimestampIn.Value = null;
            this.idtp_EffectiveTimestampIn.ValueTimeSpan = null;
            // 
            // idtp_TimestampOut
            // 
            this.idtp_TimestampOut.Checked = false;
            this.idtp_TimestampOut.CustomFormat = "dd/MM/yyyy HH:mm";
            this.idtp_TimestampOut.DefaultCheckedValue = false;
            this.idtp_TimestampOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_TimestampOut.LabelText = "OUT";
            this.idtp_TimestampOut.Location = new System.Drawing.Point(143, 5);
            this.idtp_TimestampOut.Margin = new System.Windows.Forms.Padding(4);
            this.idtp_TimestampOut.Name = "idtp_TimestampOut";
            this.idtp_TimestampOut.ShowCheckBox = false;
            this.idtp_TimestampOut.ShowUpAndDown = false;
            this.idtp_TimestampOut.Size = new System.Drawing.Size(133, 41);
            this.idtp_TimestampOut.TabIndex = 10;
            this.idtp_TimestampOut.Value = null;
            this.idtp_TimestampOut.ValueTimeSpan = null;
            this.idtp_TimestampOut.ValueChanged += new System.EventHandler(this.idtp_TimestampOut_ValueChanged);
            // 
            // idtp_TimestampIn
            // 
            this.idtp_TimestampIn.Checked = false;
            this.idtp_TimestampIn.CustomFormat = "dd/MM/yyyy HH:mm";
            this.idtp_TimestampIn.DefaultCheckedValue = false;
            this.idtp_TimestampIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_TimestampIn.LabelText = "IN";
            this.idtp_TimestampIn.Location = new System.Drawing.Point(2, 5);
            this.idtp_TimestampIn.Margin = new System.Windows.Forms.Padding(4);
            this.idtp_TimestampIn.Name = "idtp_TimestampIn";
            this.idtp_TimestampIn.ShowCheckBox = false;
            this.idtp_TimestampIn.ShowUpAndDown = false;
            this.idtp_TimestampIn.Size = new System.Drawing.Size(133, 41);
            this.idtp_TimestampIn.TabIndex = 9;
            this.idtp_TimestampIn.Value = null;
            this.idtp_TimestampIn.ValueTimeSpan = null;
            this.idtp_TimestampIn.ValueChanged += new System.EventHandler(this.idtp_TimestampIn_ValueChanged_1);
            // 
            // itxt_Client
            // 
            this.itxt_Client.IsBrowseMode = true;
            this.itxt_Client.LabelText = "*Client";
            this.itxt_Client.Location = new System.Drawing.Point(4, 52);
            this.itxt_Client.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Client.MaxLength = 32767;
            this.itxt_Client.MultiLine = false;
            this.itxt_Client.Name = "itxt_Client";
            this.itxt_Client.PasswordChar = '\0';
            this.itxt_Client.RowCount = 1;
            this.itxt_Client.ShowDeleteButton = true;
            this.itxt_Client.ShowTextboxOnly = false;
            this.itxt_Client.Size = new System.Drawing.Size(208, 41);
            this.itxt_Client.TabIndex = 1;
            this.itxt_Client.ValueText = "";
            this.itxt_Client.isBrowseMode_Clicked += new System.EventHandler(this.itxt_Client_isBrowseMode_Clicked);
            // 
            // itxt_Workshift
            // 
            this.itxt_Workshift.IsBrowseMode = true;
            this.itxt_Workshift.LabelText = "Workshift";
            this.itxt_Workshift.Location = new System.Drawing.Point(4, 97);
            this.itxt_Workshift.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Workshift.MaxLength = 32767;
            this.itxt_Workshift.MultiLine = false;
            this.itxt_Workshift.Name = "itxt_Workshift";
            this.itxt_Workshift.PasswordChar = '\0';
            this.itxt_Workshift.RowCount = 1;
            this.itxt_Workshift.ShowDeleteButton = true;
            this.itxt_Workshift.ShowTextboxOnly = false;
            this.itxt_Workshift.Size = new System.Drawing.Size(208, 41);
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
            this.iddl_AttendanceStatuses.Location = new System.Drawing.Point(4, 141);
            this.iddl_AttendanceStatuses.Margin = new System.Windows.Forms.Padding(4);
            this.iddl_AttendanceStatuses.Name = "iddl_AttendanceStatuses";
            this.iddl_AttendanceStatuses.SelectedItem = null;
            this.iddl_AttendanceStatuses.SelectedItemText = "";
            this.iddl_AttendanceStatuses.SelectedValue = null;
            this.iddl_AttendanceStatuses.ShowDropdownlistOnly = false;
            this.iddl_AttendanceStatuses.Size = new System.Drawing.Size(205, 41);
            this.iddl_AttendanceStatuses.TabIndex = 3;
            // 
            // MasterData_v1_Attendances_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MasterData_v1_Attendances_Form";
            this.Text = "ATTENDANCE";
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
    }
}