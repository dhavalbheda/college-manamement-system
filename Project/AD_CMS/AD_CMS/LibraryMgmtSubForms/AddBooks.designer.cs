namespace AD_CMS.LibraryMgmtSubForms
{
    partial class AddBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.add_new_category_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.booknm_TextBox = new CustomControl.UpperTextBox();
            this.authornm_TextBox = new CustomControl.UpperTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.publisernm_TextBox = new CustomControl.UpperTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.price_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.add_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.select_category_comboBox = new System.Windows.Forms.ComboBox();
            this.Add_Book_panel = new System.Windows.Forms.Panel();
            this.bookid_textbox = new CustomControl.NumericTextBox();
            this.Book_dataGridView = new System.Windows.Forms.DataGridView();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_numericUpDown)).BeginInit();
            this.Add_Book_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Book_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(468, 5);
            this.heading_label.Size = new System.Drawing.Size(198, 38);
            this.heading_label.Text = "Add Books";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.Book_dataGridView);
            this.contentarea_panel.Controls.Add(this.Add_Book_panel);
            // 
            // add_new_category_label
            // 
            this.add_new_category_label.AutoSize = true;
            this.add_new_category_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.add_new_category_label.Location = new System.Drawing.Point(116, 4);
            this.add_new_category_label.Name = "add_new_category_label";
            this.add_new_category_label.Size = new System.Drawing.Size(107, 27);
            this.add_new_category_label.TabIndex = 28;
            this.add_new_category_label.Text = "Book ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 27);
            this.label1.TabIndex = 28;
            this.label1.Text = "Select Category : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label2.Location = new System.Drawing.Point(84, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "Book Name :";
            // 
            // booknm_TextBox
            // 
            this.booknm_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.booknm_TextBox.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.booknm_TextBox.Location = new System.Drawing.Point(238, 82);
            this.booknm_TextBox.MaxLength = 20;
            this.booknm_TextBox.Multiline = true;
            this.booknm_TextBox.Name = "booknm_TextBox";
            this.booknm_TextBox.Size = new System.Drawing.Size(210, 33);
            this.booknm_TextBox.TabIndex = 2;
            this.booknm_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.booknm_TextBox.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // authornm_TextBox
            // 
            this.authornm_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.authornm_TextBox.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.authornm_TextBox.Location = new System.Drawing.Point(238, 121);
            this.authornm_TextBox.MaxLength = 20;
            this.authornm_TextBox.Multiline = true;
            this.authornm_TextBox.Name = "authornm_TextBox";
            this.authornm_TextBox.Size = new System.Drawing.Size(210, 33);
            this.authornm_TextBox.TabIndex = 3;
            this.authornm_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.authornm_TextBox.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label3.Location = new System.Drawing.Point(67, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "Author Name :";
            // 
            // publisernm_TextBox
            // 
            this.publisernm_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.publisernm_TextBox.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.publisernm_TextBox.Location = new System.Drawing.Point(238, 160);
            this.publisernm_TextBox.MaxLength = 20;
            this.publisernm_TextBox.Multiline = true;
            this.publisernm_TextBox.Name = "publisernm_TextBox";
            this.publisernm_TextBox.Size = new System.Drawing.Size(210, 33);
            this.publisernm_TextBox.TabIndex = 4;
            this.publisernm_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.publisernm_TextBox.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label4.Location = new System.Drawing.Point(59, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 27);
            this.label4.TabIndex = 28;
            this.label4.Text = "Publiser Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label6.Location = new System.Drawing.Point(144, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 27);
            this.label6.TabIndex = 28;
            this.label6.Text = "Price  :";
            // 
            // price_numericUpDown
            // 
            this.price_numericUpDown.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.price_numericUpDown.Location = new System.Drawing.Point(238, 200);
            this.price_numericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.price_numericUpDown.Name = "price_numericUpDown";
            this.price_numericUpDown.Size = new System.Drawing.Size(76, 27);
            this.price_numericUpDown.TabIndex = 6;
            this.price_numericUpDown.ValueChanged += new System.EventHandler(this.TextChanged);
            // 
            // add_button
            // 
            this.add_button.AutoSize = true;
            this.add_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.add_button.FlatAppearance.BorderSize = 3;
            this.add_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.add_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(523, 4);
            this.add_button.Margin = new System.Windows.Forms.Padding(2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(161, 56);
            this.add_button.TabIndex = 7;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.AutoSize = true;
            this.Clear_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Clear_button.FlatAppearance.BorderSize = 3;
            this.Clear_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Clear_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_button.Location = new System.Drawing.Point(523, 85);
            this.Clear_button.Margin = new System.Windows.Forms.Padding(2);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(161, 56);
            this.Clear_button.TabIndex = 8;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // select_category_comboBox
            // 
            this.select_category_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.select_category_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_category_comboBox.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.select_category_comboBox.FormattingEnabled = true;
            this.select_category_comboBox.Location = new System.Drawing.Point(239, 46);
            this.select_category_comboBox.Name = "select_category_comboBox";
            this.select_category_comboBox.Size = new System.Drawing.Size(174, 27);
            this.select_category_comboBox.TabIndex = 1;
            // 
            // Add_Book_panel
            // 
            this.Add_Book_panel.Controls.Add(this.bookid_textbox);
            this.Add_Book_panel.Controls.Add(this.booknm_TextBox);
            this.Add_Book_panel.Controls.Add(this.select_category_comboBox);
            this.Add_Book_panel.Controls.Add(this.add_new_category_label);
            this.Add_Book_panel.Controls.Add(this.Clear_button);
            this.Add_Book_panel.Controls.Add(this.label1);
            this.Add_Book_panel.Controls.Add(this.add_button);
            this.Add_Book_panel.Controls.Add(this.label2);
            this.Add_Book_panel.Controls.Add(this.price_numericUpDown);
            this.Add_Book_panel.Controls.Add(this.label3);
            this.Add_Book_panel.Controls.Add(this.label4);
            this.Add_Book_panel.Controls.Add(this.publisernm_TextBox);
            this.Add_Book_panel.Controls.Add(this.authornm_TextBox);
            this.Add_Book_panel.Controls.Add(this.label6);
            this.Add_Book_panel.Location = new System.Drawing.Point(158, 25);
            this.Add_Book_panel.Name = "Add_Book_panel";
            this.Add_Book_panel.Size = new System.Drawing.Size(730, 285);
            this.Add_Book_panel.TabIndex = 33;
            // 
            // bookid_textbox
            // 
            this.bookid_textbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookid_textbox.Location = new System.Drawing.Point(238, 4);
            this.bookid_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.bookid_textbox.MaxLength = 10;
            this.bookid_textbox.Name = "bookid_textbox";
            this.bookid_textbox.Size = new System.Drawing.Size(175, 26);
            this.bookid_textbox.TabIndex = 0;
            this.bookid_textbox.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // Book_dataGridView
            // 
            this.Book_dataGridView.AllowUserToAddRows = false;
            this.Book_dataGridView.AllowUserToDeleteRows = false;
            this.Book_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Book_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Book_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Book_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Book_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Book_dataGridView.Location = new System.Drawing.Point(61, 315);
            this.Book_dataGridView.Name = "Book_dataGridView";
            this.Book_dataGridView.ReadOnly = true;
            this.Book_dataGridView.Size = new System.Drawing.Size(968, 320);
            this.Book_dataGridView.TabIndex = 10;
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "AddBooks";
            this.Text = "AddBooks";
            this.Load += new System.EventHandler(this.AddBooks_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_numericUpDown)).EndInit();
            this.Add_Book_panel.ResumeLayout(false);
            this.Add_Book_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Book_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.UpperTextBox authornm_TextBox;
        private CustomControl.UpperTextBox booknm_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label add_new_category_label;
        private CustomControl.UpperTextBox publisernm_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown price_numericUpDown;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ComboBox select_category_comboBox;
        private System.Windows.Forms.Panel Add_Book_panel;
        private CustomControl.NumericTextBox bookid_textbox;
        private System.Windows.Forms.DataGridView Book_dataGridView;
    }
}