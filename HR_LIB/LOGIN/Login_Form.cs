using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace LOGIN
{
    public partial class Login_Form : Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public bool isAuthenticated = false;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Login_Form()
        {
            InitializeComponent();
        }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            this.ShowIcon = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.AcceptButton = btnSubmit;
            LIBUtil.Util.disableFormResize(this);
            itxt_Username.MaxLength = 20;
            itxt_Password.MaxLength = 20;
        }

        private void populateData()
        {
        }

        private void resetData()
        {
            itxt_Password.ValueText = string.Empty;
            itxt_Password.Focus();
        }

        private void authenticate()
        {
            UserAccount.LoggedInAccount = UserAccount.authenticate(itxt_Username.ValueText, itxt_Password.ValueText);
            if(UserAccount.LoggedInAccount != null)
            {
                isAuthenticated = true;
                this.Close();
            }
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        private void Form_Load(object sender, EventArgs e)
        {
            setupControls();
            populateData();

            //bypass login
            if(Environment.MachineName == "RQ-ASUS101")
            {
                itxt_Username.ValueText = "ricky";
                itxt_Password.ValueText = HR_LIB.Settings.TEMPORARY_PASSWORD;
                btnSubmit.Focus();
            }
            else if (Environment.MachineName == "LAPTOP-OOO4UR6V")
            {
                itxt_Username.ValueText = "chintia";
                itxt_Password.ValueText = HR_LIB.Settings.TEMPORARY_PASSWORD;
                btnSubmit.Focus();
            }
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            itxt_Username.focus();
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (itxt_Password.ValueText == HR_LIB.Settings.PASSWORD_OPENSETTINGSFORM || !HR_LIB.Helper.isDBConnectionAvailable())
                LIBUtil.Util.displayForm(this, new SETTINGS.DBConnection_Form());
            else
                authenticate();
        }
        
        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
