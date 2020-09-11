namespace AD_CMS.LibraryMgmtSubForms
{
    partial class ReturnBook
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
            this.returnbook_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.grno_TextBox = new CustomControl.NumericTextBox();
            this.bookid_textbox = new CustomControl.NumericTextBox();
            this.studentnm_TextBox = new CustomControl.UpperTextBox();
            this.booknm_TextBox = new CustomControl.UpperTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add_new_category_label = new System.Windows.Forms.Label();
            this.Clear_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(440, 5);
            this.heading_label.Size = new System.Drawing.Size(234, 38);
            this.heading_label.Text = "Return Book";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.returnbook_datetimepicker);
            this.contentarea_panel.Controls.Add(this.grno_TextBox);
            this.contentarea_panel.Controls.Add(this.bookid_textbox);
            this.contentarea_panel.Controls.Add(this.studentnm_TextBox);
            this.contentarea_panel.Controls.Add(this.booknm_TextBox);
            this.contentarea_panel.Controls.Add(this.label1);
            this.contentarea_panel.Controls.Add(this.add_new_category_label);
            this.contentarea_panel.Controls.Add(this.Clear_button);
            this.contentarea_panel.Controls.Add(this.label7);
            this.contentarea_panel.Controls.Add(this.add_button);
            this.contentarea_panel.Controls.Add(this.label2);
            this.contentarea_panel.Controls.Add(this.label8);
            // 
            // returnbook_datetimepicker
            // 
            this.returnbook_datetimepicker.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbook_datetimepicker.Location = new System.Drawing.Point(377, 220);
            this.returnbook_datetimepicker.Name = "returnbook_datetimepicker";
            this.returnbook_datetimepicker.Size = new System.Drawing.Size(230, 25);
            this.returnbook_datetimepicker.TabIndex = 57;
            // 
            // grno_TextBox
            // 
            this.grno_TextBox.Enabled = false;
            this.grno_TextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grno_TextBox.Location = new System.Drawing.Point(377, 141);
            this.grno_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.grno_TextBox.MaxLength = 10;
            this.grno_TextBox.Name = "grno_TextBox";
            this.grno_TextBox.Size = new System.Drawing.Size(175, 26);
            this.grno_TextBox.TabIndex = 46;
            this.grno_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bookid_textbox
            // 
            this.bookid_textbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookid_textbox.Location = new System.Drawing.Point(377, 60);
            this.bookid_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.bookid_textbox.MaxLength = 10;
            this.bookid_textbox.Name = "bookid_textbox";
            this.bookid_textbox.Size = new System.Drawing.Size(175, 26);
            this.bookid_textbox.TabIndex = 47;
            this.bookid_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bookid_textbox.TextChanged += new System.EventHandler(this.bookid_textbox_TextChanged);
            this.bookid_textbox.Leave += new System.EventHandler(this.bookid_textbox_Leave);
            // 
            // studentnm_TextBox
            // 
            this.studentnm_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.studentnm_TextBox.Enabled = false;
            this.studentnm_TextBox.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.studentnm_TextBox.Location = new System.Drawing.Point(377, 178);
            this.studentnm_TextBox.MaxLength = 20;
            this.studentnm_TextBox.Multiline = true;
            this.studentnm_TextBox.Name = "studentnm_TextBox";
            this.studentnm_TextBox.Size = new System.Drawing.Size(210, 30);
            this.studentnm_TextBox.TabIndex = 49;
            this.studentnm_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // booknm_TextBox
            // 
            this.booknm_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.booknm_TextBox.Enabled = false;
            this.booknm_TextBox.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.booknm_TextBox.Location = new System.Drawing.Point(377, 97);
            this.booknm_TextBox.MaxLength = 20;
            this.booknm_TextBox.Multiline = true;
            this.booknm_TextBox.Name = "booknm_TextBox";
            this.booknm_TextBox.Size = new System.Drawing.Size(210, 30);
            this.booknm_TextBox.TabIndex = 48;
            this.booknm_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label1.Location = new System.Drawing.Point(199, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 27);
            this.label1.TabIndex = 53;
            this.label1.Text = "*Student Grno  : ";
            // 
            // add_new_category_label
            // 
            this.add_new_category_label.AutoSize = true;
            this.add_new_category_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.add_new_category_label.Location = new System.Drawing.Point(252, 60);
            this.add_new_category_label.Name = "add_new_category_label";
            this.add_new_category_label.Size = new System.Drawing.Size(119, 27);
            this.add_new_category_label.TabIndex = 54;
            this.add_new_category_label.Text = "*Book ID :";
            // 
            // Clear_button
            // 
            this.Clear_button.AutoSize = true;
            this.Clear_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Clear_button.FlatAppearance.BorderSize = 3;
            this.Clear_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Clear_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.Clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_button.Location = new System.Drawing.Point(662, 162);
            this.Clear_button.Margin = new System.Windows.Forms.Padding(2);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(161, 56);
            this.Clear_button.TabIndex = 51;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label7.Location = new System.Drawing.Point(198, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 27);
            this.label7.TabIndex = 56;
            this.label7.Text = "*Student Name :";
            // 
            // add_button
            // 
            this.add_button.AutoSize = true;
            this.add_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.add_button.FlatAppearance.BorderSize = 3;
            this.add_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.add_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(662, 81);
            this.add_button.Margin = new System.Windows.Forms.Padding(2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(161, 56);
            this.add_button.TabIndex = 50;
            this.add_button.Text = "Return";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label2.Location = new System.Drawing.Point(221, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 27);
            this.label2.TabIndex = 55;
            this.label2.Text = "*Book Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label8.Location = new System.Drawing.Point(220, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 27);
            this.label8.TabIndex = 52;
            this.label8.Text = "Return Date  :";
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "ReturnBook";
            this.Text = "ReturnBook";
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            this.contentarea_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker returnbook_datetimepicker;
        private CustomControl.NumericTextBox grno_TextBox;
        private CustomControl.NumericTextBox bookid_textbox;
        private CustomControl.UpperTextBox studentnm_TextBox;
        private CustomControl.UpperTextBox booknm_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label add_new_category_label;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}