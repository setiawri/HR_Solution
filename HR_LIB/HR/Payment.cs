using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using LIBUtil;
using LOGGING;

namespace HR_LIB.HR
{
    public class PaymentInfo
    {
        public Guid Transaction_RefId;
        public decimal Amount;

        public DateTime Transaction_RefTimestamp;

        public PaymentInfo(Guid transaction_RefId, decimal amount, DateTime transaction_RefTimestamp)
        {
            Transaction_RefId = transaction_RefId;
            Amount = amount;
            Transaction_RefTimestamp = transaction_RefTimestamp;
        }
    }

    public class Payment
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public Guid Id;
        public string No;
        public DateTime Timestamp;
        public Guid Source_BankAccounts_Id;
        public Guid Target_BankAccounts_Id;
        public decimal Amount;
        public string ConfirmationNumber;
        public string Notes = "";
        public bool Approved = false;
        public bool Rejected = false;

        public string Source_BankAccounts_Name;
        public string Target_BankAccounts_Name;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_No = "No";
        public const string COL_DB_Timestamp = "Timestamp";
        public const string COL_DB_Source_BankAccounts_Id = "Source_BankAccounts_Id";
        public const string COL_DB_Target_BankAccounts_Id = "Target_BankAccounts_Id";
        public const string COL_DB_Amount = "Amount";
        public const string COL_DB_ConfirmationNumber = "ConfirmationNumber";
        public const string COL_DB_Notes = "Notes";
        public const string COL_DB_Approved = "Approved";
        public const string COL_DB_Rejected = "Rejected";

        public const string COL_Source_BankAccounts_Name = "Source_BankAccounts_Name";
        public const string COL_Target_BankAccounts_Name = "Target_BankAccounts_Name";
        public const string FILTER_Employee_UserAccounts_Id = "FILTER_Employee_UserAccounts_Id";
        public const string FILTER_Payrolls_Id = "FILTER_Payrolls_Id";

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Payment(Guid id)
        {
            DataRow row = get(id);
            Id = id;
            No = Util.wrapNullable<string>(row, COL_DB_No);
            Timestamp = Util.wrapNullable<DateTime>(row, COL_DB_Timestamp);
            Source_BankAccounts_Id = Util.wrapNullable<Guid>(row, COL_DB_Source_BankAccounts_Id);
            Target_BankAccounts_Id = Util.wrapNullable<Guid>(row, COL_DB_Target_BankAccounts_Id);
            Amount = Util.wrapNullable<decimal>(row, COL_DB_Amount);
            ConfirmationNumber = Util.wrapNullable<string>(row, COL_DB_ConfirmationNumber);
            Notes = Util.wrapNullable<string>(row, COL_DB_Notes);
            Approved = Util.wrapNullable<bool>(row, COL_DB_Approved);
            Rejected = Util.wrapNullable<bool>(row, COL_DB_Rejected);

            Source_BankAccounts_Name = Util.wrapNullable<string>(row, COL_Source_BankAccounts_Name);
            Target_BankAccounts_Name = Util.wrapNullable<string>(row, COL_Target_BankAccounts_Name);
        }

        public Payment() { }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static Guid add(Guid userAccountID, List<PaymentInfo> paymentInfoList, 
            Guid source_BankAccounts_Id, Guid target_BankAccounts_Id, decimal amount,
            string confirmationNumber, string notes)
        {
            Guid id = Guid.NewGuid();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "Payments_add",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Source_BankAccounts_Id, SqlDbType.UniqueIdentifier, source_BankAccounts_Id),
                    new SqlQueryParameter(COL_DB_Target_BankAccounts_Id, SqlDbType.UniqueIdentifier, target_BankAccounts_Id),
                    new SqlQueryParameter(COL_DB_Amount, SqlDbType.Decimal, Util.wrapNullable(amount)),
                    new SqlQueryParameter(COL_DB_ConfirmationNumber, SqlDbType.NVarChar, Util.wrapNullable(confirmationNumber)),
                    new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes))
                );

                if (result.IsSuccessful)
                {
                    ActivityLog.add(sqlConnection, userAccountID, id, "Added");

                    for (int i = 0; i < paymentInfoList.Count; i++)//notes nya untuk Payment Item didapat dr mana ya pak?
                        PaymentItem.add(sqlConnection, userAccountID, id, paymentInfoList[i].Transaction_RefId, paymentInfoList[i].Amount, null);
                }
            }
            
            return id;
        }

        public static DataRow get(Guid id) { return Util.getFirstRow(get(id, null, null, null, null,null,null)); }
        public static DataTable get(Guid? id, Guid? Source_BankAccounts_Id, Guid? Target_BankAccounts_Id, Guid? Employee_UserAccounts_Id, Guid? Payrolls_Id, DateTime? startDate, DateTime? endDate)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.FillByAdapter, 
                "Payments_get",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                new SqlQueryParameter(COL_DB_Source_BankAccounts_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(Source_BankAccounts_Id)),
                new SqlQueryParameter(COL_DB_Target_BankAccounts_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(Target_BankAccounts_Id)),
                new SqlQueryParameter(FILTER_Employee_UserAccounts_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(Employee_UserAccounts_Id)), 
                new SqlQueryParameter(FILTER_Payrolls_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(Payrolls_Id)),
                new SqlQueryParameter("startDate",SqlDbType.DateTime,Util.wrapNullable(startDate)),
                new SqlQueryParameter("endDate",SqlDbType.DateTime, Util.wrapNullable(endDate))
                );
            return result.Datatable;
        }

        public static void updateApprovedStatus(Guid userAccountID, Guid id, bool value)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "Payments_update_Approved",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Approved, SqlDbType.Bit, value)
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, string.Format("Update Approved Status: {0} to {1}", !value, value));
            }
        }
        
        public static void updateRejectedStatus(Guid userAccountID, Guid id, bool value)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "Payments_update_Rejected",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Rejected, SqlDbType.Bit, value)
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, "Update Rejected Status to " + value);
            }            
        }

        #endregion DATABASE METHODS
        /*******************************************************************************************************/
        #region CLASS METHODS

        #endregion CLASS METHODS
        /*******************************************************************************************************/
    }
}

