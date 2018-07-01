using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using LIBUtil;

namespace LOGIN
{
    public class UserAccountRole
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public Guid Id;
        public string Name = "";
        public string Notes = "";
        public bool Active;
        public bool Special;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_Name = "Name";
        public const string COL_DB_Notes = "Notes";
        public const string COL_DB_Active = "Active";
        public const string COL_DB_Special = "Special";

        public const string COL_FILTER_INCLUDEINACTIVE = "FILTER_IncludeInactive";
        public const string COL_FILTER_INCLUDESPECIAL = "FILTER_IncludeSpecial";
        public const string ARRAY_UserAccountAccessEnum = "ARRAY_UserAccountAccessEnum";

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS
		
        public UserAccountRole(Guid id) : this(null, id) { }
        public UserAccountRole(SqlConnection sqlConnection, Guid id)
        {
            DataRow row;
            if (sqlConnection == null)
                row = get(id);
            else
                row = get(sqlConnection, id);

            Id = id;
            Name = Util.wrapNullable<string>(row, COL_DB_Name);
            Notes = Util.wrapNullable<string>(row, COL_DB_Notes);
            Active = Util.wrapNullable<bool>(row, COL_DB_Active);
            Special = Util.wrapNullable<bool>(row, COL_DB_Special);
        }

        public UserAccountRole() { }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static Guid add(Guid userAccountID, string name, string notes, List<int> userAccountAccessEnum)
        {
            Guid id = Guid.NewGuid();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "UserAccountRoles_add",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Name, SqlDbType.NVarChar, name),
                    new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes))
                );

                if (result.IsSuccessful)
                {
                    LOGGING.ActivityLog.add(sqlConnection, userAccountID, id, "Added");
                    UserAccountAccessRoleAssignment.update(sqlConnection, userAccountID, id, userAccountAccessEnum);
                }
            }
            return id;
        }

        public static DataRow get(SqlConnection sqlConnection, Guid id) { return Util.getFirstRow(get(sqlConnection, true, true, id, null, null)); }
        public static DataRow get(Guid id) 
        {
            DataRow row;
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                row = Util.getFirstRow(get(sqlConnection, true, true, id, null, null));
            return row;
        }
        public static DataTable get(bool filterIncludeInactive, bool filterIncludeSpecial, Guid? id, string name, string notes)
        {
            DataTable datatable;
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                datatable = get(sqlConnection, filterIncludeInactive, filterIncludeSpecial, id, name, notes);
            return datatable;
        }
        public static DataTable get(SqlConnection sqlConnection, bool filterIncludeInactive, bool filterIncludeSpecial, Guid? id, string name, string notes)
        {
            SqlQueryResult result = DBConnection.query(
                sqlConnection,
                QueryTypes.FillByAdapter,
                "UserAccountRoles_get",
                    new SqlQueryParameter(COL_FILTER_INCLUDEINACTIVE, SqlDbType.Bit, filterIncludeInactive),
                    new SqlQueryParameter(COL_FILTER_INCLUDESPECIAL, SqlDbType.Bit, filterIncludeSpecial),
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                    new SqlQueryParameter(COL_DB_Name, SqlDbType.NVarChar, Util.wrapNullable(name))
                );
            return result.Datatable;
        }

        public static void update(Guid userAccountID, Guid id, string name, string notes, List<int> userAccountAccessEnum)
        {
            UserAccountRole objOld = new UserAccountRole(id);
            string log = "";
            log = Util.appendChange(log, objOld.Name, name, "Name: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.Notes, notes, "Notes: '{0}' to '{1}'");

            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                if (!string.IsNullOrEmpty(log))
                {
                    SqlQueryResult result = DBConnection.query(
                        sqlConnection,
                        QueryTypes.ExecuteNonQuery,
                        "UserAccountRoles_update",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Name, SqlDbType.NVarChar, Util.wrapNullable(name))
                    );

                    if (result.IsSuccessful)
                        LOGGING.ActivityLog.add(sqlConnection, userAccountID, id, String.Format("Updated: {0}", log));
                }

                UserAccountAccessRoleAssignment.update(sqlConnection, userAccountID, id, userAccountAccessEnum);
            }

        }

        public static void updateActiveStatus(Guid userAccountID, Guid id, bool value)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "UserAccountRoles_update_Active",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Active, SqlDbType.Bit, value)
                );

                if (result.IsSuccessful)
                    LOGGING.ActivityLog.add(sqlConnection, userAccountID, id, "Update Active Status to " + value);
            }
        }

        public static void updateSpecialStatus(Guid userAccountID, Guid id, bool value)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "UserAccountRoles_update_Special",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Special, SqlDbType.Bit, value)
                );

                if (result.IsSuccessful)
                    LOGGING.ActivityLog.add(sqlConnection, userAccountID, id, "Update Special Status to " + value);
            }
        }

        #endregion DATABASE METHODS
        /*******************************************************************************************************/
        #region CLASS METHODS

        public static void populateDropDownList(LIBUtil.Desktop.UserControls.Dropdownlist dropdownlist,string connectionString, bool includeInactive, bool includeSpecial)
        {
            dropdownlist.populate(get(includeInactive, includeSpecial, null, null, null), COL_DB_Name, COL_DB_Id, null);
        }

        public static void populateCheckedListBox(System.Windows.Forms.CheckedListBox checkedlistbox, bool includeInactive, bool includeSpecial)
        {
            LIBUtil.Desktop.UserControls.InputControl_CheckedListBox.populateCheckedListBox(checkedlistbox, get(includeInactive, includeSpecial, null, null, null), COL_DB_Name, COL_DB_Id);
        }

        #endregion CLASS METHODS
        /*******************************************************************************************************/
    }
}

