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
    public class FinanceDepartment_Methods
    {
        public static DataTable Load_CourseDetails()
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.CommandText = "select C_Id as Id,C_Alias as Alias,C_TotalSem as TotalSem from Courses where C_Fees!=0";
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable("CourseAlias");
                    dt.Load(dr);

                    return dt;
                }
            }
        }
        public static DataTable Load_DataGridView(string course_nm,int sem)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("financeGridView", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@currentsem", sem);
                    cmd.Parameters.AddWithValue("@coursenm", course_nm);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable("FeeCollection");
                    dt.Load(dr);

                    return dt;
                }
            }
        }

        public static DataTable FeeCollection_CellClick(int Grno)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.CommandText = "SELECT Grno,S_FullName,S_AdmissionDate,S_LeavingYear FROM student WHERE Grno="+Grno;
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    return dt;
                }
            }
        }

        public static int insertFees(FinanceEntity fe)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("insertStudentFee",conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@grno",fe.Grno);
                    cmd.Parameters.AddWithValue("@course",fe.courseName);
                    cmd.Parameters.AddWithValue("paymentdate", fe.paymentDate);
                    cmd.Parameters.AddWithValue("@paymentyear",fe.paymentYear);
                    cmd.Parameters.AddWithValue("@paidfee",fe.paidFee);
                    cmd.Parameters.AddWithValue("@totalpaid",fe.totalPaid);
                    cmd.Parameters.AddWithValue("@duefee",fe.due);
                    cmd.Parameters.AddWithValue("@discount",fe.discountPercent);
	                cmd.Parameters.AddWithValue("@payablefee",fe.payableFees);
                    cmd.Parameters.AddWithValue("@totalfee",fe.TotalFees);
                    cmd.Parameters.AddWithValue("@paymentmode",1);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
