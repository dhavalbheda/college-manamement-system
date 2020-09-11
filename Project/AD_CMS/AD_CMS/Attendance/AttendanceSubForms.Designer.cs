namespace AD_CMS.Attendance
{
    partial class AttendanceSubForms
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
            this.view_label = new System.Windows.Forms.Label();
            this.view_pictureBox = new System.Windows.Forms.PictureBox();
            this.upload_attendance_pictureBox = new System.Windows.Forms.PictureBox();
            this.upload_attendance_label = new System.Windows.Forms.Label();
            this.rules_label = new System.Windows.Forms.Label();
            this.generate_label = new System.Windows.Forms.Label();
            this.rules_pictureBox = new System.Windows.Forms.PictureBox();
            this.generate_pictureBox = new System.Windows.Forms.PictureBox();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.icon_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upload_attendance_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rules_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generate_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(452, 5);
            this.heading_label.Size = new System.Drawing.Size(211, 38);
            this.heading_label.Text = "Attendance";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.icon_tableLayoutPanel);
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
            this.icon_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00125F));
            this.icon_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00125F));
            this.icon_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99875F));
            this.icon_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99875F));
            this.icon_tableLayoutPanel.Controls.Add(this.view_label, 1, 1);
            this.icon_tableLayoutPanel.Controls.Add(this.view_pictureBox, 1, 0);
            this.icon_tableLayoutPanel.Controls.Add(this.upload_attendance_pictureBox, 0, 0);
            this.icon_tableLayoutPanel.Controls.Add(this.upload_attendance_label, 0, 1);
            this.icon_tableLayoutPanel.Controls.Add(this.rules_label, 2, 1);
            this.icon_tableLayoutPanel.Controls.Add(this.generate_label, 3, 1);
            this.icon_tableLayoutPanel.Controls.Add(this.rules_pictureBox, 2, 0);
            this.icon_tableLayoutPanel.Controls.Add(this.generate_pictureBox, 3, 0);
            this.icon_tableLayoutPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_tableLayoutPanel.Location = new System.Drawing.Point(21, 22);
            this.icon_tableLayoutPanel.Name = "icon_tableLayoutPanel";
            this.icon_tableLayoutPanel.RowCount = 2;
            this.icon_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.72528F));
            this.icon_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.27472F));
            this.icon_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.icon_tableLayoutPanel.Size = new System.Drawing.Size(958, 297);
            this.icon_tableLayoutPanel.TabIndex = 3;
            // 
            // view_label
            // 
            this.view_label.AutoSize = true;
            this.view_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.view_label.Location = new System.Drawing.Point(242, 221);
            this.view_label.Name = "view_label";
            this.view_label.Size = new System.Drawing.Size(233, 76);
            this.view_label.TabIndex = 1;
            this.view_label.Text = "View Attendance";
            this.view_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.view_label.Click += new System.EventHandler(this.view_pictureBox_Click);
            // 
            // view_pictureBox
            // 
            this.view_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_pictureBox.Image = global::AD_CMS.Properties.Resources.ViewAttendance;
            this.view_pictureBox.Location = new System.Drawing.Point(242, 3);
            this.view_pictureBox.Name = "view_pictureBox";
            this.view_pictureBox.Size = new System.Drawing.Size(233, 215);
            this.view_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.view_pictureBox.TabIndex = 1;
            this.view_pictureBox.TabStop = false;
            this.view_pictureBox.Click += new System.EventHandler(this.view_pictureBox_Click);
            // 
            // upload_attendance_pictureBox
            // 
            this.upload_attendance_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upload_attendance_pictureBox.Image = global::AD_CMS.Properties.Resources.UploadAttendance;
            this.upload_attendance_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.upload_attendance_pictureBox.Name = "upload_attendance_pictureBox";
            this.upload_attendance_pictureBox.Size = new System.Drawing.Size(233, 215);
            this.upload_attendance_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.upload_attendance_pictureBox.TabIndex = 0;
            this.upload_attendance_pictureBox.TabStop = false;
            this.upload_attendance_pictureBox.Click += new System.EventHandler(this.upload_attendance_label_Click);
            // 
            // upload_attendance_label
            // 
            this.upload_attendance_label.AutoSize = true;
            this.upload_attendance_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upload_attendance_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.upload_attendance_label.Location = new System.Drawing.Point(3, 221);
            this.upload_attendance_label.Name = "upload_attendance_label";
            this.upload_attendance_label.Size = new System.Drawing.Size(233, 76);
            this.upload_attendance_label.TabIndex = 0;
            this.upload_attendance_label.Text = "Upload Attendance Sheet";
            this.upload_attendance_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.upload_attendance_label.Click += new System.EventHandler(this.upload_attendance_label_Click);
            // 
            // rules_label
            // 
            this.rules_label.AutoSize = true;
            this.rules_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rules_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.rules_label.Location = new System.Drawing.Point(481, 221);
            this.rules_label.Name = "rules_label";
            this.rules_label.Size = new System.Drawing.Size(233, 76);
            this.rules_label.TabIndex = 1;
            this.rules_label.Text = "Instruction && Rules";
            this.rules_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rules_label.UseMnemonic = false;
            this.rules_label.Click += new System.EventHandler(this.rules_pictureBox_Click);
            // 
            // generate_label
            // 
            this.generate_label.AutoSize = true;
            this.generate_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generate_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.generate_label.Location = new System.Drawing.Point(720, 221);
            this.generate_label.Name = "generate_label";
            this.generate_label.Size = new System.Drawing.Size(235, 76);
            this.generate_label.TabIndex = 1;
            this.generate_label.Text = "Generate Attendance Sheet";
            this.generate_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generate_label.Click += new System.EventHandler(this.generate_pictureBox_Click);
            // 
            // rules_pictureBox
            // 
            this.rules_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rules_pictureBox.Image = global::AD_CMS.Properties.Resources.rules;
            this.rules_pictureBox.Location = new System.Drawing.Point(481, 3);
            this.rules_pictureBox.Name = "rules_pictureBox";
            this.rules_pictureBox.Size = new System.Drawing.Size(233, 215);
            this.rules_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rules_pictureBox.TabIndex = 1;
            this.rules_pictureBox.TabStop = false;
            this.rules_pictureBox.Click += new System.EventHandler(this.rules_pictureBox_Click);
            // 
            // generate_pictureBox
            // 
            this.generate_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generate_pictureBox.Image = global::AD_CMS.Properties.Resources.generate;
            this.generate_pictureBox.Location = new System.Drawing.Point(720, 3);
            this.generate_pictureBox.Name = "generate_pictureBox";
            this.generate_pictureBox.Size = new System.Drawing.Size(235, 215);
            this.generate_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.generate_pictureBox.TabIndex = 1;
            this.generate_pictureBox.TabStop = false;
            this.generate_pictureBox.Click += new System.EventHandler(this.generate_pictureBox_Click);
            // 
            // AttendanceSubForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "AttendanceSubForms";
            this.Text = "AttendanceSubForms";
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.icon_tableLayoutPanel.ResumeLayout(false);
            this.icon_tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upload_attendance_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rules_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generate_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel icon_tableLayoutPanel;
        private System.Windows.Forms.Label view_label;
        private System.Windows.Forms.PictureBox view_pictureBox;
        private System.Windows.Forms.PictureBox upload_attendance_pictureBox;
        private System.Windows.Forms.Label upload_attendance_label;
        private System.Windows.Forms.Label rules_label;
        private System.Windows.Forms.Label generate_label;
        private System.Windows.Forms.PictureBox rules_pictureBox;
        private System.Windows.Forms.PictureBox generate_pictureBox;
    }
}