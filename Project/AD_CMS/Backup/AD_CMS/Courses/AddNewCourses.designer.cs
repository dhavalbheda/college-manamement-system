using System.Drawing;
namespace AD_CMS.Course
{
    partial class AddNewCourses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.add_new_course_tabControl = new System.Windows.Forms.TabControl();
            this.course_Details_tabPage = new System.Windows.Forms.TabPage();
            this.CourseDetails_dataGridView = new System.Windows.Forms.DataGridView();
            this.add_course_groupBox = new System.Windows.Forms.GroupBox();
            this.As_per_name_checkBox = new System.Windows.Forms.CheckBox();
            this.course_nm_alias_textBox = new System.Windows.Forms.TextBox();
            this.course_nm_alias_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.course_nm_textBox = new CustomControl.UpperTextBox();
            this.total_sem_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.add_sem_label = new System.Windows.Forms.Label();
            this.course_nm_label = new System.Windows.Forms.Label();
            this.subject_Details_tabPage = new System.Windows.Forms.TabPage();
            this.subjectDetails_dataGridView = new System.Windows.Forms.DataGridView();
            this.subject_details_groupBox = new System.Windows.Forms.GroupBox();
            this.course_nm_comboBox = new System.Windows.Forms.ComboBox();
            this.course_nm2_label = new System.Windows.Forms.Label();
            this.subject_code_textBox = new CustomControl.NumericTextBox();
            this.subject_code_label = new System.Windows.Forms.Label();
            this.add_button2 = new System.Windows.Forms.Button();
            this.next_button2 = new System.Windows.Forms.Button();
            this.subject_nm_textBox = new CustomControl.UpperTextBox();
            this.select_sem_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.select_sem_label = new System.Windows.Forms.Label();
            this.subject_nm_label = new System.Windows.Forms.Label();
            this.course_fee_details_tabPage = new System.Windows.Forms.TabPage();
            this.courseFee_dataGridView = new System.Windows.Forms.DataGridView();
            this.course_fee_details_groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.instruction_label2 = new System.Windows.Forms.Label();
            this.instruction_label = new System.Windows.Forms.Label();
            this.total_fee_label = new System.Windows.Forms.Label();
            this.total_fee_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.set_fee_textBox = new CustomControl.NumericTextBox();
            this.select_course_comboBox = new System.Windows.Forms.ComboBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.set_fee_label = new System.Windows.Forms.Label();
            this.select_course_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.add_new_course_tabControl.SuspendLayout();
            this.course_Details_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDetails_dataGridView)).BeginInit();
            this.add_course_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.total_sem_numericUpDown)).BeginInit();
            this.subject_Details_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDetails_dataGridView)).BeginInit();
            this.subject_details_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_sem_numericUpDown)).BeginInit();
            this.course_fee_details_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseFee_dataGridView)).BeginInit();
            this.course_fee_details_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(425, 5);
            this.heading_label.Size = new System.Drawing.Size(298, 38);
            this.heading_label.Text = "Add New Course";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.add_new_course_tabControl);
            this.contentarea_panel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // add_new_course_tabControl
            // 
            this.add_new_course_tabControl.Controls.Add(this.course_Details_tabPage);
            this.add_new_course_tabControl.Controls.Add(this.subject_Details_tabPage);
            this.add_new_course_tabControl.Controls.Add(this.course_fee_details_tabPage);
            this.add_new_course_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_new_course_tabControl.Location = new System.Drawing.Point(0, 0);
            this.add_new_course_tabControl.Name = "add_new_course_tabControl";
            this.add_new_course_tabControl.SelectedIndex = 0;
            this.add_new_course_tabControl.Size = new System.Drawing.Size(1090, 654);
            this.add_new_course_tabControl.TabIndex = 2;
            this.add_new_course_tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.add_new_course_tabControl_Selected);
            // 
            // course_Details_tabPage
            // 
            this.course_Details_tabPage.BackColor = global::AD_CMS.Properties.Settings.Default.TemplateBack;
            this.course_Details_tabPage.Controls.Add(this.label2);
            this.course_Details_tabPage.Controls.Add(this.CourseDetails_dataGridView);
            this.course_Details_tabPage.Controls.Add(this.add_course_groupBox);
            this.course_Details_tabPage.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_Details_tabPage.Location = new System.Drawing.Point(4, 28);
            this.course_Details_tabPage.Name = "course_Details_tabPage";
            this.course_Details_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.course_Details_tabPage.Size = new System.Drawing.Size(1082, 622);
            this.course_Details_tabPage.TabIndex = 0;
            this.course_Details_tabPage.Text = "Course Details";
            // 
            // CourseDetails_dataGridView
            // 
            this.CourseDetails_dataGridView.AllowUserToAddRows = false;
            this.CourseDetails_dataGridView.AllowUserToDeleteRows = false;
            this.CourseDetails_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CourseDetails_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseDetails_dataGridView.Location = new System.Drawing.Point(114, 282);
            this.CourseDetails_dataGridView.Name = "CourseDetails_dataGridView";
            this.CourseDetails_dataGridView.ReadOnly = true;
            this.CourseDetails_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CourseDetails_dataGridView.Size = new System.Drawing.Size(854, 291);
            this.CourseDetails_dataGridView.TabIndex = 1;
            // 
            // add_course_groupBox
            // 
            this.add_course_groupBox.Controls.Add(this.As_per_name_checkBox);
            this.add_course_groupBox.Controls.Add(this.course_nm_alias_textBox);
            this.add_course_groupBox.Controls.Add(this.course_nm_alias_label);
            this.add_course_groupBox.Controls.Add(this.add_button);
            this.add_course_groupBox.Controls.Add(this.next_button);
            this.add_course_groupBox.Controls.Add(this.course_nm_textBox);
            this.add_course_groupBox.Controls.Add(this.total_sem_numericUpDown);
            this.add_course_groupBox.Controls.Add(this.add_sem_label);
            this.add_course_groupBox.Controls.Add(this.course_nm_label);
            this.add_course_groupBox.Location = new System.Drawing.Point(169, 15);
            this.add_course_groupBox.Name = "add_course_groupBox";
            this.add_course_groupBox.Size = new System.Drawing.Size(736, 253);
            this.add_course_groupBox.TabIndex = 0;
            this.add_course_groupBox.TabStop = false;
            this.add_course_groupBox.Text = "Add Course ";
            // 
            // As_per_name_checkBox
            // 
            this.As_per_name_checkBox.AutoSize = true;
            this.As_per_name_checkBox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.As_per_name_checkBox.Location = new System.Drawing.Point(458, 98);
            this.As_per_name_checkBox.Name = "As_per_name_checkBox";
            this.As_per_name_checkBox.Size = new System.Drawing.Size(103, 21);
            this.As_per_name_checkBox.TabIndex = 2;
            this.As_per_name_checkBox.Text = "As per name";
            this.As_per_name_checkBox.UseVisualStyleBackColor = true;
            this.As_per_name_checkBox.CheckedChanged += new System.EventHandler(this.As_per_name_checkBox_CheckedChanged);
            // 
            // course_nm_alias_textBox
            // 
            this.course_nm_alias_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.course_nm_alias_textBox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_nm_alias_textBox.Location = new System.Drawing.Point(289, 94);
            this.course_nm_alias_textBox.Name = "course_nm_alias_textBox";
            this.course_nm_alias_textBox.Size = new System.Drawing.Size(163, 27);
            this.course_nm_alias_textBox.TabIndex = 1;
            this.course_nm_alias_textBox.TextChanged += new System.EventHandler(this.course_controls_textChanged);
            this.course_nm_alias_textBox.Leave += new System.EventHandler(this.course_nm_alias_textBox_Leave);
            // 
            // course_nm_alias_label
            // 
            this.course_nm_alias_label.AutoSize = true;
            this.course_nm_alias_label.Location = new System.Drawing.Point(102, 97);
            this.course_nm_alias_label.Name = "course_nm_alias_label";
            this.course_nm_alias_label.Size = new System.Drawing.Size(181, 20);
            this.course_nm_alias_label.TabIndex = 4;
            this.course_nm_alias_label.Text = "*Course Name Alias : ";
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(383, 189);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(197, 46);
            this.add_button.TabIndex = 5;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // next_button
            // 
            this.next_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_button.Location = new System.Drawing.Point(157, 189);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(197, 46);
            this.next_button.TabIndex = 4;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // course_nm_textBox
            // 
            this.course_nm_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.course_nm_textBox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_nm_textBox.Location = new System.Drawing.Point(289, 42);
            this.course_nm_textBox.Name = "course_nm_textBox";
            this.course_nm_textBox.Size = new System.Drawing.Size(229, 27);
            this.course_nm_textBox.TabIndex = 0;
            this.course_nm_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.course_nm_textBox.TextChanged += new System.EventHandler(this.course_controls_textChanged);
            this.course_nm_textBox.Leave += new System.EventHandler(this.course_nm_textBox_Leave);
            // 
            // total_sem_numericUpDown
            // 
            this.total_sem_numericUpDown.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_sem_numericUpDown.Location = new System.Drawing.Point(289, 144);
            this.total_sem_numericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.total_sem_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.total_sem_numericUpDown.Name = "total_sem_numericUpDown";
            this.total_sem_numericUpDown.Size = new System.Drawing.Size(67, 27);
            this.total_sem_numericUpDown.TabIndex = 3;
            this.total_sem_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.total_sem_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // add_sem_label
            // 
            this.add_sem_label.AutoSize = true;
            this.add_sem_label.Location = new System.Drawing.Point(102, 146);
            this.add_sem_label.Name = "add_sem_label";
            this.add_sem_label.Size = new System.Drawing.Size(141, 20);
            this.add_sem_label.TabIndex = 0;
            this.add_sem_label.Text = "*Total Semester :";
            // 
            // course_nm_label
            // 
            this.course_nm_label.AutoSize = true;
            this.course_nm_label.Location = new System.Drawing.Point(102, 49);
            this.course_nm_label.Name = "course_nm_label";
            this.course_nm_label.Size = new System.Drawing.Size(138, 20);
            this.course_nm_label.TabIndex = 0;
            this.course_nm_label.Text = "*Course Name : ";
            // 
            // subject_Details_tabPage
            // 
            this.subject_Details_tabPage.BackColor = global::AD_CMS.Properties.Settings.Default.TemplateBack;
            this.subject_Details_tabPage.Controls.Add(this.subjectDetails_dataGridView);
            this.subject_Details_tabPage.Controls.Add(this.subject_details_groupBox);
            this.subject_Details_tabPage.Location = new System.Drawing.Point(4, 28);
            this.subject_Details_tabPage.Name = "subject_Details_tabPage";
            this.subject_Details_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.subject_Details_tabPage.Size = new System.Drawing.Size(1082, 622);
            this.subject_Details_tabPage.TabIndex = 1;
            this.subject_Details_tabPage.Text = "Subject Details";
            // 
            // subjectDetails_dataGridView
            // 
            this.subjectDetails_dataGridView.AllowUserToAddRows = false;
            this.subjectDetails_dataGridView.AllowUserToDeleteRows = false;
            this.subjectDetails_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subjectDetails_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectDetails_dataGridView.Location = new System.Drawing.Point(68, 292);
            this.subjectDetails_dataGridView.MultiSelect = false;
            this.subjectDetails_dataGridView.Name = "subjectDetails_dataGridView";
            this.subjectDetails_dataGridView.ReadOnly = true;
            this.subjectDetails_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectDetails_dataGridView.Size = new System.Drawing.Size(961, 304);
            this.subjectDetails_dataGridView.TabIndex = 2;
            // 
            // subject_details_groupBox
            // 
            this.subject_details_groupBox.Controls.Add(this.course_nm_comboBox);
            this.subject_details_groupBox.Controls.Add(this.course_nm2_label);
            this.subject_details_groupBox.Controls.Add(this.subject_code_textBox);
            this.subject_details_groupBox.Controls.Add(this.subject_code_label);
            this.subject_details_groupBox.Controls.Add(this.add_button2);
            this.subject_details_groupBox.Controls.Add(this.next_button2);
            this.subject_details_groupBox.Controls.Add(this.subject_nm_textBox);
            this.subject_details_groupBox.Controls.Add(this.select_sem_numericUpDown);
            this.subject_details_groupBox.Controls.Add(this.select_sem_label);
            this.subject_details_groupBox.Controls.Add(this.subject_nm_label);
            this.subject_details_groupBox.Location = new System.Drawing.Point(173, 6);
            this.subject_details_groupBox.Name = "subject_details_groupBox";
            this.subject_details_groupBox.Size = new System.Drawing.Size(736, 280);
            this.subject_details_groupBox.TabIndex = 0;
            this.subject_details_groupBox.TabStop = false;
            this.subject_details_groupBox.Text = "Subject Details ";
            // 
            // course_nm_comboBox
            // 
            this.course_nm_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course_nm_comboBox.FormattingEnabled = true;
            this.course_nm_comboBox.Location = new System.Drawing.Point(302, 34);
            this.course_nm_comboBox.Name = "course_nm_comboBox";
            this.course_nm_comboBox.Size = new System.Drawing.Size(272, 27);
            this.course_nm_comboBox.TabIndex = 0;
            this.course_nm_comboBox.SelectedIndexChanged += new System.EventHandler(this.course_nm_comboBox_SelectedIndexChanged);
            this.course_nm_comboBox.TextChanged += new System.EventHandler(this.subject_controls_textChanged);
            // 
            // course_nm2_label
            // 
            this.course_nm2_label.AutoSize = true;
            this.course_nm2_label.Location = new System.Drawing.Point(143, 37);
            this.course_nm2_label.Name = "course_nm2_label";
            this.course_nm2_label.Size = new System.Drawing.Size(138, 20);
            this.course_nm2_label.TabIndex = 22;
            this.course_nm2_label.Text = "*Course Name : ";
            // 
            // subject_code_textBox
            // 
            this.subject_code_textBox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_code_textBox.Location = new System.Drawing.Point(302, 124);
            this.subject_code_textBox.MaxLength = 3;
            this.subject_code_textBox.Name = "subject_code_textBox";
            this.subject_code_textBox.Size = new System.Drawing.Size(67, 27);
            this.subject_code_textBox.TabIndex = 2;
            this.subject_code_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.subject_code_textBox.TextChanged += new System.EventHandler(this.subject_controls_textChanged);
            // 
            // subject_code_label
            // 
            this.subject_code_label.AutoSize = true;
            this.subject_code_label.Location = new System.Drawing.Point(143, 127);
            this.subject_code_label.Name = "subject_code_label";
            this.subject_code_label.Size = new System.Drawing.Size(137, 20);
            this.subject_code_label.TabIndex = 21;
            this.subject_code_label.Text = "*Subject Code : ";
            // 
            // add_button2
            // 
            this.add_button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add_button2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button2.Location = new System.Drawing.Point(377, 215);
            this.add_button2.Name = "add_button2";
            this.add_button2.Size = new System.Drawing.Size(197, 50);
            this.add_button2.TabIndex = 5;
            this.add_button2.Text = "ADD";
            this.add_button2.UseVisualStyleBackColor = true;
            this.add_button2.Click += new System.EventHandler(this.add_button2_Click);
            // 
            // next_button2
            // 
            this.next_button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.next_button2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_button2.Location = new System.Drawing.Point(162, 215);
            this.next_button2.Name = "next_button2";
            this.next_button2.Size = new System.Drawing.Size(197, 50);
            this.next_button2.TabIndex = 4;
            this.next_button2.Text = "Next";
            this.next_button2.UseVisualStyleBackColor = true;
            this.next_button2.Click += new System.EventHandler(this.next_button2_Click);
            // 
            // subject_nm_textBox
            // 
            this.subject_nm_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.subject_nm_textBox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_nm_textBox.Location = new System.Drawing.Point(302, 78);
            this.subject_nm_textBox.Name = "subject_nm_textBox";
            this.subject_nm_textBox.Size = new System.Drawing.Size(154, 27);
            this.subject_nm_textBox.TabIndex = 1;
            this.subject_nm_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.subject_nm_textBox.TextChanged += new System.EventHandler(this.subject_controls_textChanged);
            // 
            // select_sem_numericUpDown
            // 
            this.select_sem_numericUpDown.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_sem_numericUpDown.Location = new System.Drawing.Point(302, 168);
            this.select_sem_numericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.select_sem_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.select_sem_numericUpDown.Name = "select_sem_numericUpDown";
            this.select_sem_numericUpDown.Size = new System.Drawing.Size(67, 27);
            this.select_sem_numericUpDown.TabIndex = 3;
            this.select_sem_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.select_sem_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // select_sem_label
            // 
            this.select_sem_label.AutoSize = true;
            this.select_sem_label.Location = new System.Drawing.Point(143, 170);
            this.select_sem_label.Name = "select_sem_label";
            this.select_sem_label.Size = new System.Drawing.Size(147, 20);
            this.select_sem_label.TabIndex = 15;
            this.select_sem_label.Text = "*Select Semester :";
            // 
            // subject_nm_label
            // 
            this.subject_nm_label.AutoSize = true;
            this.subject_nm_label.Location = new System.Drawing.Point(143, 78);
            this.subject_nm_label.Name = "subject_nm_label";
            this.subject_nm_label.Size = new System.Drawing.Size(141, 20);
            this.subject_nm_label.TabIndex = 16;
            this.subject_nm_label.Text = "*Subject Name : ";
            // 
            // course_fee_details_tabPage
            // 
            this.course_fee_details_tabPage.BackColor = global::AD_CMS.Properties.Settings.Default.TemplateBack;
            this.course_fee_details_tabPage.Controls.Add(this.courseFee_dataGridView);
            this.course_fee_details_tabPage.Controls.Add(this.course_fee_details_groupBox);
            this.course_fee_details_tabPage.Location = new System.Drawing.Point(4, 28);
            this.course_fee_details_tabPage.Name = "course_fee_details_tabPage";
            this.course_fee_details_tabPage.Size = new System.Drawing.Size(1082, 622);
            this.course_fee_details_tabPage.TabIndex = 2;
            this.course_fee_details_tabPage.Text = "Course Fee Details ";
            // 
            // courseFee_dataGridView
            // 
            this.courseFee_dataGridView.AllowUserToAddRows = false;
            this.courseFee_dataGridView.AllowUserToDeleteRows = false;
            this.courseFee_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseFee_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseFee_dataGridView.Location = new System.Drawing.Point(87, 289);
            this.courseFee_dataGridView.MultiSelect = false;
            this.courseFee_dataGridView.Name = "courseFee_dataGridView";
            this.courseFee_dataGridView.ReadOnly = true;
            this.courseFee_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseFee_dataGridView.Size = new System.Drawing.Size(961, 304);
            this.courseFee_dataGridView.TabIndex = 3;
            // 
            // course_fee_details_groupBox
            // 
            this.course_fee_details_groupBox.Controls.Add(this.label1);
            this.course_fee_details_groupBox.Controls.Add(this.instruction_label2);
            this.course_fee_details_groupBox.Controls.Add(this.instruction_label);
            this.course_fee_details_groupBox.Controls.Add(this.total_fee_label);
            this.course_fee_details_groupBox.Controls.Add(this.total_fee_textBox);
            this.course_fee_details_groupBox.Controls.Add(this.label11);
            this.course_fee_details_groupBox.Controls.Add(this.set_fee_textBox);
            this.course_fee_details_groupBox.Controls.Add(this.select_course_comboBox);
            this.course_fee_details_groupBox.Controls.Add(this.clear_button);
            this.course_fee_details_groupBox.Controls.Add(this.save_button);
            this.course_fee_details_groupBox.Controls.Add(this.set_fee_label);
            this.course_fee_details_groupBox.Controls.Add(this.select_course_label);
            this.course_fee_details_groupBox.Location = new System.Drawing.Point(174, 13);
            this.course_fee_details_groupBox.Name = "course_fee_details_groupBox";
            this.course_fee_details_groupBox.Size = new System.Drawing.Size(736, 246);
            this.course_fee_details_groupBox.TabIndex = 0;
            this.course_fee_details_groupBox.TabStop = false;
            this.course_fee_details_groupBox.Text = "*Course Fee Details ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Rs.";
            // 
            // instruction_label2
            // 
            this.instruction_label2.AutoSize = true;
            this.instruction_label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction_label2.Location = new System.Drawing.Point(496, 146);
            this.instruction_label2.Name = "instruction_label2";
            this.instruction_label2.Size = new System.Drawing.Size(0, 16);
            this.instruction_label2.TabIndex = 27;
            // 
            // instruction_label
            // 
            this.instruction_label.AutoSize = true;
            this.instruction_label.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction_label.Location = new System.Drawing.Point(479, 94);
            this.instruction_label.Name = "instruction_label";
            this.instruction_label.Size = new System.Drawing.Size(72, 16);
            this.instruction_label.TabIndex = 27;
            this.instruction_label.Text = "[ per year ]";
            // 
            // total_fee_label
            // 
            this.total_fee_label.AutoSize = true;
            this.total_fee_label.Location = new System.Drawing.Point(151, 147);
            this.total_fee_label.Name = "total_fee_label";
            this.total_fee_label.Size = new System.Drawing.Size(94, 20);
            this.total_fee_label.TabIndex = 25;
            this.total_fee_label.Text = "Total Fee : ";
            // 
            // total_fee_textBox
            // 
            this.total_fee_textBox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_fee_textBox.Location = new System.Drawing.Point(295, 140);
            this.total_fee_textBox.Name = "total_fee_textBox";
            this.total_fee_textBox.ReadOnly = true;
            this.total_fee_textBox.Size = new System.Drawing.Size(159, 27);
            this.total_fee_textBox.TabIndex = 2;
            this.total_fee_textBox.Text = "0";
            this.total_fee_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(439, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Rs.";
            // 
            // set_fee_textBox
            // 
            this.set_fee_textBox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_fee_textBox.Location = new System.Drawing.Point(295, 87);
            this.set_fee_textBox.MaxLength = 7;
            this.set_fee_textBox.Name = "set_fee_textBox";
            this.set_fee_textBox.Size = new System.Drawing.Size(143, 27);
            this.set_fee_textBox.TabIndex = 1;
            this.set_fee_textBox.Text = "0";
            this.set_fee_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.set_fee_textBox.TextChanged += new System.EventHandler(this.coursefee_control_textChanged);
            // 
            // select_course_comboBox
            // 
            this.select_course_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_course_comboBox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_course_comboBox.FormattingEnabled = true;
            this.select_course_comboBox.Location = new System.Drawing.Point(296, 35);
            this.select_course_comboBox.Name = "select_course_comboBox";
            this.select_course_comboBox.Size = new System.Drawing.Size(255, 27);
            this.select_course_comboBox.TabIndex = 0;
            this.select_course_comboBox.SelectedIndexChanged += new System.EventHandler(this.select_course_comboBox_SelectedIndexChanged);
            this.select_course_comboBox.TextChanged += new System.EventHandler(this.coursefee_control_textChanged);
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(416, 188);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(197, 44);
            this.clear_button.TabIndex = 4;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(119, 188);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(197, 44);
            this.save_button.TabIndex = 3;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // set_fee_label
            // 
            this.set_fee_label.AutoSize = true;
            this.set_fee_label.Location = new System.Drawing.Point(151, 90);
            this.set_fee_label.Name = "set_fee_label";
            this.set_fee_label.Size = new System.Drawing.Size(79, 20);
            this.set_fee_label.TabIndex = 15;
            this.set_fee_label.Text = "Set Fee : ";
            // 
            // select_course_label
            // 
            this.select_course_label.AutoSize = true;
            this.select_course_label.Location = new System.Drawing.Point(136, 35);
            this.select_course_label.Name = "select_course_label";
            this.select_course_label.Size = new System.Drawing.Size(129, 20);
            this.select_course_label.TabIndex = 16;
            this.select_course_label.Text = "Select Course : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(261, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(561, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "[Must Set The Fees of New Course, Otherwise It Will Not Display AnyWhere in Softw" +
                "are]";
            // 
            // AddNewCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "AddNewCourses";
            this.Text = "AddNewCourses";
            this.Load += new System.EventHandler(this.AddNewCourses_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.add_new_course_tabControl.ResumeLayout(false);
            this.course_Details_tabPage.ResumeLayout(false);
            this.course_Details_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDetails_dataGridView)).EndInit();
            this.add_course_groupBox.ResumeLayout(false);
            this.add_course_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.total_sem_numericUpDown)).EndInit();
            this.subject_Details_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subjectDetails_dataGridView)).EndInit();
            this.subject_details_groupBox.ResumeLayout(false);
            this.subject_details_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_sem_numericUpDown)).EndInit();
            this.course_fee_details_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseFee_dataGridView)).EndInit();
            this.course_fee_details_groupBox.ResumeLayout(false);
            this.course_fee_details_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl add_new_course_tabControl;
        private System.Windows.Forms.TabPage course_Details_tabPage;
        private System.Windows.Forms.GroupBox add_course_groupBox;
        private System.Windows.Forms.Label add_sem_label;
        private System.Windows.Forms.Label course_nm_label;
        private System.Windows.Forms.TabPage subject_Details_tabPage;
        private System.Windows.Forms.TabPage course_fee_details_tabPage;
        private CustomControl.UpperTextBox course_nm_textBox;
        private System.Windows.Forms.NumericUpDown total_sem_numericUpDown;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.GroupBox subject_details_groupBox;
        private CustomControl.NumericTextBox subject_code_textBox;
        private System.Windows.Forms.Label subject_code_label;
        private System.Windows.Forms.Button add_button2;
        private System.Windows.Forms.Button next_button2;
        private CustomControl.UpperTextBox subject_nm_textBox;
        private System.Windows.Forms.NumericUpDown select_sem_numericUpDown;
        private System.Windows.Forms.Label select_sem_label;
        private System.Windows.Forms.Label subject_nm_label;
        private System.Windows.Forms.GroupBox course_fee_details_groupBox;
        private System.Windows.Forms.Label label11;
        private CustomControl.NumericTextBox set_fee_textBox;
        private System.Windows.Forms.ComboBox select_course_comboBox;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label set_fee_label;
        private System.Windows.Forms.Label select_course_label;
        private System.Windows.Forms.Label total_fee_label;
        private System.Windows.Forms.TextBox total_fee_textBox;
        private System.Windows.Forms.Label instruction_label;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.CheckBox As_per_name_checkBox;
        private System.Windows.Forms.TextBox course_nm_alias_textBox;
        private System.Windows.Forms.Label course_nm_alias_label;
        private System.Windows.Forms.Label course_nm2_label;
        private System.Windows.Forms.ComboBox course_nm_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView subjectDetails_dataGridView;
        private System.Windows.Forms.Label instruction_label2;
        private System.Windows.Forms.DataGridView CourseDetails_dataGridView;
        private System.Windows.Forms.DataGridView courseFee_dataGridView;
        private System.Windows.Forms.Label label2;

    }
}