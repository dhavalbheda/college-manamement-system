namespace AD_CMS.Courses
{
    partial class CourseSubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseSubForm));
            this.icon_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.update_course_label = new System.Windows.Forms.Label();
            this.update_course_pictureBox = new System.Windows.Forms.PictureBox();
            this.add_new_course_pictureBox = new System.Windows.Forms.PictureBox();
            this.add_new_course_label = new System.Windows.Forms.Label();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.icon_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update_course_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_new_course_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(482, 5);
            this.heading_label.Size = new System.Drawing.Size(151, 38);
            this.heading_label.Text = "Courses";
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
            this.icon_tableLayoutPanel.ColumnCount = 2;
            this.icon_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.icon_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.icon_tableLayoutPanel.Controls.Add(this.update_course_label, 1, 1);
            this.icon_tableLayoutPanel.Controls.Add(this.update_course_pictureBox, 1, 0);
            this.icon_tableLayoutPanel.Controls.Add(this.add_new_course_pictureBox, 0, 0);
            this.icon_tableLayoutPanel.Controls.Add(this.add_new_course_label, 0, 1);
            this.icon_tableLayoutPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_tableLayoutPanel.Location = new System.Drawing.Point(6, 6);
            this.icon_tableLayoutPanel.Name = "icon_tableLayoutPanel";
            this.icon_tableLayoutPanel.RowCount = 2;
            this.icon_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.72527F));
            this.icon_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.27472F));
            this.icon_tableLayoutPanel.Size = new System.Drawing.Size(562, 297);
            this.icon_tableLayoutPanel.TabIndex = 2;
            // 
            // update_course_label
            // 
            this.update_course_label.AutoSize = true;
            this.update_course_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.update_course_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.update_course_label.Location = new System.Drawing.Point(283, 221);
            this.update_course_label.Name = "update_course_label";
            this.update_course_label.Size = new System.Drawing.Size(276, 76);
            this.update_course_label.TabIndex = 1;
            this.update_course_label.Text = "Update Course";
            this.update_course_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.update_course_label.Click += new System.EventHandler(this.UpdateCourse_Click);
            // 
            // update_course_pictureBox
            // 
            this.update_course_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.update_course_pictureBox.Image = global::AD_CMS.Properties.Resources.Upadate_Course;
            this.update_course_pictureBox.Location = new System.Drawing.Point(283, 3);
            this.update_course_pictureBox.Name = "update_course_pictureBox";
            this.update_course_pictureBox.Size = new System.Drawing.Size(276, 215);
            this.update_course_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.update_course_pictureBox.TabIndex = 1;
            this.update_course_pictureBox.TabStop = false;
            this.update_course_pictureBox.Click += new System.EventHandler(this.UpdateCourse_Click);
            // 
            // add_new_course_pictureBox
            // 
            this.add_new_course_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_new_course_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("add_new_course_pictureBox.Image")));
            this.add_new_course_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.add_new_course_pictureBox.Name = "add_new_course_pictureBox";
            this.add_new_course_pictureBox.Size = new System.Drawing.Size(274, 215);
            this.add_new_course_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add_new_course_pictureBox.TabIndex = 0;
            this.add_new_course_pictureBox.TabStop = false;
            this.add_new_course_pictureBox.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // add_new_course_label
            // 
            this.add_new_course_label.AutoSize = true;
            this.add_new_course_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_new_course_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.add_new_course_label.Location = new System.Drawing.Point(3, 221);
            this.add_new_course_label.Name = "add_new_course_label";
            this.add_new_course_label.Size = new System.Drawing.Size(274, 76);
            this.add_new_course_label.TabIndex = 0;
            this.add_new_course_label.Text = "Add New \r\nCourse";
            this.add_new_course_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add_new_course_label.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // CourseSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "CourseSubForm";
            this.Text = "CourseSubForm";
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.icon_tableLayoutPanel.ResumeLayout(false);
            this.icon_tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update_course_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_new_course_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel icon_tableLayoutPanel;
        private System.Windows.Forms.Label update_course_label;
        private System.Windows.Forms.PictureBox update_course_pictureBox;
        private System.Windows.Forms.PictureBox add_new_course_pictureBox;
        private System.Windows.Forms.Label add_new_course_label;


    }
}