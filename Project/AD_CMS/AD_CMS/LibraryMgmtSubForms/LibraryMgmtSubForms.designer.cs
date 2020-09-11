namespace AD_CMS.LibraryMgmtSubForms
{
    partial class LibraryMgmtSubForms
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
            this.category = new System.Windows.Forms.Button();
            this.AddBook = new System.Windows.Forms.Button();
            this.borrow_button = new System.Windows.Forms.Button();
            this.return_book = new System.Windows.Forms.Button();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Size = new System.Drawing.Size(366, 38);
            this.heading_label.Text = "Library Management";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.return_book);
            this.contentarea_panel.Controls.Add(this.borrow_button);
            this.contentarea_panel.Controls.Add(this.AddBook);
            this.contentarea_panel.Controls.Add(this.category);
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(64, 19);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(225, 162);
            this.category.TabIndex = 0;
            this.category.Text = "Category";
            this.category.UseVisualStyleBackColor = true;
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(329, 19);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(225, 162);
            this.AddBook.TabIndex = 0;
            this.AddBook.Text = "Addbook";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.addbook_Click);
            // 
            // borrow_button
            // 
            this.borrow_button.Location = new System.Drawing.Point(589, 19);
            this.borrow_button.Name = "borrow_button";
            this.borrow_button.Size = new System.Drawing.Size(225, 162);
            this.borrow_button.TabIndex = 0;
            this.borrow_button.Text = "Borrowbook";
            this.borrow_button.UseVisualStyleBackColor = true;
            this.borrow_button.Click += new System.EventHandler(this.borrowaddbook_Click);
            // 
            // return_book
            // 
            this.return_book.Location = new System.Drawing.Point(57, 217);
            this.return_book.Name = "return_book";
            this.return_book.Size = new System.Drawing.Size(225, 162);
            this.return_book.TabIndex = 0;
            this.return_book.Text = "Borrowbook";
            this.return_book.UseVisualStyleBackColor = true;
            this.return_book.Click += new System.EventHandler(this.returnbook_Click);
            // 
            // LibraryMgmtSubForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "LibraryMgmtSubForms";
            this.Text = "LibraryMgmtSubForms";
            this.Load += new System.EventHandler(this.LibraryMgmtSubForms_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button category;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button borrow_button;
        private System.Windows.Forms.Button return_book;
    }
}