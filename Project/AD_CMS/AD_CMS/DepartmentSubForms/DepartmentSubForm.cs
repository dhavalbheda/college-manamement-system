using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AD_CMS.DepartmentSubForms
{
    public partial class DepartmentSubForm : TemplateForm
    {
        public DepartmentSubForm()
        {
            InitializeComponent();
        }

        private void Set_ModifyDepartment_Click(object sender, EventArgs e)
        {
            Set_ModifyDepartmentDetails setdeptdet = new Set_ModifyDepartmentDetails();
            FormCall(setdeptdet);
        }

        private void ViewDepartmentDetails_Click(object sender, EventArgs e)
        {
            ViewDepartmentDetails viewdepartment = new ViewDepartmentDetails();
            FormCall(viewdepartment);
        }

        private void PromoteStudent_Click(object sender, EventArgs e)
        {
            UpdateStudentDepartment updatestuddept = new UpdateStudentDepartment();
            FormCall(updatestuddept);
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
