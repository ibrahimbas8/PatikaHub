using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{
    class User
    {
        public int customerNo { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime birthDate { get; set; }
        public double balance { get; set; }

        public User(int customerNo, string password, string name, string surname, DateTime birthDate, double balance)
        {
            this.customerNo = customerNo;
            this.password = password;
            this.name = name;
            this.surname = surname;
            this.birthDate = birthDate;
            this.balance = balance;
        }
        public void print()
        {
            Console.WriteLine("{0} {1} kullanıcımız", name, surname);
        }
    }
}
