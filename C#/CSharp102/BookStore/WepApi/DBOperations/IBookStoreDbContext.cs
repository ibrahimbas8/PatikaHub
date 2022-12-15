using Microsoft.EntityFrameworkCore;
using WepApi.Entities;

namespace WepApi.DBOperations
{
    public interface IBookStoreDbContext
    {
        DbSet<Book> Books{get; set;}
        DbSet<Genre> Genres {get; set;}
        DbSet<Author> Authors {get; set;}
        DbSet<User> Users {get; set;}
        public int SaveChanges();
    }
}