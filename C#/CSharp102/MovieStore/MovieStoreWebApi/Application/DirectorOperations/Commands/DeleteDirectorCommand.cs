using MovieStoreWebApi.DbOperations;
using System;
using System.Linq;

namespace MovieStoreWebApi.Application.DirectorOperations.Commands
{
    public class DeleteDirectorCommand
    {
        public readonly IMovieStoreDbContext _context;
        public int Id { get; set; }
        public DeleteDirectorCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var director =  _context.Directors.SingleOrDefault(x => x.Id == Id);
            if(director is null)
                throw new InvalidOperationException("Silinecek yönetmen bulunamadı");

             _context.Directors.Remove(director);
             _context.SaveChanges();
        }
    }
}
