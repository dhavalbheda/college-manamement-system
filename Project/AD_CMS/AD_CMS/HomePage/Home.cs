using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AD_CMS.HomePage
{
    public partial class Home : TemplateForm
    {
        public Home()
        {
            InitializeComponent();
        }

        #region Variables
        int fileCount = 0;
        List<string> files = new List<string>();
        #endregion

        private void Home_Load(object sender, EventArgs e)
        {
            string icon = Properties.Settings.Default.CollegeIcon;
            string name = Properties.Settings.Default.CollegeName;
            string tagline = Properties.Settings.Default.CollegeTagLine;

            if (!string.IsNullOrEmpty(icon))
                Icon_pictureBox.Image = Image.FromFile(icon);
            
            name_label.Text = name;
            tagline_label.Text = tagline;

            fileCount = Directory.GetFiles(@"..\..\HomePage\SliderImages").Length;
            if (fileCount > 0)
            {
                string newFolderPath = @"..\..\HomePage\Sliders\";
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                Directory.Delete(newFolderPath,true);
                Directory.CreateDirectory(newFolderPath);

                foreach (string str in Directory.GetFiles(@"..\..\HomePage\SliderImages"))
                {
                    string newFile = newFolderPath+ Path.GetFileName(str);
                    File.Copy(str, newFile);
                    files.Add(newFile);
                }

                fileCount = 0;
                slider_pictureBox.Image = Image.FromFile(files[fileCount]);
                fileCount++;
                Animation.Enabled = true;
                Animation.Start();
            }
        }

        private void Animation_Tick(object sender, EventArgs e)
        {
            if (fileCount > files.Count-1)
            {
                fileCount = 0;
            }
            slider_pictureBox.Image = Image.FromFile(files[fileCount]);
            fileCount++;
        }
    }
}
