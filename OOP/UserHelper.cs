using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class UserHelper //singleton class to store current operator
    {

        private static UserHelper instance = null;
        private UserHelper()
        {
            //empty
        }

        public static UserHelper getInstance()
        {
            if (instance == null)
            {
                instance = new UserHelper();
            }
            return instance;
        }
        public int userID;
        public int bookID;
        public int studentID;
        public int borrowBookID;

        /*public int getUserID()
        {
            return this.userID;
        }

        public void setUserID(int id)
        {
            this.userID = id;
        }

        public int getBookID()
        {
            return this.bookID;
        }

        public void setBookID(int id)
        {
            this.bookID = id;
        }

        public int getStudentID()
        {
            return this.studentID;
        }

        public void setStudentID(int id)
        {
            this.studentID = id;
        }*/

    }
}
