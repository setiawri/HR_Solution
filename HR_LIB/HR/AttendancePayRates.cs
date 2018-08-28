using System;
using System.Data;
using System.Data.SqlClient;
using LIBUtil;
using LOGGING;

namespace HR_LIB.HR
{
    public class AttendancePayRate
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public Guid Id;
        public Guid RefId;
        public Guid AttendanceStatuses_Id;
        public decimal Amount;
        public string Notes;
        public bool Active;

        public string Workshifts_Name;
        public string WorkshiftTemplates_Name;
        public string AttendanceStatuses_Name;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_RefId = "RefId";
        public const string COL_DB_AttendanceStatuses_Id = "AttendanceStatuses_Id";
        public const string COL_DB_Amount = "Amount";
        public const string COL_DB_Notes = "Notes";
        public const string COL_DB_Active = "Active";

        public const string COL_Workshifts_Name = "Workshifts_Name";
        public const string COL_WorkshiftTemplates_Name = "WorkshiftTemplates_Name";
        public const string COL_AttendanceStatuses_Name = "AttendanceStatuses_Name";
        public const string COL_FILTER_IncludeInactive = "FILTER_IncludeInactive";

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public AttendancePayRate(Guid id)
        {
            DataRow row = get(id);
            if(row != null)
            {
                Id = id;
                RefId = Util.wrapNullable<Guid>(row, COL_DB_RefId);
                AttendanceStatuses_Id = Util.wrapNullable<Guid>(row, COL_DB_AttendanceStatuses_Id);
                Amount = Util.wrapNullable<decimal>(row, COL_DB_Amount);
                Notes = Util.wrapNullable<string>(row, COL_DB_Notes);
                Active = Util.wrapNullable<bool>(row, COL_DB_Active);

                Workshifts_Name = Util.wrapNullable<string>(row, COL_Workshifts_Name);
                WorkshiftTemplates_Name = Util.wrapNullable<string>(row, COL_WorkshiftTemplates_Name);
                AttendanceStatuses_Name = Util.wrapNullable<string>(row, COL_AttendanceStatuses_Name);
            }
        }

        public AttendancePayRate() { }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static bool isCombinationExist(Guid? id, Guid refId, Guid AttendanceStatuses_Id)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.ExecuteNonQuery,
                false, false, false, true, false,
                "AttendancePayRates_iscombinationexist",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                    new SqlQueryParameter(COL_DB_RefId, SqlDbType.UniqueIdentifier, refId), 
                    new SqlQueryParameter(COL_DB_AttendanceStatuses_Id, SqlDbType.UniqueIdentifier, AttendanceStatuses_Id)
                );
            return result.ValueBoolean;
        }

        public static Guid add(Guid userAccountID, Guid refId, Guid AttendanceStatuses_Id, decimal? amount, string notes)
        {
            Guid id = Guid.NewGuid();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "AttendancePayRates_add",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_RefId, SqlDbType.UniqueIdentifier, refId),
                    new SqlQueryParameter(COL_DB_AttendanceStatuses_Id, SqlDbType.UniqueIdentifier, AttendanceStatuses_Id),
                    new SqlQueryParameter(COL_DB_Amount, SqlDbType.Decimal,amount),
                    new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes))
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, "Added");
            }

            return id;
        }

        public static DataRow get(Guid id) { return Util.getFirstRow(get(true, id, null, null, null, null)); }

        public static DataTable get(bool filterIncludeInactive, Guid? id, Guid? refId, Guid? AttendanceStatuses_Id, decimal? amount, string notes)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.FillByAdapter,
                "AttendancePayRates_get",
                    new SqlQueryParameter(COL_FILTER_IncludeInactive, SqlDbType.Bit, filterIncludeInactive),
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                    new SqlQueryParameter(COL_DB_RefId, SqlDbType.UniqueIdentifier, Util.wrapNullable(refId)),
                    new SqlQueryParameter(COL_DB_AttendanceStatuses_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(AttendanceStatuses_Id)),
                    new SqlQueryParameter(COL_DB_Amount, SqlDbType.Decimal, Util.wrapNullable<decimal?>(amount)),
                    new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes))
                );
            return result.Datatable;
        }


        public static void update(Guid userAccountID, Guid id, decimal amount, string notes)
        {
            AttendancePayRate objOld = new AttendancePayRate(id);
            string log = "";
            log = Util.appendChange(log, objOld.Amount, amount, "Amount: '{0}' to '{1}'");
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
                        "AttendancePayRates_update",
                        new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                        new SqlQueryParameter(COL_DB_Amount, SqlDbType.Decimal, amount),
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
                    "AttendancePayRates_update_Active",
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


