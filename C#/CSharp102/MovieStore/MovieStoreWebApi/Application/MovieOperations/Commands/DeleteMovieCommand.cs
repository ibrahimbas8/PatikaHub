using System.Linq;
using System;
using MovieStoreWebApi.DbOperations;

namespace MovieStoreWebApi.Applications.MovieOperations.Commands
{
  public class DeleteMovieCommand
  {
    private readonly IMovieStoreDbContext _context;
    public int MovieId { get; set; }
    public DeleteMovieCommand(IMovieStoreDbContext context)
    {
      _context = context;
    }

    public void Handle()
    {
      var movie = _context.Movies.SingleOrDefault(x=> x.Id == MovieId);

      if(movie is null)
        throw new InvalidOperationException("Film bulunamadı");
      
      _context.Movies.Remove(movie);
      _context.SaveChanges();
    }
  }
}