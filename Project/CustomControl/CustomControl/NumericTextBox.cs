using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class NumericTextBox : TextBox
    {
        public NumericTextBox()
        {
            InitializeComponent();
        }

        private void ContactNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericTextBox contact = sender as NumericTextBox;
            int ch = e.KeyChar;
            if ((ch < 48 || ch > 57) && ch != 8)
            {
                toolTip1.Show("Only Numbers Allow", contact);
                e.KeyChar = (char)0;
            }
            else
            {
                toolTip1.Hide(contact);
            }
        }
    }
}
