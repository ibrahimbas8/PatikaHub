using System.Linq;
using WepApi.DBOperations;
using System;
using WepApi.Entities;

namespace  WepApi.Application.GenreOperations.DeleteGenre
{
    public class DeleteGenreCommand
    {
        public int GenreId {get; set;}
        private readonly IBookStoreDbContext _context;
        public DeleteGenreCommand(IBookStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var genre = _context.Genres.SingleOrDefault(x => x.Id == GenreId);
            if(genre is null)
                throw new InvalidOperationException("Kitap Türü bulunamadı");
            _context.Genres.Remove(genre);
            _context.SaveChanges();
        }
    }
}