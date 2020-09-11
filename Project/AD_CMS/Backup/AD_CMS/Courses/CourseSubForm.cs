using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AD_CMS.Course;

namespace AD_CMS.Courses
{
    public partial class CourseSubForm : TemplateForm
    {
        public CourseSubForm()
        {
            InitializeComponent();
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            AddNewCourses addcourse = new AddNewCourses();
            FormCall(addcourse);
        }

        private void UpdateCourse_Click(object sender, EventArgs e)
        {
            UpdateCourseDetails updatecourse = new UpdateCourseDetails();
            FormCall(updatecourse);
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
