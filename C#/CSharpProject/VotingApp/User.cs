using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{
    class User
    {
        private static int id = 0;
        private string pass;
        private string username;

        public User(string username,string pass)
        {
            this.Id = id;
            this.Pass = pass;
            this.Username = username;
            id += 1;
        }

        public int Id { get => id; set => id = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Username { get => username; set => username = value; }
    }
}
