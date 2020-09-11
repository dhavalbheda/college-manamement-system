using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AD_CMS_DatabaseModel;
using AD_CMS_Entity;
using CustomMessageBox;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace AD_CMS.Attendance
{
    public partial class ViewAttendance : TemplateForm
    {
        public ViewAttendance()
        {
            InitializeComponent();
        }

        DataTable dt_dept,dt_file;
        bool isFiltering = false;
        string fnm,filenm;
        public bool isclose = false;

        private void ViewAttendance_Load(object sender, EventArgs e)
        {
            select_month_comboBox.SelectedIndex = 0;
            loadDepartment();

            if (dt_dept.Rows.Count > 0)
            {
                loadBatchYear();
            }
            else
            {
                select_batch_comboBox.Items.Add("select");
                select_batch_comboBox.SelectedIndex = 0;
            }

            if (!view_button.Enabled)
            {
                AlertBox.ShowDialog("U R not uploaded any attendance Sheet yet.", AlertBox.AlertType.information, false);
                isclose = true;
            }
        }

        private void loadBatchYear()
        {
            DataTable dt = Attendance_Methods.getBatchYears();
            if (dt.Rows.Count > 0)
            {
                select_batch_comboBox.DisplayMember = "BatchYear";
                select_batch_comboBox.DataSource = dt;
            }
            else
            {
                select_batch_comboBox.Items.Add("select");
                select_batch_comboBox.SelectedIndex = 0;
                view_button.Enabled = false;
            }
        }

        private void loadDepartment()
        {
            dt_dept = Attendance_Methods.getDepartment();

            if (dt_dept.Rows.Count > 0)
            {
                select_dept_comboBox.DisplayMember = "C_Alias";
                select_dept_comboBox.ValueMember = "C_TotalSem";
                select_dept_comboBox.DataSource = dt_dept;
            }
            else
            {
                select_dept_comboBox.Items.Add("select");
                select_dept_comboBox.SelectedIndex = 0;
                select_sem_numericUpDown.Enabled = false;
                select_batch_comboBox.Enabled = false;
                view_button.Enabled = false;
            }
        }

        private void select_dept_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt_dept.Rows.Count > 0)
            {
                attendance_dataGridView.DataSource = null;
                download_button.Enabled = false;
                select_sem_numericUpDown.Maximum = decimal.Parse(select_dept_comboBox.SelectedValue.ToString());
                select_sem_numericUpDown.Value = select_sem_numericUpDown.Minimum;

                filter_enable_button.Enabled = false;
                disableFilter();
            }
        }

        private void disableFilter()
        {
            filter_groupBox.Enabled = false;
            total_numericTextBox.Clear();
            p_numericTextBox.Clear();
            a_numericTextBox.Clear();
            stud_TextBox.Clear();
            name_radioButton.Checked = true;
        }

        private void Filter_CheckedChanged(object sender, EventArgs e)
        {
            if (name_radioButton.Checked)
            {
                this.attendance_dataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.attendance_dataGridView_RowEnter);
                this.select_date_numericUpDown.ValueChanged -= new System.EventHandler(this.select_date_numericUpDown_ValueChanged);
                select_date_numericUpDown.Visible = false;
            }
            else if (date_radioButton.Checked)
            {
                this.select_date_numericUpDown.ValueChanged += new System.EventHandler(this.select_date_numericUpDown_ValueChanged);
                this.attendance_dataGridView.RowEnter -= new System.Windows.Forms.DataGridViewCellEventHandler(this.attendance_dataGridView_RowEnter);
                select_date_numericUpDown.Visible = true;
                select_date_numericUpDown_ValueChanged(sender, e);
            }
        }

        private void view_button_Click(object sender, EventArgs e)
        {
            filenm = Attendance_Methods.getFileName(loadEntity());
            fnm = Properties.Settings.Default.AttendancePath + select_dept_comboBox.Text + @"\" + filenm;

            if (filenm != "null")
            {
                bool hassheet = false;
                dt_file = Attendance_Methods.ExcelToDGV(fnm, out hassheet);

                attendance_dataGridView.DataSource = null;

                if (hassheet)
                {
                    //If Sheets r available in Excel file the it will check for valid column names & data available
                    attendance_dataGridView.DataSource = dt_file;
                    attendance_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                    for (int i = 0; i < attendance_dataGridView.Columns.Count; i++)
                        attendance_dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    attendance_dataGridView.Columns[0].Frozen = true;

                    this.attendance_dataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.attendance_dataGridView_RowEnter);

                    total_numericTextBox.Text = attendance_dataGridView.Rows.Count.ToString();
                    download_button.Enabled = true;
                    filter_enable_button.Enabled = true;
                    counting();
                    dv = dt_file.DefaultView;
                }
            }
            else
            {
                AlertBox.ShowDialog("You didn't upload the attendance sheet for this month.", AlertBox.AlertType.information, false);
            }
        }

        private void counting()
        {
            int p=0,a=0;
            if (name_radioButton.Checked)
            {
                int selectedRow = attendance_dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                for (int i = 2; i <= 32; i++)
                {
                    string atten = attendance_dataGridView.Rows[selectedRow].Cells[i].Value.ToString();
                    if (atten.Equals("p", StringComparison.OrdinalIgnoreCase))
                        p++;
                    else if (atten.Equals("a", StringComparison.OrdinalIgnoreCase))
                        a++;
                }
            }
            else if (date_radioButton.Checked)
            {
                int dt = int.Parse(select_date_numericUpDown.Value.ToString());

                int idx = -1;
                foreach (DataGridViewColumn col in attendance_dataGridView.Columns)
                {
                    if (col.HeaderText == dt.ToString())
                    {
                        idx = col.Index;
                        break;
                    }
                }

                for (int i = 0; i < attendance_dataGridView.Rows.Count; i++)
                {
                    string atten = attendance_dataGridView.Rows[i].Cells[idx].Value.ToString();
                    if (atten.Equals("p", StringComparison.OrdinalIgnoreCase))
                        p++;
                    else if (atten.Equals("a", StringComparison.OrdinalIgnoreCase))
                        a++;
                }

            }
            p_numericTextBox.Text = p.ToString();
            a_numericTextBox.Text = a.ToString(); 
        }

        private Attendance_Entity loadEntity()
        {
            Attendance_Entity ae = new Attendance_Entity();
            ae.courseAlias = select_dept_comboBox.Text;
            ae.sem =  int.Parse(select_sem_numericUpDown.Value.ToString());
            ae.month = select_month_comboBox.Text;
            ae.batchYear = int.Parse(select_batch_comboBox.Text);
            return ae;
        }

        private void select_month_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            download_button.Enabled = false;
            filter_enable_button.Enabled = false;
            attendance_dataGridView.DataSource = null;
            disableFilter();
        }

        private void select_batch_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            download_button.Enabled = false;
            filter_enable_button.Enabled = false;
            attendance_dataGridView.DataSource = null;
            disableFilter();

        }

        private void select_date_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            counting();
        }

        private void attendance_dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(!isFiltering)
                counting();
        }

        private void select_sem_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            filter_enable_button.Enabled = false;
            disableFilter();
            download_button.Enabled = false;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            dt_file.DefaultView.RowFilter = null;
            stud_TextBox.Clear();
        }

        DataView dv;

        private void stud_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (dt_file.Rows.Count > 0)
            {
                dv = dt_file.DefaultView;
                if (stud_TextBox.Text == "")
                {
                    dv.RowFilter = null;
                }
                else
                {
                    isFiltering = true;
                    dv.RowFilter = "'Student Name' like '%" + stud_TextBox.Text + "%'";
                }
            }
        }

        private void filter_enable_button_Click(object sender, EventArgs e)
        {
            search_groupBox.Enabled = false;
            filter_groupBox.Enabled = true;
        }

        private void enable_attendance_button_Click(object sender, EventArgs e)
        {
            search_groupBox.Enabled = true;
            filter_groupBox.Enabled = false;
        }

        private void download_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog obj = new SaveFileDialog()
            {
                Filter = "Excel File|*.xls",
                Title = "Download"
            };
            if (obj.ShowDialog() == DialogResult.OK)
            {
                File.Copy(fnm, obj.FileName);

                AlertBox.ShowDialog("File downloaded successfully", AlertBox.AlertType.success, true);
            }
        }
    }
}
