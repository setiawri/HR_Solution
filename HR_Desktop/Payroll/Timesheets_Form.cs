using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Desktop.Payroll
{
    public partial class Timesheets_Form : Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region PROPERTIES

        #endregion PROPERTIES
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Timesheets_Form() : this(null) { }
        public Timesheets_Form(Guid? id) { InitializeComponent(); }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            this.ShowIcon = false;
            setupControlsBasedOnRoles();

            chkFilterEmployeesByClient.Checked = true;
        }

        private void setupControlsBasedOnRoles()
        {

        }

        private void populateData()
        {
            if (isValidToPopulateData())
            {
            }
        }

        private bool isValidToPopulateData()
        {
            return true;
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

        private void chkFilterEmployees_CheckedChanged(object sender, EventArgs e)
        {
            if(sender == chkFilterEmployeesByClient)
                chkFilterEmployeeByName.Checked = !chkFilterEmployeesByClient.Checked;
            else
                chkFilterEmployeesByClient.Checked = !chkFilterEmployeeByName.Checked;

            itxt_FilterEmployee_Client.Enabled = chkFilterEmployeesByClient.Checked;
            idtp_FilterEmployee_StartDate.Enabled = chkFilterEmployeesByClient.Checked;
            idtp_FilterEmployee_EndDate.Enabled = chkFilterEmployeesByClient.Checked;

            itxt_FilterEmployee_UserAccounts_Name.Enabled = chkFilterEmployeeByName.Checked;
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
        }
}
