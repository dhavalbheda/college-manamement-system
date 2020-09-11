using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AD_CMS.StudentMgmtSubForms
{
    public partial class StudentSubForm : TemplateForm
    {
        public StudentSubForm()
        {
            InitializeComponent();
        }

        private void StudentAddmission_Click(object sender, EventArgs e)
        {
            StudentAdmission studadd = new StudentAdmission();
            FormCall(studadd);
        }

        private void UpdateStudent_Click(object sender, EventArgs e)
        {
            SearchStudent studupdate = new SearchStudent();
            studupdate.update_button.Text = "Update";
            studupdate.remove_button.Visible = true;
            FormCall(studupdate);
        }
        private void StudentProfile_Click(object sender, EventArgs e)
        {
            SearchStudent studprofile = new SearchStudent();
            studprofile.update_button.Text = "View Student Details";
            studprofile.student_search_groupBox.Controls.Add(studprofile.update_button);
            studprofile.update_button.Location = new System.Drawing.Point(400, 27);
            studprofile.update_button.Width = 180;
            studprofile.update_button.Font = new Font("Times New Roman", 13);
            studprofile.remove_button.Visible = false;
            FormCall(studprofile);
        }

        private void FormCall()
        {
            throw new NotImplementedException();
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
