using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AD_CMS;
using AD_CMS_Entity;

namespace AD_CMS_DatabaseModel
{
    public class AdminSection_Methods
    {
        public static DataTable loadUserRole()
        {
            DataTable dt = new DataTable("UserRole");
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM UserRole", conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public static bool insertUsers(AdminSectionEntity ce)
        {
            bool flag=false;
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("insertUsers", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@usernm", ce.userName);
                    cmd.Parameters.AddWithValue("@pwd", ce.password);
                    cmd.Parameters.AddWithValue("@roleid", ce.userRole);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dr.Read();
                        flag = (bool)dr[0];
                    }
                    return flag;
                }
            }
        }

        public static DataTable loadDataGridView()
        {
            DataTable dt = new DataTable("Users");
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT u.UserId as ID,u.UserName,u.Password,(select RoleDescription from UserRole where RoleId=u.RoleId) as UserRole FROM Users u", conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public static int deleteUser(int UserId)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("delete from Users where UserId="+UserId, conn))
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
