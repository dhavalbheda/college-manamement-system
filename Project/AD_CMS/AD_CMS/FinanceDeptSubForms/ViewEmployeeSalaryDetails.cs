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

namespace AD_CMS.FinanceDeptSubForms
{
    public partial class ViewEmployeeSalaryDetails : TemplateForm
    {
        public ViewEmployeeSalaryDetails()
        {
            InitializeComponent();
        }


        private void find_button_Click(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        
        private void textChanged(object sender, EventArgs e)
        {
            ClassCall.textChangeFun(sender as Control);
        }

        private void ViewEmployeeSalaryDetails_Load(object sender, EventArgs e)
        {
            sal_month_comboBox.SelectedIndex = 0;
        }

        private void loadDataGridView()
        {
            DataTable dt = Employee_Methods.viewsalary();

            view_emp_sal_dataGridView.DataSource = dt;
            
            string month = sal_month_comboBox.Text;

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                view_emp_sal_dataGridView.Columns[i].Visible = false;
            }

            visibleColumn("Employee Id");
            visibleColumn("Employee Name");
            visibleColumn("Salary");
            visibleColumn("Last Paid For");
            visibleColumn(month);
            
            if (paid_radioButton.Checked)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = month+" <> '1/1/1900'";
            }
            else if (due_radioButton.Checked)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = month + " = '1/1/1900'";
                view_emp_sal_dataGridView.Columns[month].Visible = false;
            }
            else if (all_radioButton.Checked)
            {
                view_emp_sal_dataGridView.Columns[month].Visible = false;
            }
        }

        private void visibleColumn(string str)
        {
            view_emp_sal_dataGridView.Columns[str].Visible = true;
        }
    }
}
