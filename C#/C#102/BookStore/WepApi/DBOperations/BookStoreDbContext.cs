using Microsoft.EntityFrameworkCore;
namespace WepApi.DBOperations
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options):base(options){

        }
    }
}