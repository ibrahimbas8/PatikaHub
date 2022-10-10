using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1CSharp
{
    public class Person
    {
        public Person(string name, string surname, string number)
        {
            this.Name = name;
            this.Surname = surname;
            this.Number = number;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
    }
}
