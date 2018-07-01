using System;

namespace HR_Desktop
{
    public class GlobalData
    {
        public static Guid AppGuid = new Guid(((System.Runtime.InteropServices.GuidAttribute)System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(System.Runtime.InteropServices.GuidAttribute), false).GetValue(0)).Value.ToString());
    }
}
