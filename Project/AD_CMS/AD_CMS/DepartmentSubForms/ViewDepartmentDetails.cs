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

namespace AD_CMS.DepartmentSubForms
{
    public partial class ViewDepartmentDetails : TemplateForm
    {
        public ViewDepartmentDetails()
        {
            InitializeComponent();
        }

        //close the form
        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //validate details for finding data
        private void find_button_Click(object sender, EventArgs e)
        {
            if (finding_details_validation())
            {
                loadSubject_Teacher();
                loadStudentGridView();
            }
        }

        private void loadStudentGridView()
        {
            int sem = int.Parse(select_sem_numericUpDown.Value.ToString());
            string course = select_dept_comboBox.Text;
            DataTable dt = Department_Methods.viewStudent(course, sem);
            all_student_dataGridView.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                total_textBox.Text = dt.Rows.Count.ToString();
                int boy = 0, girl = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string text = all_student_dataGridView.Rows[i].Cells["Gender"].Value.ToString();
                    if (text.Equals("male", StringComparison.OrdinalIgnoreCase))
                        boy += 1;
                    else
                        girl += 1;
                }
                boys_textBox.Text = boy.ToString();
                girls_textBox.Text = girl.ToString();
            }
            else
            {
                boys_textBox.Text = "0";
                girls_textBox.Text = "0";
                total_textBox.Text = "0";
            }
        }

        private void loadSubject_Teacher()
        {
            int sem = int.Parse(select_sem_numericUpDown.Value.ToString());
            DataTable dt = Department_Methods.load_Set_Modify_DepartmentGridView(select_dept_comboBox.Text, sem);
            all_sub_dataGridView.DataSource = dt;
        }

        private bool finding_details_validation()
        {
            bool flg = true;

            if (select_dept_comboBox.Text.Equals("select"))
            {
                flg = false;
                select_dept_comboBox.BackColor = Color.Pink;
            }
            if (!flg)
            {
                AlertBox.ShowDialog("Please enter data in required field", AlertBox.AlertType.error, false);
            }
            return flg;
        }

        private void view_dept_textChanged(object sender, EventArgs e)
        {
            ClassCall.textChangeFun(sender as Control);
        }

        private void ViewDepartmentDetails_Load(object sender, EventArgs e)
        {
            loadDepartment();
            loadStudentGridView();
            loadSubject_Teacher();
        }

        private void loadDepartment()
        {
            DataTable dt = Department_Methods.GetCourse();
            if (dt.Rows.Count > 0)
            {
                select_dept_comboBox.DisplayMember = "C_Alias";
                select_dept_comboBox.ValueMember = "C_TotalSem";
                select_dept_comboBox.DataSource = dt;
                find_button.Enabled = true;
            }
            else
            {
                select_dept_comboBox.DataSource = null;
                select_dept_comboBox.Items.Add("select");
                select_dept_comboBox.SelectedIndex = 0;
                select_sem_numericUpDown.Enabled = false;
                find_button.Enabled = false;
            }
        }

        private void select_dept_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!select_dept_comboBox.Text.Equals("select", StringComparison.OrdinalIgnoreCase))
            {
                select_sem_numericUpDown.Maximum = decimal.Parse(select_dept_comboBox.SelectedValue.ToString());
                select_sem_numericUpDown.Value = select_sem_numericUpDown.Minimum;
            }
        }

    }
}
