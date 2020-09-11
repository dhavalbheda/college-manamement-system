using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AD_CMS.FinanceDeptSubForms;

namespace AD_CMS.StaffMgmtSubForms
{
    public partial class EmployeeSubForms : TemplateForm
    {
        public EmployeeSubForms()
        {
            InitializeComponent();
        }

        private void EmployeeRegistration_Click(object sender, EventArgs e)
        {
            EmployeeRegistration empreg = new EmployeeRegistration();
            Formcall(empreg);
        }

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {
            SearchEmployee empupdate = new SearchEmployee();
            Formcall(empupdate);
        }

        private void EmployeeProfile_Click(object sender, EventArgs e)
        {
            SearchEmployee empprofile = new SearchEmployee();
            Formcall(empprofile);
        }

        private void Set_Modify_Emp_Sal_Click(object sender, EventArgs e)
        {
            Set_ModifyEmpSalary empsal = new Set_ModifyEmpSalary();
            Formcall(empsal);
            if (empsal.isclose)
                empsal.Dispose();
        } 

        public static void Formcall(Form fm)
        {
            fm.TopLevel = false;
            fm.Parent = ClassCall.mainFormObj.masterpanel;
            fm.Dock = DockStyle.Fill;
            fm.Show();
            fm.BringToFront();
            fm.Focus();
        }

        private void FormCloseBtn_Click(object sender, EventArgs e)
        {
            ClassCall.openHomePage();
        }
    }
}
