using System;

namespace HR_LIB
{
    public class Settings
    {
        public static string CONNECTIONSTRING_DEFAULTPARAMS = "Integrated Security=False;Persist Security Info=False;";
        public const string SQL_USERNAME = "iSpeak";
        public const string SQL_PASSWORD = "1SpeakWell";

        public const string PASSWORD_OPENSETTINGSFORM = "settings";

        private static bool _useDEV = true;
        public const string TEMPORARY_PASSWORD = "qwerty";

        public static string COMPANY_INFO = "LUCKY STAR SECURITY" + Environment.NewLine + "+62.821.xxxx.xxxx";
    }
}
