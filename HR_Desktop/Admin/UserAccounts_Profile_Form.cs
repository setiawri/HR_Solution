using System;
using System.Data;
using System.Windows.Forms;
using HR_Desktop;
using LIBUtil;
using HR_LIB.HR;
using LOGIN;

namespace HR_Desktop.Admin
{
    public partial class UserAccounts_Profile_Form : Form
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

        private Guid? _UserAccounts_Id = null;
        private DayOfWeek _dgvWorkshifts_FilterDayOfWeek;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public UserAccounts_Profile_Form() : this(null) { }
        public UserAccounts_Profile_Form(Guid? id)
        {
            InitializeComponent();
            _UserAccounts_Id = id;
        }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            this.ShowIcon = false;
            setupControlsBasedOnRoles();

            rbWorkshifts_Monday.Checked = true;
            _dgvWorkshifts_FilterDayOfWeek = DayOfWeek.Monday;

            dgvWorkshifts.AutoGenerateColumns = false;
            col_dgvWorkshifts_Id.DataPropertyName = Workshift.COL_DB_Id;
            col_dgvWorkshifts_Client_CompanyName.DataPropertyName = Workshift.COL_Clients_CompanyName;
            col_dgvWorkshifts_Name.DataPropertyName = Workshift.COL_DB_Name;
            col_dgvWorkshifts_Start.DataPropertyName = Workshift.COL_DB_Start;
            col_dgvWorkshifts_Duration.DataPropertyName = Workshift.COL_DB_DurationMinutes;

            dgvBankAccounts.AutoGenerateColumns = false;
            col_dgvBankAccounts_Id.DataPropertyName = BankAccount.COL_DB_Id;
            col_dgvBankAccounts_Name.DataPropertyName = BankAccount.COL_DB_Name;
            col_dgvBankAccounts_BankName.DataPropertyName = BankAccount.COL_DB_BankName;
            col_dgvBankAccounts_AccountNumber.DataPropertyName = BankAccount.COL_DB_AccountNumber;
            col_dgvBankAccounts_Notes.DataPropertyName = BankAccount.COL_DB_Notes;
        }

        private void setupControlsBasedOnRoles()
        {

        }

        private void populateData()
        {
            if (isValidToPopulateData())
            {
                UserAccount user = new UserAccount((Guid)_UserAccounts_Id);
                lbl_Employee_UserAccounts_Name.Text = user.Fullname;
                lblUsername.Text = user.Username;
                lblFirstname.Text = user.Firstname;
                lblLastname.Text = user.Lastname;
                lblIdentification.Text = user.Identification;
                lblBirthday.Text = String.Format("{0:dd/MMM/yyyy}",user.Birthdate);
                lblPhone1.Text = user.Phone1;
                lblPhone2.Text = user.Phone2;
                lblHeight.Text = Convert.ToString(user.Height);
                lblWeight.Text = Convert.ToString(user.Weight);
                lblEmail.Text = user.Email;
                lblAddress1.Text = user.Address1;
                lblAddress2.Text = user.Address2;
                lblNotes.Text = user.Notes;

                populateDgvWorkshifts();
                populateDgvBankAccounts();
            }
        }

        private bool isValidToPopulateData()
        {
            if (_UserAccounts_Id == null)
                return false;
            return true;
        }

        private void resetData()
        {
            
        }

        private void populateDgvWorkshifts()
        {
            Util.populateDataGridView(dgvWorkshifts, Workshift.get(false, null, null, null, _UserAccounts_Id, null, (int)_dgvWorkshifts_FilterDayOfWeek, null, null, null));
        }
        private void populateDgvBankAccounts()
        {
            Util.populateDataGridView(dgvBankAccounts, BankAccount.get(null, null, _UserAccounts_Id, null, null, null));
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        private void Form_Load(object sender, EventArgs e)
        {
            setupControls();
            populateData();
        }
        
        private void lnk_Edit_Workshift_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LIBUtil.Util.displayForm(null, new Admin.MasterData_v1_Workshifts_Form());
        }

        private void rbWorkshifts_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == rbWorkshifts_Monday)
                _dgvWorkshifts_FilterDayOfWeek = DayOfWeek.Monday;
            else if (sender == rbWorkshifts_Tuesday)
                _dgvWorkshifts_FilterDayOfWeek = DayOfWeek.Tuesday;
            else if (sender == rbWorkshifts_Wednesday)
                _dgvWorkshifts_FilterDayOfWeek = DayOfWeek.Wednesday;
            else if (sender == rbWorkshifts_Thursday)
                _dgvWorkshifts_FilterDayOfWeek = DayOfWeek.Thursday;
            else if (sender == rbWorkshifts_Friday)
                _dgvWorkshifts_FilterDayOfWeek = DayOfWeek.Friday;
            else if (sender == rbWorkshifts_Saturday)
                _dgvWorkshifts_FilterDayOfWeek = DayOfWeek.Saturday;
            else if (sender == rbWorkshifts_Sunday)
                _dgvWorkshifts_FilterDayOfWeek = DayOfWeek.Sunday;

            populateDgvWorkshifts();
        }
        

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
