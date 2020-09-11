using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomMessageBox;
using AD_CMS_Entity;
using AD_CMS_DatabaseModel;

namespace AD_CMS.LibraryMgmtSubForms
{
    public partial class AddBooks : TemplateForm
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {
            loadCategory();
            loadDatagridview();
        }

        private void loadDatagridview()
        {
            DataTable dt = Library_Methods.load_Book_Datagridview();
            Book_dataGridView.DataSource = null;
            Book_dataGridView.DataSource = dt;
            //Book_dataGridView.Columns[0].Visible = false;
        }

        private void loadCategory()
        {
            DataTable dt_Category = Library_Methods.load_category_Datagridview();
            select_category_comboBox.DataSource = dt_Category;
            select_category_comboBox.DisplayMember = "Category_Name";
            select_category_comboBox.ValueMember = "Category_ID";
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                if (Library_Methods.check_book(int.Parse(bookid_textbox.Text)))
                {
                    Library_Entity le = new Library_Entity()
                    {
                        bookid = int.Parse(bookid_textbox.Text),
                        booknm = booknm_TextBox.Text,
                        categoryid = int.Parse(select_category_comboBox.SelectedValue.ToString()),
                        authornm = authornm_TextBox.Text,
                        publisernm = publisernm_TextBox.Text,
                        price = int.Parse(price_numericUpDown.Value.ToString())
                    };
                    int flag = Library_Methods.Add_book(le);
                    if (flag > 0)
                    {
                        AlertBox.ShowDialog("Add Book Sucessfully", AlertBox.AlertType.success, true);
                        loadDatagridview();
                    }
                }
                else
                {
                    AlertBox.ShowDialog("Already Available BookID", AlertBox.AlertType.warning, true);
                    bookid_textbox.Focus();
                }
            }
        }
        private bool valid()
        {
            bool flag = true;
            if (bookid_textbox.Text == "")
            {
                if (flag)
                    AlertBox.ShowDialog("Please Enter BookID", AlertBox.AlertType.error, false);
                flag = false;
                bookid_textbox.BackColor = Color.Pink;
            }
            if (booknm_TextBox.Text == "")
            {
                if (flag)
                    AlertBox.ShowDialog("Please Enter Book Name", AlertBox.AlertType.error, false);
                flag = false;
                booknm_TextBox.BackColor = Color.Pink;
            }
            if (authornm_TextBox.Text == "")
            {
                if (flag)
                    AlertBox.ShowDialog("Please Enter Author Name", AlertBox.AlertType.error, false);
                flag = false;
                authornm_TextBox.BackColor = Color.Pink;
            }
            if (publisernm_TextBox.Text == "")
            {
                if (flag)
                    AlertBox.ShowDialog("Please Enter Publiser Name", AlertBox.AlertType.error, false);
                flag = false;
                publisernm_TextBox.BackColor = Color.Pink;
            }
            if (price_numericUpDown.Value == 0)
            {
                if (flag)
                    AlertBox.ShowDialog("Please Set Valid Price", AlertBox.AlertType.error, false);
                flag = false;
                price_numericUpDown.BackColor = Color.Pink;
            }
            return flag;
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            Clear_value();
        }

        private void Clear_value()
        {
            bookid_textbox.Text = "";
            bookid_textbox.BackColor = Color.White;
            booknm_TextBox.Text = "";
            booknm_TextBox.BackColor = Color.White;
            authornm_TextBox.Text = "";
            authornm_TextBox.BackColor = Color.White;
            publisernm_TextBox.Text = "";
            publisernm_TextBox.BackColor = Color.White;
            price_numericUpDown.Value = 0;
            price_numericUpDown.BackColor = Color.White;
            select_category_comboBox.SelectedIndex = 0;
        }

        private void TextChanged(object sender, EventArgs e)
        {
            Control ct = sender as Control;
            ct.BackColor = Color.White;
        }
    }
}
