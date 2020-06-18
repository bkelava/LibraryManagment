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
    public partial class AddBookForm : Form
    {
        private Values values = new Values();

        private ProgramManager programManager = new ProgramManager();
        private DbHandler dbHandler = null;
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            programManager.Close(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.btnSaveClick();
        }

        private void btnSaveClick()
        {
            string bookName = tbBookName.Text;
            string bookAuthor = tbBookAuthor.Text;
            string bookPublication = tbBookPublication.Text;
            string bookQuantity = tbBookQuantity.Text;

            if (bookName.Length > 0 && bookAuthor.Length > 0 && bookPublication.Length > 0 && bookQuantity.Length > 0)
            {
                string sqlQuery = "INSERT INTO books (bookName, bookAuthor, bookPublication, bookQuantity) VALUES ('" + bookName + "', '" + bookAuthor + "', '" + bookPublication + "', '" + bookQuantity + "')";
                dbHandler.Insert(sqlQuery);
                MessageBox.Show("Book Inserted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetFields();
            }
            else
            {
                MessageBox.Show("One or more required fields are empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void resetFields()
        {
            tbBookName.Text = "";
            tbBookAuthor.Text = "";
            tbBookPublication.Text = "";
            tbBookQuantity.Text = "";
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            dbHandler = new DbHandler(values.getConnectionString());
        }
    }
}
