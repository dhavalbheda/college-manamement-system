namespace AD_CMS
{
    partial class TemplateForm
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
            this.heading_panel = new System.Windows.Forms.Panel();
            this.FormCloseBtn = new System.Windows.Forms.PictureBox();
            this.heading_label = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.contentarea_panel = new System.Windows.Forms.Panel();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.heading_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_panel
            // 
            this.heading_panel.BackColor = Properties.Settings.Default.TemplateHeaderBack;
            this.heading_panel.Controls.Add(this.FormCloseBtn);
            this.heading_panel.Controls.Add(this.heading_label);
            this.heading_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.heading_panel.Location = new System.Drawing.Point(0, 0);
            this.heading_panel.Name = "heading_panel";
            this.heading_panel.Size = new System.Drawing.Size(1114, 49);
            this.heading_panel.TabIndex = 0;
            // 
            // FormCloseBtn
            // 
            this.FormCloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormCloseBtn.Image = global::AD_CMS.Properties.Resources.Close;
            this.FormCloseBtn.Location = new System.Drawing.Point(1066, 3);
            this.FormCloseBtn.Name = "FormCloseBtn";
            this.FormCloseBtn.Size = new System.Drawing.Size(38, 40);
            this.FormCloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FormCloseBtn.TabIndex = 0;
            this.FormCloseBtn.TabStop = false;
            this.FormCloseBtn.Click += new System.EventHandler(this.CloseFormBtn_Click);
            // 
            // heading_label
            // 
            this.heading_label.AutoSize = true;
            this.heading_label.Font = new System.Drawing.Font("Cooper Black", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(187)))));
            this.heading_label.Location = new System.Drawing.Point(347, 5);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(335, 38);
            this.heading_label.TabIndex = 3;
            this.heading_label.Text = "Student Admission";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = Properties.Settings.Default.TemplateHeaderBack;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(0, 49);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(12, 654);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = Properties.Settings.Default.TemplateHeaderBack;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(1102, 49);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(12, 654);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.BackColor = Properties.Settings.Default.TemplateBack;
            this.contentarea_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentarea_panel.Location = new System.Drawing.Point(12, 49);
            this.contentarea_panel.Name = "contentarea_panel";
            this.contentarea_panel.Size = new System.Drawing.Size(1090, 654);
            this.contentarea_panel.TabIndex = 3;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = Properties.Settings.Default.TemplateHeaderBack;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Enabled = false;
            this.splitter3.Location = new System.Drawing.Point(12, 691);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(1090, 12);
            this.splitter3.TabIndex = 4;
            this.splitter3.TabStop = false;
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.ControlBox = false;
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.contentarea_panel);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.heading_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "TemplateForm";
            this.Text = "TemplateForm";
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel heading_panel;
        public System.Windows.Forms.Label heading_label;
        public System.Windows.Forms.Splitter splitter1;
        public System.Windows.Forms.Panel contentarea_panel;
        public System.Windows.Forms.Splitter splitter3;
        public System.Windows.Forms.Splitter splitter2;
        public System.Windows.Forms.PictureBox FormCloseBtn;
    }
}