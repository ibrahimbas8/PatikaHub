using System.Linq;
using WepApi.DBOperations;
using System;
using WepApi.Entities;

namespace  WepApi.Application.AuthorOperations.Commands.CreateAuthor
{
    public class CreateAuthorCommand
    {
        public CreateAuthorModel Model {get; set;}
        private readonly IBookStoreDbContext _context;
        public CreateAuthorCommand(IBookStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.Name == Model.Name);
            if(author is not null)
                throw new InvalidOperationException("Yazar zaten mevcut");
            
            author = new Author();
            author.Name = Model.Name;
            author.Surname = Model.Surname;
            author.BirdthDate = Model.BirdthDate;
            _context.Authors.Add(author);
            _context.SaveChanges();
        }
    }
    public class CreateAuthorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirdthDate { get; set; }
    }
}