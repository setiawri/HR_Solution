namespace LOGIN
{
    partial class Login_Form
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.itxt_Password = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Username = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(72, 114);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "login";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // itxt_Password
            //
            this.itxt_Password.IsBrowseMode = false;
            this.itxt_Password.LabelText = "password";
            this.itxt_Password.Location = new System.Drawing.Point(38, 62);
            this.itxt_Password.MaxLength = 30;
            this.itxt_Password.MultiLine = false;
            this.itxt_Password.Name = "itxt_Password";
            this.itxt_Password.PasswordChar = '*';
            this.itxt_Password.RowCount = 1;
            this.itxt_Password.ShowDeleteButton = false;
            this.itxt_Password.ShowTextboxOnly = false;
            this.itxt_Password.Size = new System.Drawing.Size(143, 41);
            this.itxt_Password.TabIndex = 1;
            this.itxt_Password.ValueText = "";
            // 
            // itxt_Username
            // 
            this.itxt_Username.IsBrowseMode = false;
            this.itxt_Username.LabelText = "username";
            this.itxt_Username.Location = new System.Drawing.Point(38, 20);
            this.itxt_Username.MaxLength = 30;
            this.itxt_Username.MultiLine = false;
            this.itxt_Username.Name = "itxt_Username";
            this.itxt_Username.PasswordChar = '\0';
            this.itxt_Username.RowCount = 1;
            this.itxt_Username.ShowDeleteButton = false;
            this.itxt_Username.ShowTextboxOnly = false;
            this.itxt_Username.Size = new System.Drawing.Size(143, 41);
            this.itxt_Username.TabIndex = 0;
            this.itxt_Username.ValueText = "";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 157);
            this.Controls.Add(this.itxt_Password);
            this.Controls.Add(this.itxt_Username);
            this.Controls.Add(this.btnSubmit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Username;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Password;
    }
}