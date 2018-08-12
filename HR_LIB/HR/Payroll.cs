﻿using System;
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
        public string No;
        public DateTime Timestamp;
        public decimal Amount;
        public Guid Employee_UserAccounts_Id;

        public string Employee_UserAccounts_Fullname;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_No = "No";
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
            No = Util.wrapNullable<string>(row, COL_DB_No);
            Timestamp = Util.wrapNullable<DateTime>(row, COL_DB_Timestamp);
            Amount = Util.wrapNullable<decimal>(row, COL_DB_Amount);
            Employee_UserAccounts_Id = Util.wrapNullable<Guid>(row, COL_DB_Employee_UserAccounts_Id);

            Employee_UserAccounts_Fullname = Util.wrapNullable<string>(row, COL_Employee_UserAccounts_Fullname);
        }

        public Payroll() { }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static void add(SqlConnection sqlConnection, Guid userAccountID)
        {
            SqlQueryResult result = DBConnection.query(
                sqlConnection,
                QueryTypes.ExecuteNonQuery,
                "Payrolls_add",
                 new SqlQueryParameter(ActivityLog.COL_DB_UserAccounts_Id, SqlDbType.UniqueIdentifier, userAccountID)
            );

        }

        public static void add(Guid userAccountID, DataTable PayrollItems)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                {
                    DBConnection.query(
                            sqlConnection,
                            QueryTypes.ExecuteNonQuery,
                            "Payrolls_create_temp");

                    foreach (DataRow row in PayrollItems.Rows)
                    {
                        SqlQueryResult result = DBConnection.query(
                            sqlConnection,
                            QueryTypes.ExecuteNonQuery,
                            "Payrolls_add_temp",
                            new SqlQueryParameter(PayrollItem.COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable<Guid>(row, COL_DB_Id)),
                            new SqlQueryParameter(PayrollItem.COL_Employee_UserAccounts_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable<Guid>(row, COL_DB_Employee_UserAccounts_Id)),
                            new SqlQueryParameter(PayrollItem.COL_DB_RefId, SqlDbType.UniqueIdentifier, Util.wrapNullable<Guid>(row, PayrollItem.COL_DB_RefId)),
                            new SqlQueryParameter(PayrollItem.COL_DB_Description, SqlDbType.NVarChar, Util.wrapNullable<string>(row, PayrollItem.COL_DB_Description)),
                            new SqlQueryParameter(PayrollItem.COL_DB_Amount, SqlDbType.Decimal, Util.wrapNullable<decimal?>(row, PayrollItem.COL_DB_Amount)),
                            new SqlQueryParameter(PayrollItem.COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable<string>(row, PayrollItem.COL_DB_Notes))
                        );

                        if (result.IsSuccessful)
                            ActivityLog.add(sqlConnection, userAccountID, Util.wrapNullable<Guid>(row, PayrollItem.COL_DB_Id), "Added");
                    }

                    Payroll.add(sqlConnection, userAccountID);
                }
            }
            catch (Exception ex) { Util.displayMessageBoxError(ex.Message); }

            
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

