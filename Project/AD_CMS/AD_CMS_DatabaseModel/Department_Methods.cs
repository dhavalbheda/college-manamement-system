using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AD_CMS;

namespace AD_CMS_DatabaseModel
{
    public class Department_Methods
    {
        public static DataTable GetCourse()
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("select C_Alias,C_TotalSem from Courses where C_Fees!=0", conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable("Course");
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        public static DataTable load_Set_Modify_DepartmentGridView(string coursenm,int sem)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadDeptGridView", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@coursenm", coursenm);
                    cmd.Parameters.AddWithValue("@sem", sem);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        public static List<string> loadEmployeeName()
        {
            List<string> nm = new List<string>();
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("select E_Name from Employee where E_IsTeaching='teaching'", conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            nm.Add(dr[0].ToString());
                        }
                    }
                }
            }
            return nm;
        }

        public static int setSubjectTeacher(string teacherName,string subjectName)
        {
            using(SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using(SqlCommand cmd = new SqlCommand("setTeacher",conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empnm",teacherName);
                    cmd.Parameters.AddWithValue("@subjnm",subjectName);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable viewStudent(string course,int sem)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("studentDepartmentWise", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@coursealias", course);
                    cmd.Parameters.AddWithValue("@currentsem", sem);
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        public static int PromoteStudent(int grno, int currentsem)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("UpgradeDepartment", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@grno", grno);
                    cmd.Parameters.AddWithValue("@currentsem", currentsem);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
