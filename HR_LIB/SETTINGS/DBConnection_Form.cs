using System;
using System.Data;
using System.Windows.Forms;

namespace SETTINGS
{
    public partial class DBConnection_Form : Form
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

        public DBConnection_Form() : this(null) { }
        public DBConnection_Form(Guid? id) { InitializeComponent(); }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            setupControlsBasedOnRoles();
        }

        private void setupControlsBasedOnRoles()
        {

        }

        private void populateData()
        {
            itxt_ServerName.ValueText = LIBUtil.DBConnection.ServerName;
            itxt_DatabaseName.ValueText = LIBUtil.DBConnection.DatabaseName;
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
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            LIBUtil.DBConnection.update(itxt_ServerName, itxt_DatabaseName);
            if (HR_LIB.Helper.isDBConnectionAvailable())
            {
                LIBUtil.Util.displayMessageBoxSuccess("Connection successful");
                this.Close();
            }
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
