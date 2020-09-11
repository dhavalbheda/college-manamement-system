namespace AD_CMS.FinanceDeptSubForms
{
    partial class ViewStudentPaymentDetails
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
            this.select_course_label = new System.Windows.Forms.Label();
            this.select_sem_label = new System.Windows.Forms.Label();
            this.selectcourse_comboBox = new System.Windows.Forms.ComboBox();
            this.find_button = new System.Windows.Forms.Button();
            this.payment_details_groupBox = new System.Windows.Forms.GroupBox();
            this.all_radioButton = new System.Windows.Forms.RadioButton();
            this.due_radioButton = new System.Windows.Forms.RadioButton();
            this.paid_radioButton = new System.Windows.Forms.RadioButton();
            this.stud_payment_dataGridView = new System.Windows.Forms.DataGridView();
            this.search_panel = new System.Windows.Forms.Panel();
            this.due_textbox = new CustomControl.NumericTextBox();
            this.selectsem_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.payment_details_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stud_payment_dataGridView)).BeginInit();
            this.search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectsem_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(293, 5);
            this.heading_label.Size = new System.Drawing.Size(528, 38);
            this.heading_label.Text = "View Student Payment Details";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.contentarea_panel.Controls.Add(this.search_panel);
            this.contentarea_panel.Controls.Add(this.stud_payment_dataGridView);
            this.contentarea_panel.Dock = System.Windows.Forms.DockStyle.None;
            this.contentarea_panel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // select_course_label
            // 
            this.select_course_label.AutoSize = true;
            this.select_course_label.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_course_label.Location = new System.Drawing.Point(130, 23);
            this.select_course_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.select_course_label.Name = "select_course_label";
            this.select_course_label.Size = new System.Drawing.Size(138, 20);
            this.select_course_label.TabIndex = 1;
            this.select_course_label.Text = "*Select Course : ";
            // 
            // select_sem_label
            // 
            this.select_sem_label.AutoSize = true;
            this.select_sem_label.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_sem_label.Location = new System.Drawing.Point(130, 70);
            this.select_sem_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.select_sem_label.Name = "select_sem_label";
            this.select_sem_label.Size = new System.Drawing.Size(152, 20);
            this.select_sem_label.TabIndex = 2;
            this.select_sem_label.Text = "*Select Semester : ";
            // 
            // selectcourse_comboBox
            // 
            this.selectcourse_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectcourse_comboBox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectcourse_comboBox.FormattingEnabled = true;
            this.selectcourse_comboBox.Items.AddRange(new object[] {
            "Select",
            "B.com",
            "BCA",
            "BBA"});
            this.selectcourse_comboBox.Location = new System.Drawing.Point(306, 23);
            this.selectcourse_comboBox.Name = "selectcourse_comboBox";
            this.selectcourse_comboBox.Size = new System.Drawing.Size(151, 27);
            this.selectcourse_comboBox.TabIndex = 0;
            this.selectcourse_comboBox.SelectedIndexChanged += new System.EventHandler(this.selectcourse_comboBox_SelectedIndexChanged);
            // 
            // find_button
            // 
            this.find_button.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_button.Location = new System.Drawing.Point(544, 91);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(197, 60);
            this.find_button.TabIndex = 3;
            this.find_button.Text = "Find";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // payment_details_groupBox
            // 
            this.payment_details_groupBox.Controls.Add(this.all_radioButton);
            this.payment_details_groupBox.Controls.Add(this.due_radioButton);
            this.payment_details_groupBox.Controls.Add(this.paid_radioButton);
            this.payment_details_groupBox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_details_groupBox.Location = new System.Drawing.Point(134, 133);
            this.payment_details_groupBox.Name = "payment_details_groupBox";
            this.payment_details_groupBox.Size = new System.Drawing.Size(382, 85);
            this.payment_details_groupBox.TabIndex = 2;
            this.payment_details_groupBox.TabStop = false;
            this.payment_details_groupBox.Text = "Payment Details";
            // 
            // all_radioButton
            // 
            this.all_radioButton.AutoSize = true;
            this.all_radioButton.Checked = true;
            this.all_radioButton.Location = new System.Drawing.Point(244, 35);
            this.all_radioButton.Name = "all_radioButton";
            this.all_radioButton.Size = new System.Drawing.Size(50, 24);
            this.all_radioButton.TabIndex = 1;
            this.all_radioButton.TabStop = true;
            this.all_radioButton.Text = "All";
            this.all_radioButton.UseVisualStyleBackColor = true;
            this.all_radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // due_radioButton
            // 
            this.due_radioButton.AutoSize = true;
            this.due_radioButton.Checked = true;
            this.due_radioButton.Location = new System.Drawing.Point(140, 35);
            this.due_radioButton.Name = "due_radioButton";
            this.due_radioButton.Size = new System.Drawing.Size(58, 24);
            this.due_radioButton.TabIndex = 1;
            this.due_radioButton.TabStop = true;
            this.due_radioButton.Text = "Due";
            this.due_radioButton.UseVisualStyleBackColor = true;
            this.due_radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // paid_radioButton
            // 
            this.paid_radioButton.AutoSize = true;
            this.paid_radioButton.Location = new System.Drawing.Point(28, 35);
            this.paid_radioButton.Name = "paid_radioButton";
            this.paid_radioButton.Size = new System.Drawing.Size(62, 24);
            this.paid_radioButton.TabIndex = 0;
            this.paid_radioButton.TabStop = true;
            this.paid_radioButton.Text = "Paid";
            this.paid_radioButton.UseVisualStyleBackColor = true;
            this.paid_radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // stud_payment_dataGridView
            // 
            this.stud_payment_dataGridView.AllowUserToAddRows = false;
            this.stud_payment_dataGridView.AllowUserToDeleteRows = false;
            this.stud_payment_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stud_payment_dataGridView.Location = new System.Drawing.Point(6, 263);
            this.stud_payment_dataGridView.Name = "stud_payment_dataGridView";
            this.stud_payment_dataGridView.ReadOnly = true;
            this.stud_payment_dataGridView.Size = new System.Drawing.Size(1078, 359);
            this.stud_payment_dataGridView.TabIndex = 14;
            this.stud_payment_dataGridView.TabStop = false;
            // 
            // search_panel
            // 
            this.search_panel.Controls.Add(this.due_textbox);
            this.search_panel.Controls.Add(this.selectsem_numericUpDown);
            this.search_panel.Controls.Add(this.payment_details_groupBox);
            this.search_panel.Controls.Add(this.find_button);
            this.search_panel.Controls.Add(this.selectcourse_comboBox);
            this.search_panel.Controls.Add(this.select_sem_label);
            this.search_panel.Controls.Add(this.select_course_label);
            this.search_panel.Location = new System.Drawing.Point(156, 9);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(778, 243);
            this.search_panel.TabIndex = 0;
            // 
            // due_textbox
            // 
            this.due_textbox.Location = new System.Drawing.Point(318, 110);
            this.due_textbox.MaxLength = 10;
            this.due_textbox.Name = "due_textbox";
            this.due_textbox.Size = new System.Drawing.Size(113, 27);
            this.due_textbox.TabIndex = 4;
            // 
            // selectsem_numericUpDown
            // 
            this.selectsem_numericUpDown.Location = new System.Drawing.Point(306, 68);
            this.selectsem_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectsem_numericUpDown.Name = "selectsem_numericUpDown";
            this.selectsem_numericUpDown.Size = new System.Drawing.Size(63, 27);
            this.selectsem_numericUpDown.TabIndex = 2;
            this.selectsem_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ViewStudentPaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "ViewStudentPaymentDetails";
            this.Text = "ViewStudentPaymentDetails";
            this.Load += new System.EventHandler(this.ViewStudentPaymentDetails_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.payment_details_groupBox.ResumeLayout(false);
            this.payment_details_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stud_payment_dataGridView)).EndInit();
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectsem_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox selectcourse_comboBox;
        private System.Windows.Forms.Label select_sem_label;
        private System.Windows.Forms.Label select_course_label;
        private System.Windows.Forms.GroupBox payment_details_groupBox;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.RadioButton due_radioButton;
        private System.Windows.Forms.RadioButton paid_radioButton;
        private System.Windows.Forms.DataGridView stud_payment_dataGridView;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.RadioButton all_radioButton;
        private System.Windows.Forms.NumericUpDown selectsem_numericUpDown;
        private CustomControl.NumericTextBox due_textbox;
    }
}