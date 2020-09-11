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
using AD_CMS_Entity;


namespace AD_CMS.FinanceDeptSubForms
{
    public partial class StudentFeeCollection : TemplateForm
    {
        DataTable dt_course, dt_dataGridView;
        FinanceEntity fe = new FinanceEntity();

        public StudentFeeCollection()
        {
            InitializeComponent();
            Load_Course_Course();
        }

        private void Load_Course_Course()
        {
            dt_course = FinanceDepartment_Methods.Load_CourseDetails();
            course_comboBox.DataSource = dt_course;
            course_comboBox.ValueMember = "Id";
            course_comboBox.DisplayMember = "Alias";
        }

        private void collect_button_Click(object sender, EventArgs e)
        {
            if (valid_collect())
            {
                loadFinanceEntity();
                if (FinanceDepartment_Methods.insertFees(fe) > 0)
                {
                    AlertBox.ShowDialog("Fees collected successfully", AlertBox.AlertType.success, true);
                    dt_dataGridView = FinanceDepartment_Methods.Load_DataGridView(course_comboBox.Text, int.Parse(select_sem_numericUpDown.Value.ToString()));
                    all_student_nm_dataGridView.DataSource = dt_dataGridView;
                }
            }
        }

        private void loadFinanceEntity()
        {
            fe.Grno = int.Parse(all_student_nm_dataGridView.Rows[er.RowIndex].Cells["Grno"].Value.ToString());
            fe.courseName = all_student_nm_dataGridView.Rows[er.RowIndex].Cells["Course Name"].Value.ToString();
            fe.paymentDate = payment_date_dateTimePicker.Value;
            fe.paymentYear = int.Parse(paymentyear_comboBox.Text.Substring(5));
            fe.paidFee = int.Parse(collected_fee_textBox.Text);
            int totalpaid = int.Parse(all_student_nm_dataGridView.Rows[er.RowIndex].Cells["Total Paid"].Value.ToString());
            fe.totalPaid = int.Parse(collected_fee_textBox.Text) + totalpaid;
            int p_due = int.Parse(all_student_nm_dataGridView.Rows[er.RowIndex].Cells["Due"].Value.ToString());
            fe.due = p_due - (int.Parse(collected_fee_textBox.Text));
            fe.discountPercent = int.Parse(all_student_nm_dataGridView.Rows[er.RowIndex].Cells["Discount"].Value.ToString());
            fe.payableFees = int.Parse(all_student_nm_dataGridView.Rows[er.RowIndex].Cells["Payable Fees"].Value.ToString());
            fe.TotalFees = int.Parse(all_student_nm_dataGridView.Rows[er.RowIndex].Cells["Total Fees"].Value.ToString());

        }

        private bool valid_collect()
        {
            bool flag = true;
            if (collected_fee_textBox.Text == "")
            {
                collected_fee_textBox.BackColor = Color.Pink;
                flag = false;
            }
            if (DateTime.Now < payment_date_dateTimePicker.Value)
            {
                if (flag)
                {
                    AlertBox.ShowDialog("Please Enter Valid Date.", AlertBox.AlertType.error, false);
                }
                payment_date_dateTimePicker.BackColor = Color.Pink;
                flag = false;
            }
            if (!flag)
            {
                AlertBox.ShowDialog("Please enter valid_collect data in required field", AlertBox.AlertType.error, false);
            }
            return flag;
        }

        private void clear_fee_button_Click(object sender, EventArgs e)
        {
            fee_collection_panel.Enabled = false;
            filter_groupBox.Enabled = true;
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            if (valid_filter())
            {
                dt_dataGridView = FinanceDepartment_Methods.Load_DataGridView(course_comboBox.Text, int.Parse(select_sem_numericUpDown.Value.ToString()));
                all_student_nm_dataGridView.DataSource = dt_dataGridView;
            }

        }

        private bool valid_filter()
        {
            bool flag = true;
            if (course_comboBox.Text == "" || paymentyear_comboBox.SelectedIndex == 0)
            {
                course_comboBox.BackColor = Color.Pink;
                flag = false;
            }
            if (!flag)
            {
                AlertBox.ShowDialog("Please Select Valid Course Or Semester.", AlertBox.AlertType.error, false);
            }
            return flag;
        }

        private void clear_filter_button_Click(object sender, EventArgs e)
        {
            course_comboBox.SelectedIndex = 0;
            course_comboBox.BackColor = Color.White;
            fee_collection_panel.Enabled = false;
        }

        private void Controls_TextChanged(object sender, EventArgs e)
        {
            ClassCall.textChangeFun(sender as Control);
        }

        private void course_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_sem_numericUpDown.Minimum = 1;
            for (int i = 0; i < dt_course.Rows.Count; i++)
            {
                if (dt_course.Rows[i][0].ToString() == course_comboBox.SelectedValue.ToString())
                {
                    select_sem_numericUpDown.Maximum = decimal.Parse(dt_course.Rows[i]["TotalSem"].ToString());
                    break;
                }
            }

        }
        DataGridViewCellEventArgs er;
        private void all_student_nm_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fee_collection_panel.Enabled = false;
            filter_groupBox.Enabled = false;
            er = e;
            if(all_student_nm_dataGridView.Rows.Count > 0)
                Load_fee_collection_panel(e);
            
        }

        private void Load_fee_collection_panel(DataGridViewCellEventArgs e)
        {

            fee_collection_panel.Enabled = true;
            int Grno = int.Parse(all_student_nm_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            DataTable dt_cellClick = FinanceDepartment_Methods.FeeCollection_CellClick(Grno);
            grno_textBox.Text = dt_cellClick.Rows[0]["Grno"].ToString();
            studentnm_textBox.Text = dt_cellClick.Rows[0][1].ToString();
            int admission_Year = ((DateTime)dt_cellClick.Rows[0][2]).Year;
            int leaving_Year = int.Parse(dt_cellClick.Rows[0][3].ToString());

            for (int i = admission_Year; i < leaving_Year; i++)
            {
                paymentyear_comboBox.Items.Add(i + "-" + (i + 1));
            }

            paymentyear_comboBox.SelectedIndex = 0;
        }

        private void studentnm_filter_textBox_TextChanged(object sender, EventArgs e)
        {
            if (all_student_nm_dataGridView.Rows.Count > 0)
            {
                DataView dt_fillter = dt_dataGridView.DefaultView;
                dt_fillter.RowFilter = "[Student Name] like '%" + studentnm_filter_textBox.Text + "%'";
                all_student_nm_dataGridView.DataSource = dt_fillter;
            }
        }

       
    }
}
