using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class btnIssueBook : Form
    {

        private DbHandler dbHandler = null;

        private Values values = new Values();

        private ProgramManager programManager = new ProgramManager();

        private UserHelper userHelper = UserHelper.getInstance;

        public btnIssueBook()
        {
            InitializeComponent();
        }

        private void IssueBooksForm_Load(object sender, EventArgs e)
        {
            dbHandler = new DbHandler(values.getConnectionString());

            this.BinData();
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
        private void btnIssue_Click(object sender, EventArgs e)
        {
            DataSet mDataSet = new DataSet();

            string selectedItem = cbBooks.SelectedValue.ToString();
            userHelper.bookID = int.Parse(selectedItem);

            mDataSet = dbHandler.Select("SELECT * FROM books WHERE bookID=" + userHelper.bookID);

            int bookQuantitiy = int.Parse(mDataSet.Tables[0].Rows[0][4].ToString());

            if (bookQuantitiy > 0)
            {
                dbHandler.Insert("INSERT INTO BookBorrow (takenDate, loginID, bookID, studentID) VALUES ('" + dtpBorrowDate.Value.ToShortDateString()+ "'," + userHelper.userID + "," + userHelper.bookID + "," + userHelper.studentID + ")");

                bookQuantitiy = bookQuantitiy - 1;

                dbHandler.Update("UPDATE books SET bookQuantity=" + bookQuantitiy + "WHERE bookID =" + userHelper.bookID);

                MessageBox.Show("Book issued!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selected book is no more", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BinData()
        {
            DataSet mDataSet = new DataSet();

            mDataSet = dbHandler.Select("SELECT * FROM books");

            cbBooks.DataSource = mDataSet.Tables[0];

            cbBooks.ValueMember = "bookID";
            cbBooks.DisplayMember = "bookName";

            cbBooks.Enabled = true;
        }
    }
}
