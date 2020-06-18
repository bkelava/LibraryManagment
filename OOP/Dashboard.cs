using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OOP
{
    public partial class Dashboard : Form
    {
        public bool isOpened = false;

        ProgramManager programManager = new ProgramManager();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.programManager.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.programManager.LogOut(this, new Form1());
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.programManager.OpenScreen(new AddBookForm());
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.programManager.OpenScreen(new ViewBookForm());
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            programManager.OpenScreen(new StudentForm());
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            programManager.OpenScreen(new ViewStudentsForm());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            programManager.OpenScreen(new IssueBooksForm());
        }
    }
}
