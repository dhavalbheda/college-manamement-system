namespace AD_CMS.CollegeDetails
{
    partial class SetUser
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
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.re_password_label = new System.Windows.Forms.Label();
            this.Ok_button = new System.Windows.Forms.Button();
            this.username_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.re_password_TextBox = new System.Windows.Forms.TextBox();
            this.userRole_comboBox = new CustomControl.CustomComboBox();
            this.select_role_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.users_dataGridView = new System.Windows.Forms.DataGridView();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(478, 5);
            this.heading_label.Size = new System.Drawing.Size(158, 38);
            this.heading_label.Text = "Set User";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.users_dataGridView);
            this.contentarea_panel.Controls.Add(this.panel1);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(186, 14);
            this.username_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(114, 22);
            this.username_label.TabIndex = 10;
            this.username_label.Text = "User Name : ";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(196, 58);
            this.password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(104, 22);
            this.password_label.TabIndex = 10;
            this.password_label.Text = "Password : ";
            // 
            // re_password_label
            // 
            this.re_password_label.AutoSize = true;
            this.re_password_label.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.re_password_label.Location = new System.Drawing.Point(123, 102);
            this.re_password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.re_password_label.Name = "re_password_label";
            this.re_password_label.Size = new System.Drawing.Size(177, 22);
            this.re_password_label.TabIndex = 10;
            this.re_password_label.Text = "Re-Type Password : ";
            // 
            // Ok_button
            // 
            this.Ok_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ok_button.Location = new System.Drawing.Point(137, 207);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(133, 64);
            this.Ok_button.TabIndex = 5;
            this.Ok_button.Text = "Create User";
            this.Ok_button.UseVisualStyleBackColor = true;
            this.Ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // username_TextBox
            // 
            this.username_TextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_TextBox.Location = new System.Drawing.Point(323, 9);
            this.username_TextBox.Multiline = true;
            this.username_TextBox.Name = "username_TextBox";
            this.username_TextBox.Size = new System.Drawing.Size(157, 27);
            this.username_TextBox.TabIndex = 1;
            this.username_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username_TextBox.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // password_TextBox
            // 
            this.password_TextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_TextBox.Location = new System.Drawing.Point(323, 53);
            this.password_TextBox.MaxLength = 14;
            this.password_TextBox.Multiline = true;
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(157, 27);
            this.password_TextBox.TabIndex = 2;
            this.password_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_TextBox.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // re_password_TextBox
            // 
            this.re_password_TextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.re_password_TextBox.Location = new System.Drawing.Point(323, 97);
            this.re_password_TextBox.MaxLength = 14;
            this.re_password_TextBox.Multiline = true;
            this.re_password_TextBox.Name = "re_password_TextBox";
            this.re_password_TextBox.Size = new System.Drawing.Size(157, 27);
            this.re_password_TextBox.TabIndex = 4;
            this.re_password_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.re_password_TextBox.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // userRole_comboBox
            // 
            this.userRole_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userRole_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRole_comboBox.FormattingEnabled = true;
            this.userRole_comboBox.Location = new System.Drawing.Point(323, 146);
            this.userRole_comboBox.Name = "userRole_comboBox";
            this.userRole_comboBox.Size = new System.Drawing.Size(146, 28);
            this.userRole_comboBox.TabIndex = 16;
            // 
            // select_role_label
            // 
            this.select_role_label.AutoSize = true;
            this.select_role_label.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_role_label.Location = new System.Drawing.Point(182, 151);
            this.select_role_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.select_role_label.Name = "select_role_label";
            this.select_role_label.Size = new System.Drawing.Size(118, 22);
            this.select_role_label.TabIndex = 10;
            this.select_role_label.Text = "Select Role : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userRole_comboBox);
            this.panel1.Controls.Add(this.password_TextBox);
            this.panel1.Controls.Add(this.re_password_TextBox);
            this.panel1.Controls.Add(this.username_label);
            this.panel1.Controls.Add(this.password_label);
            this.panel1.Controls.Add(this.username_TextBox);
            this.panel1.Controls.Add(this.re_password_label);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Ok_button);
            this.panel1.Controls.Add(this.select_role_label);
            this.panel1.Location = new System.Drawing.Point(161, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 285);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(332, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // users_dataGridView
            // 
            this.users_dataGridView.AllowUserToAddRows = false;
            this.users_dataGridView.AllowUserToDeleteRows = false;
            this.users_dataGridView.AllowUserToOrderColumns = true;
            this.users_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.users_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_dataGridView.Location = new System.Drawing.Point(140, 368);
            this.users_dataGridView.Name = "users_dataGridView";
            this.users_dataGridView.Size = new System.Drawing.Size(810, 254);
            this.users_dataGridView.TabIndex = 17;
            this.users_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.users_dataGridView_CellClick);
            // 
            // SetUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "SetUser";
            this.Text = "Set_User";
            this.Load += new System.EventHandler(this.SetUser_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Button Ok_button;
        private System.Windows.Forms.Label re_password_label;
        private System.Windows.Forms.TextBox re_password_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.TextBox username_TextBox;
        private CustomControl.CustomComboBox userRole_comboBox;
        private System.Windows.Forms.Label select_role_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView users_dataGridView;
    }
}