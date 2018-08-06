using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using LIBUtil;

namespace HR_LIB
{
    public class Helper
    {
        public static bool isDBConnectionAvailable()
        {
            return Util.isDBConnectionAvailable(null, true, true);
        }

        public static bool hideIfNoAccess(LOGIN.UserAccount userAccount, object control, bool disableOnly, params LOGIN.UserAccountAccessEnum[] access)
        {
            bool userHasAccess = hasAccess(userAccount, access);

            if (!userHasAccess && control != null)
            {
                if (control.GetType() == typeof(ToolStripMenuItem))
                {
                    if (disableOnly)
                        ((ToolStripMenuItem)control).Enabled = false;
                    else
                        ((ToolStripMenuItem)control).Available = false;
                }
                else if (control.GetType() == typeof(DataGridViewCheckBoxColumn))
                    ((DataGridViewCheckBoxColumn)control).Visible = false;
                else
                {
                    if (disableOnly)
                        ((Control)control).Enabled = false;
                    else
                        ((Control)control).Visible = false;
                }
            }

            return userHasAccess;
        }

        public static bool hasAccess(LOGIN.UserAccount userAccount, params LOGIN.UserAccountAccessEnum[] access)
        {
            if (userAccount.Id == new Guid())
                return true;

            foreach (LOGIN.UserAccountAccessEnum item in access)
                if (userAccount.UserAccountAccess_EnumId.Contains(item))
                    return true;

            return false;
        }
    }
}
