namespace AD_CMS.StudentMgmtSubForms
{
    partial class StudentSubForm
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
            this.studentprofile_label = new System.Windows.Forms.Label();
            this.updatestud_label = new System.Windows.Forms.Label();
            this.studentprofile_pictureBox = new System.Windows.Forms.PictureBox();
            this.updatestud_pictureBox = new System.Windows.Forms.PictureBox();
            this.studentadmission_pictureBox = new System.Windows.Forms.PictureBox();
            this.studentadmission_label = new System.Windows.Forms.Label();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.icon_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentprofile_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatestud_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentadmission_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(371, 5);
            this.heading_label.Size = new System.Drawing.Size(372, 38);
            this.heading_label.Text = "Student Management";
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
            this.icon_tableLayoutPanel.Controls.Add(this.studentprofile_label, 2, 1);
            this.icon_tableLayoutPanel.Controls.Add(this.updatestud_label, 1, 1);
            this.icon_tableLayoutPanel.Controls.Add(this.studentprofile_pictureBox, 2, 0);
            this.icon_tableLayoutPanel.Controls.Add(this.updatestud_pictureBox, 1, 0);
            this.icon_tableLayoutPanel.Controls.Add(this.studentadmission_pictureBox, 0, 0);
            this.icon_tableLayoutPanel.Controls.Add(this.studentadmission_label, 0, 1);
            this.icon_tableLayoutPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_tableLayoutPanel.Location = new System.Drawing.Point(6, 6);
            this.icon_tableLayoutPanel.Name = "icon_tableLayoutPanel";
            this.icon_tableLayoutPanel.RowCount = 2;
            this.icon_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.12253F));
            this.icon_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.87747F));
            this.icon_tableLayoutPanel.Size = new System.Drawing.Size(821, 253);
            this.icon_tableLayoutPanel.TabIndex = 0;
            // 
            // studentprofile_label
            // 
            this.studentprofile_label.AutoSize = true;
            this.studentprofile_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentprofile_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.studentprofile_label.Location = new System.Drawing.Point(549, 184);
            this.studentprofile_label.Name = "studentprofile_label";
            this.studentprofile_label.Size = new System.Drawing.Size(269, 69);
            this.studentprofile_label.TabIndex = 2;
            this.studentprofile_label.Text = "Student Profile";
            this.studentprofile_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.studentprofile_label.Click += new System.EventHandler(this.StudentProfile_Click);
            // 
            // updatestud_label
            // 
            this.updatestud_label.AutoSize = true;
            this.updatestud_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updatestud_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.updatestud_label.Location = new System.Drawing.Point(276, 184);
            this.updatestud_label.Name = "updatestud_label";
            this.updatestud_label.Size = new System.Drawing.Size(267, 69);
            this.updatestud_label.TabIndex = 1;
            this.updatestud_label.Text = "Update Student \r\nDetails";
            this.updatestud_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updatestud_label.Click += new System.EventHandler(this.UpdateStudent_Click);
            // 
            // studentprofile_pictureBox
            // 
            this.studentprofile_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentprofile_pictureBox.Image = global::AD_CMS.Properties.Resources.Student_Profile;
            this.studentprofile_pictureBox.Location = new System.Drawing.Point(549, 3);
            this.studentprofile_pictureBox.Name = "studentprofile_pictureBox";
            this.studentprofile_pictureBox.Size = new System.Drawing.Size(269, 178);
            this.studentprofile_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.studentprofile_pictureBox.TabIndex = 2;
            this.studentprofile_pictureBox.TabStop = false;
            this.studentprofile_pictureBox.Click += new System.EventHandler(this.StudentProfile_Click);
            // 
            // updatestud_pictureBox
            // 
            this.updatestud_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updatestud_pictureBox.Image = global::AD_CMS.Properties.Resources.Update_Student_Detail;
            this.updatestud_pictureBox.Location = new System.Drawing.Point(276, 3);
            this.updatestud_pictureBox.Name = "updatestud_pictureBox";
            this.updatestud_pictureBox.Size = new System.Drawing.Size(267, 178);
            this.updatestud_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.updatestud_pictureBox.TabIndex = 1;
            this.updatestud_pictureBox.TabStop = false;
            this.updatestud_pictureBox.Click += new System.EventHandler(this.UpdateStudent_Click);
            // 
            // studentadmission_pictureBox
            // 
            this.studentadmission_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentadmission_pictureBox.Image = global::AD_CMS.Properties.Resources.StudentRegistration;
            this.studentadmission_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.studentadmission_pictureBox.Name = "studentadmission_pictureBox";
            this.studentadmission_pictureBox.Size = new System.Drawing.Size(267, 178);
            this.studentadmission_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.studentadmission_pictureBox.TabIndex = 0;
            this.studentadmission_pictureBox.TabStop = false;
            this.studentadmission_pictureBox.Click += new System.EventHandler(this.StudentAddmission_Click);
            // 
            // studentadmission_label
            // 
            this.studentadmission_label.AutoSize = true;
            this.studentadmission_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentadmission_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.studentadmission_label.Location = new System.Drawing.Point(3, 184);
            this.studentadmission_label.Name = "studentadmission_label";
            this.studentadmission_label.Size = new System.Drawing.Size(267, 69);
            this.studentadmission_label.TabIndex = 0;
            this.studentadmission_label.Text = "Student Admission";
            this.studentadmission_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.studentadmission_label.Click += new System.EventHandler(this.StudentAddmission_Click);
            // 
            // StudentSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "StudentSubForm";
            this.Text = "StudentSubForm";
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.icon_tableLayoutPanel.ResumeLayout(false);
            this.icon_tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentprofile_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatestud_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentadmission_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel icon_tableLayoutPanel;
        private System.Windows.Forms.PictureBox studentadmission_pictureBox;
        private System.Windows.Forms.Label studentprofile_label;
        private System.Windows.Forms.Label updatestud_label;
        private System.Windows.Forms.PictureBox studentprofile_pictureBox;
        private System.Windows.Forms.PictureBox updatestud_pictureBox;
        private System.Windows.Forms.Label studentadmission_label;


    }
}