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
            if (tbBookName.Text != "" && tbBookAuthor.Text != "" && tbBookPublication.Text != "" && tbBookQuantity.Text != "")
            {
                string sqlQuery = "INSERT INTO books (bookName, bookAuthor, bookPublication, bookQuantity) VALUES ('" + tbBookName.Text + "', '" + tbBookAuthor.Text + "', '" + tbBookPublication.Text + "', " + int.Parse(tbBookQuantity.Text) + ")";
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
