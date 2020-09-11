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

namespace AD_CMS.StudentMgmtSubForms
{
    public partial class SearchStudent : TemplateForm
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        DataTable dt_student, dt_course;
        StudentAdmission studadd;
        DataView dv;

        private void update_button_Click(object sender, EventArgs e)
        {
            if (Student_Detail_dataGridView.Rows.Count > 0)
            {
                int selectedRow = Student_Detail_dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                int Grno = Convert.ToInt32(Student_Detail_dataGridView.Rows[selectedRow].Cells["Grno"].Value);

                DataTable dt = Student_Methods.loadStudentDetails_Form(Grno);

                studadd = new StudentAdmission(LoadUpdateForm(dt),this);
                if (update_button.Text.Equals("View Student Details", StringComparison.OrdinalIgnoreCase))
                {
                    studadd.isReadOnly = true;
                }
                studadd.isUpdate = true;
                studadd.TopLevel = false;
                studadd.Parent = ClassCall.mainFormObj.masterpanel;
                studadd.Dock = DockStyle.Fill;
                studadd.BringToFront();
                studadd.Focus();
                studadd.Show();

                this.Dispose();
            }
        }

        private StudentEntity LoadUpdateForm(DataTable dt)
        {
            StudentEntity se = new StudentEntity();
            string[] father = dt.Rows[0].Field<string>("S_Fathernm").Split(' ');
            string[] mother = dt.Rows[0].Field<string>("S_Mothernm").Split(' ');
            string[] student = dt.Rows[0].Field<string>("S_FullName").Split(' ');

            /****************************Parents Details ***********************************/
            se.father_FirstName = father[0];
            se.father_MiddleName = father[1];
            se.father_MiddleName = father[2];
            se.mother_FirstName = mother[0];
            se.mother_MiddleName = mother[1];
            se.mother_LastName = mother[2];
            se.ParentsOccupation = dt.Rows[0].Field<string>("S_ParentsOccupation");
            se.OfficeAddress = dt.Rows[0].Field<string>("S_ParentsOfficeAddress");
            se.ContactNo = dt.Rows[0].Field<long>("S_ParentsContactNo");

            /************************School Details*******************************/
            se.SchoolName = dt.Rows[0].Field<string>("School_nm");
            se.SchoolStream = dt.Rows[0].Field<string>("School_stream");
            se.LastYear = dt.Rows[0].Field<Int16>("School_last_year");
            se.LastYear_Percentage = dt.Rows[0].Field<byte>("School_last_year_percentage");

            /******************* School DocumentDetails**************************************/
            se.marksheet_12 = dt.Rows[0].Field<bool>("D_12_marksheet");
            se.lc_12 = dt.Rows[0].Field<bool>("D_12_lc");

            /***********************College Details********************************/
            se.checkCollege = dt.Rows[0].Field<bool>("checkCollege");
            if (se.checkCollege)
            {
                se.CollegeName = dt.Rows[0].Field<string>("Clg_nm");
                se.CollegeStream = dt.Rows[0].Field<string>("Clg_stream");
                se.LastSem = dt.Rows[0].Field<byte>("Clg_last_sem");
                se.CollegeYear = dt.Rows[0].Field<Int16>("Clg_year");
                se.LastSem_Percentage = dt.Rows[0].Field<byte>("Clg_last_sem_percentage");
                se.CollegeYear = dt.Rows[0].Field<Int16>("Clg_year");
                /********************College Document Details***************************/
                se.previous_marksheet = dt.Rows[0].Field<bool>("D_previous_marksheets");
                se.NOC = dt.Rows[0].Field<bool>("D_noc");
                se.TC = dt.Rows[0].Field<bool>("D_tc");
            }

            /****************Student Details**********************/
            se.grno = dt.Rows[0].Field<int>("Grno");
            se.candidate_FirstName = student[0];
            se.ProfilePhoto = dt.Rows[0].Field<string>("S_Profile");
            se.candidate_MiddleName = student[1];
            se.candidate_LastName = student[2];
            se.gender = dt.Rows[0].Field<string>("S_Gender");
            se.CurrentAddress = dt.Rows[0].Field<string>("S_CurrentAddress");
            se.PermanentAddress = dt.Rows[0].Field<string>("S_PermanenetAddress");
            se.AdmissionDate = dt.Rows[0].Field<DateTime>("S_AdmissionDate");
            se.Pincode = dt.Rows[0].Field<int?>("S_Pincode");
            se.CountryId = dt.Rows[0].Field<int>("S_CountryId");
            se.StateId = dt.Rows[0].Field<int>("S_StateId");
            se.CityId = dt.Rows[0].Field<int>("S_CityId");
            se.CastId = dt.Rows[0].Field<byte>("S_CastId");
            se.DOB = dt.Rows[0].Field<DateTime>("S_DOB");
            se.BirthPlace = dt.Rows[0].Field<string>("S_BirthPlace");
            se.MobileNo = dt.Rows[0].Field<long>("S_MobileNo");
            se.TelephoneNo = dt.Rows[0].Field<long?>("S_Telephone");
            se.Email = dt.Rows[0].Field<string>("S_Email");
            se.CourseId = dt.Rows[0].Field<Int16>("S_CourseId");
            se.AdmissionSem = dt.Rows[0].Field<byte>("S_AdmissionSem");
            se.Discount = dt.Rows[0].Field<byte>("S_Discount");
            se.Fees = dt.Rows[0].Field<int>("S_Fees");
            se.Remark = dt.Rows[0].Field<string>("S_Remark");

            return se;

        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            if (Student_Detail_dataGridView.Rows.Count > 0)
            {
                int selectedRow = Student_Detail_dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                int Grno = Convert.ToInt32(Student_Detail_dataGridView.Rows[selectedRow].Cells["Grno"].Value);
                string imagePath = Student_Detail_dataGridView.Rows[selectedRow].Cells["Profile"].Value.ToString();
                int affectedRows = Student_Methods.deleteStudent(Grno);
                
                if (affectedRows > 0)
                {
                    if (!(imagePath.Equals("System.Drawing.Bitmap", StringComparison.OrdinalIgnoreCase) || string.IsNullOrEmpty(imagePath)))
                    {
                        System.GC.Collect();
                        System.GC.WaitForPendingFinalizers();

                        if (System.IO.File.Exists(imagePath))
                        {
                            System.IO.File.Delete(imagePath);
                        }
                    }
                    AlertBox.ShowDialog("Successfully deleted", AlertBox.AlertType.success, true);
                    select_course_comboBox.SelectedIndex = 0;
                    student_detail_textBox.Clear();
                    loadDataGridView();
                }
            }
        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            loadDataGridView();

            this.select_course_comboBox.SelectedIndexChanged -= new System.EventHandler(this.select_course_comboBox_SelectedIndexChanged);
            dt_course = Course_Methods.Load_CourseDetails("subject");
            DataRow dr = dt_course.NewRow();
            dr["Alias"] = "All";
            dr["TotalSem"] = 0;
            dt_course.Rows.InsertAt(dr, 0);
            select_course_comboBox.DisplayMember = "Alias";
            select_course_comboBox.DataSource = dt_course;
            this.select_course_comboBox.SelectedIndexChanged += new System.EventHandler(this.select_course_comboBox_SelectedIndexChanged);
        }

        public void loadDataGridView()
        {
            dt_student = Student_Methods.loadStudent();
            Student_Detail_dataGridView.DataSource = null;
            Student_Detail_dataGridView.DataSource = dt_student;
            Student_Detail_dataGridView.Columns["Profile"].Visible = false;
        }

        private void select_course_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (select_course_comboBox.SelectedIndex != 0)
            {
                dv = dt_student.DefaultView;
                dv.RowFilter = string.Format("Course like '{0}'", select_course_comboBox.Text);
            }
            else
            {
                dt_student.DefaultView.RowFilter = "";
            }
        }

        private void student_detail_textBox_TextChanged(object sender, EventArgs e)
        {
            if (dt_student.Rows.Count > 0)
            {
                dv = dt_student.DefaultView;
                if (select_course_comboBox.SelectedIndex == 0)
                {
                    dv.RowFilter = @"Name like '%" + student_detail_textBox.Text + "%'" +
                                                        "OR City like '%" + student_detail_textBox.Text + "%'" +
                                                        "OR Convert([Grno],System.String) like '%" + student_detail_textBox.Text + "%'" +
                                                        "OR Convert([MobileNo],System.String) like '%" + student_detail_textBox.Text + "%'" +
                                                        "OR Convert([CurrentSemester],System.String) like '%" + student_detail_textBox.Text + "%'";
                }
                else
                {
                    dv.RowFilter = @"Name like '%" + student_detail_textBox.Text + "%'" +
                                                        "OR City like '%" + student_detail_textBox.Text + "%'" +
                                                        "OR Convert([Grno],System.String) like '%" + student_detail_textBox.Text + "%'" +
                                                        "OR Convert([MobileNo],System.String) like '%" + student_detail_textBox.Text + "%'" +
                                                        "OR Convert([CurrentSemester],System.String) like '%" + student_detail_textBox.Text + "%'"+
                                                        "AND Course = '" + select_course_comboBox.Text + "'";   
                }
            }
        }
    }
}
