using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AD_CMS.CollegeDetails;
using System.IO;

namespace AD_CMS.AdminSection
{
    public partial class AdminSectionSubForms : TemplateForm
    {
        public AdminSectionSubForms()
        {
            InitializeComponent();
        }

        HomePageDesign obj_home;

        private void add_new_course_label_Click(object sender, EventArgs e)
        {
            obj_home = new HomePageDesign();
            obj_home.TopLevel = false;
            obj_home.Parent = ClassCall.mainFormObj.masterpanel;
            obj_home.Show();
            obj_home.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoftwareVisualStyleChange obj = new SoftwareVisualStyleChange();
            obj.TopLevel = false;
            obj.Parent = ClassCall.mainFormObj.masterpanel;
            obj.Show();
            obj.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SetUser obj = new SetUser();
            obj.TopLevel = false;
            obj.Parent = ClassCall.mainFormObj.masterpanel;
            obj.Show();
            obj.BringToFront();
        }

        private void FormCloseBtn_Click(object sender, EventArgs e)
        {
            ClassCall.openHomePage();
        }
    }
}
