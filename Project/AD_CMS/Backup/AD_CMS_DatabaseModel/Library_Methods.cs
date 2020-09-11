using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AD_CMS_Entity;
using System.Data.SqlClient;
using AD_CMS;
using System.Data;
using System.Windows.Forms;

namespace AD_CMS_DatabaseModel
{
    public class Library_Methods
    {
        public static void Add_category(Library_Entity le)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    conn.Open();
                    cmd.CommandText = "Insert into BookCategory(Category_Name) values('" + le.category_name + "')";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Delete_category(string ctnm)
        {
            setDefaultCategory(ctnm);
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    conn.Open();
                    cmd.CommandText = "Delete BookCategory Where Category_Name='" + ctnm+"'";
                    cmd.Connection = conn;
                    int affected=cmd.ExecuteNonQuery();
                    return affected;
                }
            }
        }

        private static void setDefaultCategory(string nm)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("setDefaultBookCategory", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoryName", nm);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable load_category_Datagridview()
        {
            DataTable dt_Category = new DataTable();
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "Select * from BookCategory Where Category_id > 0 ";
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt_Category.Load(dr);
                    return dt_Category;
                }
            }
        }

        public static bool check_book(int bookid)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "Select * from L_Book where BookID = " + bookid;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        return false;
                    }
                    else
                    {
                       return true;
                    }
                }
            }
        }

        public static int Add_book(Library_Entity le)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("add_book", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@BookID", le.bookid);
                    cmd.Parameters.AddWithValue("@BookName", le.booknm);
                    cmd.Parameters.AddWithValue("@CategoryID", le.categoryid);
                    cmd.Parameters.AddWithValue("@AuthorName", le.authornm);
                    cmd.Parameters.AddWithValue("@PubliserName", le.publisernm);
                    cmd.Parameters.AddWithValue("@Price", le.price);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable load_Book_Datagridview()
        {
            DataTable dt_Category = new DataTable();
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    //cmd.CommandText = "SELECT L_Book.BookID,L_Book.BookName AS 'Book Name',BookCategory.Category_Name 'Category',L_Book.AuthorName As 'Author Name', L_Book.PubliserName AS 'Publiser Name', L_Book.Stock AS 'Total Book', L_Book.Available AS 'Available Book', L_Book.Price FROM BookCategory INNER JOIN L_Book ON BookCategory.Category_ID = L_Book.CategoryID";
                    cmd.CommandText = "SELECT L_Book.BookID,L_Book.BookName AS 'Book Name',(SELECT Category_Name from BookCategory where Category_ID=L_Book.CategoryID) AS'Category',L_Book.AuthorName As 'Author Name', L_Book.PubliserName AS 'Publiser Name', L_Book.Available AS 'Available Book', L_Book.Price FROM L_Book ";
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt_Category.Load(dr);
                    return dt_Category;
                }
            }
        }

        public static string find_studentnm(int grno)
        {
            string name="default";
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                conn.Open();
                SqlCommand cmd;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select s_fullname from student where Grno = " + grno;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dr.Read();
                        if (dr.HasRows)
                        {
                           name = (string)dr[0];
                        }
                        return name;
                    }
                }
            }
        }

        public static string find_bookname(int bookid, out bool available)
        {
            string name = "Default";
            available = false;
           
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                conn.Open();
                SqlCommand cmd;
                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select BookName,Available from L_Book where BookID= " + bookid;

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            name = (string)dr[0];
                            available = (bool)dr[1];
                        }
                    }
                }
            }
            return name;
        }

        public static int borrow_book(Library_Entity le)
        {
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("borrow_book", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@bookid", le.bookid);
                    cmd.Parameters.AddWithValue("@grno", le.grno);
                    cmd.Parameters.AddWithValue("@issue_date", le.date);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static void find_return_details(int bookid,out int grno,out String Stud_name)
        {
            grno = 0;
            Stud_name = "default";
            using (SqlConnection con = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("return_find_stud",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@bookid", bookid);

                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            grno = (int)dr["Grno"];
                            Stud_name = (string)dr["Stud_name"];                           
                        }
                    }
                }
            }
        }

        public static int return_book(Library_Entity le)
        {
            using (SqlConnection con = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("return_book",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@bookid", le.bookid);
                    cmd.Parameters.AddWithValue("return_date", le.date);
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
