namespace AD_CMS
{
    partial class MainForm
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


        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel upper_panel;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TableLayoutPanel top_tableLayoutPanel;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.LinkLabel developer_mail_label;
        private System.Windows.Forms.Label developer_no_label;
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sidebar_panel = new System.Windows.Forms.Panel();
            this.left_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.admin_section_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.collegedetails_button = new System.Windows.Forms.Button();
            this.attendance = new System.Windows.Forms.Button();
            this.financedept_button = new System.Windows.Forms.Button();
            this.department_button = new System.Windows.Forms.Button();
            this.courses_button = new System.Windows.Forms.Button();
            this.staffmgmt_button = new System.Windows.Forms.Button();
            this.studentmgmt_button = new System.Windows.Forms.Button();
            this.Library_Management = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernm_label = new System.Windows.Forms.Label();
            this.user_pictureBox = new System.Windows.Forms.PictureBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.upper_panel = new System.Windows.Forms.Panel();
            this.top_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logout_button = new System.Windows.Forms.Button();
            this.developer_mail_label = new System.Windows.Forms.LinkLabel();
            this.developer_no_label = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.masterpanel = new System.Windows.Forms.Panel();
            this.sidebar_panel.SuspendLayout();
            this.left_tableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox)).BeginInit();
            this.upper_panel.SuspendLayout();
            this.top_tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.sidebar_panel.Controls.Add(this.left_tableLayoutPanel);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(255, 742);
            this.sidebar_panel.TabIndex = 0;
            // 
            // left_tableLayoutPanel
            // 
            this.left_tableLayoutPanel.BackColor = System.Drawing.Color.SeaShell;
            this.left_tableLayoutPanel.ColumnCount = 1;
            this.left_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.left_tableLayoutPanel.Controls.Add(this.admin_section_button, 0, 10);
            this.left_tableLayoutPanel.Controls.Add(this.home_button, 0, 1);
            this.left_tableLayoutPanel.Controls.Add(this.exit_button, 0, 11);
            this.left_tableLayoutPanel.Controls.Add(this.collegedetails_button, 0, 9);
            this.left_tableLayoutPanel.Controls.Add(this.attendance, 0, 7);
            this.left_tableLayoutPanel.Controls.Add(this.financedept_button, 0, 6);
            this.left_tableLayoutPanel.Controls.Add(this.department_button, 0, 5);
            this.left_tableLayoutPanel.Controls.Add(this.courses_button, 0, 4);
            this.left_tableLayoutPanel.Controls.Add(this.staffmgmt_button, 0, 3);
            this.left_tableLayoutPanel.Controls.Add(this.studentmgmt_button, 0, 2);
            this.left_tableLayoutPanel.Controls.Add(this.Library_Management, 0, 8);
            this.left_tableLayoutPanel.Controls.Add(this.panel1, 0, 0);
            this.left_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.left_tableLayoutPanel.Name = "left_tableLayoutPanel";
            this.left_tableLayoutPanel.RowCount = 12;
            this.left_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.63754F));
            this.left_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.425062F));
            this.left_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.450335F));
            this.left_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.450335F));
            this.left_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.450335F));
            this.left_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.450335F));
            this.left_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.450335F));
            this.left_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.450335F));
            this.left_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.884012F));
            this.left_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.450335F));
            this.left_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.450697F));
            this.left_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.450335F));
            this.left_tableLayoutPanel.Size = new System.Drawing.Size(255, 742);
            this.left_tableLayoutPanel.TabIndex = 0;
            // 
            // admin_section_button
            // 
            this.admin_section_button.BackColor = System.Drawing.Color.Transparent;
            this.admin_section_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_section_button.FlatAppearance.BorderSize = 0;
            this.admin_section_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.admin_section_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_section_button.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_section_button.ForeColor = System.Drawing.Color.Black;
            this.admin_section_button.Location = new System.Drawing.Point(0, 639);
            this.admin_section_button.Margin = new System.Windows.Forms.Padding(0);
            this.admin_section_button.Name = "admin_section_button";
            this.admin_section_button.Size = new System.Drawing.Size(255, 47);
            this.admin_section_button.TabIndex = 9;
            this.admin_section_button.TabStop = false;
            this.admin_section_button.Text = "Admin Section";
            this.admin_section_button.UseVisualStyleBackColor = false;
            this.admin_section_button.Click += new System.EventHandler(this.admin_section_button_Click);
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.Color.Transparent;
            this.home_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_button.FlatAppearance.BorderSize = 0;
            this.home_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button.Image = global::AD_CMS.Properties.Resources.home2_32;
            this.home_button.Location = new System.Drawing.Point(0, 212);
            this.home_button.Margin = new System.Windows.Forms.Padding(0);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(255, 47);
            this.home_button.TabIndex = 0;
            this.home_button.Text = "Home";
            this.home_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.home_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.home_button.UseVisualStyleBackColor = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.Black;
            this.exit_button.Location = new System.Drawing.Point(0, 686);
            this.exit_button.Margin = new System.Windows.Forms.Padding(0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(255, 56);
            this.exit_button.TabIndex = 11;
            this.exit_button.TabStop = false;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // collegedetails_button
            // 
            this.collegedetails_button.BackColor = System.Drawing.Color.Transparent;
            this.collegedetails_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collegedetails_button.FlatAppearance.BorderSize = 0;
            this.collegedetails_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.collegedetails_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collegedetails_button.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collegedetails_button.ForeColor = System.Drawing.Color.Black;
            this.collegedetails_button.Location = new System.Drawing.Point(0, 592);
            this.collegedetails_button.Margin = new System.Windows.Forms.Padding(0);
            this.collegedetails_button.Name = "collegedetails_button";
            this.collegedetails_button.Size = new System.Drawing.Size(255, 47);
            this.collegedetails_button.TabIndex = 8;
            this.collegedetails_button.TabStop = false;
            this.collegedetails_button.Text = "College Details";
            this.collegedetails_button.UseVisualStyleBackColor = false;
            this.collegedetails_button.Click += new System.EventHandler(this.collegedetails_button_Click);
            // 
            // attendance
            // 
            this.attendance.BackColor = System.Drawing.Color.Transparent;
            this.attendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendance.FlatAppearance.BorderSize = 0;
            this.attendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attendance.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendance.ForeColor = System.Drawing.Color.Black;
            this.attendance.Location = new System.Drawing.Point(0, 494);
            this.attendance.Margin = new System.Windows.Forms.Padding(0);
            this.attendance.Name = "attendance";
            this.attendance.Size = new System.Drawing.Size(255, 47);
            this.attendance.TabIndex = 6;
            this.attendance.TabStop = false;
            this.attendance.Text = "Attendance";
            this.attendance.UseVisualStyleBackColor = false;
            this.attendance.Click += new System.EventHandler(this.attendance_Click);
            // 
            // financedept_button
            // 
            this.financedept_button.BackColor = System.Drawing.Color.Transparent;
            this.financedept_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financedept_button.FlatAppearance.BorderSize = 0;
            this.financedept_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.financedept_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.financedept_button.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financedept_button.ForeColor = System.Drawing.Color.Black;
            this.financedept_button.Location = new System.Drawing.Point(0, 447);
            this.financedept_button.Margin = new System.Windows.Forms.Padding(0);
            this.financedept_button.Name = "financedept_button";
            this.financedept_button.Size = new System.Drawing.Size(255, 47);
            this.financedept_button.TabIndex = 5;
            this.financedept_button.TabStop = false;
            this.financedept_button.Text = "Finance Department";
            this.financedept_button.UseVisualStyleBackColor = false;
            this.financedept_button.Click += new System.EventHandler(this.finance_button_Click);
            // 
            // department_button
            // 
            this.department_button.BackColor = System.Drawing.Color.Transparent;
            this.department_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.department_button.FlatAppearance.BorderSize = 0;
            this.department_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.department_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.department_button.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_button.ForeColor = System.Drawing.Color.Black;
            this.department_button.Location = new System.Drawing.Point(0, 400);
            this.department_button.Margin = new System.Windows.Forms.Padding(0);
            this.department_button.Name = "department_button";
            this.department_button.Size = new System.Drawing.Size(255, 47);
            this.department_button.TabIndex = 4;
            this.department_button.TabStop = false;
            this.department_button.Text = "Department";
            this.department_button.UseVisualStyleBackColor = false;
            this.department_button.Click += new System.EventHandler(this.department_button_Click);
            // 
            // courses_button
            // 
            this.courses_button.BackColor = System.Drawing.Color.Transparent;
            this.courses_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courses_button.FlatAppearance.BorderSize = 0;
            this.courses_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.courses_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courses_button.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courses_button.ForeColor = System.Drawing.Color.Black;
            this.courses_button.Location = new System.Drawing.Point(0, 353);
            this.courses_button.Margin = new System.Windows.Forms.Padding(0);
            this.courses_button.Name = "courses_button";
            this.courses_button.Size = new System.Drawing.Size(255, 47);
            this.courses_button.TabIndex = 3;
            this.courses_button.TabStop = false;
            this.courses_button.Text = "Courses";
            this.courses_button.UseVisualStyleBackColor = false;
            this.courses_button.Click += new System.EventHandler(this.course_button_Click);
            // 
            // staffmgmt_button
            // 
            this.staffmgmt_button.BackColor = System.Drawing.Color.Transparent;
            this.staffmgmt_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffmgmt_button.FlatAppearance.BorderSize = 0;
            this.staffmgmt_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.staffmgmt_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffmgmt_button.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffmgmt_button.ForeColor = System.Drawing.Color.Black;
            this.staffmgmt_button.Location = new System.Drawing.Point(0, 306);
            this.staffmgmt_button.Margin = new System.Windows.Forms.Padding(0);
            this.staffmgmt_button.Name = "staffmgmt_button";
            this.staffmgmt_button.Size = new System.Drawing.Size(255, 47);
            this.staffmgmt_button.TabIndex = 2;
            this.staffmgmt_button.TabStop = false;
            this.staffmgmt_button.Text = "Staff Management";
            this.staffmgmt_button.UseVisualStyleBackColor = false;
            this.staffmgmt_button.Click += new System.EventHandler(this.employee_button_Click);
            // 
            // studentmgmt_button
            // 
            this.studentmgmt_button.BackColor = System.Drawing.Color.Transparent;
            this.studentmgmt_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentmgmt_button.FlatAppearance.BorderSize = 0;
            this.studentmgmt_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.studentmgmt_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentmgmt_button.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentmgmt_button.ForeColor = System.Drawing.Color.Black;
            this.studentmgmt_button.Location = new System.Drawing.Point(0, 259);
            this.studentmgmt_button.Margin = new System.Windows.Forms.Padding(0);
            this.studentmgmt_button.Name = "studentmgmt_button";
            this.studentmgmt_button.Size = new System.Drawing.Size(255, 47);
            this.studentmgmt_button.TabIndex = 1;
            this.studentmgmt_button.TabStop = false;
            this.studentmgmt_button.Text = "Student Management";
            this.studentmgmt_button.UseVisualStyleBackColor = false;
            this.studentmgmt_button.Click += new System.EventHandler(this.Studentmgmt_button_Click);
            // 
            // Library_Management
            // 
            this.Library_Management.BackColor = System.Drawing.Color.Transparent;
            this.Library_Management.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Library_Management.FlatAppearance.BorderSize = 0;
            this.Library_Management.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Library_Management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Library_Management.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Library_Management.ForeColor = System.Drawing.Color.Black;
            this.Library_Management.Location = new System.Drawing.Point(0, 541);
            this.Library_Management.Margin = new System.Windows.Forms.Padding(0);
            this.Library_Management.Name = "Library_Management";
            this.Library_Management.Size = new System.Drawing.Size(255, 51);
            this.Library_Management.TabIndex = 7;
            this.Library_Management.Text = "Library Management";
            this.Library_Management.UseVisualStyleBackColor = false;
            this.Library_Management.Click += new System.EventHandler(this.Library_Management_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.usernm_label);
            this.panel1.Controls.Add(this.user_pictureBox);
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 206);
            this.panel1.TabIndex = 12;
            // 
            // usernm_label
            // 
            this.usernm_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usernm_label.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernm_label.Location = new System.Drawing.Point(0, 139);
            this.usernm_label.Name = "usernm_label";
            this.usernm_label.Size = new System.Drawing.Size(249, 65);
            this.usernm_label.TabIndex = 2;
            this.usernm_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // user_pictureBox
            // 
            this.user_pictureBox.Image = global::AD_CMS.Properties.Resources.userProfile;
            this.user_pictureBox.Location = new System.Drawing.Point(76, 33);
            this.user_pictureBox.Name = "user_pictureBox";
            this.user_pictureBox.Size = new System.Drawing.Size(96, 96);
            this.user_pictureBox.TabIndex = 1;
            this.user_pictureBox.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.Black;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Location = new System.Drawing.Point(0, 204);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(249, 2);
            this.splitter3.TabIndex = 0;
            this.splitter3.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(255, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 742);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            this.splitter1.Visible = false;
            // 
            // upper_panel
            // 
            this.upper_panel.BackColor = System.Drawing.Color.SeaShell;
            this.upper_panel.Controls.Add(this.top_tableLayoutPanel);
            this.upper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upper_panel.ForeColor = System.Drawing.Color.Black;
            this.upper_panel.Location = new System.Drawing.Point(258, 0);
            this.upper_panel.Name = "upper_panel";
            this.upper_panel.Size = new System.Drawing.Size(1106, 42);
            this.upper_panel.TabIndex = 2;
            // 
            // top_tableLayoutPanel
            // 
            this.top_tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.top_tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.top_tableLayoutPanel.ColumnCount = 3;
            this.top_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.721F));
            this.top_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.73668F));
            this.top_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.top_tableLayoutPanel.Controls.Add(this.logout_button, 2, 0);
            this.top_tableLayoutPanel.Controls.Add(this.developer_mail_label, 1, 0);
            this.top_tableLayoutPanel.Controls.Add(this.developer_no_label, 0, 0);
            this.top_tableLayoutPanel.Location = new System.Drawing.Point(469, 0);
            this.top_tableLayoutPanel.Name = "top_tableLayoutPanel";
            this.top_tableLayoutPanel.RowCount = 1;
            this.top_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.top_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.top_tableLayoutPanel.Size = new System.Drawing.Size(638, 45);
            this.top_tableLayoutPanel.TabIndex = 0;
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.SkyBlue;
            this.logout_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.logout_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logout_button.FlatAppearance.BorderSize = 0;
            this.logout_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.ForeColor = System.Drawing.Color.Crimson;
            this.logout_button.Location = new System.Drawing.Point(424, 0);
            this.logout_button.Margin = new System.Windows.Forms.Padding(0);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(214, 45);
            this.logout_button.TabIndex = 0;
            this.logout_button.TabStop = false;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // developer_mail_label
            // 
            this.developer_mail_label.AutoSize = true;
            this.developer_mail_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.developer_mail_label.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developer_mail_label.ForeColor = System.Drawing.Color.Black;
            this.developer_mail_label.LinkColor = System.Drawing.Color.Black;
            this.developer_mail_label.Location = new System.Drawing.Point(199, 0);
            this.developer_mail_label.Name = "developer_mail_label";
            this.developer_mail_label.Size = new System.Drawing.Size(222, 45);
            this.developer_mail_label.TabIndex = 1;
            this.developer_mail_label.TabStop = true;
            this.developer_mail_label.Text = "ADCMS@gmail.com";
            this.developer_mail_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // developer_no_label
            // 
            this.developer_no_label.AutoSize = true;
            this.developer_no_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.developer_no_label.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developer_no_label.Location = new System.Drawing.Point(3, 0);
            this.developer_no_label.Name = "developer_no_label";
            this.developer_no_label.Size = new System.Drawing.Size(190, 45);
            this.developer_no_label.TabIndex = 2;
            this.developer_no_label.Text = "(+91)0123456789";
            this.developer_no_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(258, 42);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1106, 3);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            this.splitter2.Visible = false;
            // 
            // masterpanel
            // 
            this.masterpanel.BackColor = System.Drawing.Color.SkyBlue;
            this.masterpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterpanel.Location = new System.Drawing.Point(258, 45);
            this.masterpanel.Name = "masterpanel";
            this.masterpanel.Size = new System.Drawing.Size(1106, 697);
            this.masterpanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.logout_button;
            this.ClientSize = new System.Drawing.Size(1364, 742);
            this.Controls.Add(this.masterpanel);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.upper_panel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.sidebar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AD - College Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.sidebar_panel.ResumeLayout(false);
            this.left_tableLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox)).EndInit();
            this.upper_panel.ResumeLayout(false);
            this.top_tableLayoutPanel.ResumeLayout(false);
            this.top_tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel masterpanel;
        private System.Windows.Forms.TableLayoutPanel left_tableLayoutPanel;
        public System.Windows.Forms.Button collegedetails_button;
        public System.Windows.Forms.Button attendance;
        public System.Windows.Forms.Button financedept_button;
        public System.Windows.Forms.Button department_button;
        public System.Windows.Forms.Button courses_button;
        public System.Windows.Forms.Button staffmgmt_button;
        public System.Windows.Forms.Button studentmgmt_button;
        public System.Windows.Forms.Button Library_Management;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button exit_button;
        public System.Windows.Forms.Button admin_section_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Label usernm_label;
        private System.Windows.Forms.PictureBox user_pictureBox;

    }
}