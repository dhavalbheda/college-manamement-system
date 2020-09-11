using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AD_CMS_DatabaseModel;
using CustomMessageBox;
using AD_CMS_Entity;

namespace AD_CMS.LibraryMgmtSubForms
{
    public partial class BorrowBook : TemplateForm
    {
        public BorrowBook()
        {
            InitializeComponent();
        }

        private void grno_TextBox_Leave(object sender, EventArgs e)
        {
            if (grno_TextBox.Text != "")
            {
                string name = Library_Methods.find_studentnm(int.Parse(grno_TextBox.Text));
                if (name == "default")
                {
                    AlertBox.ShowDialog("No Student Available..Check Grno.", AlertBox.AlertType.warning, true);
                    studentnm_TextBox.Text = "";
                    grno_TextBox.Text = "";
                }
                else
                {
                    studentnm_TextBox.Text = name;
                }
            }
            else
            {
                studentnm_TextBox.Text = "";
            }
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
                else if (!available)
                {
                    booknm_TextBox.Text = name;
                    AlertBox.ShowDialog("This Book Is Already Taken...", AlertBox.AlertType.warning, true);
                    booknm_TextBox.Text = "";
                    bookid_textbox.Text = "";
                    bookid_textbox.Focus();
                }
                else
                {
                    booknm_TextBox.Text = name;
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                Library_Entity le = new Library_Entity()
                {
                    grno = int.Parse(grno_TextBox.Text),
                    bookid = int.Parse(bookid_textbox.Text),
                    date = dateTimePicker2.Value
                };
                Library_Methods.borrow_book(le);
                AlertBox.ShowDialog("Added successfull.", AlertBox.AlertType.success, true);
                clear();
            }
            
        }

        private bool valid()
        {
            bool flag= true;

            if (grno_TextBox.Text == "")
            {
                if (flag)
                {
                    grno_TextBox.BackColor = Color.Pink;
                    AlertBox.ShowDialog("Please Enter Student GRNO..", AlertBox.AlertType.warning, true);
                    flag = false;
                }
            }
            if (bookid_textbox.Text == "")
            {
                if (flag)
                {
                    bookid_textbox.BackColor = Color.Pink;
                    AlertBox.ShowDialog("Please Enter Book ID..", AlertBox.AlertType.warning, true);
                    flag = false;
                }
            }
            return flag;
        }

        private void TextChanged(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            ctrl.BackColor = Color.White;
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
            dateTimePicker2.Value = DateTime.Today;
        }

    }
}
