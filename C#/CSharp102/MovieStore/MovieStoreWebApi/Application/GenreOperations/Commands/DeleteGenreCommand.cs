using MovieStoreWebApi.DbOperations;
using System;
using System.Linq;

namespace MovieStoreWebApi.Application.GenreOperations.Commands
{
    public class DeleteGenreCommand
    {
        public readonly IMovieStoreDbContext _context;
        public int Id { get; set; }
        public DeleteGenreCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var genre =  _context.Genres.SingleOrDefault(x => x.Id == Id);
            if(genre is null)
                throw new InvalidOperationException("Silinecek tür bulunamadı");

             _context.Genres.Remove(genre);
             _context.SaveChanges();
        }
    }
}
