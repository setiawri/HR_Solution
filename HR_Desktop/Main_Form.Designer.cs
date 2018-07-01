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
            this.menu_reports.Name = "menu_reports";
            this.menu_reports.Size = new System.Drawing.Size(59, 20);
            this.menu_reports.Text = "Reports";
            // 
            // pnlShortcuts
            // 
            this.pnlShortcuts.BackColor = System.Drawing.Color.White;
            this.pnlShortcuts.Controls.Add(this.gbShortcuts);
            this.pnlShortcuts.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlShortcuts.Location = new System.Drawing.Point(0, 24);
            this.pnlShortcuts.Name = "pnlShortcuts";
            this.pnlShortcuts.Padding = new System.Windows.Forms.Padding(5);
            this.pnlShortcuts.Size = new System.Drawing.Size(145, 426);
            this.pnlShortcuts.TabIndex = 21;
            // 
            // gbShortcuts
            // 
            this.gbShortcuts.AutoSize = true;
            this.gbShortcuts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbShortcuts.Controls.Add(this.flpShortcuts);
            this.gbShortcuts.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbShortcuts.Location = new System.Drawing.Point(5, 5);
            this.gbShortcuts.Name = "gbShortcuts";
            this.gbShortcuts.Size = new System.Drawing.Size(135, 52);
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
            this.flpShortcuts.Location = new System.Drawing.Point(3, 16);
            this.flpShortcuts.Name = "flpShortcuts";
            this.flpShortcuts.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.flpShortcuts.Size = new System.Drawing.Size(129, 33);
            this.flpShortcuts.TabIndex = 17;
            // 
            // lnkUserAccounts
            // 
            this.lnkUserAccounts.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.lnkUserAccounts.AutoSize = true;
            this.lnkUserAccounts.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lnkUserAccounts.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkUserAccounts.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.lnkUserAccounts.Location = new System.Drawing.Point(3, 5);
            this.lnkUserAccounts.Name = "lnkUserAccounts";
            this.lnkUserAccounts.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lnkUserAccounts.Size = new System.Drawing.Size(77, 23);
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
            this.pnlMDIChildren.Location = new System.Drawing.Point(145, 24);
            this.pnlMDIChildren.Name = "pnlMDIChildren";
            this.pnlMDIChildren.Size = new System.Drawing.Size(655, 426);
            this.pnlMDIChildren.TabIndex = 22;
            // 
            // expandCollapseToggle1
            // 
            this.expandCollapseToggle1.InitialArrowDirection = System.Windows.Forms.ArrowDirection.Left;
            this.expandCollapseToggle1.Location = new System.Drawing.Point(0, 0);
            this.expandCollapseToggle1.Margin = new System.Windows.Forms.Padding(4);
            this.expandCollapseToggle1.Name = "expandCollapseToggle1";
            this.expandCollapseToggle1.Size = new System.Drawing.Size(20, 20);
            this.expandCollapseToggle1.TabIndex = 17;
            this.expandCollapseToggle1.TogglePanel = this.pnlShortcuts;
            // 
            // account_password
            // 
            this.account_password.Name = "account_password";
            this.account_password.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.account_password.Size = new System.Drawing.Size(161, 22);
            this.account_password.Text = "Password";
            // 
            // account_info
            // 
            this.account_info.Name = "account_info";
            this.account_info.Size = new System.Drawing.Size(161, 22);
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
            this.msMain.Size = new System.Drawing.Size(800, 24);
            this.msMain.TabIndex = 20;
            this.msMain.Text = "menuStrip1";
            // 
            // menu_admin
            // 
            this.menu_admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admin_useraccounts});
            this.menu_admin.Name = "menu_admin";
            this.menu_admin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.menu_admin.Size = new System.Drawing.Size(55, 20);
            this.menu_admin.Text = "Admin";
            // 
            // admin_useraccounts
            // 
            this.admin_useraccounts.Name = "admin_useraccounts";
            this.admin_useraccounts.Size = new System.Drawing.Size(150, 22);
            this.admin_useraccounts.Text = "User Accounts";
            this.admin_useraccounts.Click += new System.EventHandler(this.admin_useraccounts_Click);
            // 
            // menu_account
            // 
            this.menu_account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.account_password,
            this.account_info});
            this.menu_account.Name = "menu_account";
            this.menu_account.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.menu_account.Size = new System.Drawing.Size(64, 20);
            this.menu_account.Text = "Account";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMDIChildren);
            this.Controls.Add(this.pnlShortcuts);
            this.Controls.Add(this.msMain);
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
    }
}