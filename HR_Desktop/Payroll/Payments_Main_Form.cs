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
using HR_LIB;
using HR_LIB.HR;

namespace HR_Desktop.Payroll
{
    public partial class Payments_Main_Form : Form
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

        public Payments_Main_Form() : this(null, null) { }
        public Payments_Main_Form(Guid? Employee_UserAccounts_Id, Guid? Payrolls_Id)
        {
            InitializeComponent();

            if (Employee_UserAccounts_Id != null)
            {
                itxt_Employee_UserAccount.ValueGuid = Employee_UserAccounts_Id;
                itxt_Employee_UserAccount.ValueText = new LOGIN.UserAccount((Guid)Employee_UserAccounts_Id).Fullname;
            }

            if (Payrolls_Id != null)
            {
                itxt_Payrolls.ValueGuid = Payrolls_Id;
                itxt_Payrolls.ValueText = new HR_LIB.HR.Payroll((Guid)Payrolls_Id).No;
            }
        }


        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            this.ShowIcon = false;

            dgvPayments.AutoGenerateColumns = false;
            col_dgvPayments_Id.DataPropertyName = Payment.COL_DB_Id;
            col_dgvPayments_No.DataPropertyName = Payment.COL_DB_No;
            col_dgvPayments_Timestamp.DataPropertyName = Payment.COL_DB_Timestamp;
            col_dgvPayments_Source_BankAccounts.DataPropertyName = Payment.COL_Source_BankAccounts_Name;
            col_dgvPayments_Target_BankAccounts.DataPropertyName = Payment.COL_Target_BankAccounts_Name;
            col_dgvPayments_Amount.DataPropertyName = Payment.COL_DB_Amount;
            col_dgvPayments_ConfirmationNumber.DataPropertyName = Payment.COL_DB_ConfirmationNumber;
            col_dgvPayments_Notes.DataPropertyName = Payment.COL_DB_Notes;
            col_dgvPayments_Approved.DataPropertyName = Payment.COL_DB_Approved;
            col_dgvPayments_Rejected.DataPropertyName = Payment.COL_DB_Rejected;

            dgvPaymentItems.AutoGenerateColumns = false;
            col_dgvPaymentItems_Id.DataPropertyName = PaymentItem.COL_DB_Id;
            col_dgvPaymentItems_Payrolls_No.DataPropertyName = PaymentItem.COL_Payrolls_No;
            col_dgvPaymentItems_Employee_UserAccounts.DataPropertyName = PaymentItem.COL_Employee_UserAccounts_Fullname;
            col_dgvPaymentItems_Amount.DataPropertyName = PaymentItem.COL_DB_Amount;
            col_dgvPaymentItems_Notes.DataPropertyName = PaymentItem.COL_DB_Notes;

            idtp_EndDate.Value = DateTime.Today;
            idtp_StartDate.Value = DateTime.Today.AddMonths(-3);

            BankAccount.populateDropDownList(iddl_Source_BankAccounts, false, true, null);
            BankAccount.populateDropDownList(iddl_Target_BankAccounts, false, false, true);

            setupControlsBasedOnRoles();
        }

        private void setupControlsBasedOnRoles()
        {
            Helper.hideIfNoAccess(LOGIN.UserAccount.LoggedInAccount, col_dgvPayments_Approved, false, UserAccountAccessEnum.Finance_ConfirmPayments);
        }

        private void populateData()
        {
            LIBUtil.Util.populateDataGridView(dgvPayments, Payment.get(null,(Guid?)iddl_Source_BankAccounts.SelectedValue, (Guid?)iddl_Target_BankAccounts.SelectedValue, itxt_Employee_UserAccount.ValueGuid, itxt_Payrolls.ValueGuid, idtp_StartDate.ValueAsStartDateFilter, idtp_EndDate.ValueAsEndDateFilter));
            LIBUtil.Util.populateDataGridView(dgvPaymentItems, null);
        }

        private void populateDgvPaymentItems()
        {
            LIBUtil.Util.populateDataGridView(dgvPaymentItems, PaymentItem.get(Util.getSelectedRowID(dgvPayments,col_dgvPayments_Id)));
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

        private void dgvPayments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Util.displayForm(null, new Payments_Print_Form(Util.getSelectedRowID(dgvPayments, col_dgvPayments_Id)));
        }

        private void dgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Util.isColumnMatch(sender, e, col_dgvPayments_Approved))
                Payment.updateApprovedStatus(LOGIN.UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgvPayments, col_dgvPayments_Id), !Util.getCheckboxValue(sender, e));
            else if (Util.isColumnMatch(sender, e, col_dgvPayments_Rejected))
                Payment.updateRejectedStatus(LOGIN.UserAccount.LoggedInAccount.Id, Util.getSelectedRowID(dgvPayments, col_dgvPayments_Id), !Util.getCheckboxValue(sender, e));
            else if (Util.isColumnMatch(sender, e, col_dgvPayments_No))
                populateDgvPaymentItems();
        }

        private void itxt_UserAccounts_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            var form = new LOGIN.MasterData_v1_UserAccounts_Form(FormModes.Browse, false);
            Util.displayForm(null, form);
            if (form.DialogResult == DialogResult.OK)
                ((LIBUtil.Desktop.UserControls.InputControl_Textbox)sender).setValue(form.BrowsedItemSelectionDescription, form.BrowsedItemSelectionId);
        }

        private void itxt_Payrolls_isBrowseMode_Clicked(object sender, EventArgs e)
        {
            var form = new Payroll.Payrolls_Main_Form(FormModes.Browse);
            Util.displayForm(null, form);
            if (form.DialogResult == DialogResult.OK)
                ((LIBUtil.Desktop.UserControls.InputControl_Textbox)sender).setValue(form.BrowsedItemSelectionDescription, form.BrowsedItemSelectionId);
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            populateData();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Util.displayForm(null, new LOGGING.ActivityLogs_Form(UserAccount.LoggedInAccount, Util.getSelectedRowID(dgvPayments, col_dgvPayments_Id)));
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

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
