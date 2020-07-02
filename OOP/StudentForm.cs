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
    public partial class StudentForm : Form
    {
        private string key = "";


        private DbHandler dbHandler = null;

        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            setComboBoxData();
        }

        private void setComboBoxData()
        {
            var list = new BindingList<KeyValuePair<string, string>>();

            list = Values.getInstance().getComboBoxItems();

            cbGender.DataSource = list;
            cbGender.ValueMember = "Value";
            cbGender.DisplayMember = "Value";
            cbGender.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ProgramManager.getInstance().Close(this);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        private void resetFields()
        {
            tbName.Text = "";
            dtpBirthdate.Value = DateTime.Now;
            cbGender.SelectedIndex = 0;
            tbStudentClass.Text = "";
            key = "";
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            btnSaveClick();
        }

        private void btnSaveClick()
        {
            if (MessageBox.Show("Are you sure you want to save student?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (tbName.Text != "" && cbGender.SelectedIndex != 0 && tbStudentClass.Text != "" && key != "")
                {
                    if (dbHandler.RowExist("SELECT * FROM student WHERE enrollment ='" + key + "'") == false)
                    {
                        dbHandler.Insert("INSERT INTO student (studentName, birthdate, gender, class, enrollment) VALUES ('" + tbName.Text + "','" + dtpBirthdate.Value.ToShortDateString() + "','" + cbGender.SelectedValue.ToString() + "','" + tbStudentClass.Text + "','" + key + "')");
                        MessageBox.Show("Student inserted!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        key = "";
                    }
                }
                else
                {
                    MessageBox.Show("Some fields are empty\n\n or wrong value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Student not saved!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            this.key = "stu-"+Values.getInstance().generateKey().ToString();
            tbEnrollmentKey.Text = key.ToString();
        }
    }
}
