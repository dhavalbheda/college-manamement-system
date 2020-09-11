namespace AD_CMS.FinanceDeptSubForms
{
    partial class StudentFeeCollection
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
            this.student_nm_label = new System.Windows.Forms.Label();
            this.grno_label = new System.Windows.Forms.Label();
            this.collectedfee_label = new System.Windows.Forms.Label();
            this.patment_date_label = new System.Windows.Forms.Label();
            this.grno_textBox = new CustomControl.NumericTextBox();
            this.studentnm_textBox = new CustomControl.UpperTextBox();
            this.payment_date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.all_student_nm_dataGridView = new System.Windows.Forms.DataGridView();
            this.fee_collection_panel = new System.Windows.Forms.Panel();
            this.collected_fee_textBox = new System.Windows.Forms.TextBox();
            this.clear_fee_button = new System.Windows.Forms.Button();
            this.paymentyear_label = new System.Windows.Forms.Label();
            this.collect_fee_button = new System.Windows.Forms.Button();
            this.paymentyear_comboBox = new System.Windows.Forms.ComboBox();
            this.filter_groupBox = new System.Windows.Forms.GroupBox();
            this.select_sem_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.studentnm_filter_textBox = new CustomControl.UpperTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.course_label = new System.Windows.Forms.Label();
            this.select_sem_label = new System.Windows.Forms.Label();
            this.clear_filter_button = new System.Windows.Forms.Button();
            this.course_comboBox = new System.Windows.Forms.ComboBox();
            this.filter_button = new System.Windows.Forms.Button();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_student_nm_dataGridView)).BeginInit();
            this.fee_collection_panel.SuspendLayout();
            this.filter_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_sem_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_panel
            // 
            this.heading_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.heading_panel.Size = new System.Drawing.Size(1114, 51);
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(360, 6);
            this.heading_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heading_label.Size = new System.Drawing.Size(394, 38);
            this.heading_label.Text = "Student Fee Collection";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 51);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter1.Size = new System.Drawing.Size(18, 652);
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.filter_groupBox);
            this.contentarea_panel.Controls.Add(this.fee_collection_panel);
            this.contentarea_panel.Controls.Add(this.all_student_nm_dataGridView);
            this.contentarea_panel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentarea_panel.Location = new System.Drawing.Point(18, 51);
            this.contentarea_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contentarea_panel.Size = new System.Drawing.Size(1078, 652);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(18, 691);
            this.splitter3.Size = new System.Drawing.Size(1078, 12);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(1096, 51);
            this.splitter2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter2.Size = new System.Drawing.Size(18, 652);
            // 
            // student_nm_label
            // 
            this.student_nm_label.AutoSize = true;
            this.student_nm_label.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_nm_label.Location = new System.Drawing.Point(48, 40);
            this.student_nm_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.student_nm_label.Name = "student_nm_label";
            this.student_nm_label.Size = new System.Drawing.Size(143, 20);
            this.student_nm_label.TabIndex = 2;
            this.student_nm_label.Text = "*Student Name : ";
            // 
            // grno_label
            // 
            this.grno_label.AutoSize = true;
            this.grno_label.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grno_label.Location = new System.Drawing.Point(48, 8);
            this.grno_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grno_label.Name = "grno_label";
            this.grno_label.Size = new System.Drawing.Size(103, 20);
            this.grno_label.TabIndex = 1;
            this.grno_label.Text = "*G.R. No. : ";
            // 
            // collectedfee_label
            // 
            this.collectedfee_label.AutoSize = true;
            this.collectedfee_label.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectedfee_label.Location = new System.Drawing.Point(48, 138);
            this.collectedfee_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.collectedfee_label.Name = "collectedfee_label";
            this.collectedfee_label.Size = new System.Drawing.Size(137, 20);
            this.collectedfee_label.TabIndex = 4;
            this.collectedfee_label.Text = "*Collected Fee : ";
            // 
            // patment_date_label
            // 
            this.patment_date_label.AutoSize = true;
            this.patment_date_label.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patment_date_label.Location = new System.Drawing.Point(48, 75);
            this.patment_date_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patment_date_label.Name = "patment_date_label";
            this.patment_date_label.Size = new System.Drawing.Size(142, 20);
            this.patment_date_label.TabIndex = 3;
            this.patment_date_label.Text = "*Payment Date : ";
            // 
            // grno_textBox
            // 
            this.grno_textBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grno_textBox.Location = new System.Drawing.Point(224, 5);
            this.grno_textBox.MaxLength = 10;
            this.grno_textBox.Name = "grno_textBox";
            this.grno_textBox.ReadOnly = true;
            this.grno_textBox.Size = new System.Drawing.Size(113, 27);
            this.grno_textBox.TabIndex = 2;
            this.grno_textBox.TabStop = false;
            this.grno_textBox.TextChanged += new System.EventHandler(this.Controls_TextChanged);
            // 
            // studentnm_textBox
            // 
            this.studentnm_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.studentnm_textBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentnm_textBox.Location = new System.Drawing.Point(224, 37);
            this.studentnm_textBox.Name = "studentnm_textBox";
            this.studentnm_textBox.ReadOnly = true;
            this.studentnm_textBox.Size = new System.Drawing.Size(236, 27);
            this.studentnm_textBox.TabIndex = 3;
            this.studentnm_textBox.TabStop = false;
            this.studentnm_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.studentnm_textBox.TextChanged += new System.EventHandler(this.Controls_TextChanged);
            // 
            // payment_date_dateTimePicker
            // 
            this.payment_date_dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_date_dateTimePicker.Location = new System.Drawing.Point(224, 69);
            this.payment_date_dateTimePicker.Name = "payment_date_dateTimePicker";
            this.payment_date_dateTimePicker.Size = new System.Drawing.Size(263, 27);
            this.payment_date_dateTimePicker.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(391, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Rs.";
            // 
            // all_student_nm_dataGridView
            // 
            this.all_student_nm_dataGridView.AllowUserToAddRows = false;
            this.all_student_nm_dataGridView.AllowUserToDeleteRows = false;
            this.all_student_nm_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.all_student_nm_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.all_student_nm_dataGridView.Location = new System.Drawing.Point(7, 252);
            this.all_student_nm_dataGridView.Name = "all_student_nm_dataGridView";
            this.all_student_nm_dataGridView.ReadOnly = true;
            this.all_student_nm_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.all_student_nm_dataGridView.Size = new System.Drawing.Size(1064, 369);
            this.all_student_nm_dataGridView.TabIndex = 12;
            this.all_student_nm_dataGridView.TabStop = false;
            this.all_student_nm_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.all_student_nm_dataGridView_CellDoubleClick);
            // 
            // fee_collection_panel
            // 
            this.fee_collection_panel.Controls.Add(this.collected_fee_textBox);
            this.fee_collection_panel.Controls.Add(this.clear_fee_button);
            this.fee_collection_panel.Controls.Add(this.paymentyear_label);
            this.fee_collection_panel.Controls.Add(this.grno_label);
            this.fee_collection_panel.Controls.Add(this.collect_fee_button);
            this.fee_collection_panel.Controls.Add(this.student_nm_label);
            this.fee_collection_panel.Controls.Add(this.paymentyear_comboBox);
            this.fee_collection_panel.Controls.Add(this.patment_date_label);
            this.fee_collection_panel.Controls.Add(this.collectedfee_label);
            this.fee_collection_panel.Controls.Add(this.grno_textBox);
            this.fee_collection_panel.Controls.Add(this.label8);
            this.fee_collection_panel.Controls.Add(this.studentnm_textBox);
            this.fee_collection_panel.Controls.Add(this.payment_date_dateTimePicker);
            this.fee_collection_panel.Enabled = false;
            this.fee_collection_panel.Location = new System.Drawing.Point(554, 8);
            this.fee_collection_panel.Name = "fee_collection_panel";
            this.fee_collection_panel.Size = new System.Drawing.Size(517, 238);
            this.fee_collection_panel.TabIndex = 1;
            // 
            // collected_fee_textBox
            // 
            this.collected_fee_textBox.Location = new System.Drawing.Point(224, 140);
            this.collected_fee_textBox.Name = "collected_fee_textBox";
            this.collected_fee_textBox.Size = new System.Drawing.Size(160, 26);
            this.collected_fee_textBox.TabIndex = 11;
            // 
            // clear_fee_button
            // 
            this.clear_fee_button.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_fee_button.Location = new System.Drawing.Point(261, 177);
            this.clear_fee_button.Name = "clear_fee_button";
            this.clear_fee_button.Size = new System.Drawing.Size(146, 45);
            this.clear_fee_button.TabIndex = 3;
            this.clear_fee_button.Text = "Clear";
            this.clear_fee_button.UseVisualStyleBackColor = true;
            this.clear_fee_button.Click += new System.EventHandler(this.clear_fee_button_Click);
            // 
            // paymentyear_label
            // 
            this.paymentyear_label.AutoSize = true;
            this.paymentyear_label.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentyear_label.Location = new System.Drawing.Point(48, 106);
            this.paymentyear_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentyear_label.Name = "paymentyear_label";
            this.paymentyear_label.Size = new System.Drawing.Size(144, 20);
            this.paymentyear_label.TabIndex = 10;
            this.paymentyear_label.Text = "*Payment Year  : ";
            // 
            // collect_fee_button
            // 
            this.collect_fee_button.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collect_fee_button.Location = new System.Drawing.Point(32, 177);
            this.collect_fee_button.Name = "collect_fee_button";
            this.collect_fee_button.Size = new System.Drawing.Size(192, 45);
            this.collect_fee_button.TabIndex = 2;
            this.collect_fee_button.Text = "Collect Fee";
            this.collect_fee_button.UseVisualStyleBackColor = true;
            this.collect_fee_button.Click += new System.EventHandler(this.collect_button_Click);
            // 
            // paymentyear_comboBox
            // 
            this.paymentyear_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentyear_comboBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentyear_comboBox.FormattingEnabled = true;
            this.paymentyear_comboBox.Location = new System.Drawing.Point(224, 102);
            this.paymentyear_comboBox.Name = "paymentyear_comboBox";
            this.paymentyear_comboBox.Size = new System.Drawing.Size(163, 27);
            this.paymentyear_comboBox.TabIndex = 0;
            this.paymentyear_comboBox.TextChanged += new System.EventHandler(this.Controls_TextChanged);
            // 
            // filter_groupBox
            // 
            this.filter_groupBox.Controls.Add(this.select_sem_numericUpDown);
            this.filter_groupBox.Controls.Add(this.studentnm_filter_textBox);
            this.filter_groupBox.Controls.Add(this.label1);
            this.filter_groupBox.Controls.Add(this.course_label);
            this.filter_groupBox.Controls.Add(this.select_sem_label);
            this.filter_groupBox.Controls.Add(this.clear_filter_button);
            this.filter_groupBox.Controls.Add(this.course_comboBox);
            this.filter_groupBox.Controls.Add(this.filter_button);
            this.filter_groupBox.Location = new System.Drawing.Point(7, 13);
            this.filter_groupBox.Name = "filter_groupBox";
            this.filter_groupBox.Size = new System.Drawing.Size(453, 186);
            this.filter_groupBox.TabIndex = 0;
            this.filter_groupBox.TabStop = false;
            this.filter_groupBox.Text = "Filter Detail";
            // 
            // select_sem_numericUpDown
            // 
            this.select_sem_numericUpDown.Location = new System.Drawing.Point(233, 55);
            this.select_sem_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.select_sem_numericUpDown.Name = "select_sem_numericUpDown";
            this.select_sem_numericUpDown.Size = new System.Drawing.Size(49, 26);
            this.select_sem_numericUpDown.TabIndex = 10;
            this.select_sem_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // studentnm_filter_textBox
            // 
            this.studentnm_filter_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.studentnm_filter_textBox.Location = new System.Drawing.Point(233, 86);
            this.studentnm_filter_textBox.Name = "studentnm_filter_textBox";
            this.studentnm_filter_textBox.Size = new System.Drawing.Size(163, 26);
            this.studentnm_filter_textBox.TabIndex = 2;
            this.studentnm_filter_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.studentnm_filter_textBox.TextChanged += new System.EventHandler(this.studentnm_filter_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student Name : ";
            // 
            // course_label
            // 
            this.course_label.AutoSize = true;
            this.course_label.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_label.Location = new System.Drawing.Point(57, 23);
            this.course_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.course_label.Name = "course_label";
            this.course_label.Size = new System.Drawing.Size(138, 20);
            this.course_label.TabIndex = 9;
            this.course_label.Text = "*Select Course : ";
            // 
            // select_sem_label
            // 
            this.select_sem_label.AutoSize = true;
            this.select_sem_label.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_sem_label.Location = new System.Drawing.Point(57, 56);
            this.select_sem_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.select_sem_label.Name = "select_sem_label";
            this.select_sem_label.Size = new System.Drawing.Size(152, 20);
            this.select_sem_label.TabIndex = 9;
            this.select_sem_label.Text = "*Select Semester : ";
            // 
            // clear_filter_button
            // 
            this.clear_filter_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_filter_button.Location = new System.Drawing.Point(247, 130);
            this.clear_filter_button.Name = "clear_filter_button";
            this.clear_filter_button.Size = new System.Drawing.Size(165, 45);
            this.clear_filter_button.TabIndex = 4;
            this.clear_filter_button.Text = "Clear";
            this.clear_filter_button.UseVisualStyleBackColor = true;
            this.clear_filter_button.Click += new System.EventHandler(this.clear_filter_button_Click);
            // 
            // course_comboBox
            // 
            this.course_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course_comboBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_comboBox.FormattingEnabled = true;
            this.course_comboBox.Items.AddRange(new object[] {
            "Select",
            "Sem-1",
            "Sem-2",
            "Sem-3",
            "Sem-4",
            "Sem-5",
            "Sem-6"});
            this.course_comboBox.Location = new System.Drawing.Point(233, 20);
            this.course_comboBox.Name = "course_comboBox";
            this.course_comboBox.Size = new System.Drawing.Size(163, 27);
            this.course_comboBox.TabIndex = 1;
            this.course_comboBox.TextChanged += new System.EventHandler(this.Controls_TextChanged);
            // 
            // filter_button
            // 
            this.filter_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_button.Location = new System.Drawing.Point(40, 130);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(169, 48);
            this.filter_button.TabIndex = 3;
            this.filter_button.Text = "Search";
            this.filter_button.UseVisualStyleBackColor = true;
            this.filter_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // StudentFeeCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StudentFeeCollection";
            this.Text = "StudentFeeCollection";
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_student_nm_dataGridView)).EndInit();
            this.fee_collection_panel.ResumeLayout(false);
            this.fee_collection_panel.PerformLayout();
            this.filter_groupBox.ResumeLayout(false);
            this.filter_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_sem_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label student_nm_label;
        private System.Windows.Forms.Label grno_label;
        private System.Windows.Forms.Label collectedfee_label;
        private System.Windows.Forms.Label patment_date_label;
        private System.Windows.Forms.DateTimePicker payment_date_dateTimePicker;
        private CustomControl.UpperTextBox studentnm_textBox;
        private CustomControl.NumericTextBox grno_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView all_student_nm_dataGridView;
        private System.Windows.Forms.Panel fee_collection_panel;
        private System.Windows.Forms.Button clear_fee_button;
        private System.Windows.Forms.Button collect_fee_button;
        private System.Windows.Forms.GroupBox filter_groupBox;
        private System.Windows.Forms.Label paymentyear_label;
        private System.Windows.Forms.Label select_sem_label;
        private System.Windows.Forms.ComboBox paymentyear_comboBox;
        private System.Windows.Forms.Button clear_filter_button;
        private System.Windows.Forms.Button filter_button;
        private CustomControl.UpperTextBox studentnm_filter_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label course_label;
        private System.Windows.Forms.ComboBox course_comboBox;
        private System.Windows.Forms.NumericUpDown select_sem_numericUpDown;
        private System.Windows.Forms.TextBox collected_fee_textBox;
    }
}