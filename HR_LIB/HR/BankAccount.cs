using System;
using System.Data;
using System.Data.SqlClient;
using LIBUtil;
using LOGGING;
using LOGIN;

namespace HR_LIB.HR
{
    public class BankAccount
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public Guid Id;
        public string Name;
        public Guid Owner_RefId;
        public string BankName;
        public string AccountNumber;
        public string Notes;
        public bool Active;
        public bool Internal;


        public string Clients_CompanyName;
        public string UserAccounts_Fullname;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_Name = "Name";
        public const string COL_DB_Owner_RefId = "Owner_RefId";
        public const string COL_DB_BankName = "BankName";
        public const string COL_DB_AccountNumber = "AccountNumber";
        public const string COL_DB_Notes = "Notes";
        public const string COL_DB_Active = "Active";
        public const string COL_DB_Internal = "Internal";

        public const string COL_FILTER_IncludeInactive = "FILTER_IncludeInactive";
        public const string COL_FILTER_Employee = "FILTER_Employee";
        public const string COL_Clients_CompanyName = "Clients_CompanyName";
        public const string COL_UserAccounts_Fullname = "UserAccounts_Fullname";


        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public BankAccount(Guid id)
        {
            DataRow row = get(id);
            if (row != null)
            {
                Id = id;
                Name = Util.wrapNullable<string>(row, COL_DB_Name);
                Owner_RefId = Util.wrapNullable<Guid>(row, COL_DB_Owner_RefId);
                BankName = Util.wrapNullable<string>(row, COL_DB_BankName);
                AccountNumber = Util.wrapNullable<string>(row, COL_DB_AccountNumber);
                Notes = Util.wrapNullable<string>(row, COL_DB_Notes);
                Active = Util.wrapNullable<bool>(row, COL_DB_Active);
                Internal = Util.wrapNullable<bool>(row, COL_DB_Internal);

                Clients_CompanyName = Util.wrapNullable<string>(row, COL_Clients_CompanyName);
                UserAccounts_Fullname = Util.wrapNullable<string>(row, COL_UserAccounts_Fullname);
            }
        }

        public BankAccount() { }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static bool isCombinationExist(Guid? id, Guid owner_RefId, string accountNumber)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.ExecuteNonQuery,
                false, false, false, true, false,
                "BankAccounts_iscombinationexist",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                    new SqlQueryParameter(COL_DB_Owner_RefId, SqlDbType.UniqueIdentifier, owner_RefId),
                    new SqlQueryParameter(COL_DB_AccountNumber, SqlDbType.NVarChar, accountNumber)
                );
            return result.ValueBoolean;
        }

        public static Guid add(Guid userAccountID, string name, Guid owner_RefId, string bankName, string accountNumber, string notes)
        {
            Guid id = Guid.NewGuid();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "BankAccounts_add",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Name, SqlDbType.NVarChar, name),
                    new SqlQueryParameter(COL_DB_Owner_RefId, SqlDbType.UniqueIdentifier, owner_RefId),
                    new SqlQueryParameter(COL_DB_BankName, SqlDbType.NVarChar, bankName),
                    new SqlQueryParameter(COL_DB_AccountNumber, SqlDbType.NVarChar, accountNumber),
                    new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes))
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, "Added");
            }

            return id;
        }

        public static DataRow get(Guid id) { return Util.getFirstRow(get(false, id, null, null, null, null, null, null, null)); }

        public static DataTable get(bool filterIncludeInactive, Guid? id, string name, Guid? owner_RefId, string bankName, string accountNumber, string notes, bool? Internal, bool? filterEmployee)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.FillByAdapter,
                "BankAccounts_get",
                    new SqlQueryParameter(COL_FILTER_IncludeInactive, SqlDbType.Bit, filterIncludeInactive),
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                    new SqlQueryParameter(COL_DB_Name, SqlDbType.NVarChar, Util.wrapNullable(name)),
                    new SqlQueryParameter(COL_DB_Owner_RefId, SqlDbType.UniqueIdentifier, Util.wrapNullable(owner_RefId)),
                    new SqlQueryParameter(COL_DB_BankName, SqlDbType.NVarChar, Util.wrapNullable(bankName)),
                    new SqlQueryParameter(COL_DB_AccountNumber, SqlDbType.NVarChar, Util.wrapNullable(accountNumber)),
                    new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes)),
                    new SqlQueryParameter(COL_DB_Internal, SqlDbType.Bit, Internal),
                    new SqlQueryParameter(COL_FILTER_Employee, SqlDbType.Bit, filterEmployee)

                );
            return result.Datatable;
        }


        public static void update(Guid userAccountID, Guid id, string name, Guid owner_RefId, string bankName, string accountNumber, string notes)
        {
            BankAccount objOld = new BankAccount(id);
            string log = "";
            log = Util.appendChange(log, objOld.Name, name, "Name: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.BankName, bankName, "Bank Name: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.AccountNumber, accountNumber, "Account Number: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.Notes, notes, "Notes: '{0}' to '{1}'");
            if (new Client(owner_RefId).CompanyName != null)
                log = Util.appendChange(log, objOld.Clients_CompanyName, new Client(owner_RefId).CompanyName, "Owner: '{0}' to '{1}'");
            else
                log = Util.appendChange(log, objOld.UserAccounts_Fullname, new UserAccount(owner_RefId).Fullname, "Owner: '{0}' to '{1}'");


            if (string.IsNullOrEmpty(log))
                Util.displayMessageBoxError("No changes to record");
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                {
                    SqlQueryResult result = DBConnection.query(
                        sqlConnection,
                        QueryTypes.ExecuteNonQuery,
                        "BankAccounts_update",
                        new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                        new SqlQueryParameter(COL_DB_Name, SqlDbType.NVarChar, name),
                        new SqlQueryParameter(COL_DB_Owner_RefId, SqlDbType.UniqueIdentifier, owner_RefId),
                        new SqlQueryParameter(COL_DB_BankName, SqlDbType.NVarChar, bankName),
                        new SqlQueryParameter(COL_DB_AccountNumber, SqlDbType.NVarChar, accountNumber),
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
                    "BankAccounts_update_Active",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Active, SqlDbType.Bit, value)
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, "Update Active Status to " + value);
            }
        }

        public static void updateInternalStatus(Guid userAccountID, Guid id, bool value)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "BankAccounts_update_Internal",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Internal, SqlDbType.Bit, value)
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, "Update Internal Status to " + value);
            }
        }

        #endregion DATABASE METHODS
        /*******************************************************************************************************/
        #region CLASS METHODS

        public static void populateDropDownList(LIBUtil.Desktop.UserControls.InputControl_Dropdownlist dropdownlist, bool includeInactive, bool? Internal, bool? filterEmployee)
        {
            dropdownlist.populate(get(includeInactive, null, null, null, null, null, null, Internal, filterEmployee), COL_DB_Name, COL_DB_Id, null);
        }

        #endregion CLASS METHODS
        /*******************************************************************************************************/
    }
}


