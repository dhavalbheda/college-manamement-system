namespace AD_CMS.AdminSection
{
    partial class SoftwareVisualStyleChange
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
            this.ChooseColor = new System.Windows.Forms.ColorDialog();
            this.update_button = new System.Windows.Forms.Button();
            this.main_linkLabel = new System.Windows.Forms.LinkLabel();
            this.reset_button = new System.Windows.Forms.Button();
            this.template_linkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.template_header_linkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(287, 5);
            this.heading_label.Size = new System.Drawing.Size(540, 38);
            this.heading_label.Text = "Change Software Visual Design";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.pictureBox3);
            this.contentarea_panel.Controls.Add(this.pictureBox2);
            this.contentarea_panel.Controls.Add(this.pictureBox1);
            this.contentarea_panel.Controls.Add(this.template_header_linkLabel);
            this.contentarea_panel.Controls.Add(this.template_linkLabel);
            this.contentarea_panel.Controls.Add(this.main_linkLabel);
            this.contentarea_panel.Controls.Add(this.reset_button);
            this.contentarea_panel.Controls.Add(this.label3);
            this.contentarea_panel.Controls.Add(this.update_button);
            this.contentarea_panel.Controls.Add(this.label2);
            this.contentarea_panel.Controls.Add(this.label1);
            this.contentarea_panel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Form Background Color : ";
            // 
            // ChooseColor
            // 
            this.ChooseColor.AllowFullOpen = false;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(93, 293);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(92, 39);
            this.update_button.TabIndex = 2;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // main_linkLabel
            // 
            this.main_linkLabel.AutoSize = true;
            this.main_linkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.main_linkLabel.Location = new System.Drawing.Point(465, 56);
            this.main_linkLabel.Name = "main_linkLabel";
            this.main_linkLabel.Size = new System.Drawing.Size(63, 20);
            this.main_linkLabel.TabIndex = 3;
            this.main_linkLabel.TabStop = true;
            this.main_linkLabel.Text = "Change";
            this.main_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Main_Back_LinkClicked);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(282, 293);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(92, 39);
            this.reset_button.TabIndex = 2;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // template_linkLabel
            // 
            this.template_linkLabel.AutoSize = true;
            this.template_linkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.template_linkLabel.Location = new System.Drawing.Point(465, 103);
            this.template_linkLabel.Name = "template_linkLabel";
            this.template_linkLabel.Size = new System.Drawing.Size(63, 20);
            this.template_linkLabel.TabIndex = 3;
            this.template_linkLabel.TabStop = true;
            this.template_linkLabel.Text = "Change";
            this.template_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Template_Back_linkLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(372, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 36);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(372, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 36);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "All Form Background Color : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "All Form Header Background Color : ";
            // 
            // template_header_linkLabel
            // 
            this.template_header_linkLabel.AutoSize = true;
            this.template_header_linkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.template_header_linkLabel.Location = new System.Drawing.Point(465, 152);
            this.template_header_linkLabel.Name = "template_header_linkLabel";
            this.template_header_linkLabel.Size = new System.Drawing.Size(63, 20);
            this.template_header_linkLabel.TabIndex = 3;
            this.template_header_linkLabel.TabStop = true;
            this.template_header_linkLabel.Text = "Change";
            this.template_header_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.template_header_linkLabel_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(372, 143);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 36);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // SoftwareVisualStyleChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "SoftwareVisualStyleChange";
            this.Text = "SoftwareVisualStyleChange";
            this.Load += new System.EventHandler(this.SoftwareVisualStyleChange_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            this.contentarea_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog ChooseColor;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.LinkLabel main_linkLabel;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.LinkLabel template_linkLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel template_header_linkLabel;
        private System.Windows.Forms.Label label3;
    }
}