using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using LIBUtil;

namespace LOGIN
{
    public class UserAccountAccessRoleAssignment
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public Guid Id;
        public Guid UserAccountRoles_Id;
        public UserAccountAccess UserAccountAccess_EnumId;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_UserAccountRoles_Id = "UserAccountRoles_Id";
        public const string COL_DB_UserAccountAccess_EnumId = "UserAccountAccess_EnumId";

        public const string COL_FILTER_UserAccounts_Id = "UserAccounts_Id";
        public const string COL_FILTER_UserAccountRoles_Id = "UserAccountRoles_Id";
        public const string ARRAY_UserAccountAccessEnum = "ARRAY_UserAccountAccessEnum";

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public UserAccountAccessRoleAssignment(Guid id)
        {
            DataRow row = get(id);
            Id = id;
            UserAccountRoles_Id = Util.wrapNullable<Guid>(row, COL_DB_UserAccountRoles_Id);
            UserAccountAccess_EnumId = Util.parseEnum<UserAccountAccess>(Util.wrapNullable<Int16>(row, COL_DB_UserAccountAccess_EnumId));
        }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        /// <summary>
        /// <para>userAccountID is user that is performing the assignment</para>
        /// <para>userAccountsId is the user to be assigned to the userAccountRoleId </para>
        /// </summary>
        public static Guid add(Guid userAccountID, Guid userAccountRoleId, UserAccountAccessEnum userAccountAccessEnum)
        {
            Guid id = Guid.NewGuid();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "UserAccountAccessRoleAssignments_add",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_UserAccountRoles_Id, SqlDbType.UniqueIdentifier, userAccountRoleId),
                    new SqlQueryParameter(COL_DB_UserAccountAccess_EnumId, SqlDbType.Int, userAccountAccessEnum)
                );

                if (result.IsSuccessful)
                    LOGGING.ActivityLog.add(sqlConnection, userAccountID, id, "Added");
            }
            return id;
        }

        public static DataRow get(Guid id) { return Util.getFirstRow(get(id, null)); }

        public static DataTable get(Guid? id, Guid? userAccountRoleId)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.FillByAdapter,
                "UserAccountAccessRoleAssignments_get",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                    new SqlQueryParameter(COL_DB_UserAccountRoles_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(userAccountRoleId))
                );
            return result.Datatable;
        }
        
        /// <summary>
        /// <para>retrieves all accessses granted to userAccountId </para>
        /// </summary>
        public static DataTable getByUserAccountId(Guid userAccountID)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.FillByAdapter,
                "UserAccountAccessRoleAssignments_getby_UserAccounts_Id",
                    new SqlQueryParameter(COL_FILTER_UserAccounts_Id, SqlDbType.UniqueIdentifier, userAccountID)
                );
            return result.Datatable;
        }
        
        public static DataTable getByUserAccountRoleId(Guid userAccountRoleId)
        {
            DataTable datatable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                datatable = getByUserAccountRoleId(sqlConnection, userAccountRoleId);

            return datatable;
        }
        /// <summary>retrieves all accessses granted to userAccountRoleId </summary>
        public static DataTable getByUserAccountRoleId(SqlConnection sqlConnection, Guid userAccountRoleId)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.FillByAdapter,
                "UserAccountAccessRoleAssignments_getby_UserAccountRoles_Id",
                    new SqlQueryParameter(COL_FILTER_UserAccountRoles_Id, SqlDbType.UniqueIdentifier, userAccountRoleId)
                );
            return result.Datatable;
        }
        
        /// <summary>
        /// <para>userAccountID is user that is performing the assignment</para>
        /// </summary>
        public static void update(Guid userAccountID, Guid userAccountRoleId, List<int> userAccountAccessEnum)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                update(sqlConnection, userAccountID, userAccountRoleId, userAccountAccessEnum);
        }

        /// <summary>
        /// <para>userAccountID is user that is performing the assignment</para>
        /// </summary>
        public static void update(SqlConnection sqlConnection, Guid userAccountID, Guid userAccountRoleId, List<int> userAccountAccessEnum)
        {
            List<int> oldList = new List<int>();
            foreach (DataRow row in getByUserAccountRoleId(sqlConnection, userAccountRoleId).Rows)
                oldList.Add(Util.wrapNullable<int>(row, COL_DB_UserAccountAccess_EnumId));

            string log = "";
            foreach (int item in oldList)
            {
                if (!userAccountAccessEnum.Contains(item))
                    log = Util.appendChange(log, Util.GetEnumDescription<UserAccountAccessEnum>(item), null, "Access '{0}' deleted");
            }
            foreach (int item in userAccountAccessEnum)
            {
                if (!oldList.Contains(item))
                    log = Util.appendChange(log, Util.GetEnumDescription<UserAccountAccessEnum>(item), null, "Access '{0}' added");
            }
            
            if (!string.IsNullOrEmpty(log))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "UserAccountAccessRoleAssignments_update",
                    DBConnection.createTableParameters(
                        new SqlQueryTableParameterInt(ARRAY_UserAccountAccessEnum, userAccountAccessEnum.ToArray())
                        ),
                    new SqlQueryParameter(COL_DB_UserAccountRoles_Id, SqlDbType.UniqueIdentifier, userAccountRoleId)
                );

                if (result.IsSuccessful)
                    LOGGING.ActivityLog.add(sqlConnection, userAccountID, userAccountRoleId, String.Format("Updated: {0}", log));
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
                    "UserAccountAccessRoleAssignments_delete",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id)
                );

                if (result.IsSuccessful)
                {
                    UserAccountAccessRoleAssignment obj = new UserAccountAccessRoleAssignment(id);
                    LOGGING.ActivityLog.add(sqlConnection, userAccountID, obj.UserAccountRoles_Id, "Deleted Access " + Util.GetEnumDescription<UserAccountAccess>(obj.UserAccountAccess_EnumId));
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


