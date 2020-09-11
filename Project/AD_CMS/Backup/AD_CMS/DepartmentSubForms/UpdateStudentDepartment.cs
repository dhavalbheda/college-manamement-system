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

namespace AD_CMS.DepartmentSubForms
{
    public partial class UpdateStudentDepartment : TemplateForm
    {
        public UpdateStudentDepartment()
        {
            InitializeComponent();
        }

        DataTable dtToOld, OldToNew, NewToOld;

        //validate finding details & finds data
        private void find_stud_button_Click(object sender, EventArgs e)
        {
            if (finding_details_validation())
            {
                dtToOld = Department_Methods.viewStudent(select_course_comboBox.Text, int.Parse(update_numericUpDown.Value.ToString()));
                if (dtToOld.Rows.Count > 0)
                {
                    search_dept_groupBox.Enabled = false;
                    if (update_sem_textBox.Text.Contains("-"))
                    {
                        new_sem_label.Text = "";
                        old_sem_label.Text = "";
                    }
                    else
                    {
                        new_sem_label.Text = "Sem - " + update_sem_textBox.Text;
                        old_sem_label.Text = "Sem - " + update_numericUpDown.Value;
                    }
                    OldToNew = dtToOld;
                    NewToOld = dtToOld.Clone();

                    old_stud_dataGridView.DataSource = OldToNew;
                    EnableForwardNavigation(true);
                    EnableReverseNavigation(false);
                    data_moving_option_panel.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No students r available");
                }
            }
        }

        private void EnableReverseNavigation(bool p)
        {
            one_rev_button.Enabled = p;
            all_rev_button.Enabled = p;
        }

        private void EnableForwardNavigation(bool p)
        {
            one_tr_button.Enabled = p;
            all_tr_button.Enabled = p;
        }

        private bool finding_details_validation()
        {
            bool flg = true;
            if (select_course_comboBox.Text.Equals("select",StringComparison.OrdinalIgnoreCase))
            {
                flg = false;
                select_course_comboBox.BackColor = Color.Pink;
            }
            if (!flg)
            {
                AlertBox.ShowDialog("Enter data in required field", AlertBox.AlertType.error, false);
            }
            return flg;
        }

        //clear the new_stud_datagridview
        private void clear_button_Click(object sender, EventArgs e)
        {
            search_dept_groupBox.Enabled = true;
            data_moving_option_panel.Enabled = false;
            one_rev_button.Enabled = false;
            all_rev_button.Enabled = false;
            one_tr_button.Enabled = true;
            all_tr_button.Enabled = true;
            old_stud_dataGridView.DataSource = null;
            new_stud_dataGridView.DataSource = null;
            old_sem_label.Text = "";
            new_sem_label.Text = "";
        }

        private void promote_button_Click(object sender, EventArgs e)
        {
            int successCounter = 0;
            foreach (DataGridViewRow row in new_stud_dataGridView.SelectedRows)
            {
                int grno = int.Parse(row.Cells["Grno"].Value.ToString());
                int affected = Department_Methods.PromoteStudent(grno, int.Parse(update_sem_textBox.Text));
                if (affected > 0)
                {
                    successCounter++;
                }
                DataRow[] temp = NewToOld.Select("Grno="+grno);
                NewToOld.Rows.Remove(temp[0]);
            }
            MessageBox.Show(successCounter + " student(s) r promoted");
        }

        private void Promote_stud_textChanged(object sender, EventArgs e)
        {
            ClassCall.textChangeFun(sender as Control);
        }

        private void UpdateStudentDepartment_Load(object sender, EventArgs e)
        {
            loadDepartment();
        }

        private void loadDepartment()
        {
            DataTable dt = Department_Methods.GetCourse();
            if (dt.Rows.Count > 0)
            {
                select_course_comboBox.DisplayMember = "C_Alias";
                select_course_comboBox.ValueMember = "C_TotalSem";
                select_course_comboBox.DataSource = dt;
                find_stud_button.Enabled = true;
            }
            else
            {
                select_course_comboBox.DataSource = null;
                select_course_comboBox.Items.Add("select");
                select_course_comboBox.SelectedIndex = 0;
                update_numericUpDown.Enabled = false;
                find_stud_button.Enabled = false;
            }

            if (!select_course_comboBox.Text.Equals("select", StringComparison.OrdinalIgnoreCase))
            {
                decimal totalsem = decimal.Parse(select_course_comboBox.SelectedValue.ToString());
                update_numericUpDown.Maximum = totalsem;
                update_sem_textBox.Text = (update_numericUpDown.Value + 1).ToString();
            }
        }

        private void update_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (update_numericUpDown.Value == update_numericUpDown.Maximum)
            {
                update_sem_textBox.Text = "-";
                data_moving_option_panel.Visible = false;
                new_stud_dataGridView.Visible = false;
                promote_button.Visible = false;
                old_stud_dataGridView.Size = new Size(1020, 367);
                find_stud_button.Text = "View Students";
            }
            else
            {
                update_sem_textBox.Text = (update_numericUpDown.Value + 1).ToString();
                data_moving_option_panel.Visible = true;
                new_stud_dataGridView.Visible = true;
                promote_button.Visible = true;
                old_stud_dataGridView.Size = new Size(401, 367);
                find_stud_button.Text = "Find Students";
            }
           
        }

        private void select_course_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!select_course_comboBox.Text.Equals("select", StringComparison.OrdinalIgnoreCase))
            {
                decimal totalsem = decimal.Parse(select_course_comboBox.SelectedValue.ToString());
                update_numericUpDown.Maximum = totalsem;
                update_numericUpDown.Value = update_numericUpDown.Minimum;
                if (update_numericUpDown.Value == update_numericUpDown.Maximum)
                {
                    update_sem_textBox.Text = "-";
                    data_moving_option_panel.Visible = false;
                    new_stud_dataGridView.Visible = false;
                    promote_button.Visible = false;
                    old_stud_dataGridView.Size = new Size(1020, 367);
                    find_stud_button.Text = "View Students";
                }
                else
                {
                    data_moving_option_panel.Visible = true;
                    new_stud_dataGridView.Visible = true;
                    promote_button.Visible = true;
                    old_stud_dataGridView.Size = new Size(401, 367);
                    find_stud_button.Text = "Find Students";
                }
            }
        }

        private void one_tr_button_Click(object sender, EventArgs e)
        {
            RowTransfering(old_stud_dataGridView, ref OldToNew,ref NewToOld, new_stud_dataGridView,old_stud_dataGridView.SelectedRows);

            if (new_stud_dataGridView.Rows.Count > 0)
            {
                EnableReverseNavigation(true);
                promote_button.Enabled = true;
            }
            if (old_stud_dataGridView.Rows.Count < 1)
                EnableForwardNavigation(false);
                
        }

        private void one_rev_button_Click(object sender, EventArgs e)
        {
            RowTransfering(new_stud_dataGridView,ref NewToOld,ref OldToNew, old_stud_dataGridView, new_stud_dataGridView.SelectedRows);

            if (old_stud_dataGridView.Rows.Count > 0)
                EnableForwardNavigation(true);
            if (new_stud_dataGridView.Rows.Count < 1)
            {
                EnableReverseNavigation(false);
                promote_button.Enabled = false;
            }
        }

        private void all_tr_button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in old_stud_dataGridView.Rows)
            {
                row.Selected = true;
            }
            RowTransfering(old_stud_dataGridView, ref OldToNew, ref NewToOld, new_stud_dataGridView, old_stud_dataGridView.SelectedRows);
            EnableReverseNavigation(true);
            EnableForwardNavigation(false);
            promote_button.Enabled = true;
        }

        private void all_rev_button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in new_stud_dataGridView.Rows)
            {
                row.Selected = true;
            }
            RowTransfering(new_stud_dataGridView, ref NewToOld, ref OldToNew, old_stud_dataGridView, new_stud_dataGridView.SelectedRows);
            EnableReverseNavigation(false);
            EnableForwardNavigation(true);
            promote_button.Enabled = false;
        }

        private void RowTransfering(DataGridView from, ref DataTable fromDT, ref DataTable toDT, DataGridView To, DataGridViewSelectedRowCollection fromSelectedRows)
        {
            foreach (DataGridViewRow dgvrow in fromSelectedRows)
            {
                DataRow row = toDT.NewRow();
                int idToDelete = 0;
                for (int j = 0; j < toDT.Columns.Count; j++)
                {
                    if (j == 0)
                        idToDelete = int.Parse(dgvrow.Cells[j].Value.ToString());
                    row[j] = dgvrow.Cells[j].Value;
                }
                toDT.Rows.Add(row);//Adding Row to OldToNew DataTable
                DataRow[] temp = fromDT.Select("Grno=" + idToDelete);
                fromDT.Rows.Remove(temp[0]);//Delete The transfered row from dtToOld DataTable
            }
            To.DataSource = toDT;
        }
    }
}
