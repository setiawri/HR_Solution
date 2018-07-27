using System;
using System.Data;
using System.Data.SqlClient;
using LIBUtil;
using LOGGING;

namespace HR_LIB.HR
{
    public class Client
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public Guid Id;
        public string CompanyName;
        public string Address;
        public string BillingAddress;
        public string ContactPersonName;
        public string Phone1;
        public string Phone2;
        public string NPWP;
        public string NPWPAddress;
        public string Notes;
        public bool Active;


        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_CompanyName = "CompanyName";
        public const string COL_DB_Address = "Address";
        public const string COL_DB_BillingAddress = "BillingAddress";
        public const string COL_DB_ContactPersonName = "ContactPersonName";
        public const string COL_DB_Phone1 = "Phone1";
        public const string COL_DB_Phone2 = "Phone2";
        public const string COL_DB_NPWP = "NPWP";
        public const string COL_DB_NPWPAddress = "NPWPAddress";
        public const string COL_DB_Notes = "Notes";
        public const string COL_DB_Active = "Active";

        public const string COL_FILTER_IncludeInactive = "FILTER_IncludeInactive";
        public const string COL_FILTER_UserAccounts_Id = "FILTER_UserAccounts_Id";

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public Client(Guid id)
        {
            DataRow row = get(id);
            
            if(row != null)
            {
                Id = id;
                CompanyName = Util.wrapNullable<string>(row, COL_DB_CompanyName);
                Address = Util.wrapNullable<string>(row, COL_DB_Address);
                BillingAddress = Util.wrapNullable<string>(row, COL_DB_BillingAddress);
                ContactPersonName = Util.wrapNullable<string>(row, COL_DB_ContactPersonName);
                Phone1 = Util.wrapNullable<string>(row, COL_DB_Phone1);
                Phone2 = Util.wrapNullable<string>(row, COL_DB_Phone2);
                NPWP = Util.wrapNullable<string>(row, COL_DB_NPWP);
                NPWPAddress = Util.wrapNullable<string>(row, COL_DB_NPWPAddress);
                Notes = Util.wrapNullable<string>(row, COL_DB_Notes);
                Active = Util.wrapNullable<bool>(row, COL_DB_Active);
            }
            return;
        }

        public Client() { }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static bool isCompanyNameExist(string companyName, Guid? id)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.ExecuteNonQuery,
                false, false, false, true, false,
                "Clients_isexist_CompanyName",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                new SqlQueryParameter(COL_DB_CompanyName, SqlDbType.NVarChar, companyName)
                );
            return result.ValueBoolean;
        }

        public static Guid add(Guid userAccountID, string companyName, string address, string billingAddress ,
            string contactPersonName, string phone1, string phone2, string npwp, string npwpAddress, string notes)
        {
            Guid id = Guid.NewGuid();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(sqlConnection,
                QueryTypes.ExecuteNonQuery,
                "Clients_add",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_CompanyName, SqlDbType.NVarChar, companyName),
                    new SqlQueryParameter(COL_DB_Address, SqlDbType.NVarChar, Util.wrapNullable(address)),
                    new SqlQueryParameter(COL_DB_BillingAddress, SqlDbType.NVarChar, Util.wrapNullable(billingAddress)),
                    new SqlQueryParameter(COL_DB_ContactPersonName, SqlDbType.NVarChar, Util.wrapNullable(contactPersonName)),
                    new SqlQueryParameter(COL_DB_Phone1, SqlDbType.NVarChar, Util.wrapNullable(phone1)),
                    new SqlQueryParameter(COL_DB_Phone2, SqlDbType.NVarChar, Util.wrapNullable(phone2)),
                    new SqlQueryParameter(COL_DB_NPWP, SqlDbType.NVarChar, Util.wrapNullable(npwp)),
                    new SqlQueryParameter(COL_DB_NPWPAddress, SqlDbType.NVarChar, Util.wrapNullable(npwpAddress)),
                    new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes))
                );

                if (result.IsSuccessful)
                    ActivityLog.add(sqlConnection, userAccountID, id, "Added");
            }
            return id;
        }

        public static DataRow get(SqlConnection sqlConnection, Guid id)
        {
            return Util.getFirstRow(get(sqlConnection,true, id, null, null, null, null, null, null, null, null, null, null));
        }
        public static DataRow get(Guid id)
        {
            DataRow row;
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                row = Util.getFirstRow(get(sqlConnection,true, id, null, null, null, null, null, null, null, null, null, null));
            return row;
        }
        public static DataTable get(bool filterIncludeInactive, Guid? id, string companyName, string address, string billingAddress,
            string contactPersonName, string phone1, string phone2, string npwp, string npwpAddress, string notes, Guid? UserAccounts_Id)
        {
            DataTable datatable;
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                datatable = get(sqlConnection, filterIncludeInactive, id, companyName, address, billingAddress, contactPersonName, phone1, phone2, npwp, npwpAddress, notes, UserAccounts_Id);
            return datatable;
        }
        public static DataTable get(SqlConnection sqlConnection, bool filterIncludeInactive, Guid? id, string companyName, string address, string billingAddress,
            string contactPersonName, string phone1, string phone2, string npwp, string npwpAddress, string notes, Guid? UserAccounts_Id)
        {
            SqlQueryResult result = DBConnection.query(
                sqlConnection,
                QueryTypes.FillByAdapter,
                "Clients_get",
                new SqlQueryParameter(COL_FILTER_IncludeInactive, SqlDbType.Bit, filterIncludeInactive),
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                new SqlQueryParameter(COL_DB_CompanyName, SqlDbType.NVarChar, Util.wrapNullable(companyName)),
                new SqlQueryParameter(COL_DB_Address, SqlDbType.NVarChar, Util.wrapNullable(address)),
                new SqlQueryParameter(COL_DB_BillingAddress, SqlDbType.NVarChar, Util.wrapNullable(billingAddress)),
                new SqlQueryParameter(COL_DB_ContactPersonName, SqlDbType.NVarChar, Util.wrapNullable(contactPersonName)),
                new SqlQueryParameter(COL_DB_Phone1, SqlDbType.NVarChar, Util.wrapNullable(phone1)),
                new SqlQueryParameter(COL_DB_Phone2, SqlDbType.NVarChar, Util.wrapNullable(phone2)),
                new SqlQueryParameter(COL_DB_NPWP, SqlDbType.NVarChar, Util.wrapNullable(npwp)),
                new SqlQueryParameter(COL_DB_NPWPAddress, SqlDbType.NVarChar, Util.wrapNullable(npwpAddress)),
                new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes)),
                new SqlQueryParameter(COL_FILTER_UserAccounts_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(UserAccounts_Id))

                );
            return result.Datatable;
        }

        public static void update(Guid userAccountID, Guid id, string companyName, string address, string billingAddress,
            string contactPersonName, string phone1, string phone2, string npwp, string npwpAddress, string notes)
        {
            Client objOld = new Client(id);
            string log = "";
            log = Util.appendChange(log, objOld.CompanyName, companyName, "CompanyName: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.Address, address, "Address: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.BillingAddress, billingAddress, "BillingAddress: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.ContactPersonName, contactPersonName, "ContactPersonName: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.Phone1, phone1, "Phone1: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.Phone2, phone2, "Phone2: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.NPWP, npwp, "NPWP: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.NPWPAddress, npwpAddress, "NPWPAddress: '{0}' to '{1}'");
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
                        "Clients_update",
                        new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                        new SqlQueryParameter(COL_DB_CompanyName, SqlDbType.NVarChar, companyName),
                        new SqlQueryParameter(COL_DB_Address, SqlDbType.NVarChar, Util.wrapNullable(address)),
                        new SqlQueryParameter(COL_DB_BillingAddress, SqlDbType.NVarChar, Util.wrapNullable(billingAddress)),
                        new SqlQueryParameter(COL_DB_ContactPersonName, SqlDbType.NVarChar, Util.wrapNullable(contactPersonName)),
                        new SqlQueryParameter(COL_DB_Phone1, SqlDbType.NVarChar, Util.wrapNullable(phone1)),
                        new SqlQueryParameter(COL_DB_Phone2, SqlDbType.NVarChar, Util.wrapNullable(phone2)),
                        new SqlQueryParameter(COL_DB_NPWP, SqlDbType.NVarChar, Util.wrapNullable(npwp)),
                        new SqlQueryParameter(COL_DB_NPWPAddress, SqlDbType.NVarChar, Util.wrapNullable(npwpAddress)),
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
                    "Clients_update_Active",
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

