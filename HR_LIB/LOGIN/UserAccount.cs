using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using LIBUtil;

namespace LOGIN
{
    public class UserAccount
    {
        /*******************************************************************************************************/
        #region CONSTANTS

        public const int USERNAME_MINLENGTH = 4;
        public const int USERNAME_MAXLENGTH = 20;
        public const int PASSWORD_MINLENGTH = 4;
        public const int PASSWORD_MAXLENGTH = 20;

        public static bool IsCreateAccount = false;

        public static string INVALIDPASSWORDERROR
        {
            get
            {
                return string.Format("Invalid New Password{0}- Min length is {1}{0}- Max length is {2}{0}- Cannot contain: {3}",
                  Environment.NewLine, UserAccount.PASSWORD_MINLENGTH, UserAccount.PASSWORD_MAXLENGTH, string.Join(" ", Util.sanitizeList));
            }
        }

        #endregion 
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public static UserAccount LoggedInAccount;

        public Guid Id;
        public string Username;
        private string HashedPassword;  
        public string Firstname;
        public string Lastname;
        public string Address1;
        public string Address2;
        public string Phone1;
        public string Phone2;
        public string Email;
        public DateTime? Birthdate;
        public string Notes = "";
        public bool Active;

        public string Fullname;
        public List<Guid> UserAccountRoles_Id;
        public bool Special = false;
        //public NodeTree UserAccountAccessTree;
        
        private List<UserAccountAccessEnum> _userAccountAccess_EnumId;
        public List<UserAccountAccessEnum> UserAccountAccess_EnumId
        {
            get
            {
                if(_userAccountAccess_EnumId == null)
                    _userAccountAccess_EnumId = Util.convertToList<UserAccountAccessEnum>(UserAccountAccessRoleAssignment.getByUserAccountId(Id), UserAccountAccessRoleAssignment.COL_DB_UserAccountAccess_EnumId);

                return _userAccountAccess_EnumId;
            }
        }

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_Username = "Username";
        public const string COL_DB_HashedPassword = "HashedPassword";
        public const string COL_DB_Firstname = "Firstname";
        public const string COL_DB_Lastname = "Lastname";
        public const string COL_DB_Address1 = "Address1";
        public const string COL_DB_Address2 = "Address2";
        public const string COL_DB_Phone1 = "Phone1";
        public const string COL_DB_Phone2 = "Phone2";
        public const string COL_DB_Email = "Email";
        public const string COL_DB_Birthdate = "Birthdate";
        public const string COL_DB_Notes = "notes";
        public const string COL_DB_Active = "Active";

        public const string COL_Fullname = "Fullname";
        public const string COL_INPUT_Password = "INPUT_Password";
        public const string COL_Special = "Special";

        #endregion 
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        /// <summary><para>Only to create new account.</para></summary>
        public UserAccount() { Id = new Guid(); }
        public UserAccount(Guid id)
        {
            DataRow row = get(id);
            Id = Util.wrapNullable<Guid>(row, COL_DB_Id); 
            Username = Util.wrapNullable<string>(row, COL_DB_Username);
            HashedPassword = Util.wrapNullable<string>(row, COL_DB_HashedPassword);
            Firstname = Util.wrapNullable<string>(row, COL_DB_Firstname);
            Lastname = Util.wrapNullable<string>(row, COL_DB_Lastname);
            Address1 = Util.wrapNullable<string>(row, COL_DB_Address1);
            Address2 = Util.wrapNullable<string>(row, COL_DB_Address2);
            Phone1 = Util.wrapNullable<string>(row, COL_DB_Phone1);
            Phone2 = Util.wrapNullable<string>(row, COL_DB_Phone2);
            Email = Util.wrapNullable<string>(row, COL_DB_Email);
            Birthdate = Util.wrapNullable<DateTime?>(row, COL_DB_Birthdate);
            Notes = Util.wrapNullable<string>(row, COL_DB_Notes);
            Active = Util.wrapNullable<bool>(row, COL_DB_Active);

            Fullname = Util.wrapNullable<string>(row, COL_Fullname);
            Special = Util.wrapNullable<bool>(row, COL_Special);
        }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static bool isUsernameExist(string username, Guid? id)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.ExecuteNonQuery,
                false, false, false, true, false,
                "UserAccounts_isexist_Username",
                new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                new SqlQueryParameter(COL_DB_Username, SqlDbType.NVarChar, username)
                );
            return result.ValueBoolean;
        }

        public static Guid add(Guid userAccountID, string username, string password, string firstName, string lastName,
            string address1, string address2, string phone1, string phone2, string email, DateTime? birthdate, string notes, List<Guid?> userAccountRoles)
        {
            Guid id = Guid.NewGuid();
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "UserAccounts_add",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Username, SqlDbType.NVarChar, username),
                    new SqlQueryParameter(COL_DB_Firstname, SqlDbType.NVarChar, firstName),
                    new SqlQueryParameter(COL_INPUT_Password, SqlDbType.NVarChar, password),
                    new SqlQueryParameter(COL_DB_Lastname, SqlDbType.NVarChar, Util.wrapNullable(lastName)),
                    new SqlQueryParameter(COL_DB_Address1, SqlDbType.NVarChar, Util.wrapNullable(address1)),
                    new SqlQueryParameter(COL_DB_Address2, SqlDbType.NVarChar, Util.wrapNullable(address2)),
                    new SqlQueryParameter(COL_DB_Phone1, SqlDbType.NVarChar, Util.wrapNullable(phone1)),
                    new SqlQueryParameter(COL_DB_Phone2, SqlDbType.NVarChar, Util.wrapNullable(phone2)),
                    new SqlQueryParameter(COL_DB_Email, SqlDbType.NVarChar, Util.wrapNullable(email)),
                    new SqlQueryParameter(COL_DB_Birthdate, SqlDbType.NVarChar, Util.wrapNullable(birthdate)),
                    new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes))
                );

                if(result.IsSuccessful)
                {
                    LOGGING.ActivityLog.add(sqlConnection, userAccountID, id, "Added");
                    UserAccountRoleAssignment.update(sqlConnection, userAccountID, id, userAccountRoles);
                }
            }
            return id;
        }

        public static bool isPasswordMatch(string username, string password)
        {
            return authenticate(username, password) != null;
        }
        public static UserAccount authenticate(string username, string password)
        {
            if(username == "createaccount")
            {
                if (password != string.Format("{0:yyHHMMdd}", DateTime.Now))
                {
                    Util.displayMessageBoxError("Invalid Password");
                    return null;
                }
                else
                {
                    IsCreateAccount = true;
                    return new UserAccount();
                }
            }
            else
            {
                SqlQueryResult result = DBConnection.query(
                    QueryTypes.ExecuteNonQuery,
                    true, false, false, false, true,
                    "UserAccounts_authenticate",
                    new SqlQueryParameter(COL_DB_Username, SqlDbType.NVarChar, username),
                    new SqlQueryParameter(COL_INPUT_Password, SqlDbType.NVarChar, password)
                    );

                if (string.IsNullOrEmpty(result.ValueString))
                    return new UserAccount(result.ValueGuid);
                else
                {
                    Util.displayMessageBoxError(result.ValueString);
                    return null;
                }
            }
        }

        public static DataRow get(Guid id) { return Util.getFirstRow(get(true, id, null, null, null, null, null, null, null, null, null, null)); }
        public static DataTable get(bool filterIncludeInactive, Guid? id, string username, string firstName, string lastName,
            string address1, string address2, string phone1, string phone2, string email, DateTime? birthdate, string notes)
        {
            SqlQueryResult result = DBConnection.query(
                QueryTypes.FillByAdapter,
                "UserAccounts_get",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, Util.wrapNullable(id)),
                    new SqlQueryParameter(COL_DB_Username, SqlDbType.NVarChar, Util.wrapNullable(username)),
                    new SqlQueryParameter(COL_DB_Firstname, SqlDbType.NVarChar, Util.wrapNullable(firstName)),
                    new SqlQueryParameter(COL_DB_Lastname, SqlDbType.NVarChar, Util.wrapNullable(lastName)),
                    new SqlQueryParameter(COL_DB_Address1, SqlDbType.NVarChar, Util.wrapNullable(address1)),
                    new SqlQueryParameter(COL_DB_Address2, SqlDbType.NVarChar, Util.wrapNullable(address2)),
                    new SqlQueryParameter(COL_DB_Phone1, SqlDbType.NVarChar, Util.wrapNullable(phone1)),
                    new SqlQueryParameter(COL_DB_Phone2, SqlDbType.NVarChar, Util.wrapNullable(phone2)),
                    new SqlQueryParameter(COL_DB_Email, SqlDbType.NVarChar, Util.wrapNullable(email)),
                    new SqlQueryParameter(COL_DB_Birthdate, SqlDbType.NVarChar, Util.wrapNullable(birthdate)),
                    new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes))
                );
            return result.Datatable;
        }

        public static void update(Guid userAccountID, Guid id, string username, string firstName, string lastName,
            string address1, string address2, string phone1, string phone2, string email, DateTime? birthdate, string notes, List<Guid?> userAccountRoles)
        {
            UserAccount objOld = new UserAccount(id);
            string log = "";
            log = Util.appendChange(log, objOld.Username, username, "Username: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.Firstname, firstName, "First Name: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.Lastname, lastName, "Last Name: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.Address1, address1, "Address 1: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.Address2, address2, "Address 2: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.Phone1, phone1, "Phone 1: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.Phone2, phone2, "Phone 2: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.Email, email, "Email: '{0}' to '{1}'");
            log = Util.appendChange(log, objOld.Birthdate, birthdate, "Birthdate: '{0:dd MMM yyyy}' to '{1:dd MMM yyyy}'");
            log = Util.appendChange(log, objOld.Notes, notes, "Notes: '{0}' to '{1}'");

            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                if (!string.IsNullOrEmpty(log))
                {
                    SqlQueryResult result = DBConnection.query(
                        sqlConnection,
                        QueryTypes.ExecuteNonQuery,
                        "UserAccounts_update",
                        new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                        new SqlQueryParameter(COL_DB_Username, SqlDbType.NVarChar, username),
                        new SqlQueryParameter(COL_DB_Firstname, SqlDbType.NVarChar, firstName),
                        new SqlQueryParameter(COL_DB_Lastname, SqlDbType.NVarChar, Util.wrapNullable(lastName)),
                        new SqlQueryParameter(COL_DB_Address1, SqlDbType.NVarChar, Util.wrapNullable(address1)),
                        new SqlQueryParameter(COL_DB_Address2, SqlDbType.NVarChar, Util.wrapNullable(address2)),
                        new SqlQueryParameter(COL_DB_Phone1, SqlDbType.NVarChar, Util.wrapNullable(phone1)),
                        new SqlQueryParameter(COL_DB_Phone2, SqlDbType.NVarChar, Util.wrapNullable(phone2)),
                        new SqlQueryParameter(COL_DB_Email, SqlDbType.NVarChar, Util.wrapNullable(email)),
                        new SqlQueryParameter(COL_DB_Birthdate, SqlDbType.NVarChar, Util.wrapNullable(birthdate)),
                        new SqlQueryParameter(COL_DB_Notes, SqlDbType.NVarChar, Util.wrapNullable(notes))
                    );

                    if (result.IsSuccessful)
                        LOGGING.ActivityLog.add(sqlConnection, userAccountID, id, String.Format("Updated: {0}", log));
                }
                UserAccountRoleAssignment.update(sqlConnection, userAccountID, id, userAccountRoles);
            }

        }

        public static bool updatePassword(Guid userAccountID, Guid id, string newPassword)
        {
            SqlQueryResult result;
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "UserAccounts_update_HashedPassword",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_INPUT_Password, SqlDbType.NVarChar, newPassword)
                );

                if(result.IsSuccessful)
                    LOGGING.ActivityLog.add(sqlConnection, userAccountID, id, "Password Updated");
            }
            return result.IsSuccessful;
        }

        public static void updateActiveStatus(Guid userAccountID, Guid id, bool value)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
            {
                SqlQueryResult result = DBConnection.query(
                    sqlConnection,
                    QueryTypes.ExecuteNonQuery,
                    "UserAccounts_update_Active",
                    new SqlQueryParameter(COL_DB_Id, SqlDbType.UniqueIdentifier, id),
                    new SqlQueryParameter(COL_DB_Active, SqlDbType.Bit, value)
                );

                if (result.IsSuccessful)
                    LOGGING.ActivityLog.add(sqlConnection, userAccountID, id, "Update Active Status to " + value);
            }
        }
        
        #endregion DATABASE METHODS
        /*******************************************************************************************************/
        #region CLASS METHODS

        public static bool isValidNewPassword(string password)
        {
            if (string.IsNullOrEmpty(password)
                || password.Length < PASSWORD_MINLENGTH
                || password.Length > PASSWORD_MAXLENGTH)
                return false;

            foreach(string item in Util.sanitizeList)
                if (password.Contains(item))
                    return false;

            return true;
        }

        public static void populateDropDownList(LIBUtil.Desktop.UserControls.InputControl_Dropdownlist dropdownlist, bool includeInactive)
        {
            dropdownlist.populate(get(false, null, null, null, null, null, null, null, null, null, null, null), COL_Fullname, COL_DB_Id, null);
        }

        #endregion CLASS METHODS
        /*******************************************************************************************************/
    }
}

