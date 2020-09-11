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

namespace AD_CMS.LogInForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        List<Control> AllOption;
        AD_CMS.MainForm mf;
        private void login_Button_Click(object sender, EventArgs e)
        {
            Object[] data = Login_Methods.user_login(usernm_textBox.Text, password_textBox.Text);

            if ((bool)data[0])
            {
                String role = data[1].ToString();
                MainForm.Role usr_role = setUserRole(role);
                
                 mf =  new AD_CMS.MainForm(this,usr_role);
                AllOption = new List<Control>();
                AllOption.Add(mf.studentmgmt_button);
                AllOption.Add(mf.staffmgmt_button);
                AllOption.Add(mf.courses_button);
                AllOption.Add(mf.department_button);
                AllOption.Add(mf.financedept_button);
                AllOption.Add(mf.attendance);
                AllOption.Add(mf.Library_Management);
                AllOption.Add(mf.collegedetails_button);
                AllOption.Add(mf.admin_section_button);

                
                if(role.Equals("Cashier",StringComparison.OrdinalIgnoreCase))
                {
                    VisibleOptions("financedept_button");
                }
                else if (role.Equals("TEACHER", StringComparison.OrdinalIgnoreCase))
                {
                    VisibleOptions("department_button", "attendance");
                }
                else if(role.Equals("LIBRARIAN",StringComparison.OrdinalIgnoreCase))
                {
                    VisibleOptions("Library_Management");
                }

                mf.Show();
                this.Hide();
            }
            else
            {
                AlertBox.ShowDialog("Incorrect User Name Or Password :( ", AlertBox.AlertType.warning, true);
            }
        }

        private MainForm.Role setUserRole(string role)
        {
            if (role.Equals("Cashier", StringComparison.OrdinalIgnoreCase))
                return MainForm.Role.Finance;
            else if (role.Equals("TEACHER", StringComparison.OrdinalIgnoreCase))
                return MainForm.Role.Teacher;
            else if (role.Equals("LIBRARIAN", StringComparison.OrdinalIgnoreCase))
                return MainForm.Role.Librarian;
            else
                return MainForm.Role.Admin;
        }

        private void VisibleOptions(params String[] nm)
        {
            for(int i = 0;i<AllOption.Count;i++)
            {
                for (int j = 0; j < nm.Length; j++)
                {
                    if (AllOption[i].Name.Equals(nm[j].ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        AllOption[i].Enabled = true;
                        break;
                    }
                    else
                    {
                        AllOption[i].Enabled = false;
                    }
                }
            }
            
        }


        private void Cancel_button_Click(object sender, EventArgs e)
        {
            usernm_textBox.Clear();
            password_textBox.Clear();
        }


    }
}
