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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //empty
        }

        private void tbUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbUserName.Text == Values.getInstance().getUsernameText())  
            {
                tbUserName.Clear();
            }
        }

        private void pbInstagram_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(Values.getInstance().getInstagramUrl());
        }

        private void pbFacebook_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(Values.getInstance().getFacebookUrl());
        }

        private void pbYoutube_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(Values.getInstance().getYoutubeUrl());
        }

        private void btnX_MouseClick(object sender, MouseEventArgs e)
        {
            ProgramManager.getInstance().Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ProgramManager.getInstance().SwitchScreen(this, new SignUp());
            
        }

        private void login()
        {
            mDataSet = new DataSet();

            string userName = tbUserName.Text;
            string password = tbPassword.Text;
            mDataSet = DbHandler.getInstance().Select("SELECT * FROM loginTable WHERE username = '" + userName + "' AND password = '" + password + "'");

            if (mDataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Wrong username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserHelper.getInstance().userID = int.Parse(mDataSet.Tables[0].Rows[0][0].ToString());
                ProgramManager.getInstance().SwitchScreen(this, new Dashboard());
            }
        }
    }
}
