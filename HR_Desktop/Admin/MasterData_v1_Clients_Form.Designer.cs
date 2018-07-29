namespace HR_Desktop.Admin
{
    partial class MasterData_v1_Clients_Form
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
            this.itxt_CompanyName = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_NPWP = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_BillingAddress = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Address = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_NPWPAddress = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_ContactPersonName = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Notes = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Phone2 = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Phone1 = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlActionButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scInputLeft)).BeginInit();
            this.scInputLeft.Panel1.SuspendLayout();
            this.scInputLeft.Panel2.SuspendLayout();
            this.scInputLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scInputRight)).BeginInit();
            this.scInputRight.Panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(765, 28);
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Location = new System.Drawing.Point(0, 227);
            this.pnlActionButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActionButtons.Size = new System.Drawing.Size(765, 23);
            // 
            // scInputLeft
            // 
            this.scInputLeft.Margin = new System.Windows.Forms.Padding(4);
            // 
            // scInputLeft.Panel1
            // 
            this.scInputLeft.Panel1.Controls.Add(this.itxt_ContactPersonName);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_CompanyName);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Phone2);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Phone1);
            // 
            // scInputLeft.Panel2
            // 
            this.scInputLeft.Panel2.Controls.Add(this.itxt_Address);
            this.scInputLeft.Panel2.Controls.Add(this.itxt_BillingAddress);
            this.scInputLeft.Size = new System.Drawing.Size(500, 201);
            this.scInputLeft.SplitterWidth = 5;
            // 
            // scInputRight
            // 
            this.scInputRight.Margin = new System.Windows.Forms.Padding(4);
            // 
            // scInputRight.Panel1
            // 
            this.scInputRight.Panel1.Controls.Add(this.itxt_NPWP);
            this.scInputRight.Panel1.Controls.Add(this.itxt_Notes);
            this.scInputRight.Panel1.Controls.Add(this.itxt_NPWPAddress);
            this.scInputRight.Size = new System.Drawing.Size(260, 201);
            this.scInputRight.SplitterWidth = 5;
            // 
            // scMain
            // 
            this.scMain.Margin = new System.Windows.Forms.Padding(4);
            this.scMain.Size = new System.Drawing.Size(765, 609);
            this.scMain.SplitterDistance = 250;
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Margin = new System.Windows.Forms.Padding(4);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Size = new System.Drawing.Size(765, 26);
            // 
            // scInputContainer
            // 
            this.scInputContainer.Margin = new System.Windows.Forms.Padding(4);
            this.scInputContainer.Size = new System.Drawing.Size(765, 201);
            this.scInputContainer.SplitterWidth = 5;
            // 
            // btnLog
            // 
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // pnlQuickSearch
            // 
            this.pnlQuickSearch.Controls.Add(this.btnProfile);
            this.pnlQuickSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pnlQuickSearch.Size = new System.Drawing.Size(735, 28);
            this.pnlQuickSearch.Controls.SetChildIndex(this.txtQuickSearch, 0);
            this.pnlQuickSearch.Controls.SetChildIndex(this.lnkClearQuickSearch, 0);
            this.pnlQuickSearch.Controls.SetChildIndex(this.chkIncludeInactive, 0);
            this.pnlQuickSearch.Controls.SetChildIndex(this.label1, 0);
            this.pnlQuickSearch.Controls.SetChildIndex(this.btnProfile, 0);
            // 
            // itxt_CompanyName
            // 
            this.itxt_CompanyName.IsBrowseMode = false;
            this.itxt_CompanyName.LabelText = "*Company";
            this.itxt_CompanyName.Location = new System.Drawing.Point(4, 8);
            this.itxt_CompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_CompanyName.MaxLength = 50;
            this.itxt_CompanyName.MultiLine = false;
            this.itxt_CompanyName.Name = "itxt_CompanyName";
            this.itxt_CompanyName.PasswordChar = '\0';
            this.itxt_CompanyName.RowCount = 1;
            this.itxt_CompanyName.ShowDeleteButton = false;
            this.itxt_CompanyName.ShowTextboxOnly = false;
            this.itxt_CompanyName.Size = new System.Drawing.Size(225, 41);
            this.itxt_CompanyName.TabIndex = 9;
            this.itxt_CompanyName.ValueText = "";
            // 
            // itxt_NPWP
            // 
            this.itxt_NPWP.IsBrowseMode = false;
            this.itxt_NPWP.LabelText = "NPWP";
            this.itxt_NPWP.Location = new System.Drawing.Point(4, 8);
            this.itxt_NPWP.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_NPWP.MaxLength = 50;
            this.itxt_NPWP.MultiLine = false;
            this.itxt_NPWP.Name = "itxt_NPWP";
            this.itxt_NPWP.PasswordChar = '\0';
            this.itxt_NPWP.RowCount = 1;
            this.itxt_NPWP.ShowDeleteButton = false;
            this.itxt_NPWP.ShowTextboxOnly = false;
            this.itxt_NPWP.Size = new System.Drawing.Size(225, 41);
            this.itxt_NPWP.TabIndex = 12;
            this.itxt_NPWP.ValueText = "";
            // 
            // itxt_BillingAddress
            // 
            this.itxt_BillingAddress.IsBrowseMode = false;
            this.itxt_BillingAddress.LabelText = "Billing Address";
            this.itxt_BillingAddress.Location = new System.Drawing.Point(4, 79);
            this.itxt_BillingAddress.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_BillingAddress.MaxLength = 32767;
            this.itxt_BillingAddress.MultiLine = true;
            this.itxt_BillingAddress.Name = "itxt_BillingAddress";
            this.itxt_BillingAddress.PasswordChar = '\0';
            this.itxt_BillingAddress.RowCount = 3;
            this.itxt_BillingAddress.ShowDeleteButton = false;
            this.itxt_BillingAddress.ShowTextboxOnly = false;
            this.itxt_BillingAddress.Size = new System.Drawing.Size(225, 71);
            this.itxt_BillingAddress.TabIndex = 11;
            this.itxt_BillingAddress.ValueText = "";
            // 
            // itxt_Address
            // 
            this.itxt_Address.IsBrowseMode = false;
            this.itxt_Address.LabelText = "Address";
            this.itxt_Address.Location = new System.Drawing.Point(4, 8);
            this.itxt_Address.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Address.MaxLength = 32767;
            this.itxt_Address.MultiLine = true;
            this.itxt_Address.Name = "itxt_Address";
            this.itxt_Address.PasswordChar = '\0';
            this.itxt_Address.RowCount = 3;
            this.itxt_Address.ShowDeleteButton = false;
            this.itxt_Address.ShowTextboxOnly = false;
            this.itxt_Address.Size = new System.Drawing.Size(225, 71);
            this.itxt_Address.TabIndex = 10;
            this.itxt_Address.ValueText = "";
            // 
            // itxt_NPWPAddress
            // 
            this.itxt_NPWPAddress.IsBrowseMode = false;
            this.itxt_NPWPAddress.LabelText = "NPWP Address";
            this.itxt_NPWPAddress.Location = new System.Drawing.Point(4, 49);
            this.itxt_NPWPAddress.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_NPWPAddress.MaxLength = 32767;
            this.itxt_NPWPAddress.MultiLine = true;
            this.itxt_NPWPAddress.Name = "itxt_NPWPAddress";
            this.itxt_NPWPAddress.PasswordChar = '\0';
            this.itxt_NPWPAddress.RowCount = 3;
            this.itxt_NPWPAddress.ShowDeleteButton = false;
            this.itxt_NPWPAddress.ShowTextboxOnly = false;
            this.itxt_NPWPAddress.Size = new System.Drawing.Size(225, 71);
            this.itxt_NPWPAddress.TabIndex = 13;
            this.itxt_NPWPAddress.ValueText = "";
            // 
            // itxt_ContactPersonName
            // 
            this.itxt_ContactPersonName.IsBrowseMode = false;
            this.itxt_ContactPersonName.LabelText = "Contact";
            this.itxt_ContactPersonName.Location = new System.Drawing.Point(4, 49);
            this.itxt_ContactPersonName.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_ContactPersonName.MaxLength = 50;
            this.itxt_ContactPersonName.MultiLine = false;
            this.itxt_ContactPersonName.Name = "itxt_ContactPersonName";
            this.itxt_ContactPersonName.PasswordChar = '\0';
            this.itxt_ContactPersonName.RowCount = 5;
            this.itxt_ContactPersonName.ShowDeleteButton = false;
            this.itxt_ContactPersonName.ShowTextboxOnly = false;
            this.itxt_ContactPersonName.Size = new System.Drawing.Size(225, 41);
            this.itxt_ContactPersonName.TabIndex = 12;
            this.itxt_ContactPersonName.ValueText = "";
            // 
            // itxt_Notes
            // 
            this.itxt_Notes.IsBrowseMode = false;
            this.itxt_Notes.LabelText = "Notes";
            this.itxt_Notes.Location = new System.Drawing.Point(4, 120);
            this.itxt_Notes.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Notes.MaxLength = 32767;
            this.itxt_Notes.MultiLine = true;
            this.itxt_Notes.Name = "itxt_Notes";
            this.itxt_Notes.PasswordChar = '\0';
            this.itxt_Notes.RowCount = 3;
            this.itxt_Notes.ShowDeleteButton = false;
            this.itxt_Notes.ShowTextboxOnly = false;
            this.itxt_Notes.Size = new System.Drawing.Size(225, 71);
            this.itxt_Notes.TabIndex = 11;
            this.itxt_Notes.ValueText = "";
            // 
            // itxt_Phone2
            // 
            this.itxt_Phone2.IsBrowseMode = false;
            this.itxt_Phone2.LabelText = "Phone 2";
            this.itxt_Phone2.Location = new System.Drawing.Point(4, 131);
            this.itxt_Phone2.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Phone2.MaxLength = 50;
            this.itxt_Phone2.MultiLine = false;
            this.itxt_Phone2.Name = "itxt_Phone2";
            this.itxt_Phone2.PasswordChar = '\0';
            this.itxt_Phone2.RowCount = 1;
            this.itxt_Phone2.ShowDeleteButton = false;
            this.itxt_Phone2.ShowTextboxOnly = false;
            this.itxt_Phone2.Size = new System.Drawing.Size(225, 41);
            this.itxt_Phone2.TabIndex = 10;
            this.itxt_Phone2.ValueText = "";
            // 
            // itxt_Phone1
            // 
            this.itxt_Phone1.IsBrowseMode = false;
            this.itxt_Phone1.LabelText = "Phone1";
            this.itxt_Phone1.Location = new System.Drawing.Point(4, 90);
            this.itxt_Phone1.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Phone1.MaxLength = 50;
            this.itxt_Phone1.MultiLine = false;
            this.itxt_Phone1.Name = "itxt_Phone1";
            this.itxt_Phone1.PasswordChar = '\0';
            this.itxt_Phone1.RowCount = 1;
            this.itxt_Phone1.ShowDeleteButton = false;
            this.itxt_Phone1.ShowTextboxOnly = false;
            this.itxt_Phone1.Size = new System.Drawing.Size(225, 41);
            this.itxt_Phone1.TabIndex = 9;
            this.itxt_Phone1.ValueText = "";
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProfile.Location = new System.Drawing.Point(658, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 26);
            this.btnProfile.TabIndex = 14;
            this.btnProfile.Text = "PROFILE";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // MasterData_v1_Clients_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 609);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MasterData_v1_Clients_Form";
            this.Text = "CLIENTS";
            this.panel1.ResumeLayout(false);
            this.pnlActionButtons.ResumeLayout(false);
            this.scInputLeft.Panel1.ResumeLayout(false);
            this.scInputLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scInputLeft)).EndInit();
            this.scInputLeft.ResumeLayout(false);
            this.scInputRight.Panel1.ResumeLayout(false);
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

        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_CompanyName;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_NPWP;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_BillingAddress;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Address;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_NPWPAddress;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_ContactPersonName;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Notes;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Phone2;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Phone1;
        private System.Windows.Forms.Button btnProfile;
    }
}