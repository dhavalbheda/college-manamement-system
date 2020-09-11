namespace AD_CMS.FinanceDeptSubForms
{
    partial class FinanceSubForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceSubForms));
            this.icon_tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pay_emp_salary_label = new System.Windows.Forms.Label();
            this.view_emp_salary_label = new System.Windows.Forms.Label();
            this.view_stud_payment_details_label = new System.Windows.Forms.Label();
            this.view_emp_salary_pictureBox = new System.Windows.Forms.PictureBox();
            this.view_stud_payment_details_pictureBox = new System.Windows.Forms.PictureBox();
            this.pay_emp_salary_pictureBox = new System.Windows.Forms.PictureBox();
            this.student_fee_collection_pictureBox = new System.Windows.Forms.PictureBox();
            this.student_fee_collection_label = new System.Windows.Forms.Label();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.icon_tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_emp_salary_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_stud_payment_details_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pay_emp_salary_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_fee_collection_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(377, 5);
            this.heading_label.Size = new System.Drawing.Size(361, 38);
            this.heading_label.Text = "Finance Department";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.icon_tableLayoutPanel1);
            this.contentarea_panel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FormCloseBtn
            // 
            this.FormCloseBtn.Click += new System.EventHandler(this.FormCloseBtn_Click);
            // 
            // icon_tableLayoutPanel1
            // 
            this.icon_tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_tableLayoutPanel1.ColumnCount = 4;
            this.icon_tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00145F));
            this.icon_tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00146F));
            this.icon_tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99896F));
            this.icon_tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.icon_tableLayoutPanel1.Controls.Add(this.pay_emp_salary_label, 2, 1);
            this.icon_tableLayoutPanel1.Controls.Add(this.view_emp_salary_label, 3, 1);
            this.icon_tableLayoutPanel1.Controls.Add(this.view_stud_payment_details_label, 1, 1);
            this.icon_tableLayoutPanel1.Controls.Add(this.view_emp_salary_pictureBox, 3, 0);
            this.icon_tableLayoutPanel1.Controls.Add(this.view_stud_payment_details_pictureBox, 1, 0);
            this.icon_tableLayoutPanel1.Controls.Add(this.pay_emp_salary_pictureBox, 2, 0);
            this.icon_tableLayoutPanel1.Controls.Add(this.student_fee_collection_pictureBox, 0, 0);
            this.icon_tableLayoutPanel1.Controls.Add(this.student_fee_collection_label, 0, 1);
            this.icon_tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.icon_tableLayoutPanel1.Name = "icon_tableLayoutPanel1";
            this.icon_tableLayoutPanel1.RowCount = 2;
            this.icon_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.33202F));
            this.icon_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.66798F));
            this.icon_tableLayoutPanel1.Size = new System.Drawing.Size(1036, 278);
            this.icon_tableLayoutPanel1.TabIndex = 11;
            // 
            // pay_emp_salary_label
            // 
            this.pay_emp_salary_label.AutoSize = true;
            this.pay_emp_salary_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pay_emp_salary_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.pay_emp_salary_label.Location = new System.Drawing.Point(521, 201);
            this.pay_emp_salary_label.Name = "pay_emp_salary_label";
            this.pay_emp_salary_label.Size = new System.Drawing.Size(252, 77);
            this.pay_emp_salary_label.TabIndex = 3;
            this.pay_emp_salary_label.Text = "Pay Employee\r\n Salary";
            this.pay_emp_salary_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pay_emp_salary_label.Click += new System.EventHandler(this.PayEmpSal_Click);
            // 
            // view_emp_salary_label
            // 
            this.view_emp_salary_label.AutoSize = true;
            this.view_emp_salary_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_emp_salary_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.view_emp_salary_label.Location = new System.Drawing.Point(779, 201);
            this.view_emp_salary_label.Name = "view_emp_salary_label";
            this.view_emp_salary_label.Size = new System.Drawing.Size(254, 77);
            this.view_emp_salary_label.TabIndex = 4;
            this.view_emp_salary_label.Text = "View Employee \r\nSalary Details";
            this.view_emp_salary_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.view_emp_salary_label.Click += new System.EventHandler(this.EmployeeSalaryDetails_Click);
            // 
            // view_stud_payment_details_label
            // 
            this.view_stud_payment_details_label.AutoSize = true;
            this.view_stud_payment_details_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_stud_payment_details_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.view_stud_payment_details_label.Location = new System.Drawing.Point(262, 201);
            this.view_stud_payment_details_label.Name = "view_stud_payment_details_label";
            this.view_stud_payment_details_label.Size = new System.Drawing.Size(253, 77);
            this.view_stud_payment_details_label.TabIndex = 1;
            this.view_stud_payment_details_label.Text = "View Student \r\n Payment Details";
            this.view_stud_payment_details_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.view_stud_payment_details_label.Click += new System.EventHandler(this.ViewStudPayment_Click);
            // 
            // view_emp_salary_pictureBox
            // 
            this.view_emp_salary_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_emp_salary_pictureBox.Image = global::AD_CMS.Properties.Resources.View_Employee_Salary_Details;
            this.view_emp_salary_pictureBox.Location = new System.Drawing.Point(779, 3);
            this.view_emp_salary_pictureBox.Name = "view_emp_salary_pictureBox";
            this.view_emp_salary_pictureBox.Size = new System.Drawing.Size(254, 195);
            this.view_emp_salary_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.view_emp_salary_pictureBox.TabIndex = 1;
            this.view_emp_salary_pictureBox.TabStop = false;
            this.view_emp_salary_pictureBox.Click += new System.EventHandler(this.EmployeeSalaryDetails_Click);
            // 
            // view_stud_payment_details_pictureBox
            // 
            this.view_stud_payment_details_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_stud_payment_details_pictureBox.Image = global::AD_CMS.Properties.Resources.View_Student_Payment_Details;
            this.view_stud_payment_details_pictureBox.Location = new System.Drawing.Point(262, 3);
            this.view_stud_payment_details_pictureBox.Name = "view_stud_payment_details_pictureBox";
            this.view_stud_payment_details_pictureBox.Size = new System.Drawing.Size(253, 195);
            this.view_stud_payment_details_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.view_stud_payment_details_pictureBox.TabIndex = 1;
            this.view_stud_payment_details_pictureBox.TabStop = false;
            this.view_stud_payment_details_pictureBox.Click += new System.EventHandler(this.ViewStudPayment_Click);
            // 
            // pay_emp_salary_pictureBox
            // 
            this.pay_emp_salary_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pay_emp_salary_pictureBox.Image = global::AD_CMS.Properties.Resources.Pay_Employee_Salary;
            this.pay_emp_salary_pictureBox.Location = new System.Drawing.Point(521, 3);
            this.pay_emp_salary_pictureBox.Name = "pay_emp_salary_pictureBox";
            this.pay_emp_salary_pictureBox.Size = new System.Drawing.Size(252, 195);
            this.pay_emp_salary_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pay_emp_salary_pictureBox.TabIndex = 0;
            this.pay_emp_salary_pictureBox.TabStop = false;
            this.pay_emp_salary_pictureBox.Click += new System.EventHandler(this.PayEmpSal_Click);
            // 
            // student_fee_collection_pictureBox
            // 
            this.student_fee_collection_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.student_fee_collection_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("student_fee_collection_pictureBox.Image")));
            this.student_fee_collection_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.student_fee_collection_pictureBox.Name = "student_fee_collection_pictureBox";
            this.student_fee_collection_pictureBox.Size = new System.Drawing.Size(253, 195);
            this.student_fee_collection_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.student_fee_collection_pictureBox.TabIndex = 0;
            this.student_fee_collection_pictureBox.TabStop = false;
            this.student_fee_collection_pictureBox.Click += new System.EventHandler(this.StudentFee_Click);
            // 
            // student_fee_collection_label
            // 
            this.student_fee_collection_label.AutoSize = true;
            this.student_fee_collection_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.student_fee_collection_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.student_fee_collection_label.Location = new System.Drawing.Point(3, 201);
            this.student_fee_collection_label.Name = "student_fee_collection_label";
            this.student_fee_collection_label.Size = new System.Drawing.Size(253, 77);
            this.student_fee_collection_label.TabIndex = 0;
            this.student_fee_collection_label.Text = "Student Fee\r\n Collection";
            this.student_fee_collection_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.student_fee_collection_label.Click += new System.EventHandler(this.StudentFee_Click);
            // 
            // FinanceSubForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "FinanceSubForms";
            this.Text = "FinanceDeptSubForms";
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.icon_tableLayoutPanel1.ResumeLayout(false);
            this.icon_tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_emp_salary_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_stud_payment_details_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pay_emp_salary_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_fee_collection_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel icon_tableLayoutPanel1;
        private System.Windows.Forms.Label view_stud_payment_details_label;
        private System.Windows.Forms.PictureBox view_stud_payment_details_pictureBox;
        private System.Windows.Forms.PictureBox student_fee_collection_pictureBox;
        private System.Windows.Forms.Label student_fee_collection_label;
        private System.Windows.Forms.Label view_emp_salary_label;
        private System.Windows.Forms.PictureBox view_emp_salary_pictureBox;
        private System.Windows.Forms.PictureBox pay_emp_salary_pictureBox;
        private System.Windows.Forms.Label pay_emp_salary_label;
    }
}