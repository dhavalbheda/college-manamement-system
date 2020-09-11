namespace AD_CMS.Course
{
    partial class UpdateCourseDetails
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
            this.update_course_tabControl = new System.Windows.Forms.TabControl();
            this.course_details_tabPage = new System.Windows.Forms.TabPage();
            this.Course_dataGridView = new System.Windows.Forms.DataGridView();
            this.subject_details_tabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.select_course_combobox = new CustomControl.CustomComboBox();
            this.subject_dataGridView = new System.Windows.Forms.DataGridView();
            this.course_fee_tabPage = new System.Windows.Forms.TabPage();
            this.course_fee_groupBox = new System.Windows.Forms.GroupBox();
            this.instruction_label2 = new System.Windows.Forms.Label();
            this.instruction_label = new System.Windows.Forms.Label();
            this.total_fee_label = new System.Windows.Forms.Label();
            this.total_fee_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.set_fee_TextBox = new CustomControl.NumericTextBox();
            this.select_course_comboBox3 = new System.Windows.Forms.ComboBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.update_button3 = new System.Windows.Forms.Button();
            this.set_fee_label = new System.Windows.Forms.Label();
            this.select_course_label3 = new System.Windows.Forms.Label();
            this.fee_dataGridView = new System.Windows.Forms.DataGridView();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            this.update_course_tabControl.SuspendLayout();
            this.course_details_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Course_dataGridView)).BeginInit();
            this.subject_details_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subject_dataGridView)).BeginInit();
            this.course_fee_tabPage.SuspendLayout();
            this.course_fee_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fee_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(384, 5);
            this.heading_label.Size = new System.Drawing.Size(389, 38);
            this.heading_label.Text = "Update Course Details";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.update_course_tabControl);
            this.contentarea_panel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // update_course_tabControl
            // 
            this.update_course_tabControl.Controls.Add(this.course_details_tabPage);
            this.update_course_tabControl.Controls.Add(this.subject_details_tabPage);
            this.update_course_tabControl.Controls.Add(this.course_fee_tabPage);
            this.update_course_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.update_course_tabControl.Location = new System.Drawing.Point(0, 0);
            this.update_course_tabControl.Name = "update_course_tabControl";
            this.update_course_tabControl.SelectedIndex = 0;
            this.update_course_tabControl.Size = new System.Drawing.Size(1090, 654);
            this.update_course_tabControl.TabIndex = 2;
            this.update_course_tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.update_course_tabControl_Selected);
            // 
            // course_details_tabPage
            // 
            this.course_details_tabPage.Controls.Add(this.Course_dataGridView);
            this.course_details_tabPage.Location = new System.Drawing.Point(4, 28);
            this.course_details_tabPage.Name = "course_details_tabPage";
            this.course_details_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.course_details_tabPage.Size = new System.Drawing.Size(1082, 622);
            this.course_details_tabPage.TabIndex = 0;
            this.course_details_tabPage.Text = "Course Details";
            this.course_details_tabPage.UseVisualStyleBackColor = true;
            this.course_details_tabPage.BackColor = Properties.Settings.Default.TemplateBack;
            // 
            // Course_dataGridView
            // 
            this.Course_dataGridView.AllowUserToAddRows = false;
            this.Course_dataGridView.AllowUserToDeleteRows = false;
            this.Course_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Course_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Course_dataGridView.Location = new System.Drawing.Point(57, 111);
            this.Course_dataGridView.Name = "Course_dataGridView";
            this.Course_dataGridView.ReadOnly = true;
            this.Course_dataGridView.Size = new System.Drawing.Size(968, 401);
            this.Course_dataGridView.TabIndex = 1;
            this.Course_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Course_dataGridView_CellClick);
            // 
            // subject_details_tabPage
            // 
            this.subject_details_tabPage.Controls.Add(this.label2);
            this.subject_details_tabPage.Controls.Add(this.select_course_combobox);
            this.subject_details_tabPage.Controls.Add(this.subject_dataGridView);
            this.subject_details_tabPage.Location = new System.Drawing.Point(4, 28);
            this.subject_details_tabPage.Name = "subject_details_tabPage";
            this.subject_details_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.subject_details_tabPage.Size = new System.Drawing.Size(1082, 622);
            this.subject_details_tabPage.TabIndex = 1;
            this.subject_details_tabPage.Text = "Subject Details";
            this.subject_details_tabPage.UseVisualStyleBackColor = true;
            this.subject_details_tabPage.BackColor = Properties.Settings.Default.TemplateBack;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Course : ";
            // 
            // select_course_combobox
            // 
            this.select_course_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_course_combobox.FormattingEnabled = true;
            this.select_course_combobox.Location = new System.Drawing.Point(426, 37);
            this.select_course_combobox.Name = "select_course_combobox";
            this.select_course_combobox.Size = new System.Drawing.Size(466, 27);
            this.select_course_combobox.TabIndex = 4;
            this.select_course_combobox.SelectedIndexChanged += new System.EventHandler(this.select_course_combobox_SelectedIndexChanged);
            // 
            // subject_dataGridView
            // 
            this.subject_dataGridView.AllowUserToAddRows = false;
            this.subject_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subject_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subject_dataGridView.Location = new System.Drawing.Point(106, 163);
            this.subject_dataGridView.Name = "subject_dataGridView";
            this.subject_dataGridView.Size = new System.Drawing.Size(886, 370);
            this.subject_dataGridView.TabIndex = 3;
            this.subject_dataGridView.TabStop = false;
            this.subject_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subject_dataGridView_CellClick);
            // 
            // course_fee_tabPage
            // 
            this.course_fee_tabPage.Controls.Add(this.course_fee_groupBox);
            this.course_fee_tabPage.Controls.Add(this.fee_dataGridView);
            this.course_fee_tabPage.Location = new System.Drawing.Point(4, 28);
            this.course_fee_tabPage.Name = "course_fee_tabPage";
            this.course_fee_tabPage.Size = new System.Drawing.Size(1082, 622);
            this.course_fee_tabPage.TabIndex = 2;
            this.course_fee_tabPage.Text = "Course Fee Details ";
            this.course_fee_tabPage.UseVisualStyleBackColor = true;
            this.course_fee_tabPage.BackColor = Properties.Settings.Default.TemplateBack;
            // 
            // course_fee_groupBox
            // 
            this.course_fee_groupBox.Controls.Add(this.instruction_label2);
            this.course_fee_groupBox.Controls.Add(this.instruction_label);
            this.course_fee_groupBox.Controls.Add(this.total_fee_label);
            this.course_fee_groupBox.Controls.Add(this.total_fee_textBox);
            this.course_fee_groupBox.Controls.Add(this.label1);
            this.course_fee_groupBox.Controls.Add(this.label11);
            this.course_fee_groupBox.Controls.Add(this.set_fee_TextBox);
            this.course_fee_groupBox.Controls.Add(this.select_course_comboBox3);
            this.course_fee_groupBox.Controls.Add(this.clear_button);
            this.course_fee_groupBox.Controls.Add(this.update_button3);
            this.course_fee_groupBox.Controls.Add(this.set_fee_label);
            this.course_fee_groupBox.Controls.Add(this.select_course_label3);
            this.course_fee_groupBox.Location = new System.Drawing.Point(173, 303);
            this.course_fee_groupBox.Name = "course_fee_groupBox";
            this.course_fee_groupBox.Size = new System.Drawing.Size(736, 287);
            this.course_fee_groupBox.TabIndex = 0;
            this.course_fee_groupBox.TabStop = false;
            this.course_fee_groupBox.Text = "*Course Fee ";
            // 
            // instruction_label2
            // 
            this.instruction_label2.AutoSize = true;
            this.instruction_label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction_label2.Location = new System.Drawing.Point(526, 159);
            this.instruction_label2.Name = "instruction_label2";
            this.instruction_label2.Size = new System.Drawing.Size(0, 16);
            this.instruction_label2.TabIndex = 29;
            // 
            // instruction_label
            // 
            this.instruction_label.AutoSize = true;
            this.instruction_label.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction_label.Location = new System.Drawing.Point(518, 107);
            this.instruction_label.Name = "instruction_label";
            this.instruction_label.Size = new System.Drawing.Size(72, 16);
            this.instruction_label.TabIndex = 26;
            this.instruction_label.Text = "[ per year ]";
            // 
            // total_fee_label
            // 
            this.total_fee_label.AutoSize = true;
            this.total_fee_label.Location = new System.Drawing.Point(169, 160);
            this.total_fee_label.Name = "total_fee_label";
            this.total_fee_label.Size = new System.Drawing.Size(94, 20);
            this.total_fee_label.TabIndex = 25;
            this.total_fee_label.Text = "Total Fee : ";
            // 
            // total_fee_textBox
            // 
            this.total_fee_textBox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_fee_textBox.Location = new System.Drawing.Point(313, 153);
            this.total_fee_textBox.Name = "total_fee_textBox";
            this.total_fee_textBox.ReadOnly = true;
            this.total_fee_textBox.Size = new System.Drawing.Size(159, 27);
            this.total_fee_textBox.TabIndex = 2;
            this.total_fee_textBox.Text = "0";
            this.total_fee_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Rs.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(480, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Rs.";
            // 
            // set_fee_TextBox
            // 
            this.set_fee_TextBox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_fee_TextBox.Location = new System.Drawing.Point(313, 100);
            this.set_fee_TextBox.MaxLength = 7;
            this.set_fee_TextBox.Name = "set_fee_TextBox";
            this.set_fee_TextBox.Size = new System.Drawing.Size(166, 27);
            this.set_fee_TextBox.TabIndex = 1;
            this.set_fee_TextBox.Text = "0";
            this.set_fee_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.set_fee_TextBox.TextChanged += new System.EventHandler(this.coursefee_textChanged);
            // 
            // select_course_comboBox3
            // 
            this.select_course_comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_course_comboBox3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_course_comboBox3.FormattingEnabled = true;
            this.select_course_comboBox3.Items.AddRange(new object[] {
            "Select"});
            this.select_course_comboBox3.Location = new System.Drawing.Point(314, 48);
            this.select_course_comboBox3.Name = "select_course_comboBox3";
            this.select_course_comboBox3.Size = new System.Drawing.Size(142, 27);
            this.select_course_comboBox3.TabIndex = 0;
            this.select_course_comboBox3.TextChanged += new System.EventHandler(this.coursefee_textChanged);
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(417, 207);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(197, 60);
            this.clear_button.TabIndex = 4;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // update_button3
            // 
            this.update_button3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button3.Location = new System.Drawing.Point(122, 207);
            this.update_button3.Name = "update_button3";
            this.update_button3.Size = new System.Drawing.Size(197, 60);
            this.update_button3.TabIndex = 3;
            this.update_button3.Text = "Update ";
            this.update_button3.UseVisualStyleBackColor = true;
            this.update_button3.Click += new System.EventHandler(this.update_button3_Click);
            // 
            // set_fee_label
            // 
            this.set_fee_label.AutoSize = true;
            this.set_fee_label.Location = new System.Drawing.Point(169, 103);
            this.set_fee_label.Name = "set_fee_label";
            this.set_fee_label.Size = new System.Drawing.Size(79, 20);
            this.set_fee_label.TabIndex = 15;
            this.set_fee_label.Text = "Set Fee : ";
            // 
            // select_course_label3
            // 
            this.select_course_label3.AutoSize = true;
            this.select_course_label3.Location = new System.Drawing.Point(154, 48);
            this.select_course_label3.Name = "select_course_label3";
            this.select_course_label3.Size = new System.Drawing.Size(129, 20);
            this.select_course_label3.TabIndex = 16;
            this.select_course_label3.Text = "Select Course : ";
            // 
            // fee_dataGridView
            // 
            this.fee_dataGridView.AllowUserToAddRows = false;
            this.fee_dataGridView.AllowUserToDeleteRows = false;
            this.fee_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fee_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fee_dataGridView.Location = new System.Drawing.Point(90, 32);
            this.fee_dataGridView.MultiSelect = false;
            this.fee_dataGridView.Name = "fee_dataGridView";
            this.fee_dataGridView.ReadOnly = true;
            this.fee_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fee_dataGridView.Size = new System.Drawing.Size(902, 231);
            this.fee_dataGridView.TabIndex = 3;
            this.fee_dataGridView.TabStop = false;
            // 
            // UpdateCourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "UpdateCourseDetails";
            this.Text = "UpdateCourseDetails";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            this.update_course_tabControl.ResumeLayout(false);
            this.course_details_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Course_dataGridView)).EndInit();
            this.subject_details_tabPage.ResumeLayout(false);
            this.subject_details_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subject_dataGridView)).EndInit();
            this.course_fee_tabPage.ResumeLayout(false);
            this.course_fee_groupBox.ResumeLayout(false);
            this.course_fee_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fee_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl update_course_tabControl;
        private System.Windows.Forms.TabPage course_details_tabPage;
        private System.Windows.Forms.TabPage subject_details_tabPage;
        private System.Windows.Forms.TabPage course_fee_tabPage;
        private System.Windows.Forms.DataGridView subject_dataGridView;
        private System.Windows.Forms.DataGridView fee_dataGridView;
        private System.Windows.Forms.GroupBox course_fee_groupBox;
        private System.Windows.Forms.Label total_fee_label;
        private System.Windows.Forms.TextBox total_fee_textBox;
        private System.Windows.Forms.Label label11;
        private CustomControl.NumericTextBox set_fee_TextBox;
        private System.Windows.Forms.ComboBox select_course_comboBox3;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button update_button3;
        private System.Windows.Forms.Label set_fee_label;
        private System.Windows.Forms.Label select_course_label3;
        private System.Windows.Forms.Label instruction_label;
        private System.Windows.Forms.Label instruction_label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Course_dataGridView;
        private System.Windows.Forms.Label label2;
        private CustomControl.CustomComboBox select_course_combobox;
    }
}