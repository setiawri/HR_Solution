using System;
using System.Data;
using System.Data.SqlClient;
using LIBUtil;
using LOGGING;

namespace HR_LIB.HR
{
    public class PaymentItem
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public Guid Id;
        public Guid Payments_Id;
        public Guid Transaction_RefId;
        public decimal Amount;
        public string Notes;

        public DateTime Transaction_RefTimestamp;
        public string Employee_UserAccounts_Fullname;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_Payments_Id = "Payments_Id";
        public const string COL_DB_Transaction_RefId = "Transaction_RefId";
        public const string COL_DB_Amount = "Amount";
        public const string COL_DB_Notes = "Notes";

        public const string COL_Payrolls_No = "Payrolls_No";
        public const string COL_Employee_UserAccounts_Fullname = "Employee_UserAccounts_Fullname";


        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public PaymentItem(Guid id) { }
        public PaymentItem() { }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static void add(SqlConnection sqlConnection, Guid userAccountID, Guid Payments_Id, Guid Transaction_RefId, decimal amount, string notes)
        {
            Guid id = Guid.NewGuid();
            SqlQueryResult result = DBConnection.query(
                sqlConnection,
                QueryTypes.ExecuteNonQuery,
                "PaymentItems_add",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                new SqlQueryParameter(COL_DB_Payments_Id, SqlDbType.UniqueIdentifier, Payments_Id),
                new SqlQueryParameter(COL_DB_Transaction_RefId, SqlDbType.UniqueIdentifier, Transaction_RefId),
                new SqlQueryParameter(COL_DB_Amount, SqlDbType.Decimal, amount),
                new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, notes)
            );

            if (result.IsSuccessful)
                ActivityLog.add(sqlConnection, userAccountID, id, "Added");
        }

        public static DataTable get(Guid Payments_Id)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.FillByAdapter,
                "PaymentItems_get",
                new SqlQueryParameter(COL_DB_Payments_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(Payments_Id))
                );
            return result.Datatable;
        }

        #endregion DATABASE METHODS
        /*******************************************************************************************************/
        #region CLASS METHODS

        #endregion CLASS METHODS
        /*******************************************************************************************************/
    }
}

