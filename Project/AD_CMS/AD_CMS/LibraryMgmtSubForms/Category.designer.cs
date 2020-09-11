namespace AD_CMS.LibraryMgmtSubForms
{
    partial class Category
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
            this.add_button = new System.Windows.Forms.Button();
            this.category_TextBox = new CustomControl.UpperTextBox();
            this.Category_dataGridView = new System.Windows.Forms.DataGridView();
            this.heading_panel.SuspendLayout();
            this.contentarea_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Category_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.Size = new System.Drawing.Size(304, 38);
            this.heading_label.Text = "Manage Category";
            // 
            // contentarea_panel
            // 
            this.contentarea_panel.Controls.Add(this.Category_dataGridView);
            this.contentarea_panel.Controls.Add(this.category_TextBox);
            this.contentarea_panel.Controls.Add(this.add_button);
            this.contentarea_panel.Controls.Add(this.add_new_category_label);
            // 
            // add_new_category_label
            // 
            this.add_new_category_label.AutoSize = true;
            this.add_new_category_label.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.add_new_category_label.Location = new System.Drawing.Point(69, 69);
            this.add_new_category_label.Name = "add_new_category_label";
            this.add_new_category_label.Size = new System.Drawing.Size(216, 27);
            this.add_new_category_label.TabIndex = 0;
            this.add_new_category_label.Text = "Add New Category : ";
            // 
            // add_button
            // 
            this.add_button.AutoSize = true;
            this.add_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.add_button.FlatAppearance.BorderSize = 3;
            this.add_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.add_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(532, 46);
            this.add_button.Margin = new System.Windows.Forms.Padding(2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(161, 56);
            this.add_button.TabIndex = 26;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // category_TextBox
            // 
            this.category_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.category_TextBox.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.category_TextBox.Location = new System.Drawing.Point(291, 64);
            this.category_TextBox.MaxLength = 20;
            this.category_TextBox.Multiline = true;
            this.category_TextBox.Name = "category_TextBox";
            this.category_TextBox.Size = new System.Drawing.Size(210, 33);
            this.category_TextBox.TabIndex = 27;
            this.category_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Category_dataGridView
            // 
            this.Category_dataGridView.AllowUserToAddRows = false;
            this.Category_dataGridView.AllowUserToDeleteRows = false;
            this.Category_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Category_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Category_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Category_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Category_dataGridView.Location = new System.Drawing.Point(61, 127);
            this.Category_dataGridView.Name = "Category_dataGridView";
            this.Category_dataGridView.ReadOnly = true;
            this.Category_dataGridView.Size = new System.Drawing.Size(968, 401);
            this.Category_dataGridView.TabIndex = 28;
            this.Category_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Category_dataGridView_CellClick);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.heading_panel.ResumeLayout(false);
            this.heading_panel.PerformLayout();
            this.contentarea_panel.ResumeLayout(false);
            this.contentarea_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Category_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label add_new_category_label;
        private System.Windows.Forms.Button add_button;
        private CustomControl.UpperTextBox category_TextBox;
        private System.Windows.Forms.DataGridView Category_dataGridView;
    }
}