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
        private int _dgvWorkshifts_FilterDayOfWeek;
        private int _dgvWorkshiftTemplates_FilterDayOfWeek;

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
            _dgvWorkshifts_FilterDayOfWeek = 1;
            rbWorkshiftTemplates_Monday.Checked = true;
            _dgvWorkshiftTemplates_FilterDayOfWeek = 1;

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

           }
        }

        private void populateDgvWorkshifts()
        {
            Util.populateDataGridView(dgvWorkshifts, Workshift.get(false, null, null, _Clients_Id, null, null, _dgvWorkshifts_FilterDayOfWeek, null, null, null));
        }

        private void populateDgvWorkshiftTemplates()
        {
            Util.populateDataGridView(dgvWorkshiftTemplates, WorkshiftTemplate.get(false, null, null, _Clients_Id, null, _dgvWorkshiftTemplates_FilterDayOfWeek, null, null, null));
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

        private void rbWorkshifts_Monday_CheckedChanged(object sender, EventArgs e)
        {
            _dgvWorkshifts_FilterDayOfWeek = 1;
            populateDgvWorkshifts();
        }

        private void rbWorkshifts_Tuesday_CheckedChanged(object sender, EventArgs e)
        {
            _dgvWorkshifts_FilterDayOfWeek = 2;
            populateDgvWorkshifts();
        }

        private void rbWorkshifts_Wednesday_CheckedChanged(object sender, EventArgs e)
        {
            _dgvWorkshifts_FilterDayOfWeek = 3;
            populateDgvWorkshifts();
        }

        private void rbWorkshifts_Thursday_CheckedChanged(object sender, EventArgs e)
        {
            _dgvWorkshifts_FilterDayOfWeek = 4;
            populateDgvWorkshifts();
        }

        private void rbWorkshifts_Friday_CheckedChanged(object sender, EventArgs e)
        {
            _dgvWorkshifts_FilterDayOfWeek = 5;
            populateDgvWorkshifts();
        }

        private void rbWorkshifts_Saturday_CheckedChanged(object sender, EventArgs e)
        {
            _dgvWorkshifts_FilterDayOfWeek = 6;
            populateDgvWorkshifts();
        }

        private void rbWorkshifts_Sunday_CheckedChanged(object sender, EventArgs e)
        {
            _dgvWorkshifts_FilterDayOfWeek = 0;
            populateDgvWorkshifts();
        }

        private void rbWorkshiftTemplates_Monday_CheckedChanged(object sender, EventArgs e)
        {
            _dgvWorkshiftTemplates_FilterDayOfWeek = 1;
            populateDgvWorkshiftTemplates();
        }

        private void rbWorkshiftTemplates_Tuesday_CheckedChanged(object sender, EventArgs e)
        {
            _dgvWorkshiftTemplates_FilterDayOfWeek = 2;
            populateDgvWorkshiftTemplates();
        }

        private void rbWorkshiftTemplates_Wednesday_CheckedChanged(object sender, EventArgs e)
        {
            _dgvWorkshiftTemplates_FilterDayOfWeek = 3;
            populateDgvWorkshiftTemplates();
        }

        private void rbWorkshiftTemplates_Thursday_CheckedChanged(object sender, EventArgs e)
        {
            _dgvWorkshiftTemplates_FilterDayOfWeek = 4;
            populateDgvWorkshiftTemplates();
        }

        private void rbWorkshiftTemplates_Friday_CheckedChanged(object sender, EventArgs e)
        {
            _dgvWorkshiftTemplates_FilterDayOfWeek = 5;
            populateDgvWorkshiftTemplates();
        }

        private void rbWorkshiftTemplates_Saturday_CheckedChanged(object sender, EventArgs e)
        {
            _dgvWorkshiftTemplates_FilterDayOfWeek = 6;
            populateDgvWorkshiftTemplates();
        }

        private void rbWorkshiftTemplates_Sunday_CheckedChanged(object sender, EventArgs e)
        {
            _dgvWorkshiftTemplates_FilterDayOfWeek = 0;
            populateDgvWorkshiftTemplates();
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
