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
    public partial class Set_ModifyDepartmentDetails : TemplateForm
    {
        public Set_ModifyDepartmentDetails()
        {
            InitializeComponent();
        }

        //validate & find data into database
        private void find_button_Click(object sender, EventArgs e)
        {
            subject_panel.Enabled = false;
            if (finding_details_validation())
            {
                loadDataGridiew();
            }
        }

        private bool finding_details_validation()
        {
            bool flg = true;
            if (dept_name_comboBox.Text.Contains("select"))
            {
                dept_name_comboBox.BackColor = Color.Pink;
                flg = false;
            }
            if (!flg)
            {
                AlertBox.ShowDialog("Please enter data in required field", AlertBox.AlertType.error, false);
            }
            return flg;
        }

        //validate & save data and insert it into database
        private void save_button_Click(object sender, EventArgs e)
        {
            if (save_details_validation())
            {
                int affected = Department_Methods.setSubjectTeacher(select_teacher_comboBox.Text, subject_nm_comboBox.Text);
                if (affected > 0)
                {
                    AlertBox.ShowDialog("Data saved successfully", AlertBox.AlertType.success, true);
                    loadDataGridiew();
                }
            }
        }

        private bool save_details_validation()
        {
            bool flg = true;

            if (subject_nm_comboBox.Text.Equals("select"))
            {
                subject_nm_comboBox.BackColor = Color.Pink;
                flg = false;
            }
            if (select_teacher_comboBox.Text.Equals("select"))
            {
                select_teacher_comboBox.BackColor = Color.Pink;
                flg = false;
            }
            if (!flg)
            {
                AlertBox.ShowDialog("Please enter data in required field", AlertBox.AlertType.error, false);
            }
            return flg;
        }

        private void set_modify_textChanged(object sender, EventArgs e)
        {
            ClassCall.textChangeFun(sender as Control);
        }

        private void Set_ModifyDepartmentDetails_Load(object sender, EventArgs e)
        {
            loadEmployee();
            loadDepartment();
            dept_name_comboBox_SelectedIndexChanged(sender, e);

            loadDataGridiew();
        }

        private void loadEmployee()
        {
            List<string> nm = Department_Methods.loadEmployeeName();
            if (nm.Count > 0)
            {
                string[] temp = new string[nm.Count];
                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = nm[i].ToString();
                }
                select_teacher_comboBox.Items.Clear();
                select_teacher_comboBox.Items.AddRange(temp);
            }
            else
            {
                select_teacher_comboBox.Items.Add("select");
            }
            select_teacher_comboBox.SelectedIndex = 0;
        }

        private void loadDataGridiew()
        {
            int sem = int.Parse(select_sem_numericUpDown.Value.ToString());
            DataTable department = Department_Methods.load_Set_Modify_DepartmentGridView(dept_name_comboBox.Text, sem);
            department_dataGridView.DataSource = department;

            if (department.Rows.Count > 0)
            {
                subject_nm_comboBox.DisplayMember = "SubjectName";
                subject_nm_comboBox.DataSource = department;
                subject_nm_comboBox.SelectedIndex = 0;

                int rowid = department_dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                string empnm = department_dataGridView.Rows[rowid].Cells[1].Value.ToString();
                if (empnm.Equals("not set", StringComparison.OrdinalIgnoreCase))
                {
                    select_teacher_comboBox.Text = empnm;
                }
                else
                    select_teacher_comboBox.SelectedIndex = 0;
            }
        }

        private void loadDepartment()
        {
            DataTable dt = Department_Methods.GetCourse();
            if (dt.Rows.Count > 0)
            {
                dept_name_comboBox.DisplayMember = "C_Alias";
                dept_name_comboBox.ValueMember = "C_TotalSem";
                dept_name_comboBox.DataSource = dt;
                find_button.Enabled = true;
            }
            else
            {
                dept_name_comboBox.DataSource = null;
                dept_name_comboBox.Items.Add("select");
                dept_name_comboBox.SelectedIndex = 0;
                select_sem_numericUpDown.Enabled = false;
                find_button.Enabled = false;
            }
        }

        private void dept_name_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dept_name_comboBox.Text.Equals("select",StringComparison.OrdinalIgnoreCase))
            {
                select_sem_numericUpDown.Maximum = decimal.Parse(dept_name_comboBox.SelectedValue.ToString());
                select_sem_numericUpDown.Value = select_sem_numericUpDown.Minimum;
            }
        }

        private void department_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex != -1)
                {
                    if (department_dataGridView.Rows.Count > 0)
                    {
                        subject_panel.Enabled = true;
                        subject_nm_comboBox.Text = department_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    }
                }
            }   
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //select teacher & select subject will enabled when the double click event of data grid view occurs 
    }
}
