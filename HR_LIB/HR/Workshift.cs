using System;
using System.Data;
using System.Data.SqlClient;
using LIBUtil;
using LOGGING;
using LOGIN;

namespace HR_LIB.HR
{
    public class Workshift
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public Guid Id;
        public string Name;
        public Guid Clients_Id;
        public Guid UserAccounts_Id;
        public Guid WorkshiftCategories_Id;
        public DayOfWeek DayOfWeek;
        public TimeSpan Start;
        public int DurationMinutes;
        public decimal PayableAmount;
        public string Notes;
        public bool Active;

        public string Clients_CompanyName;
        public string UserAccounts_Fullname;
        public string WorkshiftCategories_Name;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_Name = "Name";
        public const string COL_DB_Clients_Id = "Clients_Id";
        public const string COL_DB_UserAccounts_Id = "UserAccounts_Id";
        public const string COL_DB_WorkshiftCategories_Id = "WorkshiftCategories_Id";
        public const string COL_DB_DayOfWeek = "DayOfWeek";
        public const string COL_DB_Start = "Start";
        public const string COL_DB_DurationMinutes = "DurationMinutes";
        public const string COL_DB_PayableAmount = "PayableAmount";
        public const string COL_DB_Notes = "Notes";
        public const string COL_DB_Active = "Active";

        public const string COL_Clients_CompanyName = "Clients_CompanyName";
        public const string COL_UserAccounts_Fullname = "UserAccounts_Fullname";
        public const string COL_WorkshiftCategories_Name = "WorkshiftCategories_Name";
        public const string COL_DayOfWeekName = "Day_Of_Week_Name";
        public const string COL_FILTER_IncludeInactive = "FILTER_IncludeInactive";
        public const string FILTER_StartDate = "FILTER_StartDate";
        public const string FILTER_EndDate = "FILTER_EndDate";


        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Workshift(Guid id)
        {
            DataRow row = get(id);
            if(row != null)
            {
                Id = id;
                Name = Util.wrapNullable<string>(row, COL_DB_Name);
                Clients_Id = Util.wrapNullable<Guid>(row, COL_DB_Clients_Id);
                UserAccounts_Id = Util.wrapNullable<Guid>(row, COL_DB_UserAccounts_Id);
                WorkshiftCategories_Id = Util.wrapNullable<Guid>(row, COL_DB_WorkshiftCategories_Id);
                DayOfWeek = Util.parseEnum<DayOfWeek>(Util.wrapNullable<int>(row, COL_DB_DayOfWeek));
                Start = Util.wrapNullable<TimeSpan>(row, COL_DB_Start);
                DurationMinutes = Util.wrapNullable<int>(row, COL_DB_DurationMinutes);
                PayableAmount = Util.wrapNullable<decimal>(row, COL_DB_PayableAmount);
                Notes = Util.wrapNullable<string>(row, COL_DB_Notes);
                Active = Util.wrapNullable<bool>(row, COL_DB_Active);

                Clients_CompanyName = Util.wrapNullable<string>(row, COL_Clients_CompanyName);
                UserAccounts_Fullname = Util.wrapNullable<string>(row, COL_UserAccounts_Fullname);
                WorkshiftCategories_Name = Util.wrapNullable<string>(row, COL_WorkshiftCategories_Name);
            }
        }

        public Workshift() { }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static bool isCombinationExist(Guid? id, string name, Guid Clients_Id, Guid? UserAccounts_Id, DayOfWeek dayOfWeek, string start)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.ExecuteNonQuery,
                false, false, false, true, false,
                "Workshifts_iscombinationexist",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                    new SqlQueryParameter(COL_DB_Name, SqlDbType.NVarChar,name),
                    new SqlQueryParameter(COL_DB_Clients_Id, SqlDbType.UniqueIdentifier, Clients_Id),
                    new SqlQueryParameter(COL_DB_UserAccounts_Id, SqlDbType.UniqueIdentifier, UserAccounts_Id),
                    new SqlQueryParameter(COL_DB_DayOfWeek, SqlDbType.Int, (int)dayOfWeek),
                    new SqlQueryParameter(COL_DB_Start, SqlDbType.NVarChar, start)
                );
            return result.ValueBoolean;
        }

        public static Guid add(Guid userAccountID, string name, Guid Clients_Id, Guid? UserAccounts_Id, Guid WorkshiftCategories_Id, DayOfWeek dayOfWeek, string start, int durationMinutes, decimal? payableAmount, string notes)
        {
            Guid id = Guid.NewGuid();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "Workshifts_add",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Name, SqlDbType.NVarChar, name),
                    new SqlQueryParameter(COL_DB_Clients_Id, SqlDbType.UniqueIdentifier, Clients_Id),
                    new SqlQueryParameter(COL_DB_UserAccounts_Id, SqlDbType.UniqueIdentifier, UserAccounts_Id),
                    new SqlQueryParameter(COL_DB_WorkshiftCategories_Id, SqlDbType.UniqueIdentifier, WorkshiftCategories_Id),
                    new SqlQueryParameter(COL_DB_DayOfWeek, SqlDbType.Int, (int)dayOfWeek),
                    new SqlQueryParameter(COL_DB_Start, SqlDbType.Time, Util.wrapNullable<TimeSpan?>(start)),
                    new SqlQueryParameter(COL_DB_DurationMinutes, SqlDbType.Int, Util.wrapNullable<int>(durationMinutes)),
                    new SqlQueryParameter(COL_DB_PayableAmount, SqlDbType.Decimal, Util.wrapNullable<decimal>(payableAmount)),
                    new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes))
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, "Added");
            }

            return id;
        }

        public static DataRow get(Guid id) { return Util.getFirstRow(get(true, id, null, null, null, null, null, null, null, null, null)); }

        public static DataTable get(bool filterIncludeInactive, Guid? id, string name, Guid? Clients_Id, Guid? UserAccounts_Id, Guid? WorkshiftCategories_Id, int? dayOfWeek, 
            TimeSpan? start, int? durationMinutes, decimal? payableAmount, string notes)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.FillByAdapter,
                "Workshifts_get",
                    new SqlQueryParameter(COL_FILTER_IncludeInactive, SqlDbType.Bit, filterIncludeInactive),
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                    new SqlQueryParameter(COL_DB_Name, SqlDbType.NVarChar, Util.wrapNullable(name)),
                    new SqlQueryParameter(COL_DB_Clients_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(Clients_Id)),
                    new SqlQueryParameter(COL_DB_UserAccounts_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(UserAccounts_Id)),
                    new SqlQueryParameter(COL_DB_WorkshiftCategories_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(WorkshiftCategories_Id)),
                    new SqlQueryParameter(COL_DB_DayOfWeek, SqlDbType.TinyInt, Util.wrapNullable<int?>(dayOfWeek)),
                    new SqlQueryParameter(COL_DB_Start, SqlDbType.Time, Util.wrapNullable<TimeSpan?>(start)),
                    new SqlQueryParameter(COL_DB_DurationMinutes, SqlDbType.Int, Util.wrapNullable<int?>(durationMinutes)),
                    new SqlQueryParameter(COL_DB_PayableAmount, SqlDbType.Decimal, Util.wrapNullable<decimal?>(payableAmount)),
                    new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes))
                );
            return result.Datatable;
        }

        public static DataTable getEmployeeByClientOrName(Guid? Clients_Id, DateTime? startDate, DateTime? endDate, string employeeName)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.FillByAdapter,
                "Workshifts_getEmployeeByClientOrName",
                    new SqlQueryParameter(COL_DB_Clients_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(Clients_Id)),
                    new SqlQueryParameter(FILTER_StartDate, SqlDbType.DateTime, Util.wrapNullable(startDate)),
                    new SqlQueryParameter(FILTER_EndDate, SqlDbType.DateTime, Util.wrapNullable(endDate)),
                    new SqlQueryParameter(COL_UserAccounts_Fullname, SqlDbType.NVarChar, Util.wrapNullable(employeeName))
                );
            return result.Datatable;
        }


        public static void update(Guid userAccountID, Guid id, string name, Guid UserAccounts_Id, Guid WorkshiftCategories_Id, DayOfWeek dayOfWeek, string start, int durationMinutes, decimal payableAmount, string notes)
        {
            Workshift objOld = new Workshift(id);
            string log = "";
            log = Util.appendChange(log, objOld.Name, name, "Name: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.WorkshiftCategories_Name, new WorkshiftCategory(WorkshiftCategories_Id).Name, "Workshift Category: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.UserAccounts_Fullname, new UserAccount(UserAccounts_Id).Fullname, "User: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.DayOfWeek, dayOfWeek, "Day of week: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.Start.ToString(@"h\:mm"), start, "Start: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.DurationMinutes, durationMinutes, "Duration Minutes: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.PayableAmount, payableAmount, "Payable Amount: '{0}' to '{1}'");
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
                        "Workshifts_update",
                        new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                        new SqlQueryParameter(COL_DB_Name, SqlDbType.NVarChar, name),
                        new SqlQueryParameter(COL_DB_UserAccounts_Id, SqlDbType.UniqueIdentifier, UserAccounts_Id),
                        new SqlQueryParameter(COL_DB_WorkshiftCategories_Id, SqlDbType.UniqueIdentifier, WorkshiftCategories_Id),
                        new SqlQueryParameter(COL_DB_DayOfWeek, SqlDbType.Int, (int)dayOfWeek),
                        new SqlQueryParameter(COL_DB_Start, SqlDbType.Time, Util.wrapNullable<TimeSpan?>(start)),
                        new SqlQueryParameter(COL_DB_DurationMinutes, SqlDbType.Int, Util.wrapNullable<int>(durationMinutes)),
                        new SqlQueryParameter(COL_DB_PayableAmount, SqlDbType.Decimal, Util.wrapNullable<decimal>(payableAmount)),
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
                    "Workshifts_update_Active",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Active, SqlDbType.Bit, value)
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, "Update Active Status to " + value);
            }
        }


        public static void delete(Guid userAccountID, Guid id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "Workshifts_delete",
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


