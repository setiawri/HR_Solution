using System;
using System.Drawing;
using System.Windows.Forms;

namespace HR_Desktop
{
    public partial class Main_Form : Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Main_Form()
        {
            InitializeComponent();
        }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            LIBUtil.Util.setAsMDIParent(this, pnlMDIChildren);
            this.ShowIcon = false;

            this.Text += " (" + LOGIN.UserAccount.LoggedInAccount.Fullname + ")";

            setupControlsBasedOnRoles();
        }

        private void setupControlsBasedOnRoles()
        {
            LIBUtil.Util.setAvailability(menu_admin);
            
            LIBUtil.Util.setAvailability(menu_reports);
        }

        private void populateData()
        {

        }

        private void resetData()
        {

        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        private void Form_Load(object sender, EventArgs e)
        {
            setupControls();
            populateData();
            //setSkin();

            //var form = new UserAccounts.UserAccounts_ScheduleTimetable_Form();
            //LIBUtil.Util.displayMDIChild(form);
        }

        private void setSkin()
        {
            msMain.BackColor = Color.Black;
            foreach (ToolStripMenuItem menuitem in msMain.Items)
            {
                menuitem.ForeColor = Color.White;
                foreach (ToolStripItem item in menuitem.DropDownItems)
                {
                    item.BackColor = Color.Black;
                    item.ForeColor = Color.White;
                }
            }
        }

        private void admin_useraccounts_Click(object sender, EventArgs e)
        {
            LIBUtil.Util.displayMDIChild(new LOGIN.MasterData_v1_UserAccounts_Form());
        }

        private void lnkUserAccounts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LIBUtil.Util.displayMDIChild(new LOGIN.MasterData_v1_UserAccounts_Form());
        }


        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }

}
