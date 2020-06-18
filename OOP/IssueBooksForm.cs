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
    public partial class IssueBooksForm : Form
    {

        private DbHandler dbHandler = null;

        private Values values = new Values();

        private ProgramManager programManager = new ProgramManager();

        private UserHelper userHelper = UserHelper.getInstance;

        public IssueBooksForm()
        {
            InitializeComponent();
        }

        private void IssueBooksForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookManagmentDataSet1.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.bookManagmentDataSet1.books);
            dbHandler = new DbHandler(values.getConnectionString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet mDataSet = new DataSet();

            if (tbEnrollmentKey.Text != "")
            {
                mDataSet = dbHandler.Select("SELECT * FROM student WHERE enrollment='" + tbEnrollmentKey.Text + "'");

                if (mDataSet.Tables[0].Rows.Count != 0)
                {
                    userHelper.studentID = int.Parse(mDataSet.Tables[0].Rows[0][0].ToString());

                    tbStudentName.Text = mDataSet.Tables[0].Rows[0][1].ToString();
                    tbStudentClass.Text = mDataSet.Tables[0].Rows[0][4].ToString();
                    dtpBorrowDate.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Please enter valid enrollment key!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter valid enrollment key!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            programManager.Close(this);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            tbEnrollmentKey.Text = "";
            tbStudentClass.Text = "";
            tbStudentName.Text = "";
            dtpBorrowDate.Value = DateTime.Now;
        }
    }
}
