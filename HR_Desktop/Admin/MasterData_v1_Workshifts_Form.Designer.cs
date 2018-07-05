namespace HR_Desktop.Admin
{
    partial class MasterData_v1_Workshifts_Form
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.iddl_DayOfWeek = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
            this.iddl_Start = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
            this.iddl_End = new LIBUtil.Desktop.UserControls.InputControl_Dropdownlist();
            this.itxt_Notes = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Clients = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_WorkshiftCategories = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
            this.itxt_Name = new LIBUtil.Desktop.UserControls.InputControl_Textbox();
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
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(685, 34);
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.Location = new System.Drawing.Point(0, 252);
            this.pnlActionButtons.Margin = new System.Windows.Forms.Padding(5);
            this.pnlActionButtons.Size = new System.Drawing.Size(685, 28);
            // 
            // scInputLeft
            // 
            this.scInputLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // scInputLeft.Panel1
            // 
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Name);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_WorkshiftCategories);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Clients);
            this.scInputLeft.Panel1.Controls.Add(this.iddl_End);
            this.scInputLeft.Panel1.Controls.Add(this.iddl_Start);
            this.scInputLeft.Panel1.Controls.Add(this.iddl_DayOfWeek);
            this.scInputLeft.Panel1.Controls.Add(this.itxt_Notes);
            this.scInputLeft.Size = new System.Drawing.Size(500, 220);
            this.scInputLeft.SplitterWidth = 4;
            // 
            // scInputRight
            // 
            this.scInputRight.Margin = new System.Windows.Forms.Padding(5);
            this.scInputRight.Size = new System.Drawing.Size(178, 220);
            this.scInputRight.SplitterWidth = 7;
            // 
            // scMain
            // 
            this.scMain.Margin = new System.Windows.Forms.Padding(5);
            this.scMain.Size = new System.Drawing.Size(685, 750);
            this.scMain.SplitterDistance = 280;
            this.scMain.SplitterWidth = 6;
            // 
            // txtQuickSearch
            // 
            this.txtQuickSearch.Margin = new System.Windows.Forms.Padding(5);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(5);
            this.pnlButtons.Size = new System.Drawing.Size(685, 32);
            this.pnlButtons.Controls.SetChildIndex(this.btnSearch, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnUpdate, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnLog, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnAdd, 0);
            this.pnlButtons.Controls.SetChildIndex(this.btnDelete, 0);
            // 
            // scInputContainer
            // 
            this.scInputContainer.Margin = new System.Windows.Forms.Padding(5);
            this.scInputContainer.Size = new System.Drawing.Size(685, 220);
            this.scInputContainer.SplitterWidth = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(403, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // iddl_DayOfWeek
            // 
            this.iddl_DayOfWeek.DisableTextInput = false;
            this.iddl_DayOfWeek.HideFilter = true;
            this.iddl_DayOfWeek.HideUpdateLink = true;
            this.iddl_DayOfWeek.LabelText = "*Day";
            this.iddl_DayOfWeek.Location = new System.Drawing.Point(8, 150);
            this.iddl_DayOfWeek.Margin = new System.Windows.Forms.Padding(5);
            this.iddl_DayOfWeek.Name = "iddl_DayOfWeek";
            this.iddl_DayOfWeek.SelectedItem = null;
            this.iddl_DayOfWeek.SelectedValue = null;
            this.iddl_DayOfWeek.ShowDropdownlistOnly = false;
            this.iddl_DayOfWeek.Size = new System.Drawing.Size(116, 50);
            this.iddl_DayOfWeek.TabIndex = 0;
            // 
            // iddl_Start
            // 
            this.iddl_Start.DisableTextInput = false;
            this.iddl_Start.HideFilter = true;
            this.iddl_Start.HideUpdateLink = true;
            this.iddl_Start.LabelText = "*Start";
            this.iddl_Start.Location = new System.Drawing.Point(129, 150);
            this.iddl_Start.Margin = new System.Windows.Forms.Padding(5);
            this.iddl_Start.Name = "iddl_Start";
            this.iddl_Start.SelectedItem = null;
            this.iddl_Start.SelectedValue = null;
            this.iddl_Start.ShowDropdownlistOnly = false;
            this.iddl_Start.Size = new System.Drawing.Size(88, 50);
            this.iddl_Start.TabIndex = 5;
            // 
            // iddl_End
            // 
            this.iddl_End.DisableTextInput = false;
            this.iddl_End.HideFilter = true;
            this.iddl_End.HideUpdateLink = true;
            this.iddl_End.LabelText = "End";
            this.iddl_End.Location = new System.Drawing.Point(225, 150);
            this.iddl_End.Margin = new System.Windows.Forms.Padding(5);
            this.iddl_End.Name = "iddl_End";
            this.iddl_End.SelectedItem = null;
            this.iddl_End.SelectedValue = null;
            this.iddl_End.ShowDropdownlistOnly = false;
            this.iddl_End.Size = new System.Drawing.Size(99, 50);
            this.iddl_End.TabIndex = 6;
            // 
            // itxt_Notes
            // 
            this.itxt_Notes.AllowDecimal = true;
            this.itxt_Notes.AllowNegativeValue = true;
            this.itxt_Notes.IsBrowseMode = false;
            this.itxt_Notes.LabelText = "Notes";
            this.itxt_Notes.Location = new System.Drawing.Point(8, 201);
            this.itxt_Notes.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Notes.MaxLength = 32767;
            this.itxt_Notes.MultiLine = true;
            this.itxt_Notes.Name = "itxt_Notes";
            this.itxt_Notes.PasswordChar = '\0';
            this.itxt_Notes.RowCount = 5;
            this.itxt_Notes.ShowDeleteButton = false;
            this.itxt_Notes.ShowInNumeric = false;
            this.itxt_Notes.ShowTextboxOnly = false;
            this.itxt_Notes.Size = new System.Drawing.Size(316, 81);
            this.itxt_Notes.TabIndex = 4;
            this.itxt_Notes.ValueText = "";
            // 
            // itxt_Clients
            // 
            this.itxt_Clients.AllowDecimal = true;
            this.itxt_Clients.AllowNegativeValue = true;
            this.itxt_Clients.IsBrowseMode = true;
            this.itxt_Clients.LabelText = "*Client";
            this.itxt_Clients.Location = new System.Drawing.Point(8, 52);
            this.itxt_Clients.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Clients.MaxLength = 32767;
            this.itxt_Clients.MultiLine = false;
            this.itxt_Clients.Name = "itxt_Clients";
            this.itxt_Clients.PasswordChar = '\0';
            this.itxt_Clients.RowCount = 1;
            this.itxt_Clients.ShowDeleteButton = true;
            this.itxt_Clients.ShowInNumeric = false;
            this.itxt_Clients.ShowTextboxOnly = false;
            this.itxt_Clients.Size = new System.Drawing.Size(319, 50);
            this.itxt_Clients.TabIndex = 7;
            this.itxt_Clients.ValueText = "";
            this.itxt_Clients.isBrowseMode_Clicked += new System.EventHandler(this.itxt_Clients_isBrowseMode_Clicked);
            // 
            // itxt_WorkshiftCategories
            // 
            this.itxt_WorkshiftCategories.AllowDecimal = true;
            this.itxt_WorkshiftCategories.AllowNegativeValue = true;
            this.itxt_WorkshiftCategories.IsBrowseMode = true;
            this.itxt_WorkshiftCategories.LabelText = "Category";
            this.itxt_WorkshiftCategories.Location = new System.Drawing.Point(8, 104);
            this.itxt_WorkshiftCategories.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_WorkshiftCategories.MaxLength = 32767;
            this.itxt_WorkshiftCategories.MultiLine = false;
            this.itxt_WorkshiftCategories.Name = "itxt_WorkshiftCategories";
            this.itxt_WorkshiftCategories.PasswordChar = '\0';
            this.itxt_WorkshiftCategories.RowCount = 1;
            this.itxt_WorkshiftCategories.ShowDeleteButton = true;
            this.itxt_WorkshiftCategories.ShowInNumeric = false;
            this.itxt_WorkshiftCategories.ShowTextboxOnly = false;
            this.itxt_WorkshiftCategories.Size = new System.Drawing.Size(319, 50);
            this.itxt_WorkshiftCategories.TabIndex = 8;
            this.itxt_WorkshiftCategories.ValueText = "";
            this.itxt_WorkshiftCategories.isBrowseMode_Clicked += new System.EventHandler(this.itxt_WorkshiftCategories_isBrowseMode_Clicked);
            // 
            // itxt_Name
            // 
            this.itxt_Name.AllowDecimal = true;
            this.itxt_Name.AllowNegativeValue = true;
            this.itxt_Name.IsBrowseMode = false;
            this.itxt_Name.LabelText = "*Name";
            this.itxt_Name.Location = new System.Drawing.Point(5, 5);
            this.itxt_Name.Margin = new System.Windows.Forms.Padding(5);
            this.itxt_Name.MaxLength = 32767;
            this.itxt_Name.MultiLine = false;
            this.itxt_Name.Name = "itxt_Name";
            this.itxt_Name.PasswordChar = '\0';
            this.itxt_Name.RowCount = 1;
            this.itxt_Name.ShowDeleteButton = false;
            this.itxt_Name.ShowInNumeric = false;
            this.itxt_Name.ShowTextboxOnly = false;
            this.itxt_Name.Size = new System.Drawing.Size(319, 50);
            this.itxt_Name.TabIndex = 9;
            this.itxt_Name.ValueText = "";
            // 
            // MasterData_v1_Workshifts_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 750);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MasterData_v1_Workshifts_Form";
            this.Text = "Workshifts";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
            this.ResumeLayout(false);

        }

        #endregion
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Notes;
        private System.Windows.Forms.Button btnDelete;
        private LIBUtil.Desktop.UserControls.InputControl_Dropdownlist iddl_DayOfWeek;
        private LIBUtil.Desktop.UserControls.InputControl_Dropdownlist iddl_End;
        private LIBUtil.Desktop.UserControls.InputControl_Dropdownlist iddl_Start;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Clients;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_WorkshiftCategories;
        private LIBUtil.Desktop.UserControls.InputControl_Textbox itxt_Name;
    }
}