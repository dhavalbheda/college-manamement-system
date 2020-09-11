using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using CustomMessageBox;
using AD_CMS_DatabaseModel;
using AD_CMS_Entity;

namespace AD_CMS.Attendance
{
    public partial class UploadAttendance : TemplateForm
    {
        public UploadAttendance()
        {
            InitializeComponent();
        }

        DataTable dt_file , dt_dept;

        private void select_file_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Excel File|*.xls;*.xlsx;",
                Multiselect = false,
                Title = "Upload Attendance Sheet"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                file_path_textBox.Text = ofd.FileName;
                string filenm = ofd.FileName;
                bool hasSheet = false;
                
                dt_file = Attendance_Methods.ExcelToDGV(filenm,out hasSheet);
                
                attendance_dataGridView.DataSource = null;

                if (hasSheet)
                {
                    //If Sheets r available in Excel file the it will check for valid column names & data available
                    if (dt_file.Rows.Count > 0 && dt_file.Columns.Count > 0)
                    {
                        if (columnNameValidation())
                        {
                            attendance_dataGridView.DataSource = dt_file;
                            attendance_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                            attendance_dataGridView.Columns[0].Frozen = true;

                            //After successfull checking of column names, will check the valid data in Grid View if not will give error
                            if (!ValidatingDataGridView())
                                AlertBox.ShowDialog("AttendanceSheet is not in the specified format.", AlertBox.AlertType.error, false);
                        }
                        else
                        {
                            AlertBox.ShowDialog("We won't open :(,\r\n bcz AttendanceSheet has not the valid column name.", AlertBox.AlertType.error, false);
                        }
                    }
                    else
                    {
                        AlertBox.ShowDialog("AttendanceSheet doesn't have any data.", AlertBox.AlertType.warning, false);
                    }
                }
                else
                {
                    AlertBox.ShowDialog("Your Excel File doesn't have Sheet, Named with 'AttendanceSheet'",AlertBox.AlertType.error,false);
                }
            }
        }

        //Validation with Specified Column Names
        private bool columnNameValidation()
        {
            bool flg = true;
            int count = 1;
            for (int i = 0; i < dt_file.Columns.Count; i++)
            {
                if (i == 0)
                {
                    if(!dt_file.Columns[i].Caption.Equals("RollNo"))
                    {
                        flg = false;
                    }
                }
                else if (i == 1)
                {
                    if (!dt_file.Columns[i].Caption.Equals("Student Name"))
                        flg = false;
                }
                else
                {
                    if (!dt_file.Columns[i].Caption.Equals(count.ToString()))
                        flg = false;
                    count++;
                }
            }
            return flg;
        }

        //Validation of proper data in data grid view
        private bool ValidatingDataGridView()
        {
            bool flg = true;
            for (int i = 0; i < attendance_dataGridView.Columns.Count; i++)
            {
                attendance_dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                for (int j = 0; j < attendance_dataGridView.Rows.Count; j++)
                {
                    DataGridViewCell cell = attendance_dataGridView.Rows[j].Cells[i];

                    if (i == 0)
                    {
                        string str = cell.Value.ToString();
                        if (!string.IsNullOrEmpty(str))
                        {
                            for (int k = 0; k < str.Length; k++)
                            {
                                if (!char.IsDigit(str[k]))
                                {
                                    cell.ErrorText = "Must be a Non-Negative Integeral Number";
                                    flg = false;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            cell.ErrorText = "Roll No Required.";
                            flg = false;
                        }
                    }
                    else if (i == 1)
                    {
                        if (cell.ValueType != typeof(string) || string.IsNullOrEmpty(cell.Value.ToString()))
                        {
                            cell.ErrorText = "Not in valid Format";
                            flg = false;
                        }
                    }
                    else
                    {
                        if (!(cell.Value.ToString().Equals("p", StringComparison.OrdinalIgnoreCase) || cell.Value.ToString().Equals("a", StringComparison.OrdinalIgnoreCase) || string.IsNullOrEmpty(cell.Value.ToString())))
                        {
                            cell.ErrorText = "Not in valid Format.\r\n(Value must be either p/a)";
                            flg = false;
                        }
                    }
                }
            }
            if (!flg)
                upload_button.Enabled = false;
            else
                upload_button.Enabled = true;
            return flg;
        }

        //Page load
        private void UploadAttendance_Load(object sender, EventArgs e)
        {
            loadDepartment();

            this.select_dept_comboBox.SelectedIndexChanged += new System.EventHandler(this.select_dept_comboBox_SelectedIndexChanged);
            
            int month = DateTime.Now.Month;
            select_month_comboBox.SelectedIndex = month-1;

            loadBatchYear();
        }

        private void loadBatchYear()
        {
            int sem = int.Parse(select_sem_numericUpDown.Value.ToString());
            string reply = Attendance_Methods.getBatchYear(select_dept_comboBox.Text, sem).ToString();
            if (reply != "0")
            {
                batch_year_TextBox.Text = reply;
                select_file_button.Enabled = true;
            }
            else
            {
                batch_year_TextBox.Text = "No Student Presents";
                select_file_button.Enabled = false;
                upload_button.Enabled = false;
                attendance_dataGridView.DataSource = null;
                file_path_textBox.Clear();
            }
        }

        //load Courses
        private void loadDepartment()
        {
            dt_dept = Attendance_Methods.getDepartment();

            select_dept_comboBox.DisplayMember = "C_Alias";
            select_dept_comboBox.ValueMember = "C_TotalSem";
            select_dept_comboBox.DataSource = dt_dept;
        }

        private void select_dept_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt_dept.Rows.Count > 0)
            {
                file_path_textBox.Clear();
                select_file_button.Enabled = false;
                upload_button.Enabled = false;
                select_sem_numericUpDown.Maximum = decimal.Parse(select_dept_comboBox.SelectedValue.ToString());
                select_sem_numericUpDown.Value = select_sem_numericUpDown.Minimum;
                loadBatchYear();
            }
        }

        //Upload button click event
        private void upload_button_Click(object sender, EventArgs e)
        {
            Attendance_Entity ae = loadEntity();

            UploadFile(ae);//upload file to specific folder
        }

        //upload file to specific folder
        private void UploadFile(Attendance_Entity ae)
        {
            string saveFilePath = Properties.Settings.Default.AttendancePath + select_dept_comboBox.Text + @"\";
            string msg = "";
            bool isUpload = true;

            if (!Directory.Exists(Properties.Settings.Default.AttendancePath + select_dept_comboBox.Text))
            {
                Directory.CreateDirectory(Properties.Settings.Default.AttendancePath + select_dept_comboBox.Text);
            }
            if (!File.Exists(saveFilePath + ae.file + ".xls"))
            {
                ae.file = ae.file + ".xls";
                int affected = Attendance_Methods.UploadAttendance(ae);

                if (affected > 0)
                    msg = "Attendance Uploaded Successfully :)";
            }
            else
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();

                DialogResult result;
                result = MessageBox.Show("This Attendance file is already exists,\r\nDo u want to override the existing file?", "File Exists!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    File.Delete(saveFilePath + ae.file + ".xls");
                    msg = "File Overriden successfully :)";
                }
                else
                    isUpload = false;
            }

            if (isUpload)
            {
                saveDataInExcel(saveFilePath, ae);
            }
            if (msg != "")
                AlertBox.ShowDialog(msg, AlertBox.AlertType.success, true);

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        //Write Uploaded data to the Uploaded excel file
        private void saveDataInExcel(string saveFilePath,Attendance_Entity ae)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;

            worksheet.Name = "AttendanceSheet";
            app.DisplayAlerts = false;

            System.Data.DataTable dt = (DataTable)attendance_dataGridView.DataSource;

            for (int i = 0; i < dt.Columns.Count; i++)
            {

                worksheet.Cells[1, i + 1] = dt.Columns[i].Caption;
            }

            int count = 2;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    worksheet.Cells[count, j + 1] = dt.Rows[i][j].ToString();
                }
                count++;
            }

            string uploadPath = Path.GetFullPath(saveFilePath + ae.file);
            workbook.SaveAs(uploadPath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,
                            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                            Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            app.Quit();
        }

        //load entity for uploadAttendance (insert)
        private Attendance_Entity loadEntity()
        {
            Attendance_Entity ae = new Attendance_Entity();
            
            ae.courseAlias = select_dept_comboBox.Text;
            ae.sem = int.Parse(select_sem_numericUpDown.Value.ToString());
            ae.month = select_month_comboBox.Text;
            ae.batchYear = int.Parse(batch_year_TextBox.Text);
            
            string subMonth = select_month_comboBox.Text.Substring(0, 3);
            string fileName = ae.courseAlias + ae.batchYear + "_" + subMonth + select_sem_numericUpDown.Value.ToString();

            ae.file = fileName;
            
            return ae;
        }

        private void select_sem_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (dt_dept.Rows.Count > 0)
            {
                loadBatchYear();
            }
        }
    }    
}
