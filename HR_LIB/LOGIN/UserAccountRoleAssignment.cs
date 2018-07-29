using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using LIBUtil;

namespace LOGIN
{
    public class UserAccountRoleAssignment
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public Guid Id;
        public Guid UserAccounts_Id;
        public Guid UserAccountRoles_Id;

        public string UserAccountRoles_Name;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_UserAccounts_Id = "UserAccounts_Id";
        public const string COL_DB_UserAccountRoles_Id = "UserAccountRoles_Id";

        public const string COL_FILTER_UserAccounts_Id = "UserAccounts_Id";
        public const string COL_UserAccountRoles_Name = "UserAccountRoles_Name";
        public const string ARRAY_UserAccountRoles_Id = "ARRAY_UserAccountRoles_Id";

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public UserAccountRoleAssignment() { }

        public UserAccountRoleAssignment(Guid id)
        {
            DataRow row = get(id);
            Id = id;
            UserAccounts_Id = Util.wrapNullable<Guid>(row, COL_DB_UserAccounts_Id);
            UserAccountRoles_Id = Util.wrapNullable<Guid>(row, COL_DB_UserAccountRoles_Id);

            UserAccountRoles_Name = Util.wrapNullable<string>(row, COL_UserAccountRoles_Name);
        }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        /// <summary>
        /// <para>userAccountID is user that is performing the assignment</para>
        /// <para>userAccountsId is the user to be assigned to the userAccountRoleId </para>
        /// </summary>
        public static void add(Guid userAccountID, Guid userAccountId, Guid userAccountRoleId)
        {
            Guid id = Guid.NewGuid();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "UserAccountRoleAssignments_add",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_UserAccounts_Id, SqlDbType.UniqueIdentifier, userAccountId),
                    new SqlQueryParameter(COL_DB_UserAccountRoles_Id, SqlDbType.UniqueIdentifier, userAccountRoleId)
                );

                if (result.IsSuccessful)
                {
                    LOGGING.ActivityLog.add(sqlConnection, userAccountID, id, "Added");
                }
            }
        }

        public static DataRow get(Guid id) { return Util.getFirstRow(get(id, null)); }
        
        public static DataTable get(Guid? id, Guid? UserAccounts_Id)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.FillByAdapter,
                "UserAccountRoleAssignments_get",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                    new SqlQueryParameter(COL_DB_UserAccounts_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(UserAccounts_Id))
                );
            return result.Datatable;
        }

        public static DataTable getByUserAccountId(Guid userAccountId)
        {
            DataTable datatable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                datatable = getByUserAccountId(sqlConnection, userAccountId);

            return datatable;
        }
        /// <summary>retrieves all roles granted to userAccountId </summary>
        public static DataTable getByUserAccountId(SqlConnection sqlConnection, Guid userAccountId)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.FillByAdapter,
                "UserAccountRoleAssignments_getby_UserAccounts_Id",
                    new SqlQueryParameter(COL_FILTER_UserAccounts_Id, SqlDbType.UniqueIdentifier, userAccountId)
                );
            return result.Datatable;
        }

        /// <summary>
        /// <para>userAccountID is user that is performing the assignment</para>
        /// </summary>
        public static void update(Guid userAccountID, Guid userAccountIdToBeAssigned, List<Guid?> userAccountRoles_Id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                update(sqlConnection, userAccountID, userAccountIdToBeAssigned, userAccountRoles_Id);
        }

        /// <summary>
        /// <para>userAccountID is user that is performing the assignment</para>
        /// </summary>
        public static void update(SqlConnection sqlConnection, Guid userAccountID, Guid userAccountIdToBeAssigned, List<Guid?> userAccountRoles_Id)
        {
            List<Guid?> oldList = new List<Guid?>();
            foreach (DataRow row in getByUserAccountId(sqlConnection, userAccountIdToBeAssigned).Rows)
                oldList.Add(Util.wrapNullable<Guid?>(row, COL_DB_UserAccountRoles_Id));

            string log = "";
            foreach (Guid item in oldList)
            {
                if (!userAccountRoles_Id.Contains(item))
                    log = Util.appendChange(log, new UserAccountRole(sqlConnection, (Guid)item).Name, null, "Role '{0}' deleted");
            }
            foreach (Guid item in userAccountRoles_Id)
            {
                if (!oldList.Contains(item))
                    log = Util.appendChange(log, new UserAccountRole(sqlConnection, (Guid)item).Name, null, "Role '{0}' added");
            }

            if (!string.IsNullOrEmpty(log))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "UserAccountRoleAssignments_update",
                    DBConnection.createTableParameters(
                        new SqlQueryTableParameterGuid(ARRAY_UserAccountRoles_Id, userAccountRoles_Id.ToArray())
                        ),
                    new SqlQueryParameter(COL_DB_UserAccounts_Id, SqlDbType.UniqueIdentifier, userAccountIdToBeAssigned)
                );

                if (result.IsSuccessful)
                    LOGGING.ActivityLog.add(sqlConnection, userAccountID, userAccountIdToBeAssigned, String.Format("Updated: {0}", log));
            }
        }

        /// <summary>
        /// <para>userAccountID is user that is performing the assignment</para>
        /// <para>userAccountsId is the user to be assigned to the userAccountRoleId </para>
        /// </summary>
        public static void delete(Guid userAccountID, Guid id)
        {

            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "UserAccountRoleAssignments_delete",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id)
                );

                if (result.IsSuccessful)
                {
                    UserAccountRoleAssignment obj = new UserAccountRoleAssignment(id);
                    LOGGING.ActivityLog.add(sqlConnection, userAccountID, obj.UserAccounts_Id, "Deleted Role " + obj.UserAccountRoles_Name);
                }
            }
        }

        #endregion DATABASE METHODS
        /*******************************************************************************************************/
        #region CLASS METHODS
        
        #endregion CLASS METHODS
        /*******************************************************************************************************/
    }
}


