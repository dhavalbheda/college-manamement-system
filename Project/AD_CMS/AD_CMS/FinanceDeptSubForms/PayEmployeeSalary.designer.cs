namespace AD_CMS.FinanceDeptSubForms
{
    partial class PayEmployeeSalary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employee_salary_dataGridView = new System.Windows.Forms.DataGridView();
            this.search_groupBox = new System.Windows.Forms.GroupBox();
            this.empnm_panel = new System.Windows.Forms.Panel();
            this.empnm_textBox2 = new CustomControl.UpperTextBox();
            this.empnm_label2 = new System.Windows.Forms.Label();
            this.empid_panel = new System.Windows.Forms.Panel();
            this.empid_textBox = new CustomControl.NumericTextBox();
            this.empid_label = new System.Windows.Forms.Label();
            this.designation_panel = new System.Windows.Forms.Panel();
            this.designation_comboBox = new System.Windows.Forms.ComboBox();
            this.designation_label = new System.Windows.Forms.Label();
            this.find_button = new System.Windows.Forms.Button();
            this.designation_radioButton = new System.Windows.Forms.RadioButton();
            this.empnm_radioButton = new System.Windows.Forms.RadioButton();
            this.empid_radioButton = new System.Windows.Forms.RadioButton();
            this.emp_details_panel = new System.Windows.Forms.Panel();
            this.pay_sal_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.payment_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sal_month_comboBox = new System.Windows.Forms.ComboBox();
            this.sal_mounth_label = new System.Windows.Forms.Label();
            this.payment_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.amount_label = new System.Windows.Forms.Label();
            this.empnm_textBox = new CustomControl.UpperTextBox();
            this.empnm_label = new System.Windows.Forms.Label();
            this.amount_textBox = new System.Windows.Forms.TextBox();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_salary_dataGridView)).BeginInit();
            this.search_groupBox.SuspendLayout();
            this.empnm_panel.SuspendLayout();
            this.empid_panel.SuspendLayout();
            this.designation_panel.SuspendLayout();
            this.emp_details_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(374, 5);
            this.heading_label.Size = new System.Drawing.Size(367, 38);
            this.heading_label.Text = "Pay Employee Salary";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.emp_details_panel);
            this.contentarea_panel.Controls.Add(this.employee_salary_dataGridView);
            this.contentarea_panel.Controls.Add(this.search_groupBox);
            this.contentarea_panel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // employee_salary_dataGridView
            // 
            this.employee_salary_dataGridView.AllowUserToAddRows = false;
            this.employee_salary_dataGridView.AllowUserToDeleteRows = false;
            this.employee_salary_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employee_salary_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employee_salary_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.employee_salary_dataGridView.Location = new System.Drawing.Point(95, 168);
            this.employee_salary_dataGridView.MultiSelect = false;
            this.employee_salary_dataGridView.Name = "employee_salary_dataGridView";
            this.employee_salary_dataGridView.ReadOnly = true;
            this.employee_salary_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employee_salary_dataGridView.Size = new System.Drawing.Size(901, 221);
            this.employee_salary_dataGridView.TabIndex = 3;
            this.employee_salary_dataGridView.TabStop = false;
            this.employee_salary_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employee_salary_dataGridView_CellDoubleClick);
            // 
            // search_groupBox
            // 
            this.search_groupBox.Controls.Add(this.empnm_panel);
            this.search_groupBox.Controls.Add(this.empid_panel);
            this.search_groupBox.Controls.Add(this.designation_panel);
            this.search_groupBox.Controls.Add(this.find_button);
            this.search_groupBox.Controls.Add(this.designation_radioButton);
            this.search_groupBox.Controls.Add(this.empnm_radioButton);
            this.search_groupBox.Controls.Add(this.empid_radioButton);
            this.search_groupBox.Location = new System.Drawing.Point(163, 12);
            this.search_groupBox.Name = "search_groupBox";
            this.search_groupBox.Size = new System.Drawing.Size(765, 150);
            this.search_groupBox.TabIndex = 0;
            this.search_groupBox.TabStop = false;
            this.search_groupBox.Text = "*Search By : ";
            this.search_groupBox.Enter += new System.EventHandler(this.search_groupBox_Enter);
            // 
            // empnm_panel
            // 
            this.empnm_panel.Controls.Add(this.empnm_textBox2);
            this.empnm_panel.Controls.Add(this.empnm_label2);
            this.empnm_panel.Location = new System.Drawing.Point(19, 70);
            this.empnm_panel.Name = "empnm_panel";
            this.empnm_panel.Size = new System.Drawing.Size(289, 59);
            this.empnm_panel.TabIndex = 3;
            this.empnm_panel.Visible = false;
            // 
            // empnm_textBox2
            // 
            this.empnm_textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.empnm_textBox2.Location = new System.Drawing.Point(155, 17);
            this.empnm_textBox2.Name = "empnm_textBox2";
            this.empnm_textBox2.Size = new System.Drawing.Size(130, 27);
            this.empnm_textBox2.TabIndex = 1;
            this.empnm_textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // empnm_label2
            // 
            this.empnm_label2.AutoSize = true;
            this.empnm_label2.Location = new System.Drawing.Point(5, 20);
            this.empnm_label2.Name = "empnm_label2";
            this.empnm_label2.Size = new System.Drawing.Size(150, 20);
            this.empnm_label2.TabIndex = 0;
            this.empnm_label2.Text = "Employee Name : ";
            // 
            // empid_panel
            // 
            this.empid_panel.Controls.Add(this.empid_textBox);
            this.empid_panel.Controls.Add(this.empid_label);
            this.empid_panel.Location = new System.Drawing.Point(25, 70);
            this.empid_panel.Name = "empid_panel";
            this.empid_panel.Size = new System.Drawing.Size(289, 59);
            this.empid_panel.TabIndex = 1;
            // 
            // empid_textBox
            // 
            this.empid_textBox.Location = new System.Drawing.Point(130, 17);
            this.empid_textBox.MaxLength = 10;
            this.empid_textBox.Name = "empid_textBox";
            this.empid_textBox.Size = new System.Drawing.Size(144, 27);
            this.empid_textBox.TabIndex = 1;
            // 
            // empid_label
            // 
            this.empid_label.AutoSize = true;
            this.empid_label.Location = new System.Drawing.Point(5, 20);
            this.empid_label.Name = "empid_label";
            this.empid_label.Size = new System.Drawing.Size(125, 20);
            this.empid_label.TabIndex = 0;
            this.empid_label.Text = "Employee ID : ";
            // 
            // designation_panel
            // 
            this.designation_panel.Controls.Add(this.designation_comboBox);
            this.designation_panel.Controls.Add(this.designation_label);
            this.designation_panel.Location = new System.Drawing.Point(28, 70);
            this.designation_panel.Name = "designation_panel";
            this.designation_panel.Size = new System.Drawing.Size(289, 59);
            this.designation_panel.TabIndex = 14;
            this.designation_panel.Visible = false;
            // 
            // designation_comboBox
            // 
            this.designation_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.designation_comboBox.FormattingEnabled = true;
            this.designation_comboBox.Items.AddRange(new object[] {
            "All",
            "Teaching",
            "Non-Teaching"});
            this.designation_comboBox.Location = new System.Drawing.Point(118, 17);
            this.designation_comboBox.Name = "designation_comboBox";
            this.designation_comboBox.Size = new System.Drawing.Size(159, 27);
            this.designation_comboBox.TabIndex = 1;
            // 
            // designation_label
            // 
            this.designation_label.AutoSize = true;
            this.designation_label.Location = new System.Drawing.Point(5, 20);
            this.designation_label.Name = "designation_label";
            this.designation_label.Size = new System.Drawing.Size(116, 20);
            this.designation_label.TabIndex = 0;
            this.designation_label.Text = "Designation : ";
            // 
            // find_button
            // 
            this.find_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_button.Location = new System.Drawing.Point(533, 53);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(197, 60);
            this.find_button.TabIndex = 2;
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
            this.designation_radioButton.TabIndex = 0;
            this.designation_radioButton.Text = "Designation ";
            this.designation_radioButton.UseVisualStyleBackColor = true;
            this.designation_radioButton.CheckedChanged += new System.EventHandler(this.Finding_options_CheckedChanged);
            // 
            // empnm_radioButton
            // 
            this.empnm_radioButton.AutoSize = true;
            this.empnm_radioButton.Location = new System.Drawing.Point(174, 36);
            this.empnm_radioButton.Name = "empnm_radioButton";
            this.empnm_radioButton.Size = new System.Drawing.Size(158, 24);
            this.empnm_radioButton.TabIndex = 0;
            this.empnm_radioButton.Text = "Employee Name ";
            this.empnm_radioButton.UseVisualStyleBackColor = true;
            this.empnm_radioButton.CheckedChanged += new System.EventHandler(this.Finding_options_CheckedChanged);
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
            this.empid_radioButton.CheckedChanged += new System.EventHandler(this.Finding_options_CheckedChanged);
            // 
            // emp_details_panel
            // 
            this.emp_details_panel.Controls.Add(this.amount_textBox);
            this.emp_details_panel.Controls.Add(this.pay_sal_button);
            this.emp_details_panel.Controls.Add(this.close_button);
            this.emp_details_panel.Controls.Add(this.payment_dateTimePicker);
            this.emp_details_panel.Controls.Add(this.sal_month_comboBox);
            this.emp_details_panel.Controls.Add(this.sal_mounth_label);
            this.emp_details_panel.Controls.Add(this.payment_label);
            this.emp_details_panel.Controls.Add(this.label7);
            this.emp_details_panel.Controls.Add(this.amount_label);
            this.emp_details_panel.Controls.Add(this.empnm_textBox);
            this.emp_details_panel.Controls.Add(this.empnm_label);
            this.emp_details_panel.Enabled = false;
            this.emp_details_panel.Location = new System.Drawing.Point(217, 395);
            this.emp_details_panel.Name = "emp_details_panel";
            this.emp_details_panel.Size = new System.Drawing.Size(656, 236);
            this.emp_details_panel.TabIndex = 1;
            // 
            // pay_sal_button
            // 
            this.pay_sal_button.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_sal_button.Location = new System.Drawing.Point(101, 172);
            this.pay_sal_button.Name = "pay_sal_button";
            this.pay_sal_button.Size = new System.Drawing.Size(197, 49);
            this.pay_sal_button.TabIndex = 2;
            this.pay_sal_button.Text = "Pay Salary";
            this.pay_sal_button.UseVisualStyleBackColor = true;
            this.pay_sal_button.Click += new System.EventHandler(this.pay_sal_button_Click);
            // 
            // close_button
            // 
            this.close_button.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.Location = new System.Drawing.Point(353, 172);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(197, 49);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // payment_dateTimePicker
            // 
            this.payment_dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_dateTimePicker.Location = new System.Drawing.Point(271, 88);
            this.payment_dateTimePicker.Name = "payment_dateTimePicker";
            this.payment_dateTimePicker.Size = new System.Drawing.Size(279, 27);
            this.payment_dateTimePicker.TabIndex = 2;
            // 
            // sal_month_comboBox
            // 
            this.sal_month_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sal_month_comboBox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_month_comboBox.FormattingEnabled = true;
            this.sal_month_comboBox.Items.AddRange(new object[] {
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
            "NOEMBER",
            "DECEMBER"});
            this.sal_month_comboBox.Location = new System.Drawing.Point(271, 54);
            this.sal_month_comboBox.Name = "sal_month_comboBox";
            this.sal_month_comboBox.Size = new System.Drawing.Size(158, 27);
            this.sal_month_comboBox.TabIndex = 1;
            // 
            // sal_mounth_label
            // 
            this.sal_mounth_label.AutoSize = true;
            this.sal_mounth_label.Location = new System.Drawing.Point(107, 57);
            this.sal_mounth_label.Name = "sal_mounth_label";
            this.sal_mounth_label.Size = new System.Drawing.Size(161, 20);
            this.sal_mounth_label.TabIndex = 8;
            this.sal_mounth_label.Text = "*Salary of Month : ";
            // 
            // payment_label
            // 
            this.payment_label.AutoSize = true;
            this.payment_label.Location = new System.Drawing.Point(107, 94);
            this.payment_label.Name = "payment_label";
            this.payment_label.Size = new System.Drawing.Size(142, 20);
            this.payment_label.TabIndex = 7;
            this.payment_label.Text = "*Payment Date : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(455, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rs.";
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Location = new System.Drawing.Point(107, 130);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(147, 20);
            this.amount_label.TabIndex = 4;
            this.amount_label.Text = "*Amount to Pay :";
            // 
            // empnm_textBox
            // 
            this.empnm_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.empnm_textBox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empnm_textBox.Location = new System.Drawing.Point(271, 16);
            this.empnm_textBox.Name = "empnm_textBox";
            this.empnm_textBox.ReadOnly = true;
            this.empnm_textBox.Size = new System.Drawing.Size(181, 27);
            this.empnm_textBox.TabIndex = 0;
            this.empnm_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // empnm_label
            // 
            this.empnm_label.AutoSize = true;
            this.empnm_label.Location = new System.Drawing.Point(107, 20);
            this.empnm_label.Name = "empnm_label";
            this.empnm_label.Size = new System.Drawing.Size(159, 20);
            this.empnm_label.TabIndex = 2;
            this.empnm_label.Text = "*Employee Name : ";
            // 
            // amount_textBox
            // 
            this.amount_textBox.Location = new System.Drawing.Point(271, 127);
            this.amount_textBox.Name = "amount_textBox";
            this.amount_textBox.ReadOnly = true;
            this.amount_textBox.Size = new System.Drawing.Size(178, 27);
            this.amount_textBox.TabIndex = 9;
            // 
            // PayEmployeeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "PayEmployeeSalary";
            this.Text = "PayEmployeeSalary";
            this.Load += new System.EventHandler(this.PayEmployeeSalary_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_salary_dataGridView)).EndInit();
            this.search_groupBox.ResumeLayout(false);
            this.search_groupBox.PerformLayout();
            this.empnm_panel.ResumeLayout(false);
            this.empnm_panel.PerformLayout();
            this.empid_panel.ResumeLayout(false);
            this.empid_panel.PerformLayout();
            this.designation_panel.ResumeLayout(false);
            this.designation_panel.PerformLayout();
            this.emp_details_panel.ResumeLayout(false);
            this.emp_details_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employee_salary_dataGridView;
        private System.Windows.Forms.GroupBox search_groupBox;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.RadioButton designation_radioButton;
        private System.Windows.Forms.RadioButton empnm_radioButton;
        private System.Windows.Forms.RadioButton empid_radioButton;
        private System.Windows.Forms.Panel emp_details_panel;
        private System.Windows.Forms.Label sal_mounth_label;
        private System.Windows.Forms.Label payment_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label amount_label;
        private CustomControl.UpperTextBox empnm_textBox;
        private System.Windows.Forms.Label empnm_label;
        private System.Windows.Forms.DateTimePicker payment_dateTimePicker;
        private System.Windows.Forms.ComboBox sal_month_comboBox;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button pay_sal_button;
        private System.Windows.Forms.Panel designation_panel;
        private System.Windows.Forms.ComboBox designation_comboBox;
        private System.Windows.Forms.Label designation_label;
        private System.Windows.Forms.Panel empnm_panel;
        private CustomControl.UpperTextBox empnm_textBox2;
        private System.Windows.Forms.Label empnm_label2;
        private System.Windows.Forms.Panel empid_panel;
        private CustomControl.NumericTextBox empid_textBox;
        private System.Windows.Forms.Label empid_label;
        private System.Windows.Forms.TextBox amount_textBox;
    }
}