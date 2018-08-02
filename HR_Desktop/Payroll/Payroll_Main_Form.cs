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
using LOGIN;
using LOGGING;
using HR_LIB.HR;

namespace HR_Desktop.Payroll
{
    public partial class Payroll_Main_Form : Form
    {/*******************************************************************************************************/
        #region SETTINGS

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public Guid BrowsedItemSelectionId;
        public string BrowsedItemSelectionDescription;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        //private List<PaymentInfo> _selectedPayrolls_PaymentInfo = new List<PaymentInfo>();

        private FormModes _formMode;

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Payroll_Main_Form() : this(FormModes.Normal, null) { }
        public Payroll_Main_Form(FormModes formMode) : this(formMode, null) { }
        public Payroll_Main_Form(FormModes formMode, Guid? id)
        {
            InitializeComponent();

            _formMode = formMode;
        }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            this.ShowIcon = false;

            dgvPayrolls.AutoGenerateColumns = false;
            col_dgvPayrolls_Id.DataPropertyName = HR_LIB.HR.Payroll.COL_DB_Id;
            col_dgvPayrolls_UserAccounts_Fullname.DataPropertyName = HR_LIB.HR.Payroll.COL_Employee_UserAccounts_Fullname;
            col_dgvPayrolls_Amount.DataPropertyName = HR_LIB.HR.Payroll.COL_DB_Amount;
            col_dgvPayrolls_Timestamp.DataPropertyName = HR_LIB.HR.Payroll.COL_DB_Timestamp;

            dgvPayrollItems.AutoGenerateColumns = false;
            Util.clearWhenSelected(dgvPayrollItems);
            col_dgvPayrollItems_Id.DataPropertyName = PayrollItem.COL_DB_Id;
            col_dgvPayrollItems_Description.DataPropertyName = PayrollItem.COL_DB_Description;
            col_dgvPayrollItems_Amount.DataPropertyName = PayrollItem.COL_DB_Amount;
            col_dgvPayrollItems_Notes.DataPropertyName = PayrollItem.COL_DB_Notes;
            Util.setGridviewColumnWordwrap(col_dgvPayrollItems_Notes, DataGridViewAutoSizeColumnMode.Fill);

            calculateTotals();

            idtp_EndDate.Value = DateTime.Today;
            idtp_StartDate.Value = DateTime.Today.AddMonths(-3);

            setupControlsBasedOnRoles();

            if (_formMode == FormModes.Browse)
            {
                menuStrip1.Visible = false;
                btnPayment.Visible = false;
            }
        }

        private void setupControlsBasedOnRoles()
        {

        }

        private void populateData()
        {
            Util.setGridviewDataSource(dgvPayrolls, true, true, HR_LIB.HR.Payroll.get(null, itxt_Employee_UserAccount.ValueGuid, idtp_StartDate.ValueAsStartDateFilter, idtp_EndDate.ValueAsEndDateFilter));
            populateDgvPayrollItems();
        }

        private void populateDgvPayrollItems()
        {
            List<Guid?> Payrolls_Id = new List<Guid?>();
            foreach (DataGridViewRow row in dgvPayrolls.Rows)
            {
                if (Util.getCheckboxValue(row, col_dgvPayrolls_Selected.Index))
                    Payrolls_Id.Add((Guid)row.Cells[col_dgvPayrolls_Id.Name].Value);
            }

            DataTable datatable = null;
            if (Payrolls_Id.Count != 0)
                datatable = PayrollItem.get(Payrolls_Id);

            Util.populateDataGridView(dgvPayrollItems, datatable);
            calculateTotals();
        }

        private void calculateTotals()
        {
            lblTotalAmount.Text = string.Format("{0:N0}", Util.compute((DataTable)dgvPayrollItems.DataSource, "SUM", PayrollItem.COL_DB_Amount, null));
            lblPayableAmount.Text = string.Format("{0:N0}", lblTotalAmount.Text);
        }

        #endregion METHODS
        /*******************************************************************************************************/
        #region EVENT HANDLERS

        private void Form_Load(object sender, EventArgs e)
        {
            setupControls();
            populateData();
        }

        private void menu_log_Click(object sender, EventArgs e)
        {
            ActivityLogs_Form.show( UserAccount.LoggedInAccount, dgvPayrolls, col_dgvPayrolls_Id);
        }

        private void dgvPayrolls_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (Util.isColumnMatch(sender, e, col_dgvPayrolls_Selected))
            {
                    Util.clickDataGridViewCheckbox(sender, e);
                    populateDgvPayrollItems();
            }
        }
     
        private void itxt_UserAccount_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            var form = new LOGIN.MasterData_v1_UserAccounts_Form(FormModes.Browse, false);
            Util.displayForm(null, form);
            if (form.DialogResult == DialogResult.OK)
                itxt_Employee_UserAccount.setValue(form.BrowsedItemSelectionDescription, form.BrowsedItemSelectionId);
        }

        private void idtp_Date_ValueChanged(object sender, EventArgs e)
        {
            if (!idtp_EndDate.isValidEndDate(idtp_StartDate))
            {
                idtp_EndDate.ValueError("Invalid End Date. End Date must be later than Start Date.");
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            populateData();
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            populateData();
        }

        private void pbRefreshCalculation_Click(object sender, EventArgs e)
        {
            populateDgvPayrollItems();
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
