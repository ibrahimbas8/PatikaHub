
using System.Collections.Generic;
using AutoMapper;
using MovieStoreWebApi.Applications.UserOperations.Commands;
using MovieStoreWebApi.Applications.UserOperations.Queries;
using MovieStoreWebApi.Entities;
using static MovieStoreWebApi.Application.ActorOperations.Commands.CreateActorCommand;
using static MovieStoreWebApi.Application.ActorOperations.Queries.GetActorDetailQuery;
using static MovieStoreWebApi.Application.ActorOperations.Queries.GetActorsQuery;
using static MovieStoreWebApi.Application.DirectorOperations.Commands.CreateDirectorCommand;
using static MovieStoreWebApi.Application.DirectorOperations.Queries.GetDirectorDetailQuery;
using static MovieStoreWebApi.Application.DirectorOperations.Queries.GetDirectorsQuery;
using static MovieStoreWebApi.Application.GenreOperations.Commands.CreateGenreCommand;
using static MovieStoreWebApi.Application.GenreOperations.Queries.GetGenreDetailQuery;
using static MovieStoreWebApi.Application.GenreOperations.Queries.GetGenresQuery;
using static MovieStoreWebApi.Applications.MovieOperations.Commands.CreateMovieCommand;
using static MovieStoreWebApi.Applications.MovieOperations.Queries.GetMovieDetailQuery;
using static MovieStoreWebApi.Applications.MovieOperations.Queries.GetMoviesQuery;
using static MovieStoreWebApi.Applications.OrderOperations.Commands.CreateOrderCommand;
using static MovieStoreWebApi.Applications.OrderOperations.Queries.GetOrderDetailQuery;
using static MovieStoreWebApi.Applications.OrderOperations.Queries.GetOrdersQuery;

namespace MovieStoreWebApi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Actor, ActorViewModel>();
            CreateMap<Actor, ActorDetailViewModel>();
            CreateMap<CreateActorModel, Actor>();

            CreateMap<Director, DirectorViewModel>();
            CreateMap<Director, DirectorDetailViewModel>();
            CreateMap<CreateDirectorModel, Director>();

            CreateMap<Genre, GenresViewModel>();
            CreateMap<Genre, GenreDetailViewModel>();
            CreateMap<CreateGenreModel, Genre>();

            CreateMap<CreateMovieModel, Movie>();      
            CreateMap<Movie, MovieDetailViewModel>()
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name))
                .ForMember(dest => dest.Director, opt => opt.MapFrom(src => src.Director.Name + " " + src.Director.LastName))
                .ForMember(dest => dest.Actors, opt => opt.MapFrom(src => returnActors(src.Actors)));
            CreateMap<Movie, MoviesViewModel>()
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name))
                .ForMember(dest => dest.Director, opt => opt.MapFrom(src => src.Director.Name + " " + src.Director.LastName))
                .ForMember(dest => dest.Actors, opt => opt.MapFrom(src => returnActors(src.Actors)));

            CreateMap<CreateOrderModel, Order>();      
            CreateMap<Order, OrderDetailViewModel>()
            .ForMember(dest => dest.BuyerName, opt => opt.MapFrom(src => src.User.Name + " " + src.User.LastName))
            .ForMember(dest => dest.MovieGenre, opt => opt.MapFrom(src => src.Movie.Genre.Name))
            .ForMember(dest => dest.MovieName, opt => opt.MapFrom(src => src.Movie.Name))
            .ForMember(dest => dest.MoviePrice, opt => opt.MapFrom(src => src.Movie.Price + " $"));
            CreateMap<Order, OrdersViewModel>()
            .ForMember(dest => dest.BuyerName, opt => opt.MapFrom(src => src.User.Name + " " + src.User.LastName))
            .ForMember(dest => dest.MovieGenre, opt => opt.MapFrom(src => src.Movie.Genre.Name))
            .ForMember(dest => dest.MovieName, opt => opt.MapFrom(src => src.Movie.Name))
            .ForMember(dest => dest.MoviePrice, opt => opt.MapFrom(src => src.Movie.Price + " $"));

            CreateMap<CreateUserModel, User>();
            CreateMap<User, UsersViewModel>()
                .ForMember(dest => dest.Genres, opt => opt.MapFrom(src => returnGenres(src.Genres)))
                .ForMember(dest => dest.Movies, opt => opt.MapFrom(src => returnMovies(src.Movies)));
            CreateMap<User, UserDetailViewModel>();
        }
        public List<string> returnActors(List<Actor> actors)
        {
            List<string> actorNames = new List<string>();
            foreach(Actor actor in actors)
            {
                actorNames.Add(actor.Name + " " + actor.LastName);
            }
            return actorNames;
        }
        public List<string> returnGenres(List<Genre> genres)
        {
            List<string> genreNames = new List<string>();
            foreach(Genre genre in genres)
            {
                genreNames.Add(genre.Name);
            }
            return genreNames;
        }
        public List<string> returnMovies(List<Movie> movies)
        {
            List<string> movieNames = new List<string>();
            foreach(Movie movie in movies)
            {
                movieNames.Add(movie.Name);
            }
            return movieNames;
        }
    }
}
