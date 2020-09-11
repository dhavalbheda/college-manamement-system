using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AD_CMS.FinanceDeptSubForms
{
    public partial class FinanceSubForms : TemplateForm
    {
        public FinanceSubForms()
        {
            InitializeComponent();
        }

        private void StudentFee_Click(object sender, EventArgs e)
        {
            StudentFeeCollection studfee = new StudentFeeCollection();
            FormCall(studfee);
        }

        private void ViewStudPayment_Click(object sender, EventArgs e)
        {
            ViewStudentPaymentDetails studpay = new ViewStudentPaymentDetails();
            FormCall(studpay);
        }

        private void SetEmpSal_Click(object sender, EventArgs e)
        {
            Set_ModifyEmpSalary setEmpSal = new Set_ModifyEmpSalary();
            FormCall(setEmpSal);
        }

        private void PayEmpSal_Click(object sender, EventArgs e)
        {
            PayEmployeeSalary payEmpSal=new PayEmployeeSalary();
            FormCall(payEmpSal);
            if (payEmpSal.isClose)
                payEmpSal.Dispose();

        }

        private void EmployeeSalaryDetails_Click(object sender, EventArgs e)
        {
            ViewEmployeeSalaryDetails empsaldet = new ViewEmployeeSalaryDetails();
            FormCall(empsaldet);
        }

        private static void FormCall(Form fm)
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
