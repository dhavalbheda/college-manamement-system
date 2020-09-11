using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomMessageBox;
using AD_CMS_DatabaseModel;
using AD_CMS_Entity;

namespace AD_CMS.LibraryMgmtSubForms
{
    public partial class ReturnBook : TemplateForm
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            bookid_textbox.Text = "";
            booknm_TextBox.Text = "";
            studentnm_TextBox.Text = "";
            grno_TextBox.Text = "";
            returnbook_datetimepicker.Value = DateTime.Today;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                Library_Entity le = new Library_Entity()
                {
                    bookid = int.Parse(bookid_textbox.Text),
                    date = returnbook_datetimepicker.Value
                };
               int flag = Library_Methods.return_book(le);
               if (flag != null)
               {
                   AlertBox.ShowDialog("Return Successfully...", AlertBox.AlertType.success, true);
                   clear();
               }
               else
               {
                   AlertBox.ShowDialog("Return Canceled...", AlertBox.AlertType.error, true);
               }
            } 
        }

        private bool valid()
        {
            if (bookid_textbox.Text == "")
            {
                bookid_textbox.BackColor = Color.Pink;
                AlertBox.ShowDialog("Please Enter Book ID..", AlertBox.AlertType.warning, true);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void bookid_textbox_TextChanged(object sender, EventArgs e)
        {
            bookid_textbox.BackColor = Color.White;
        }

        private void bookid_textbox_Leave(object sender, EventArgs e)
        {
            bool available;
            if (bookid_textbox.Text != "")
            {
                string name = Library_Methods.find_bookname(int.Parse(bookid_textbox.Text), out available);
                if (name.Equals("default", StringComparison.OrdinalIgnoreCase))
                {
                    AlertBox.ShowDialog("No Books Available..Check BookID.", AlertBox.AlertType.warning, true);
                    booknm_TextBox.Text = "";
                    bookid_textbox.Text = "";
                    bookid_textbox.Focus();
                }
                else if (available)
                {
                    booknm_TextBox.Text = name;
                    AlertBox.ShowDialog("No One Issue This Book...", AlertBox.AlertType.warning, true);
                    booknm_TextBox.Text = "";
                    bookid_textbox.Text = "";
                    bookid_textbox.Focus();
                }
                else
                {
                    booknm_TextBox.Text = name;
                    int grno;
                    string Stud_name;
                    Library_Methods.find_return_details(int.Parse(bookid_textbox.Text), out grno, out Stud_name);
                    grno_TextBox.Text = grno.ToString();
                    studentnm_TextBox.Text = Stud_name;
                }
            }
        }

    }
}
