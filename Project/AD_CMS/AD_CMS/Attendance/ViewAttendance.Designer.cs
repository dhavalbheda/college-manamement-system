namespace AD_CMS.Attendance
{
    partial class ViewAttendance
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
            this.search_groupBox = new System.Windows.Forms.GroupBox();
            this.download_button = new System.Windows.Forms.Button();
            this.filter_enable_button = new System.Windows.Forms.Button();
            this.view_button = new System.Windows.Forms.Button();
            this.select_sem_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.select_month_comboBox = new System.Windows.Forms.ComboBox();
            this.select_batch_comboBox = new System.Windows.Forms.ComboBox();
            this.select_dept_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.attendance_dataGridView = new System.Windows.Forms.DataGridView();
            this.filter_groupBox = new System.Windows.Forms.GroupBox();
            this.stud_TextBox = new System.Windows.Forms.TextBox();
            this.enable_attendance_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.a_numericTextBox = new CustomControl.NumericTextBox();
            this.p_numericTextBox = new CustomControl.NumericTextBox();
            this.total_numericTextBox = new CustomControl.NumericTextBox();
            this.select_date_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.date_radioButton = new System.Windows.Forms.RadioButton();
            this.name_radioButton = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.search_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_sem_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_dataGridView)).BeginInit();
            this.filter_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_date_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(353, 5);
            this.heading_label.Size = new System.Drawing.Size(409, 38);
            this.heading_label.Text = "View Attendance Sheet";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.filter_groupBox);
            this.contentarea_panel.Controls.Add(this.attendance_dataGridView);
            this.contentarea_panel.Controls.Add(this.search_groupBox);
            this.contentarea_panel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // search_groupBox
            // 
            this.search_groupBox.Controls.Add(this.download_button);
            this.search_groupBox.Controls.Add(this.filter_enable_button);
            this.search_groupBox.Controls.Add(this.view_button);
            this.search_groupBox.Controls.Add(this.select_sem_numericUpDown);
            this.search_groupBox.Controls.Add(this.label5);
            this.search_groupBox.Controls.Add(this.label2);
            this.search_groupBox.Controls.Add(this.select_month_comboBox);
            this.search_groupBox.Controls.Add(this.select_batch_comboBox);
            this.search_groupBox.Controls.Add(this.select_dept_comboBox);
            this.search_groupBox.Controls.Add(this.label3);
            this.search_groupBox.Controls.Add(this.label1);
            this.search_groupBox.Location = new System.Drawing.Point(31, 22);
            this.search_groupBox.Name = "search_groupBox";
            this.search_groupBox.Size = new System.Drawing.Size(581, 164);
            this.search_groupBox.TabIndex = 0;
            this.search_groupBox.TabStop = false;
            this.search_groupBox.Text = "*Attendance Details";
            // 
            // download_button
            // 
            this.download_button.Enabled = false;
            this.download_button.Location = new System.Drawing.Point(357, 86);
            this.download_button.Name = "download_button";
            this.download_button.Size = new System.Drawing.Size(202, 52);
            this.download_button.TabIndex = 6;
            this.download_button.Text = "Download Attendance";
            this.download_button.UseVisualStyleBackColor = true;
            this.download_button.Click += new System.EventHandler(this.download_button_Click);
            // 
            // filter_enable_button
            // 
            this.filter_enable_button.Enabled = false;
            this.filter_enable_button.Location = new System.Drawing.Point(461, 21);
            this.filter_enable_button.Name = "filter_enable_button";
            this.filter_enable_button.Size = new System.Drawing.Size(98, 52);
            this.filter_enable_button.TabIndex = 5;
            this.filter_enable_button.Text = "Enable Filtering";
            this.filter_enable_button.UseVisualStyleBackColor = true;
            this.filter_enable_button.Click += new System.EventHandler(this.filter_enable_button_Click);
            // 
            // view_button
            // 
            this.view_button.Location = new System.Drawing.Point(357, 23);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(98, 52);
            this.view_button.TabIndex = 4;
            this.view_button.Text = "View Attendance";
            this.view_button.UseVisualStyleBackColor = true;
            this.view_button.Click += new System.EventHandler(this.view_button_Click);
            // 
            // select_sem_numericUpDown
            // 
            this.select_sem_numericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_sem_numericUpDown.Location = new System.Drawing.Point(157, 56);
            this.select_sem_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.select_sem_numericUpDown.Name = "select_sem_numericUpDown";
            this.select_sem_numericUpDown.Size = new System.Drawing.Size(53, 26);
            this.select_sem_numericUpDown.TabIndex = 1;
            this.select_sem_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.select_sem_numericUpDown.ValueChanged += new System.EventHandler(this.select_sem_numericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select Month : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Semester : ";
            // 
            // select_month_comboBox
            // 
            this.select_month_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_month_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_month_comboBox.FormattingEnabled = true;
            this.select_month_comboBox.Items.AddRange(new object[] {
            "JANUARY",
            "FEBRUARY",
            "MARCH",
            "APRIL",
            "MAY",
            "JUNE",
            "JULY",
            "AUGUST",
            "SEPTEMBER",
            "OCTOBER",
            "NOVEMBER",
            "DECEMBER"});
            this.select_month_comboBox.Location = new System.Drawing.Point(157, 88);
            this.select_month_comboBox.Name = "select_month_comboBox";
            this.select_month_comboBox.Size = new System.Drawing.Size(169, 27);
            this.select_month_comboBox.TabIndex = 2;
            this.select_month_comboBox.SelectedIndexChanged += new System.EventHandler(this.select_month_comboBox_SelectedIndexChanged);
            // 
            // select_batch_comboBox
            // 
            this.select_batch_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_batch_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_batch_comboBox.FormattingEnabled = true;
            this.select_batch_comboBox.Location = new System.Drawing.Point(157, 121);
            this.select_batch_comboBox.Name = "select_batch_comboBox";
            this.select_batch_comboBox.Size = new System.Drawing.Size(149, 27);
            this.select_batch_comboBox.TabIndex = 3;
            this.select_batch_comboBox.SelectedIndexChanged += new System.EventHandler(this.select_batch_comboBox_SelectedIndexChanged);
            // 
            // select_dept_comboBox
            // 
            this.select_dept_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_dept_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_dept_comboBox.FormattingEnabled = true;
            this.select_dept_comboBox.Location = new System.Drawing.Point(157, 23);
            this.select_dept_comboBox.Name = "select_dept_comboBox";
            this.select_dept_comboBox.Size = new System.Drawing.Size(183, 27);
            this.select_dept_comboBox.TabIndex = 0;
            this.select_dept_comboBox.SelectedIndexChanged += new System.EventHandler(this.select_dept_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select Batch Year : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Department : ";
            // 
            // attendance_dataGridView
            // 
            this.attendance_dataGridView.AllowUserToAddRows = false;
            this.attendance_dataGridView.AllowUserToDeleteRows = false;
            this.attendance_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendance_dataGridView.Location = new System.Drawing.Point(19, 192);
            this.attendance_dataGridView.MultiSelect = false;
            this.attendance_dataGridView.Name = "attendance_dataGridView";
            this.attendance_dataGridView.ReadOnly = true;
            this.attendance_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.attendance_dataGridView.Size = new System.Drawing.Size(1052, 434);
            this.attendance_dataGridView.TabIndex = 2;
            // 
            // filter_groupBox
            // 
            this.filter_groupBox.Controls.Add(this.stud_TextBox);
            this.filter_groupBox.Controls.Add(this.enable_attendance_button);
            this.filter_groupBox.Controls.Add(this.clear_button);
            this.filter_groupBox.Controls.Add(this.label6);
            this.filter_groupBox.Controls.Add(this.a_numericTextBox);
            this.filter_groupBox.Controls.Add(this.p_numericTextBox);
            this.filter_groupBox.Controls.Add(this.total_numericTextBox);
            this.filter_groupBox.Controls.Add(this.select_date_numericUpDown);
            this.filter_groupBox.Controls.Add(this.date_radioButton);
            this.filter_groupBox.Controls.Add(this.name_radioButton);
            this.filter_groupBox.Controls.Add(this.label9);
            this.filter_groupBox.Controls.Add(this.label8);
            this.filter_groupBox.Controls.Add(this.label7);
            this.filter_groupBox.Controls.Add(this.label4);
            this.filter_groupBox.Enabled = false;
            this.filter_groupBox.Location = new System.Drawing.Point(618, 22);
            this.filter_groupBox.Name = "filter_groupBox";
            this.filter_groupBox.Size = new System.Drawing.Size(453, 164);
            this.filter_groupBox.TabIndex = 3;
            this.filter_groupBox.TabStop = false;
            this.filter_groupBox.Text = "Filter && Details";
            // 
            // stud_TextBox
            // 
            this.stud_TextBox.Location = new System.Drawing.Point(122, 116);
            this.stud_TextBox.Name = "stud_TextBox";
            this.stud_TextBox.Size = new System.Drawing.Size(128, 27);
            this.stud_TextBox.TabIndex = 9;
            this.stud_TextBox.Visible = false;
            this.stud_TextBox.TextChanged += new System.EventHandler(this.stud_TextBox_TextChanged);
            // 
            // enable_attendance_button
            // 
            this.enable_attendance_button.Location = new System.Drawing.Point(337, 108);
            this.enable_attendance_button.Name = "enable_attendance_button";
            this.enable_attendance_button.Size = new System.Drawing.Size(110, 50);
            this.enable_attendance_button.TabIndex = 8;
            this.enable_attendance_button.Text = "Enable Attendance";
            this.enable_attendance_button.UseVisualStyleBackColor = true;
            this.enable_attendance_button.Click += new System.EventHandler(this.enable_attendance_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(256, 115);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 26);
            this.clear_button.TabIndex = 8;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Visible = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Find Student : ";
            this.label6.Visible = false;
            // 
            // a_numericTextBox
            // 
            this.a_numericTextBox.Location = new System.Drawing.Point(382, 75);
            this.a_numericTextBox.MaxLength = 10;
            this.a_numericTextBox.Name = "a_numericTextBox";
            this.a_numericTextBox.ReadOnly = true;
            this.a_numericTextBox.Size = new System.Drawing.Size(44, 27);
            this.a_numericTextBox.TabIndex = 3;
            this.a_numericTextBox.TabStop = false;
            // 
            // p_numericTextBox
            // 
            this.p_numericTextBox.Location = new System.Drawing.Point(263, 76);
            this.p_numericTextBox.MaxLength = 10;
            this.p_numericTextBox.Name = "p_numericTextBox";
            this.p_numericTextBox.ReadOnly = true;
            this.p_numericTextBox.Size = new System.Drawing.Size(44, 27);
            this.p_numericTextBox.TabIndex = 3;
            this.p_numericTextBox.TabStop = false;
            // 
            // total_numericTextBox
            // 
            this.total_numericTextBox.Location = new System.Drawing.Point(130, 74);
            this.total_numericTextBox.MaxLength = 10;
            this.total_numericTextBox.Name = "total_numericTextBox";
            this.total_numericTextBox.ReadOnly = true;
            this.total_numericTextBox.Size = new System.Drawing.Size(44, 27);
            this.total_numericTextBox.TabIndex = 3;
            this.total_numericTextBox.TabStop = false;
            // 
            // select_date_numericUpDown
            // 
            this.select_date_numericUpDown.Location = new System.Drawing.Point(325, 34);
            this.select_date_numericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.select_date_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.select_date_numericUpDown.Name = "select_date_numericUpDown";
            this.select_date_numericUpDown.Size = new System.Drawing.Size(55, 27);
            this.select_date_numericUpDown.TabIndex = 2;
            this.select_date_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.select_date_numericUpDown.Visible = false;
            this.select_date_numericUpDown.ValueChanged += new System.EventHandler(this.select_date_numericUpDown_ValueChanged);
            // 
            // date_radioButton
            // 
            this.date_radioButton.AutoSize = true;
            this.date_radioButton.Location = new System.Drawing.Point(239, 37);
            this.date_radioButton.Name = "date_radioButton";
            this.date_radioButton.Size = new System.Drawing.Size(61, 24);
            this.date_radioButton.TabIndex = 1;
            this.date_radioButton.Text = "Date";
            this.date_radioButton.UseVisualStyleBackColor = true;
            this.date_radioButton.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // name_radioButton
            // 
            this.name_radioButton.AutoSize = true;
            this.name_radioButton.Checked = true;
            this.name_radioButton.Location = new System.Drawing.Point(163, 35);
            this.name_radioButton.Name = "name_radioButton";
            this.name_radioButton.Size = new System.Drawing.Size(70, 24);
            this.name_radioButton.TabIndex = 1;
            this.name_radioButton.TabStop = true;
            this.name_radioButton.Text = "Name";
            this.name_radioButton.UseVisualStyleBackColor = true;
            this.name_radioButton.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Absent : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Present : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Students : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Attendance By : ";
            // 
            // ViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "ViewAttendance";
            this.Text = "ViewAttendance";
            this.Load += new System.EventHandler(this.ViewAttendance_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.search_groupBox.ResumeLayout(false);
            this.search_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_sem_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_dataGridView)).EndInit();
            this.filter_groupBox.ResumeLayout(false);
            this.filter_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_date_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox search_groupBox;
        private System.Windows.Forms.NumericUpDown select_sem_numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox select_batch_comboBox;
        private System.Windows.Forms.ComboBox select_dept_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button download_button;
        private System.Windows.Forms.Button view_button;
        private System.Windows.Forms.DataGridView attendance_dataGridView;
        private System.Windows.Forms.GroupBox filter_groupBox;
        private System.Windows.Forms.RadioButton name_radioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton date_radioButton;
        private System.Windows.Forms.NumericUpDown select_date_numericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox select_month_comboBox;
        private CustomControl.NumericTextBox a_numericTextBox;
        private CustomControl.NumericTextBox p_numericTextBox;
        private CustomControl.NumericTextBox total_numericTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stud_TextBox;
        private System.Windows.Forms.Button enable_attendance_button;
        private System.Windows.Forms.Button filter_enable_button;
    }
}