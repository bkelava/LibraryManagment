using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    class ProgramManager
    {
        public void Exit()
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void SwitchScreen(Form oldForm, Form newForm)
        {
            oldForm.Hide();
            newForm.Show();
        }

        public void LogOut(Form oldForm, Form newForm)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.SwitchScreen(oldForm, newForm);
            }
        }

        public void OpenScreen(Form newForm)
        {
            newForm.ShowDialog();
        }

        public void Close(Form form)
        { 
            form.Close();
        }
    }
}
