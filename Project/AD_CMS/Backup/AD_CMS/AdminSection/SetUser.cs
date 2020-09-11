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

namespace AD_CMS.CollegeDetails
{
    public partial class SetUser : TemplateForm
    {
        public SetUser()
        {
            InitializeComponent();
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                AdminSectionEntity ce = new AdminSectionEntity()
                {
                    userName = username_TextBox.Text,
                    password = password_TextBox.Text,
                    userRole = int.Parse(userRole_comboBox.SelectedValue.ToString())
                };
                bool isNotExists= AdminSection_Methods.insertUsers(ce);
                if (isNotExists)
                {
                    AlertBox.ShowDialog("UserName is already Exists.", AlertBox.AlertType.error, false);
                }
                else
                {
                    AlertBox.ShowDialog("User Created", AlertBox.AlertType.success, true);
                }
            }
        }

       

        private bool Valid()
        {
            bool flag = true;
            if (username_TextBox.Text == "")
            {
                if (flag)
                {
                    AlertBox.ShowDialog("Please Fill Require Details...", AlertBox.AlertType.warning, true);
                }
                flag = false;
                username_TextBox.BackColor = Color.Pink;
            }
            if (password_TextBox.Text == "")
            {
                if (flag)
                {
                    AlertBox.ShowDialog("Please Fill Require Details...", AlertBox.AlertType.warning, true);
                }
                flag = false;
                password_TextBox.BackColor = Color.Pink;
            }
            if (re_password_TextBox.Text == "")
            {
                if (flag)
                {
                    AlertBox.ShowDialog("Please Fill Require Details...", AlertBox.AlertType.warning, true);
                }
                flag = false;
                re_password_TextBox.BackColor = Color.Pink;
            }
            if (password_TextBox.Text != re_password_TextBox.Text)
            {
                if (flag)
                {
                    AlertBox.ShowDialog("Password Does Not Match.",AlertBox.AlertType.warning,true);
                    flag = false;
                    re_password_TextBox.BackColor = Color.Pink;
                }
            }
            if (password_TextBox.Text.Length < 6)
            {
                if (flag)
                {
                    AlertBox.ShowDialog("Password Must B Of 6 Characters...", AlertBox.AlertType.warning, true);
                    flag = false;
                    password_TextBox.BackColor = Color.Pink;
                    re_password_TextBox.BackColor = Color.Pink;
                }
            }
            return flag;
        }

        private void TextChange(object sender, EventArgs e)
        {
            ClassCall.textChangeFun(sender as Control);
        }

        private void loadUserRole()
        {
            DataTable dt = AdminSection_Methods.loadUserRole();
            userRole_comboBox.DisplayMember = "RoleDescription";
            userRole_comboBox.ValueMember = "RoleId";
            userRole_comboBox.DataSource = dt;
        }

        private void SetUser_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            loadUserRole();
        }

        private void loadDataGridView()
        {
            DataTable dt = AdminSection_Methods.loadDataGridView();
            if (dt.Rows.Count > 0)
            {
                users_dataGridView.DataSource = dt;
                users_dataGridView.AutoGenerateColumns = false;
                if (!users_dataGridView.Columns.Contains("delete"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn()
                    {
                        Name = "delete",
                        HeaderText = "DELETE",
                        UseColumnTextForButtonValue = true,
                        Text = "Remove",
                        Visible = true
                    };
                    users_dataGridView.Columns.Insert(users_dataGridView.Columns.Count, btn);
                }   
            }
        }

        private void users_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == users_dataGridView.Columns.Count-1)
                {
                    int id = int.Parse(users_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    int affected = AdminSection_Methods.deleteUser(id);
                    if (affected > 0)
                    {
                        AlertBox.ShowDialog("User Deleted Sucesfully", AlertBox.AlertType.success, false);
                        loadDataGridView();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username_TextBox.Clear();
            password_TextBox.Clear();
            re_password_TextBox.Clear();
            userRole_comboBox.SelectedIndex = 0;
            username_TextBox.BackColor = Color.White;
            password_TextBox.BackColor = Color.White;
            re_password_TextBox.BackColor = Color.White;
            userRole_comboBox.BackColor = Color.White;
        }

        
    }
}
