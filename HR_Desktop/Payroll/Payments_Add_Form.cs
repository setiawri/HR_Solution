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
    public partial class Payments_Add_Form : Form
    {
        /*******************************************************************************************************/
        #region SETTINGS

        #endregion SETTINGS
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region PRIVATE VARIABLES

        private decimal _amount = 0;
        List<HR_LIB.HR.PaymentInfo> _paymentInfoList = new List<HR_LIB.HR.PaymentInfo>();

        #endregion PRIVATE VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Payments_Add_Form(HR_LIB.HR.PaymentInfo paymentInfo) : this(new List<HR_LIB.HR.PaymentInfo>() { paymentInfo }) { }
        public Payments_Add_Form(List<HR_LIB.HR.PaymentInfo> paymentInfoList)
        {
            InitializeComponent();

            _paymentInfoList = paymentInfoList.OrderBy(item => item.Transaction_RefTimestamp).ToList(); //sort list based on timestamp
            _amount = _paymentInfoList.Sum(item => item.Amount);
        }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region METHODS

        private void setupControls()
        {
            this.ShowIcon = false;
            btnSubmit.Enabled = false;
            lblAmount.Text = string.Format("{0:N0}", _amount);
            in_BankAmount.Value = _amount;

            BankAccount.populateDropDownList(iddl_Source_BankAccounts,false,true, null);
            BankAccount.populateDropDownList(iddl_Target_BankAccounts, false, false, true);

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
                Guid Payments_Id = HR_LIB.HR.Payment.add(LOGIN.UserAccount.LoggedInAccount.Id,
                   _paymentInfoList, (Guid)iddl_Source_BankAccounts.SelectedValue, (Guid)iddl_Target_BankAccounts.SelectedValue,
                   in_BankAmount.ValueLong, itxt_ConfirmationNumber.ValueText, itxt_Notes.ValueText);
                // Util.displayForm(null, new SharedForms.Payments_Print_Form(Payments_Id));

                this.Close();
            }
        }


        private bool isInputValid()
        {

            if (in_BankAmount.ValueLong == 0 || !(in_BankAmount.ValueLong == _amount))
                return in_BankAmount.isValueError("Amount transfer can not zero and must be equal with Total Amount");
            return true;
        }

        private void in_BankAmount_ValueChanged(object sender, EventArgs e)
        {
            if (in_BankAmount.ValueInt == 0)
                btnSubmit.Enabled = false;
            else
                btnSubmit.Enabled = true;
        }

        #endregion EVENT HANDLERS
        /*******************************************************************************************************/
    }
}
