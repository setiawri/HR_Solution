using System;
using System.Data;
using System.Windows.Forms;
using HR_LIB.HR;
using LIBUtil;
using LOGIN;

namespace HR_Desktop.Admin
{
    public partial class Clients_Profile_Form : Form
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

        private Guid? _Clients_Id =  null;
        private DayOfWeek _dgvWorkshifts_FilterDayOfWeek;
        private DayOfWeek _dgvWorkshiftTemplates_FilterDayOfWeek;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Clients_Profile_Form() : this(null) { }
        public Clients_Profile_Form(Guid? id)
        {
            InitializeComponent();
            if (id != null)
                _Clients_Id = id;
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
            rbWorkshiftTemplates_Monday.Checked = true;
            _dgvWorkshiftTemplates_FilterDayOfWeek = DayOfWeek.Monday;

            dgvWorkshifts.AutoGenerateColumns = false;
            col_dgvWorkshifts_Id.DataPropertyName = Workshift.COL_DB_Id;
            col_dgvWorkshifts_Name.DataPropertyName = Workshift.COL_DB_Name;
            col_dgvWorkshifts_UserAccounts_Fullname.DataPropertyName = Workshift.COL_UserAccounts_Fullname;
            col_dgvWorkshifts_Start.DataPropertyName = Workshift.COL_DB_Start;
            col_dgvWorkshifts_Duration.DataPropertyName = Workshift.COL_DB_DurationMinutes;

            dgvWorkshiftTemplates.AutoGenerateColumns = false;
            col_dgvWorkshiftTemplates_Id.DataPropertyName = WorkshiftTemplate.COL_DB_Id;
            col_dgvWorkshiftTemplates_Name.DataPropertyName = WorkshiftTemplate.COL_DB_Name;
            col_dgvWorkshiftTemplates_Start.DataPropertyName = WorkshiftTemplate.COL_DB_Start;
            col_dgvWorkshifts_Duration.DataPropertyName = WorkshiftTemplate.COL_DB_DurationMinutes;

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
                Client client = new Client((Guid)_Clients_Id);
                lblCompany_Name.Text = client.CompanyName;
                lblAddress.Text = client.Address;
                lblBillingAddress.Text = client.BillingAddress;
                lblContactPerson.Text = client.ContactPersonName;
                lblPhone1.Text = client.Phone1;
                lblPhone2.Text = client.Phone2;
                lblNpwp.Text = client.NPWP;
                lblNpwpAddress.Text = client.NPWPAddress;
                lblNotes.Text = client.Notes;

                populateDgvWorkshifts();
                populateDgvWorkshiftTemplates();
                populateDgvBankAccounts();
           }
        }

        private void populateDgvWorkshifts()
        {
            Util.populateDataGridView(dgvWorkshifts, Workshift.get(false, null, null, _Clients_Id, null, null, (int)_dgvWorkshifts_FilterDayOfWeek, null, null, null));
        }

        private void populateDgvWorkshiftTemplates()
        {
            Util.populateDataGridView(dgvWorkshiftTemplates, WorkshiftTemplate.get(false, null, null, _Clients_Id, null, (int)_dgvWorkshiftTemplates_FilterDayOfWeek, null, null, null));
        }

        private void populateDgvBankAccounts()
        {
            Util.populateDataGridView(dgvBankAccounts, BankAccount.get(null, null, _Clients_Id, null, null, null));
        }

        private bool isValidToPopulateData()
        {
            if (_Clients_Id == null)
                return false;
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

        private void lnk_Edit_WorkshiftTemplates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LIBUtil.Util.displayForm(null, new Admin.MasterData_v1_WorkshiftTemplates_Form(FormModes.Add, _Clients_Id));
            populateDgvWorkshiftTemplates();
        }

        private void lnk_Edit_Workshifts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LIBUtil.Util.displayForm(null, new Admin.MasterData_v1_Workshifts_Form(FormModes.Add, _Clients_Id));
            populateDgvWorkshifts();
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

        private void rbWorkshiftTemplates_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == rbWorkshiftTemplates_Monday)
                _dgvWorkshiftTemplates_FilterDayOfWeek = DayOfWeek.Monday;
            else if (sender == rbWorkshiftTemplates_Tuesday)
                _dgvWorkshiftTemplates_FilterDayOfWeek = DayOfWeek.Tuesday;
            else if (sender == rbWorkshiftTemplates_Wednesday)
                _dgvWorkshiftTemplates_FilterDayOfWeek = DayOfWeek.Wednesday;
            else if (sender == rbWorkshiftTemplates_Thursday)
                _dgvWorkshiftTemplates_FilterDayOfWeek = DayOfWeek.Thursday;
            else if (sender == rbWorkshiftTemplates_Friday)
                _dgvWorkshiftTemplates_FilterDayOfWeek = DayOfWeek.Friday;
            else if (sender == rbWorkshiftTemplates_Saturday)
                _dgvWorkshiftTemplates_FilterDayOfWeek = DayOfWeek.Saturday;
            else if (sender == rbWorkshiftTemplates_Sunday)
                _dgvWorkshiftTemplates_FilterDayOfWeek = DayOfWeek.Sunday;

            populateDgvWorkshiftTemplates();
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
