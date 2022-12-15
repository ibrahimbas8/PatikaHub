using System;
using WepApi.DBOperations;
using WepApi.Entities;

namespace TestSetup
{
    public static class Genres
    {
        public static void AddGenres(this BookStoreDbContext context)
        {
            context.Genres.AddRange
                (
                    new Genre   
                    {
                        Name = "Personal Growth"
                    },
                    new Genre
                    {
                        Name = "Science Fiction "
                    },
                    new Genre
                    {
                        Name = "Romance"
                    }
                );
        }
    }
}