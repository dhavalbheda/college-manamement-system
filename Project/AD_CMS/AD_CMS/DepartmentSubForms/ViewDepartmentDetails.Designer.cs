namespace AD_CMS.DepartmentSubForms
{
    partial class ViewDepartmentDetails
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
            this.close_button = new System.Windows.Forms.Button();
            this.find_button = new System.Windows.Forms.Button();
            this.select_dept_comboBox = new System.Windows.Forms.ComboBox();
            this.select_sem_label = new System.Windows.Forms.Label();
            this.select_dept_label = new System.Windows.Forms.Label();
            this.all_student_dataGridView = new System.Windows.Forms.DataGridView();
            this.all_sub_dataGridView = new System.Windows.Forms.DataGridView();
            this.total_label = new System.Windows.Forms.Label();
            this.total_textBox = new CustomControl.NumericTextBox();
            this.boys_label = new System.Windows.Forms.Label();
            this.girls_textBox = new CustomControl.NumericTextBox();
            this.girls_label = new System.Windows.Forms.Label();
            this.boys_textBox = new CustomControl.NumericTextBox();
            this.noOfStudgroupBox = new System.Windows.Forms.GroupBox();
            this.search_groupBox = new System.Windows.Forms.GroupBox();
            this.select_sem_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_student_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_sub_dataGridView)).BeginInit();
            this.noOfStudgroupBox.SuspendLayout();
            this.search_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_sem_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Size = new System.Drawing.Size(442, 38);
            this.heading_label.Text = "View Department Details";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.search_groupBox);
            this.contentarea_panel.Controls.Add(this.noOfStudgroupBox);
            this.contentarea_panel.Controls.Add(this.all_sub_dataGridView);
            this.contentarea_panel.Controls.Add(this.all_student_dataGridView);
            this.contentarea_panel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(443, 70);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(114, 37);
            this.close_button.TabIndex = 3;
            this.close_button.TabStop = false;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(443, 25);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(114, 37);
            this.find_button.TabIndex = 2;
            this.find_button.Text = "Find";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // select_dept_comboBox
            // 
            this.select_dept_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_dept_comboBox.FormattingEnabled = true;
            this.select_dept_comboBox.Items.AddRange(new object[] {
            "Select"});
            this.select_dept_comboBox.Location = new System.Drawing.Point(206, 31);
            this.select_dept_comboBox.Name = "select_dept_comboBox";
            this.select_dept_comboBox.Size = new System.Drawing.Size(160, 27);
            this.select_dept_comboBox.TabIndex = 0;
            this.select_dept_comboBox.SelectedIndexChanged += new System.EventHandler(this.select_dept_comboBox_SelectedIndexChanged);
            this.select_dept_comboBox.TextChanged += new System.EventHandler(this.view_dept_textChanged);
            // 
            // select_sem_label
            // 
            this.select_sem_label.AutoSize = true;
            this.select_sem_label.Location = new System.Drawing.Point(24, 70);
            this.select_sem_label.Name = "select_sem_label";
            this.select_sem_label.Size = new System.Drawing.Size(143, 20);
            this.select_sem_label.TabIndex = 0;
            this.select_sem_label.Text = "Select Semester : ";
            // 
            // select_dept_label
            // 
            this.select_dept_label.AutoSize = true;
            this.select_dept_label.Location = new System.Drawing.Point(24, 34);
            this.select_dept_label.Name = "select_dept_label";
            this.select_dept_label.Size = new System.Drawing.Size(166, 20);
            this.select_dept_label.TabIndex = 0;
            this.select_dept_label.Text = "Select Department : ";
            // 
            // all_student_dataGridView
            // 
            this.all_student_dataGridView.AllowUserToAddRows = false;
            this.all_student_dataGridView.AllowUserToDeleteRows = false;
            this.all_student_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.all_student_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.all_student_dataGridView.Location = new System.Drawing.Point(35, 143);
            this.all_student_dataGridView.Name = "all_student_dataGridView";
            this.all_student_dataGridView.ReadOnly = true;
            this.all_student_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.all_student_dataGridView.Size = new System.Drawing.Size(712, 493);
            this.all_student_dataGridView.TabIndex = 1;
            this.all_student_dataGridView.TabStop = false;
            // 
            // all_sub_dataGridView
            // 
            this.all_sub_dataGridView.AllowUserToAddRows = false;
            this.all_sub_dataGridView.AllowUserToDeleteRows = false;
            this.all_sub_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.all_sub_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.all_sub_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.all_sub_dataGridView.GridColor = System.Drawing.Color.MistyRose;
            this.all_sub_dataGridView.Location = new System.Drawing.Point(767, 143);
            this.all_sub_dataGridView.Name = "all_sub_dataGridView";
            this.all_sub_dataGridView.ReadOnly = true;
            this.all_sub_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.all_sub_dataGridView.Size = new System.Drawing.Size(307, 243);
            this.all_sub_dataGridView.TabIndex = 2;
            this.all_sub_dataGridView.TabStop = false;
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Location = new System.Drawing.Point(27, 57);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(63, 20);
            this.total_label.TabIndex = 0;
            this.total_label.Text = "Total : ";
            // 
            // total_textBox
            // 
            this.total_textBox.Location = new System.Drawing.Point(107, 54);
            this.total_textBox.MaxLength = 3;
            this.total_textBox.Name = "total_textBox";
            this.total_textBox.ReadOnly = true;
            this.total_textBox.Size = new System.Drawing.Size(113, 27);
            this.total_textBox.TabIndex = 1;
            this.total_textBox.TabStop = false;
            // 
            // boys_label
            // 
            this.boys_label.AutoSize = true;
            this.boys_label.Location = new System.Drawing.Point(27, 157);
            this.boys_label.Name = "boys_label";
            this.boys_label.Size = new System.Drawing.Size(62, 20);
            this.boys_label.TabIndex = 0;
            this.boys_label.Text = "Boys : ";
            // 
            // girls_textBox
            // 
            this.girls_textBox.Location = new System.Drawing.Point(107, 105);
            this.girls_textBox.MaxLength = 3;
            this.girls_textBox.Name = "girls_textBox";
            this.girls_textBox.ReadOnly = true;
            this.girls_textBox.Size = new System.Drawing.Size(113, 27);
            this.girls_textBox.TabIndex = 1;
            this.girls_textBox.TabStop = false;
            // 
            // girls_label
            // 
            this.girls_label.AutoSize = true;
            this.girls_label.Location = new System.Drawing.Point(27, 108);
            this.girls_label.Name = "girls_label";
            this.girls_label.Size = new System.Drawing.Size(62, 20);
            this.girls_label.TabIndex = 0;
            this.girls_label.Text = "Girls : ";
            // 
            // boys_textBox
            // 
            this.boys_textBox.Location = new System.Drawing.Point(107, 154);
            this.boys_textBox.MaxLength = 3;
            this.boys_textBox.Name = "boys_textBox";
            this.boys_textBox.ReadOnly = true;
            this.boys_textBox.Size = new System.Drawing.Size(113, 27);
            this.boys_textBox.TabIndex = 1;
            this.boys_textBox.TabStop = false;
            // 
            // noOfStudgroupBox
            // 
            this.noOfStudgroupBox.Controls.Add(this.total_label);
            this.noOfStudgroupBox.Controls.Add(this.boys_textBox);
            this.noOfStudgroupBox.Controls.Add(this.boys_label);
            this.noOfStudgroupBox.Controls.Add(this.girls_label);
            this.noOfStudgroupBox.Controls.Add(this.girls_textBox);
            this.noOfStudgroupBox.Controls.Add(this.total_textBox);
            this.noOfStudgroupBox.Location = new System.Drawing.Point(796, 424);
            this.noOfStudgroupBox.Name = "noOfStudgroupBox";
            this.noOfStudgroupBox.Size = new System.Drawing.Size(262, 208);
            this.noOfStudgroupBox.TabIndex = 1;
            this.noOfStudgroupBox.TabStop = false;
            this.noOfStudgroupBox.Text = "Number Of Students";
            // 
            // search_groupBox
            // 
            this.search_groupBox.Controls.Add(this.select_sem_numericUpDown);
            this.search_groupBox.Controls.Add(this.select_dept_comboBox);
            this.search_groupBox.Controls.Add(this.close_button);
            this.search_groupBox.Controls.Add(this.find_button);
            this.search_groupBox.Controls.Add(this.select_sem_label);
            this.search_groupBox.Controls.Add(this.select_dept_label);
            this.search_groupBox.Location = new System.Drawing.Point(245, 6);
            this.search_groupBox.Name = "search_groupBox";
            this.search_groupBox.Size = new System.Drawing.Size(601, 122);
            this.search_groupBox.TabIndex = 0;
            this.search_groupBox.TabStop = false;
            this.search_groupBox.Text = "*Search By";
            // 
            // select_sem_numericUpDown
            // 
            this.select_sem_numericUpDown.Location = new System.Drawing.Point(206, 68);
            this.select_sem_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.select_sem_numericUpDown.Name = "select_sem_numericUpDown";
            this.select_sem_numericUpDown.Size = new System.Drawing.Size(60, 27);
            this.select_sem_numericUpDown.TabIndex = 4;
            this.select_sem_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ViewDepartmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "ViewDepartmentDetails";
            this.Text = "ViewDepartmentDetails";
            this.Load += new System.EventHandler(this.ViewDepartmentDetails_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_student_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_sub_dataGridView)).EndInit();
            this.noOfStudgroupBox.ResumeLayout(false);
            this.noOfStudgroupBox.PerformLayout();
            this.search_groupBox.ResumeLayout(false);
            this.search_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_sem_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView all_student_dataGridView;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.ComboBox select_dept_comboBox;
        private System.Windows.Forms.Label select_sem_label;
        private System.Windows.Forms.Label select_dept_label;
        private System.Windows.Forms.DataGridView all_sub_dataGridView;
        private System.Windows.Forms.GroupBox noOfStudgroupBox;
        private System.Windows.Forms.Label total_label;
        private CustomControl.NumericTextBox boys_textBox;
        private System.Windows.Forms.Label boys_label;
        private System.Windows.Forms.Label girls_label;
        private CustomControl.NumericTextBox girls_textBox;
        private CustomControl.NumericTextBox total_textBox;
        private System.Windows.Forms.GroupBox search_groupBox;
        private System.Windows.Forms.NumericUpDown select_sem_numericUpDown;
    }
}