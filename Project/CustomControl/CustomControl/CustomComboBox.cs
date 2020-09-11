using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class CustomComboBox : ComboBox
    {
        public CustomComboBox()
        {
            InitializeComponent();
        }

        private void CustomComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CustomComboBox obj = sender as CustomComboBox;
            int ch = e.KeyChar;
            if ((ch < 65 || ch > 90) && (ch < 97 || ch > 122) && (ch != 8) && (ch != 32))
            {
                toolTip1.Show("Only Alphabatics r Allowed", obj);
                e.KeyChar = (char)0;
            }
            else
            {
                if (ch >= 97 && ch <= 122)
                {
                    e.KeyChar = (char)(ch-32);
                }
                toolTip1.Hide(obj);
            }
        }

    }
}
