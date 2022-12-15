using System;
using WepApi.DBOperations;
using WepApi.Entities;

namespace TestSetup
{
    public static class Books
    {
        public static void AddBooks(this BookStoreDbContext context)
        {
            context.Books.AddRange(
                new Book
                {
                    Title = "Lean Startup",
                    GenreId = 1, 
                    PageCount = 200,
                    PublishDate = new DateTime(2001,06,12),
                    AuthorId = 2 
                },
                new Book{
                    Title = "LOTR",
                    GenreId = 2, 
                    PageCount = 250,
                    PublishDate = new DateTime(1970,05,23),
                    AuthorId = 1
                },
                new Book{
                    Title = "Dune",
                    GenreId = 2, 
                    PageCount = 540,
                    PublishDate = new DateTime(2002,12,21),
                    AuthorId = 3
                }
                );
        }
    }
}