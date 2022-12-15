using System.Linq;
using System;
using AutoMapper;
using MovieStoreWebApi.Entities;
using MovieStoreWebApi.DbOperations;
using System.Collections.Generic;

namespace MovieStoreWebApi.Applications.MovieOperations.Commands
{
  public class CreateMovieCommand
  {
    public CreateMovieModel Model { get; set; }
    private readonly IMovieStoreDbContext _context;
    private readonly IMapper _mapper;
    public CreateMovieCommand(IMovieStoreDbContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }

    public void Handle()
    {
      var movie = _context.Movies.SingleOrDefault(x => x.Name == Model.Name);

      if(movie is not null)
        throw new InvalidOperationException("Film zaten var");

      movie = _mapper.Map<Movie>(Model);
      _context.Movies.Add(movie);
      _context.SaveChanges();
    }

    public class CreateMovieModel
    {
      public string Name { get; set; }
      public int Price { get; set; }   
      public  DateTime PublishDate { get; set; }
      public int GenreId { get; set; }
      public int DirectorId { get; set; }
      public List<Actor> Actors { get; set; }
    }
  }
}