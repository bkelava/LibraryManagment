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

        private static readonly UserHelper instance = new UserHelper();

        private UserHelper()
        {
            //empty
        }

        public static UserHelper getInstance
        {
            get
            {
                return instance;
            }
        }
        public int userID;
        public int bookID;
        public int studentID;

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
