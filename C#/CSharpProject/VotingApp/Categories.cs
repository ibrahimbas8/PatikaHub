using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{
    class Categories
    {
        private FilmCategories filmCategory;
        private int voteRate = 0;
        public FilmCategories FilmKategorisi { get => filmCategory; set => filmCategory = value; }
        public int currentVoteRate { get => voteRate; set => voteRate = value; }

        public Categories(FilmCategories filmCategory, int voteRate)
        {
            this.filmCategory = filmCategory;
            this.currentVoteRate += voteRate;
        }

        public Categories() { }
    }
    public enum FilmCategories
    {
        Korku, Dram, Komedi, Fantastik
    }
}
