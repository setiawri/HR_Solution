using System.ComponentModel;

namespace LOGIN
{

    /// <summary>
    /// <para>First digit is to prevent second digit if zero to get truncated</para>
    /// </summary>
    public enum UserAccountAccessEnum
    {
        [Description("1.1 View User Accounts")]
        UserAccounts_View = 10101,
        [Description("1.2 Add/Update User Accounts")]
        UserAccounts_AddUpdate = 10102,
        [Description("1.3 Add/Update Roles")]
        UserAccountRoles_AddUpdate = 10103,
        [Description("8.1 Confirm Payments")]
        Finance_ConfirmPayments = 10801,
        [Description("9.1. View Financial Reports")]
        FinancialReports_View = 10901,
        [Description("9.2. Add Financial Reports")]
        FinancialReports_Add = 10902,
        [Description("9.3. Update Financial Reports")]
        FinancialReports_Update = 10903,
    }

    public class UserAccountAccess
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS        

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS
		
        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        #endregion DATABASE METHODS
        /*******************************************************************************************************/
        #region CLASS METHODS

        //public static NodeTree getTree(string connectionString) { return getTree(null); }
        //public static NodeTree getTree(Guid? userAccountId)
        //{
        //    NodeTree tree = new NodeTree();

        //    DataTable accesses = new DataTable();
        //    if (userAccountId != null)
        //    {
        //        accesses = UserAccountAccessRoleAssignment.getByUserAccountId((Guid)userAccountId);

        //        foreach (DataRow row in accesses.Rows)
        //            tree.Add(new Node(Util.parseEnum<UserAccountAccessEnum>(row[UserAccountAccessRoleAssignment.COL_DB_UserAccountAccess_EnumId].ToString())));
        //    }

        //    return tree;
        //}

        #endregion CLASS METHODS
        /*******************************************************************************************************/
    }
}

