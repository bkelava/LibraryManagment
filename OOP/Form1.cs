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
    public partial class Form1 : Form
    {

        private DataSet mDataSet = null;
        private DbHandler dbHandler = null;
        private ProgramManager programManager = new ProgramManager();

        private UserHelper userHelper = UserHelper.getInstance;

        private Values values = new Values();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbHandler = new DbHandler(values.getConnectionString());
        }

        private void tbUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbUserName.Text == values.getUsernameText())  
            {
                tbUserName.Clear();
            }
        }

        private void pbInstagram_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(values.getInstagramUrl());
        }

        private void pbFacebook_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(values.getFacebookUrl());
        }

        private void pbYoutube_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(values.getYoutubeUrl());
        }

        private void btnX_MouseClick(object sender, MouseEventArgs e)
        {
            programManager.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            programManager.SwitchScreen(this, new SignUp());
            
        }

        private void login()
        {
            mDataSet = new DataSet();
            mDataSet = dbHandler.Select("SELECT * FROM loginTable WHERE username = '" + tbUserName.Text + "' AND password = '" + tbPassword.Text + "'");

            userHelper.userID = int.Parse( mDataSet.Tables[0].Rows[0][0].ToString());

            if (mDataSet.Tables[0].Rows.Count != 0)
            {
                programManager.SwitchScreen(this, new Dashboard());
            }
            else
            {
                MessageBox.Show("Wrong username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
