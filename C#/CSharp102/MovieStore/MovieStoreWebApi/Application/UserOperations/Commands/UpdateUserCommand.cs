using System;
using System.Collections.Generic;
using System.Linq;
using MovieStoreWebApi.DbOperations;
using MovieStoreWebApi.Entities;

namespace MovieStoreWebApi.Applications.UserOperations.Commands
{
  public class UpdateUserCommand
  {
    public UpdateUserModel Model { get; set; }
    public int UserId { get; set; }
    private readonly IMovieStoreDbContext _context;
    public UpdateUserCommand(IMovieStoreDbContext context)
    {
      _context = context;
    }

    public void Handle()
    {
      var user = _context.Users.SingleOrDefault(x => x.Id == UserId);
      if(user is null)
       throw new InvalidOperationException("Kullanıcı bulunamadı");

      if(_context.Users.Any(x => x.Name.ToLower() == Model.Name.ToLower() && x.LastName.ToLower() == Model.LastName.ToLower() && x.Id != UserId))
        throw new InvalidOperationException("Bu isimde bir kullanıcı zaten mevcut");
      
      List<Genre> genreList = returnGenres(Model.FavoriteGenreIDList);
      List<Movie> movieList = returnMovies(Model.PurchasedMoviesIDList);     

      user.Name = string.IsNullOrEmpty(Model.Name.Trim()) ? user.Name : Model.Name;
      user.LastName = string.IsNullOrEmpty(Model.LastName.Trim()) ? user.LastName : Model.LastName;
      user.Password = string.IsNullOrEmpty(Model.Password.Trim()) ? user.Password : Model.Password;
      user.Email = string.IsNullOrEmpty(Model.Email.Trim()) ? user.Email : Model.Email;
      user.Genres = genreList.Any() ? genreList :user.Genres;
      user.Movies = movieList.Any() ? movieList : user.Movies;

      _context.SaveChanges();
    }
    public List<Genre> returnGenres(List<int> genreListID)
    {
      List<Genre> returnGenres = new List<Genre>();
      foreach(int genreID in genreListID)
      {
        var genre = _context.Genres.SingleOrDefault(x=> x.Id == genreID);
        if(genre is null)
          throw new InvalidOperationException("Geçersiz tür adı");
        returnGenres.Add(genre);
      }
      return returnGenres;
    }
    public List<Movie> returnMovies(List<int> MovieListID)
    {
      List<Movie> returnMovies = new List<Movie>();
      foreach(int movieID in MovieListID)
      {
        var movie = _context.Movies.SingleOrDefault(x=> x.Id == movieID);
        if(movie is null)
          throw new InvalidOperationException("Geçersiz film adı");
        returnMovies.Add(movie);
      }
      return returnMovies;
    }
  }
  
  public class UpdateUserModel{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public List<int> FavoriteGenreIDList { get; set; }
    public List<int> PurchasedMoviesIDList { get; set; }
  }
}