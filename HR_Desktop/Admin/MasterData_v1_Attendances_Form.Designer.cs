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
            this.idtp_TimestampIn = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.idtp_TimestampOut = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(685, 34);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // lnkClearQuickSearch
            // 
            this.lnkClearQuickSearch.Location = new System.Drawing.Point(244, 10);
            // 
            // chkIncludeInactive
            // 
            this.chkIncludeInactive.Location = new System.Drawing.Point(269, 7);
            this.chkIncludeInactive.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Location = new System.Drawing.Point(0, 152);
            this.pnlActionButtons.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlActionButtons.Size = new System.Drawing.Size(685, 28);
            // 
            // scInputLeft
            // 
            this.scInputLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // scInputLeft.Panel1
            // 
            this.scInputLeft.Panel1.Controls.Add(this.idtp_TimestampOut);
            this.scInputLeft.Panel1.Controls.Add(this.idtp_TimestampIn);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_UserAccount);
            // 
            // scInputLeft.Panel2
            // 
            this.scInputLeft.Panel2.Controls.Add(this.itxt_Notes);
            this.scInputLeft.Size = new System.Drawing.Size(500, 120);
            this.scInputLeft.SplitterWidth = 4;
            // 
            // scInputRight
            // 
            this.scInputRight.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.scInputRight.Size = new System.Drawing.Size(178, 120);
            this.scInputRight.SplitterWidth = 7;
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
            this.scMain.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.scMain.Size = new System.Drawing.Size(685, 750);
            this.scMain.SplitterDistance = 180;
            this.scMain.SplitterWidth = 6;
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Location = new System.Drawing.Point(105, 5);
            this.txtQuickSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtQuickSearch.TabStop = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlButtons.Size = new System.Drawing.Size(685, 32);
            // 
            // scInputContainer
            // 
            this.scInputContainer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.scInputContainer.Size = new System.Drawing.Size(685, 120);
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
            this.pnlQuickSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlQuickSearch.Size = new System.Drawing.Size(645, 34);
            // 
            // itxt_Notes
            // 
            this.itxt_Notes.IsBrowseMode = false;
            this.itxt_Notes.LabelText = "Notes";
            this.itxt_Notes.Location = new System.Drawing.Point(4, 5);
            this.itxt_Notes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.itxt_Notes.MaxLength = 32767;
            this.itxt_Notes.MultiLine = true;
            this.itxt_Notes.Name = "itxt_Notes";
            this.itxt_Notes.PasswordChar = '\0';
            this.itxt_Notes.RowCount = 5;
            this.itxt_Notes.ShowDeleteButton = false;
            this.itxt_Notes.ShowTextboxOnly = false;
            this.itxt_Notes.Size = new System.Drawing.Size(323, 122);
            this.itxt_Notes.TabIndex = 4;
            this.itxt_Notes.TabStop = false;
            this.itxt_Notes.ValueText = "";
            // 
            // itxt_UserAccount
            // 
            this.itxt_UserAccount.IsBrowseMode = true;
            this.itxt_UserAccount.LabelText = "*User";
            this.itxt_UserAccount.Location = new System.Drawing.Point(5, 10);
            this.itxt_UserAccount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.itxt_UserAccount.MaxLength = 32767;
            this.itxt_UserAccount.MultiLine = false;
            this.itxt_UserAccount.Name = "itxt_UserAccount";
            this.itxt_UserAccount.PasswordChar = '\0';
            this.itxt_UserAccount.RowCount = 1;
            this.itxt_UserAccount.ShowDeleteButton = true;
            this.itxt_UserAccount.ShowTextboxOnly = false;
            this.itxt_UserAccount.Size = new System.Drawing.Size(323, 50);
            this.itxt_UserAccount.TabIndex = 0;
            this.itxt_UserAccount.TabStop = false;
            this.itxt_UserAccount.ValueText = "";
            this.itxt_UserAccount.isBrowseMode_Clicked += new System.EventHandler(this.itxt_UserAccount_isBrowseMode_Clicked);
            // 
            // idtp_TimestampIn
            // 
            this.idtp_TimestampIn.Checked = false;
            this.idtp_TimestampIn.CustomFormat = "dd/MM/yyyy HH:mm";
            this.idtp_TimestampIn.DefaultCheckedValue = false;
            this.idtp_TimestampIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_TimestampIn.LabelText = "IN";
            this.idtp_TimestampIn.Location = new System.Drawing.Point(4, 60);
            this.idtp_TimestampIn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.idtp_TimestampIn.Name = "idtp_TimestampIn";
            this.idtp_TimestampIn.ShowCheckBox = false;
            this.idtp_TimestampIn.ShowUpAndDown = true;
            this.idtp_TimestampIn.Size = new System.Drawing.Size(160, 50);
            this.idtp_TimestampIn.TabIndex = 1;
            this.idtp_TimestampIn.Value = null;
            this.idtp_TimestampIn.ValueTimeSpan = null;
            this.idtp_TimestampIn.ValueChanged += new System.EventHandler(this.idtp_TimestampIn_ValueChanged);
            // 
            // idtp_TimestampOut
            // 
            this.idtp_TimestampOut.Checked = false;
            this.idtp_TimestampOut.CustomFormat = "dd/MM/yyyy HH:mm";
            this.idtp_TimestampOut.DefaultCheckedValue = false;
            this.idtp_TimestampOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idtp_TimestampOut.LabelText = "OUT";
            this.idtp_TimestampOut.Location = new System.Drawing.Point(168, 60);
            this.idtp_TimestampOut.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.idtp_TimestampOut.Name = "idtp_TimestampOut";
            this.idtp_TimestampOut.ShowCheckBox = false;
            this.idtp_TimestampOut.ShowUpAndDown = true;
            this.idtp_TimestampOut.Size = new System.Drawing.Size(160, 50);
            this.idtp_TimestampOut.TabIndex = 2;
            this.idtp_TimestampOut.Value = null;
            this.idtp_TimestampOut.ValueTimeSpan = null;
            // 
            // MasterData_v1_Attendances_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 750);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MasterData_v1_Attendances_Form";
            this.Text = "Attendances";
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
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_TimestampOut;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_TimestampIn;
    }
}