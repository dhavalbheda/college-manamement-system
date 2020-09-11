using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions; 

namespace CustomControl
{
    public partial class EmailTextBox : TextBox
    {
        public int isEmailValidate;

        public EmailTextBox()
        {
            InitializeComponent();
        }
        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            EmailTextBox email = sender as EmailTextBox;

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            Match match = regex.Match(email.Text);
            if (!match.Success || email.Text == "")
            {
                isEmailValidate = 0;
            }
            else
            {
                isEmailValidate = 1;
            }
        }
    }
}
