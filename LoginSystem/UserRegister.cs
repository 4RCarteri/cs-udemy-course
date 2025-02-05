using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem
{
    static internal class UserRegister
    {
        private static User[] users =
        {
            new User { Username = "admin", Password = "admin" },
            new User { Username = "user", Password = "user" },
            new User { Username = "guest", Password = "guest" }
        };

        public static User _loggedUser = null;

        public static User LoggedUser
        {
            get { return _loggedUser; }
            private set { _loggedUser = value; }
        }

        public static bool Login(string username, string password)
        {
            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    LoggedUser = user;
                    return true;
                }
            }
            return false;
        }
    }
}
