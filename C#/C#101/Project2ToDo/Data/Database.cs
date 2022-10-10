using System.Collections.Generic;

namespace Project2ToDo
{
    internal class Database
    {
        private static List<Card> _Cards;
        private static List<Person> _PersonList;
        static Database()
        {
            _Cards = new List<Card>()
        {
            new Card{Title="Ödev", Content="Ödevin arayüzü geliştirilicek ",Person="İbo", Size="L",BoardType="TODO" },
            new Card{Title="Proje", Content="Proje taslağı tasarlanacak. ", Person="Ayşe", Size="M",BoardType="IN PROGRESS" },
            new Card{Title="Çalışma", Content="8-5 arası çalışma yapılacak ", Person="Kübra", Size="XL",BoardType="DONE" },
            new Card{Title="Ders", Content="Ders verilecek", Person="Can", Size="L",BoardType="TODO" },
        };

            _PersonList = new List<Person>()
        {
            new Person{Id=1,Name="İbo",Team="A"},
            new Person{Id=2,Name="Can",Team="B"},
            new Person{Id=3,Name="Kübra",Team="A"},
            new Person{Id=4,Name="Ayşe",Team="B"},
        };

        }
        public static List<Card> Cards => _Cards;
        public static List<Person> PersonList => _PersonList;
    }
}
