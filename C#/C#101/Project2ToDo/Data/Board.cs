using System.Collections.Generic;

namespace Project2ToDo
{
    internal class Board
    {
        public List<Card>? Todo { get; set; }
        public List<Card>? Inprogress { get; set; }
        public List<Card>? Done { get; set; }
    }
}
