using System;
using System.Data;
using System.Windows.Forms;
using HR_LIB.HR;
using LIBUtil;
using System.Linq;
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

            rbWorkshifts_Monday.Tag = rbWorkshiftTemplates_Monday.Tag = DayOfWeek.Monday;
            rbWorkshifts_Tuesday.Tag = rbWorkshiftTemplates_Tuesday.Tag = DayOfWeek.Tuesday;
            rbWorkshifts_Wednesday.Tag = rbWorkshiftTemplates_Wednesday.Tag = DayOfWeek.Wednesday;
            rbWorkshifts_Thursday.Tag = rbWorkshiftTemplates_Thursday.Tag = DayOfWeek.Thursday;
            rbWorkshifts_Friday.Tag = rbWorkshiftTemplates_Friday.Tag = DayOfWeek.Friday;
            rbWorkshifts_Saturday.Tag = rbWorkshiftTemplates_Saturday.Tag = DayOfWeek.Saturday;
            rbWorkshifts_Sunday.Tag = rbWorkshiftTemplates_Sunday.Tag = DayOfWeek.Sunday;
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

                populateDgvBankAccounts();
                rbWorkshifts_Monday.Checked = true;
                rbWorkshiftTemplates_Monday.Checked = true;
            }
        }

        private void populateDgvWorkshifts()
        {
            Util.populateDataGridView(dgvWorkshifts, Workshift.get(false, null, null, _Clients_Id, null, null, (int)Util.getDayOfWeekFromActiveRadioButtonTag(flpWorkshifts), null, null, null));
        }

        private void populateDgvWorkshiftTemplates()
        {
            Util.populateDataGridView(dgvWorkshiftTemplates, WorkshiftTemplate.get(false, null, null, _Clients_Id, null, (int)Util.getDayOfWeekFromActiveRadioButtonTag(flpWorkshiftTemplates), null, null, null));
        }

        private void populateDgvBankAccounts()
        {
            Util.populateDataGridView(dgvBankAccounts, BankAccount.get(false, null, null, _Clients_Id, null, null, null));
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
            populateDgvWorkshifts();
        }

        private void rbWorkshiftTemplates_CheckedChanged(object sender, EventArgs e)
        {
            populateDgvWorkshiftTemplates();
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
