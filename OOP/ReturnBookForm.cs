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
    public partial class ReturnBookForm : Form
    {
        ProgramManager programManager = new ProgramManager();

        DbHandler dbHandler = null;

        Values values = new Values();

        UserHelper userHelper = UserHelper.getInstance;
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            programManager.Close(this);
        }

        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            dbHandler = new DbHandler(values.getConnectionString());
            Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string enrollment = tbEnrollment.Text;
            if (enrollment != "")
            {
                DataSet mDataSet = new DataSet();

                mDataSet = dbHandler.Select("SELECT * FROM student WHERE enrollment='" + enrollment + "'");

                if (mDataSet.Tables[0].Rows.Count > 0)
                {
                    int studentId = int.Parse(mDataSet.Tables[0].Rows[0][0].ToString());
                    dgvIssuedBooks.DataSource = dbHandler.populateDataGridView("SELECT borrowID, takenDate, bookName, studentName FROM BookBorrow, books, student WHERE BookBorrow.bookID = books.bookID AND BookBorrow.studentID=student.studentID AND student.studentID=" + studentId + " AND BookBorrow.studentID=" + studentId + "");
                }
                else
                {
                    MessageBox.Show("Enter a valid enrollment key!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Enter a valid enrollment key!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
            }
        }
        private void Clear()
        {
            dgvIssuedBooks.DataSource = null;
            tbBookData.Text = "";
            tbEnrollment.Text = "";
        }

        private void dgvIssuedBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIssuedBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            {
                string builder = "";
                DataSet mDataSet = new DataSet();
                userHelper.borrowBookID = int.Parse(dgvIssuedBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
                mDataSet = dbHandler.Select("SELECT * FROM BookBorrow WHERE borrowID=" + userHelper.borrowBookID + "");

                builder = builder + mDataSet.Tables[0].Rows[0][1].ToString() + " ";

                userHelper.studentID = int.Parse(mDataSet.Tables[0].Rows[0][5].ToString());
                userHelper.bookID = int.Parse(mDataSet.Tables[0].Rows[0][4].ToString());

                mDataSet = dbHandler.Select("SELECT * FROM books WHERE bookID=" + userHelper.bookID + "");

                builder = builder + " " + mDataSet.Tables[0].Rows[0][1].ToString();
                tbBookData.Text = builder;
            }
            else
            {
                MessageBox.Show("Wrong selection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to return the book?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbHandler.Delete("DELETE FROM BookBorrow WHERE borrowID=" + userHelper.borrowBookID + "");

                DataSet mDataSet = new DataSet();
                mDataSet = dbHandler.Select("SELECT bookQuantity FROM books WHERE bookID=" + userHelper.bookID + "");

                int quantity = int.Parse(mDataSet.Tables[0].Rows[0][0].ToString());
                quantity = quantity + 1;
                dbHandler.Update("UPDATE books SET bookQuantity=" + quantity + " WHERE bookID=" + userHelper.bookID + "");

                MessageBox.Show("You have returned your book!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please, make a valid \n\nbook selection inside table!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
