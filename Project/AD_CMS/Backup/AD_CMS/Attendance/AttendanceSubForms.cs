using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AD_CMS.Attendance
{
    public partial class AttendanceSubForms : TemplateForm
    {
        public AttendanceSubForms()
        {
            InitializeComponent();
        }

        private void upload_attendance_label_Click(object sender, EventArgs e)
        {
            UploadAttendance obj = new UploadAttendance();
            FormCall(obj);
            
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

        private void view_pictureBox_Click(object sender, EventArgs e)
        {
            ViewAttendance obj = new ViewAttendance();
            FormCall(obj);
            if (obj.isclose)
                obj.Dispose();
        }

        private void rules_pictureBox_Click(object sender, EventArgs e)
        {
            Instructions obj = new Instructions();
            FormCall(obj);
        }

        private void generate_pictureBox_Click(object sender, EventArgs e)
        {
            GenerateAttendanceSheet obj = new GenerateAttendanceSheet();
            FormCall(obj);
        }

        private void FormCloseBtn_Click(object sender, EventArgs e)
        {
            ClassCall.openHomePage();
        }
    }
}
