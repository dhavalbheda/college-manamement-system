namespace AD_CMS.StaffMgmtSubForms
{
    partial class SearchEmployee
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
            this.remove_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.search_groupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emp_details_textBox = new System.Windows.Forms.TextBox();
            this.emp_details_label = new System.Windows.Forms.Label();
            this.select_designation_comboBox = new System.Windows.Forms.ComboBox();
            this.select_designation_label = new System.Windows.Forms.Label();
            this.employee_dataGridView = new System.Windows.Forms.DataGridView();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.search_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(420, 5);
            this.heading_label.Size = new System.Drawing.Size(304, 38);
            this.heading_label.Text = "Search Employee";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.BackColor = System.Drawing.Color.White;
            this.contentarea_panel.Controls.Add(this.employee_dataGridView);
            this.contentarea_panel.Controls.Add(this.remove_button);
            this.contentarea_panel.Controls.Add(this.update_button);
            this.contentarea_panel.Controls.Add(this.search_groupBox);
            this.contentarea_panel.Font = new System.Drawing.Font("Times New Roman", 13F);
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(588, 573);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(151, 52);
            this.remove_button.TabIndex = 2;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(351, 573);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(151, 52);
            this.update_button.TabIndex = 1;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // search_groupBox
            // 
            this.search_groupBox.Controls.Add(this.label4);
            this.search_groupBox.Controls.Add(this.emp_details_textBox);
            this.search_groupBox.Controls.Add(this.emp_details_label);
            this.search_groupBox.Controls.Add(this.select_designation_comboBox);
            this.search_groupBox.Controls.Add(this.select_designation_label);
            this.search_groupBox.Location = new System.Drawing.Point(233, 380);
            this.search_groupBox.Name = "search_groupBox";
            this.search_groupBox.Size = new System.Drawing.Size(625, 157);
            this.search_groupBox.TabIndex = 0;
            this.search_groupBox.TabStop = false;
            this.search_groupBox.Text = "Search By";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "[enter any single detail of student]";
            // 
            // emp_details_textBox
            // 
            this.emp_details_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.emp_details_textBox.Location = new System.Drawing.Point(207, 83);
            this.emp_details_textBox.Name = "emp_details_textBox";
            this.emp_details_textBox.Size = new System.Drawing.Size(180, 27);
            this.emp_details_textBox.TabIndex = 1;
            this.emp_details_textBox.TextChanged += new System.EventHandler(this.emp_details_textBox_TextChanged);
            // 
            // emp_details_label
            // 
            this.emp_details_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.emp_details_label.AutoSize = true;
            this.emp_details_label.Location = new System.Drawing.Point(16, 86);
            this.emp_details_label.Name = "emp_details_label";
            this.emp_details_label.Size = new System.Drawing.Size(186, 20);
            this.emp_details_label.TabIndex = 7;
            this.emp_details_label.Text = "Enter Employee Detail : ";
            // 
            // select_designation_comboBox
            // 
            this.select_designation_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.select_designation_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_designation_comboBox.FormattingEnabled = true;
            this.select_designation_comboBox.Items.AddRange(new object[] {
            "ALL",
            "Teaching",
            "Non-Teaching"});
            this.select_designation_comboBox.Location = new System.Drawing.Point(206, 40);
            this.select_designation_comboBox.Name = "select_designation_comboBox";
            this.select_designation_comboBox.Size = new System.Drawing.Size(174, 27);
            this.select_designation_comboBox.TabIndex = 0;
            this.select_designation_comboBox.SelectedIndexChanged += new System.EventHandler(this.select_designation_comboBox_SelectedIndexChanged);
            // 
            // select_designation_label
            // 
            this.select_designation_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.select_designation_label.AutoSize = true;
            this.select_designation_label.Location = new System.Drawing.Point(32, 43);
            this.select_designation_label.Name = "select_designation_label";
            this.select_designation_label.Size = new System.Drawing.Size(169, 20);
            this.select_designation_label.TabIndex = 5;
            this.select_designation_label.Text = "*Select Designation  : ";
            // 
            // employee_dataGridView
            // 
            this.employee_dataGridView.AllowUserToAddRows = false;
            this.employee_dataGridView.AllowUserToDeleteRows = false;
            this.employee_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employee_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_dataGridView.Location = new System.Drawing.Point(52, 27);
            this.employee_dataGridView.MultiSelect = false;
            this.employee_dataGridView.Name = "employee_dataGridView";
            this.employee_dataGridView.ReadOnly = true;
            this.employee_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employee_dataGridView.Size = new System.Drawing.Size(997, 325);
            this.employee_dataGridView.TabIndex = 3;
            this.employee_dataGridView.TabStop = false;
            // 
            // SearchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "SearchEmployee";
            this.Text = "SearchEmplye";
            this.Load += new System.EventHandler(this.SearchEmployee_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.search_groupBox.ResumeLayout(false);
            this.search_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.GroupBox search_groupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emp_details_textBox;
        private System.Windows.Forms.Label emp_details_label;
        private System.Windows.Forms.ComboBox select_designation_comboBox;
        private System.Windows.Forms.Label select_designation_label;
        public System.Windows.Forms.DataGridView employee_dataGridView;
    }
}