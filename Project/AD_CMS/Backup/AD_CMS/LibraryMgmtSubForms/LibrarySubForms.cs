using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AD_CMS.LibraryMgmtSubForms
{
    public partial class LibrarySubForms : TemplateForm
    {
        public LibrarySubForms()
        {
            InitializeComponent();
        }

        private void Book_Category_Click(object sender, EventArgs e)
        {
            Category ct = new Category();
            FormCall(ct);
        }

        private void addbook_Click(object sender, EventArgs e)
        {
            AddBooks AB = new AddBooks();
            FormCall(AB);
        }

        private void borrowbook_Click(object sender, EventArgs e)
        {
            BorrowBook bb = new BorrowBook();
            FormCall(bb);
        }

        private void returnbook_Click(object sender, EventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            FormCall(rb);
        }

        private static void FormCall(Form fm)
        {
            fm.TopLevel = false;
            fm.Parent = ClassCall.mainFormObj.masterpanel;
            fm.Dock = DockStyle.Fill;
            fm.Show();
            fm.BringToFront();
            fm.Focus();
        }
    }
}
