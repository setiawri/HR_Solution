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

        public string UserAccounts_Fullname;


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

        public const string COL_UserAccounts_Fullname = "UserAccounts_Fullname";

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Attendance(Guid id)
        {
            DataRow row = get(id);

            Id = id;
            UserAccounts_Id = Util.wrapNullable<Guid>(row, COL_DB_UserAccounts_Id);
            TimestampIn = Util.wrapNullable<DateTime>(row, COL_DB_TimestampIn);
            TimestampOut = Util.wrapNullable<DateTime>(row, COL_DB_TimestampOut);
            Notes = Util.wrapNullable<string>(row, COL_DB_Notes);
            Flag1 = Util.wrapNullable<bool>(row, COL_DB_Flag1);
            Flag2 = Util.wrapNullable<bool>(row, COL_DB_Flag2);
            Approved = Util.wrapNullable<bool>(row, COL_DB_Approved);

            UserAccounts_Fullname = Util.wrapNullable<string>(row, COL_UserAccounts_Fullname);
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
                "Attendance_iscombinationexist",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                new SqlQueryParameter(COL_DB_UserAccounts_Id, SqlDbType.UniqueIdentifier, UserAccounts_Id),
                new SqlQueryParameter(COL_DB_TimestampIn, SqlDbType.DateTime, timestampIn)

                );
            return result.ValueBoolean;
        }

        public static Guid add(Guid userAccountID, Guid UserAccounts_Id, DateTime timestampIn, DateTime timestampOut ,
            string notes)
        {
            Guid id = Guid.NewGuid();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "Attendance_add",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_UserAccounts_Id, SqlDbType.UniqueIdentifier, UserAccounts_Id),
                    new SqlQueryParameter(COL_DB_TimestampIn, SqlDbType.DateTime, timestampIn),
                    new SqlQueryParameter(COL_DB_TimestampOut, SqlDbType.DateTime, timestampOut),
                    new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes)
                    )
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, "Added");
            }
            return id;
        }

        public static DataRow get(SqlConnection sqlConnection, Guid id)
        {
            return Util.getFirstRow(get(sqlConnection, id, null, null));
        }
        public static DataRow get(Guid id)
        {
            DataRow row;
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                row = Util.getFirstRow(get(sqlConnection, id, null, null));
            return row;
        }
        public static DataTable get(Guid? id, Guid? UserAccounts_Id, string notes)
        {
            DataTable datatable;
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                datatable = get(sqlConnection, id, UserAccounts_Id, notes);
            return datatable;
        }
        public static DataTable get(SqlConnection sqlConnection, Guid? id, Guid? UserAccounts_Id, string notes)
        {
            SqlQueryResult result = DBConnection.query(
                sqlConnection,
                QueryTypes.FillByAdapter,
                "Attendance_get",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                new SqlQueryParameter(COL_DB_UserAccounts_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(UserAccounts_Id)),
                new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes))
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
                        "Attendance_update",
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
                    "Attendance_update_Flag1",
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
                    "Attendance_update_Flag2",
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
                    "Attendance_update_Approved",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Approved, SqlDbType.Bit, value)
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, "Update Approved to " + value);
            }
        }

        public static void delete(Guid userAccountID, Guid id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "Attendance_delete",
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

