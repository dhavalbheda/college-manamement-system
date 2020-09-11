namespace AD_CMS.StudentMgmtSubForms
{
    partial class SearchStudent
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
            this.Student_Detail_dataGridView = new System.Windows.Forms.DataGridView();
            this.instruction_label = new System.Windows.Forms.Label();
            this.student_detail_textBox = new System.Windows.Forms.TextBox();
            this.student_detail_label = new System.Windows.Forms.Label();
            this.select_course_comboBox = new System.Windows.Forms.ComboBox();
            this.select_course_label = new System.Windows.Forms.Label();
            this.student_search_groupBox = new System.Windows.Forms.GroupBox();
            this.update_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Detail_dataGridView)).BeginInit();
            this.student_search_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(366, 5);
            this.heading_label.Size = new System.Drawing.Size(382, 38);
            this.heading_label.Text = "Search Student Detail";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.remove_button);
            this.contentarea_panel.Controls.Add(this.update_button);
            this.contentarea_panel.Controls.Add(this.student_search_groupBox);
            this.contentarea_panel.Controls.Add(this.Student_Detail_dataGridView);
            this.contentarea_panel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Student_Detail_dataGridView
            // 
            this.Student_Detail_dataGridView.AllowUserToAddRows = false;
            this.Student_Detail_dataGridView.AllowUserToDeleteRows = false;
            this.Student_Detail_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Student_Detail_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_Detail_dataGridView.Location = new System.Drawing.Point(47, 23);
            this.Student_Detail_dataGridView.MultiSelect = false;
            this.Student_Detail_dataGridView.Name = "Student_Detail_dataGridView";
            this.Student_Detail_dataGridView.ReadOnly = true;
            this.Student_Detail_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Student_Detail_dataGridView.Size = new System.Drawing.Size(997, 325);
            this.Student_Detail_dataGridView.TabIndex = 0;
            this.Student_Detail_dataGridView.TabStop = false;
            // 
            // instruction_label
            // 
            this.instruction_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.instruction_label.AutoSize = true;
            this.instruction_label.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction_label.Location = new System.Drawing.Point(388, 91);
            this.instruction_label.Name = "instruction_label";
            this.instruction_label.Size = new System.Drawing.Size(200, 16);
            this.instruction_label.TabIndex = 9;
            this.instruction_label.Text = "[enter any single detail of student]";
            // 
            // student_detail_textBox
            // 
            this.student_detail_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.student_detail_textBox.Location = new System.Drawing.Point(207, 83);
            this.student_detail_textBox.Name = "student_detail_textBox";
            this.student_detail_textBox.Size = new System.Drawing.Size(180, 27);
            this.student_detail_textBox.TabIndex = 2;
            this.student_detail_textBox.TextChanged += new System.EventHandler(this.student_detail_textBox_TextChanged);
            // 
            // student_detail_label
            // 
            this.student_detail_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.student_detail_label.AutoSize = true;
            this.student_detail_label.Location = new System.Drawing.Point(32, 86);
            this.student_detail_label.Name = "student_detail_label";
            this.student_detail_label.Size = new System.Drawing.Size(169, 20);
            this.student_detail_label.TabIndex = 7;
            this.student_detail_label.Text = "Enter Student Detail : ";
            // 
            // select_course_comboBox
            // 
            this.select_course_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.select_course_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_course_comboBox.FormattingEnabled = true;
            this.select_course_comboBox.Items.AddRange(new object[] {
            "Select",
            "B.com",
            "BCA",
            "BBA"});
            this.select_course_comboBox.Location = new System.Drawing.Point(206, 40);
            this.select_course_comboBox.Name = "select_course_comboBox";
            this.select_course_comboBox.Size = new System.Drawing.Size(174, 27);
            this.select_course_comboBox.TabIndex = 1;
            this.select_course_comboBox.SelectedIndexChanged += new System.EventHandler(this.select_course_comboBox_SelectedIndexChanged);
            // 
            // select_course_label
            // 
            this.select_course_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.select_course_label.AutoSize = true;
            this.select_course_label.Location = new System.Drawing.Point(32, 43);
            this.select_course_label.Name = "select_course_label";
            this.select_course_label.Size = new System.Drawing.Size(131, 20);
            this.select_course_label.TabIndex = 5;
            this.select_course_label.Text = "*Select Course : ";
            // 
            // student_search_groupBox
            // 
            this.student_search_groupBox.Controls.Add(this.instruction_label);
            this.student_search_groupBox.Controls.Add(this.student_detail_textBox);
            this.student_search_groupBox.Controls.Add(this.student_detail_label);
            this.student_search_groupBox.Controls.Add(this.select_course_comboBox);
            this.student_search_groupBox.Controls.Add(this.select_course_label);
            this.student_search_groupBox.Location = new System.Drawing.Point(233, 373);
            this.student_search_groupBox.Name = "student_search_groupBox";
            this.student_search_groupBox.Size = new System.Drawing.Size(625, 157);
            this.student_search_groupBox.TabIndex = 0;
            this.student_search_groupBox.TabStop = false;
            this.student_search_groupBox.Text = "Search By";
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(351, 566);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(151, 52);
            this.update_button.TabIndex = 3;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(588, 566);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(151, 52);
            this.remove_button.TabIndex = 4;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // SearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "SearchStudent";
            this.Text = "SearchStudent";
            this.Load += new System.EventHandler(this.SearchStudent_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Student_Detail_dataGridView)).EndInit();
            this.student_search_groupBox.ResumeLayout(false);
            this.student_search_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instruction_label;
        private System.Windows.Forms.TextBox student_detail_textBox;
        private System.Windows.Forms.Label student_detail_label;
        private System.Windows.Forms.ComboBox select_course_comboBox;
        private System.Windows.Forms.Label select_course_label;
        public System.Windows.Forms.Button update_button;
        public System.Windows.Forms.Button remove_button;
        public System.Windows.Forms.GroupBox student_search_groupBox;
        public System.Windows.Forms.DataGridView Student_Detail_dataGridView;
    }
}