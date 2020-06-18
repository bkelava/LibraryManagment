using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class ViewStudentsForm : Form
    {
        private Int64 id;

        private Values values = new Values();

        private DbHandler dbHandler = null;

        private ProgramManager programManager = new ProgramManager();
        public ViewStudentsForm()
        {
            InitializeComponent();
        }

        private void ViewStudentsForm_Load(object sender, EventArgs e)
        {
            dbHandler = new DbHandler(values.getConnectionString());
            panelUpdateStudents.Visible = false;
            makeView();
        }

        private void makeView()
        {
            tbSearchStudents.Text = "";
            dgvViewStudents.DataSource = dbHandler.populateDataGridView("SELECT * FROM student");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelUpdateStudents.Visible = false;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            programManager.Close(this);
        }

        private void dgvViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvViewStudents.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            {
                setComboBoxData();
                int id = int.Parse(dgvViewStudents.Rows[e.RowIndex].Cells[0].Value.ToString());

                panelUpdateStudents.Visible = true;

                DataSet mDataSet = new DataSet();

                mDataSet = dbHandler.Select("SELECT * FROM student WHERE studentID = " + id);

                tbStudentNameUpdate.Text = mDataSet.Tables[0].Rows[0][1].ToString();
                dtpBirthdateUpdate.Value = DateTime.Parse(mDataSet.Tables[0].Rows[0][2].ToString());

                if (mDataSet.Tables[0].Rows[0][3].ToString() == "Male")
                {
                    cbGenderUpdate.SelectedValue = "Male";
                }
                else
                {
                    cbGenderUpdate.SelectedValue = "Female";
                }

                tbStudentClassUpdate.Text = mDataSet.Tables[0].Rows[0][4].ToString();

                this.id = Int64.Parse(mDataSet.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                MessageBox.Show("Wrong selection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void setComboBoxData()
        {
            var list = new BindingList<KeyValuePair<string, string>>();

            list = values.getComboBoxItems();

            cbGenderUpdate.DataSource = list;
            cbGenderUpdate.ValueMember = "Value";
            cbGenderUpdate.DisplayMember = "Value";
            cbGenderUpdate.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbStudentNameUpdate.Text == "" || tbStudentClassUpdate.Text == "" || cbGenderUpdate.SelectedIndex == 0)
            {
                MessageBox.Show("Some of the fields are wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string studentNameUpdate = tbStudentNameUpdate.Text;
                    string studentBirthdateUpdate = dtpBirthdateUpdate.Value.ToShortDateString();
                    string studentGenderUpdate = cbGenderUpdate.SelectedValue.ToString();
                    string studentClassUpdate = tbStudentClassUpdate.Text;
                    dbHandler.Update("UPDATE student SET studentName='" + studentNameUpdate + "', birthdate='" + studentBirthdateUpdate + "',gender='" + studentGenderUpdate + "', class='" + studentClassUpdate + "' WHERE studentID =" + this.id + "");
                    MessageBox.Show("Student updated!\n\n Please refresh data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Student is not updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            makeView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbHandler.Delete("DELETE FROM student WHERE studentID=" + this.id + "");
                MessageBox.Show("Item deleted!\n\n Refresh table!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbSearchStudents_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchStudents.Text != "")
            {
                DataSet mDataSet = new DataSet();

                mDataSet = dbHandler.Select("SELECT * FROM student WHERE studentName LIKE '%" + tbSearchStudents.Text + "%'");

                dgvViewStudents.DataSource = mDataSet.Tables[0];
            }
            else
            {
                makeView();
            }
        }
    }
}
