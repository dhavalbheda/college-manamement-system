using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CustomMessageBox;
using AD_CMS_DatabaseModel;
using AD_CMS_Entity;

namespace AD_CMS.StudentMgmtSubForms
{
    public partial class StudentAdmission : TemplateForm
    {
        #region variables
        List<Control> lstctrl_tab1 = new List<Control>(); // contains only required controls
        List<Control> lstclear_tab1 = new List<Control>(); // contains every control except label , groupbox , panel, button
        bool isPersonalDet_Validated = false,isStore=false;
        public bool isUpdate = false , isReadOnly = false;
        DataTable dt_course;
        StudentEntity se;
        string ImagePath;
        SearchStudent searchstudentobj;
        OpenFileDialog openphoto;

        #endregion

        public StudentAdmission()
        {
            InitializeComponent();   
            AddElementsToList(personal_details_tabPage);
            
            /*string str="";
            foreach (Control cc in lstctrl_tab1)
            {
                str += cc.Name+Environment.NewLine;
            }
            MessageBox.Show(str);*/
        }
        public StudentAdmission(StudentEntity se,SearchStudent obj1)
        {
            InitializeComponent();
            this.se = se;
             searchstudentobj = obj1;
        }

        #region Personal Details
        //this fucnction adds only required elements in the list - lstctrl
        //this function also adds every controls of the personal info tab page into the list - lstclear
        private void AddElementsToList(Control cc)
        {
            foreach (Control ctrl in cc.Controls)
            {
                if (!(ctrl is Button || ctrl is Label || ctrl is PictureBox))
                {
                    if (ctrl.Name.Contains("_groupBox"))
                        AddElementsToList(ctrl);
                    else
                    {
                        if (!(ctrl is CheckBox))
                        {
                            if (ctrl.Name != "admission_dateTimePicker")
                            {
                                lstctrl_tab1.Add(ctrl);
                            }
                        }
                        lstclear_tab1.Add(ctrl);
                    }
                }
            }
        }

        #region button animation functions - save & clear
        //button hover animation function
        private void save_nexttab_button_MouseEnter(object sender, EventArgs e)
        {
            save_nexttab_button.FlatAppearance.BorderColor = Color.White;
            save_nexttab_button.ForeColor = Color.White;
            save_nexttab_button.Font = new Font(save_nexttab_button.Font,FontStyle.Bold);
        }

        //button leave animation function
        private void save_nexttab_button_MouseLeave(object sender, EventArgs e)
        {
            save_nexttab_button.FlatAppearance.BorderColor = Color.Black;
            save_nexttab_button.ForeColor = Color.Black;
            save_nexttab_button.Font = new Font(save_nexttab_button.Font, FontStyle.Regular);
        }

        //button hover animation function
        private void clear_button_MouseEnter(object sender, EventArgs e)
        {
            clear_button.FlatAppearance.BorderColor = Color.White;
            clear_button.ForeColor = Color.White;
            clear_button.Font = new Font(save_nexttab_button.Font, FontStyle.Bold);
        }

        //button leave animation function
        private void clear_button_MouseLeave(object sender, EventArgs e)
        {
            clear_button.FlatAppearance.BorderColor = Color.Black;
            clear_button.ForeColor = Color.Black;
            clear_button.Font = new Font(save_nexttab_button.Font, FontStyle.Regular);
        }
        #endregion

        #region coding for as above checkbox

        //as abouve checkbox checked changed
        private void asabove_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (asabove_checkBox.Checked)
            {
                permanentaddress_textbox.Text = currentaddress_textbox.Text;
                permanentaddress_textbox.ReadOnly = true;
            }
            else
            {
                permanentaddress_textbox.ReadOnly = false;
                permanentaddress_textbox.Clear();
            }
        }

        //if as above is not checked and both the address contains the same data then it will autometic checked with this function        
        private void permanentaddress_textbox_Leave(object sender, EventArgs e)
        {
            if (currentaddress_textbox.Text.Trim() == permanentaddress_textbox.Text.Trim())
            {
                if (!asabove_checkBox.Checked)
                {
                    asabove_checkBox.Checked = true;
                }
            }
            else
                asabove_checkBox.Checked = false;
        }

        //if checkbox checked and then the text of current address changed then permenant address will autometically change with this function
        private void currentaddress_textbox_Leave(object sender, EventArgs e)
        {
            if (asabove_checkBox.Checked)
                permanentaddress_textbox.Text = currentaddress_textbox.Text;
        }
        #endregion

        //save button click event
        private void save_nexttab_button_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                AlertBox.ShowDialog("Details r correct.",AlertBox.AlertType.success,true);
                isPersonalDet_Validated = true;
                studentadmission_tabControl.SelectedIndex = 1;
            }
        }

        //perform validation for save button
        private bool valid()
        {
            bool flg = true;
            foreach (Control ctrl in lstctrl_tab1)
            {
                if (ctrl is TextBox && ctrl.Text.Trim() == "" && ctrl.Name != "email_textbox" && ctrl.Name != "pincode_TextBox" && ctrl.Name != "telephone_textbox" && (ctrl.Name != "candidate_mno_textbox" || ctrl.Name != "parents_contact_TextBox"))
                {
                    if (flg)
                        AlertBox.ShowDialog("Please enter data in required field", AlertBox.AlertType.error, false);
                    flg = false;
                    ctrl.BackColor = Color.Pink;

                }
                else if (ctrl is ComboBox && ((ComboBox)ctrl).Items.Contains("select"))
                {
                    if (flg)
                        AlertBox.ShowDialog("Please enter data in required field", AlertBox.AlertType.error, false);
                    flg = false;
                    ctrl.BackColor = Color.Pink;
                }
                else if (ctrl is DateTimePicker && ctrl.Name == "dob_dateTimePicker" && (((DateTimePicker)ctrl).Value == DateTime.Today || ((DateTimePicker)ctrl).Value.Year >= DateTime.Today.Year - 12))
                {
                    if (flg)
                        AlertBox.ShowDialog("Please enter valid date in Birth date", AlertBox.AlertType.error, false);
                    flg = false;
                    ctrl.BackColor = Color.Pink;
                }
                else if(ctrl.Name == "candidate_mno_textbox")
                {
                    if(candidate_mno_textbox.Text.Trim() == "")
                    {
                        if(flg)
                            AlertBox.ShowDialog("Please enter valid data in required field", AlertBox.AlertType.error, false);
                        flg = false;
                        ctrl.BackColor = Color.Pink;
                    }
                    else if (candidate_mno_textbox.Text.Length != 10)
                    {
                        if(flg)
                            AlertBox.ShowDialog("Please enter valid mobile number", AlertBox.AlertType.error, false);
                        flg = false;
                        ctrl.BackColor = Color.Pink;
                    }
                }
                else if(ctrl.Name == "parents_contact_TextBox")
                {
                    if(parents_contact_TextBox.Text.Trim() == "")
                    {
                        if(flg)
                            AlertBox.ShowDialog("Please enter valid data in required field", AlertBox.AlertType.error, false);
                        flg = false;
                        ctrl.BackColor = Color.Pink;
                    }
                    else if(parents_contact_TextBox.Text.Length != 10)
                    {
                        if(flg)
                            AlertBox.ShowDialog("Plese enter valid mobile number",AlertBox.AlertType.error,false);
                        flg = false;
                        ctrl.BackColor = Color.Pink;
                    }
                }
                else if (ctrl.Name == "email_textbox" && ctrl.Text.Trim() != "")
                {
                    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                    Match match = regex.Match(ctrl.Text);
                    if (!match.Success || ctrl.Text == "")
                    {
                        flg = false;
                        AlertBox.ShowDialog("Please enter valid Email", AlertBox.AlertType.error, false);
                        ctrl.BackColor = Color.Pink;
                    }
                }
                else if (ctrl.Name == "pincode_TextBox" && ctrl.Text != "")
                {
                    if (ctrl.Text.Length != 6)
                    {
                        if (flg)
                            AlertBox.ShowDialog("Pin Code Must B 6 Digit Only.", AlertBox.AlertType.error, false);
                        flg = false;
                        ctrl.BackColor = Color.Pink;
                    }
                }
                else if (ctrl.Name == "telephone_textbox" && ctrl.Text != "")
                {
                    if (ctrl.Text.Length != 10)
                    {
                        if (flg)
                            AlertBox.ShowDialog("Telephone No Must B 10 Digit.", AlertBox.AlertType.error, false);
                        flg = false;
                        ctrl.BackColor = Color.Pink;
                    }
                }

            }
            return flg;

        }

        //clears the all control's data when clear button clicked
        private void clear_button_Click(object sender, EventArgs e)
        {
            foreach (Control clr in lstclear_tab1)
            {
                if (clr is TextBox && clr.Name != "grno_textBox")
                {
                    ((TextBox)clr).Clear();
                }
                else if (clr is CheckBox)
                {
                    ((CheckBox)clr).Checked = false;
                }
                else if (clr is ComboBox)
                {
                    ((ComboBox)clr).SelectedIndex = 0;
                }
                else if (clr is DateTimePicker)
                {
                    if (clr.Name == "admission_dateTimePicker")
                    {
                        ((DateTimePicker)clr).Value = DateTime.Now;
                    }
                    else
                    {
                        ((DateTimePicker)clr).Value = dob_dateTimePicker.MinDate;
                    }
                }
                if(clr.Name != "grno_textBox")
                    clr.BackColor = Color.White;
            }
            student_pictureBox.Image = student_pictureBox.InitialImage;
            
        }

        //add new city in database if its not in the list
        private void add_CitycomboBox_data_Leave(object sender, EventArgs e)
        {
            int flag = 0;
            for (int i = 0; i< country_comboBox.Items.Count; i++)
            {
                if (country_comboBox.Items.Contains(country_comboBox.Text))
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                if(country_comboBox.Text != "")
                    country_comboBox.Items.Add(country_comboBox.Text);
            }
        }

        //add new state in database if its not in the list
        private void add_StatecomboBox_data_Leave(object sender, EventArgs e)
        {
            int flag = 0;
            for (int i = 0; i < state_comboBox.Items.Count; i++)
            {
                if (state_comboBox.Items.Contains(state_comboBox.Text))
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                if(state_comboBox.Text != "")
                state_comboBox.Items.Add(state_comboBox.Text);
            }
        }

        //add new nationality in database if its not in the list
        private void add_NationalitycomboBox_data_Leave(object sender, EventArgs e)
        {
            int flag = 0;
            for (int i = 0; i < city_comboBox.Items.Count; i++)
            {
                if (city_comboBox.Items.Contains(city_comboBox.Text))
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                if (city_comboBox.Text != "")
                city_comboBox.Items.Add(city_comboBox.Text);
            }
        }

        //if error occurs then all controls will be red so if its text changed then it'll be white
        private void textChange(object sender, EventArgs e)
        {
            Control ctr = sender as Control;
            ClassCall.textChangeFun(ctr);

            if (ctr.Name == "candidatelnm_TextBox" || ctr.Name == "fatherlnm_TextBox" || ctr.Name == "motherlnm_TextBox")
            {
                candidatelnm_TextBox.Text = fatherlnm_TextBox.Text = motherlnm_TextBox.Text = ctr.Text;
            }
            else if (ctr.Name == "candidatemnm_TextBox" || ctr.Name == "fatherfnm_TextBox" || ctr.Name == "mothermnm_TextBox")
            {
                candidatemnm_TextBox.Text = fatherfnm_TextBox.Text = mothermnm_TextBox.Text = ctr.Text;
            }
        }

        private void student_picture_Click(object sender, EventArgs e)
        {
            openphoto = new OpenFileDialog();
            openphoto.Title = "Upload Photo";
            openphoto.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;.*bmp";
            if (openphoto.ShowDialog() == DialogResult.OK)
            {
                student_pictureBox.Image = Image.FromFile(openphoto.FileName);
                ImagePath = @"..\..\StudentProfilePhotos\" + grno_textBox.Text + Path.GetExtension(openphoto.FileName);
                isStore = true;
            }
        }

        private void student_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            picturebox_tip_label.Show();
        }
        private void student_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            picturebox_tip_label.Hide();
        }
        #endregion

        #region Educational Details
        //school clg radio button check un check coding
        private void school_clg_CheckedChanged(object sender, EventArgs e)
        {
            if(college_checkBox.Checked)
            {
                college_panel.Enabled = true;
                college_doc_panel.Enabled = true;
                school_checkBox.Checked = true;
            }
            if (!college_checkBox.Checked)
            {
                college_panel.Enabled = false;
                college_doc_panel.Enabled = false;
            }            
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (!isPersonalDet_Validated)
            {
                AlertBox.ShowDialog("Please fill up Personal Detail", AlertBox.AlertType.error, false);
                studentadmission_tabControl.SelectedIndex = 0;
            }

            else if (educational_details_validation()/* && isPersonalDet_Validated*/)
            {
                #region entity
                StudentEntity se = new StudentEntity();
                se.grno = int.Parse(grno_textBox.Text);
                se.AdmissionDate = admission_dateTimePicker.Value;
                se.ProfilePhoto = ImagePath;
                se.candidate_FirstName = candidatefnm_TextBox.Text;
                se.candidate_MiddleName = candidatemnm_TextBox.Text;
                se.candidate_LastName = candidatelnm_TextBox.Text;
                se.gender = (male_radioButton.Checked) ? male_radioButton.Text : female_radioButton.Text;
                se.CastId = int.Parse(cast_comboBox.SelectedValue.ToString());
                se.CountryId = int.Parse(country_comboBox.SelectedValue.ToString());
                se.StateId = int.Parse(state_comboBox.SelectedValue.ToString());
                se.CityId = int.Parse(city_comboBox.SelectedValue.ToString());
                se.CurrentAddress = currentaddress_textbox.Text;
                se.PermanentAddress = permanentaddress_textbox.Text;
                se.Pincode = (pincode_TextBox.Text == string.Empty) ? (int?)null : int.Parse(pincode_TextBox.Text);
                se.BirthPlace = birthplace_TextBox.Text;
                se.DOB = dob_dateTimePicker.Value;
                se.MobileNo = Int64.Parse(candidate_mno_textbox.Text);
                se.TelephoneNo = (telephone_textbox.Text == string.Empty) ? (Int64?)null : Int64.Parse(telephone_textbox.Text);
                se.Email = email_textbox.Text;
                se.CourseId = int.Parse(admission_stream_combobox.SelectedValue.ToString());
                se.Coursenm = admission_stream_combobox.Text;
                se.AdmissionSem = int.Parse(admission_sem_numericUpDown.Value.ToString());
                se.CurrentSem = int.Parse(admission_sem_numericUpDown.Value.ToString());
                se.Discount = int.Parse(discount_numericUpDown.Value.ToString());
                se.Fees = int.Parse(fees_to_pay_textbox.Text);
                se.Remark = remark_textBox.Text;
                se.CurrentStatus = 'C';
                if (Convert.ToInt32(admission_sem_numericUpDown.Maximum) > 1)
                {
                    se.LeavingYear = admission_dateTimePicker.Value.Year + Convert.ToInt32(admission_sem_numericUpDown.Maximum / 2);
                }
                else
                {
                    int Mymonth = 0;
                    if ((admission_dateTimePicker.Value.Month + 6) > 12)
                    {
                        int InCurrentYear = 12 - admission_dateTimePicker.Value.Month;
                        int InNextYear = 6 - InCurrentYear;
                        Mymonth = InNextYear;
                    }
                    else
                    {
                        Mymonth = admission_dateTimePicker.Value.Month + 6;
                    }
                    DateTime dt = new DateTime(admission_dateTimePicker.Value.Year, Mymonth, admission_dateTimePicker.Value.Day);
                    se.LeavingYear = dt.Year;
                }
                se.father_FirstName = fatherfnm_TextBox.Text;
                se.father_MiddleName = fathermnm_TextBox.Text;
                se.father_LastName = fatherlnm_TextBox.Text;

                se.mother_FirstName = motherfnm_TextBox.Text;
                se.mother_MiddleName = mothermnm_TextBox.Text;
                se.mother_LastName = motherlnm_TextBox.Text;

                se.ParentsOccupation = father_mother_occupation_textbox.Text;
                se.OfficeAddress = office_address_textBox.Text;
                se.ContactNo = Int64.Parse(parents_contact_TextBox.Text);

                se.SchoolName = schoolnm_textbox.Text;
                se.SchoolStream = school_stream_textbox.Text;
                se.LastYear = int.Parse(school_year_textbox.Text);
                se.LastYear_Percentage = int.Parse(school_percent_textbox.Text);

                se.marksheet_12 = school_marksheet_CheckBox.Checked;
                se.lc_12 = school_LC_checkBox.Checked;
                se.TC = college_tc_checkBox.Checked;
                se.previous_marksheet = college_previous_marksheet_checkBox.Checked;
                se.NOC = college_NOC_checkBox.Checked;

                if (college_checkBox.Checked)
                {
                    se.checkCollege = true;
                    se.CollegeName = collegenm_textbox.Text;
                    se.CollegeStream = college_stream_textbox.Text;
                    se.CollegeYear = int.Parse(college_year_textbox.Text);
                    se.LastSem = int.Parse(college_last_sem_numericUpDown.Value.ToString());
                    se.LastSem_Percentage = int.Parse(college_percent_textbox.Text);

                }
                #endregion

                if (this.isUpdate)
                {
                    Student_Methods.deleteStudent_for_Update(int.Parse(grno_textBox.Text));
                }
                if (Student_Methods.insertStudent(se) > 0)
                {
                    if (isStore)
                    {
                        File.Copy(openphoto.FileName, ImagePath, true);
                        if (this.isUpdate)
                            student_pictureBox.Enabled = false;
                    }

                    if (!isUpdate)
                    {
                        AlertBox.ShowDialog("Successfull registered", AlertBox.AlertType.success, true);
                        clearAll(sender, e);
                        loadGrno();
                        admission_stream_combobox_SelectedIndexChanged(sender, e);
                    }
                    else
                    {
                        AlertBox.ShowDialog("Successfully updated", AlertBox.AlertType.success, true);
                        DataTable dt_student = Student_Methods.loadStudent();                        
                    }
                    studentadmission_tabControl.SelectedIndex = 0;
                }

            }
        }

        private void clearAll(object sender, EventArgs e)
        {
            clear_button_Click(sender, e);
            clearingAll_subFunc(educational_details_tabPage);
            
        }

        private void clear2_button_Click(object sender, EventArgs e)
        {
            clearingAll_subFunc(educational_details_tabPage);
            admission_stream_combobox_SelectedIndexChanged(sender, e);
        }

        private void clearingAll_subFunc(Control cc)
        {
            foreach (Control ctrl in cc.Controls)
            {
                if (!(ctrl is Label || ctrl is Button || ctrl is RadioButton))
                {
                    if (ctrl is GroupBox || ctrl is Panel)
                        clearingAll_subFunc(ctrl);
                    else
                    {
                        if (ctrl is TextBox)
                        {
                            ((TextBox)ctrl).Clear();
                        }
                        else if (ctrl is ComboBox)
                        {
                            ((ComboBox)ctrl).SelectedIndex = 0;
                        }
                        else if (ctrl is CheckBox && ctrl.Name != "school_checkBox")
                        {
                            ((CheckBox)ctrl).Checked = false;
                        }
                        else if (ctrl is NumericUpDown)
                        {
                            ((NumericUpDown)ctrl).Value = ((NumericUpDown)ctrl).Minimum;
                        }
                        ctrl.BackColor = Color.White;
                    }
                }
            }
            fees_to_pay_textbox.Text = "0";
        }
        
        private bool educational_details_validation()
        {
            bool flg = true;
            if (school_checkBox.Checked)
            {
                if (schoolnm_textbox.Text == "")
                {
                    flg = false;
                    schoolnm_textbox.BackColor = Color.Pink;
                }
                if(school_stream_textbox.Text == "")
                {
                    flg = false;
                    school_stream_textbox.BackColor = Color.Pink;
                }
                if(school_year_textbox.Text == "" || school_year_textbox.Text.Length != 4 || (int.Parse(school_year_textbox.Text)) <= dob_dateTimePicker.Value.Year || (int.Parse(school_year_textbox.Text)) > DateTime.Now.Year)
                {
                    flg =false;
                    school_year_textbox.BackColor = Color.Pink;
                }
                if(school_percent_textbox.Text == "" )
                {
                    flg =false;
                    school_percent_textbox.BackColor = Color.Pink;
                }
            }
            if (college_checkBox.Checked)
            {
                if(collegenm_textbox.Text == "")
                {
                    flg = false;
                    collegenm_textbox.BackColor = Color.Pink;
                }
                if(college_stream_textbox.Text == "")
                {
                    flg =false;
                    college_stream_textbox.BackColor = Color.Pink;
                }
                if(college_year_textbox.Text == "" || (int.Parse(college_year_textbox.Text) <= int.Parse(school_year_textbox.Text)) || college_year_textbox.Text.Length != 4 || (int.Parse(college_year_textbox.Text)) <= dob_dateTimePicker.Value.Year || (int.Parse(college_year_textbox.Text)) > DateTime.Now.Year)
                {
                    flg = false;
                    college_year_textbox.BackColor = Color.Pink;
                }
                if(college_percent_textbox.Text == "")
                {
                    flg =false;
                    college_percent_textbox.BackColor = Color.Pink;
                }
            }
            if(admission_stream_combobox.Items.Contains("select"))
            {
                flg =false;
                admission_stream_combobox.BackColor = Color.Pink;
            }
            if(!flg)
            {
                AlertBox.ShowDialog("Please enter valid data in required field",AlertBox.AlertType.error,false);
            }
            return flg;
        }

        private void educational_details_textChanged(object sender, EventArgs e)
        {
            ClassCall.textChangeFun(sender as Control);
        }
        #endregion

        private void city_state_nation_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch < 65 || ch > 91) && ch != 32 && ch != 8)
            {
                e.KeyChar = (char)0;
            }
        }



        #region variables
        DataTable dt_state, dt_city;
        #endregion

        private void loadGrno()
        {
            int grno = Student_Methods.loadGrno();
            grno_textBox.Text = grno.ToString();
        }
        private void StudentAdmission_Load(object sender, EventArgs e)
        {
            loadGrno();
            loadCast();
            loadCountry();
            loadState();
            loadCourse();
            admission_stream_combobox_SelectedIndexChanged(sender, e);
            loadCity();

            if (isUpdate)
            {
                loadDataInForm();
                if (this.isReadOnly)
                {
                    save_nexttab_button.Visible = false;
                    clear_button.Visible = false;
                    save_button.Visible = false;
                    clear2_button.Visible = false;
                    foreach (Control cc in personal_details_tabPage.Controls)
                    {
                        cc.Enabled = false;
                    }
                    foreach (Control cc in educational_details_tabPage.Controls)
                    {
                        cc.Enabled = false;
                    }
                }
            }
        }


        private void AllCtrlKeyPressed(object sender, KeyPressEventArgs ke)
        {
            ke.KeyChar = (char)0;
        }

        private void loadDataInForm()
        {
            grno_textBox.ReadOnly = true;
            grno_textBox.Text = se.grno.ToString();


            /********************student detail**********************/
            candidatefnm_TextBox.Text = se.candidate_FirstName;
            candidatemnm_TextBox.Text = se.candidate_MiddleName;
            candidatelnm_TextBox.Text = se.candidate_LastName;

            if (se.ProfilePhoto != null)
            {
                student_pictureBox.Image = Image.FromFile(se.ProfilePhoto);
                student_pictureBox.Enabled = false;
            }

            currentaddress_textbox.Text = se.CurrentAddress;
            permanentaddress_textbox.Text = se.PermanentAddress;
            pincode_TextBox.Text = se.Pincode.ToString();
            country_comboBox.SelectedValue = se.CountryId;
            state_comboBox.SelectedValue = se.StateId;
            city_comboBox.SelectedValue = se.CityId;
            admission_dateTimePicker.Value = se.AdmissionDate;
            dob_dateTimePicker.Value = se.DOB;
            birthplace_TextBox.Text = se.BirthPlace;
            candidate_mno_textbox.Text = se.MobileNo.ToString();
            email_textbox.Text = se.Email;
            telephone_textbox.Text = se.TelephoneNo.ToString();
            discount_numericUpDown.Value = Convert.ToDecimal(se.Discount);
            admission_stream_combobox.SelectedValue = se.CourseId;
            admission_sem_numericUpDown.Value = Convert.ToDecimal(se.AdmissionSem);
            cast_comboBox.SelectedValue = se.CastId;
            if (se.gender.Equals("male", StringComparison.OrdinalIgnoreCase))
                male_radioButton.Checked = true;
            else
                female_radioButton.Checked = true;


            /***************************Parents Details**********************/
            fatherfnm_TextBox.Text = se.father_FirstName;
            fathermnm_TextBox.Text = se.father_MiddleName;
            fatherlnm_TextBox.Text = se.father_LastName;
            motherfnm_TextBox.Text = se.mother_FirstName;
            mothermnm_TextBox.Text = se.mother_MiddleName;
            motherlnm_TextBox.Text = se.mother_LastName;
            parents_contact_TextBox.Text = se.ContactNo.ToString();
            father_mother_occupation_textbox.Text = se.ParentsOccupation;
            office_address_textBox.Text = se.OfficeAddress;

            /*******************School Details**************/
            schoolnm_textbox.Text = se.SchoolName;
            school_stream_textbox.Text = se.SchoolStream;
            school_year_textbox.Text = se.LastYear.ToString();
            school_percent_textbox.Text = se.LastYear_Percentage.ToString();

            /***************School Documents*****************/
            school_marksheet_CheckBox.Checked = se.marksheet_12;
            school_LC_checkBox.Checked = se.lc_12;

            /**************College Details***************/
            if (se.checkCollege)
            {
                college_checkBox.Checked = true;
                collegenm_textbox.Text = se.CollegeName;
                college_stream_textbox.Text = se.CollegeStream;
                college_last_sem_numericUpDown.Value = Convert.ToDecimal(se.LastSem);
                college_year_textbox.Text = se.CollegeYear.ToString();
                college_percent_textbox.Text = se.LastSem_Percentage.ToString();

                /****************College Document**************/
                college_previous_marksheet_checkBox.Checked = se.previous_marksheet;
                college_tc_checkBox.Checked = se.TC;
                college_NOC_checkBox.Checked = se.NOC;
            }
        }

        private void loadCourse()
        {
            dt_course = Student_Methods.loadCourse();
            admission_stream_combobox.DataSource = dt_course; 
            admission_stream_combobox.ValueMember = "C_Id";
            admission_stream_combobox.DisplayMember = "C_Alias";
        }


        private void loadCity()
        {
            dt_city = Student_Methods.loadCity();
            city_comboBox.DisplayMember = "CityNm";
            city_comboBox.ValueMember = "CityId";
            city_comboBox.DataSource = dt_city;
        }

        private void loadState()
        {
            dt_state = Student_Methods.loadState();
            state_comboBox.DisplayMember = "StateNm";
            state_comboBox.ValueMember = "StateId";
            state_comboBox.DataSource = dt_state;
        }

        private void loadCountry()
        {
            DataTable dt = Student_Methods.loadCountry();
            country_comboBox.DisplayMember = "CountryNm";
            country_comboBox.ValueMember = "CountryId";
            country_comboBox.DataSource = dt;
        }

        private void loadCast()
        {
            DataTable dt = Student_Methods.loadCast();
            cast_comboBox.DisplayMember = "CastNm";
            cast_comboBox.ValueMember = "CastId";
            cast_comboBox.DataSource = dt;
        }

        private void state_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void country_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*DataView dv = dt_state.DefaultView;
            MessageBox.Show(country_comboBox.SelectedValue.ToString());
            //dv.RowFilter = "CountryId=" + Convert.ToInt32(country_comboBox.SelectedValue);
            //dt_state.DefaultView.RowFilter = "CountryId=" + country_comboBox.SelectedValue;*/
        }

        private void admission_stream_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            admission_sem_numericUpDown.Value = 1;
            for (int i = 0; i < dt_course.Rows.Count; i++)
            {
                if (dt_course.Rows[i][0].ToString() == admission_stream_combobox.SelectedValue.ToString())
                {
                    admission_sem_numericUpDown.Maximum = decimal.Parse(dt_course.Rows[i]["C_TotalSem"].ToString());
                    fees_to_pay_textbox.Text = dt_course.Rows[i]["C_Fees"].ToString();
                    break;
                }
            }
        }

        private void FormCloseBtn_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                SearchStudent obj = new SearchStudent();
                obj.TopLevel = false;
                obj.Parent = ClassCall.mainFormObj.masterpanel;
                obj.Dock = DockStyle.Fill;
                obj.BringToFront();
                obj.Focus();
                obj.Show();
            }
        }

    }
}
