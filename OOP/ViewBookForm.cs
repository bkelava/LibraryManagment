using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class ViewBookForm : Form
    {

        private Int64 id;

        public ViewBookForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelBookAlter.Visible = false;
        }

        private void ViewBookForm_Load(object sender, EventArgs e)
        {
            panelBookAlter.Visible = false;
            makeView();
        }

        private void dgvViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvViewBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            {
                int id = int.Parse(dgvViewBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
               
                panelBookAlter.Visible = true;

                DataSet mDataSet = new DataSet();

                mDataSet = DbHandler.getInstance().Select("SELECT * FROM books WHERE bookID = " + id);

                tbBookName.Text = mDataSet.Tables[0].Rows[0][1].ToString();
                tbBookAuthor.Text = mDataSet.Tables[0].Rows[0][2].ToString();
                tbBookPublication.Text = mDataSet.Tables[0].Rows[0][3].ToString();
                tbBookQuantity.Text = mDataSet.Tables[0].Rows[0][4].ToString();

                this.id = Int64.Parse(mDataSet.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                MessageBox.Show("Wrong selection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            makeView();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            ProgramManager.getInstance().Close(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                DbHandler.getInstance().Delete("DELETE FROM books WHERE bookID=" + this.id + "");
                MessageBox.Show("Item deleted!\n\n Refresh table!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }       
        }

        private void tbBookNameSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbBookNameSearch.Text != "")
            {
                DataSet mDataSet = new DataSet();

                mDataSet = DbHandler.getInstance().Select("SELECT * FROM books WHERE bookName LIKE '%" + tbBookNameSearch.Text + "%'");

                dgvViewBooks.DataSource = mDataSet.Tables[0];
            }
            else
            {
                makeView();
            }
        }

        private void makeView()
        {
            tbBookNameSearch.Text = "";
            dgvViewBooks.DataSource = DbHandler.getInstance().populateDataGridView("SELECT * FROM books");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbBookAuthor.Text == "" || tbBookName.Text == "" || tbBookPublication.Text == "" || tbBookQuantity.Text == "")
            {
                MessageBox.Show("Some of the fields are empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string bookNameUpdate = tbBookName.Text;
                    string bookAuthorUpdate = tbBookAuthor.Text;
                    string bookPublicationUpdate = tbBookPublication.Text;
                    int bookQuantityUpdate = int.Parse(tbBookQuantity.Text.ToString());
                    DbHandler.getInstance().Update("UPDATE books SET bookName='" + bookNameUpdate + "', bookAuthor='" + bookAuthorUpdate + "',bookPublication='" + bookPublicationUpdate + "', bookQuantity=" + bookQuantityUpdate + " WHERE bookID =" + this.id + "");
                    MessageBox.Show("Book updated!\n\n Please refresh data.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Books are not updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
