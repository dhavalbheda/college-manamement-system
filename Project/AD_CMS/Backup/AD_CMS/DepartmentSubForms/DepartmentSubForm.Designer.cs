namespace AD_CMS.DepartmentSubForms
{
    partial class DepartmentSubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentSubForm));
            this.icon_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.promote_stud_dept_label = new System.Windows.Forms.Label();
            this.view_dept_details_label = new System.Windows.Forms.Label();
            this.promote_stud_dept_pictureBox = new System.Windows.Forms.PictureBox();
            this.view_dept_details_pictureBox = new System.Windows.Forms.PictureBox();
            this.set_dept_details_pictureBox = new System.Windows.Forms.PictureBox();
            this.set_dept_details_label = new System.Windows.Forms.Label();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.icon_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promote_stud_dept_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_dept_details_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_dept_details_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(446, 5);
            this.heading_label.Size = new System.Drawing.Size(222, 38);
            this.heading_label.Text = "Department";
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
            this.icon_tableLayoutPanel.ColumnCount = 3;
            this.icon_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.icon_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.icon_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.icon_tableLayoutPanel.Controls.Add(this.promote_stud_dept_label, 2, 1);
            this.icon_tableLayoutPanel.Controls.Add(this.view_dept_details_label, 1, 1);
            this.icon_tableLayoutPanel.Controls.Add(this.promote_stud_dept_pictureBox, 2, 0);
            this.icon_tableLayoutPanel.Controls.Add(this.view_dept_details_pictureBox, 1, 0);
            this.icon_tableLayoutPanel.Controls.Add(this.set_dept_details_pictureBox, 0, 0);
            this.icon_tableLayoutPanel.Controls.Add(this.set_dept_details_label, 0, 1);
            this.icon_tableLayoutPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_tableLayoutPanel.Location = new System.Drawing.Point(6, 6);
            this.icon_tableLayoutPanel.Name = "icon_tableLayoutPanel";
            this.icon_tableLayoutPanel.RowCount = 2;
            this.icon_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.33202F));
            this.icon_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.66798F));
            this.icon_tableLayoutPanel.Size = new System.Drawing.Size(875, 298);
            this.icon_tableLayoutPanel.TabIndex = 10;
            // 
            // promote_stud_dept_label
            // 
            this.promote_stud_dept_label.AutoSize = true;
            this.promote_stud_dept_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.promote_stud_dept_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.promote_stud_dept_label.Location = new System.Drawing.Point(585, 215);
            this.promote_stud_dept_label.Name = "promote_stud_dept_label";
            this.promote_stud_dept_label.Size = new System.Drawing.Size(287, 83);
            this.promote_stud_dept_label.TabIndex = 2;
            this.promote_stud_dept_label.Text = "Promote Student\r\n Department";
            this.promote_stud_dept_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.promote_stud_dept_label.Click += new System.EventHandler(this.PromoteStudent_Click);
            // 
            // view_dept_details_label
            // 
            this.view_dept_details_label.AutoSize = true;
            this.view_dept_details_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_dept_details_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.view_dept_details_label.Location = new System.Drawing.Point(294, 215);
            this.view_dept_details_label.Name = "view_dept_details_label";
            this.view_dept_details_label.Size = new System.Drawing.Size(285, 83);
            this.view_dept_details_label.TabIndex = 1;
            this.view_dept_details_label.Text = "View Department\r\n Details";
            this.view_dept_details_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.view_dept_details_label.Click += new System.EventHandler(this.ViewDepartmentDetails_Click);
            // 
            // promote_stud_dept_pictureBox
            // 
            this.promote_stud_dept_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.promote_stud_dept_pictureBox.Image = global::AD_CMS.Properties.Resources.Promote_Student_Department;
            this.promote_stud_dept_pictureBox.Location = new System.Drawing.Point(585, 3);
            this.promote_stud_dept_pictureBox.Name = "promote_stud_dept_pictureBox";
            this.promote_stud_dept_pictureBox.Size = new System.Drawing.Size(287, 209);
            this.promote_stud_dept_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.promote_stud_dept_pictureBox.TabIndex = 2;
            this.promote_stud_dept_pictureBox.TabStop = false;
            this.promote_stud_dept_pictureBox.Click += new System.EventHandler(this.PromoteStudent_Click);
            // 
            // view_dept_details_pictureBox
            // 
            this.view_dept_details_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_dept_details_pictureBox.Image = global::AD_CMS.Properties.Resources.View_Department;
            this.view_dept_details_pictureBox.Location = new System.Drawing.Point(294, 3);
            this.view_dept_details_pictureBox.Name = "view_dept_details_pictureBox";
            this.view_dept_details_pictureBox.Size = new System.Drawing.Size(285, 209);
            this.view_dept_details_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.view_dept_details_pictureBox.TabIndex = 1;
            this.view_dept_details_pictureBox.TabStop = false;
            this.view_dept_details_pictureBox.Click += new System.EventHandler(this.ViewDepartmentDetails_Click);
            // 
            // set_dept_details_pictureBox
            // 
            this.set_dept_details_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_dept_details_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("set_dept_details_pictureBox.Image")));
            this.set_dept_details_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.set_dept_details_pictureBox.Name = "set_dept_details_pictureBox";
            this.set_dept_details_pictureBox.Size = new System.Drawing.Size(285, 209);
            this.set_dept_details_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.set_dept_details_pictureBox.TabIndex = 0;
            this.set_dept_details_pictureBox.TabStop = false;
            this.set_dept_details_pictureBox.Click += new System.EventHandler(this.Set_ModifyDepartment_Click);
            // 
            // set_dept_details_label
            // 
            this.set_dept_details_label.AutoSize = true;
            this.set_dept_details_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_dept_details_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.set_dept_details_label.Location = new System.Drawing.Point(3, 215);
            this.set_dept_details_label.Name = "set_dept_details_label";
            this.set_dept_details_label.Size = new System.Drawing.Size(285, 83);
            this.set_dept_details_label.TabIndex = 0;
            this.set_dept_details_label.Text = "Set && Modify\r\nDepartment\r\nDetails";
            this.set_dept_details_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.set_dept_details_label.Click += new System.EventHandler(this.Set_ModifyDepartment_Click);
            // 
            // DepartmentSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "DepartmentSubForm";
            this.Text = "DepartmentSubForm";
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.icon_tableLayoutPanel.ResumeLayout(false);
            this.icon_tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promote_stud_dept_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_dept_details_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_dept_details_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel icon_tableLayoutPanel;
        private System.Windows.Forms.Label promote_stud_dept_label;
        private System.Windows.Forms.Label view_dept_details_label;
        private System.Windows.Forms.PictureBox promote_stud_dept_pictureBox;
        private System.Windows.Forms.PictureBox view_dept_details_pictureBox;
        private System.Windows.Forms.PictureBox set_dept_details_pictureBox;
        private System.Windows.Forms.Label set_dept_details_label;

    }
}