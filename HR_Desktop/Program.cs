using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LIBUtil.DBConnection.initialize(HR_LIB.Settings.CONNECTIONSTRING_DEFAULTPARAMS, HR_LIB.Settings.SQL_USERNAME, HR_LIB.Settings.SQL_PASSWORD);
            LIBUtil.Util.ensureSingleInstance(runApplication);
        }

        static void runApplication()
        {
            LOGIN.Login_Form loginform = new LOGIN.Login_Form();
            LIBUtil.Util.displayForm(null, loginform);
            if (loginform.isAuthenticated)
                Application.Run(new Main_Form());
        }
    }
}
