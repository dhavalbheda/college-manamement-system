using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AD_CMS_Entity;
using AD_CMS;

namespace AD_CMS_DatabaseModel
{
    public class Course_Methods
    {
        public static DataTable Load_CourseDetails(string type)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    if (type == "subject")
                        cmd.CommandText = "select C_Alias as Alias,C_TotalSem as TotalSem from Courses";
                    else if (type == "fee")
                        cmd.CommandText = "select C_Alias as Alias,C_DurationDescription as duration_desc from Courses where C_Fees=0";
                    
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable("CourseAlias");
                    dt.Load(dr);

                    return dt;
                }
            }
        }

        public static string insert_course(CourseEntity ce)
        {
            bool isCourseNmExists = false;
            bool isCourseAliasExists = false;
            string msg = "";

            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                conn.Open();
                SqlCommand cmd;
                using (cmd = new SqlCommand("course_unique_check", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CourseName", ce.course_nm.Trim());
                    cmd.Parameters.AddWithValue("@CourseAlias", ce.course_alias.Trim().ToUpper());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dr.Read();
                        isCourseNmExists = (bool)dr[0];
                        isCourseAliasExists = (bool)dr[1];
                    }
                }
                if (!isCourseNmExists && !isCourseAliasExists)
                {
                    using (cmd = new SqlCommand("insert_course", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nm", ce.course_nm.Trim());
                        cmd.Parameters.AddWithValue("@alias", ce.course_alias.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@sem", ce.total_sem);
                        if (ce.total_sem > 1)
                        {
                            cmd.Parameters.AddWithValue("@duration", (ce.total_sem / 2) * 12);
                            cmd.Parameters.AddWithValue("@duration_desc", "[per year]");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@duration", 6);
                            cmd.Parameters.AddWithValue("@duration_desc", "[per sem]");
                        }

                        cmd.ExecuteNonQuery();
                        msg = "Course Created Successfully.0";
                    }
                }
                else
                {
                    if (isCourseNmExists)
                    {
                        msg = "Course Name already available.1";
                        if (isCourseAliasExists)
                            msg = "Course Name && Course Alias both are exists.1";
                    }
                    else if (isCourseAliasExists)
                    {
                        msg = "Course Alias is already given.1";
                    }
                    else
                    {
                        msg = "Something went wrong.1";
                    }
                }
            }
            return msg;
        }

        public static string insert_subject(CourseEntity ce)
        {
            bool isSubjectAvailable = false;
            bool isSubjectCodeAvailable = false;
            string msg = "";

            using (SqlConnection con = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("subject_insert_check", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@course_alias", ce.course_alias);
                    cmd.Parameters.AddWithValue("@subject_nm", ce.subject_nm);
                    cmd.Parameters.AddWithValue("@subject_code", ce.subject_code);
                    cmd.Parameters.AddWithValue("@subject_sem", ce.subject_sem);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    isSubjectAvailable = (bool)dr[0];
                    isSubjectCodeAvailable = (bool)dr[1];

                    if (!isSubjectAvailable && !isSubjectCodeAvailable)
                    {
                        msg = "Subject inserted successfully.0";
                    }
                    else
                    {
                        if (isSubjectAvailable)
                        {
                            msg = "Subject is already available in " + ce.course_alias + ".1";
                            if (isSubjectCodeAvailable)
                            {
                                msg = "Subject name & Subject Code both are available.1";
                            }
                        }
                        else if (isSubjectCodeAvailable)
                        {
                            msg = "Subject Code already avaliable.1";
                        }
                    }
                }
            }
            return msg;
        }

        public static int update_fees(CourseEntity ce)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("update_course_fee", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@course_alias", ce.course_alias);
                    cmd.Parameters.AddWithValue("@fee_per_year", ce.fee_per_year);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable LoadDataGridView(String type)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    if (type == "course")
                    {
                        cmd.CommandText = "load_courseDetails";
                    }
                    else if (type == "subject")
                    {
                        cmd.CommandText = "load_subjectDetails";
                    }
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            return dt; 
        }

        public static DataTable feeCout(string coursealias)
        {
             using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                SqlCommand cmd;
                using (cmd = new SqlCommand("fee_count", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@course_alias",SqlDbType.NVarChar,50).Value = coursealias;
                }
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable("FeeCount");
                dt.Load(reader);
                return dt;
            }
           
        }

        public static int deleteCourses(string coursealias)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                SqlCommand cmd;
                using (cmd = new SqlCommand("delete_course", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@course_alias", SqlDbType.NVarChar, 50).Value = coursealias;
                }
                conn.Open();

                return cmd.ExecuteNonQuery();
            }

        }

        public static string getCourseAlias()
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT C_Alias
                                                FROM   Courses WHERE C_Id =
                                                        (SELECT MAX(C_Id)
                                                        FROM Courses)", conn))
                {
                    conn.Open();
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }
    }
}
