namespace AD_CMS.LibraryMgmtSubForms
{
    partial class LibrarySubForms
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
            this.BorrowBook_label = new System.Windows.Forms.Label();
            this.AddBook_label = new System.Windows.Forms.Label();
            this.BorrowBook_pictureBox = new System.Windows.Forms.PictureBox();
            this.AddBook_pictureBox = new System.Windows.Forms.PictureBox();
            this.BookCategory_pictureBox = new System.Windows.Forms.PictureBox();
            this.Category_label = new System.Windows.Forms.Label();
            this.ReturnBook_label = new System.Windows.Forms.Label();
            this.ReturnBook_pictureBox = new System.Windows.Forms.PictureBox();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.icon_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowBook_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBook_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookCategory_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBook_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Location = new System.Drawing.Point(374, 5);
            this.heading_label.Size = new System.Drawing.Size(366, 38);
            this.heading_label.Text = "Library Management";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.icon_tableLayoutPanel);
            // 
            // icon_tableLayoutPanel
            // 
            this.icon_tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_tableLayoutPanel.ColumnCount = 4;
            this.icon_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.icon_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.icon_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.icon_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99812F));
            this.icon_tableLayoutPanel.Controls.Add(this.BorrowBook_label, 2, 1);
            this.icon_tableLayoutPanel.Controls.Add(this.AddBook_label, 1, 1);
            this.icon_tableLayoutPanel.Controls.Add(this.BorrowBook_pictureBox, 2, 0);
            this.icon_tableLayoutPanel.Controls.Add(this.AddBook_pictureBox, 1, 0);
            this.icon_tableLayoutPanel.Controls.Add(this.BookCategory_pictureBox, 0, 0);
            this.icon_tableLayoutPanel.Controls.Add(this.Category_label, 0, 1);
            this.icon_tableLayoutPanel.Controls.Add(this.ReturnBook_label, 3, 1);
            this.icon_tableLayoutPanel.Controls.Add(this.ReturnBook_pictureBox, 3, 0);
            this.icon_tableLayoutPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_tableLayoutPanel.Location = new System.Drawing.Point(6, 6);
            this.icon_tableLayoutPanel.Name = "icon_tableLayoutPanel";
            this.icon_tableLayoutPanel.RowCount = 2;
            this.icon_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.99268F));
            this.icon_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.00733F));
            this.icon_tableLayoutPanel.Size = new System.Drawing.Size(993, 273);
            this.icon_tableLayoutPanel.TabIndex = 2;
            // 
            // BorrowBook_label
            // 
            this.BorrowBook_label.AutoSize = true;
            this.BorrowBook_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorrowBook_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.BorrowBook_label.Location = new System.Drawing.Point(499, 201);
            this.BorrowBook_label.Name = "BorrowBook_label";
            this.BorrowBook_label.Size = new System.Drawing.Size(242, 72);
            this.BorrowBook_label.TabIndex = 2;
            this.BorrowBook_label.Text = "Borrow Books";
            this.BorrowBook_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BorrowBook_label.Click += new System.EventHandler(this.borrowbook_Click);
            // 
            // AddBook_label
            // 
            this.AddBook_label.AutoSize = true;
            this.AddBook_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddBook_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.AddBook_label.Location = new System.Drawing.Point(251, 201);
            this.AddBook_label.Name = "AddBook_label";
            this.AddBook_label.Size = new System.Drawing.Size(242, 72);
            this.AddBook_label.TabIndex = 1;
            this.AddBook_label.Text = "Add Book";
            this.AddBook_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBook_label.Click += new System.EventHandler(this.addbook_Click);
            // 
            // BorrowBook_pictureBox
            // 
            this.BorrowBook_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorrowBook_pictureBox.Image = global::AD_CMS.Properties.Resources.Borrow_Book;
            this.BorrowBook_pictureBox.Location = new System.Drawing.Point(499, 3);
            this.BorrowBook_pictureBox.Name = "BorrowBook_pictureBox";
            this.BorrowBook_pictureBox.Size = new System.Drawing.Size(242, 195);
            this.BorrowBook_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BorrowBook_pictureBox.TabIndex = 2;
            this.BorrowBook_pictureBox.TabStop = false;
            this.BorrowBook_pictureBox.Click += new System.EventHandler(this.borrowbook_Click);
            // 
            // AddBook_pictureBox
            // 
            this.AddBook_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddBook_pictureBox.Image = global::AD_CMS.Properties.Resources.add_book;
            this.AddBook_pictureBox.Location = new System.Drawing.Point(251, 3);
            this.AddBook_pictureBox.Name = "AddBook_pictureBox";
            this.AddBook_pictureBox.Size = new System.Drawing.Size(242, 195);
            this.AddBook_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddBook_pictureBox.TabIndex = 1;
            this.AddBook_pictureBox.TabStop = false;
            this.AddBook_pictureBox.Click += new System.EventHandler(this.addbook_Click);
            // 
            // BookCategory_pictureBox
            // 
            this.BookCategory_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookCategory_pictureBox.Image = global::AD_CMS.Properties.Resources.Book_Category;
            this.BookCategory_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.BookCategory_pictureBox.Name = "BookCategory_pictureBox";
            this.BookCategory_pictureBox.Size = new System.Drawing.Size(242, 195);
            this.BookCategory_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookCategory_pictureBox.TabIndex = 0;
            this.BookCategory_pictureBox.TabStop = false;
            this.BookCategory_pictureBox.Click += new System.EventHandler(this.Book_Category_Click);
            // 
            // Category_label
            // 
            this.Category_label.AutoSize = true;
            this.Category_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Category_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.Category_label.Location = new System.Drawing.Point(3, 201);
            this.Category_label.Name = "Category_label";
            this.Category_label.Size = new System.Drawing.Size(242, 72);
            this.Category_label.TabIndex = 0;
            this.Category_label.Text = "Books Category";
            this.Category_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Category_label.Click += new System.EventHandler(this.Book_Category_Click);
            // 
            // ReturnBook_label
            // 
            this.ReturnBook_label.AutoSize = true;
            this.ReturnBook_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReturnBook_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.ReturnBook_label.Location = new System.Drawing.Point(747, 201);
            this.ReturnBook_label.Name = "ReturnBook_label";
            this.ReturnBook_label.Size = new System.Drawing.Size(243, 72);
            this.ReturnBook_label.TabIndex = 2;
            this.ReturnBook_label.Text = "Return Books";
            this.ReturnBook_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReturnBook_label.Click += new System.EventHandler(this.returnbook_Click);
            // 
            // ReturnBook_pictureBox
            // 
            this.ReturnBook_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReturnBook_pictureBox.Image = global::AD_CMS.Properties.Resources.return_book;
            this.ReturnBook_pictureBox.Location = new System.Drawing.Point(747, 3);
            this.ReturnBook_pictureBox.Name = "ReturnBook_pictureBox";
            this.ReturnBook_pictureBox.Size = new System.Drawing.Size(243, 195);
            this.ReturnBook_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ReturnBook_pictureBox.TabIndex = 2;
            this.ReturnBook_pictureBox.TabStop = false;
            this.ReturnBook_pictureBox.Click += new System.EventHandler(this.returnbook_Click);
            // 
            // LibrarySubForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "LibrarySubForms";
            this.Text = "LibrarySubForms";
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.icon_tableLayoutPanel.ResumeLayout(false);
            this.icon_tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowBook_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBook_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookCategory_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBook_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel icon_tableLayoutPanel;
        private System.Windows.Forms.Label BorrowBook_label;
        private System.Windows.Forms.Label AddBook_label;
        private System.Windows.Forms.PictureBox BorrowBook_pictureBox;
        private System.Windows.Forms.PictureBox AddBook_pictureBox;
        private System.Windows.Forms.Label Category_label;
        private System.Windows.Forms.Label ReturnBook_label;
        private System.Windows.Forms.PictureBox ReturnBook_pictureBox;
        private System.Windows.Forms.PictureBox BookCategory_pictureBox;

    }
}