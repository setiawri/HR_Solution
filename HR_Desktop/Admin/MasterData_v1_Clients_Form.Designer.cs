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
            this.itxt_Notes = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Address = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_BillingAddress = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_ContactPersonName = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Phone1 = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Phone2 = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_NPWP = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_NPWPAddress = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.btnProfile = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(765, 28);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.btnProfile, 0);
            this.panel1.Controls.SetChildIndex(this.chkIncludeInactive, 0);
            this.panel1.Controls.SetChildIndex(this.txtQuickSearch, 0);
            this.panel1.Controls.SetChildIndex(this.lnkClearQuickSearch, 0);
            this.panel1.Controls.SetChildIndex(this.ptInputPanel, 0);
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActionButtons.Size = new System.Drawing.Size(765, 23);
            // 
            // scInputLeft
            // 
            this.scInputLeft.Margin = new System.Windows.Forms.Padding(2);
            // 
            // scInputLeft.Panel1
            // 
            this.scInputLeft.Panel1.Controls.Add(this.itxt_CompanyName);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_NPWP);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_BillingAddress);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Address);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_NPWPAddress);
            // 
            // scInputLeft.Panel2
            // 
            this.scInputLeft.Panel2.Controls.Add(this.itxt_ContactPersonName);
            this.scInputLeft.Panel2.Controls.Add(this.itxt_Notes);
            this.scInputLeft.Panel2.Controls.Add(this.itxt_Phone2);
            this.scInputLeft.Panel2.Controls.Add(this.itxt_Phone1);
            this.scInputLeft.SplitterWidth = 3;
            // 
            // scInputRight
            // 
            this.scInputRight.Margin = new System.Windows.Forms.Padding(4);
            this.scInputRight.Size = new System.Drawing.Size(260, 271);
            this.scInputRight.SplitterWidth = 5;
            // 
            // scMain
            // 
            this.scMain.Margin = new System.Windows.Forms.Padding(4);
            this.scMain.Size = new System.Drawing.Size(765, 609);
            this.scMain.SplitterWidth = 5;
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
            this.scInputContainer.Size = new System.Drawing.Size(765, 271);
            this.scInputContainer.SplitterWidth = 5;
            // 
            // ptInputPanel
            // 
            this.ptInputPanel.Location = new System.Drawing.Point(0, 0);
            // 
            // itxt_CompanyName
            // 
            this.itxt_CompanyName.AllowDecimal = true;
            this.itxt_CompanyName.AllowNegativeValue = true;
            this.itxt_CompanyName.IsBrowseMode = false;
            this.itxt_CompanyName.LabelText = "*Company";
            this.itxt_CompanyName.Location = new System.Drawing.Point(12, 9);
            this.itxt_CompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_CompanyName.MaxLength = 50;
            this.itxt_CompanyName.MultiLine = false;
            this.itxt_CompanyName.Name = "itxt_CompanyName";
            this.itxt_CompanyName.PasswordChar = '\0';
            this.itxt_CompanyName.RowCount = 1;
            this.itxt_CompanyName.ShowDeleteButton = false;
            this.itxt_CompanyName.ShowInNumeric = false;
            this.itxt_CompanyName.ShowTextboxOnly = false;
            this.itxt_CompanyName.Size = new System.Drawing.Size(225, 40);
            this.itxt_CompanyName.TabIndex = 0;
            this.itxt_CompanyName.ValueText = "";
            // 
            // itxt_Notes
            // 
            this.itxt_Notes.AllowDecimal = true;
            this.itxt_Notes.AllowNegativeValue = true;
            this.itxt_Notes.IsBrowseMode = false;
            this.itxt_Notes.LabelText = "Notes";
            this.itxt_Notes.Location = new System.Drawing.Point(11, 131);
            this.itxt_Notes.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Notes.MaxLength = 32767;
            this.itxt_Notes.MultiLine = true;
            this.itxt_Notes.Name = "itxt_Notes";
            this.itxt_Notes.PasswordChar = '\0';
            this.itxt_Notes.RowCount = 8;
            this.itxt_Notes.ShowDeleteButton = false;
            this.itxt_Notes.ShowInNumeric = false;
            this.itxt_Notes.ShowTextboxOnly = false;
            this.itxt_Notes.Size = new System.Drawing.Size(225, 66);
            this.itxt_Notes.TabIndex = 3;
            this.itxt_Notes.ValueText = "";
            // 
            // itxt_Address
            // 
            this.itxt_Address.AllowDecimal = true;
            this.itxt_Address.AllowNegativeValue = true;
            this.itxt_Address.IsBrowseMode = false;
            this.itxt_Address.LabelText = "Address";
            this.itxt_Address.Location = new System.Drawing.Point(12, 49);
            this.itxt_Address.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Address.MaxLength = 32767;
            this.itxt_Address.MultiLine = true;
            this.itxt_Address.Name = "itxt_Address";
            this.itxt_Address.PasswordChar = '\0';
            this.itxt_Address.RowCount = 1;
            this.itxt_Address.ShowDeleteButton = false;
            this.itxt_Address.ShowInNumeric = false;
            this.itxt_Address.ShowTextboxOnly = false;
            this.itxt_Address.Size = new System.Drawing.Size(225, 49);
            this.itxt_Address.TabIndex = 1;
            this.itxt_Address.ValueText = "";
            // 
            // itxt_BillingAddress
            // 
            this.itxt_BillingAddress.AllowDecimal = true;
            this.itxt_BillingAddress.AllowNegativeValue = true;
            this.itxt_BillingAddress.IsBrowseMode = false;
            this.itxt_BillingAddress.LabelText = "Billing Address";
            this.itxt_BillingAddress.Location = new System.Drawing.Point(12, 101);
            this.itxt_BillingAddress.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_BillingAddress.MaxLength = 32767;
            this.itxt_BillingAddress.MultiLine = true;
            this.itxt_BillingAddress.Name = "itxt_BillingAddress";
            this.itxt_BillingAddress.PasswordChar = '\0';
            this.itxt_BillingAddress.RowCount = 1;
            this.itxt_BillingAddress.ShowDeleteButton = false;
            this.itxt_BillingAddress.ShowInNumeric = false;
            this.itxt_BillingAddress.ShowTextboxOnly = false;
            this.itxt_BillingAddress.Size = new System.Drawing.Size(225, 49);
            this.itxt_BillingAddress.TabIndex = 2;
            this.itxt_BillingAddress.ValueText = "";
            // 
            // itxt_ContactPersonName
            // 
            this.itxt_ContactPersonName.AllowDecimal = true;
            this.itxt_ContactPersonName.AllowNegativeValue = true;
            this.itxt_ContactPersonName.IsBrowseMode = false;
            this.itxt_ContactPersonName.LabelText = "Contact";
            this.itxt_ContactPersonName.Location = new System.Drawing.Point(11, 8);
            this.itxt_ContactPersonName.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_ContactPersonName.MaxLength = 50;
            this.itxt_ContactPersonName.MultiLine = false;
            this.itxt_ContactPersonName.Name = "itxt_ContactPersonName";
            this.itxt_ContactPersonName.PasswordChar = '\0';
            this.itxt_ContactPersonName.RowCount = 5;
            this.itxt_ContactPersonName.ShowDeleteButton = false;
            this.itxt_ContactPersonName.ShowInNumeric = false;
            this.itxt_ContactPersonName.ShowTextboxOnly = false;
            this.itxt_ContactPersonName.Size = new System.Drawing.Size(225, 41);
            this.itxt_ContactPersonName.TabIndex = 4;
            this.itxt_ContactPersonName.ValueText = "";
            // 
            // itxt_Phone1
            // 
            this.itxt_Phone1.AllowDecimal = true;
            this.itxt_Phone1.AllowNegativeValue = true;
            this.itxt_Phone1.IsBrowseMode = false;
            this.itxt_Phone1.LabelText = "Phone1";
            this.itxt_Phone1.Location = new System.Drawing.Point(11, 48);
            this.itxt_Phone1.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Phone1.MaxLength = 50;
            this.itxt_Phone1.MultiLine = false;
            this.itxt_Phone1.Name = "itxt_Phone1";
            this.itxt_Phone1.PasswordChar = '\0';
            this.itxt_Phone1.RowCount = 1;
            this.itxt_Phone1.ShowDeleteButton = false;
            this.itxt_Phone1.ShowInNumeric = false;
            this.itxt_Phone1.ShowTextboxOnly = false;
            this.itxt_Phone1.Size = new System.Drawing.Size(225, 46);
            this.itxt_Phone1.TabIndex = 1;
            this.itxt_Phone1.ValueText = "";
            // 
            // itxt_Phone2
            // 
            this.itxt_Phone2.AllowDecimal = true;
            this.itxt_Phone2.AllowNegativeValue = true;
            this.itxt_Phone2.IsBrowseMode = false;
            this.itxt_Phone2.LabelText = "Phone 2";
            this.itxt_Phone2.Location = new System.Drawing.Point(11, 89);
            this.itxt_Phone2.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Phone2.MaxLength = 50;
            this.itxt_Phone2.MultiLine = false;
            this.itxt_Phone2.Name = "itxt_Phone2";
            this.itxt_Phone2.PasswordChar = '\0';
            this.itxt_Phone2.RowCount = 1;
            this.itxt_Phone2.ShowDeleteButton = false;
            this.itxt_Phone2.ShowInNumeric = false;
            this.itxt_Phone2.ShowTextboxOnly = false;
            this.itxt_Phone2.Size = new System.Drawing.Size(225, 40);
            this.itxt_Phone2.TabIndex = 2;
            this.itxt_Phone2.ValueText = "";
            // 
            // itxt_NPWP
            // 
            this.itxt_NPWP.AllowDecimal = true;
            this.itxt_NPWP.AllowNegativeValue = true;
            this.itxt_NPWP.IsBrowseMode = false;
            this.itxt_NPWP.LabelText = "NPWP";
            this.itxt_NPWP.Location = new System.Drawing.Point(12, 153);
            this.itxt_NPWP.MaxLength = 50;
            this.itxt_NPWP.MultiLine = false;
            this.itxt_NPWP.Name = "itxt_NPWP";
            this.itxt_NPWP.PasswordChar = '\0';
            this.itxt_NPWP.RowCount = 1;
            this.itxt_NPWP.ShowDeleteButton = false;
            this.itxt_NPWP.ShowInNumeric = false;
            this.itxt_NPWP.ShowTextboxOnly = false;
            this.itxt_NPWP.Size = new System.Drawing.Size(225, 41);
            this.itxt_NPWP.TabIndex = 3;
            this.itxt_NPWP.ValueText = "";
            // 
            // itxt_NPWPAddress
            // 
            this.itxt_NPWPAddress.AllowDecimal = true;
            this.itxt_NPWPAddress.AllowNegativeValue = true;
            this.itxt_NPWPAddress.IsBrowseMode = false;
            this.itxt_NPWPAddress.LabelText = "NPWP Address";
            this.itxt_NPWPAddress.Location = new System.Drawing.Point(12, 193);
            this.itxt_NPWPAddress.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_NPWPAddress.MaxLength = 32767;
            this.itxt_NPWPAddress.MultiLine = true;
            this.itxt_NPWPAddress.Name = "itxt_NPWPAddress";
            this.itxt_NPWPAddress.PasswordChar = '\0';
            this.itxt_NPWPAddress.RowCount = 1;
            this.itxt_NPWPAddress.ShowDeleteButton = false;
            this.itxt_NPWPAddress.ShowInNumeric = false;
            this.itxt_NPWPAddress.ShowTextboxOnly = false;
            this.itxt_NPWPAddress.Size = new System.Drawing.Size(225, 49);
            this.itxt_NPWPAddress.TabIndex = 3;
            this.itxt_NPWPAddress.ValueText = "";
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(328, 3);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 23);
            this.btnProfile.TabIndex = 4;
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
            this.panel1.PerformLayout();
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
            this.ResumeLayout(false);

        }

        #endregion

        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_CompanyName;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Notes;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_ContactPersonName;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_BillingAddress;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Address;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Phone2;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Phone1;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_NPWP;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_NPWPAddress;
        private System.Windows.Forms.Button btnProfile;
    }
}