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
using System.IO;

namespace AD_CMS.StaffMgmtSubForms
{
    public partial class SearchEmployee : TemplateForm
    {
        EmployeeRegistration employeeadd;
        DataTable dt_employee;
        DataView dv;
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            if (employee_dataGridView.Rows.Count > 0)
            {
                int selectedRow = employee_dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                int empid = Convert.ToInt32(employee_dataGridView.Rows[selectedRow].Cells["EMPID"].Value);
                string path = employee_dataGridView.Rows[selectedRow].Cells["Profile"].Value.ToString();
                int affectedRow = Employee_Methods.deleteEmployee(empid);

                if (affectedRow > 0)
                {
                    AlertBox.ShowDialog("Successfully deleted.", AlertBox.AlertType.success, true);
                    if (!string.IsNullOrEmpty(path))
                    {
                        System.GC.Collect();
                        System.GC.WaitForPendingFinalizers();

                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }
                    }
                    select_designation_comboBox.SelectedIndex = 0;
                    emp_details_textBox.Clear();
                    loadDataGridView();
                }
            }
        }


        public void loadDataGridView()
        {
            dt_employee = Employee_Methods.loadEmployee();
            employee_dataGridView.DataSource = null;
            employee_dataGridView.DataSource = dt_employee;
            employee_dataGridView.Columns["Profile"].Visible = false;
        }

        private void SearchEmployee_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            select_designation_comboBox.SelectedIndex = 0;
        }


        private void update_button_Click(object sender, EventArgs e)
        {
            if (employee_dataGridView.Rows.Count > 0)
            {
                int selectedRow = employee_dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                int empid = Convert.ToInt32(employee_dataGridView.Rows[selectedRow].Cells["EmpID"].Value);

                DataTable dt = Employee_Methods.loadEmployeeDetails_Form(empid);

                employeeadd = new EmployeeRegistration(LoadUpdateForm(dt), this);
                employeeadd.isUpdate = true;
                employeeadd.TopLevel = false;
                employeeadd.Parent = ClassCall.mainFormObj.masterpanel;
                employeeadd.Dock = DockStyle.Fill;
                employeeadd.BringToFront();
                employeeadd.Focus();
                employeeadd.Show();

                this.Dispose();
            }
        }

        private EmployeeEntity LoadUpdateForm(DataTable dt)
        {
            EmployeeEntity ey = new EmployeeEntity();
            string[] father = dt.Rows[0].Field<string>("E_FatherName").Split(' ');
            string[] mother = dt.Rows[0].Field<string>("E_MotherName").Split(' ');
            string[] employee = dt.Rows[0].Field<string>("E_Name").Split(' ');

            /****************************Parents Details ***********************************/
            ey.emp_firstName = employee[0];
            ey.emp_middleName = employee[1];
            ey.emp_lastName = employee[2];
            ey.father_firstName = father[0];
            ey.father_middleName = father[1];
            ey.father_lastName = father[2];
            ey.mother_firstName = mother[0];
            ey.mother_middleName = mother[1];
            ey.mother_lastName = mother[2];

            ey.empid = dt.Rows[0].Field<int>("EmpID");
            ey.profile = dt.Rows[0].Field<string>("E_Profile");
            ey.joinDate = dt.Rows[0].Field<DateTime>("E_JoinDate");
            ey.isTeaching = dt.Rows[0].Field<string>("E_IsTeaching");
            ey.currentAddress = dt.Rows[0].Field<string>("E_CurrentAddress");
            ey.permanentAddress = dt.Rows[0].Field<string>("E_PermanenetAddress");
            ey.pincode = dt.Rows[0].Field<int?>("E_Pincode");
            ey.cityid = dt.Rows[0].Field<int>("E_CityId");
            ey.stateid = dt.Rows[0].Field<int>("E_StateID");
            ey.countryid = dt.Rows[0].Field<int>("E_CountryId");
            ey.gender = dt.Rows[0].Field<string>("E_Gender");
            ey.castid = dt.Rows[0].Field<byte>("E_CastId");
            ey.dob = dt.Rows[0].Field<DateTime>("E_DOB");
            ey.birthplace = dt.Rows[0].Field<string>("E_Birthplace");
            ey.empmobileNo = dt.Rows[0].Field<Int64>("E_EmpMobileno");
            ey.email = dt.Rows[0].Field<string>("E_Email");
            ey.telephone = dt.Rows[0].Field<Int64?>("E_Telephone");
            ey.perentsNo = dt.Rows[0].Field<Int64>("E_ParentsMobileNo");
            ey.degree = dt.Rows[0].Field<string>("E_Degree");
            ey.lastEmployeeAt = dt.Rows[0].Field<string>("E_LastEmployerAt");
            ey.YearOfExperience = dt.Rows[0].Field<int?>("E_YearOfExperience");
            ey.remark = dt.Rows[0].Field<string>("E_Remark");

            ey.bankID = dt.Rows[0].Field<int>("BankID");
            ey.accountNo = dt.Rows[0].Field<Int64>("AccountNo");
            ey.IFSCCode = dt.Rows[0].Field<string>("IFSCCode");
            ey.BranchName = dt.Rows[0].Field<string>("BranchName");

            ey.aadharCard = dt.Rows[0].Field<bool>("I_Aadharcard");
            ey.panCard = dt.Rows[0].Field<bool>("I_Pancard");
            ey.experienceCertificate = dt.Rows[0].Field<bool>("I_ExperienceCertificate");
            ey.degreeCertificate = dt.Rows[0].Field<bool>("I_DegreeCertificate");

            return ey;

        }

        private void select_designation_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (select_designation_comboBox.SelectedIndex != 0)
            {
                dv = dt_employee.DefaultView;
                dv.RowFilter = string.Format("Designation like '{0}'", select_designation_comboBox.Text);
            }
            else
            {
                dt_employee.DefaultView.RowFilter = "";
            }
        }

        private void emp_details_textBox_TextChanged(object sender, EventArgs e)
        {
            if (dt_employee.Rows.Count > 0)
            {
                dv = dt_employee.DefaultView;
                if (select_designation_comboBox.SelectedIndex != 0)
                {
                    dv.RowFilter = @"EmpoyeeName like '%" + emp_details_textBox.Text + "%'" +
                                    "OR City like '%" + emp_details_textBox.Text + "%'" +
                                    "OR Convert([EMPID],System.String) like '%" + emp_details_textBox.Text + "%'" +
                                    "OR Convert([MobileNo],System.String) like '%" + emp_details_textBox.Text + "%'" +
                                    "AND Designation='" + select_designation_comboBox.Text + "'";
                }
                else
                {
                    dv.RowFilter = @"EmpoyeeName like '%" + emp_details_textBox.Text + "%'" +
                                    "OR City like '%" + emp_details_textBox.Text + "%'" +
                                    "OR Convert([EMPID],System.String) like '%" + emp_details_textBox.Text + "%'" +
                                    "OR Convert([MobileNo],System.String) like '%" + emp_details_textBox.Text + "%'";
                }
            }
        }

    }
}
