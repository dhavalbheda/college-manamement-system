using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomMessageBox;
using AD_CMS_Entity;
using AD_CMS_DatabaseModel;
using System.Data.SqlClient;

namespace AD_CMS.LibraryMgmtSubForms
{
    public partial class Category : TemplateForm
    {
        DataTable dt_Category;
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            loadCategory();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (category_TextBox.Text != "")
            {
                Library_Entity le = new Library_Entity()
                {
                    category_name = category_TextBox.Text
                };
                Library_Methods.Add_category(le);
                AlertBox.ShowDialog("Category Add Successfully...", AlertBox.AlertType.success, true);
                Category_dataGridView.Columns.RemoveAt(Category_dataGridView.Columns.Count - 1);
                loadCategory();
            }
            else
            {
                AlertBox.ShowDialog("Please Enter Category...", AlertBox.AlertType.warning, true);
                category_TextBox.BackColor = Color.Pink;
            }
        }
        private void loadCategory()
        {
            dt_Category = Library_Methods.load_category_Datagridview();
            Category_dataGridView.DataSource = dt_Category;

            Category_dataGridView.AutoGenerateColumns = false;
            if (!Category_dataGridView.Columns.Contains("remove"))
            {
                DataGridViewLinkColumn dc = new DataGridViewLinkColumn()
                {
                    Text = "Remove",
                    HeaderText = "Edit",
                    Name = "remove",
                    UseColumnTextForLinkValue = true,
                    LinkColor = Color.Crimson,
                    LinkBehavior = LinkBehavior.HoverUnderline
                };
                Category_dataGridView.Columns.Insert(Category_dataGridView.Columns.Count, dc);
                Category_dataGridView.Columns[0].Visible = false;
            }
        }

        private void Category_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridView dgv = sender as DataGridView;
                string ctnm = "";
                if (dgv.Rows.Count > 0)
                {
                    ctnm = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                    if (e.ColumnIndex == 2)
                    {
                        int affectedRows = Library_Methods.Delete_category(ctnm);
                        if (affectedRows > 0)
                        {
                            AlertBox.ShowDialog("Category Deleted Successfully", AlertBox.AlertType.success, true);
                            Category_dataGridView.Columns.RemoveAt(Category_dataGridView.Columns.Count - 1);
                            loadCategory();
                        }
                    }
                }
            }
        }
    }
}
