using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class UpperTextBox : TextBox
    {
        public UpperTextBox()
        {
            InitializeComponent();
        }

        private void UpperTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpperTextBox upper = sender as UpperTextBox;
            int ch = e.KeyChar;
            if ((ch < 65 || ch > 90) && (ch < 97 || ch > 122) && (ch != 8) && (ch != 32))
            {
                toolTip1.Show("Only Alphabatic Allow", upper);
                e.KeyChar = (char)0;
            }
            else
            {
                toolTip1.Hide(upper);
            }
        }

    }
}
