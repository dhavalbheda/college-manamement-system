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
    public partial class PayEmployeeSalary : TemplateForm
    {
        private DataTable dt_emp;
        public bool isClose=false;
        private int tempid;

        public PayEmployeeSalary()
        {
            InitializeComponent();
        }

        private void PayEmployeeSalary_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            sal_month_comboBox.SelectedIndex = 0;
            payment_dateTimePicker.MaxDate = DateTime.Today;
        }

        private void loadDataGridView()
        {
            dt_emp = Employee_Methods.loadEmp_salary("paysal");
            if (dt_emp.Rows.Count > 0)
            {
                employee_salary_dataGridView.DataSource = null;
                employee_salary_dataGridView.DataSource = dt_emp;
                employee_salary_dataGridView.Columns["Join Date"].Visible = false;
            }
            else
            {
                AlertBox.ShowDialog("There is No Employee Registered.", AlertBox.AlertType.information, false);
                isClose = true;
            }
        }

        private void Finding_options_CheckedChanged(object sender, EventArgs e)
        {
            if (empid_radioButton.Checked)
            {
                empid_panel.Show();
                empid_textBox.Clear();
                empnm_panel.Hide();
                designation_panel.Hide();
                empid_textBox.BackColor = Color.White;
            }
            else if (empnm_radioButton.Checked)
            {
                empnm_panel.Show();
                empnm_textBox.Clear();
                empid_panel.Hide();
                designation_panel.Hide();
                empnm_textBox2.BackColor = Color.White;
            }
            else if (designation_radioButton.Checked)
            {
                designation_panel.Show();
                designation_comboBox.SelectedIndex = 0;
                empid_panel.Hide();
                empnm_panel.Hide();
                designation_comboBox.BackColor = Color.White;
            }
        }

        private void find_button_Click(object sender, EventArgs e)
        {
            DataView dv = dt_emp.DefaultView;
            if (empid_radioButton.Checked)
            {
                dv.RowFilter = "Convert([Employee Id],System.String) like '%" + empid_textBox.Text + "%'";
            }
            else if (empnm_radioButton.Checked)
            {
                dv.RowFilter = "[Employee Name] like '%" + empnm_textBox2.Text + "%'";
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


        private void pay_sal_button_Click(object sender, EventArgs e)
        {
            EmployeeEntity ee = new EmployeeEntity();
            ee.empid = tempid;
            ee.paymentdate = payment_dateTimePicker.Value;
            ee.month = sal_month_comboBox.Text;

            int affected = Employee_Methods.paySalary(ee);
            if(affected > 0)
            AlertBox.ShowDialog("Salary paid successfully", AlertBox.AlertType.success, true);
            emp_details_panel.Enabled = false;
        }

        private void Controls_TextChanged(object sender, EventArgs e)
        {
            ClassCall.textChangeFun(sender as Control);
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void employee_salary_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex != -1)
                {
                    emp_details_panel.Enabled = true;
                    tempid = int.Parse(employee_salary_dataGridView.SelectedRows[0].Cells["Employee Id"].Value.ToString());
                    string name = employee_salary_dataGridView.SelectedRows[0].Cells["Employee Name"].Value.ToString();
                    string salary = employee_salary_dataGridView.SelectedRows[0].Cells["Salary"].Value.ToString();
                    DateTime join = (DateTime)employee_salary_dataGridView.SelectedRows[0].Cells["Join Date"].Value;

                    empnm_textBox.Text = name;
                    amount_textBox.Text = salary;
                    int month = payment_dateTimePicker.Value.Month;
                    sal_month_comboBox.SelectedIndex = month-1;
                    payment_dateTimePicker.MinDate = join;
                }
            }
        }

        private void search_groupBox_Enter(object sender, EventArgs e)
        {
            emp_details_panel.Enabled = false;
        }
    }
}
