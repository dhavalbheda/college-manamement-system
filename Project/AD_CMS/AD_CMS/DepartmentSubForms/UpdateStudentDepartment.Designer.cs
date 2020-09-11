namespace AD_CMS.DepartmentSubForms
{
    partial class UpdateStudentDepartment
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
            this.search_dept_groupBox = new System.Windows.Forms.GroupBox();
            this.update_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.find_stud_button = new System.Windows.Forms.Button();
            this.update_sem_textBox = new CustomControl.NumericTextBox();
            this.to_label = new System.Windows.Forms.Label();
            this.update_sem_label = new System.Windows.Forms.Label();
            this.select_course_comboBox = new System.Windows.Forms.ComboBox();
            this.select_course_label = new System.Windows.Forms.Label();
            this.old_stud_dataGridView = new System.Windows.Forms.DataGridView();
            this.new_stud_dataGridView = new System.Windows.Forms.DataGridView();
            this.one_tr_button = new System.Windows.Forms.Button();
            this.one_rev_button = new System.Windows.Forms.Button();
            this.all_tr_button = new System.Windows.Forms.Button();
            this.all_rev_button = new System.Windows.Forms.Button();
            this.old_sem_label = new System.Windows.Forms.Label();
            this.new_sem_label = new System.Windows.Forms.Label();
            this.promote_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.data_moving_option_panel = new System.Windows.Forms.Panel();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.search_dept_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.old_stud_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_stud_dataGridView)).BeginInit();
            this.data_moving_option_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Size = new System.Drawing.Size(518, 38);
            this.heading_label.Text = "Promote Student Department";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.data_moving_option_panel);
            this.contentarea_panel.Controls.Add(this.clear_button);
            this.contentarea_panel.Controls.Add(this.promote_button);
            this.contentarea_panel.Controls.Add(this.new_sem_label);
            this.contentarea_panel.Controls.Add(this.old_sem_label);
            this.contentarea_panel.Controls.Add(this.new_stud_dataGridView);
            this.contentarea_panel.Controls.Add(this.old_stud_dataGridView);
            this.contentarea_panel.Controls.Add(this.search_dept_groupBox);
            this.contentarea_panel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // search_dept_groupBox
            // 
            this.search_dept_groupBox.Controls.Add(this.update_numericUpDown);
            this.search_dept_groupBox.Controls.Add(this.find_stud_button);
            this.search_dept_groupBox.Controls.Add(this.update_sem_textBox);
            this.search_dept_groupBox.Controls.Add(this.to_label);
            this.search_dept_groupBox.Controls.Add(this.update_sem_label);
            this.search_dept_groupBox.Controls.Add(this.select_course_comboBox);
            this.search_dept_groupBox.Controls.Add(this.select_course_label);
            this.search_dept_groupBox.Location = new System.Drawing.Point(329, 11);
            this.search_dept_groupBox.Name = "search_dept_groupBox";
            this.search_dept_groupBox.Size = new System.Drawing.Size(432, 184);
            this.search_dept_groupBox.TabIndex = 0;
            this.search_dept_groupBox.TabStop = false;
            this.search_dept_groupBox.Text = "*Search Departmnt";
            // 
            // update_numericUpDown
            // 
            this.update_numericUpDown.Location = new System.Drawing.Point(222, 83);
            this.update_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.update_numericUpDown.Name = "update_numericUpDown";
            this.update_numericUpDown.Size = new System.Drawing.Size(50, 27);
            this.update_numericUpDown.TabIndex = 5;
            this.update_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.update_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.update_numericUpDown.ValueChanged += new System.EventHandler(this.update_numericUpDown_ValueChanged);
            // 
            // find_stud_button
            // 
            this.find_stud_button.Location = new System.Drawing.Point(125, 131);
            this.find_stud_button.Name = "find_stud_button";
            this.find_stud_button.Size = new System.Drawing.Size(182, 35);
            this.find_stud_button.TabIndex = 2;
            this.find_stud_button.Text = "Find Students";
            this.find_stud_button.UseVisualStyleBackColor = true;
            this.find_stud_button.Click += new System.EventHandler(this.find_stud_button_Click);
            // 
            // update_sem_textBox
            // 
            this.update_sem_textBox.Enabled = false;
            this.update_sem_textBox.Location = new System.Drawing.Point(322, 83);
            this.update_sem_textBox.MaxLength = 10;
            this.update_sem_textBox.Name = "update_sem_textBox";
            this.update_sem_textBox.ReadOnly = true;
            this.update_sem_textBox.Size = new System.Drawing.Size(43, 27);
            this.update_sem_textBox.TabIndex = 4;
            this.update_sem_textBox.TabStop = false;
            this.update_sem_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // to_label
            // 
            this.to_label.AutoSize = true;
            this.to_label.Location = new System.Drawing.Point(285, 86);
            this.to_label.Name = "to_label";
            this.to_label.Size = new System.Drawing.Size(25, 20);
            this.to_label.TabIndex = 3;
            this.to_label.Text = "to";
            // 
            // update_sem_label
            // 
            this.update_sem_label.AutoSize = true;
            this.update_sem_label.Location = new System.Drawing.Point(67, 86);
            this.update_sem_label.Name = "update_sem_label";
            this.update_sem_label.Size = new System.Drawing.Size(154, 20);
            this.update_sem_label.TabIndex = 2;
            this.update_sem_label.Text = "Update Semester : ";
            // 
            // select_course_comboBox
            // 
            this.select_course_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_course_comboBox.FormattingEnabled = true;
            this.select_course_comboBox.Location = new System.Drawing.Point(202, 37);
            this.select_course_comboBox.Name = "select_course_comboBox";
            this.select_course_comboBox.Size = new System.Drawing.Size(163, 27);
            this.select_course_comboBox.TabIndex = 0;
            this.select_course_comboBox.SelectedIndexChanged += new System.EventHandler(this.select_course_comboBox_SelectedIndexChanged);
            this.select_course_comboBox.TextChanged += new System.EventHandler(this.Promote_stud_textChanged);
            // 
            // select_course_label
            // 
            this.select_course_label.AutoSize = true;
            this.select_course_label.Location = new System.Drawing.Point(67, 40);
            this.select_course_label.Name = "select_course_label";
            this.select_course_label.Size = new System.Drawing.Size(129, 20);
            this.select_course_label.TabIndex = 0;
            this.select_course_label.Text = "Select Course : ";
            // 
            // old_stud_dataGridView
            // 
            this.old_stud_dataGridView.AllowUserToAddRows = false;
            this.old_stud_dataGridView.AllowUserToDeleteRows = false;
            this.old_stud_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.old_stud_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.old_stud_dataGridView.Location = new System.Drawing.Point(34, 209);
            this.old_stud_dataGridView.Name = "old_stud_dataGridView";
            this.old_stud_dataGridView.ReadOnly = true;
            this.old_stud_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.old_stud_dataGridView.Size = new System.Drawing.Size(401, 367);
            this.old_stud_dataGridView.TabIndex = 3;
            this.old_stud_dataGridView.TabStop = false;
            // 
            // new_stud_dataGridView
            // 
            this.new_stud_dataGridView.AllowUserToAddRows = false;
            this.new_stud_dataGridView.AllowUserToDeleteRows = false;
            this.new_stud_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.new_stud_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.new_stud_dataGridView.Location = new System.Drawing.Point(653, 209);
            this.new_stud_dataGridView.Name = "new_stud_dataGridView";
            this.new_stud_dataGridView.ReadOnly = true;
            this.new_stud_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.new_stud_dataGridView.Size = new System.Drawing.Size(401, 367);
            this.new_stud_dataGridView.TabIndex = 1;
            this.new_stud_dataGridView.TabStop = false;
            // 
            // one_tr_button
            // 
            this.one_tr_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.one_tr_button.Font = new System.Drawing.Font("Cooper Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one_tr_button.Location = new System.Drawing.Point(19, 12);
            this.one_tr_button.Name = "one_tr_button";
            this.one_tr_button.Size = new System.Drawing.Size(61, 53);
            this.one_tr_button.TabIndex = 1;
            this.one_tr_button.Text = ">";
            this.one_tr_button.UseVisualStyleBackColor = true;
            this.one_tr_button.Click += new System.EventHandler(this.one_tr_button_Click);
            // 
            // one_rev_button
            // 
            this.one_rev_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.one_rev_button.Enabled = false;
            this.one_rev_button.Font = new System.Drawing.Font("Cooper Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one_rev_button.Location = new System.Drawing.Point(19, 71);
            this.one_rev_button.Name = "one_rev_button";
            this.one_rev_button.Size = new System.Drawing.Size(61, 53);
            this.one_rev_button.TabIndex = 2;
            this.one_rev_button.Text = "<";
            this.one_rev_button.UseVisualStyleBackColor = true;
            this.one_rev_button.Click += new System.EventHandler(this.one_rev_button_Click);
            // 
            // all_tr_button
            // 
            this.all_tr_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.all_tr_button.Font = new System.Drawing.Font("Cooper Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_tr_button.Location = new System.Drawing.Point(19, 130);
            this.all_tr_button.Name = "all_tr_button";
            this.all_tr_button.Size = new System.Drawing.Size(61, 53);
            this.all_tr_button.TabIndex = 3;
            this.all_tr_button.Text = ">>";
            this.all_tr_button.UseVisualStyleBackColor = true;
            this.all_tr_button.Click += new System.EventHandler(this.all_tr_button_Click);
            // 
            // all_rev_button
            // 
            this.all_rev_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.all_rev_button.Enabled = false;
            this.all_rev_button.Font = new System.Drawing.Font("Cooper Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_rev_button.Location = new System.Drawing.Point(19, 189);
            this.all_rev_button.Name = "all_rev_button";
            this.all_rev_button.Size = new System.Drawing.Size(61, 53);
            this.all_rev_button.TabIndex = 4;
            this.all_rev_button.Text = "<<";
            this.all_rev_button.UseVisualStyleBackColor = true;
            this.all_rev_button.Click += new System.EventHandler(this.all_rev_button_Click);
            // 
            // old_sem_label
            // 
            this.old_sem_label.AutoSize = true;
            this.old_sem_label.Location = new System.Drawing.Point(52, 175);
            this.old_sem_label.Name = "old_sem_label";
            this.old_sem_label.Size = new System.Drawing.Size(0, 20);
            this.old_sem_label.TabIndex = 7;
            // 
            // new_sem_label
            // 
            this.new_sem_label.AutoSize = true;
            this.new_sem_label.Location = new System.Drawing.Point(967, 175);
            this.new_sem_label.Name = "new_sem_label";
            this.new_sem_label.Size = new System.Drawing.Size(0, 20);
            this.new_sem_label.TabIndex = 7;
            // 
            // promote_button
            // 
            this.promote_button.Enabled = false;
            this.promote_button.Location = new System.Drawing.Point(336, 594);
            this.promote_button.Name = "promote_button";
            this.promote_button.Size = new System.Drawing.Size(182, 35);
            this.promote_button.TabIndex = 5;
            this.promote_button.Text = "Promote Student";
            this.promote_button.UseVisualStyleBackColor = true;
            this.promote_button.Click += new System.EventHandler(this.promote_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(573, 594);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(182, 35);
            this.clear_button.TabIndex = 6;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // data_moving_option_panel
            // 
            this.data_moving_option_panel.Controls.Add(this.one_tr_button);
            this.data_moving_option_panel.Controls.Add(this.one_rev_button);
            this.data_moving_option_panel.Controls.Add(this.all_tr_button);
            this.data_moving_option_panel.Controls.Add(this.all_rev_button);
            this.data_moving_option_panel.Enabled = false;
            this.data_moving_option_panel.Location = new System.Drawing.Point(503, 252);
            this.data_moving_option_panel.Name = "data_moving_option_panel";
            this.data_moving_option_panel.Size = new System.Drawing.Size(98, 255);
            this.data_moving_option_panel.TabIndex = 8;
            // 
            // UpdateStudentDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "UpdateStudentDepartment";
            this.Text = "UpdateStudentDepartment";
            this.Load += new System.EventHandler(this.UpdateStudentDepartment_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            this.contentarea_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.search_dept_groupBox.ResumeLayout(false);
            this.search_dept_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.old_stud_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_stud_dataGridView)).EndInit();
            this.data_moving_option_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox search_dept_groupBox;
        private System.Windows.Forms.DataGridView new_stud_dataGridView;
        private System.Windows.Forms.DataGridView old_stud_dataGridView;
        private System.Windows.Forms.Button find_stud_button;
        private CustomControl.NumericTextBox update_sem_textBox;
        private System.Windows.Forms.Label to_label;
        private System.Windows.Forms.Label update_sem_label;
        private System.Windows.Forms.ComboBox select_course_comboBox;
        private System.Windows.Forms.Label select_course_label;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button promote_button;
        private System.Windows.Forms.Label new_sem_label;
        private System.Windows.Forms.Label old_sem_label;
        private System.Windows.Forms.Button all_rev_button;
        private System.Windows.Forms.Button all_tr_button;
        private System.Windows.Forms.Button one_rev_button;
        private System.Windows.Forms.Button one_tr_button;
        private System.Windows.Forms.Panel data_moving_option_panel;
        private System.Windows.Forms.NumericUpDown update_numericUpDown;
    }
}