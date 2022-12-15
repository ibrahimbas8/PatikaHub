using System.Linq;
using WepApi.DBOperations;
using System;
using WepApi.Entities;

namespace  WepApi.Application.AuthorOperations.Commands.UpdateAuthor
{
    public class UpdateAuthorCommand
    {
        public int AuthorId { get; set; }
        public UpdateAuthorModel Model {get; set;}
        private readonly IBookStoreDbContext _context;

        public UpdateAuthorCommand(IBookStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.AuthorId == AuthorId);
            if(author is null)
                throw new InvalidOperationException("Yazar Bulunamadı");
                
            if(_context.Authors.Any(x => x.Name.ToLower() == Model.Name.ToLower() && x.AuthorId != AuthorId))
                throw new InvalidOperationException("Aynı isimli bir yazar zaten mevcut");

            author.Name = string.IsNullOrEmpty(Model.Name.Trim()) ? author.Name : Model.Name ;
            author.Surname = Model.Surname;
            author.BirdthDate = Model.BirdthDate;
            _context.SaveChanges();
        }
    }
    public class UpdateAuthorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirdthDate { get; set; }
    }
}