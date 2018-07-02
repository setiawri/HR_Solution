﻿namespace LOGIN
{
    partial class MasterData_v1_UserAccounts_Form
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
            this.itxt_Username = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Notes = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Firstname = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Lastname = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Address1 = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Email = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Phone1 = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Phone2 = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.idtp_Birthdate = new LIBUtil.Desktop.UserControls.InputControl_DateTimePicker();
            this.gbUserAccountRoles = new System.Windows.Forms.GroupBox();
            this.clbUserAccountRoles = new System.Windows.Forms.CheckedListBox();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnTutorSchedule = new System.Windows.Forms.Button();
            this.itxt_Address2 = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Identification = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Height = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Weight = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
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
            this.gbUserAccountRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTutorSchedule);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1020, 34);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.chkIncludeInactive, 0);
            this.panel1.Controls.SetChildIndex(this.txtQuickSearch, 0);
            this.panel1.Controls.SetChildIndex(this.lnkClearQuickSearch, 0);
            this.panel1.Controls.SetChildIndex(this.btnTutorSchedule, 0);
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Location = new System.Drawing.Point(0, 292);
            this.pnlActionButtons.Margin = new System.Windows.Forms.Padding(5);
            this.pnlActionButtons.Size = new System.Drawing.Size(1020, 28);
            // 
            // scInputLeft
            // 
            // 
            // scInputLeft.Panel1
            // 
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Username);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Identification);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Lastname);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Firstname);
            this.scInputLeft.Panel1.Controls.Add(this.idtp_Birthdate);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Email);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Weight);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Height);
            // 
            // scInputLeft.Panel2
            // 
            this.scInputLeft.Panel2.Controls.Add(this.itxt_Address1);
            this.scInputLeft.Panel2.Controls.Add(this.itxt_Address2);
            this.scInputLeft.Panel2.Controls.Add(this.itxt_Notes);
            this.scInputLeft.Panel2.Controls.Add(this.itxt_Phone2);
            this.scInputLeft.Panel2.Controls.Add(this.itxt_Phone1);
            this.scInputLeft.Size = new System.Drawing.Size(500, 260);
            // 
            // scInputRight
            // 
            this.scInputRight.Margin = new System.Windows.Forms.Padding(5);
            // 
            // scInputRight.Panel1
            // 
            this.scInputRight.Panel1.Controls.Add(this.gbUserAccountRoles);
            this.scInputRight.Size = new System.Drawing.Size(513, 260);
            this.scInputRight.SplitterWidth = 7;
            // 
            // scMain
            // 
            this.scMain.Margin = new System.Windows.Forms.Padding(5);
            this.scMain.Size = new System.Drawing.Size(1020, 825);
            this.scMain.SplitterWidth = 6;
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Margin = new System.Windows.Forms.Padding(5);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnRoles);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(5);
            this.pnlButtons.Size = new System.Drawing.Size(1020, 32);
            this.pnlButtons.Controls.SetChildIndex(this.btnRoles, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnSearch, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnUpdate, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnLog, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnAdd, 0);
            // 
            // scInputContainer
            // 
            this.scInputContainer.Margin = new System.Windows.Forms.Padding(5);
            this.scInputContainer.Size = new System.Drawing.Size(1020, 260);
            this.scInputContainer.SplitterWidth = 7;
            // 
            // itxt_Username
            // 
            this.itxt_Username.AllowDecimal = true;
            this.itxt_Username.AllowNegativeValue = true;
            this.itxt_Username.IsBrowseMode = false;
            this.itxt_Username.LabelText = "Username";
            this.itxt_Username.Location = new System.Drawing.Point(16, 7);
            this.itxt_Username.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Username.MaxLength = 50;
            this.itxt_Username.MultiLine = false;
            this.itxt_Username.Name = "itxt_Username";
            this.itxt_Username.PasswordChar = '\0';
            this.itxt_Username.RowCount = 1;
            this.itxt_Username.ShowDeleteButton = false;
            this.itxt_Username.ShowInNumeric = false;
            this.itxt_Username.ShowTextboxOnly = false;
            this.itxt_Username.Size = new System.Drawing.Size(300, 49);
            this.itxt_Username.TabIndex = 0;
            this.itxt_Username.ValueText = "";
            // 
            // itxt_Notes
            // 
            this.itxt_Notes.AllowDecimal = true;
            this.itxt_Notes.AllowNegativeValue = true;
            this.itxt_Notes.IsBrowseMode = false;
            this.itxt_Notes.LabelText = "Notes";
            this.itxt_Notes.Location = new System.Drawing.Point(15, 240);
            this.itxt_Notes.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Notes.MaxLength = 32767;
            this.itxt_Notes.MultiLine = true;
            this.itxt_Notes.Name = "itxt_Notes";
            this.itxt_Notes.PasswordChar = '\0';
            this.itxt_Notes.RowCount = 8;
            this.itxt_Notes.ShowDeleteButton = false;
            this.itxt_Notes.ShowInNumeric = false;
            this.itxt_Notes.ShowTextboxOnly = false;
            this.itxt_Notes.Size = new System.Drawing.Size(300, 81);
            this.itxt_Notes.TabIndex = 3;
            this.itxt_Notes.ValueText = "";
            // 
            // itxt_Firstname
            // 
            this.itxt_Firstname.AllowDecimal = true;
            this.itxt_Firstname.AllowNegativeValue = true;
            this.itxt_Firstname.IsBrowseMode = false;
            this.itxt_Firstname.LabelText = "Firstname";
            this.itxt_Firstname.Location = new System.Drawing.Point(16, 55);
            this.itxt_Firstname.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Firstname.MaxLength = 50;
            this.itxt_Firstname.MultiLine = false;
            this.itxt_Firstname.Name = "itxt_Firstname";
            this.itxt_Firstname.PasswordChar = '\0';
            this.itxt_Firstname.RowCount = 1;
            this.itxt_Firstname.ShowDeleteButton = false;
            this.itxt_Firstname.ShowInNumeric = false;
            this.itxt_Firstname.ShowTextboxOnly = false;
            this.itxt_Firstname.Size = new System.Drawing.Size(300, 49);
            this.itxt_Firstname.TabIndex = 1;
            this.itxt_Firstname.ValueText = "";
            // 
            // itxt_Lastname
            // 
            this.itxt_Lastname.AllowDecimal = true;
            this.itxt_Lastname.AllowNegativeValue = true;
            this.itxt_Lastname.IsBrowseMode = false;
            this.itxt_Lastname.LabelText = "Lastname";
            this.itxt_Lastname.Location = new System.Drawing.Point(16, 103);
            this.itxt_Lastname.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Lastname.MaxLength = 50;
            this.itxt_Lastname.MultiLine = false;
            this.itxt_Lastname.Name = "itxt_Lastname";
            this.itxt_Lastname.PasswordChar = '\0';
            this.itxt_Lastname.RowCount = 1;
            this.itxt_Lastname.ShowDeleteButton = false;
            this.itxt_Lastname.ShowInNumeric = false;
            this.itxt_Lastname.ShowTextboxOnly = false;
            this.itxt_Lastname.Size = new System.Drawing.Size(300, 49);
            this.itxt_Lastname.TabIndex = 2;
            this.itxt_Lastname.ValueText = "";
            // 
            // itxt_Address1
            // 
            this.itxt_Address1.AllowDecimal = true;
            this.itxt_Address1.AllowNegativeValue = true;
            this.itxt_Address1.IsBrowseMode = false;
            this.itxt_Address1.LabelText = "Address1";
            this.itxt_Address1.Location = new System.Drawing.Point(15, 6);
            this.itxt_Address1.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Address1.MaxLength = 32767;
            this.itxt_Address1.MultiLine = true;
            this.itxt_Address1.Name = "itxt_Address1";
            this.itxt_Address1.PasswordChar = '\0';
            this.itxt_Address1.RowCount = 5;
            this.itxt_Address1.ShowDeleteButton = false;
            this.itxt_Address1.ShowInNumeric = false;
            this.itxt_Address1.ShowTextboxOnly = false;
            this.itxt_Address1.Size = new System.Drawing.Size(300, 60);
            this.itxt_Address1.TabIndex = 4;
            this.itxt_Address1.ValueText = "";
            // 
            // itxt_Email
            // 
            this.itxt_Email.AllowDecimal = true;
            this.itxt_Email.AllowNegativeValue = true;
            this.itxt_Email.IsBrowseMode = false;
            this.itxt_Email.LabelText = "Email";
            this.itxt_Email.Location = new System.Drawing.Point(16, 245);
            this.itxt_Email.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Email.MaxLength = 50;
            this.itxt_Email.MultiLine = false;
            this.itxt_Email.Name = "itxt_Email";
            this.itxt_Email.PasswordChar = '\0';
            this.itxt_Email.RowCount = 1;
            this.itxt_Email.ShowDeleteButton = false;
            this.itxt_Email.ShowInNumeric = false;
            this.itxt_Email.ShowTextboxOnly = false;
            this.itxt_Email.Size = new System.Drawing.Size(300, 43);
            this.itxt_Email.TabIndex = 3;
            this.itxt_Email.ValueText = "";
            // 
            // itxt_Phone1
            // 
            this.itxt_Phone1.AllowDecimal = true;
            this.itxt_Phone1.AllowNegativeValue = true;
            this.itxt_Phone1.IsBrowseMode = false;
            this.itxt_Phone1.LabelText = "Phone1";
            this.itxt_Phone1.Location = new System.Drawing.Point(15, 139);
            this.itxt_Phone1.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Phone1.MaxLength = 50;
            this.itxt_Phone1.MultiLine = false;
            this.itxt_Phone1.Name = "itxt_Phone1";
            this.itxt_Phone1.PasswordChar = '\0';
            this.itxt_Phone1.RowCount = 1;
            this.itxt_Phone1.ShowDeleteButton = false;
            this.itxt_Phone1.ShowInNumeric = false;
            this.itxt_Phone1.ShowTextboxOnly = false;
            this.itxt_Phone1.Size = new System.Drawing.Size(300, 56);
            this.itxt_Phone1.TabIndex = 1;
            this.itxt_Phone1.ValueText = "";
            // 
            // itxt_Phone2
            // 
            this.itxt_Phone2.AllowDecimal = true;
            this.itxt_Phone2.AllowNegativeValue = true;
            this.itxt_Phone2.IsBrowseMode = false;
            this.itxt_Phone2.LabelText = "Phone 2";
            this.itxt_Phone2.Location = new System.Drawing.Point(15, 186);
            this.itxt_Phone2.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Phone2.MaxLength = 50;
            this.itxt_Phone2.MultiLine = false;
            this.itxt_Phone2.Name = "itxt_Phone2";
            this.itxt_Phone2.PasswordChar = '\0';
            this.itxt_Phone2.RowCount = 1;
            this.itxt_Phone2.ShowDeleteButton = false;
            this.itxt_Phone2.ShowInNumeric = false;
            this.itxt_Phone2.ShowTextboxOnly = false;
            this.itxt_Phone2.Size = new System.Drawing.Size(300, 49);
            this.itxt_Phone2.TabIndex = 2;
            this.itxt_Phone2.ValueText = "";
            // 
            // idtp_Birthdate
            // 
            this.idtp_Birthdate.CustomFormat = "";
            this.idtp_Birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.idtp_Birthdate.LabelText = "Birthday";
            this.idtp_Birthdate.Location = new System.Drawing.Point(16, 199);
            this.idtp_Birthdate.Margin = new System.Windows.Forms.Padding(5);
            this.idtp_Birthdate.Name = "idtp_Birthdate";
            this.idtp_Birthdate.ShowCheckBox = true;
            this.idtp_Birthdate.Size = new System.Drawing.Size(300, 43);
            this.idtp_Birthdate.TabIndex = 3;
            this.idtp_Birthdate.Value = new System.DateTime(2017, 2, 28, 16, 27, 12, 664);
            // 
            // gbUserAccountRoles
            // 
            this.gbUserAccountRoles.BackColor = System.Drawing.SystemColors.Control;
            this.gbUserAccountRoles.Controls.Add(this.clbUserAccountRoles);
            this.gbUserAccountRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUserAccountRoles.Location = new System.Drawing.Point(0, 0);
            this.gbUserAccountRoles.Margin = new System.Windows.Forms.Padding(4);
            this.gbUserAccountRoles.Name = "gbUserAccountRoles";
            this.gbUserAccountRoles.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gbUserAccountRoles.Size = new System.Drawing.Size(249, 260);
            this.gbUserAccountRoles.TabIndex = 1;
            this.gbUserAccountRoles.TabStop = false;
            this.gbUserAccountRoles.Text = "Roles";
            // 
            // clbUserAccountRoles
            // 
            this.clbUserAccountRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbUserAccountRoles.FormattingEnabled = true;
            this.clbUserAccountRoles.Location = new System.Drawing.Point(7, 21);
            this.clbUserAccountRoles.Margin = new System.Windows.Forms.Padding(4);
            this.clbUserAccountRoles.Name = "clbUserAccountRoles";
            this.clbUserAccountRoles.Size = new System.Drawing.Size(235, 233);
            this.clbUserAccountRoles.TabIndex = 0;
            // 
            // btnRoles
            // 
            this.btnRoles.Location = new System.Drawing.Point(909, 2);
            this.btnRoles.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(100, 28);
            this.btnRoles.TabIndex = 4;
            this.btnRoles.Text = "ROLES";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnTutorSchedule
            // 
            this.btnTutorSchedule.Location = new System.Drawing.Point(909, 4);
            this.btnTutorSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnTutorSchedule.Name = "btnTutorSchedule";
            this.btnTutorSchedule.Size = new System.Drawing.Size(100, 28);
            this.btnTutorSchedule.TabIndex = 14;
            this.btnTutorSchedule.Text = "Schedule";
            this.btnTutorSchedule.UseVisualStyleBackColor = true;
            this.btnTutorSchedule.Click += new System.EventHandler(this.btnTutorSchedule_Click);
            // 
            // itxt_Address2
            // 
            this.itxt_Address2.AllowDecimal = true;
            this.itxt_Address2.AllowNegativeValue = true;
            this.itxt_Address2.IsBrowseMode = false;
            this.itxt_Address2.LabelText = "Address2";
            this.itxt_Address2.Location = new System.Drawing.Point(15, 68);
            this.itxt_Address2.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Address2.MaxLength = 32767;
            this.itxt_Address2.MultiLine = true;
            this.itxt_Address2.Name = "itxt_Address2";
            this.itxt_Address2.PasswordChar = '\0';
            this.itxt_Address2.RowCount = 5;
            this.itxt_Address2.ShowDeleteButton = false;
            this.itxt_Address2.ShowInNumeric = false;
            this.itxt_Address2.ShowTextboxOnly = false;
            this.itxt_Address2.Size = new System.Drawing.Size(300, 70);
            this.itxt_Address2.TabIndex = 5;
            this.itxt_Address2.ValueText = "";
            // 
            // itxt_Identification
            // 
            this.itxt_Identification.AllowDecimal = true;
            this.itxt_Identification.AllowNegativeValue = true;
            this.itxt_Identification.IsBrowseMode = false;
            this.itxt_Identification.LabelText = "Identification";
            this.itxt_Identification.Location = new System.Drawing.Point(16, 151);
            this.itxt_Identification.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itxt_Identification.MaxLength = 32767;
            this.itxt_Identification.MultiLine = false;
            this.itxt_Identification.Name = "itxt_Identification";
            this.itxt_Identification.PasswordChar = '\0';
            this.itxt_Identification.RowCount = 1;
            this.itxt_Identification.ShowDeleteButton = false;
            this.itxt_Identification.ShowInNumeric = false;
            this.itxt_Identification.ShowTextboxOnly = false;
            this.itxt_Identification.Size = new System.Drawing.Size(300, 50);
            this.itxt_Identification.TabIndex = 3;
            this.itxt_Identification.ValueText = "";
            // 
            // itxt_Height
            // 
            this.itxt_Height.AllowDecimal = true;
            this.itxt_Height.AllowNegativeValue = true;
            this.itxt_Height.IsBrowseMode = false;
            this.itxt_Height.LabelText = "Height";
            this.itxt_Height.Location = new System.Drawing.Point(16, 288);
            this.itxt_Height.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itxt_Height.MaxLength = 32767;
            this.itxt_Height.MultiLine = false;
            this.itxt_Height.Name = "itxt_Height";
            this.itxt_Height.PasswordChar = '\0';
            this.itxt_Height.RowCount = 1;
            this.itxt_Height.ShowDeleteButton = false;
            this.itxt_Height.ShowInNumeric = false;
            this.itxt_Height.ShowTextboxOnly = false;
            this.itxt_Height.Size = new System.Drawing.Size(140, 43);
            this.itxt_Height.TabIndex = 4;
            this.itxt_Height.ValueText = "";
            // 
            // itxt_Weight
            // 
            this.itxt_Weight.AllowDecimal = true;
            this.itxt_Weight.AllowNegativeValue = true;
            this.itxt_Weight.IsBrowseMode = false;
            this.itxt_Weight.LabelText = "Weight";
            this.itxt_Weight.Location = new System.Drawing.Point(176, 288);
            this.itxt_Weight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itxt_Weight.MaxLength = 32767;
            this.itxt_Weight.MultiLine = false;
            this.itxt_Weight.Name = "itxt_Weight";
            this.itxt_Weight.PasswordChar = '\0';
            this.itxt_Weight.RowCount = 1;
            this.itxt_Weight.ShowDeleteButton = false;
            this.itxt_Weight.ShowInNumeric = false;
            this.itxt_Weight.ShowTextboxOnly = false;
            this.itxt_Weight.Size = new System.Drawing.Size(140, 43);
            this.itxt_Weight.TabIndex = 5;
            this.itxt_Weight.ValueText = "";
            // 
            // MasterData_v1_UserAccounts_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 825);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MasterData_v1_UserAccounts_Form";
            this.Text = "USER ACCOUNTS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
            this.gbUserAccountRoles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Username;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Notes;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Address1;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Lastname;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Firstname;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Phone2;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Phone1;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Email;
        private LIBUtil.Desktop.UserControls.InputControl_DateTimePicker idtp_Birthdate;
        private System.Windows.Forms.GroupBox gbUserAccountRoles;
        private System.Windows.Forms.CheckedListBox clbUserAccountRoles;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnTutorSchedule;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Address2;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Weight;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Height;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Identification;
    }
}