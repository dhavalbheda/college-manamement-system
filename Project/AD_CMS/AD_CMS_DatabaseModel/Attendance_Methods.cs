using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AD_CMS;
using AD_CMS_Entity;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Data.OleDb;

namespace AD_CMS_DatabaseModel
{
    public class Attendance_Methods
    {
        public static System.Data.DataTable getDepartment()
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("select C_Alias,C_TotalSem from Courses where C_Fees!=0", conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Load(dr);
                    return (dt);
                }
            }
        }

        public static int UploadAttendance(Attendance_Entity ae)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("UploadAttendance", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@alias", ae.courseAlias);
                    cmd.Parameters.AddWithValue("@sem", ae.sem);
                    cmd.Parameters.AddWithValue("@month", ae.month);
                    cmd.Parameters.AddWithValue("@file", ae.file);
                    cmd.Parameters.AddWithValue("@batchyear", ae.batchYear);
                    conn.Open();

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int getBatchYear(string courseAlias,int currentsem)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getBatchYear", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@alias", courseAlias);
                    cmd.Parameters.AddWithValue("@sem", currentsem);

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        DateTime date = Convert.ToDateTime(dr[0]);
                        return date.Year;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        public static void GenerateSheet(string courseAlias, int sem, string filePath)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;

            worksheet.Name = "AttendanceSheet";
            app.DisplayAlerts = false;

            System.Data.DataTable dt = GetStudent(courseAlias, sem);

            if (dt.Rows.Count > 0)
            {
                int count = 1;

                int date = 1;
                for (int i = 0; i < 33; i++)
                {
                    if (i == 0)
                        worksheet.Cells[1, count] = "RollNo";
                    else if (i == 1)
                        worksheet.Cells[1, count] = "Student Name";
                    else
                    {
                        worksheet.Cells[1, count] = date.ToString();
                        date++;
                    }
                    count++;
                }
                worksheet.Columns.Locked = false;
                worksheet.get_Range((object)worksheet.Cells[1, 1], (object)worksheet.Cells[1, 33]).EntireRow.Locked = true;
                worksheet.EnableSelection = Excel.XlEnableSelection.xlUnlockedCells;

                Missing mv = Missing.Value;
                worksheet.Protect(mv, mv, mv, mv, mv, mv, mv, mv, mv, mv, mv, mv, mv, mv, mv, mv);

                count = 2;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        worksheet.Cells[count, 2] = dt.Rows[i][j].ToString();
                    }
                    count++;
                }
            }

            workbook.SaveAs(filePath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,
                            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                            Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            app.Quit();
        }

        private static System.Data.DataTable GetStudent(string alias,int sem)
        {
            using (SqlConnection con = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getStudentName", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@alias", alias);
                    cmd.Parameters.AddWithValue("@sem", sem);

                    con.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    if (dr.HasRows)
                    {
                        dt.Load(dr);
                    }
                    return dt;
                }
            }
        }

        public static System.Data.DataTable getBatchYears()
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT DISTINCT BatchYear
                                                       FROM Attendance", conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        public static System.Data.DataTable ExcelToDGV(string filenm,out bool hasSheet)
        {
            string constr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filenm
                                + @";Extended Properties='Excel 8.0;'";
            using (OleDbConnection conn = new OleDbConnection(constr))
            {
                conn.Open();
                System.Data.DataTable dt = new System.Data.DataTable("File");
                try
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter("select * from [AttendanceSheet$A:AG]", conn);
                    adapter.Fill(dt);
                    hasSheet = true;
                }
                catch (Exception e)
                {
                    hasSheet = false;
                }
                return dt;
            }
        }

        public static string getFileName(Attendance_Entity ae)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getFileName", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@alias", ae.courseAlias);
                    cmd.Parameters.AddWithValue("@sem", ae.sem);
                    cmd.Parameters.AddWithValue("@batch", ae.batchYear);
                    cmd.Parameters.AddWithValue("@month", ae.month);
                    conn.Open();
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }
    }
}
