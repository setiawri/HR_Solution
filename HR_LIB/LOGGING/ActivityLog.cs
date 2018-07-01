using System;
using System.Data;
using System.Data.SqlClient;
using LIBUtil;

namespace LOGGING
{
    public class ActivityLog
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_Timestamp = "Timestamp";
        public const string COL_DB_Description = "Description";
        public const string COL_DB_AssociatedId = "AssociatedId";
        public const string COL_DB_UserAccounts_Id = "UserAccounts_Id";

        public const string COL_UserAccounts_Fullname = "UserAccounts_Fullname";

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static DataTable get(Guid userAccountID, Guid associatedId)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("ActivityLogs_get", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@" + COL_DB_AssociatedId, SqlDbType.UniqueIdentifier).Value = associatedId;

                adapter.SelectCommand = cmd;
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        
        public static string add(Guid userAccountID, Guid associatedID, string description)
        {
            string returnValue = "";
            using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionString))
            {
                returnValue = add(conn, userAccountID, associatedID, description);
            }
            return returnValue;
        }

        public static string add(SqlConnection sqlConnection, Guid userAccountId, Guid associatedId, string description)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("ActivityLogs_add", sqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@" + COL_DB_Id, SqlDbType.UniqueIdentifier).Value = Guid.NewGuid();
                    cmd.Parameters.Add("@" + COL_DB_Timestamp, SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@" + COL_DB_Description, SqlDbType.VarChar).Value = description;
                    cmd.Parameters.Add("@" + COL_DB_AssociatedId, SqlDbType.UniqueIdentifier).Value = associatedId;
                    cmd.Parameters.Add("@" + COL_DB_UserAccounts_Id, SqlDbType.UniqueIdentifier).Value = userAccountId;

                    if (sqlConnection.State != ConnectionState.Open)
                        sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { return ex.Message; }

            return string.Empty;
        }

        #endregion DATABASE METHODS
        /*******************************************************************************************************/
        #region CLASS METHODS

        #endregion CLASS METHODS
        /*******************************************************************************************************/
    }
}
