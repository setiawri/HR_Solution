namespace SETTINGS
{
    partial class DBConnection_Form
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
            this.itxt_DatabaseName = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_ServerName = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(60, 111);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(64, 26);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "SAVE";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // itxt_DatabaseName
            // 
            this.itxt_DatabaseName.AllowDecimal = true;
            this.itxt_DatabaseName.AllowNegativeValue = true;
            this.itxt_DatabaseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itxt_DatabaseName.IsBrowseMode = false;
            this.itxt_DatabaseName.LabelText = "Database Name";
            this.itxt_DatabaseName.Location = new System.Drawing.Point(17, 64);
            this.itxt_DatabaseName.MaxLength = 32767;
            this.itxt_DatabaseName.MultiLine = false;
            this.itxt_DatabaseName.Name = "itxt_DatabaseName";
            this.itxt_DatabaseName.RowCount = 1;
            this.itxt_DatabaseName.ShowDeleteButton = false;
            this.itxt_DatabaseName.ShowInNumeric = false;
            this.itxt_DatabaseName.ShowTextboxOnly = false;
            this.itxt_DatabaseName.Size = new System.Drawing.Size(151, 40);
            this.itxt_DatabaseName.TabIndex = 7;
            this.itxt_DatabaseName.ValueText = "";
            // 
            // itxt_ServerName
            // 
            this.itxt_ServerName.AllowDecimal = true;
            this.itxt_ServerName.AllowNegativeValue = true;
            this.itxt_ServerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itxt_ServerName.IsBrowseMode = false;
            this.itxt_ServerName.LabelText = "Server Name";
            this.itxt_ServerName.Location = new System.Drawing.Point(17, 23);
            this.itxt_ServerName.MaxLength = 32767;
            this.itxt_ServerName.MultiLine = false;
            this.itxt_ServerName.Name = "itxt_ServerName";
            this.itxt_ServerName.RowCount = 1;
            this.itxt_ServerName.ShowDeleteButton = false;
            this.itxt_ServerName.ShowInNumeric = false;
            this.itxt_ServerName.ShowTextboxOnly = false;
            this.itxt_ServerName.Size = new System.Drawing.Size(151, 40);
            this.itxt_ServerName.TabIndex = 6;
            this.itxt_ServerName.ValueText = "";
            // 
            // DBConnectionSettings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.itxt_DatabaseName);
            this.Controls.Add(this.itxt_ServerName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBConnectionSettings_Form";
            this.Text = "DB CONNECTION";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_DatabaseName;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_ServerName;
    }
}