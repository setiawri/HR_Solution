namespace HR_Desktop
{
    partial class Main_Form
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
            this.menu_reports = new System.Windows.Forms.ToolStripMenuItem();
            this.reports_timesheets = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlShortcuts = new System.Windows.Forms.Panel();
            this.gbShortcuts = new System.Windows.Forms.GroupBox();
            this.flpShortcuts = new System.Windows.Forms.FlowLayoutPanel();
            this.lnkUserAccounts = new System.Windows.Forms.LinkLabel();
            this.pnlMDIChildren = new System.Windows.Forms.Panel();
            this.expandCollapseToggle1 = new LIBUtil.Desktop.UserControls.PanelToggle();
            this.account_password = new System.Windows.Forms.ToolStripMenuItem();
            this.account_info = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.menu_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_useraccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_clients = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_workshiftcategories = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_workshifttemplates = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_workshifts = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_attendance_statuses = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_userprofile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_account = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlShortcuts.SuspendLayout();
            this.gbShortcuts.SuspendLayout();
            this.flpShortcuts.SuspendLayout();
            this.pnlMDIChildren.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_reports
            // 
            this.menu_reports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reports_timesheets});
            this.menu_reports.Name = "menu_reports";
            this.menu_reports.Size = new System.Drawing.Size(72, 24);
            this.menu_reports.Text = "Reports";
            // 
            // reports_timesheets
            // 
            this.reports_timesheets.Name = "reports_timesheets";
            this.reports_timesheets.Size = new System.Drawing.Size(158, 26);
            this.reports_timesheets.Text = "Timesheets";
            this.reports_timesheets.Click += new System.EventHandler(this.reports_timesheets_Click);
            // 
            // pnlShortcuts
            // 
            this.pnlShortcuts.BackColor = System.Drawing.Color.White;
            this.pnlShortcuts.Controls.Add(this.gbShortcuts);
            this.pnlShortcuts.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlShortcuts.Location = new System.Drawing.Point(0, 28);
            this.pnlShortcuts.Margin = new System.Windows.Forms.Padding(4);
            this.pnlShortcuts.Name = "pnlShortcuts";
            this.pnlShortcuts.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlShortcuts.Size = new System.Drawing.Size(193, 526);
            this.pnlShortcuts.TabIndex = 21;
            // 
            // gbShortcuts
            // 
            this.gbShortcuts.AutoSize = true;
            this.gbShortcuts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbShortcuts.Controls.Add(this.flpShortcuts);
            this.gbShortcuts.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbShortcuts.Location = new System.Drawing.Point(7, 6);
            this.gbShortcuts.Margin = new System.Windows.Forms.Padding(4);
            this.gbShortcuts.Name = "gbShortcuts";
            this.gbShortcuts.Padding = new System.Windows.Forms.Padding(4);
            this.gbShortcuts.Size = new System.Drawing.Size(179, 64);
            this.gbShortcuts.TabIndex = 14;
            this.gbShortcuts.TabStop = false;
            this.gbShortcuts.Text = "Shortcuts";
            // 
            // flpShortcuts
            // 
            this.flpShortcuts.AutoSize = true;
            this.flpShortcuts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpShortcuts.Controls.Add(this.lnkUserAccounts);
            this.flpShortcuts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpShortcuts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpShortcuts.Location = new System.Drawing.Point(4, 19);
            this.flpShortcuts.Margin = new System.Windows.Forms.Padding(4);
            this.flpShortcuts.Name = "flpShortcuts";
            this.flpShortcuts.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.flpShortcuts.Size = new System.Drawing.Size(171, 41);
            this.flpShortcuts.TabIndex = 17;
            // 
            // lnkUserAccounts
            // 
            this.lnkUserAccounts.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.lnkUserAccounts.AutoSize = true;
            this.lnkUserAccounts.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lnkUserAccounts.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkUserAccounts.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.lnkUserAccounts.Location = new System.Drawing.Point(4, 6);
            this.lnkUserAccounts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkUserAccounts.Name = "lnkUserAccounts";
            this.lnkUserAccounts.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lnkUserAccounts.Size = new System.Drawing.Size(100, 29);
            this.lnkUserAccounts.TabIndex = 25;
            this.lnkUserAccounts.TabStop = true;
            this.lnkUserAccounts.Text = "User Accounts";
            this.lnkUserAccounts.VisitedLinkColor = System.Drawing.Color.CornflowerBlue;
            this.lnkUserAccounts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUserAccounts_LinkClicked);
            // 
            // pnlMDIChildren
            // 
            this.pnlMDIChildren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlMDIChildren.Controls.Add(this.expandCollapseToggle1);
            this.pnlMDIChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMDIChildren.Location = new System.Drawing.Point(193, 28);
            this.pnlMDIChildren.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMDIChildren.Name = "pnlMDIChildren";
            this.pnlMDIChildren.Size = new System.Drawing.Size(874, 526);
            this.pnlMDIChildren.TabIndex = 22;
            // 
            // expandCollapseToggle1
            // 
            this.expandCollapseToggle1.InitialArrowDirection = System.Windows.Forms.ArrowDirection.Left;
            this.expandCollapseToggle1.Location = new System.Drawing.Point(0, 0);
            this.expandCollapseToggle1.Margin = new System.Windows.Forms.Padding(5);
            this.expandCollapseToggle1.Name = "expandCollapseToggle1";
            this.expandCollapseToggle1.Size = new System.Drawing.Size(27, 25);
            this.expandCollapseToggle1.TabIndex = 17;
            this.expandCollapseToggle1.TogglePanel = this.pnlShortcuts;
            // 
            // account_password
            // 
            this.account_password.Name = "account_password";
            this.account_password.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.account_password.Size = new System.Drawing.Size(191, 26);
            this.account_password.Text = "Password";
            // 
            // account_info
            // 
            this.account_info.Name = "account_info";
            this.account_info.Size = new System.Drawing.Size(191, 26);
            this.account_info.Text = "Info";
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_admin,
            this.menu_account,
            this.menu_reports});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(1067, 28);
            this.msMain.TabIndex = 20;
            this.msMain.Text = "menuStrip1";
            // 
            // menu_admin
            // 
            this.menu_admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admin_useraccounts,
            this.admin_clients,
            this.admin_workshiftcategories,
            this.admin_workshifttemplates,
            this.admin_workshifts,
            this.admin_attendance_statuses,
            this.admin_userprofile});
            this.menu_admin.Name = "menu_admin";
            this.menu_admin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.menu_admin.Size = new System.Drawing.Size(65, 24);
            this.menu_admin.Text = "Admin";
            // 
            // admin_useraccounts
            // 
            this.admin_useraccounts.Name = "admin_useraccounts";
            this.admin_useraccounts.Size = new System.Drawing.Size(221, 26);
            this.admin_useraccounts.Text = "User Accounts";
            this.admin_useraccounts.Click += new System.EventHandler(this.admin_useraccounts_Click);
            // 
            // admin_clients
            // 
            this.admin_clients.Name = "admin_clients";
            this.admin_clients.Size = new System.Drawing.Size(221, 26);
            this.admin_clients.Text = "Clients";
            this.admin_clients.Click += new System.EventHandler(this.admin_clients_Click);
            // 
            // admin_workshiftcategories
            // 
            this.admin_workshiftcategories.Name = "admin_workshiftcategories";
            this.admin_workshiftcategories.Size = new System.Drawing.Size(221, 26);
            this.admin_workshiftcategories.Text = "Workshift Categories";
            this.admin_workshiftcategories.Click += new System.EventHandler(this.admin_workshiftcategories_Click);
            // 
            // admin_workshifttemplates
            // 
            this.admin_workshifttemplates.Name = "admin_workshifttemplates";
            this.admin_workshifttemplates.Size = new System.Drawing.Size(221, 26);
            this.admin_workshifttemplates.Text = "Workshift Templates";
            this.admin_workshifttemplates.Click += new System.EventHandler(this.admin_workshifttemplates_Click);
            // 
            // admin_workshifts
            // 
            this.admin_workshifts.Name = "admin_workshifts";
            this.admin_workshifts.Size = new System.Drawing.Size(221, 26);
            this.admin_workshifts.Text = "Workshifts";
            this.admin_workshifts.Click += new System.EventHandler(this.admin_workshifts_Click);
            // 
            // admin_attendance_statuses
            // 
            this.admin_attendance_statuses.Name = "admin_attendance_statuses";
            this.admin_attendance_statuses.Size = new System.Drawing.Size(221, 26);
            this.admin_attendance_statuses.Text = "Attendance Statuses";
            this.admin_attendance_statuses.Click += new System.EventHandler(this.admin_attendance_statuses_Click);
            // 
            // admin_userprofile
            // 
            this.admin_userprofile.Name = "admin_userprofile";
            this.admin_userprofile.Size = new System.Drawing.Size(221, 26);
            this.admin_userprofile.Text = "User Account Profile";
            this.admin_userprofile.Click += new System.EventHandler(this.admin_userprofile_Click);
            // 
            // menu_account
            // 
            this.menu_account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.account_password,
            this.account_info});
            this.menu_account.Name = "menu_account";
            this.menu_account.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.menu_account.Size = new System.Drawing.Size(75, 24);
            this.menu_account.Text = "Account";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlMDIChildren);
            this.Controls.Add(this.pnlShortcuts);
            this.Controls.Add(this.msMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LUCKY STAR SECURITY";
            this.Load += new System.EventHandler(this.Form_Load);
            this.pnlShortcuts.ResumeLayout(false);
            this.pnlShortcuts.PerformLayout();
            this.gbShortcuts.ResumeLayout(false);
            this.gbShortcuts.PerformLayout();
            this.flpShortcuts.ResumeLayout(false);
            this.flpShortcuts.PerformLayout();
            this.pnlMDIChildren.ResumeLayout(false);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menu_reports;
        private LIBUtil.Desktop.UserControls.PanelToggle expandCollapseToggle1;
        private System.Windows.Forms.Panel pnlShortcuts;
        private System.Windows.Forms.GroupBox gbShortcuts;
        private System.Windows.Forms.FlowLayoutPanel flpShortcuts;
        private System.Windows.Forms.LinkLabel lnkUserAccounts;
        private System.Windows.Forms.Panel pnlMDIChildren;
        private System.Windows.Forms.ToolStripMenuItem account_password;
        private System.Windows.Forms.ToolStripMenuItem account_info;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem menu_admin;
        private System.Windows.Forms.ToolStripMenuItem admin_useraccounts;
        private System.Windows.Forms.ToolStripMenuItem menu_account;
        private System.Windows.Forms.ToolStripMenuItem admin_workshiftcategories;
        private System.Windows.Forms.ToolStripMenuItem admin_clients;
        private System.Windows.Forms.ToolStripMenuItem admin_workshifts;
        private System.Windows.Forms.ToolStripMenuItem reports_timesheets;
        private System.Windows.Forms.ToolStripMenuItem admin_attendance_statuses;
        private System.Windows.Forms.ToolStripMenuItem admin_workshifttemplates;
        private System.Windows.Forms.ToolStripMenuItem admin_userprofile;
    }
}