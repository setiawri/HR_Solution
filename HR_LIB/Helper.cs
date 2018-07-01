using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using LIBUtil;
using LOGIN;

namespace HR_LIB
{
    public class Helper
    {
        public static bool isDBConnectionAvailable()
        {
            return Util.isDBConnectionAvailable(null, true, true);
        }

        public static bool hideIfNoAccess(UserAccount userAccount, object control, bool disableOnly, params UserAccountAccessEnum[] access)
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

        public static bool hasAccess(UserAccount userAccount, params UserAccountAccessEnum[] access)
        {
            if (userAccount.Id == new Guid())
                return true;

            foreach (UserAccountAccessEnum item in access)
                if (userAccount.UserAccountAccess_EnumId.Contains(item))
                    return true;

            return false;
        }
    }
}
