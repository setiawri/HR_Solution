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
    }
}
