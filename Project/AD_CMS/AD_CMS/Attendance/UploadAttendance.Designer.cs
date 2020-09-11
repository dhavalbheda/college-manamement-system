namespace AD_CMS.Attendance
{
    partial class UploadAttendance
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.batch_year_TextBox = new System.Windows.Forms.TextBox();
            this.upload_button = new System.Windows.Forms.Button();
            this.file_path_textBox = new System.Windows.Forms.TextBox();
            this.select_file_button = new System.Windows.Forms.Button();
            this.select_sem_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.select_month_comboBox = new System.Windows.Forms.ComboBox();
            this.select_dept_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.attendance_dataGridView = new System.Windows.Forms.DataGridView();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_sem_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(388, 5);
            this.heading_label.Size = new System.Drawing.Size(339, 38);
            this.heading_label.Text = "Upload Attendance";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.attendance_dataGridView);
            this.contentarea_panel.Controls.Add(this.groupBox1);
            this.contentarea_panel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.batch_year_TextBox);
            this.groupBox1.Controls.Add(this.upload_button);
            this.groupBox1.Controls.Add(this.file_path_textBox);
            this.groupBox1.Controls.Add(this.select_file_button);
            this.groupBox1.Controls.Add(this.select_sem_numericUpDown);
            this.groupBox1.Controls.Add(this.select_month_comboBox);
            this.groupBox1.Controls.Add(this.select_dept_comboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(188, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendance Sheet Details";
            // 
            // batch_year_TextBox
            // 
            this.batch_year_TextBox.Location = new System.Drawing.Point(237, 125);
            this.batch_year_TextBox.Name = "batch_year_TextBox";
            this.batch_year_TextBox.ReadOnly = true;
            this.batch_year_TextBox.Size = new System.Drawing.Size(243, 27);
            this.batch_year_TextBox.TabIndex = 8;
            this.batch_year_TextBox.TabStop = false;
            // 
            // upload_button
            // 
            this.upload_button.Enabled = false;
            this.upload_button.Location = new System.Drawing.Point(530, 92);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(127, 54);
            this.upload_button.TabIndex = 7;
            this.upload_button.Text = "Upload Attendance";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // file_path_textBox
            // 
            this.file_path_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_path_textBox.Location = new System.Drawing.Point(237, 159);
            this.file_path_textBox.Multiline = true;
            this.file_path_textBox.Name = "file_path_textBox";
            this.file_path_textBox.ReadOnly = true;
            this.file_path_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.file_path_textBox.Size = new System.Drawing.Size(265, 42);
            this.file_path_textBox.TabIndex = 4;
            this.file_path_textBox.TabStop = false;
            // 
            // select_file_button
            // 
            this.select_file_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_file_button.Location = new System.Drawing.Point(77, 168);
            this.select_file_button.Name = "select_file_button";
            this.select_file_button.Size = new System.Drawing.Size(117, 28);
            this.select_file_button.TabIndex = 4;
            this.select_file_button.Text = "Select File";
            this.select_file_button.UseVisualStyleBackColor = true;
            this.select_file_button.Click += new System.EventHandler(this.select_file_button_Click);
            // 
            // select_sem_numericUpDown
            // 
            this.select_sem_numericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_sem_numericUpDown.Location = new System.Drawing.Point(237, 60);
            this.select_sem_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.select_sem_numericUpDown.Name = "select_sem_numericUpDown";
            this.select_sem_numericUpDown.Size = new System.Drawing.Size(71, 26);
            this.select_sem_numericUpDown.TabIndex = 1;
            this.select_sem_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.select_sem_numericUpDown.ValueChanged += new System.EventHandler(this.select_sem_numericUpDown_ValueChanged);
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
            this.select_month_comboBox.Location = new System.Drawing.Point(237, 92);
            this.select_month_comboBox.Name = "select_month_comboBox";
            this.select_month_comboBox.Size = new System.Drawing.Size(149, 27);
            this.select_month_comboBox.TabIndex = 3;
            // 
            // select_dept_comboBox
            // 
            this.select_dept_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_dept_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_dept_comboBox.FormattingEnabled = true;
            this.select_dept_comboBox.Location = new System.Drawing.Point(237, 27);
            this.select_dept_comboBox.Name = "select_dept_comboBox";
            this.select_dept_comboBox.Size = new System.Drawing.Size(253, 27);
            this.select_dept_comboBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Betch Year : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "*Select Month : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Select Semester : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Select Department : ";
            // 
            // attendance_dataGridView
            // 
            this.attendance_dataGridView.AllowUserToAddRows = false;
            this.attendance_dataGridView.AllowUserToDeleteRows = false;
            this.attendance_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendance_dataGridView.Location = new System.Drawing.Point(19, 233);
            this.attendance_dataGridView.MultiSelect = false;
            this.attendance_dataGridView.Name = "attendance_dataGridView";
            this.attendance_dataGridView.ReadOnly = true;
            this.attendance_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.attendance_dataGridView.Size = new System.Drawing.Size(1052, 403);
            this.attendance_dataGridView.TabIndex = 1;
            // 
            // UploadAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "UploadAttendance";
            this.Text = "UploadAttendance";
            this.Load += new System.EventHandler(this.UploadAttendance_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_sem_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox select_dept_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown select_sem_numericUpDown;
        private System.Windows.Forms.ComboBox select_month_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox file_path_textBox;
        private System.Windows.Forms.Button select_file_button;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.DataGridView attendance_dataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox batch_year_TextBox;
    }
}