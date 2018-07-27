using System;
using System.Data;
using System.Data.SqlClient;
using LIBUtil;
using LOGGING;

namespace HR_LIB.HR
{
    public class WorkshiftCategory
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public Guid Id;
        public string Name = "";
        public string Notes = "";
        public bool Active;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_Name = "Name";
        public const string COL_DB_Notes = "Notes";
        public const string COL_DB_Active = "Active";

        public const string COL_FILTER_IncludeInactive = "FILTER_IncludeInactive";

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public WorkshiftCategory(Guid id) : this(null, id) { }
        public WorkshiftCategory(SqlConnection sqlConnection, Guid id)
        {
            DataRow row;
            if (sqlConnection == null)
                row = get(id);
            else
                row = get(sqlConnection, id);


            if(row != null)
            {

                Id = id;
                Name = Util.wrapNullable<string>(row, COL_DB_Name);
                Notes = Util.wrapNullable<string>(row, COL_DB_Notes);
                Active = Util.wrapNullable<bool>(row, COL_DB_Active);
            }
            return;
        }

        public WorkshiftCategory() { }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static bool isNameExist(Guid? id, string name)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.ExecuteNonQuery,
                false, false, false, true, false,
                "WorkshiftCategories_isexist_Name",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                new SqlQueryParameter(COL_DB_Name, SqlDbType.NVarChar, name)
                );
            return result.ValueBoolean;
        }

        public static Guid add(Guid userAccountID, string name, string notes)
        {
            Guid id = Guid.NewGuid();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "WorkshiftCategories_add",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Name, SqlDbType.NVarChar, name),
                    new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, notes)
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, "Added");
            }
            return id;
        }

        public static DataRow get(SqlConnection sqlConnection, Guid id) { return Util.getFirstRow(get(sqlConnection, true, id, null, null)); }
        public static DataRow get(Guid id)
        {
            DataRow row;
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                row = Util.getFirstRow(get(sqlConnection, true, id, null, null));
            return row;
        }
        public static DataTable get(bool filterIncludeInactive, Guid? id, string name, string notes)
        {
            DataTable datatable;
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                datatable = get(sqlConnection, filterIncludeInactive, id, name, notes);
            return datatable;
        }
        public static DataTable get(SqlConnection sqlConnection, bool filterIncludeInactive, Guid? id, string name, string notes)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.FillByAdapter,
                "WorkshiftCategories_get",
                    new SqlQueryParameter(COL_FILTER_IncludeInactive, SqlDbType.Bit, filterIncludeInactive),
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                    new SqlQueryParameter(COL_DB_Name, SqlDbType.NVarChar, Util.wrapNullable(name)),
                    new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes))
                );
            return result.Datatable;
        }

        public static void update(Guid userAccountID, Guid id, string name, string notes)
        {
            WorkshiftCategory objOld = new WorkshiftCategory(id);
            string log = "";
            log = Util.appendChange(log, objOld.Name, name, "Name: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.Notes, notes, "Notes: '{0}' to '{1}'");

            if (string.IsNullOrEmpty(log))
                Util.displayMessageBoxError("No changes to record");
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlQueryResult result = DBConnection.query(
                        sqlConnection,
                        QueryTypes.ExecuteNonQuery,
                        "WorkshiftCategories_update",
                        new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                        new SqlQueryParameter(COL_DB_Name, SqlDbType.NVarChar, name),
                        new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, notes)
                    );

                    if (result.IsSuccessful)
                        ActivityLog.add(sqlConnection, userAccountID, id, String.Format("Updated: {0}", log));
                }
            }
        }

        public static void updateActiveStatus(Guid userAccountID, Guid id, bool value)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "WorkshiftCategories_update_Active",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Active, SqlDbType.Bit, value)
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, "Update Active Status to " + value);
            }
        }

        #endregion DATABASE METHODS
        /*******************************************************************************************************/
        #region CLASS METHODS
        #endregion CLASS METHODS
        /*******************************************************************************************************/
    }
}

