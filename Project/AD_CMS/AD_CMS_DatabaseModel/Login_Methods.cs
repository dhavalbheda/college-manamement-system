using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using AD_CMS;
using System.Data;

namespace AD_CMS_DatabaseModel
{
    public class Login_Methods
    {
        public static Object[] user_login(string usernm,string pwd)
        {
            Object[] field=new Object[2];
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString())) 
            {
                using (SqlCommand cmd = new SqlCommand("checkLogin", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@usernm", usernm);
                    cmd.Parameters.AddWithValue("@password", pwd);
                    conn.Open();
                    SqlDataReader dr =cmd.ExecuteReader();
                    dr.Read();
                    field[0] = dr[0];
                    field[1] = dr[1];
                }
            }
            return field;
        }
    }
}
