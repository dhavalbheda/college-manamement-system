namespace AD_CMS.Attendance
{
    partial class GenerateAttendanceSheet
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
            this.label1 = new System.Windows.Forms.Label();
            this.select_dept_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.select_sem_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.generat_sheet_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.select_sem_numericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(320, 5);
            this.heading_label.Size = new System.Drawing.Size(475, 38);
            this.heading_label.Text = "Generate Attendance Sheet";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.groupBox1);
            this.contentarea_panel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Department : ";
            // 
            // select_dept_comboBox
            // 
            this.select_dept_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_dept_comboBox.FormattingEnabled = true;
            this.select_dept_comboBox.Location = new System.Drawing.Point(262, 54);
            this.select_dept_comboBox.Name = "select_dept_comboBox";
            this.select_dept_comboBox.Size = new System.Drawing.Size(209, 27);
            this.select_dept_comboBox.TabIndex = 1;
            this.select_dept_comboBox.SelectedIndexChanged += new System.EventHandler(this.select_dept_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Sem : ";
            // 
            // select_sem_numericUpDown
            // 
            this.select_sem_numericUpDown.Location = new System.Drawing.Point(262, 103);
            this.select_sem_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.select_sem_numericUpDown.Name = "select_sem_numericUpDown";
            this.select_sem_numericUpDown.Size = new System.Drawing.Size(58, 27);
            this.select_sem_numericUpDown.TabIndex = 2;
            this.select_sem_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // generat_sheet_button
            // 
            this.generat_sheet_button.Location = new System.Drawing.Point(147, 213);
            this.generat_sheet_button.Name = "generat_sheet_button";
            this.generat_sheet_button.Size = new System.Drawing.Size(209, 54);
            this.generat_sheet_button.TabIndex = 3;
            this.generat_sheet_button.Text = "Generate Attendance Sheet";
            this.generat_sheet_button.UseVisualStyleBackColor = true;
            this.generat_sheet_button.Click += new System.EventHandler(this.generat_sheet_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.generat_sheet_button);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.select_sem_numericUpDown);
            this.groupBox1.Controls.Add(this.select_dept_comboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(294, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 284);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "*Select Department && Semester";
            // 
            // GenerateAttendanceSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "GenerateAttendanceSheet";
            this.Text = "GenerateExcelFile";
            this.Load += new System.EventHandler(this.GenerateAttendanceSheet_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.select_sem_numericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown select_sem_numericUpDown;
        private System.Windows.Forms.ComboBox select_dept_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generat_sheet_button;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}