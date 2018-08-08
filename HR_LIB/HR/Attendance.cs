using System;
using System.Data;
using System.Data.SqlClient;
using LIBUtil;
using LOGGING;

namespace HR_LIB.HR
{
    public class Attendance
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public Guid Id;
        public Guid UserAccounts_Id;
        public DateTime TimestampIn;
        public DateTime TimestampOut;
        public string Notes;
        public bool Flag1;
        public bool Flag2;
        public bool Approved;
        public Guid Clients_Id;
        public DayOfWeek Workshifts_DayOfWeek;
        public TimeSpan Workshifts_Start;
        public int Workshifts_DurationMinutes;
        public DateTime EffectiveTimestampIn;
        public DateTime EffectiveTimestampOut;
        public bool Rejected;
        public Guid? PayrollItems_Id;
        public Guid AttendanceStatuses_Id;

        public string UserAccounts_Fullname;
        public string Clients_CompanyName;
        public string AttendanceStatuses_Name;
        public Guid Workshifts_Id;
        public string Workshifts_Name;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_UserAccounts_Id = "UserAccounts_Id";
        public const string COL_DB_TimestampIn = "TimestampIn";
        public const string COL_DB_TimestampOut = "TimestampOut";
        public const string COL_DB_Notes = "Notes";
        public const string COL_DB_Flag1 = "Flag1";
        public const string COL_DB_Flag2 = "Flag2";
        public const string COL_DB_Approved = "Approved";
        public const string COL_DB_Clients_Id = "Clients_Id";
        public const string COL_DB_Workshifts_DayOfWeek = "Workshifts_DayOfWeek";
        public const string COL_DB_Workshifts_Start = "Workshifts_Start";
        public const string COL_DB_Workshifts_DurationMinutes = "Workshifts_DurationMinutes";
        public const string COL_DB_EffectiveTimestampIn = "EffectiveTimestampIn";
        public const string COL_DB_EffectiveTimestampOut = "EffectiveTimestampOut";
        public const string COL_DB_Rejected = "Rejected";
        public const string COL_DB_PayrollItems_Id = "PayrollItems_Id";
        public const string COL_DB_AttendanceStatuses_Id = "AttendanceStatuses_Id";

        public const string COL_EffectiveWorkHours = "EffectiveWorkHours";
        public const string COL_UserAccounts_Fullname = "UserAccounts_Fullname";
        public const string COL_Clients_CompanyName = "Clients_CompanyName";
        public const string COL_Workshifts_Id = "Workshifts_Id";
        public const string COL_Workshifts_Name = "Workshifts_Name";
        public const string COL_AttendanceStatuses_Name = "AttendanceStatuses_Name";
        public const string COL_Workshifts_DayOfWeek_Name = "Workshifts_DayOfWeek_Name";
        public const string FILTER_DayOfWeek = "FILTER_DayOfWeek";
        public const string FILTER_StartDate = "FILTER_StartDate";
        public const string FILTER_EndDate = "FILTER_EndDate";
        public const string FILTER_StartTime = "FILTER_StartTime";
        public const string FILTER_EndTime = "FILTER_EndTime";

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Attendance(Guid id)
        {
            DataRow row = get(id);

            if(row != null)
            {
                Id = id;
                UserAccounts_Id = Util.wrapNullable<Guid>(row, COL_DB_UserAccounts_Id);
                TimestampIn = Util.wrapNullable<DateTime>(row, COL_DB_TimestampIn);
                TimestampOut = Util.wrapNullable<DateTime>(row, COL_DB_TimestampOut);
                Notes = Util.wrapNullable<string>(row, COL_DB_Notes);
                Flag1 = Util.wrapNullable<bool>(row, COL_DB_Flag1);
                Flag2 = Util.wrapNullable<bool>(row, COL_DB_Flag2);
                Approved = Util.wrapNullable<bool>(row, COL_DB_Approved);
                Clients_Id = Util.wrapNullable<Guid>(row, COL_DB_Clients_Id);
                Workshifts_DayOfWeek = Util.parseEnum<DayOfWeek>(Util.wrapNullable<int>(row, COL_DB_Workshifts_DayOfWeek));
                Workshifts_Start = Util.wrapNullable<TimeSpan>(row, COL_DB_Workshifts_Start);
                Workshifts_DurationMinutes = Util.wrapNullable<int>(row, COL_DB_Workshifts_DurationMinutes);
                EffectiveTimestampIn = Util.wrapNullable<DateTime>(row, COL_DB_EffectiveTimestampIn);
                EffectiveTimestampOut = Util.wrapNullable<DateTime>(row, COL_DB_EffectiveTimestampOut);
                Rejected = Util.wrapNullable<bool>(row, COL_DB_Rejected);
                PayrollItems_Id = Util.wrapNullable<Guid?>(row, COL_DB_PayrollItems_Id);
                AttendanceStatuses_Id = Util.wrapNullable<Guid>(row, COL_DB_AttendanceStatuses_Id);

                UserAccounts_Fullname = Util.wrapNullable<string>(row, COL_UserAccounts_Fullname);
                Clients_CompanyName = Util.wrapNullable<string>(row, COL_Clients_CompanyName);
                AttendanceStatuses_Name = Util.wrapNullable<string>(row, COL_AttendanceStatuses_Name);
                Workshifts_Id = Util.wrapNullable<Guid>(row, COL_Workshifts_Id);
                Workshifts_Name = Util.wrapNullable<string>(row, COL_Workshifts_Name);
            }
        }

        public Attendance() { }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static bool isCombinationExist(Guid? id,Guid UserAccounts_Id, DateTime timestampIn)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.ExecuteNonQuery,
                false, false, false, true, false,
                "Attendances_iscombinationexist",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                new SqlQueryParameter(COL_DB_UserAccounts_Id, SqlDbType.UniqueIdentifier, UserAccounts_Id),
                new SqlQueryParameter(COL_DB_TimestampIn, SqlDbType.DateTime, timestampIn)

                );
            return result.ValueBoolean;
        }

        public static Guid add(Guid userAccountID, Guid UserAccounts_Id, Guid? Clients_Id, Guid? Workshifts_Id,
            DateTime timestampIn, DateTime timestampOut, DateTime? effectiveTimestampIn, DateTime? effectiveTimestampOut, 
            string notes, Guid AttendanceStatuses_Id)
        {
            Guid id = Guid.NewGuid();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "Attendances_add",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_UserAccounts_Id, SqlDbType.UniqueIdentifier, UserAccounts_Id),
                    new SqlQueryParameter(COL_DB_Clients_Id, SqlDbType.UniqueIdentifier, Clients_Id),
                    new SqlQueryParameter(COL_Workshifts_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(Workshifts_Id)),
                    new SqlQueryParameter(COL_DB_TimestampIn, SqlDbType.DateTime, timestampIn),
                    new SqlQueryParameter(COL_DB_TimestampOut, SqlDbType.DateTime, timestampOut),
                    new SqlQueryParameter(COL_DB_EffectiveTimestampIn, SqlDbType.DateTime, effectiveTimestampIn),
                    new SqlQueryParameter(COL_DB_EffectiveTimestampOut, SqlDbType.DateTime, effectiveTimestampOut),
                    new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes)),
                    new SqlQueryParameter(COL_DB_AttendanceStatuses_Id, SqlDbType.UniqueIdentifier, AttendanceStatuses_Id)
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, "Added");
            }
            return id;
        }

        public static DataRow get(SqlConnection sqlConnection, Guid id)
        {
            return Util.getFirstRow(get(sqlConnection, id, null, null, null, null, null, null, null, null, null, null));
        }
        public static DataRow get(Guid id)
        {
            DataRow row;
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                row = Util.getFirstRow(get(sqlConnection, id, null, null, null, null, null, null, null, null, null, null));
            return row;
        }
        public static DataTable get(Guid? id, Guid? UserAccounts_Id, Guid? Clients_Id, Guid? Workshifts_Id, int? dayOfWeek, DateTime? startDate, 
            DateTime? endDate, TimeSpan? startTime, TimeSpan? endTime, string notes, Guid? AttendanceStatuses_Id)
        {
            DataTable datatable;
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                datatable = get(sqlConnection, id, UserAccounts_Id, Clients_Id, Workshifts_Id, dayOfWeek, startDate, endDate, startTime, endTime, notes, AttendanceStatuses_Id);
            return datatable;
        }
        public static DataTable get(SqlConnection sqlConnection, Guid? id, Guid? UserAccounts_Id, Guid? Clients_Id, Guid? Workshifts_Id, int? dayOfWeek, 
            DateTime? startDate, DateTime? endDate, TimeSpan? startTime, TimeSpan? endTime, string notes, Guid? AttendanceStatuses_Id)
        {
            SqlQueryResult result = DBConnection.query(
                sqlConnection,
                QueryTypes.FillByAdapter,
                "Attendances_get",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                new SqlQueryParameter(COL_DB_UserAccounts_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(UserAccounts_Id)),
                new SqlQueryParameter(COL_DB_Clients_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(Clients_Id)),
                new SqlQueryParameter(COL_Workshifts_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(Workshifts_Id)),
                new SqlQueryParameter(FILTER_DayOfWeek, SqlDbType.TinyInt, Util.wrapNullable<int?>(dayOfWeek)),
                new SqlQueryParameter(FILTER_StartDate, SqlDbType.DateTime, Util.wrapNullable(startDate)),
                new SqlQueryParameter(FILTER_EndDate, SqlDbType.DateTime, Util.wrapNullable(endDate)),
                new SqlQueryParameter(FILTER_StartTime, SqlDbType.Time, Util.wrapNullable(startTime)),
                new SqlQueryParameter(FILTER_EndTime, SqlDbType.Time, Util.wrapNullable(endTime)),
                new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes)),
                new SqlQueryParameter(COL_DB_AttendanceStatuses_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(AttendanceStatuses_Id))

                );
            return result.Datatable;
        }

        public static void update(Guid userAccountID, Guid id, DateTime timestampIn, DateTime timestampOut,string notes)
        {
            Attendance objOld = new Attendance(id);
            string log = "";
            log = Util.appendChange(log, objOld.TimestampIn, timestampIn, "TimestampIn: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.TimestampOut, timestampOut, "TimestampOut: '{0}' to '{1}'");
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
                        "Attendances_update",
                        new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                        new SqlQueryParameter(COL_DB_TimestampIn, SqlDbType.DateTime, timestampIn),
                        new SqlQueryParameter(COL_DB_TimestampOut, SqlDbType.DateTime, timestampOut),
                        new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes))
                    );

                    if (result.IsSuccessful)
                        ActivityLog.add(sqlConnection, userAccountID, id, String.Format("Updated: {0}", log));
                }
            }
        }

        public static void updateFlag1Status(Guid userAccountID, Guid id, bool value)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "Attendances_update_Flag1",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Flag1, SqlDbType.Bit, value)
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, "Update Flag 1 to " + value);
            }
        }

        public static void updateFlag2Status(Guid userAccountID, Guid id, bool value)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "Attendances_update_Flag2",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Flag2, SqlDbType.Bit, value)
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, "Update Flag 2 to " + value);
            }
        }

        public static void updateApprovedStatus(Guid userAccountID, Guid id, bool value)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "Attendances_update_Approved",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Approved, SqlDbType.Bit, value)
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, "Update Approved to " + value);
            }
        }

        public static void updateRejectedStatus(Guid userAccountID, Guid id, bool value)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "Attendances_update_Rejected",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Rejected, SqlDbType.Bit, value)
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, "Update Rejected to " + value);
            }
        }

        public static void delete(Guid userAccountID, Guid id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "Attendances_delete",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id)
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, String.Format("Deleted"));
            }
        }

        #endregion DATABASE METHODS
        /*******************************************************************************************************/
        #region CLASS METHODS

        #endregion CLASS METHODS
        /*******************************************************************************************************/
    }
}

