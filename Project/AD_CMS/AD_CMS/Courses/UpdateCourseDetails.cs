using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomMessageBox;
using AD_CMS_DatabaseModel;
using AD_CMS_Entity;
using System.Data.SqlClient;
using System.IO;

namespace AD_CMS.Course
{
    public partial class UpdateCourseDetails : TemplateForm
    {
        public UpdateCourseDetails()
        {
            InitializeComponent();
        }

        #region variables
        DataTable dt_course, dt_subject;
        private bool isModified = false;
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            loadCourse();
        }

        private void course_textChanged(object sender, EventArgs e)
        {
            ClassCall.textChangeFun(sender as Control);
        }

        private void update_course_tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (update_course_tabControl.SelectedIndex == 0 && isModified)
                loadCourse();
            else if (update_course_tabControl.SelectedIndex == 1)
            {
                loadSubject();
                loadCourse_ComboBox();
            }
            else if (update_course_tabControl.SelectedIndex == 2)
            {
                set_fee_TextBox.BackColor = Color.White;
                LoadCourseFee_dataGridView();
                //loadCourseAdd_RemoveBtn_GridView();
            }
        }

        private void loadCourse_ComboBox()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("select C_Id,C_Alias from Courses", conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                select_course_combobox.DisplayMember = "C_Alias";
                select_course_combobox.ValueMember = "C_Id";
                select_course_combobox.DataSource = dt;
            }
            else
            {
                select_course_combobox.Items.Add("Select Course");
                select_course_combobox.SelectedIndex = 0;
            }
        }

        private void loadSubject()
        {
            dt_subject = new DataTable();
            using (SqlConnection conn= new SqlConnection(Connection.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("load_subjectDetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt_subject.Load(dr);
                }
            }
            subject_dataGridView.DataSource = dt_subject;

            subject_dataGridView.AutoGenerateColumns = false;
            if (!subject_dataGridView.Columns.Contains("remove"))
            {
                DataGridViewLinkColumn dc = new DataGridViewLinkColumn()
                {
                    Text = "Remove",
                    HeaderText = "Edit",
                    Name = "remove",
                    UseColumnTextForLinkValue = true,
                    LinkColor = Color.Crimson,
                    LinkBehavior = LinkBehavior.HoverUnderline
                };
                subject_dataGridView.Columns.Insert(subject_dataGridView.Columns.Count, dc);
            }
            
        }


        private void select_course_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt_subject.Rows.Count > 0)
            {
                dt_subject.DefaultView.RowFilter = "CourseAlias='" + select_course_combobox.Text + "'";
            }
        }

        #region course fee

        private void LoadCourseFee_dataGridView()
        {
            DataTable dt = Course_Methods.LoadDataGridView("course");
            fee_dataGridView.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                select_course_comboBox3.DataSource = dt;
                select_course_comboBox3.DisplayMember = "CourseAlias";
            }
            else
            {
                select_course_comboBox3.SelectedIndex = 0;
            }

            set_fee_TextBox.DataBindings.Clear();
            set_fee_TextBox.DataBindings.Add("TEXT", dt, "Fees");

            fee_dataGridView.DefaultCellStyle = new DataGridViewCellStyle()
            {
                Font = new Font("Times New Roman", 10, FontStyle.Regular),
            };
        }

        //validate and update details for course fee and save it into database
        private void update_button3_Click(object sender, EventArgs e)
        {
            if (course_fee_valid())
            {
                //write code to update course fee details in database
                CourseEntity ce = new CourseEntity()
                {
                    course_alias = select_course_comboBox3.Text,
                    fee_per_year = int.Parse(set_fee_TextBox.Text)
                };

                if (Course_Methods.update_fees(ce) > 0)
                {
                    AlertBox.ShowDialog("successfully updated course fee details", AlertBox.AlertType.success, true);
                    clear_button_Click(sender, e);
                    LoadCourseFee_dataGridView();
                }
            }
        }

        //validate course fee details
        private bool course_fee_valid()
        {
            bool flg = true;
            if (select_course_comboBox3.Text.Contains("Select"))
            {
                select_course_comboBox3.BackColor = Color.Pink;
                //flg = false;
            }
            if (set_fee_TextBox.Text == "" || (double.Parse(set_fee_TextBox.Text) == 0))
            {
                set_fee_TextBox.BackColor = Color.Pink;
                flg = false;
            }
            if (!flg)
            {
                AlertBox.ShowDialog("Please enter data in required field", AlertBox.AlertType.error, false);
            }
            return flg;
        }

        //clears course fee details without saving it
        private void clear_button_Click(object sender, EventArgs e)
        {
            select_course_comboBox3.SelectedIndex = 0;
            select_course_comboBox3.BackColor = Color.White;
            if (fee_dataGridView.Rows.Count == 0)
            {
                set_fee_TextBox.Text = "0";
                total_fee_textBox.Text = "0";
            }
            set_fee_TextBox.BackColor = Color.White;
        }

        private void coursefee_textChanged(object sender, EventArgs e)
        {
            if (set_fee_TextBox.BackColor == Color.Pink)
            {
                ClassCall.textChangeFun(sender as Control);
            }
            if (set_fee_TextBox.Text.Trim() != string.Empty)
            {
                DataTable dt = Course_Methods.feeCout(select_course_comboBox3.Text);

                instruction_label.Text = dt.Rows[0]["durationDesc"].ToString();
                instruction_label2.Text = dt.Rows[0]["feeDescription"].ToString();
                int year = Convert.ToInt32(dt.Rows[0]["yearCount"]);
                int fees = Convert.ToInt32(set_fee_TextBox.Text);

                total_fee_textBox.Text = (fees * year).ToString();
            }
            else
            {
                total_fee_textBox.Text = "0";
            }
        }

        #endregion

        #region Course Details
        private void loadCourse()
        {
            dt_course = Course_Methods.LoadDataGridView("course");
            Course_dataGridView.DataSource = dt_course;

            Course_dataGridView.AutoGenerateColumns = false;
            if (!Course_dataGridView.Columns.Contains("remove"))
            {
                DataGridViewLinkColumn dc = new DataGridViewLinkColumn()
                {
                    Text = "Remove",
                    HeaderText = "Edit",
                    Name = "remove",
                    UseColumnTextForLinkValue = true,
                    LinkColor = Color.Crimson,
                    LinkBehavior = LinkBehavior.HoverUnderline
                };
                Course_dataGridView.Columns.Insert(Course_dataGridView.Columns.Count, dc);
            }
        }

        private void Course_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv = sender as DataGridView;
                string alias = "";
                if (dgv.Rows.Count > 0)
                {
                    alias = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();


                    if (e.ColumnIndex == dgv.Columns.Count - 1)
                    {
                        DialogResult result1 = MessageBox.Show("Do u sure U want to delete this course?\n(If any subject is attached with this course, will be deleted also.)", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result1 == DialogResult.OK)
                        {
                            DialogResult result = MessageBox.Show("It will also remove your attendance if exists.\r\nDo u want to remove course?");
                            if (result == DialogResult.OK)
                            {
                                int affectedRows = Course_Methods.deleteCourses(alias);
                                if (affectedRows > 0)
                                {
                                    AlertBox.ShowDialog("Course Deleted Successfully", AlertBox.AlertType.success, true);
                                    Course_dataGridView.Columns.RemoveAt(Course_dataGridView.Columns.Count - 1);
                                    isModified = true;
                                    loadCourse();
                                    string path = Properties.Settings.Default.AttendancePath;

                                    System.GC.Collect();
                                    System.GC.WaitForPendingFinalizers();
                                    Directory.Delete(path + alias, true);
                                }
                                else
                                {
                                    AlertBox.ShowDialog("You can't delete this course,\r\nbcz Some of the students have this course.", AlertBox.AlertType.error, false);
                                }
                            }
                        }
                    }
                    else
                    {
                        isModified = false;
                    }
                }
            }
        }
        #endregion

        private void subject_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv.Rows.Count > 0)
                {
                    if (e.ColumnIndex == dgv.Columns.Count - 1)
                    {
                        int subject_code = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["SubjectCode"].Value);
                        DialogResult result = MessageBox.Show("Do u sure U want to delete this Subject from "+select_course_combobox.Text+"?", "QuestionMark", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            using (SqlConnection conn = new SqlConnection(Connection.getConnectionString()))
                            {
                                using (SqlCommand cmd = new SqlCommand("deleteSubject", conn))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@scode", subject_code);
                                    conn.Open();
                                    int affectedRows = cmd.ExecuteNonQuery();
                                    if (affectedRows > 0)
                                    {
                                        AlertBox.ShowDialog("Subject Deleted Successfully", AlertBox.AlertType.success, true);
                                        subject_dataGridView.Columns.RemoveAt(subject_dataGridView.Columns.Count - 1);
                                        string coursenm = select_course_combobox.Text;
                                        loadSubject();
                                        loadCourse();
                                        select_course_combobox.SelectedText = coursenm;
                                        dt_subject.DefaultView.RowFilter = "CourseAlias='" + coursenm + "'";

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
