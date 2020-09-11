using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomMessageBox;

namespace AD_CMS.AdminSection
{
    public partial class SoftwareVisualStyleChange : TemplateForm
    {
        public SoftwareVisualStyleChange()
        {
            InitializeComponent();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MainFormBack = pictureBox1.BackColor;
            Properties.Settings.Default.TemplateBack = pictureBox2.BackColor;
            Properties.Settings.Default.TemplateHeaderBack = pictureBox3.BackColor;
            Properties.Settings.Default.Save();
            AlertBox.ShowDialog("Successfully Changed.", AlertBox.AlertType.success, false);
        }

        private void SoftwareVisualStyleChange_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Properties.Settings.Default.MainFormBack;
            pictureBox2.BackColor = Properties.Settings.Default.TemplateBack;
            pictureBox3.BackColor = Properties.Settings.Default.TemplateHeaderBack;
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MainFormBack = Properties.Settings.Default.d_MainFormBack;
            Properties.Settings.Default.TemplateBack = Properties.Settings.Default.d_TemplateBack;
            Properties.Settings.Default.TemplateHeaderBack = Properties.Settings.Default.d_TemplateHeader;
            Properties.Settings.Default.Save();
            AlertBox.ShowDialog("Visual Style Reset.",AlertBox.AlertType.success,true);
            AlertBox.ShowDialog("Please Restart the Software to Get the Effect Properly..", AlertBox.AlertType.success, true);
        }

        private void Main_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Color_TextSet(pictureBox1);

        }

        private void Template_Back_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Color_TextSet(pictureBox2);
        }

        private void template_header_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Color_TextSet(pictureBox3);
        }

        private void Color_TextSet(Control ctrl)
        {
            if (ChooseColor.ShowDialog() == DialogResult.OK)
            {
                if (ChooseColor.Color == Color.Black && ctrl.Name != "pictureBox3")
                {
                    AlertBox.ShowDialog("Sorry.....:( We r not allow u to set the Black Color.", AlertBox.AlertType.warning, false);
                    AlertBox.ShowDialog("Please try another color.", AlertBox.AlertType.information, true);
                }
                else
                {
                    ctrl.BackColor = ChooseColor.Color;
                }
            }
        }
    }
}
