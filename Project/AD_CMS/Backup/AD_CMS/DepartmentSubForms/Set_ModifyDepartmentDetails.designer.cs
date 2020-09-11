namespace AD_CMS.DepartmentSubForms
{
    partial class Set_ModifyDepartmentDetails
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
            this.dept_name_label = new System.Windows.Forms.Label();
            this.select_sem_label = new System.Windows.Forms.Label();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.select_sem_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.find_button = new System.Windows.Forms.Button();
            this.dept_name_comboBox = new System.Windows.Forms.ComboBox();
            this.department_dataGridView = new System.Windows.Forms.DataGridView();
            this.subject_panel = new System.Windows.Forms.Panel();
            this.save_button = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.select_teacher_comboBox = new System.Windows.Forms.ComboBox();
            this.subject_nm_comboBox = new System.Windows.Forms.ComboBox();
            this.select_teacher_label = new System.Windows.Forms.Label();
            this.subject_name_label = new System.Windows.Forms.Label();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_sem_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.department_dataGridView)).BeginInit();
            this.subject_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(273, 5);
            this.heading_label.Size = new System.Drawing.Size(568, 38);
            this.heading_label.Text = "Set && Modify Department Details";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.department_dataGridView);
            this.contentarea_panel.Controls.Add(this.subject_panel);
            this.contentarea_panel.Controls.Add(this.SearchPanel);
            this.contentarea_panel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dept_name_label
            // 
            this.dept_name_label.AutoSize = true;
            this.dept_name_label.Location = new System.Drawing.Point(47, 14);
            this.dept_name_label.Name = "dept_name_label";
            this.dept_name_label.Size = new System.Drawing.Size(175, 20);
            this.dept_name_label.TabIndex = 0;
            this.dept_name_label.Text = "*Department Name : ";
            // 
            // select_sem_label
            // 
            this.select_sem_label.AutoSize = true;
            this.select_sem_label.Location = new System.Drawing.Point(47, 53);
            this.select_sem_label.Name = "select_sem_label";
            this.select_sem_label.Size = new System.Drawing.Size(152, 20);
            this.select_sem_label.TabIndex = 4;
            this.select_sem_label.Text = "*Select Semester : ";
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.select_sem_numericUpDown);
            this.SearchPanel.Controls.Add(this.find_button);
            this.SearchPanel.Controls.Add(this.dept_name_comboBox);
            this.SearchPanel.Controls.Add(this.select_sem_label);
            this.SearchPanel.Controls.Add(this.dept_name_label);
            this.SearchPanel.Location = new System.Drawing.Point(251, 22);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(589, 100);
            this.SearchPanel.TabIndex = 0;
            // 
            // select_sem_numericUpDown
            // 
            this.select_sem_numericUpDown.Location = new System.Drawing.Point(228, 51);
            this.select_sem_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.select_sem_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.select_sem_numericUpDown.Name = "select_sem_numericUpDown";
            this.select_sem_numericUpDown.Size = new System.Drawing.Size(50, 27);
            this.select_sem_numericUpDown.TabIndex = 5;
            this.select_sem_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(447, 26);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(120, 49);
            this.find_button.TabIndex = 2;
            this.find_button.Text = "Find";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // dept_name_comboBox
            // 
            this.dept_name_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dept_name_comboBox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept_name_comboBox.FormattingEnabled = true;
            this.dept_name_comboBox.Items.AddRange(new object[] {
            "Select"});
            this.dept_name_comboBox.Location = new System.Drawing.Point(228, 11);
            this.dept_name_comboBox.Name = "dept_name_comboBox";
            this.dept_name_comboBox.Size = new System.Drawing.Size(183, 27);
            this.dept_name_comboBox.TabIndex = 0;
            this.dept_name_comboBox.SelectedIndexChanged += new System.EventHandler(this.dept_name_comboBox_SelectedIndexChanged);
            this.dept_name_comboBox.TextChanged += new System.EventHandler(this.set_modify_textChanged);
            // 
            // department_dataGridView
            // 
            this.department_dataGridView.AllowUserToAddRows = false;
            this.department_dataGridView.AllowUserToDeleteRows = false;
            this.department_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.department_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.department_dataGridView.Location = new System.Drawing.Point(148, 141);
            this.department_dataGridView.Name = "department_dataGridView";
            this.department_dataGridView.ReadOnly = true;
            this.department_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.department_dataGridView.Size = new System.Drawing.Size(794, 248);
            this.department_dataGridView.TabIndex = 6;
            this.department_dataGridView.TabStop = false;
            this.department_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.department_dataGridView_CellDoubleClick);
            // 
            // subject_panel
            // 
            this.subject_panel.Controls.Add(this.save_button);
            this.subject_panel.Controls.Add(this.closebutton);
            this.subject_panel.Controls.Add(this.select_teacher_comboBox);
            this.subject_panel.Controls.Add(this.subject_nm_comboBox);
            this.subject_panel.Controls.Add(this.select_teacher_label);
            this.subject_panel.Controls.Add(this.subject_name_label);
            this.subject_panel.Enabled = false;
            this.subject_panel.Location = new System.Drawing.Point(268, 424);
            this.subject_panel.Name = "subject_panel";
            this.subject_panel.Size = new System.Drawing.Size(518, 198);
            this.subject_panel.TabIndex = 1;
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(57, 128);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(195, 61);
            this.save_button.TabIndex = 2;
            this.save_button.Text = "Save / Update";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // closebutton
            // 
            this.closebutton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebutton.Location = new System.Drawing.Point(292, 128);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(195, 61);
            this.closebutton.TabIndex = 3;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // select_teacher_comboBox
            // 
            this.select_teacher_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_teacher_comboBox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_teacher_comboBox.FormattingEnabled = true;
            this.select_teacher_comboBox.Location = new System.Drawing.Point(212, 56);
            this.select_teacher_comboBox.Name = "select_teacher_comboBox";
            this.select_teacher_comboBox.Size = new System.Drawing.Size(183, 27);
            this.select_teacher_comboBox.TabIndex = 1;
            this.select_teacher_comboBox.TextChanged += new System.EventHandler(this.set_modify_textChanged);
            // 
            // subject_nm_comboBox
            // 
            this.subject_nm_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subject_nm_comboBox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_nm_comboBox.FormattingEnabled = true;
            this.subject_nm_comboBox.Items.AddRange(new object[] {
            "Select"});
            this.subject_nm_comboBox.Location = new System.Drawing.Point(212, 17);
            this.subject_nm_comboBox.Name = "subject_nm_comboBox";
            this.subject_nm_comboBox.Size = new System.Drawing.Size(241, 27);
            this.subject_nm_comboBox.TabIndex = 0;
            this.subject_nm_comboBox.TextChanged += new System.EventHandler(this.set_modify_textChanged);
            // 
            // select_teacher_label
            // 
            this.select_teacher_label.AutoSize = true;
            this.select_teacher_label.Location = new System.Drawing.Point(65, 59);
            this.select_teacher_label.Name = "select_teacher_label";
            this.select_teacher_label.Size = new System.Drawing.Size(142, 20);
            this.select_teacher_label.TabIndex = 4;
            this.select_teacher_label.Text = "*Select Teacher : ";
            // 
            // subject_name_label
            // 
            this.subject_name_label.AutoSize = true;
            this.subject_name_label.Location = new System.Drawing.Point(65, 20);
            this.subject_name_label.Name = "subject_name_label";
            this.subject_name_label.Size = new System.Drawing.Size(141, 20);
            this.subject_name_label.TabIndex = 0;
            this.subject_name_label.Text = "*Subject Name : ";
            // 
            // Set_ModifyDepartmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "Set_ModifyDepartmentDetails";
            this.Text = "Set_ModifyDepartmentDetails";
            this.Load += new System.EventHandler(this.Set_ModifyDepartmentDetails_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_sem_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.department_dataGridView)).EndInit();
            this.subject_panel.ResumeLayout(false);
            this.subject_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dept_name_label;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.ComboBox dept_name_comboBox;
        private System.Windows.Forms.Label select_sem_label;
        private System.Windows.Forms.DataGridView department_dataGridView;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Panel subject_panel;
        private System.Windows.Forms.ComboBox select_teacher_comboBox;
        private System.Windows.Forms.ComboBox subject_nm_comboBox;
        private System.Windows.Forms.Label select_teacher_label;
        private System.Windows.Forms.Label subject_name_label;
        private System.Windows.Forms.NumericUpDown select_sem_numericUpDown;

    }
}