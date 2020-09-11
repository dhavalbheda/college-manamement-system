using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using AD_CMS;

namespace AD_CMS_DatabaseModel
{
    public class CollegeDetails_Methods
    {
        public static object[] StudentCount()
        {
            Object[] obj = new object[3];
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("CountStudent", conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    obj[0] = dr[0];
                    obj[1] = dr[1];
                    obj[2] = dr[2];
                }
            }
            return obj;
        }

        public static int TotalCourse()
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("select count(*) from Courses", conn))
                {
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public static List<string> CourseList()
        {
            List<string> str = new List<string>();
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("select C_Alias from Courses", conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            str.Add(dr[0].ToString());
                        }
                    }     
                }
            }
            return str;
        }

        public static object[] EmployeeCount()
        {
            object[] obj = new object[7];
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("countEmployee", conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    for (int i = 0; i < obj.Length; i++)
                    {
                        obj[i]=dr[i];
                    }
                }
            }
            return obj;
        }

    }
}
