using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomMessageBox
{
    public partial class AlertBox : Form
    {
        #region variables & enums
        private static AlertBox alt;
        private bool AutoClose { get; set; }
        private bool isMouseDown = false;
        private Point oldMousePoint, newMousePoint;
        public enum AlertType
        {
            success, information, warning, error
        }
        #endregion

        public AlertBox(string message,AlertType type,bool autoclose)
        {
            InitializeComponent();
            MessageLabel.Text = message;
            switch (type)
            {
                case AlertType.information:
                    this.BackColor = Color.Gray;
                    icon.Image = AD_CMS.Properties.Resources.information;
                    break;
                case AlertType.success:
                    this.BackColor = Color.SeaGreen;
                    icon.Image = AD_CMS.Properties.Resources.success;
                    break;
                case AlertType.warning:
                    this.BackColor = Color.FromArgb(255,128,0);
                    icon.Image = AD_CMS.Properties.Resources.warning;
                    break;
                case AlertType.error:
                    this.BackColor = Color.Crimson;
                    icon.Image = AD_CMS.Properties.Resources.error;
                    break;
            }
            start_timer.Enabled = true;
            start_timer.Start();
        }

        //initialize the object of this form and show it
        public static void ShowDialog(string message, AlertType type,bool autoclose)
        {
            if (alt != null)
                alt.Dispose();
            alt = new AlertBox(message, type,autoclose);
            alt.AutoClose = autoclose;
            alt.ShowDialog();
        }

        //form starting animation
        private void start_timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.1;
            }
            if (this.Opacity == 1.0)
            {
                start_timer.Enabled = false;
                start_timer.Stop();
                if (alt.AutoClose)
                {
                    auto_close_timer.Enabled = true;
                    auto_close_timer.Start();
                }
            }
        }

        //close button event
        private void CloseButton_Click(object sender, EventArgs e)
        {
            close_timer.Enabled = true;
            close_timer.Start();
        }
        
        //form closing animation
        private void close_timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 0.0)
            {
                this.Opacity -= 0.1;
            }
            if (this.Opacity <= 0.1)
                this.Dispose();
        }

        //form auto close timer event
        private void auto_close_timer_Tick(object sender, EventArgs e)
        {
            close_timer.Enabled = true;
            close_timer.Start();
        }

        //when form lost its focus then this function will give it focus
        private void Alert_FocusLost(object sender, EventArgs e)
        {
            this.Focus();
            this.BringToFront();
        }

        #region code for moving form without border
        private void Alert_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                oldMousePoint = e.Location;
            }
            else
            {
                isMouseDown = false;
            }
        }

        private void Alert_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                newMousePoint = e.Location;
                this.Location = new Point(this.Location.X + (newMousePoint.X - oldMousePoint.X), this.Location.Y + (newMousePoint.Y - oldMousePoint.Y));
            }
        }

        private void Alert_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
        #endregion
    }
}
