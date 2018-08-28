namespace HR_Desktop.Admin
{
    partial class MasterData_v1_AttendancePayRates_Form
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
            this.itxt_Ref = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.in_Amount = new LIBUtil.Desktop.UserControls.InputControl_Numeric();
            this.iddl_AttendanceStatuses = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(805, 34);
            // 
            // lnkClearQuickSearch
            // 
            this.lnkClearQuickSearch.TabStop = false;
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Location = new System.Drawing.Point(0, 252);
            this.pnlActionButtons.Margin = new System.Windows.Forms.Padding(5);
            this.pnlActionButtons.Size = new System.Drawing.Size(805, 28);
            // 
            // scInputLeft
            // 
            this.scInputLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // scInputLeft.Panel1
            // 
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Notes);
            this.scInputLeft.Panel1.Controls.Add(this.iddl_AttendanceStatuses);
            this.scInputLeft.Panel1.Controls.Add(this.in_Amount);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Ref);
            this.scInputLeft.Size = new System.Drawing.Size(574, 220);
            this.scInputLeft.SplitterWidth = 4;
            // 
            // scInputRight
            // 
            this.scInputRight.Margin = new System.Windows.Forms.Padding(5);
            this.scInputRight.Size = new System.Drawing.Size(224, 220);
            this.scInputRight.SplitterWidth = 7;
            // 
            // scMain
            // 
            this.scMain.Margin = new System.Windows.Forms.Padding(5);
            this.scMain.Size = new System.Drawing.Size(805, 750);
            this.scMain.SplitterDistance = 280;
            this.scMain.SplitterWidth = 6;
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Margin = new System.Windows.Forms.Padding(5);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(5);
            this.pnlButtons.Size = new System.Drawing.Size(805, 32);
            // 
            // scInputContainer
            // 
            this.scInputContainer.Margin = new System.Windows.Forms.Padding(5);
            this.scInputContainer.Size = new System.Drawing.Size(805, 220);
            this.scInputContainer.SplitterDistance = 574;
            this.scInputContainer.SplitterWidth = 7;
            // 
            // btnLog
            // 
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // pnlQuickSearch
            // 
            this.pnlQuickSearch.Margin = new System.Windows.Forms.Padding(5);
            this.pnlQuickSearch.Size = new System.Drawing.Size(765, 34);
            // 
            // itxt_Notes
            // 
            this.itxt_Notes.IsBrowseMode = false;
            this.itxt_Notes.LabelText = "Notes";
            this.itxt_Notes.Location = new System.Drawing.Point(5, 177);
            this.itxt_Notes.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Notes.MaxLength = 32767;
            this.itxt_Notes.MultiLine = true;
            this.itxt_Notes.Name = "itxt_Notes";
            this.itxt_Notes.PasswordChar = '\0';
            this.itxt_Notes.RowCount = 3;
            this.itxt_Notes.ShowDeleteButton = false;
            this.itxt_Notes.ShowTextboxOnly = false;
            this.itxt_Notes.Size = new System.Drawing.Size(321, 76);
            this.itxt_Notes.TabIndex = 4;
            this.itxt_Notes.ValueText = "";
            // 
            // itxt_Ref
            // 
            this.itxt_Ref.Enabled = false;
            this.itxt_Ref.IsBrowseMode = true;
            this.itxt_Ref.LabelText = "*Tempates / Workshifts";
            this.itxt_Ref.Location = new System.Drawing.Point(5, 10);
            this.itxt_Ref.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Ref.MaxLength = 32767;
            this.itxt_Ref.MultiLine = false;
            this.itxt_Ref.Name = "itxt_Ref";
            this.itxt_Ref.PasswordChar = '\0';
            this.itxt_Ref.RowCount = 1;
            this.itxt_Ref.ShowDeleteButton = false;
            this.itxt_Ref.ShowTextboxOnly = false;
            this.itxt_Ref.Size = new System.Drawing.Size(321, 50);
            this.itxt_Ref.TabIndex = 7;
            this.itxt_Ref.ValueText = "";
            // 
            // in_Amount
            // 
            this.in_Amount.Checked = false;
            this.in_Amount.DecimalPlaces = 0;
            this.in_Amount.HideUpDown = false;
            this.in_Amount.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.in_Amount.LabelText = "Amount";
            this.in_Amount.Location = new System.Drawing.Point(5, 121);
            this.in_Amount.Margin = new System.Windows.Forms.Padding(5);
            this.in_Amount.MaximumValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.in_Amount.MinimumValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.in_Amount.Name = "in_Amount";
            this.in_Amount.ShowAllowDecimalCheckbox = false;
            this.in_Amount.ShowCheckbox = false;
            this.in_Amount.ShowTextboxOnly = false;
            this.in_Amount.Size = new System.Drawing.Size(321, 52);
            this.in_Amount.TabIndex = 10;
            this.in_Amount.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // iddl_AttendanceStatuses
            // 
            this.iddl_AttendanceStatuses.DisableTextInput = false;
            this.iddl_AttendanceStatuses.HideFilter = true;
            this.iddl_AttendanceStatuses.HideUpdateLink = true;
            this.iddl_AttendanceStatuses.LabelText = "*Status";
            this.iddl_AttendanceStatuses.Location = new System.Drawing.Point(5, 66);
            this.iddl_AttendanceStatuses.Margin = new System.Windows.Forms.Padding(5);
            this.iddl_AttendanceStatuses.Name = "iddl_AttendanceStatuses";
            this.iddl_AttendanceStatuses.SelectedItem = null;
            this.iddl_AttendanceStatuses.SelectedItemText = "";
            this.iddl_AttendanceStatuses.SelectedValue = null;
            this.iddl_AttendanceStatuses.ShowDropdownlistOnly = false;
            this.iddl_AttendanceStatuses.Size = new System.Drawing.Size(321, 50);
            this.iddl_AttendanceStatuses.TabIndex = 11;
            // 
            // MasterData_v1_AttendancePayRates_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 750);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MasterData_v1_AttendancePayRates_Form";
            this.Text = "ATTENDANCE PAY RATES";
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
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Notes;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Ref;
        private LIBUtil.Desktop.UserControls.InputControl_Numeric in_Amount;
        private LIBUtil.Desktop.UserControls.InputControl_Dropdownlist iddl_AttendanceStatuses;
    }
}