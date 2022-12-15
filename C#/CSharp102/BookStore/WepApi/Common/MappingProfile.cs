using AutoMapper;
using WepApi.Application.AuthorOperations.Queries.GetAuthorDetail;
using WepApi.Application.AuthorOperations.Queries.GetAuthors;
using WepApi.Application.GenreOperations.Queries.GetGenreDetail;
using WepApi.Application.GenreOperations.Queries.GetGenres;
using WepApi.BookOperations.GetBookDetail;
using WepApi.BookOperations.GetBooks;
using WepApi.Entities;
using static WepApi.BookOperations.CreateBook.CreateBookCommand;
using static WepApi.UserOperations.Commands.CreateUser.CreateUserCommand;

namespace WepApi.Common
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateBookModel, Book>();

            CreateMap<Book, BookDetailViewModel>()
            .ForMember(dest => dest.Genre, opt =>opt.MapFrom(src => src.Genre.Name))
            .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author.Name + " " + src.Author.Surname));

            CreateMap<Book, BooksViewModel>()
            .ForMember(dest => dest.Genre, opt =>opt.MapFrom(src => src.Genre.Name))
            .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author.Name + " " + src.Author.Surname));

            CreateMap<Genre, GenresViewModel>();
            CreateMap<Genre, GenreDetailViewModel>();

            CreateMap<Author, AuthorViewModel>();
            CreateMap<Author, AuthorDetailViewModel>();

            CreateMap<CreateUserModel, User>();

        }
    }
}