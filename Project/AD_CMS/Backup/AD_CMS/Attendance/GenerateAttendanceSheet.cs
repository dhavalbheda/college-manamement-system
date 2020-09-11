using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AD_CMS_DatabaseModel;
using CustomMessageBox;
using System.Reflection;

namespace AD_CMS.Attendance
{
    public partial class GenerateAttendanceSheet : TemplateForm
    {
        public GenerateAttendanceSheet()
        {
            InitializeComponent();
        }

        DataTable dt_dept;

        private void GenerateAttendanceSheet_Load(object sender, EventArgs e)
        {
            loadDepartment();
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
                generat_sheet_button.Enabled = false;
            }
        }

        private void select_dept_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt_dept.Rows.Count > 0)
            {
                select_sem_numericUpDown.Maximum = decimal.Parse(select_dept_comboBox.SelectedValue.ToString());
                select_sem_numericUpDown.Value = select_sem_numericUpDown.Minimum;
            }
        }

        private void generat_sheet_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog obj = new SaveFileDialog()
            {
                Filter = "Excel File|*.xls",
                AddExtension = true,
                Title = "Save Attendace Sheet As ",
                
            };

            if (obj.ShowDialog() == DialogResult.OK)
            {
                int sem = int.Parse(select_sem_numericUpDown.Value.ToString());
                Attendance_Methods.GenerateSheet(select_dept_comboBox.Text, sem, obj.FileName);

                AlertBox.ShowDialog("Attendance Sheet generated Successfully.", AlertBox.AlertType.success, true);

            }
        }
    }
}
