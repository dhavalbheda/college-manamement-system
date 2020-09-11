namespace AD_CMS.FinanceDeptSubForms
{
    partial class ViewEmployeeSalaryDetails
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
            this.status_groupBox = new System.Windows.Forms.GroupBox();
            this.all_radioButton = new System.Windows.Forms.RadioButton();
            this.due_radioButton = new System.Windows.Forms.RadioButton();
            this.paid_radioButton = new System.Windows.Forms.RadioButton();
            this.view_emp_sal_panel = new System.Windows.Forms.Panel();
            this.sal_month_comboBox = new System.Windows.Forms.ComboBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.find_button = new System.Windows.Forms.Button();
            this.view_emp_sal_dataGridView = new System.Windows.Forms.DataGridView();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.status_groupBox.SuspendLayout();
            this.view_emp_sal_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_emp_sal_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(304, 5);
            this.heading_label.Size = new System.Drawing.Size(506, 38);
            this.heading_label.Text = "View Empoyee Salary Details";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.view_emp_sal_dataGridView);
            this.contentarea_panel.Controls.Add(this.view_emp_sal_panel);
            this.contentarea_panel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // status_groupBox
            // 
            this.status_groupBox.Controls.Add(this.all_radioButton);
            this.status_groupBox.Controls.Add(this.due_radioButton);
            this.status_groupBox.Controls.Add(this.paid_radioButton);
            this.status_groupBox.Location = new System.Drawing.Point(38, 84);
            this.status_groupBox.Name = "status_groupBox";
            this.status_groupBox.Size = new System.Drawing.Size(343, 74);
            this.status_groupBox.TabIndex = 4;
            this.status_groupBox.TabStop = false;
            this.status_groupBox.Text = "*Payment Status";
            // 
            // all_radioButton
            // 
            this.all_radioButton.AutoSize = true;
            this.all_radioButton.Location = new System.Drawing.Point(229, 32);
            this.all_radioButton.Name = "all_radioButton";
            this.all_radioButton.Size = new System.Drawing.Size(51, 26);
            this.all_radioButton.TabIndex = 1;
            this.all_radioButton.Text = "All";
            this.all_radioButton.UseVisualStyleBackColor = true;
            // 
            // due_radioButton
            // 
            this.due_radioButton.AutoSize = true;
            this.due_radioButton.Location = new System.Drawing.Point(130, 32);
            this.due_radioButton.Name = "due_radioButton";
            this.due_radioButton.Size = new System.Drawing.Size(61, 26);
            this.due_radioButton.TabIndex = 1;
            this.due_radioButton.Text = "Due";
            this.due_radioButton.UseVisualStyleBackColor = true;
            // 
            // paid_radioButton
            // 
            this.paid_radioButton.AutoSize = true;
            this.paid_radioButton.Checked = true;
            this.paid_radioButton.Location = new System.Drawing.Point(24, 32);
            this.paid_radioButton.Name = "paid_radioButton";
            this.paid_radioButton.Size = new System.Drawing.Size(65, 26);
            this.paid_radioButton.TabIndex = 0;
            this.paid_radioButton.TabStop = true;
            this.paid_radioButton.Text = "Paid";
            this.paid_radioButton.UseVisualStyleBackColor = true;
            // 
            // view_emp_sal_panel
            // 
            this.view_emp_sal_panel.Controls.Add(this.sal_month_comboBox);
            this.view_emp_sal_panel.Controls.Add(this.clear_button);
            this.view_emp_sal_panel.Controls.Add(this.label1);
            this.view_emp_sal_panel.Controls.Add(this.find_button);
            this.view_emp_sal_panel.Controls.Add(this.status_groupBox);
            this.view_emp_sal_panel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_emp_sal_panel.Location = new System.Drawing.Point(214, 6);
            this.view_emp_sal_panel.Name = "view_emp_sal_panel";
            this.view_emp_sal_panel.Size = new System.Drawing.Size(663, 188);
            this.view_emp_sal_panel.TabIndex = 0;
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
            this.sal_month_comboBox.Location = new System.Drawing.Point(183, 32);
            this.sal_month_comboBox.Name = "sal_month_comboBox";
            this.sal_month_comboBox.Size = new System.Drawing.Size(158, 27);
            this.sal_month_comboBox.TabIndex = 15;
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(442, 109);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(182, 49);
            this.clear_button.TabIndex = 6;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Select Month : ";
            // 
            // find_button
            // 
            this.find_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_button.Location = new System.Drawing.Point(442, 33);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(182, 42);
            this.find_button.TabIndex = 5;
            this.find_button.Text = "Find";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // view_emp_sal_dataGridView
            // 
            this.view_emp_sal_dataGridView.AllowUserToAddRows = false;
            this.view_emp_sal_dataGridView.AllowUserToDeleteRows = false;
            this.view_emp_sal_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_emp_sal_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_emp_sal_dataGridView.Location = new System.Drawing.Point(108, 219);
            this.view_emp_sal_dataGridView.MultiSelect = false;
            this.view_emp_sal_dataGridView.Name = "view_emp_sal_dataGridView";
            this.view_emp_sal_dataGridView.ReadOnly = true;
            this.view_emp_sal_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_emp_sal_dataGridView.Size = new System.Drawing.Size(875, 402);
            this.view_emp_sal_dataGridView.TabIndex = 14;
            this.view_emp_sal_dataGridView.TabStop = false;
            // 
            // ViewEmployeeSalaryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "ViewEmployeeSalaryDetails";
            this.Text = "ViewEmployeeSalaryDetails";
            this.Load += new System.EventHandler(this.ViewEmployeeSalaryDetails_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.status_groupBox.ResumeLayout(false);
            this.status_groupBox.PerformLayout();
            this.view_emp_sal_panel.ResumeLayout(false);
            this.view_emp_sal_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_emp_sal_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox status_groupBox;
        private System.Windows.Forms.Panel view_emp_sal_panel;
        private System.Windows.Forms.RadioButton due_radioButton;
        private System.Windows.Forms.RadioButton paid_radioButton;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.DataGridView view_emp_sal_dataGridView;
        private System.Windows.Forms.RadioButton all_radioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sal_month_comboBox;
    }
}