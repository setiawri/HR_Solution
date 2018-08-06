namespace HR_Desktop.Payroll
{
    partial class Payments_Add_Form
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.iddl_Target_BankAccounts = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
            this.iddl_Source_BankAccounts = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
            this.label2 = new System.Windows.Forms.Label();
            this.in_BankAmount = new LIBUtil.Desktop.UserControls.InputControl_Numeric();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itxt_ConfirmationNumber = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Notes = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(95, 25);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(89, 20);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "lblAmount";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "TOTAL:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmit.Location = new System.Drawing.Point(118, 293);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // iddl_Target_BankAccounts
            // 
            this.iddl_Target_BankAccounts.DisableTextInput = false;
            this.iddl_Target_BankAccounts.HideFilter = false;
            this.iddl_Target_BankAccounts.HideUpdateLink = false;
            this.iddl_Target_BankAccounts.LabelText = "dropdownlist";
            this.iddl_Target_BankAccounts.Location = new System.Drawing.Point(102, 85);
            this.iddl_Target_BankAccounts.Name = "iddl_Target_BankAccounts";
            this.iddl_Target_BankAccounts.SelectedItem = null;
            this.iddl_Target_BankAccounts.SelectedValue = null;
            this.iddl_Target_BankAccounts.ShowDropdownlistOnly = true;
            this.iddl_Target_BankAccounts.Size = new System.Drawing.Size(177, 22);
            this.iddl_Target_BankAccounts.TabIndex = 26;
            // 
            // iddl_Source_BankAccounts
            // 
            this.iddl_Source_BankAccounts.DisableTextInput = false;
            this.iddl_Source_BankAccounts.HideFilter = false;
            this.iddl_Source_BankAccounts.HideUpdateLink = true;
            this.iddl_Source_BankAccounts.LabelText = "";
            this.iddl_Source_BankAccounts.Location = new System.Drawing.Point(102, 113);
            this.iddl_Source_BankAccounts.Name = "iddl_Source_BankAccounts";
            this.iddl_Source_BankAccounts.SelectedItem = null;
            this.iddl_Source_BankAccounts.SelectedValue = null;
            this.iddl_Source_BankAccounts.ShowDropdownlistOnly = true;
            this.iddl_Source_BankAccounts.Size = new System.Drawing.Size(177, 22);
            this.iddl_Source_BankAccounts.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Amount";
            // 
            // in_BankAmount
            // 
            this.in_BankAmount.Checked = false;
            this.in_BankAmount.DecimalPlaces = 0;
            this.in_BankAmount.HideUpDown = false;
            this.in_BankAmount.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.in_BankAmount.LabelText = "";
            this.in_BankAmount.Location = new System.Drawing.Point(103, 142);
            this.in_BankAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.in_BankAmount.MaximumValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.in_BankAmount.MinimumValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.in_BankAmount.Name = "in_BankAmount";
            this.in_BankAmount.ShowCheckbox = false;
            this.in_BankAmount.ShowTextboxOnly = true;
            this.in_BankAmount.Size = new System.Drawing.Size(176, 22);
            this.in_BankAmount.TabIndex = 2;
            this.in_BankAmount.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.in_BankAmount.ValueChanged += new System.EventHandler(this.in_BankAmount_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Target";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(31, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Confirmation";
            // 
            // itxt_ConfirmationNumber
            // 
            this.itxt_ConfirmationNumber.IsBrowseMode = false;
            this.itxt_ConfirmationNumber.LabelText = "textbox";
            this.itxt_ConfirmationNumber.Location = new System.Drawing.Point(103, 172);
            this.itxt_ConfirmationNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itxt_ConfirmationNumber.MaxLength = 100;
            this.itxt_ConfirmationNumber.MultiLine = false;
            this.itxt_ConfirmationNumber.Name = "itxt_ConfirmationNumber";
            this.itxt_ConfirmationNumber.PasswordChar = '\0';
            this.itxt_ConfirmationNumber.RowCount = 1;
            this.itxt_ConfirmationNumber.ShowDeleteButton = false;
            this.itxt_ConfirmationNumber.ShowTextboxOnly = true;
            this.itxt_ConfirmationNumber.Size = new System.Drawing.Size(176, 21);
            this.itxt_ConfirmationNumber.TabIndex = 5;
            this.itxt_ConfirmationNumber.ValueText = "";
            // 
            // itxt_Notes
            // 
            this.itxt_Notes.IsBrowseMode = false;
            this.itxt_Notes.LabelText = "Notes";
            this.itxt_Notes.Location = new System.Drawing.Point(34, 201);
            this.itxt_Notes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itxt_Notes.MaxLength = 32767;
            this.itxt_Notes.MultiLine = true;
            this.itxt_Notes.Name = "itxt_Notes";
            this.itxt_Notes.PasswordChar = '\0';
            this.itxt_Notes.RowCount = 3;
            this.itxt_Notes.ShowDeleteButton = false;
            this.itxt_Notes.ShowTextboxOnly = false;
            this.itxt_Notes.Size = new System.Drawing.Size(245, 72);
            this.itxt_Notes.TabIndex = 2;
            this.itxt_Notes.ValueText = "";
            // 
            // Payments_Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 382);
            this.Controls.Add(this.iddl_Target_BankAccounts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itxt_Notes);
            this.Controls.Add(this.iddl_Source_BankAccounts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.in_BankAmount);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itxt_ConfirmationNumber);
            this.Name = "Payments_Add_Form";
            this.Text = "PAYMENTS";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmit;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Notes;
        private LIBUtil.Desktop.UserControls.InputControl_Dropdownlist iddl_Target_BankAccounts;
        private LIBUtil.Desktop.UserControls.InputControl_Dropdownlist iddl_Source_BankAccounts;
        private System.Windows.Forms.Label label2;
        private LIBUtil.Desktop.UserControls.InputControl_Numeric in_BankAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_ConfirmationNumber;
    }
}