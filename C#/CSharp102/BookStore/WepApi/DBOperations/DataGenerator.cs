using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WepApi.Entities;

namespace WepApi.DBOperations
{
    public class DataGenerator{
        public static void Initialize(IServiceProvider serviceProvider){
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>())){
                if(context.Books.Any()){
                    return;
                }
                context.Authors.AddRange
                (
                    new Author
                    {
                        Name = "JRR",
                        Surname = "Tolkien",
                        BirdthDate = new System.DateTime(1902,06,12) 
                    },
                    new Author
                    {
                        Name = "Eric",
                        Surname = "Ries",
                        BirdthDate = new System.DateTime(1961,08,02) 
                    },
                    new Author
                    {
                        Name = "Frank",
                        Surname = "Herbert",
                        BirdthDate = new System.DateTime(1920,12,05) 
                    }
                );
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
                context.Books.AddRange(
                    new Book
                    {
                        //Id = 1,
                        Title = "Lean Startup",
                        GenreId = 1, 
                        PageCount = 200,
                        PublishDate = new System.DateTime(2001,06,12),
                        AuthorId = 2 
                    },
                    new Book{
                        //Id = 2,
                        Title = "LOTR",
                        GenreId = 2, 
                        PageCount = 250,
                        PublishDate = new System.DateTime(1970,05,23),
                        AuthorId = 1
                    },
                    new Book{
                        //Id = 3,
                        Title = "Dune",
                        GenreId = 2, 
                        PageCount = 540,
                        PublishDate = new System.DateTime(2002,12,21),
                        AuthorId = 3
                    }
                );
                context.SaveChanges();  
            }
        }
    }
}