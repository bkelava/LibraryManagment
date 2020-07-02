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
    public partial class SignUp : Form
    {

        private DbHandler dbHandler = null;

        public SignUp()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)


        {
            ProgramManager.getInstance().Exit();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            //empty
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.SignUpBtnClick();
        }

        private void SignUpBtnClick()
        {
            string username = tbUserName.Text;
            string password = tbPassword.Text;
            string passwordRepeat = tbPasswordRepeat.Text;

            string query = "SELECT * FROM loginTable WHERE username = '" + username + "'";

            if (tbUserName.Text.Length > 0 && tbPassword.Text.Length > 0)
            {
                if (dbHandler.RowExist(query) == false)
                {
                    if (password == passwordRepeat)
                    {
                        dbHandler.Insert("INSERT INTO loginTable (username, password) VALUES ('" + username + "', '" + password + "')");
                        MessageBox.Show("User successfully registered!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ProgramManager.getInstance().SwitchScreen(this, new Form1());
                    }
                    else
                    {
                        MessageBox.Show("Passwords aren't matching!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter username or password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            
            ProgramManager.getInstance().SwitchScreen(this, new Form1());
        }
    }
}
