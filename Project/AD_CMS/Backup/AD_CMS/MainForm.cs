using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AD_CMS.StudentMgmtSubForms;
using AD_CMS.StaffMgmtSubForms;
using AD_CMS.FinanceDeptSubForms;
using AD_CMS.DepartmentSubForms;
using AD_CMS.Courses;
using AD_CMS.AdminSection;
using AD_CMS.Attendance;
using System.IO;

namespace AD_CMS
{
    public partial class MainForm : Form
    {
        Form globalForm,loginfm;
        string userName;
        public enum Role
        {
            Admin,Teacher,Finance,Librarian
        }

        public MainForm()
        {
            InitializeComponent();
            ClassCall cc = new ClassCall(this);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            usernm_label.Text = "Welcome" + Environment.NewLine + userName;
            left_tableLayoutPanel.BackColor = Properties.Settings.Default.MainFormBack;
            upper_panel.BackColor = Properties.Settings.Default.MainFormBack;


            HomeCall();
        }

        public MainForm(LogInForm.LoginForm lf, Role usr_role)
        {
            InitializeComponent();

            this.loginfm = lf;
            userName = lf.usernm_textBox.Text;
            SetProfile(usr_role);
            lf.usernm_textBox.Clear();
            lf.password_textBox.Clear();

            ClassCall cc = new ClassCall(this);
        }

        private void SetProfile(Role role)
        {
            if (role == Role.Admin)
                user_pictureBox.Image = Properties.Resources.adminProfile;
            else if (role == Role.Teacher)
                user_pictureBox.Image = Properties.Resources.teacherProfile;
            else if (role == Role.Finance)
                user_pictureBox.Image = Properties.Resources.financeProfile;
            else if (role == Role.Librarian)
                user_pictureBox.Image = Properties.Resources.LibrarianProfile;
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            GlobalFormNull();
            HomePage.Home obj = new AD_CMS.HomePage.Home();
            globalForm = obj;
            formshow(obj);
        }

        private void Studentmgmt_button_Click(object sender, EventArgs e)
        {
            GlobalFormNull();
            StudentSubForm obj = new StudentSubForm();
            globalForm = obj;
            formshow(obj);
        }

        private void employee_button_Click(object sender, EventArgs e)
        {
            GlobalFormNull();
            EmployeeSubForms obj = new EmployeeSubForms();
            globalForm = obj;
            formshow(obj);
        }

        private void course_button_Click(object sender, EventArgs e)
        {
            GlobalFormNull();
            CourseSubForm obj = new CourseSubForm();
            globalForm = obj;
            formshow(obj);
        }

        private void finance_button_Click(object sender, EventArgs e)
        {
            GlobalFormNull();
            FinanceSubForms obj = new FinanceSubForms();
            globalForm = obj;
            formshow(obj);
        }

        private void department_button_Click(object sender, EventArgs e)
        {
            GlobalFormNull();
            DepartmentSubForm obj = new DepartmentSubForm();
            globalForm = obj;
            formshow(obj);
        }

        private void collegedetails_button_Click(object sender, EventArgs e)
        {
            GlobalFormNull();
            CollegeDetails.CollegeDetailsSubForm obj = new CollegeDetails.CollegeDetailsSubForm();
            globalForm = obj;
            formshow(obj);

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            logout_button_Click(sender, e);
        }

        private void GlobalFormNull()
        {
            if (globalForm != null)
            {
                globalForm.Dispose();
                globalForm = null;
            }
        }

        private void formshow(Form fm)
        {
            fm.TopLevel = false;
            fm.Parent = masterpanel;
            fm.Dock = DockStyle.Fill;
            fm.Show();
            fm.Focus();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.loginfm != null)
                this.loginfm.Show();
            if (Properties.Settings.Default.DeleteIconPath != string.Empty)
                File.Delete(Properties.Settings.Default.DeleteIconPath);
        }

        public void HomeCall()
        {
            GlobalFormNull();
            this.logout_button.BackColor = Color.White;
            this.logout_button.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            HomePage.Home obj = new AD_CMS.HomePage.Home();
            globalForm = obj;
            formshow(obj);
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            if (loginfm != null)
                loginfm.Show();
            this.Dispose();
        }

        private void admin_section_button_Click(object sender, EventArgs e)
        {
            GlobalFormNull();
            AdminSectionSubForms obj = new AdminSectionSubForms();
            globalForm = obj;
            formshow(obj);
            
        }

        private void attendance_Click(object sender, EventArgs e)
        {
            GlobalFormNull();
            AttendanceSubForms obj = new AttendanceSubForms();
            globalForm = obj;
            formshow(obj);
        }

        private void Library_Management_Click(object sender, EventArgs e)
        {
            GlobalFormNull();
            LibraryMgmtSubForms.LibrarySubForms obj = new AD_CMS.LibraryMgmtSubForms.LibrarySubForms();
            globalForm = obj;
            formshow(obj);
        }

    }
}
