using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomMessageBox;
using AD_CMS_DatabaseModel;

namespace AD_CMS.FinanceDeptSubForms
{
    public partial class ViewStudentPaymentDetails : TemplateForm
    {
        public ViewStudentPaymentDetails()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void find_button_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                DataTable dt = FinanceDepartment_Methods.Load_DataGridView(selectcourse_comboBox.Text, int.Parse(selectsem_numericUpDown.Value.ToString()));

                DataView filter = dt.DefaultView;
                if (all_radioButton.Checked)
                {
                    stud_payment_dataGridView.DataSource = dt;
                }
                else if (due_radioButton.Checked)
                {
                    int duefee = 0;
                    if (due_textbox.Text != "")
                    {
                        duefee = int.Parse(due_textbox.Text);
                    }
                    filter.RowFilter = "Due >" + duefee;
                    stud_payment_dataGridView.DataSource = filter;
                }
                else if (paid_radioButton.Checked)
                {
                    filter.RowFilter = "[Total Paid] =[Payable Fees]";
                    stud_payment_dataGridView.DataSource = filter;
                }

            }
        }

        private bool valid()
        {
            bool flag = true;
            if (selectcourse_comboBox.Text.Contains("select"))
            {
                selectcourse_comboBox.BackColor = Color.Pink;
                flag = false;
            }
            if (!flag)
            {
                AlertBox.ShowDialog("Please enter valid_collect data in required field", AlertBox.AlertType.error, false);
            }
            return flag;
        }

        private void ViewStudentPaymentDetails_Load(object sender, EventArgs e)
        {
            loadCourse();
            selectcourse_comboBox_SelectedIndexChanged(sender, e);
        }

        DataTable dt_course;

        private void loadCourse()
        {
            dt_course = FinanceDepartment_Methods.Load_CourseDetails();
            if (dt_course.Rows.Count > 0)
            {
                selectcourse_comboBox.DisplayMember = "Alias";
                selectcourse_comboBox.ValueMember = "TotalSem";
                selectcourse_comboBox.DataSource = dt_course;
            }
            else
            {
                selectcourse_comboBox.DataSource = null;
                selectcourse_comboBox.Items.Add("select");
                selectcourse_comboBox.SelectedIndex = 0;
            }
        }

        private void selectcourse_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt_course.Rows.Count > 0)
            {
                selectsem_numericUpDown.Value = selectsem_numericUpDown.Minimum;
                selectsem_numericUpDown.Maximum = decimal.Parse(selectcourse_comboBox.SelectedValue.ToString());
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (due_radioButton.Checked)
            {
                due_textbox.Enabled = true;
                due_textbox.Text = "";
            }
            else
            {
                due_textbox.Enabled = false;
                due_textbox.Text = "";
            }
        }
    }
}
