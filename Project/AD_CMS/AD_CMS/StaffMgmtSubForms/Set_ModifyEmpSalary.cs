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

namespace AD_CMS.FinanceDeptSubForms
{
    public partial class Set_ModifyEmpSalary : TemplateForm
    {
        DataTable dt_emp;
        int tempid;
        public bool isclose = false;

        public Set_ModifyEmpSalary()
        {
            InitializeComponent();
        }

        private void Set_ModifyEmpSalary_Load(object sender, EventArgs e)
        {
            designation_comboBox.SelectedIndex = 0;

            loadDataGridView();
        }

        private void loadDataGridView()
        {
            dt_emp = Employee_Methods.loadEmp_salary("setsal");
            if (dt_emp.Rows.Count > 0)
            {
                emp_salary_dataGridView.DataSource = null;
                emp_salary_dataGridView.DataSource = dt_emp;
            }
            else
            {
                search_groupBox.Enabled = false;
                AlertBox.ShowDialog("There are no Employees Registered.!!!", AlertBox.AlertType.information, false);
                isclose = true;
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (empid_radioButton.Checked)
            {
                empid_panel.Visible = true;
                empid_TextBox.BackColor = Color.White;
                empid_TextBox.Clear();
                designation_panel.Hide();
                empnm_panel.Hide();
            }
            else if (empnm_radioButton.Checked)
            {
                empnm_textBox.BackColor = Color.White;
                empid_panel.Hide();
                empnm_textBox.Clear();
                designation_panel.Hide();
                empnm_panel.Show();
            }
            else if (designation_radioButton.Checked)
            {
                designation_comboBox.BackColor = Color.White;
                designation_comboBox.SelectedIndex = 0;
                empid_panel.Hide();
                designation_panel.Show();
                empnm_panel.Hide();
            }
        }

        private void find_button_Click(object sender, EventArgs e)
        {
            DataView dv = dt_emp.DefaultView;
            if (empid_radioButton.Checked)
            {
                dv.RowFilter = "Convert([Employee Id],System.String) like '%" + empid_TextBox.Text + "%'";
            }
            else if (empnm_radioButton.Checked)
            {
                dv.RowFilter = "[Employee Name] like '%" + empnm_textBox.Text + "%'";
            }
            else if (designation_radioButton.Checked)
            {                
                if (!designation_comboBox.Text.Equals("all", StringComparison.OrdinalIgnoreCase))
                {
                    dv.RowFilter = "[Employee Type] = '" + designation_comboBox.Text + "'";
                }
                else
                {
                    dv.RowFilter = "";
                }
            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            ClassCall.textChangeFun(sender as Control);
            enableUpdateButton();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            EmployeeEntity entity = new EmployeeEntity()
            {
                empid = tempid,
                salary = int.Parse(emp_salary_textBox.Text)
            };

            int affected = Employee_Methods.UpdateEmployee_salary(entity);
            if (affected > 0)
            {
                AlertBox.ShowDialog("Salary Updated Successfully.", AlertBox.AlertType.success, true);
                emp_nm_sal_panel.Enabled = false;
                empid_radioButton.Checked = true;
                loadDataGridView();
            }
        }

        private void search_groupBox_Enter(object sender, EventArgs e)
        {
            emp_nm_sal_panel.Enabled = false;
        }

        private void emp_salary_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex != -1)
                {
                    emp_nm_sal_panel.Enabled = true;
                    string name = emp_salary_dataGridView.SelectedRows[0].Cells["Employee Name"].Value.ToString();
                    string salary = emp_salary_dataGridView.SelectedRows[0].Cells["Salary"].Value.ToString();
                    tempid = int.Parse(emp_salary_dataGridView.SelectedRows[0].Cells["Employee Id"].Value.ToString());
                    empname_textbox.Text = name;
                    emp_salary_textBox.Text = (salary.Equals("Not Set", StringComparison.OrdinalIgnoreCase)) ? "" : salary;

                    enableUpdateButton();
                }
            }
        }

        private void enableUpdateButton()
        {
            if (string.IsNullOrEmpty(emp_salary_textBox.Text))
                update_button.Enabled = false;
            else
                update_button.Enabled = true;
        }
    }

}
