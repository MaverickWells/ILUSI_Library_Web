using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ILUSI_7320
{
    public class User
    {
        private string username, password;
        private int role;

        public User() { }

        public User(string username, string password, int role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public string Username
        {
            set { username = value; }
            get { return username; }
        }

        public string Password
        {
            set { password = value; }
            get { return password; }
        }

        public int Role
        {
            set { role = value; }
            get { return role; }
        }
    }
}
