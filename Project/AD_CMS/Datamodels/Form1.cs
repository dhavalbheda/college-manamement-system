using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Datamodels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\PROJECT20018\\AD_CMS\\AD_CMS\\MasterDatabase.mdf;Integrated Security=True;User Instance=True"))
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand("select CastNm from Cast where CastId=1",con))
                {
                    textBox1.Text = cmd.ExecuteScalar().ToString();
                }
            }
        }
    }
}
