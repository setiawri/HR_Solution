﻿namespace HR_Desktop
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
            this.reports_payrolls = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_payments = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlShortcuts = new System.Windows.Forms.Panel();
            this.gbShortcuts = new System.Windows.Forms.GroupBox();
            this.flpShortcuts = new System.Windows.Forms.FlowLayoutPanel();
            this.lnkUserAccounts = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lnk_Timesheets = new System.Windows.Forms.LinkLabel();
            this.account_password = new System.Windows.Forms.ToolStripMenuItem();
            this.account_info = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.menu_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_useraccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_clients = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_workshiftcategories = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_workshifttemplates = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_workshifts = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_attendances = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_attendance_statuses = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_bankaccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_holidayschedules = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_account = new System.Windows.Forms.ToolStripMenuItem();
            this.expandCollapseToggle1 = new LIBUtil.Desktop.UserControls.PanelToggle();
            this.admin_attendance_pay_rates = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlShortcuts.SuspendLayout();
            this.gbShortcuts.SuspendLayout();
            this.flpShortcuts.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_reports
            // 
            this.menu_reports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reports_timesheets,
            this.reports_payrolls,
            this.menu_payments});
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
            // reports_payrolls
            // 
            this.reports_payrolls.Name = "reports_payrolls";
            this.reports_payrolls.Size = new System.Drawing.Size(158, 26);
            this.reports_payrolls.Text = "Payrolls";
            this.reports_payrolls.Click += new System.EventHandler(this.reports_payrolls_Click);
            // 
            // menu_payments
            // 
            this.menu_payments.Name = "menu_payments";
            this.menu_payments.Size = new System.Drawing.Size(158, 26);
            this.menu_payments.Text = "Payments";
            this.menu_payments.Click += new System.EventHandler(this.menu_payments_Click);
            // 
            // pnlShortcuts
            // 
            this.pnlShortcuts.BackColor = System.Drawing.Color.White;
            this.pnlShortcuts.Controls.Add(this.gbShortcuts);
            this.pnlShortcuts.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlShortcuts.Location = new System.Drawing.Point(0, 28);
            this.pnlShortcuts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.gbShortcuts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbShortcuts.Name = "gbShortcuts";
            this.gbShortcuts.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbShortcuts.Size = new System.Drawing.Size(179, 113);
            this.gbShortcuts.TabIndex = 14;
            this.gbShortcuts.TabStop = false;
            this.gbShortcuts.Text = "Shortcuts";
            // 
            // flpShortcuts
            // 
            this.flpShortcuts.AutoSize = true;
            this.flpShortcuts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpShortcuts.Controls.Add(this.lnkUserAccounts);
            this.flpShortcuts.Controls.Add(this.flowLayoutPanel1);
            this.flpShortcuts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpShortcuts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpShortcuts.Location = new System.Drawing.Point(4, 19);
            this.flpShortcuts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpShortcuts.Name = "flpShortcuts";
            this.flpShortcuts.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.flpShortcuts.Size = new System.Drawing.Size(171, 90);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.lnk_Timesheets);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 39);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(100, 41);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // lnk_Timesheets
            // 
            this.lnk_Timesheets.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.lnk_Timesheets.AutoSize = true;
            this.lnk_Timesheets.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lnk_Timesheets.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnk_Timesheets.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.lnk_Timesheets.Location = new System.Drawing.Point(4, 6);
            this.lnk_Timesheets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnk_Timesheets.Name = "lnk_Timesheets";
            this.lnk_Timesheets.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lnk_Timesheets.Size = new System.Drawing.Size(81, 29);
            this.lnk_Timesheets.TabIndex = 25;
            this.lnk_Timesheets.TabStop = true;
            this.lnk_Timesheets.Text = "Timesheets";
            this.lnk_Timesheets.VisitedLinkColor = System.Drawing.Color.CornflowerBlue;
            this.lnk_Timesheets.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_Timesheets_LinkClicked);
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
            this.admin_attendances,
            this.admin_attendance_statuses,
            this.admin_attendance_pay_rates,
            this.admin_bankaccounts,
            this.admin_holidayschedules});
            this.menu_admin.Name = "menu_admin";
            this.menu_admin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.menu_admin.Size = new System.Drawing.Size(65, 24);
            this.menu_admin.Text = "Admin";
            // 
            // admin_useraccounts
            // 
            this.admin_useraccounts.Name = "admin_useraccounts";
            this.admin_useraccounts.Size = new System.Drawing.Size(226, 26);
            this.admin_useraccounts.Text = "User Accounts";
            this.admin_useraccounts.Click += new System.EventHandler(this.admin_useraccounts_Click);
            // 
            // admin_clients
            // 
            this.admin_clients.Name = "admin_clients";
            this.admin_clients.Size = new System.Drawing.Size(226, 26);
            this.admin_clients.Text = "Clients";
            this.admin_clients.Click += new System.EventHandler(this.admin_clients_Click);
            // 
            // admin_workshiftcategories
            // 
            this.admin_workshiftcategories.Name = "admin_workshiftcategories";
            this.admin_workshiftcategories.Size = new System.Drawing.Size(226, 26);
            this.admin_workshiftcategories.Text = "Workshift Categories";
            this.admin_workshiftcategories.Click += new System.EventHandler(this.admin_workshiftcategories_Click);
            // 
            // admin_workshifttemplates
            // 
            this.admin_workshifttemplates.Name = "admin_workshifttemplates";
            this.admin_workshifttemplates.Size = new System.Drawing.Size(226, 26);
            this.admin_workshifttemplates.Text = "Workshift Templates";
            this.admin_workshifttemplates.Click += new System.EventHandler(this.admin_workshifttemplates_Click);
            // 
            // admin_workshifts
            // 
            this.admin_workshifts.Name = "admin_workshifts";
            this.admin_workshifts.Size = new System.Drawing.Size(226, 26);
            this.admin_workshifts.Text = "Workshifts";
            this.admin_workshifts.Click += new System.EventHandler(this.admin_workshifts_Click);
            // 
            // admin_attendances
            // 
            this.admin_attendances.Name = "admin_attendances";
            this.admin_attendances.Size = new System.Drawing.Size(226, 26);
            this.admin_attendances.Text = "Attendances";
            this.admin_attendances.Click += new System.EventHandler(this.admin_attendances_Click);
            // 
            // admin_attendance_statuses
            // 
            this.admin_attendance_statuses.Name = "admin_attendance_statuses";
            this.admin_attendance_statuses.Size = new System.Drawing.Size(226, 26);
            this.admin_attendance_statuses.Text = "Attendance Statuses";
            this.admin_attendance_statuses.Click += new System.EventHandler(this.admin_attendance_statuses_Click);
            // 
            // admin_bankaccounts
            // 
            this.admin_bankaccounts.Name = "admin_bankaccounts";
            this.admin_bankaccounts.Size = new System.Drawing.Size(226, 26);
            this.admin_bankaccounts.Text = "Bank Accounts";
            this.admin_bankaccounts.Click += new System.EventHandler(this.admin_bankaccounts_Click);
            // 
            // admin_holidayschedules
            // 
            this.admin_holidayschedules.Name = "admin_holidayschedules";
            this.admin_holidayschedules.Size = new System.Drawing.Size(226, 26);
            this.admin_holidayschedules.Text = "Holiday Schedules";
            this.admin_holidayschedules.Click += new System.EventHandler(this.admin_holidayschedules_Click);
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
            // expandCollapseToggle1
            // 
            this.expandCollapseToggle1.AdjustLocationOnClick = true;
            this.expandCollapseToggle1.InitialArrowDirection = System.Windows.Forms.ArrowDirection.Left;
            this.expandCollapseToggle1.Location = new System.Drawing.Point(193, 30);
            this.expandCollapseToggle1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.expandCollapseToggle1.Name = "expandCollapseToggle1";
            this.expandCollapseToggle1.Size = new System.Drawing.Size(27, 25);
            this.expandCollapseToggle1.TabIndex = 17;
            this.expandCollapseToggle1.TogglePanel = this.pnlShortcuts;
            // 
            // admin_attendance_pay_rates
            // 
            this.admin_attendance_pay_rates.Name = "admin_attendance_pay_rates";
            this.admin_attendance_pay_rates.Size = new System.Drawing.Size(226, 26);
            this.admin_attendance_pay_rates.Text = "Attendance Pay Rates";
            this.admin_attendance_pay_rates.Click += new System.EventHandler(this.admin_attendance_pay_rates_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.expandCollapseToggle1);
            this.Controls.Add(this.pnlShortcuts);
            this.Controls.Add(this.msMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menu_reports;
        private System.Windows.Forms.Panel pnlShortcuts;
        private System.Windows.Forms.GroupBox gbShortcuts;
        private System.Windows.Forms.FlowLayoutPanel flpShortcuts;
        private System.Windows.Forms.LinkLabel lnkUserAccounts;
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
        private System.Windows.Forms.ToolStripMenuItem admin_bankaccounts;
        private System.Windows.Forms.ToolStripMenuItem admin_holidayschedules;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel lnk_Timesheets;
        private LIBUtil.Desktop.UserControls.PanelToggle expandCollapseToggle1;
        private System.Windows.Forms.ToolStripMenuItem reports_payrolls;
        private System.Windows.Forms.ToolStripMenuItem menu_payments;
        private System.Windows.Forms.ToolStripMenuItem admin_attendances;
        private System.Windows.Forms.ToolStripMenuItem admin_attendance_pay_rates;
    }
}