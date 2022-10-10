using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{
    class RegisteredUsers
    {
        public static List<User> users;
        public RegisteredUsers()
        {
            User user = new User(1, "123456", "ibrahim", "baş", new DateTime(1998, 08, 18), 1000);
            User user2 = new User(2, "123456", "ali", "cengiz", new DateTime(1992, 3, 5), 5000);
            User user3 = new User(3, "123456", "Ayşe", "baş", new DateTime(1974, 06, 10), 20000);
            users = new List<User> { user, user2, user3 };
        }
    }
}
