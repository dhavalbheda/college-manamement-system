using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AD_CMS
{
    public partial class TemplateForm : Form
    {
        public TemplateForm()
        {
            InitializeComponent();
            
            contentarea_panel.BackColor = Properties.Settings.Default.TemplateBack;
            
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
