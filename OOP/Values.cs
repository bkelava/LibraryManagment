using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    sealed class Values
    {

        private static Values instance = null;

        private Values()
        {
            //empty private constructor
        }


        public static Values getInstance()
        {
            if (instance == null)
            {
                instance = new Values();
            }
            return instance;
        }

        private string username = "Username";

        private string password = "Password";

        private char passwordChar = '*';

        private string youtubeUrl = "https://www.youtube.com/";

        private string facebookUrl = "https://www.facebook.com/";

        private string instangramUrl = "https://www.instagram.com/";

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Kelava\\source\\repos\\OOP\\OOP\\BookManagment.mdf;Integrated Security=True";


        public string getUsernameText() 
        {
            return this.username;
        }

        public string getPasswordText()
        {
            return this.password;
        }

        public char getPasswordChar()
        {
            return this.passwordChar;
        }

        public string getYoutubeUrl()
        {
            return this.youtubeUrl;
        }

        public string getFacebookUrl()
        {
            return this.facebookUrl;
        }

        public string getInstagramUrl()
        {
            return this.instangramUrl;
        }

        public string getConnectionString()
        {
            return this.connectionString;
        }

        public BindingList<KeyValuePair<string, string>> getComboBoxItems()
        {
            BindingList<KeyValuePair<string, string>> list = new BindingList<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("0", "--Select Gender--"));
            list.Add(new KeyValuePair<string, string>("1", "Male"));
            list.Add(new KeyValuePair<string, string>("2", "Female"));

            return list;
        }

        public Int64 generateKey()
        {
            Random random = new Random();
            Int64 number = random.Next(10000, 99999);

            return number;
        }
    }
}
