namespace AD_CMS.FinanceDeptSubForms
{
    partial class Set_ModifyEmpSalary
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
            this.empid_panel = new System.Windows.Forms.Panel();
            this.empid_TextBox = new CustomControl.NumericTextBox();
            this.empid_label2 = new System.Windows.Forms.Label();
            this.empnm_panel = new System.Windows.Forms.Panel();
            this.empnm_textBox = new CustomControl.UpperTextBox();
            this.emp_nm_label = new System.Windows.Forms.Label();
            this.designation_panel = new System.Windows.Forms.Panel();
            this.designation_comboBox = new System.Windows.Forms.ComboBox();
            this.designation_label = new System.Windows.Forms.Label();
            this.find_button = new System.Windows.Forms.Button();
            this.designation_radioButton = new System.Windows.Forms.RadioButton();
            this.empnm_radioButton = new System.Windows.Forms.RadioButton();
            this.empid_radioButton = new System.Windows.Forms.RadioButton();
            this.emp_salary_dataGridView = new System.Windows.Forms.DataGridView();
            this.empnm_label = new System.Windows.Forms.Label();
            this.empname_textbox = new CustomControl.UpperTextBox();
            this.emp_nm_sal_panel = new System.Windows.Forms.Panel();
            this.close_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.emp_salary_textBox = new CustomControl.NumericTextBox();
            this.emp_salary_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.search_groupBox.SuspendLayout();
            this.empid_panel.SuspendLayout();
            this.empnm_panel.SuspendLayout();
            this.designation_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_salary_dataGridView)).BeginInit();
            this.emp_nm_sal_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // heading_panel
            // 
            this.heading_panel.Size = new System.Drawing.Size(1114, 53);
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(328, 5);
            this.heading_label.Size = new System.Drawing.Size(519, 38);
            this.heading_label.Text = "Set && Modify Employee Salary";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 53);
            this.splitter1.Size = new System.Drawing.Size(12, 650);
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.label1);
            this.contentarea_panel.Controls.Add(this.emp_nm_sal_panel);
            this.contentarea_panel.Controls.Add(this.emp_salary_dataGridView);
            this.contentarea_panel.Controls.Add(this.search_groupBox);
            this.contentarea_panel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentarea_panel.Location = new System.Drawing.Point(12, 53);
            this.contentarea_panel.Size = new System.Drawing.Size(1090, 650);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(1102, 53);
            this.splitter2.Size = new System.Drawing.Size(12, 650);
            // 
            // search_groupBox
            // 
            this.search_groupBox.Controls.Add(this.empid_panel);
            this.search_groupBox.Controls.Add(this.empnm_panel);
            this.search_groupBox.Controls.Add(this.designation_panel);
            this.search_groupBox.Controls.Add(this.find_button);
            this.search_groupBox.Controls.Add(this.designation_radioButton);
            this.search_groupBox.Controls.Add(this.empnm_radioButton);
            this.search_groupBox.Controls.Add(this.empid_radioButton);
            this.search_groupBox.Location = new System.Drawing.Point(163, 12);
            this.search_groupBox.Name = "search_groupBox";
            this.search_groupBox.Size = new System.Drawing.Size(765, 164);
            this.search_groupBox.TabIndex = 0;
            this.search_groupBox.TabStop = false;
            this.search_groupBox.Text = "*Search By : ";
            this.search_groupBox.Enter += new System.EventHandler(this.search_groupBox_Enter);
            // 
            // empid_panel
            // 
            this.empid_panel.Controls.Add(this.empid_TextBox);
            this.empid_panel.Controls.Add(this.empid_label2);
            this.empid_panel.Location = new System.Drawing.Point(39, 88);
            this.empid_panel.Name = "empid_panel";
            this.empid_panel.Size = new System.Drawing.Size(289, 59);
            this.empid_panel.TabIndex = 1;
            // 
            // empid_TextBox
            // 
            this.empid_TextBox.Location = new System.Drawing.Point(130, 17);
            this.empid_TextBox.MaxLength = 10;
            this.empid_TextBox.Name = "empid_TextBox";
            this.empid_TextBox.Size = new System.Drawing.Size(144, 27);
            this.empid_TextBox.TabIndex = 1;
            this.empid_TextBox.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // empid_label2
            // 
            this.empid_label2.AutoSize = true;
            this.empid_label2.Location = new System.Drawing.Point(5, 20);
            this.empid_label2.Name = "empid_label2";
            this.empid_label2.Size = new System.Drawing.Size(125, 20);
            this.empid_label2.TabIndex = 0;
            this.empid_label2.Text = "Employee ID : ";
            // 
            // empnm_panel
            // 
            this.empnm_panel.Controls.Add(this.empnm_textBox);
            this.empnm_panel.Controls.Add(this.emp_nm_label);
            this.empnm_panel.Location = new System.Drawing.Point(44, 84);
            this.empnm_panel.Name = "empnm_panel";
            this.empnm_panel.Size = new System.Drawing.Size(289, 59);
            this.empnm_panel.TabIndex = 2;
            this.empnm_panel.Visible = false;
            // 
            // empnm_textBox
            // 
            this.empnm_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.empnm_textBox.Location = new System.Drawing.Point(148, 17);
            this.empnm_textBox.Name = "empnm_textBox";
            this.empnm_textBox.Size = new System.Drawing.Size(130, 27);
            this.empnm_textBox.TabIndex = 0;
            this.empnm_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.empnm_textBox.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // emp_nm_label
            // 
            this.emp_nm_label.AutoSize = true;
            this.emp_nm_label.Location = new System.Drawing.Point(5, 20);
            this.emp_nm_label.Name = "emp_nm_label";
            this.emp_nm_label.Size = new System.Drawing.Size(150, 20);
            this.emp_nm_label.TabIndex = 0;
            this.emp_nm_label.Text = "Employee Name : ";
            // 
            // designation_panel
            // 
            this.designation_panel.Controls.Add(this.designation_comboBox);
            this.designation_panel.Controls.Add(this.designation_label);
            this.designation_panel.Location = new System.Drawing.Point(49, 81);
            this.designation_panel.Name = "designation_panel";
            this.designation_panel.Size = new System.Drawing.Size(289, 59);
            this.designation_panel.TabIndex = 3;
            this.designation_panel.Visible = false;
            // 
            // designation_comboBox
            // 
            this.designation_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.designation_comboBox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designation_comboBox.FormattingEnabled = true;
            this.designation_comboBox.Items.AddRange(new object[] {
            "All",
            "Teaching",
            "Non-Teaching"});
            this.designation_comboBox.Location = new System.Drawing.Point(145, 17);
            this.designation_comboBox.Name = "designation_comboBox";
            this.designation_comboBox.Size = new System.Drawing.Size(136, 27);
            this.designation_comboBox.TabIndex = 1;
            this.designation_comboBox.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // designation_label
            // 
            this.designation_label.AutoSize = true;
            this.designation_label.Location = new System.Drawing.Point(5, 20);
            this.designation_label.Name = "designation_label";
            this.designation_label.Size = new System.Drawing.Size(142, 20);
            this.designation_label.TabIndex = 0;
            this.designation_label.Text = "Employee Type : ";
            // 
            // find_button
            // 
            this.find_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_button.Location = new System.Drawing.Point(533, 68);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(197, 60);
            this.find_button.TabIndex = 4;
            this.find_button.Text = "Find";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // designation_radioButton
            // 
            this.designation_radioButton.AutoSize = true;
            this.designation_radioButton.Location = new System.Drawing.Point(344, 36);
            this.designation_radioButton.Name = "designation_radioButton";
            this.designation_radioButton.Size = new System.Drawing.Size(124, 24);
            this.designation_radioButton.TabIndex = 2;
            this.designation_radioButton.Text = "Designation ";
            this.designation_radioButton.UseVisualStyleBackColor = true;
            this.designation_radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // empnm_radioButton
            // 
            this.empnm_radioButton.AutoSize = true;
            this.empnm_radioButton.Location = new System.Drawing.Point(174, 36);
            this.empnm_radioButton.Name = "empnm_radioButton";
            this.empnm_radioButton.Size = new System.Drawing.Size(158, 24);
            this.empnm_radioButton.TabIndex = 1;
            this.empnm_radioButton.Text = "Employee Name ";
            this.empnm_radioButton.UseVisualStyleBackColor = true;
            this.empnm_radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // empid_radioButton
            // 
            this.empid_radioButton.AutoSize = true;
            this.empid_radioButton.Checked = true;
            this.empid_radioButton.Location = new System.Drawing.Point(28, 36);
            this.empid_radioButton.Name = "empid_radioButton";
            this.empid_radioButton.Size = new System.Drawing.Size(133, 24);
            this.empid_radioButton.TabIndex = 0;
            this.empid_radioButton.TabStop = true;
            this.empid_radioButton.Text = "Employee ID ";
            this.empid_radioButton.UseVisualStyleBackColor = true;
            this.empid_radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // emp_salary_dataGridView
            // 
            this.emp_salary_dataGridView.AllowUserToAddRows = false;
            this.emp_salary_dataGridView.AllowUserToDeleteRows = false;
            this.emp_salary_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.emp_salary_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emp_salary_dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.emp_salary_dataGridView.Location = new System.Drawing.Point(120, 182);
            this.emp_salary_dataGridView.MultiSelect = false;
            this.emp_salary_dataGridView.Name = "emp_salary_dataGridView";
            this.emp_salary_dataGridView.ReadOnly = true;
            this.emp_salary_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.emp_salary_dataGridView.Size = new System.Drawing.Size(850, 244);
            this.emp_salary_dataGridView.TabIndex = 1;
            this.emp_salary_dataGridView.TabStop = false;
            this.emp_salary_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emp_salary_dataGridView_CellDoubleClick);
            // 
            // empnm_label
            // 
            this.empnm_label.AutoSize = true;
            this.empnm_label.Location = new System.Drawing.Point(91, 14);
            this.empnm_label.Name = "empnm_label";
            this.empnm_label.Size = new System.Drawing.Size(150, 20);
            this.empnm_label.TabIndex = 2;
            this.empnm_label.Text = "Employee Name : ";
            // 
            // empname_textbox
            // 
            this.empname_textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.empname_textbox.Location = new System.Drawing.Point(255, 14);
            this.empname_textbox.Name = "empname_textbox";
            this.empname_textbox.ReadOnly = true;
            this.empname_textbox.Size = new System.Drawing.Size(310, 27);
            this.empname_textbox.TabIndex = 0;
            this.empname_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emp_nm_sal_panel
            // 
            this.emp_nm_sal_panel.Controls.Add(this.close_button);
            this.emp_nm_sal_panel.Controls.Add(this.label7);
            this.emp_nm_sal_panel.Controls.Add(this.update_button);
            this.emp_nm_sal_panel.Controls.Add(this.emp_salary_textBox);
            this.emp_nm_sal_panel.Controls.Add(this.emp_salary_label);
            this.emp_nm_sal_panel.Controls.Add(this.empname_textbox);
            this.emp_nm_sal_panel.Controls.Add(this.empnm_label);
            this.emp_nm_sal_panel.Enabled = false;
            this.emp_nm_sal_panel.Location = new System.Drawing.Point(208, 451);
            this.emp_nm_sal_panel.Name = "emp_nm_sal_panel";
            this.emp_nm_sal_panel.Size = new System.Drawing.Size(656, 166);
            this.emp_nm_sal_panel.TabIndex = 1;
            // 
            // close_button
            // 
            this.close_button.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.Location = new System.Drawing.Point(370, 107);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(197, 45);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(441, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rs.  [Per Month]";
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(117, 107);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(197, 45);
            this.update_button.TabIndex = 2;
            this.update_button.Text = "Update && Save";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // emp_salary_textBox
            // 
            this.emp_salary_textBox.Location = new System.Drawing.Point(255, 61);
            this.emp_salary_textBox.MaxLength = 8;
            this.emp_salary_textBox.Name = "emp_salary_textBox";
            this.emp_salary_textBox.Size = new System.Drawing.Size(181, 27);
            this.emp_salary_textBox.TabIndex = 1;
            this.emp_salary_textBox.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // emp_salary_label
            // 
            this.emp_salary_label.AutoSize = true;
            this.emp_salary_label.Location = new System.Drawing.Point(91, 61);
            this.emp_salary_label.Name = "emp_salary_label";
            this.emp_salary_label.Size = new System.Drawing.Size(163, 20);
            this.emp_salary_label.TabIndex = 4;
            this.emp_salary_label.Text = "*Employee Salary : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(382, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Double Click On The Record To Update The Salary.";
            // 
            // Set_ModifyEmpSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Set_ModifyEmpSalary";
            this.Text = "Set_ModifyEmpSalary";
            this.Load += new System.EventHandler(this.Set_ModifyEmpSalary_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            this.contentarea_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.search_groupBox.ResumeLayout(false);
            this.search_groupBox.PerformLayout();
            this.empid_panel.ResumeLayout(false);
            this.empid_panel.PerformLayout();
            this.empnm_panel.ResumeLayout(false);
            this.empnm_panel.PerformLayout();
            this.designation_panel.ResumeLayout(false);
            this.designation_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_salary_dataGridView)).EndInit();
            this.emp_nm_sal_panel.ResumeLayout(false);
            this.emp_nm_sal_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox search_groupBox;
        private System.Windows.Forms.RadioButton empnm_radioButton;
        private System.Windows.Forms.RadioButton empid_radioButton;
        private System.Windows.Forms.RadioButton designation_radioButton;
        private System.Windows.Forms.Panel designation_panel;
        private System.Windows.Forms.ComboBox designation_comboBox;
        private System.Windows.Forms.Label designation_label;
        private System.Windows.Forms.Panel empid_panel;
        private CustomControl.NumericTextBox empid_TextBox;
        private System.Windows.Forms.Panel empnm_panel;
        private CustomControl.UpperTextBox empnm_textBox;
        private System.Windows.Forms.Label emp_nm_label;
        private System.Windows.Forms.Label empid_label2;
        private System.Windows.Forms.DataGridView emp_salary_dataGridView;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.Panel emp_nm_sal_panel;
        private CustomControl.UpperTextBox empname_textbox;
        private System.Windows.Forms.Label empnm_label;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label label7;
        private CustomControl.NumericTextBox emp_salary_textBox;
        private System.Windows.Forms.Label emp_salary_label;
        private System.Windows.Forms.Label label1;

    }
}