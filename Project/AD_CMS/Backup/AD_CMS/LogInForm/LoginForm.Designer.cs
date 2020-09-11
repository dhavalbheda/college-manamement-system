namespace AD_CMS.LogInForm
{
    partial class LoginForm
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
            this.header_panel = new System.Windows.Forms.Panel();
            this.title_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Clear_button = new System.Windows.Forms.Button();
            this.usernm_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.login_Button = new System.Windows.Forms.Button();
            this.logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.exit_pictureBox = new System.Windows.Forms.PictureBox();
            this.header_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.Color.Black;
            this.header_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.header_panel.Controls.Add(this.title_label);
            this.header_panel.Controls.Add(this.logo_pictureBox);
            this.header_panel.Controls.Add(this.exit_pictureBox);
            this.header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(414, 32);
            this.header_panel.TabIndex = 0;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(44, 3);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(93, 23);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "AD_CMS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(48, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(60, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password : ";
            // 
            // Clear_button
            // 
            this.Clear_button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Clear_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear_button.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear_button.Location = new System.Drawing.Point(230, 195);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(135, 50);
            this.Clear_button.TabIndex = 3;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // usernm_textBox
            // 
            this.usernm_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernm_textBox.Location = new System.Drawing.Point(203, 73);
            this.usernm_textBox.Name = "usernm_textBox";
            this.usernm_textBox.Size = new System.Drawing.Size(164, 26);
            this.usernm_textBox.TabIndex = 0;
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Lemon", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.Location = new System.Drawing.Point(203, 118);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '@';
            this.password_textBox.Size = new System.Drawing.Size(164, 25);
            this.password_textBox.TabIndex = 1;
            // 
            // login_Button
            // 
            this.login_Button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.login_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_Button.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_Button.Image = global::AD_CMS.Properties.Resources.login_icon;
            this.login_Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.login_Button.Location = new System.Drawing.Point(50, 195);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(135, 50);
            this.login_Button.TabIndex = 2;
            this.login_Button.Text = "Log In";
            this.login_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.login_Button.UseVisualStyleBackColor = false;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // logo_pictureBox
            // 
            this.logo_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.logo_pictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logo_pictureBox.Image = global::AD_CMS.Properties.Resources.small_logo;
            this.logo_pictureBox.Location = new System.Drawing.Point(-1, 0);
            this.logo_pictureBox.Name = "logo_pictureBox";
            this.logo_pictureBox.Size = new System.Drawing.Size(33, 28);
            this.logo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_pictureBox.TabIndex = 1;
            this.logo_pictureBox.TabStop = false;
            // 
            // exit_pictureBox
            // 
            this.exit_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_pictureBox.Image = global::AD_CMS.Properties.Resources.Close;
            this.exit_pictureBox.Location = new System.Drawing.Point(374, 1);
            this.exit_pictureBox.Name = "exit_pictureBox";
            this.exit_pictureBox.Size = new System.Drawing.Size(30, 25);
            this.exit_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit_pictureBox.TabIndex = 1;
            this.exit_pictureBox.TabStop = false;
            this.exit_pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(414, 299);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.usernm_textBox);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.header_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.PictureBox exit_pictureBox;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.Button Clear_button;
        public System.Windows.Forms.TextBox usernm_textBox;
        public System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.PictureBox logo_pictureBox;
    }
}