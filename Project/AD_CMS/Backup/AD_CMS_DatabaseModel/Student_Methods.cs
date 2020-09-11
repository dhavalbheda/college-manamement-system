using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using AD_CMS;
using System.Data;
using AD_CMS_Entity;

namespace AD_CMS_DatabaseModel
{
    public class Student_Methods
    {
        public static int loadGrno()
        {
            int Grno;
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("load_Grno", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dr.Read();
                        Grno = (int)dr[0];
                        Grno++;
                    }
                }
            }
            return Grno;
        }
		
        public static DataTable loadCast()
        {
            DataTable dt = new DataTable("Cast");
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM CAST", conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public static DataTable loadCountry()
        {
            DataTable dt = new DataTable("Country");
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Country", conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public static DataTable loadState()
        {
            DataTable dt = new DataTable("State");
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM State", conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public static DataTable loadCity()
        {
            DataTable dt = new DataTable("City");
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM City", conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public static DataTable loadCourse()
        {
            DataTable dt = new DataTable("Course");
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT C_Id,C_Alias,C_TotalSem,C_Fees FROM Courses where C_Fees!=0", conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public static int insertStudent(StudentEntity se)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("InsertStudent",conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Grno", se.grno);
                    cmd.Parameters.AddWithValue("@profile",se.ProfilePhoto);
                    cmd.Parameters.AddWithValue("@fullname",se.candidate_FirstName+" "+se.candidate_MiddleName+" "+se.candidate_LastName);
                    cmd.Parameters.AddWithValue("@gender",se.gender);
                    cmd.Parameters.AddWithValue("@admissiondate",se.AdmissionDate);
                    cmd.Parameters.AddWithValue("@castid",se.CastId);
                    cmd.Parameters.AddWithValue("@currentaddress",se.CurrentAddress);
                    cmd.Parameters.AddWithValue("@permanentaddress",se.PermanentAddress);
                    cmd.Parameters.AddWithValue("@pincode",se.Pincode);
                    cmd.Parameters.AddWithValue("@countryid",se.CountryId);
                    cmd.Parameters.AddWithValue("@stateid",se.StateId);
                    cmd.Parameters.AddWithValue("@cityid",se.CityId);
                    cmd.Parameters.AddWithValue("@dob",se.DOB);
                    cmd.Parameters.AddWithValue("@birthplace",se.BirthPlace);
                    cmd.Parameters.AddWithValue("@mobileno",se.MobileNo);
                    cmd.Parameters.AddWithValue("@telephone",se.TelephoneNo);
                    cmd.Parameters.AddWithValue("@email",se.Email);
                    cmd.Parameters.AddWithValue("@courseid",se.CourseId);
                    cmd.Parameters.AddWithValue("@coursenm", se.Coursenm);
                    cmd.Parameters.AddWithValue("@admissionsem",se.AdmissionSem);
                    cmd.Parameters.AddWithValue("@currentsem",se.CurrentSem);
                    cmd.Parameters.AddWithValue("@discount",se.Discount);
                    cmd.Parameters.AddWithValue("@fees",se.Fees);
                    cmd.Parameters.AddWithValue("@remark",se.Remark);
                    cmd.Parameters.AddWithValue("@currentstatus",se.CurrentStatus);
                    cmd.Parameters.AddWithValue("@leavingyear",se.LeavingYear);

                    cmd.Parameters.AddWithValue("@fathername", se.father_FirstName + " " + se.father_MiddleName + " " + se.father_LastName);
                    cmd.Parameters.AddWithValue("@mothername", se.mother_FirstName + " " + se.mother_MiddleName + " " + se.mother_LastName);
                    cmd.Parameters.AddWithValue("@parentsocupation", se.ParentsOccupation);
                    cmd.Parameters.AddWithValue("@parentsofficeaddress", se.OfficeAddress);
                    cmd.Parameters.AddWithValue("@parentscontectno", se.ContactNo);

                    cmd.Parameters.AddWithValue("@schoolname", se.SchoolName);
                    cmd.Parameters.AddWithValue("@schoolstream", se.SchoolStream);
                    cmd.Parameters.AddWithValue("@schoollastyear", se.LastYear);
                    cmd.Parameters.AddWithValue("@schoollastyearpercent", se.LastYear_Percentage);

                    cmd.Parameters.AddWithValue("@checkcollege", se.checkCollege);
                    cmd.Parameters.AddWithValue("@collegename", se.CollegeName);
                    cmd.Parameters.AddWithValue("@collegestream", se.CollegeStream);
                    cmd.Parameters.AddWithValue("@collegelastsem", se.LastSem);
                    cmd.Parameters.AddWithValue("@collegelastyear", se.CollegeYear);
                    cmd.Parameters.AddWithValue("@collegelastyearpercent", se.LastSem_Percentage);

                    cmd.Parameters.AddWithValue("@marksheet12", se.marksheet_12);
                    cmd.Parameters.AddWithValue("@lc", se.lc_12);
                    cmd.Parameters.AddWithValue("@previousmarksheet", se.previous_marksheet);
                    cmd.Parameters.AddWithValue("@noc", se.NOC);
                    cmd.Parameters.AddWithValue("@tc", se.TC);

                    cmd.Parameters.AddWithValue("@discountfee", ((se.Fees-((se.Fees * se.Discount) / 100))));
                    cmd.Parameters.AddWithValue("@duefee", ((se.Fees-((se.Fees * se.Discount) / 100))));


                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable loadStudent()
        {
            DataTable dt = new DataTable("Student");
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT        Grno, S_FullName AS Name,S_Profile as Profile, S_Gender AS Gender, S_AdmissionDate AS AdmissionDate,
                             (SELECT        C_Alias
                               FROM            Courses
                               WHERE        (C_Id = Student.S_CourseId)) AS Course, S_CurrentSem AS CurrentSemester,
                             (SELECT        CityNm
                               FROM            City
                               WHERE        (CityId = Student.S_CityId)) AS City, S_MobileNo AS MobileNo
FROM            Student", conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        public static DataTable loadStudentDetails_Form(int Grno)
        {
            DataTable dt = new DataTable("Student");
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadStudentForm", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@grno", Grno);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public static int deleteStudent(int grno)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("delete_student", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Grno", grno);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int deleteStudent_for_Update(int grno)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("delete_student_for_update", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Grno", grno);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
