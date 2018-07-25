using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LIBUtil;

namespace LOGIN
{
    public partial class UserAccounts_Update_Password_Form : Form
    {        
        /*******************************************************************************************************/
        #region SETTINGS

        private const string FORMTITLE = "PASSWORD UPDATE";

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        UserAccount _UserAccount;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public UserAccounts_Update_Password_Form(UserAccount userAccount)
        {
            InitializeComponent();

            _UserAccount = userAccount;
			setupControls();
        }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            this.ShowIcon = false;
            this.Text = FORMTITLE;
			setupControlsBasedOnRoles();
        }

		private void setupControlsBasedOnRoles() 
		{

		}
		
        private void populateData()
        {

        }

		private void resetData()
		{
            txtCurrentPassword.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
		}

        private bool isInputValid()
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text) || !UserAccount.isPasswordMatch(_UserAccount.Username, txtCurrentPassword.Text))
                return Util.inputError<TextBox>(txtCurrentPassword, "Invalid Current Password");
            else if (string.IsNullOrWhiteSpace(txtNewPassword.Text) || !UserAccount.isValidNewPassword(txtNewPassword.Text))
                return Util.inputError<TextBox>(txtNewPassword, UserAccount.INVALIDPASSWORDERROR);
            else if (txtConfirmPassword.Text != txtNewPassword.Text)
                return Util.inputError<TextBox>(txtConfirmPassword, "Invalid Confirm Password");

            return true;
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        private void Form_Load(object sender, EventArgs e)
        {
            setupControls();
            populateData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isInputValid())
            {
                if (UserAccount.updatePassword(UserAccount.LoggedInAccount.Id, _UserAccount.Id, txtNewPassword.Text))
                    this.Close();
                else
                    resetData();
            }
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
