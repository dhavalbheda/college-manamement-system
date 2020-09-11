using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using AD_CMS_DatabaseModel;
using System.Data.SqlClient;

namespace AD_CMS.CollegeDetails
{
    public partial class CollegeDetailsSubForm : TemplateForm
    {
        public CollegeDetailsSubForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.TemplateBack == Color.White)
                this.contentarea_panel.BackColor = Color.LightCyan;
        }

        string teachingText, nonTeachingText, courseText;

        private void FormCloseBtn_Click(object sender, EventArgs e)
        {
            string del = Properties.Settings.Default.DeleteIconPath;
            if (File.Exists(del) || !string.IsNullOrEmpty(del))
            {
                File.Delete(Properties.Settings.Default.DeleteIconPath);
                Properties.Settings.Default.DeleteIconPath = string.Empty;
                string ext = Path.GetExtension(Properties.Settings.Default.CollegeIcon);
                string newName = @"..\..\Resources\icon_img" + ext;
                string newFileDel = Properties.Settings.Default.CollegeIcon;
                File.Copy(newFileDel,newName ,true);
                Properties.Settings.Default.CollegeIcon = newName;
                Properties.Settings.Default.Save();
                File.Delete(newFileDel);
            }
            ClassCall.openHomePage();
        }   

        private void CollegeDetailsSubForm_Load(object sender, EventArgs e)
        {
            icon_pictureBox.Image = Image.FromFile(Properties.Settings.Default.CollegeIcon);
            name_label.Text = Properties.Settings.Default.CollegeName;

            loadStudentDetails();

            loadEmployeeDeatils();

            course_no_label.Text = CollegeDetails_Methods.TotalCourse().ToString();
            loadCourses();

            classes_no_label.Text = Properties.Settings.Default.TotalClasses.ToString();
            labs_no_label.Text = Properties.Settings.Default.TotalLabs.ToString();
        }

        private void loadEmployeeDeatils()
        {
            object[] obj = CollegeDetails_Methods.EmployeeCount();
            total_emp_label.Text = obj[0].ToString();
            total_teaching_label.Text = obj[1].ToString();
            total_non_teaching_label.Text = obj[2].ToString();
            teachingText = obj[3].ToString()+Environment.NewLine+"Male"+
                            Environment.NewLine+Environment.NewLine + 
                            obj[4].ToString() + Environment.NewLine + "Female";

            nonTeachingText = obj[5].ToString() + Environment.NewLine +"Male" +
                            Environment.NewLine+Environment.NewLine + 
                            obj[6].ToString() + Environment.NewLine + "Female";
        }

        private void loadStudentDetails()
        {
            object[] students = CollegeDetails_Methods.StudentCount();
            total_student_label.Text = students[0].ToString();
            boy_label.Text = students[1].ToString();
            girl_label.Text = students[2].ToString();
        }

        private void loadCourses()
        {
            richTextBox1.Clear();
            List<string> str = CollegeDetails_Methods.CourseList();
            foreach (string s in str)
            {
                courseText +=  s  + "    ";
            }
        }

        private void Course_MouseEntered(object sender, EventArgs e)
        {
            richTextBox1.Show();
        }

        private void Hiding_RichTextBox(object sender, EventArgs e)
        {            
            Control ctrl = sender as Control;
            if (ctrl.Name == "total_teaching_label" || ctrl.Name == "label7")
            {
                tableLayoutPanel1.SetColumnSpan(richTextBox1, 1);
                richTextBox1.BackColor = Color.DarkOrange;
                richTextBox1.Text = teachingText;
                richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
                richTextBox1.Show();
            }
            else if (ctrl.Name == "total_non_teaching_label" || ctrl.Name == "label1")
            {
                tableLayoutPanel1.SetColumnSpan(richTextBox1, 1);
                richTextBox1.BackColor = Color.DarkOrange;
                richTextBox1.Text = nonTeachingText;
                richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
                richTextBox1.Show();
            }
            else if (ctrl.Name == "course_no_label")
            {
                tableLayoutPanel1.SetColumnSpan(richTextBox1, 2);
                richTextBox1.BackColor = Color.Brown;
                richTextBox1.Text = courseText;
                richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
                richTextBox1.Show();
            }
        }

        private void edit_save_label_Click(object sender, EventArgs e)
        {
            if (edit_save_label.Text.Equals("edit", StringComparison.OrdinalIgnoreCase))
            {
                edit_panel.Show();
                save_panel.Hide();
                edit_save_label.Text = "Save";
                classes_TextBox.Text = classes_no_label.Text;
                Labs_TextBox.Text = labs_no_label.Text;
            }
            else if (edit_save_label.Text.Equals("save", StringComparison.OrdinalIgnoreCase))
            {
                Properties.Settings.Default.TotalClasses = int.Parse(classes_TextBox.Text);
                Properties.Settings.Default.TotalLabs = int.Parse(Labs_TextBox.Text);
                Properties.Settings.Default.Save();
                edit_save_label.Text = "Edit";

                classes_no_label.Text = Properties.Settings.Default.TotalClasses.ToString();
                labs_no_label.Text = Properties.Settings.Default.TotalLabs.ToString();

                edit_panel.Hide();
                save_panel.Show();
            }
        }

        private void classes_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (classes_TextBox.Text == string.Empty)
                classes_TextBox.Text = "0";
        }

        private void Labs_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Labs_TextBox.Text == string.Empty)
                Labs_TextBox.Text = "0";
        }
    }
}
