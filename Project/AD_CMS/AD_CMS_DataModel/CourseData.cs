using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using AD_CMS.ClassProperties;

namespace AD_CMS_DataModel
{
    class CourseData
    {
        public static void insert_course(CourseProperties cp)
        {
            using(SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\PROJECT20018\\AD_CMS\\AD_CMS\\MasterDatabase.mdf;Integrated Security=True;User Instance=True"))
            {
                using(SqlCommand cmd = new SqlCommand("insert into Courses(C_Name,C_Alias,C_TotalSem) values(@nm,@alias,@sem)"))
                {
                    cmd.Parameters.AddWithValue("@nm",cp.course_nm);
                    cmd.Parameters.AddWithValue("@alias",cp.course_alias);
                    cmd.Parameters.AddWithValue("@sem",cp.total_sem);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
