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

        public btnIssueBook()
        {
            InitializeComponent();
        }

        private void IssueBooksForm_Load(object sender, EventArgs e)
        {
            this.BinData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet mDataSet = new DataSet();

            if (tbEnrollmentKey.Text != "")
            {
                mDataSet = DbHandler.getInstance().Select("SELECT * FROM student WHERE enrollment='" + tbEnrollmentKey.Text + "'");

                if (mDataSet.Tables[0].Rows.Count != 0)
                {
                    UserHelper.getInstance().studentID = int.Parse(mDataSet.Tables[0].Rows[0][0].ToString());

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
            ProgramManager.getInstance().Close(this);
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
            UserHelper.getInstance().bookID = int.Parse(selectedItem);

            mDataSet = dbHandler.Select("SELECT * FROM books WHERE bookID=" + UserHelper.getInstance().bookID);

            int bookQuantitiy = int.Parse(mDataSet.Tables[0].Rows[0][4].ToString());

            if (bookQuantitiy > 0)
            {
                dbHandler.Insert("INSERT INTO BookBorrow (takenDate, loginID, bookID, studentID) VALUES ('" + dtpBorrowDate.Value.ToShortDateString()+ "'," + UserHelper.getInstance().userID + "," + UserHelper.getInstance().bookID + "," + UserHelper.getInstance().studentID + ")");

                bookQuantitiy = bookQuantitiy - 1;

                dbHandler.Update("UPDATE books SET bookQuantity=" + bookQuantitiy + "WHERE bookID =" + UserHelper.getInstance().bookID);

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

            mDataSet = DbHandler.getInstance().Select("SELECT * FROM books");

            cbBooks.DataSource = mDataSet.Tables[0];

            cbBooks.ValueMember = "bookID";
            cbBooks.DisplayMember = "bookName";

            cbBooks.Enabled = true;
        }
    }
}
