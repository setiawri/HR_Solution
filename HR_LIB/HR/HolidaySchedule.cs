using System;
using System.Data;
using System.Data.SqlClient;
using LIBUtil;
using LOGGING;

namespace HR_LIB.HR
{
    public class HolidaySchedule
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public Guid Id;
        public DateTime StartDate;
        public int DurationDays;
        public string Description;
        public string Notes;
        public bool Active;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_StartDate = "StartDate";
        public const string COL_DB_DurationDays = "DurationDays";
        public const string COL_DB_Description = "Description";
        public const string COL_DB_Notes = "Notes";
        public const string COL_DB_Active = "Active";

        public const string COL_FILTER_IncludeInactive = "FILTER_IncludeInactive";


        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public HolidaySchedule(Guid id)
        {
            DataRow row = get(id);
            Id = id;
            StartDate = Util.wrapNullable<DateTime>(row, COL_DB_StartDate);
            DurationDays = Util.wrapNullable<int>(row, COL_DB_DurationDays);
            Description = Util.wrapNullable<string>(row, COL_DB_Description);
            Notes = Util.wrapNullable<string>(row, COL_DB_Notes);
            Active = Util.wrapNullable<bool>(row, COL_DB_Active);
            
        }

        public HolidaySchedule() { }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static bool isCombinationExist(Guid? id, DateTime startDate, string description)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.ExecuteNonQuery,
                false, false, false, true, false,
                "HolidaySchedules_iscombinationexist",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                    new SqlQueryParameter(COL_DB_StartDate, SqlDbType.DateTime, startDate),
                    new SqlQueryParameter(COL_DB_Description, SqlDbType.NVarChar, description)
                );
            return result.ValueBoolean;
        }

        public static Guid add(Guid userAccountID, DateTime startDate, int durationDays, string description, string notes)
        {
            Guid id = Guid.NewGuid();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "HolidaySchedules_add",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_StartDate, SqlDbType.Date, startDate),
                    new SqlQueryParameter(COL_DB_DurationDays, SqlDbType.Int, durationDays),
                    new SqlQueryParameter(COL_DB_Description, SqlDbType.NVarChar, description),
                    new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes))
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, "Added");
            }

            return id;
        }

        public static DataRow get(Guid id) { return Util.getFirstRow(get(false, id, null, null, null, null)); }

        public static DataTable get(bool filterIncludeInactive, Guid? id, DateTime? startDate, int? durationDays, string description, string notes)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.FillByAdapter,
                "HolidaySchedules_get",
                    new SqlQueryParameter(COL_FILTER_IncludeInactive, SqlDbType.Bit, filterIncludeInactive),
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                    new SqlQueryParameter(COL_DB_StartDate, SqlDbType.Date, Util.wrapNullable(startDate)),
                    new SqlQueryParameter(COL_DB_DurationDays, SqlDbType.Int, Util.wrapNullable(durationDays)),
                    new SqlQueryParameter(COL_DB_Description, SqlDbType.NVarChar, Util.wrapNullable(description)),
                    new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes))
                );
            return result.Datatable;
        }


        public static void update(Guid userAccountID, Guid id, DateTime startDate, int durationDays, string description, string notes)
        {
            HolidaySchedule objOld = new HolidaySchedule(id);
            string log = "";
            log = Util.appendChange(log, objOld.StartDate, startDate, "StartDate: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.DurationDays, durationDays, "Owner Ref Id: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.Description, description, "Description: '{0}' to '{1}'");
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
                        "HolidaySchedules_update",
                        new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                        new SqlQueryParameter(COL_DB_StartDate, SqlDbType.DateTime, startDate),
                        new SqlQueryParameter(COL_DB_DurationDays, SqlDbType.Int, durationDays),
                        new SqlQueryParameter(COL_DB_Description, SqlDbType.NVarChar, description),
                        new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes))
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
                    "HolidaySchedules_update_Active",
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


