using System;
using System.Data;
using System.Data.SqlClient;
using LIBUtil;
using LOGGING;

namespace HR_LIB.HR
{
    public class Payroll
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public Guid Id;
        public DateTime Timestamp;
        public decimal Amount;
        public Guid Employee_UserAccounts_Id;

        public string Employee_UserAccounts_Fullname;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_Timestamp = "Timestamp";
        public const string COL_DB_Employee_UserAccounts_Id = "Employee_UserAccounts_Id";
        public const string COL_DB_Amount = "Amount";

        public const string COL_Employee_UserAccounts_Fullname = "Employee_UserAccounts_Fullname";

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Payroll(Guid id) : this(null, id) { }
        public Payroll(SqlConnection sqlConnection, Guid id)
        {
            DataRow row;
            if (sqlConnection == null)
                row = get(id);
            else
                row = get(sqlConnection, id);

            Id = id;
            Timestamp = Util.wrapNullable<DateTime>(row, COL_DB_Timestamp);
            Amount = Util.wrapNullable<decimal>(row, COL_DB_Amount);
            Employee_UserAccounts_Id = Util.wrapNullable<Guid>(row, COL_DB_Employee_UserAccounts_Id);

            Employee_UserAccounts_Fullname = Util.wrapNullable<string>(row, COL_Employee_UserAccounts_Fullname);
        }

        public Payroll() { }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static Guid add(SqlConnection sqlConnection, Guid userAccountID, Guid id, int amount, Guid Employee_UserAccounts_Id, string notes)
        {
            SqlQueryResult result = DBConnection.query(
                sqlConnection,
                QueryTypes.ExecuteNonQuery,
                "Payrolls_add",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                new SqlQueryParameter(COL_DB_Employee_UserAccounts_Id, SqlDbType.UniqueIdentifier, Employee_UserAccounts_Id),
                new SqlQueryParameter(COL_DB_Amount, SqlDbType.Int, amount)
            );

            if (result.IsSuccessful)
                ActivityLog.add(sqlConnection, userAccountID, id, "Added");

            return id;
        }

        public static DataRow get(SqlConnection sqlConnection, Guid id) { return Util.getFirstRow(get(sqlConnection, id, null, null, null)); }
        public static DataRow get(Guid id)
        {
            DataRow row;
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                row = Util.getFirstRow(get(sqlConnection, id, null, null, null));
            return row;
        }
        public static DataTable get(Guid? id, Guid? Employee_UserAccounts_Id, DateTime? startDate, DateTime? endDate)
        {
            DataTable datatable;
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                datatable = get(sqlConnection, id, Employee_UserAccounts_Id, startDate, endDate);
            return datatable;
        }
        public static DataTable get(SqlConnection sqlConnection, Guid? id, Guid? Employee_UserAccounts_Id, DateTime? startDate, DateTime? endDate)
        {
            SqlQueryResult result = DBConnection.query(
                sqlConnection,
                QueryTypes.FillByAdapter,
                "Payrolls_get",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                new SqlQueryParameter(COL_DB_Employee_UserAccounts_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(Employee_UserAccounts_Id)),
                new SqlQueryParameter("StartDate", SqlDbType.DateTime, Util.wrapNullable(startDate)),
                new SqlQueryParameter("EndDate", SqlDbType.DateTime, Util.wrapNullable(endDate))
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

