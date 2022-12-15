using System.Linq;
using WepApi.DBOperations;
using System;
using WepApi.Entities;

namespace  WepApi.Application.AuthorOperations.Commands.DeleteAuthor
{
    public class DeleteAuthorCommand
    {
        public int AuthorId {get; set;}
        private readonly IBookStoreDbContext _context;
        public DeleteAuthorCommand(IBookStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.AuthorId == AuthorId);
            var authorBook = _context.Books.Where(x=> x.AuthorId == AuthorId).Any(); 
            if (authorBook) 
                throw new InvalidProgramException("Yazara kayıtlı kitap bulunmaktadır.");
            if(author is null)
                throw new InvalidOperationException("Yazar bulunamadı");
            _context.Authors.Remove(author);
            _context.SaveChanges();
        }
    }
}