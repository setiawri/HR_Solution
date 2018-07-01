using System;
using System.Windows.Forms;

using LIBUtil;
using LOGIN;

namespace LOGGING
{
    public partial class ActivityLogs_Form : Form
    {
        private Guid _associatedId;
        private UserAccount _LoggedInUserAccount;

        public ActivityLogs_Form(UserAccount loggedInUserAccount, Guid associatedID)
        {
            InitializeComponent();

            _LoggedInUserAccount = loggedInUserAccount;
            _associatedId = associatedID;

            setupControls();
            populatePageData();
        }

        private void setupControls()
        {
            this.ShowIcon = false;

            //this.Text += Util.appendTitleIfLive();

            dgv.AutoGenerateColumns = false;
            col_dgv_Timestamp.DataPropertyName = ActivityLog.COL_DB_Timestamp;
            col_dgv_Fullname.DataPropertyName = ActivityLog.COL_UserAccounts_Fullname;
            col_dgv_Description.DataPropertyName = ActivityLog.COL_DB_Description;
            Util.setGridviewColumnWordwrap(col_dgv_Description, null);
            col_dgv_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void populatePageData()
        {
            dgv.DataSource = ActivityLog.get(_LoggedInUserAccount.Id, _associatedId);
            dgv.ClearSelection();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            dgv.ClearSelection();
            txtDescription.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Util.sanitize(txtDescription);
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                Util.inputError<TextBox>(txtDescription, "Please provide description");
            }
            else
            {
                ActivityLog.add(_LoggedInUserAccount.Id, _associatedId, txtDescription.Text);
                populatePageData();
                txtDescription.Text = "";
                txtDescription.Focus();
            }
        }

        public static void show(UserAccount loggedInUserAccount, DataGridView grid, DataGridViewColumn column)
        {
            LIBUtil.Util.displayMDIChild(new ActivityLogs_Form(loggedInUserAccount, Util.getSelectedRowID(grid, column)));
        }
    }
}