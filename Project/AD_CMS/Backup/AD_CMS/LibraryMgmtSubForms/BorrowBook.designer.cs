namespace AD_CMS.LibraryMgmtSubForms
{
    partial class BorrowBook
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
            this.bookid_textbox = new CustomControl.NumericTextBox();
            this.booknm_TextBox = new CustomControl.UpperTextBox();
            this.add_new_category_label = new System.Windows.Forms.Label();
            this.Clear_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grno_TextBox = new CustomControl.NumericTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.studentnm_TextBox = new CustomControl.UpperTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Size = new System.Drawing.Size(246, 38);
            this.heading_label.Text = "Borrow Book";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.dateTimePicker2);
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
            // bookid_textbox
            // 
            this.bookid_textbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookid_textbox.Location = new System.Drawing.Point(338, 135);
            this.bookid_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.bookid_textbox.MaxLength = 10;
            this.bookid_textbox.Name = "bookid_textbox";
            this.bookid_textbox.Size = new System.Drawing.Size(175, 26);
            this.bookid_textbox.TabIndex = 29;
            this.bookid_textbox.TextChanged += new System.EventHandler(this.TextChanged);
            this.bookid_textbox.Leave += new System.EventHandler(this.bookid_textbox_Leave);
            // 
            // booknm_TextBox
            // 
            this.booknm_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.booknm_TextBox.Enabled = false;
            this.booknm_TextBox.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.booknm_TextBox.Location = new System.Drawing.Point(338, 172);
            this.booknm_TextBox.MaxLength = 20;
            this.booknm_TextBox.Multiline = true;
            this.booknm_TextBox.Name = "booknm_TextBox";
            this.booknm_TextBox.Size = new System.Drawing.Size(210, 30);
            this.booknm_TextBox.TabIndex = 31;
            this.booknm_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add_new_category_label
            // 
            this.add_new_category_label.AutoSize = true;
            this.add_new_category_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.add_new_category_label.Location = new System.Drawing.Point(213, 135);
            this.add_new_category_label.Name = "add_new_category_label";
            this.add_new_category_label.Size = new System.Drawing.Size(119, 27);
            this.add_new_category_label.TabIndex = 42;
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
            this.Clear_button.Location = new System.Drawing.Point(623, 156);
            this.Clear_button.Margin = new System.Windows.Forms.Padding(2);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(161, 56);
            this.Clear_button.TabIndex = 37;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
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
            this.add_button.Location = new System.Drawing.Point(623, 75);
            this.add_button.Margin = new System.Windows.Forms.Padding(2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(161, 56);
            this.add_button.TabIndex = 36;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label2.Location = new System.Drawing.Point(182, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 27);
            this.label2.TabIndex = 44;
            this.label2.Text = "*Book Name :";
            // 
            // grno_TextBox
            // 
            this.grno_TextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grno_TextBox.Location = new System.Drawing.Point(338, 57);
            this.grno_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.grno_TextBox.MaxLength = 10;
            this.grno_TextBox.Name = "grno_TextBox";
            this.grno_TextBox.Size = new System.Drawing.Size(175, 26);
            this.grno_TextBox.TabIndex = 29;
            this.grno_TextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.grno_TextBox.Leave += new System.EventHandler(this.grno_TextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label1.Location = new System.Drawing.Point(160, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 27);
            this.label1.TabIndex = 42;
            this.label1.Text = "*Student Grno  : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label7.Location = new System.Drawing.Point(159, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 27);
            this.label7.TabIndex = 44;
            this.label7.Text = "*Student Name :";
            // 
            // studentnm_TextBox
            // 
            this.studentnm_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.studentnm_TextBox.Enabled = false;
            this.studentnm_TextBox.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.studentnm_TextBox.Location = new System.Drawing.Point(338, 94);
            this.studentnm_TextBox.MaxLength = 20;
            this.studentnm_TextBox.Multiline = true;
            this.studentnm_TextBox.Name = "studentnm_TextBox";
            this.studentnm_TextBox.Size = new System.Drawing.Size(210, 30);
            this.studentnm_TextBox.TabIndex = 31;
            this.studentnm_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label8.Location = new System.Drawing.Point(202, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 27);
            this.label8.TabIndex = 38;
            this.label8.Text = "Issue Date  :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(338, 214);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(230, 25);
            this.dateTimePicker2.TabIndex = 45;
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "BorrowBook";
            this.Text = "BorrowBook";
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            this.contentarea_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.NumericTextBox bookid_textbox;
        private CustomControl.UpperTextBox booknm_TextBox;
        private System.Windows.Forms.Label add_new_category_label;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label2;
        private CustomControl.NumericTextBox grno_TextBox;
        private CustomControl.UpperTextBox studentnm_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
    }
}