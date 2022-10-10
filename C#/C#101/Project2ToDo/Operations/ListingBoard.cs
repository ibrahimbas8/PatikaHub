using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2ToDo
{
    public class ListingBoard : IOperations
    {
        private static Board _Boards;

        public void LineBoard()
        {
            var toDo = Database.Cards.Where(x => x.BoardType == "TODO").ToList();
            var ınProgress = Database.Cards.Where(x => x.BoardType == "IN PROGRESS").ToList();
            var done = Database.Cards.Where(x => x.BoardType == "DONE").ToList();

            _Boards = new Board();
            _Boards.Todo = toDo;
            _Boards.Inprogress = ınProgress;
            _Boards.Done = done;
        }
        public void List()
        {
            LineBoard();
            ShowCard(" TODO Line", _Boards.Todo);
            ShowCard(" IN PROGRESS Line", _Boards.Inprogress);
            ShowCard(" DONE Line", _Boards.Done);

        }
        void ShowCard(string boardType, List<Card>? listName)
        {
            Console.WriteLine("\t");
            Console.WriteLine(boardType);
            Console.WriteLine("*******************************************");
            foreach (var item in listName)
            {
                Console.WriteLine("Başlık      :  {0}", item.Title);
                Console.WriteLine("İçerik      :  {0}", item.Content);
                Console.WriteLine("Atanan Kişi :  {0}", item.Person);
                Console.WriteLine("Büyüklük    :  {0}\n", item.Size);
            }
        }
    }
}
