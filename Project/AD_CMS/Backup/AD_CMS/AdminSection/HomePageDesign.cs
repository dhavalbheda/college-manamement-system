using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CustomMessageBox;

namespace AD_CMS.AdminSection
{
    public partial class HomePageDesign : TemplateForm
    {
        public HomePageDesign()
        {
            InitializeComponent();
        }

        #region variables
        bool isStoreImage = false;
        string FileName, fileExtension;
        List<string> Slider_img_Fullpath = new List<string>();
        List<string> img_name = new List<string>();
        List<string> removed_img = new List<string>();
        #endregion

        private void submit_button_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.CollegeName = clgnm_textBox.Text;

                if (isStoreImage)
                {
                    string oldFile = Properties.Settings.Default.CollegeIcon;
                    string newPath = @"..\..\Resources\"+Path.GetFileName(FileName)+fileExtension;
                    File.Copy(FileName, newPath);
                    Properties.Settings.Default.CollegeIcon = newPath;
                    Properties.Settings.Default.DeleteIconPath = oldFile;
                }

                Properties.Settings.Default.CollegeTagLine = clg_tag_linetextBox.Text;

                if (slider_images_listBox.Items.Count > 0)
                {
                    string temp_path = @"..\..\HomePage\temp\";
                    string slider_path = @"..\..\HomePage\SliderImages\";
                    
                    //Copying data to temp Directory
                    int i = 0;
                    foreach (string filenm in Slider_img_Fullpath)
                    {
                        File.Copy(filenm, temp_path + img_name[i], true);
                        i++;
                    }
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();

                    //Deleteing data from SliderImages Directory
                    foreach (string fnm in Directory.GetFiles(slider_path))
                    {
                        File.Delete(fnm);
                    }

                    i = 0;
                    foreach (string fnm in Directory.GetFiles(temp_path))
                    {
                        //copying data to sliderImages Directory
                        File.Copy(fnm, slider_path + img_name[i]);
                        //delete data from temp Directory
                        File.Delete(fnm);
                        i++;
                    }
                }
                else
                {
                    int count = Directory.GetFiles(@"..\..\HomePage\SliderImages\").Length;
                    if (count > 0)
                    {
                        System.GC.Collect();
                        System.GC.WaitForPendingFinalizers();
                        foreach (string fnm in Directory.GetFiles(@"..\..\HomePage\SliderImages\"))
                        {
                            File.Delete(fnm);
                        }
                    }
                }
                Properties.Settings.Default.Save();
                AlertBox.ShowDialog("Successfully Updated", AlertBox.AlertType.success, true);
            }
            catch (Exception ex)
            {
                AlertBox.ShowDialog("Error : " + ex.Message, AlertBox.AlertType.error, false);
            }
        }

        private void upload_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Upload Icon",
                Filter = "Image Files(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp",
                Multiselect = false
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                isStoreImage = true;
                FileName = ofd.FileName;
                fileExtension = Path.GetExtension(FileName);
                clg_icon_pictureBox.Image = Image.FromFile(FileName);
            }
        }

        private void HomePageDesign_Load(object sender, EventArgs e)
        {
            clgnm_textBox.Text = Properties.Settings.Default.CollegeName;
            string icon = Properties.Settings.Default.CollegeIcon;

            if (!string.IsNullOrEmpty(icon))
            {
                clg_icon_pictureBox.Image = Image.FromFile(icon);
            }

            string imgspath = @"..\..\HomePage\SliderImages";
            int hasSliderImages = Directory.GetFiles(imgspath).Length;
            if (hasSliderImages > 0)
            {
                Slider_img_Fullpath.Clear();
                img_name.Clear();
                int i = 0;
                foreach (string str in Directory.GetFiles(imgspath))
                {
                    Slider_img_Fullpath.Add(str);
                    img_name.Add(Path.GetFileName(str));
                    slider_images_listBox.Items.Add(img_name[i]);
                    i++;
                }
                slider_images_listBox.Enabled = true;
                remove_button.Enabled = true;
                removeAll_button.Enabled = true;
            }

            clg_tag_linetextBox.Text = Properties.Settings.Default.CollegeTagLine;

        }


        private void slider_upload_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Upload Icon",
                Filter = "Image Files(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp",
                Multiselect = true
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!slider_images_listBox.Items.Contains(Path.GetFileName(ofd.FileName).ToString()))
                {
                    slider_images_listBox.Enabled = true;
                    remove_button.Enabled = true;
                    removeAll_button.Enabled = true;
                    int i = slider_images_listBox.Items.Count;
                    foreach (string str in ofd.FileNames)
                    {
                        Slider_img_Fullpath.Add(str);
                        img_name.Add(Path.GetFileName(str));
                        slider_images_listBox.Items.Add(img_name[i]);
                        i++;
                    }
                }
                else
                {
                    AlertBox.ShowDialog("This Image is already exists", AlertBox.AlertType.warning, false);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (slider_images_listBox.Items.Count <= 0)
            {
                removeAll_button.Enabled = remove_button.Enabled = false;
            }
            if (slider_images_listBox.Text == string.Empty)
            {
                slider_pictureBox.Image = null;
            }
            else
                slider_pictureBox.Image = Image.FromFile(Slider_img_Fullpath[slider_images_listBox.SelectedIndex]);
        }

        private void removeAll_button_Click(object sender, EventArgs e)
        {
            foreach (string str in slider_images_listBox.Items)
            {
                removed_img.Add(str);
            }
            slider_images_listBox.Items.Clear();
            removeAll_button.Enabled = false;
            remove_button.Enabled = false;
            slider_pictureBox.Image = null;
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            if (slider_images_listBox.SelectedIndex != -1)
            {
                Slider_img_Fullpath.RemoveAt(slider_images_listBox.SelectedIndex);
                img_name.RemoveAt(slider_images_listBox.SelectedIndex);
                slider_images_listBox.Items.RemoveAt(slider_images_listBox.SelectedIndex);
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
                this.Dispose();
        }

    }
}
