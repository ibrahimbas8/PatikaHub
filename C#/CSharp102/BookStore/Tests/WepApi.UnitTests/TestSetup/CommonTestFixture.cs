using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WepApi.Common;
using WepApi.DBOperations;

namespace TestSetup
{
    public class CommonTestFixture
    {
        public CommonTestFixture()
        {
            var options = new DbContextOptionsBuilder<BookStoreDbContext>().UseInMemoryDatabase(databaseName:"BookStoreTestDB").Options;
            Context = new BookStoreDbContext(options);

            Context.Database.EnsureCreated();
            Context.AddBooks();
            Context.AddGenres();
            Context.AddAuthors();

            Mapper = new MapperConfiguration(cfg => {cfg.AddProfile<MappingProfile>(); }).CreateMapper();
        }

        public BookStoreDbContext Context{get; set;}
        public IMapper Mapper{get; set;}
    }
}