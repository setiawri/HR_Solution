namespace HR_Desktop.Admin
{
    partial class MasterData_v1_AttendanceStatuses_Form
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
            this.itxt_Name = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Notes = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.panel1.SuspendLayout();
            this.pnlActionButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scInputLeft)).BeginInit();
            this.scInputLeft.Panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(330, 28);
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Location = new System.Drawing.Point(0, 177);
            this.pnlActionButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActionButtons.Size = new System.Drawing.Size(330, 23);
            // 
            // scInputLeft
            // 
            this.scInputLeft.Margin = new System.Windows.Forms.Padding(2);
            // 
            // scInputLeft.Panel1
            // 
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Name);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Notes);
            this.scInputLeft.Size = new System.Drawing.Size(500, 151);
            this.scInputLeft.SplitterWidth = 3;
            // 
            // scInputRight
            // 
            this.scInputRight.Margin = new System.Windows.Forms.Padding(4);
            this.scInputRight.Size = new System.Drawing.Size(25, 151);
            this.scInputRight.SplitterWidth = 5;
            // 
            // scMain
            // 
            this.scMain.Margin = new System.Windows.Forms.Padding(4);
            this.scMain.Size = new System.Drawing.Size(330, 528);
            this.scMain.SplitterDistance = 200;
            this.scMain.SplitterWidth = 5;
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Margin = new System.Windows.Forms.Padding(4);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Size = new System.Drawing.Size(330, 26);
            // 
            // scInputContainer
            // 
            this.scInputContainer.Margin = new System.Windows.Forms.Padding(4);
            this.scInputContainer.Size = new System.Drawing.Size(330, 151);
            this.scInputContainer.SplitterWidth = 5;
            // 
            // btnLog
            // 
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // pnlQuickSearch
            // 
            this.pnlQuickSearch.Size = new System.Drawing.Size(300, 28);
            // 
            // itxt_Name
            // 
            this.itxt_Name.IsBrowseMode = false;
            this.itxt_Name.LabelText = "Name";
            this.itxt_Name.Location = new System.Drawing.Point(4, 8);
            this.itxt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Name.MaxLength = 32767;
            this.itxt_Name.MultiLine = false;
            this.itxt_Name.Name = "itxt_Name";
            this.itxt_Name.PasswordChar = '\0';
            this.itxt_Name.RowCount = 1;
            this.itxt_Name.ShowDeleteButton = false;
            this.itxt_Name.ShowTextboxOnly = false;
            this.itxt_Name.Size = new System.Drawing.Size(239, 41);
            this.itxt_Name.TabIndex = 7;
            this.itxt_Name.ValueText = "";
            // 
            // itxt_Notes
            // 
            this.itxt_Notes.IsBrowseMode = false;
            this.itxt_Notes.LabelText = "Notes";
            this.itxt_Notes.Location = new System.Drawing.Point(4, 49);
            this.itxt_Notes.Margin = new System.Windows.Forms.Padding(4);
            this.itxt_Notes.MaxLength = 32767;
            this.itxt_Notes.MultiLine = true;
            this.itxt_Notes.Name = "itxt_Notes";
            this.itxt_Notes.PasswordChar = '\0';
            this.itxt_Notes.RowCount = 4;
            this.itxt_Notes.ShowDeleteButton = false;
            this.itxt_Notes.ShowTextboxOnly = false;
            this.itxt_Notes.Size = new System.Drawing.Size(237, 86);
            this.itxt_Notes.TabIndex = 4;
            this.itxt_Notes.ValueText = "";
            // 
            // MasterData_v1_AttendanceStatuses_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 528);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MasterData_v1_AttendanceStatuses_Form";
            this.Text = "ATTENDANCE STATUS";
            this.panel1.ResumeLayout(false);
            this.pnlActionButtons.ResumeLayout(false);
            this.scInputLeft.Panel1.ResumeLayout(false);
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
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Name;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Notes;

    }
}