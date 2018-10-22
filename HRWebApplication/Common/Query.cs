using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HRWebApplication.Common
{
    public class Query
    {
        public void Delete(string table, string param, string param_val)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["amtk"].ToString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM " + table + " WHERE " + param + "=@param", conn);
                cmd.Parameters.AddWithValue("@param", param_val);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete2(string table, string param1, string param_val1, string param2, string param_val2)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["amtk"].ToString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM " + table + " WHERE " + param1 + "=@param1 AND " + param2 + "=@param2", conn);
                cmd.Parameters.AddWithValue("@param1", param_val1);
                cmd.Parameters.AddWithValue("@param2", param_val2);
                cmd.ExecuteNonQuery();
            }
        }
    }
}