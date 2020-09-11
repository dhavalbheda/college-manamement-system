using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CustomMessageBox;
using AD_CMS_DatabaseModel;
using AD_CMS_Entity;
using System.IO;
using AD_CMS.StudentMgmtSubForms;

namespace AD_CMS.StaffMgmtSubForms
{
    public partial class EmployeeRegistration : TemplateForm
    {
        #region valriables
        List<Control> lstctrl = new List<Control>(); // contains only required controls
        List<Control> lstclear = new List<Control>(); // contains all controls except label , groupbox,panel
        bool isPersonalDet_validated = false,isStoreImage=false;
        string ImagePath;
        EmployeeEntity ey;
        public bool isUpdate;
        public SearchEmployee searchemployeeobj;
        OpenFileDialog openphoto;

        #endregion

        public EmployeeRegistration()
        {
            InitializeComponent();
            AddElementsToList(personal_details_tabPage);
        }

        public EmployeeRegistration(EmployeeEntity ey, SearchEmployee obj1)
        {
            InitializeComponent();
            this.ey = ey;
            searchemployeeobj = obj1;
        }


        private void EmployeeRegistration_Load(object sender, EventArgs e)
        {
            loadEMPID();
            loadCity();
            loadState();
            loadCountry();
            loadCast();
            loadBankname();
            education_comboBox.SelectedIndex = 0;

            if (isUpdate)
            {
                 
                emp_id_textbox.Text = ey.empid.ToString();
                if (!string.IsNullOrEmpty(ey.profile))
                {
                    EmployeeProfile_pictureBox.Image = Image.FromFile(ey.profile);
                    EmployeeProfile_pictureBox.Enabled = false;
                }
                else
                {
                    EmployeeProfile_pictureBox.Enabled = true;
                }
                empfnm_textBox.Text = ey.emp_firstName;
                empmnm_textBox.Text = ey.emp_middleName;
                emplnm_textBox.Text = ey.emp_lastName;
                fatherfnm_textBox.Text = ey.father_firstName;
                fathermnm_textBox.Text = ey.father_middleName;
                fatherlnm_textBox.Text = ey.father_lastName;
                motherfnm_textBox.Text = ey.mother_firstName;
                mothermnm_textBox.Text = ey.mother_middleName;
                motherlnm_textBox.Text = ey.mother_lastName;
                joindate_dateTimePicker.Value = ey.joinDate;
                if (ey.isTeaching.Equals("Teaching", StringComparison.OrdinalIgnoreCase))
                {
                    teaching_radioButton.Checked = true;
                }
                else
                {
                    non_teachingradioButton.Checked = true;
                }
                current_address_textBox.Text = ey.currentAddress;
                permanentaddress_textBox.Text = ey.permanentAddress;
                pincode_textBox.Text = ey.pincode.ToString();
                nationality_comboBox.SelectedValue = ey.countryid;
                state_comboBox.SelectedValue = ey.stateid;
                City_comboBox.SelectedValue = ey.cityid;
                if (ey.gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
                {
                    female_radioButton.Checked = true;
                }
                else
                {
                    male_radioButton.Checked = true;
                }
                cast_comboBox.SelectedValue = ey.castid;
                
                dob_dateTimePicker.Value = ey.dob;
                bithplace_textBox.Text = ey.birthplace;
                education_comboBox.Text = ey.degree;
                emp_mno_textBox.Text = ey.empmobileNo.ToString();
                email_textBox.Text = ey.email;
                parents_no_textBox.Text = ey.perentsNo.ToString();
                telephone_textBox.Text = ey.telephone.ToString();
                //ey.degree = education_comboBox.Text;
                lastemployer_textBox.Text = ey.lastEmployeeAt;
                yearexperience_textBox.Text = ey.YearOfExperience.ToString();
                remark_textBox.Text = ey.remark;

                Banknm_ComboBox.SelectedValue = ey.bankID;
                accountno_textBox.Text = ey.accountNo.ToString();
                ifsccode_textBox.Text = ey.IFSCCode;
                branchnm_textBox.Text = ey.BranchName;

                aadharcard_checkBox.Checked = ey.aadharCard;
                pancard_checkBox.Checked = ey.panCard;
                experience_certificate_checkBox.Checked = ey.experienceCertificate;
                degree_certificate_checkBox.Checked = ey.degreeCertificate;
            }
        }

        private void loadEMPID()
        {
            int EMPID = Employee_Methods.loadEmpID();
            emp_id_textbox.Text = EMPID.ToString();
        }

        private void loadCity()
        {
            DataTable dt_city = Student_Methods.loadCity();
            City_comboBox.DisplayMember = "CityNm";
            City_comboBox.ValueMember = "CityId";
            City_comboBox.DataSource = dt_city;
        }

        private void loadState()
        {
            DataTable dt_state = Student_Methods.loadState();
            state_comboBox.DisplayMember = "StateNm";
            state_comboBox.ValueMember = "StateId";
            state_comboBox.DataSource = dt_state;
        }

        private void loadCountry()
        {
            DataTable dt_country = Student_Methods.loadCountry();
            nationality_comboBox.DisplayMember = "CountryNm";
            nationality_comboBox.ValueMember = "CountryId";
            nationality_comboBox.DataSource = dt_country;
        }

        private void loadCast()
        {
            DataTable dt_cast = Student_Methods.loadCast();
            cast_comboBox.DisplayMember = "CastNm";
            cast_comboBox.ValueMember = "CastId";
            cast_comboBox.DataSource = dt_cast;
        }

        private void loadBankname()
        {
            DataTable dt_bknm = Employee_Methods.loadBankName();
            Banknm_ComboBox.DisplayMember = "BankName";
            Banknm_ComboBox.ValueMember = "BankID";
            Banknm_ComboBox.DataSource = dt_bknm;
        }

        private void EmployeeProfile_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            picturebox_tip_label.Show();
        }

        private void EmployeeProfile_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            picturebox_tip_label.Hide();
        }

        private void EmployeeProfile_pictureBox_Click(object sender, EventArgs e)
        {
            openphoto = new OpenFileDialog();
            openphoto.Title = "Upload Photo";
            openphoto.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;.*bmp";
            if (openphoto.ShowDialog() == DialogResult.OK)
            {
                EmployeeProfile_pictureBox.Image = Image.FromFile(openphoto.FileName);
                ImagePath = @"..\..\EmployeeProfilePhotos\" + emp_id_textbox.Text + Path.GetExtension(openphoto.FileName);
                isStoreImage = true;
            }
        }
        
        #region Personal details
        //this function add controls into lists - lstctrl,lstclears
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
                            if (ctrl.Name != "joindate_dateTimePicker" && ctrl.Name != "lastemployer_textBox" && ctrl.Name != "yearexperience_textBox")
                            {
                                lstctrl.Add(ctrl);
                            }
                        }
                        lstclear.Add(ctrl);
                    }
                }
            }
        }

        //save button click event and saves data into database
        private void save_nexttab_button_Click(object sender, EventArgs e)
        {
            if (valid())
            {
               AlertBox.ShowDialog("All Details Correct",AlertBox.AlertType.success,true);
               isPersonalDet_validated = true;
               emp_registration_tabControl.SelectedIndex = 1;
            }
        }

        //validate all required field
        private bool valid()
        {
            bool flag = true;
            foreach (Control ctrl in lstctrl)
            {
                if (ctrl is TextBox && ctrl.Text.Trim() == "" && ctrl.Name != "pincode_textBox" && ctrl.Name != "telephone_textBox" && (ctrl.Name != "emp_mno_textBox" || ctrl.Name != "parents_no_textBox"))
                {
                    if (flag)
                        AlertBox.ShowDialog("Please enter data in required field", AlertBox.AlertType.error, false);
                    flag = false;
                    ctrl.BackColor = Color.Pink;
                }
                else if (ctrl is DateTimePicker && ctrl.Name == "dob_dateTimePicker" && (((DateTimePicker)ctrl).Value == DateTime.Today || ((DateTimePicker)ctrl).Value.Year >= DateTime.Today.Year - 12))
                {
                    if (flag)
                        AlertBox.ShowDialog("Please enter valid date in Birth date", AlertBox.AlertType.error, false);
                    flag = false;
                    ctrl.BackColor = Color.Pink;
                }
                else if (ctrl.Name == "pincode_textBox" && pincode_textBox.Text != "")
                {
                    if (ctrl.Text.Length != 6)
                    {
                        if (flag)
                            AlertBox.ShowDialog("Please enter valid pincode", AlertBox.AlertType.error, false);
                        flag = false;
                        ctrl.BackColor = Color.Pink;
                    }
                }
                else if (ctrl.Name == "telephone_textBox" && ctrl.Text != "")
                {
                    if (ctrl.Text.Length != 10)
                    {
                        if (flag)
                            AlertBox.ShowDialog("Please enter valid telephone no", AlertBox.AlertType.error, false);
                        flag = false;
                        ctrl.BackColor = Color.Pink;
                    }
                }
                else if (ctrl.Name == "emp_mno_textBox" || ctrl.Name == "parents_no_textBox")
                {
                    if (ctrl.Text.Trim() == "")
                    {
                        if (flag)
                            AlertBox.ShowDialog("Please enter data in required field", AlertBox.AlertType.error, false);
                        flag = false;
                        ctrl.BackColor = Color.Pink;
                    }
                    else if (ctrl.Text.Length != 10)
                    {
                        if (flag)
                            AlertBox.ShowDialog("Please enter valid mobile number", AlertBox.AlertType.error, false);
                        flag = false;
                        ctrl.BackColor = Color.Pink;
                    }
                }
                else if (ctrl.Name == "email_textBox")
                {
                    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                    Match match = regex.Match(ctrl.Text);
                    if (!match.Success || ctrl.Text == "")
                    {
                        flag = false;
                        AlertBox.ShowDialog("Please enter valid Email Address", AlertBox.AlertType.error, false);
                        ctrl.BackColor = Color.Pink;
                    }
                }
            }
            if ((pincode_textBox.Text != "" && pincode_textBox.Text.Length!=6))
            {
                if (flag)
                {
                    AlertBox.ShowDialog("Pin Code Must B 6 Digit.", AlertBox.AlertType.error, false);
                }
                flag = false;
                pincode_textBox.BackColor = Color.Pink;
            }
            return flag;
        }

        //change the color of error control
        private void textChange(object sender, EventArgs e)
        {
            Control ctr = sender as Control;
            ClassCall.textChangeFun(ctr);

            if (ctr.Name == "empmnm_textBox" || ctr.Name == "fatherfnm_textBox" || ctr.Name == "mothermnm_textBox")
            {
                empmnm_textBox.Text = fatherfnm_textBox.Text = mothermnm_textBox.Text = ctr.Text;
            }
            if (ctr.Name == "emplnm_textBox" || ctr.Name == "fatherlnm_textBox" || ctr.Name == "mothermnm_textBox.Name")
            {
                emplnm_textBox.Text = fatherlnm_textBox.Text = motherlnm_textBox.Text = ctr.Text;
            }
                 
        }

        //clears the value of all controls
        private void clear_button_Click(object sender, EventArgs e)
        {
            foreach (Control clr in lstclear)
            {
                if (clr is TextBox && clr.Name != "emp_id_textbox")
                {
                    ((TextBox)clr).Clear();
                }
                else if (clr is ComboBox)
                {
                    ((ComboBox)clr).SelectedIndex = 0;
                }
                else if (clr is DateTimePicker)
                {
                    if (clr.Name == "joindate_dateTimePicker")
                    {
                        ((DateTimePicker)clr).Value = DateTime.Now;
                    }
                    else
                    {
                        ((DateTimePicker)clr).Value = dob_dateTimePicker.MinDate;
                    }
                }
                else if (clr is CheckBox)
                {
                    ((CheckBox)clr).Checked = false;
                }
                clr.BackColor = Color.White;
            }

        }

        #region as above checkbox

        //if this checkbox is checked then value of both the addresses textbox will be same
        private void asabove_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (asabove_checkBox.Checked)
            {
                permanentaddress_textBox.Text = current_address_textBox.Text;
                permanentaddress_textBox.ReadOnly = true;
            }
            else
            {
                permanentaddress_textBox.Clear();
                permanentaddress_textBox.ReadOnly = false;
            }
        }

        //assign value of current address to permanent address on its leave event
        private void current_address_textBox_Leave(object sender, EventArgs e)
        {
            if (asabove_checkBox.Checked)
            {
                permanentaddress_textBox.Text = current_address_textBox.Text;
            }
        }

        //if both the address have same data but checkbox isn't checked then it will check on permanent address leave event
        private void permanent_address_textBox_Leave(object sender, EventArgs e)
        {
            if (current_address_textBox.Text.Trim() == permanentaddress_textBox.Text.Trim())
            {
                if (!asabove_checkBox.Checked)
                {
                    asabove_checkBox.Checked = true;
                }
            }
            else
                asabove_checkBox.Checked = false;
        }

        #endregion

        private void save_button_Click(object sender, EventArgs e)
        {
            if (!isPersonalDet_validated)
            {
                AlertBox.ShowDialog("Please fill up Personal Details", AlertBox.AlertType.error, false);
                emp_registration_tabControl.SelectedIndex = 0;
            }
            else if (OtherDet_validation() && isPersonalDet_validated)
            {
                EmployeeEntity ey = loadEntity();
                if (isUpdate)
                {
                    save_next_button.Text = "Next";
                    Employee_Methods.updateEmployee(ey);
                    AlertBox.ShowDialog("Successfull Updated", AlertBox.AlertType.success, true);
                    if (isStoreImage)
                    {
                        File.Copy(openphoto.FileName, ImagePath, true);
                        EmployeeProfile_pictureBox.Enabled = false;
                    }
                    clear_button_Click(sender, e);
                    clear_button2_Click(sender, e);
                    emp_registration_tabControl.SelectedIndex = 0;
                    /*DataTable dt_employee = Employee_Methods.loadEmployee();
                    searchemployeeobj.employee_dataGridView.DataSource = null;
                    searchemployeeobj.employee_dataGridView.DataSource = dt_employee;
                    //searchemployeeobj.employee_dataGridView.Columns["Profile"].Visible = false;
                */
                }
                else
                {
                    int FLAG = Employee_Methods.insertEmployee(ey);
                    if (FLAG > 0)
                    {
                        if (isStoreImage)
                        {
                            File.Copy(openphoto.FileName, ImagePath, true);
                        }
                        AlertBox.ShowDialog("Successfull registered", AlertBox.AlertType.success, true);
                        clear_button_Click(sender, e);
                        clear_button2_Click(sender, e);
                        emp_registration_tabControl.SelectedIndex = 0;
                        EmployeeProfile_pictureBox.Image = EmployeeProfile_pictureBox.InitialImage;

                        loadEMPID();
                    }
                }
            }
        }

        private EmployeeEntity loadEntity()
        {
            EmployeeEntity ey = new EmployeeEntity();
            ey.empid = int.Parse(emp_id_textbox.Text.ToString());
            ey.profile = ImagePath;
            ey.emp_firstName = empfnm_textBox.Text;
            ey.emp_middleName = empmnm_textBox.Text;
            ey.emp_lastName = emplnm_textBox.Text;
            ey.father_firstName = fatherfnm_textBox.Text;
            ey.father_middleName = fathermnm_textBox.Text;
            ey.father_lastName = fatherlnm_textBox.Text;
            ey.mother_firstName = motherfnm_textBox.Text;
            ey.mother_middleName = mothermnm_textBox.Text;
            ey.mother_lastName = motherlnm_textBox.Text;
            ey.joinDate = joindate_dateTimePicker.Value;
            ey.isTeaching = (teaching_radioButton.Checked) ? teaching_radioButton.Text : non_teachingradioButton.Text;
            ey.currentAddress = current_address_textBox.Text;
            ey.permanentAddress = permanentaddress_textBox.Text;
            ey.pincode = (pincode_textBox.Text == string.Empty) ? (int?)null : int.Parse(pincode_textBox.Text);
            ey.cityid = int.Parse(City_comboBox.SelectedValue.ToString());
            ey.stateid = int.Parse(state_comboBox.SelectedValue.ToString());
            ey.countryid = int.Parse(nationality_comboBox.SelectedValue.ToString());
            ey.gender = (male_radioButton.Checked) ? male_radioButton.Text : female_radioButton.Text;
            ey.castid = int.Parse(cast_comboBox.SelectedValue.ToString());
            ey.dob = dob_dateTimePicker.Value;
            ey.birthplace = bithplace_textBox.Text;
            ey.empmobileNo = Int64.Parse(emp_mno_textBox.Text.ToString());
            ey.email = email_textBox.Text;
            ey.perentsNo = Int64.Parse(parents_no_textBox.Text.ToString());
            ey.telephone = (telephone_textBox.Text == string.Empty) ? (Int64?)null : Int64.Parse(telephone_textBox.Text);
            ey.degree = education_comboBox.Text;
            ey.lastEmployeeAt = lastemployer_textBox.Text;
            ey.YearOfExperience = (yearexperience_textBox.Text == string.Empty) ? (int?)null : int.Parse(yearexperience_textBox.Text);
            ey.remark = remark_textBox.Text;

            ey.bankID = int.Parse(Banknm_ComboBox.SelectedValue.ToString());
            ey.accountNo = Int64.Parse(accountno_textBox.Text.ToString());
            ey.IFSCCode = ifsccode_textBox.Text;
            ey.BranchName = branchnm_textBox.Text;

            ey.aadharCard = aadharcard_checkBox.Checked;
            ey.panCard = pancard_checkBox.Checked;
            ey.experienceCertificate = experience_certificate_checkBox.Checked;
            ey.degreeCertificate = degree_certificate_checkBox.Checked;
            return ey;
        }

        private bool OtherDet_validation()
        {
            bool flag=true;
            if (accountno_textBox.Text == "")
            {
                if(flag)
                {
                    AlertBox.ShowDialog("Please Fill Required Fill",AlertBox.AlertType.error,false);
                }
                accountno_textBox.BackColor=Color.Pink;
                flag = false;
            }
            
            if (ifsccode_textBox.Text == "")
            {
                if (flag)
                {
                    AlertBox.ShowDialog("Please Fill Required Fill", AlertBox.AlertType.error, false);
                }
                ifsccode_textBox.BackColor = Color.Pink;
                flag = false;
            }
            if (branchnm_textBox.Text == "")
            {
                if (flag)
                {
                    AlertBox.ShowDialog("Please Fill Required Fill", AlertBox.AlertType.error, false);
                }
                branchnm_textBox.BackColor = Color.Pink;
                flag = false;
            }
            if (!degree_certificate_checkBox.Checked)
            {
                if (flag)
                {
                    AlertBox.ShowDialog("Degree Certificate Required.", AlertBox.AlertType.error, false);
                }
                degree_certificate_checkBox.BackColor = Color.Pink;
                flag = false;
            }
            if (!pancard_checkBox.Checked)
            {
                if (flag)
                {
                    AlertBox.ShowDialog("PanCard Required.", AlertBox.AlertType.error, false);
                }
                pancard_checkBox.BackColor = Color.Pink;
                flag = false;
            }
            if (!aadharcard_checkBox.Checked)
            {
                if (flag)
                {
                    AlertBox.ShowDialog("Aadhar Card Required.", AlertBox.AlertType.error, false);
                }
                aadharcard_checkBox.BackColor = Color.Pink;
                flag = false;
            }
            return flag;
        }
        #endregion

        private void clear_button2_Click(object sender, EventArgs e)
        {
            accountno_textBox.Text = "";
            accountno_textBox.BackColor = Color.White;
            ifsccode_textBox.Text = "";
            ifsccode_textBox.BackColor = Color.White;
            branchnm_textBox.Text = "";
            branchnm_textBox.BackColor = Color.White;
            remark_textBox.Text = "";
            aadharcard_checkBox.Checked = false;
            pancard_checkBox.Checked = false;
            experience_certificate_checkBox.Checked = false;
            degree_certificate_checkBox.Checked = false;
            degree_certificate_checkBox.BackColor = Color.White;
            
        }

        private void FormCloseBtn_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                SearchEmployee obj = new SearchEmployee();
                obj.TopLevel = false;
                obj.Parent = ClassCall.mainFormObj.masterpanel;
                obj.Dock = DockStyle.Fill;
                obj.BringToFront();
                obj.Show();
            }
        }
    }
}
