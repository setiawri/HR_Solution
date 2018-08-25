namespace HR_Desktop.Admin
{
    partial class MasterData_v1_BankAccounts_Form
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
            this.itxt_BankName = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Name = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_AccountNumber = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Owner_Ref = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.rbUserAccount = new System.Windows.Forms.RadioButton();
            this.rbClient = new System.Windows.Forms.RadioButton();
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
            this.panel1.Size = new System.Drawing.Size(660, 28);
            // 
            // lnkClearQuickSearch
            // 
            this.lnkClearQuickSearch.TabStop = false;
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActionButtons.Size = new System.Drawing.Size(660, 23);
            // 
            // scInputLeft
            // 
            this.scInputLeft.Margin = new System.Windows.Forms.Padding(2);
            // 
            // scInputLeft.Panel1
            // 
            this.scInputLeft.Panel1.Controls.Add(this.rbUserAccount);
            this.scInputLeft.Panel1.Controls.Add(this.rbClient);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_BankName);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Name);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Owner_Ref);
            // 
            // scInputLeft.Panel2
            // 
            this.scInputLeft.Panel2.Controls.Add(this.itxt_Notes);
            this.scInputLeft.Panel2.Controls.Add(this.itxt_AccountNumber);
            this.scInputLeft.SplitterWidth = 2;
            // 
            // scInputRight
            // 
            this.scInputRight.Margin = new System.Windows.Forms.Padding(4);
            this.scInputRight.Size = new System.Drawing.Size(155, 271);
            this.scInputRight.SplitterWidth = 5;
            // 
            // scMain
            // 
            this.scMain.Margin = new System.Windows.Forms.Padding(4);
            this.scMain.Size = new System.Drawing.Size(660, 609);
            this.scMain.SplitterWidth = 5;
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Margin = new System.Windows.Forms.Padding(4);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Size = new System.Drawing.Size(660, 26);
            // 
            // scInputContainer
            // 
            this.scInputContainer.Margin = new System.Windows.Forms.Padding(4);
            this.scInputContainer.Size = new System.Drawing.Size(660, 271);
            this.scInputContainer.SplitterWidth = 5;
            // 
            // btnLog
            // 
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // pnlQuickSearch
            // 
            this.pnlQuickSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pnlQuickSearch.Size = new System.Drawing.Size(630, 28);
            // 
            // itxt_Notes
            // 
            this.itxt_Notes.IsBrowseMode = false;
            this.itxt_Notes.LabelText = "Notes";
            this.itxt_Notes.Location = new System.Drawing.Point(4, 47);
            this.itxt_Notes.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Notes.MaxLength = 32767;
            this.itxt_Notes.MultiLine = true;
            this.itxt_Notes.Name = "itxt_Notes";
            this.itxt_Notes.PasswordChar = '\0';
            this.itxt_Notes.RowCount = 3;
            this.itxt_Notes.ShowDeleteButton = false;
            this.itxt_Notes.ShowTextboxOnly = false;
            this.itxt_Notes.Size = new System.Drawing.Size(241, 71);
            this.itxt_Notes.TabIndex = 4;
            this.itxt_Notes.ValueText = "";
            // 
            // itxt_BankName
            // 
            this.itxt_BankName.IsBrowseMode = false;
            this.itxt_BankName.LabelText = "Bank";
            this.itxt_BankName.Location = new System.Drawing.Point(4, 88);
            this.itxt_BankName.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_BankName.MaxLength = 32767;
            this.itxt_BankName.MultiLine = false;
            this.itxt_BankName.Name = "itxt_BankName";
            this.itxt_BankName.PasswordChar = '\0';
            this.itxt_BankName.RowCount = 1;
            this.itxt_BankName.ShowDeleteButton = false;
            this.itxt_BankName.ShowTextboxOnly = false;
            this.itxt_BankName.Size = new System.Drawing.Size(241, 41);
            this.itxt_BankName.TabIndex = 8;
            this.itxt_BankName.ValueText = "";
            // 
            // itxt_Name
            // 
            this.itxt_Name.IsBrowseMode = false;
            this.itxt_Name.LabelText = "Name";
            this.itxt_Name.Location = new System.Drawing.Point(4, 6);
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
            // itxt_AccountNumber
            // 
            this.itxt_AccountNumber.IsBrowseMode = false;
            this.itxt_AccountNumber.LabelText = "*Account";
            this.itxt_AccountNumber.Location = new System.Drawing.Point(4, 6);
            this.itxt_AccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_AccountNumber.MaxLength = 32767;
            this.itxt_AccountNumber.MultiLine = false;
            this.itxt_AccountNumber.Name = "itxt_AccountNumber";
            this.itxt_AccountNumber.PasswordChar = '\0';
            this.itxt_AccountNumber.RowCount = 1;
            this.itxt_AccountNumber.ShowDeleteButton = false;
            this.itxt_AccountNumber.ShowTextboxOnly = false;
            this.itxt_AccountNumber.Size = new System.Drawing.Size(241, 41);
            this.itxt_AccountNumber.TabIndex = 10;
            this.itxt_AccountNumber.ValueText = "";
            // 
            // itxt_Owner_Ref
            // 
            this.itxt_Owner_Ref.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.itxt_Owner_Ref.IsBrowseMode = true;
            this.itxt_Owner_Ref.LabelText = "*Owner";
            this.itxt_Owner_Ref.Location = new System.Drawing.Point(4, 47);
            this.itxt_Owner_Ref.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Owner_Ref.MaxLength = 32767;
            this.itxt_Owner_Ref.MultiLine = false;
            this.itxt_Owner_Ref.Name = "itxt_Owner_Ref";
            this.itxt_Owner_Ref.PasswordChar = '\0';
            this.itxt_Owner_Ref.RowCount = 1;
            this.itxt_Owner_Ref.ShowDeleteButton = false;
            this.itxt_Owner_Ref.ShowTextboxOnly = false;
            this.itxt_Owner_Ref.Size = new System.Drawing.Size(241, 41);
            this.itxt_Owner_Ref.TabIndex = 7;
            this.itxt_Owner_Ref.ValueText = "";
            this.itxt_Owner_Ref.isBrowseMode_Clicked += new System.EventHandler(this.itxt_Owner_Ref_isBrowseMode_Clicked);
            // 
            // rbUserAccount
            // 
            this.rbUserAccount.AutoSize = true;
            this.rbUserAccount.Location = new System.Drawing.Point(110, 50);
            this.rbUserAccount.Margin = new System.Windows.Forms.Padding(2);
            this.rbUserAccount.Name = "rbUserAccount";
            this.rbUserAccount.Size = new System.Drawing.Size(71, 17);
            this.rbUserAccount.TabIndex = 11;
            this.rbUserAccount.TabStop = true;
            this.rbUserAccount.Text = "Employee";
            this.rbUserAccount.UseVisualStyleBackColor = true;
            this.rbUserAccount.CheckedChanged += new System.EventHandler(this.rbOwner_CheckedChanged);
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Location = new System.Drawing.Point(55, 50);
            this.rbClient.Margin = new System.Windows.Forms.Padding(2);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(51, 17);
            this.rbClient.TabIndex = 11;
            this.rbClient.TabStop = true;
            this.rbClient.Text = "Client";
            this.rbClient.UseVisualStyleBackColor = true;
            this.rbClient.CheckedChanged += new System.EventHandler(this.rbOwner_CheckedChanged);
            // 
            // MasterData_v1_BankAccounts_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 609);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MasterData_v1_BankAccounts_Form";
            this.Text = "BANK ACCOUNTS";
            this.panel1.ResumeLayout(false);
            this.pnlActionButtons.ResumeLayout(false);
            this.scInputLeft.Panel1.ResumeLayout(false);
            this.scInputLeft.Panel1.PerformLayout();
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
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_BankName;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Name;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.RadioButton rbUserAccount;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Owner_Ref;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_AccountNumber;
    }
}