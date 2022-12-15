using WepApi.DBOperations;
using WepApi.Entities;

namespace TestSetup
{
    public static class Authors
    {
        public static void AddAuthors(this BookStoreDbContext context)
        {
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
        }
    }
}