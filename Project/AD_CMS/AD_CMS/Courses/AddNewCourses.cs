using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomMessageBox;
using AD_CMS_Entity;
using AD_CMS_DatabaseModel;
using System.Data.SqlClient;
using System.IO;

namespace AD_CMS.Course
{
    public partial class AddNewCourses : TemplateForm
    {
        public AddNewCourses()
        {
            InitializeComponent();
        }


        private void AddNewCourses_Load(object sender, EventArgs e)
        {
            if (add_new_course_tabControl.SelectedIndex == 0)
            {
                LoadCourseDetails_dataGridView();
            }
        }

        private void LoadCourseDetails_dataGridView()
        {
            CourseDetails_dataGridView.DataSource = Course_Methods.LoadDataGridView("course");
            CourseDetails_dataGridView.DefaultCellStyle = new DataGridViewCellStyle()
            {
                Font = new Font("Times New Roman", 10, FontStyle.Regular),
            };
        }

        private void LoadCourseFee_dataGridView()
        {
            courseFee_dataGridView.DataSource = Course_Methods.LoadDataGridView("course");
            courseFee_dataGridView.DefaultCellStyle = new DataGridViewCellStyle()
            {
                Font = new Font("Times New Roman", 10, FontStyle.Regular),
            };
        }

        #region Course Details

        //checkbox CheckedChanged event
        private void As_per_name_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (As_per_name_checkBox.Checked)
            {
                course_nm_alias_textBox.Text = course_nm_textBox.Text;
                course_nm_alias_textBox.ReadOnly = true;
            }
            else
            {
                course_nm_alias_textBox.Clear();
                course_nm_alias_textBox.ReadOnly = false;
            }
        }

        //course name leave event
        private void course_nm_textBox_Leave(object sender, EventArgs e)
        {
            if (As_per_name_checkBox.Checked)
            {
                course_nm_alias_textBox.Text = course_nm_textBox.Text;
                course_nm_alias_textBox.ReadOnly = true;
            }
        }

        //validate details & go to next tab & add details into database
        private void next_button_Click(object sender, EventArgs e)
        {
            if(course_details_validation())
            {
                if (InsertDataInCourse())
                {
                    Clear_course_details();
                    add_new_course_tabControl.SelectedIndex = 1;
                    CreateCourseFolder();
                }
            }
        }

        //validate details & clear it if details r correct & add it into database
        private void add_button_Click(object sender, EventArgs e)
        {
            if (course_details_validation())
            {
                if (InsertDataInCourse())
                {
                    LoadCourseDetails_dataGridView();           
                    Clear_course_details();
                    CreateCourseFolder();
                }
            }
        }

        private void CreateCourseFolder()
        {
            string CourseName = Course_Methods.getCourseAlias();
            string path = Properties.Settings.Default.AttendancePath;
            if (!Directory.Exists(path + CourseName))
            {
                Directory.CreateDirectory(path + CourseName);
            }
        }

        private bool InsertDataInCourse()
        {
            string msg = Course_Methods.insert_course(setProperties());
            return displayMessage(msg);
        }

        private CourseEntity setProperties()
        {
            CourseEntity ce = new CourseEntity();
            ce.course_nm = course_nm_textBox.Text.Trim();
            ce.course_alias = course_nm_alias_textBox.Text.Trim();
            ce.total_sem = (int)total_sem_numericUpDown.Value;

            return ce;
        }

        //clears the details of course tab
        private void Clear_course_details()
        {
            course_nm_textBox.Text = "";
            course_nm_alias_textBox.Clear();
            As_per_name_checkBox.Checked = false;
            total_sem_numericUpDown.Value = total_sem_numericUpDown.Minimum;
            changeBackColor(course_nm_textBox, course_nm_alias_textBox, total_sem_numericUpDown);
        }

        //validates course details
        private bool course_details_validation()
        {
            bool flg = true;

            if (course_nm_textBox.Text == "")
            {
                course_nm_textBox.BackColor = Color.Pink;
                flg = false;
            }
            if (course_nm_alias_textBox.Text == "")
            {
                course_nm_alias_textBox.BackColor = Color.Pink;
                flg = false;
            }
            if (!flg)
            {
                AlertBox.ShowDialog("Enter data in required field", AlertBox.AlertType.error, false);
            }
            return flg;
        }

        private void course_controls_textChanged(object sender, EventArgs e)
        {
            ClassCall.textChangeFun(sender as Control);
        }
        #endregion

        #region Subject Details

        //validate details & go to next tab & add details into database
        private void next_button2_Click(object sender, EventArgs e)
        {
            if (subject_detils_validation())
            {
                CourseEntity ce = new CourseEntity()
                {
                    course_alias = course_nm_comboBox.Text,
                    subject_nm = subject_nm_textBox.Text.Trim(),
                    subject_code = int.Parse(subject_code_textBox.Text.Trim()),
                    subject_sem = int.Parse(select_sem_numericUpDown.Value.ToString()),
                };
                string msg = Course_Methods.insert_subject(ce);
                if (displayMessage(msg))
                {
                    clear_subject_details();
                    add_new_course_tabControl.SelectedIndex = 2;
                }
            }
        }

        //validate details & clear it & add it into database
        private void add_button2_Click(object sender, EventArgs e)
        {
            if (subject_detils_validation())
            {
                CourseEntity ce = new CourseEntity()
                {
                    course_alias = course_nm_comboBox.Text,
                    subject_nm = subject_nm_textBox.Text.Trim(),
                    subject_code = int.Parse(subject_code_textBox.Text.Trim()),
                    subject_sem = int.Parse(select_sem_numericUpDown.Value.ToString()),
                };
                string msg = Course_Methods.insert_subject(ce);
                if (displayMessage(msg))
                {
                    clear_subject_details();
                    refresh_SubjectDataGridView();
                }
            }
        }

        private void clear_subject_details()
        {
            subject_code_textBox.Text = "";
            subject_nm_textBox.Text = "";
            select_sem_numericUpDown.Value = select_sem_numericUpDown.Minimum;
            changeBackColor(subject_code_textBox, subject_nm_textBox, select_sem_numericUpDown);
            
        }

        //validate Subject details
        private bool subject_detils_validation()
        {
            bool flg = true;
            if (course_nm_comboBox.SelectedIndex == 0 && course_nm_comboBox.SelectedText.Contains("select"))
            {
                course_nm_comboBox.BackColor = Color.Pink;
                flg = false;
            }
            else if (subject_nm_textBox.Text == "")
            {
                subject_nm_textBox.BackColor = Color.Pink;
                flg = false;
            }
            else if (!select_sem_numericUpDown.Enabled)
            {
                select_sem_numericUpDown.BackColor = Color.Pink;
                flg = false;
            }
            else if (subject_code_textBox.Text == "")
            {
                subject_code_textBox.BackColor = Color.Pink;
                flg = false;
            }
            if (!flg)
            {
                AlertBox.ShowDialog("please select/Enter data in Required Field.", AlertBox.AlertType.error,false);
            }
            return flg;
        }

        private void subject_controls_textChanged(object sender, EventArgs e)
        {
            ClassCall.textChangeFun(sender as Control);
        }
        #endregion

        #region Course Fee Details
        
        //validate fee details & clear details & add it into database
        private void save_button_Click(object sender, EventArgs e)
        {
            if (course_fee_valid())
            {
                CourseEntity ce = new CourseEntity()
                {
                    course_alias = select_course_comboBox.Text,
                    fee_per_year = int.Parse(set_fee_textBox.Text)
                };

                if (Course_Methods.update_fees(ce) > 0)
                {
                    AlertBox.ShowDialog("Fees r set for selected Course", AlertBox.AlertType.success, true);
                    clear_button_Click(sender, e);
                    loadingCourseDetails();
                    LoadCourseFee_dataGridView();
                }
            }
        }

        private bool course_fee_valid()
        {
            bool flg = true;
            string msg = "";
            if (select_course_comboBox.SelectedIndex == 0 && select_course_comboBox.Text.Contains("Select")) 
            {
                select_course_comboBox.BackColor = Color.Pink;
                msg = "Course are not available/Course are not available which fees r not set.";
                flg = false;
            }
            if (set_fee_textBox.Text == "" || (int.Parse(set_fee_textBox.Text) == 0))
            {
                set_fee_textBox.BackColor = Color.Pink;
                msg = "enter data in required field";
                flg = false;
            }
            if (!flg)
            {
                AlertBox.ShowDialog(msg, AlertBox.AlertType.error, false);
            }
            return flg;
        }

        //clear details without saving it
        private void clear_button_Click(object sender, EventArgs e)
        {
            select_course_comboBox.SelectedIndex = 0;
            set_fee_textBox.Text = "0";
            total_fee_textBox.Text = "0";
            changeBackColor(select_course_comboBox, set_fee_textBox);
        }

        private void coursefee_control_textChanged(object sender, EventArgs e)
        {
            if (set_fee_textBox.BackColor == Color.Pink)
            {
                ClassCall.textChangeFun(sender as Control);
            }
            if (set_fee_textBox.Text.Trim() != string.Empty)
            {
                total_fee_textBox.Text = (int.Parse(set_fee_textBox.Text) * multiply).ToString();
            }
            else
            {
                total_fee_textBox.Text = "0";
            }
        }
        #endregion

        private bool displayMessage(string msg)
        {
            if (msg.Contains('0'))
            {
                msg = msg.Remove(msg.Length - 1);
                AlertBox.ShowDialog(msg, AlertBox.AlertType.success, true);
                return true;
            }
            else
            {
                msg = msg.Remove(msg.Length - 1);
                AlertBox.ShowDialog(msg, AlertBox.AlertType.error, false);
                return false;
            }
        }

        DataTable dt_loadDetails,dt_loadDGV;
        private void add_new_course_tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (add_new_course_tabControl.SelectedIndex == 0)
            {
                changeBackColor(course_nm_textBox, course_nm_alias_textBox, total_sem_numericUpDown);
                CourseDetails_dataGridView.DataSource = Course_Methods.LoadDataGridView("course");
            }
            else if (add_new_course_tabControl.SelectedIndex == 1)
            {
                changeBackColor(subject_code_textBox, subject_nm_textBox, select_sem_numericUpDown);
                //fuction to load data in datagridview
                refresh_SubjectDataGridView();
                
                subjectDetails_dataGridView.DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Font = new Font("Times New Roman", 10, FontStyle.Regular),
                };

                #region Code to load Course name & it's according semester in "Subject detail tabpage"

                this.course_nm_comboBox.TextChanged -= new EventHandler(this.subject_controls_textChanged);
                dt_loadDetails = Course_Methods.Load_CourseDetails("subject");

                if (dt_loadDetails.Rows.Count > 0)
                {
                    select_sem_numericUpDown.Enabled = true;
                    course_nm_comboBox.DisplayMember = "Alias";
                    course_nm_comboBox.ValueMember = "TotalSem";
                    course_nm_comboBox.DataSource = dt_loadDetails;
                }
                else
                {
                    select_sem_numericUpDown.Enabled = false;
                    course_nm_comboBox.Items.Add("Select Course");
                    course_nm_comboBox.SelectedIndex = 0;
                }
                this.course_nm_comboBox.TextChanged += new EventHandler(this.subject_controls_textChanged);
                #endregion
            }
            else if (add_new_course_tabControl.SelectedIndex == 2)
            {
                changeBackColor(select_course_comboBox, set_fee_textBox);
                #region code to load Course Alias in "Course fee tabpage"

                this.select_course_comboBox.TextChanged -= new EventHandler(this.subject_controls_textChanged);
                loadingCourseDetails();

                LoadCourseFee_dataGridView();
                this.select_course_comboBox.TextChanged += new EventHandler(this.subject_controls_textChanged);

                #endregion
            }
        }

        private void loadingCourseDetails()
        {
            dt_loadDetails = Course_Methods.Load_CourseDetails("fee");
            if (dt_loadDetails.Rows.Count > 0)
            {
                select_course_comboBox.DisplayMember = "Alias";
                select_course_comboBox.ValueMember = "duration_desc";
                select_course_comboBox.DataSource = dt_loadDetails;
            }
            else
            {
                select_course_comboBox.DataSource = null;
                select_course_comboBox.Items.Add("Select Course");
                select_course_comboBox.SelectedIndex = 0;
            }
        }

        private void course_nm_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt_loadDetails.Rows.Count > 0)
            {
                select_sem_numericUpDown.Value = select_sem_numericUpDown.Minimum;
                select_sem_numericUpDown.Maximum = decimal.Parse(course_nm_comboBox.SelectedValue.ToString());

                refresh_SubjectDataGridView();
            }
        }

        private void refresh_SubjectDataGridView()
        {
            dt_loadDGV = Course_Methods.LoadDataGridView("subject");
            subjectDetails_dataGridView.DataSource = dt_loadDGV;
            dt_loadDGV.DefaultView.RowFilter = "CourseAlias = '" + course_nm_comboBox.Text + "'";
        }

        private void changeBackColor(params Control[] ctrl)
        {
            foreach (Control cc in ctrl)
            {
                cc.BackColor = Color.White;
            }
        }

        int multiply;
        private void select_course_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = Course_Methods.feeCout(select_course_comboBox.Text.ToString());
            instruction_label2.Text = dt.Rows[0]["feeDescription"].ToString();

            instruction_label.Text = dt.Rows[0]["durationDesc"].ToString();
            multiply = int.Parse(dt.Rows[0]["yearCount"].ToString());
            set_fee_textBox.Text = "0";
            total_fee_textBox.Text = "0";
        }

        private void course_nm_alias_textBox_Leave(object sender, EventArgs e)
        {
            if (course_nm_alias_textBox.Text == course_nm_textBox.Text)
            {
                As_per_name_checkBox.Checked = true;
            }
        }


    }
}
