namespace AD_CMS.StaffMgmtSubForms
{
    partial class EmployeeSubForms
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
            this.icon_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.emp_profile_label = new System.Windows.Forms.Label();
            this.update_emp_detail_label = new System.Windows.Forms.Label();
            this.emp_profile_pictureBox = new System.Windows.Forms.PictureBox();
            this.update_emp_detail_pictureBox = new System.Windows.Forms.PictureBox();
            this.emp_registration_pictureBox = new System.Windows.Forms.PictureBox();
            this.emp_registration_label = new System.Windows.Forms.Label();
            this.set_emp_sal_detail_label = new System.Windows.Forms.Label();
            this.set_emp_sal_detail_pictureBox = new System.Windows.Forms.PictureBox();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.icon_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_profile_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_emp_detail_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_registration_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_emp_sal_detail_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(356, 5);
            this.heading_label.Size = new System.Drawing.Size(402, 38);
            this.heading_label.Text = "Employee Management";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.icon_tableLayoutPanel);
            this.contentarea_panel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FormCloseBtn
            // 
            this.FormCloseBtn.Click += new System.EventHandler(this.FormCloseBtn_Click);
            // 
            // icon_tableLayoutPanel
            // 
            this.icon_tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_tableLayoutPanel.ColumnCount = 4;
            this.icon_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.icon_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.icon_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.icon_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99812F));
            this.icon_tableLayoutPanel.Controls.Add(this.emp_profile_label, 2, 1);
            this.icon_tableLayoutPanel.Controls.Add(this.update_emp_detail_label, 1, 1);
            this.icon_tableLayoutPanel.Controls.Add(this.emp_profile_pictureBox, 2, 0);
            this.icon_tableLayoutPanel.Controls.Add(this.update_emp_detail_pictureBox, 1, 0);
            this.icon_tableLayoutPanel.Controls.Add(this.emp_registration_pictureBox, 0, 0);
            this.icon_tableLayoutPanel.Controls.Add(this.emp_registration_label, 0, 1);
            this.icon_tableLayoutPanel.Controls.Add(this.set_emp_sal_detail_label, 3, 1);
            this.icon_tableLayoutPanel.Controls.Add(this.set_emp_sal_detail_pictureBox, 3, 0);
            this.icon_tableLayoutPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_tableLayoutPanel.Location = new System.Drawing.Point(6, 6);
            this.icon_tableLayoutPanel.Name = "icon_tableLayoutPanel";
            this.icon_tableLayoutPanel.RowCount = 2;
            this.icon_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.99268F));
            this.icon_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.00733F));
            this.icon_tableLayoutPanel.Size = new System.Drawing.Size(993, 273);
            this.icon_tableLayoutPanel.TabIndex = 1;
            // 
            // emp_profile_label
            // 
            this.emp_profile_label.AutoSize = true;
            this.emp_profile_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emp_profile_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.emp_profile_label.Location = new System.Drawing.Point(499, 201);
            this.emp_profile_label.Name = "emp_profile_label";
            this.emp_profile_label.Size = new System.Drawing.Size(242, 72);
            this.emp_profile_label.TabIndex = 2;
            this.emp_profile_label.Text = "Employee Profile";
            this.emp_profile_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emp_profile_label.Click += new System.EventHandler(this.EmployeeProfile_Click);
            // 
            // update_emp_detail_label
            // 
            this.update_emp_detail_label.AutoSize = true;
            this.update_emp_detail_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.update_emp_detail_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.update_emp_detail_label.Location = new System.Drawing.Point(251, 201);
            this.update_emp_detail_label.Name = "update_emp_detail_label";
            this.update_emp_detail_label.Size = new System.Drawing.Size(242, 72);
            this.update_emp_detail_label.TabIndex = 1;
            this.update_emp_detail_label.Text = "Update Employee\r\n Details";
            this.update_emp_detail_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.update_emp_detail_label.Click += new System.EventHandler(this.UpdateEmployee_Click);
            // 
            // emp_profile_pictureBox
            // 
            this.emp_profile_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emp_profile_pictureBox.Image = global::AD_CMS.Properties.Resources.Employee_Profile;
            this.emp_profile_pictureBox.Location = new System.Drawing.Point(499, 3);
            this.emp_profile_pictureBox.Name = "emp_profile_pictureBox";
            this.emp_profile_pictureBox.Size = new System.Drawing.Size(242, 195);
            this.emp_profile_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.emp_profile_pictureBox.TabIndex = 2;
            this.emp_profile_pictureBox.TabStop = false;
            this.emp_profile_pictureBox.Click += new System.EventHandler(this.EmployeeProfile_Click);
            // 
            // update_emp_detail_pictureBox
            // 
            this.update_emp_detail_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.update_emp_detail_pictureBox.Image = global::AD_CMS.Properties.Resources.Update_Employee_Details;
            this.update_emp_detail_pictureBox.Location = new System.Drawing.Point(251, 3);
            this.update_emp_detail_pictureBox.Name = "update_emp_detail_pictureBox";
            this.update_emp_detail_pictureBox.Size = new System.Drawing.Size(242, 195);
            this.update_emp_detail_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.update_emp_detail_pictureBox.TabIndex = 1;
            this.update_emp_detail_pictureBox.TabStop = false;
            this.update_emp_detail_pictureBox.Click += new System.EventHandler(this.UpdateEmployee_Click);
            // 
            // emp_registration_pictureBox
            // 
            this.emp_registration_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emp_registration_pictureBox.Image = global::AD_CMS.Properties.Resources.Employee_Registration;
            this.emp_registration_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.emp_registration_pictureBox.Name = "emp_registration_pictureBox";
            this.emp_registration_pictureBox.Size = new System.Drawing.Size(242, 195);
            this.emp_registration_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.emp_registration_pictureBox.TabIndex = 0;
            this.emp_registration_pictureBox.TabStop = false;
            this.emp_registration_pictureBox.Click += new System.EventHandler(this.EmployeeRegistration_Click);
            // 
            // emp_registration_label
            // 
            this.emp_registration_label.AutoSize = true;
            this.emp_registration_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emp_registration_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.emp_registration_label.Location = new System.Drawing.Point(3, 201);
            this.emp_registration_label.Name = "emp_registration_label";
            this.emp_registration_label.Size = new System.Drawing.Size(242, 72);
            this.emp_registration_label.TabIndex = 0;
            this.emp_registration_label.Text = "Employee \r\nRegistration";
            this.emp_registration_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emp_registration_label.Click += new System.EventHandler(this.EmployeeRegistration_Click);
            // 
            // set_emp_sal_detail_label
            // 
            this.set_emp_sal_detail_label.AutoSize = true;
            this.set_emp_sal_detail_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_emp_sal_detail_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.set_emp_sal_detail_label.Location = new System.Drawing.Point(747, 201);
            this.set_emp_sal_detail_label.Name = "set_emp_sal_detail_label";
            this.set_emp_sal_detail_label.Size = new System.Drawing.Size(243, 72);
            this.set_emp_sal_detail_label.TabIndex = 2;
            this.set_emp_sal_detail_label.Text = "Set && Modify Employee Salary";
            this.set_emp_sal_detail_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.set_emp_sal_detail_label.Click += new System.EventHandler(this.Set_Modify_Emp_Sal_Click);
            // 
            // set_emp_sal_detail_pictureBox
            // 
            this.set_emp_sal_detail_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_emp_sal_detail_pictureBox.Image = global::AD_CMS.Properties.Resources.Update_Salary_Details;
            this.set_emp_sal_detail_pictureBox.Location = new System.Drawing.Point(747, 3);
            this.set_emp_sal_detail_pictureBox.Name = "set_emp_sal_detail_pictureBox";
            this.set_emp_sal_detail_pictureBox.Size = new System.Drawing.Size(243, 195);
            this.set_emp_sal_detail_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.set_emp_sal_detail_pictureBox.TabIndex = 2;
            this.set_emp_sal_detail_pictureBox.TabStop = false;
            this.set_emp_sal_detail_pictureBox.Click += new System.EventHandler(this.Set_Modify_Emp_Sal_Click);
            // 
            // EmployeeSubForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "EmployeeSubForms";
            this.Text = "EmployeeSubForms";
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.icon_tableLayoutPanel.ResumeLayout(false);
            this.icon_tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_profile_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_emp_detail_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_registration_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_emp_sal_detail_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel icon_tableLayoutPanel;
        private System.Windows.Forms.Label emp_profile_label;
        private System.Windows.Forms.Label update_emp_detail_label;
        private System.Windows.Forms.PictureBox emp_profile_pictureBox;
        private System.Windows.Forms.PictureBox update_emp_detail_pictureBox;
        private System.Windows.Forms.PictureBox emp_registration_pictureBox;
        private System.Windows.Forms.Label emp_registration_label;
        private System.Windows.Forms.Label set_emp_sal_detail_label;
        private System.Windows.Forms.PictureBox set_emp_sal_detail_pictureBox;

    }
}