using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AD_CMS.Attendance
{
    public partial class Instructions : TemplateForm
    {
        public Instructions()
        {
            InitializeComponent();
        }

        PictureBox p1;
        Timer t1;
        int counter;
        string path;

        private void Instructions_Load(object sender, EventArgs e)
        {
            string str = "\u25a0 Steps How To Creat your own Attendance Sheet :) \u25a0";
            str += "\r\n\n \u274f Open Microsoft Excel." +
                    "\r\n \u274f Right Click on Sheet1(At the bottom of the file) -> Rename -> 'AttendanceSheet'." +
                    "\r\n \u274f Software will detect only this name sheet not others." +
                    "\r\n \u274f In Columns A-AG , the headings r :  RollNo,Student Name,1,2,3,4,5,6,.....,31" +
                    "\r\n\n \u274f All Columns Must have valid Data like........" +
                    "\r\n       \u274f RollNo must have only Non-Negative Integeral Number." +
                    "\r\n       \u274f Student Name must have only Alphabets" +
                    "\r\n       \u274f 1,2,3,.......,31 this are the dates where u can only write 'p/P' for Present or 'a/A' for absent." +
                    "\r\n       \u274f You can also leave it if there is any holidays" +
                    "\r\n\n\n \u25e6\u25e6\u25e6\u25e6\u25e6\u25e6\u25e6 We Also Provide the Readymade format You Can Download It From Other Option. \u25e6\u25e6\u25e6\u25e6\u25e6\u25e6\u25e6";
                    
            Instructions_label.Text = str;

            p1 = new PictureBox();
            p1.Location = new Point(121,116);
            p1.Size = new Size(840,391);
            p1.SizeMode = PictureBoxSizeMode.Zoom;
            path = Properties.Settings.Default.AttendancePath + @"Steps\";
            counter++;
            p1.Image = Image.FromFile(path + counter + ".png");

            this.tabControl1.TabPages[1].Controls.Add(p1);

            t1 = new Timer();
            t1.Interval = 3000;

            this.p1.MouseLeave += new System.EventHandler(this.p1_MouseLeave);
            this.p1.MouseEnter += new System.EventHandler(this.p1_MouseEnter);
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            if (counter >= 6)
                counter = 1;
            else
                counter++;
            p1.Image = Image.FromFile(path + counter + ".png");
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                t1.Stop();
            }
            else
            {
                t1.Enabled = true;
                t1.Start();
            }
        }

        private void p1_MouseEnter(object sender, EventArgs e)
        {
            t1.Enabled = false;
            t1.Stop();
        }

        private void p1_MouseLeave(object sender, EventArgs e)
        {
            t1.Enabled = true;
            t1.Start();
        }
    }
}
