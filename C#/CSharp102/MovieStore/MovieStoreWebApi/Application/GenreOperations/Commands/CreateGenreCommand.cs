using AutoMapper;
using MovieStoreWebApi.DbOperations;
using MovieStoreWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieStoreWebApi.Application.GenreOperations.Commands
{
    public class CreateGenreCommand
    {
        public CreateGenreModel Model{get; set;}
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;

        public CreateGenreCommand(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var genre =  _context.Genres.SingleOrDefault(x => x.Name == Model.Name);
            if(genre is not null)
                throw new InvalidOperationException("Tür zaten mevcut");
            
            genre = new Genre();
            genre.Name = Model.Name;

            _context.Genres.Add(genre);
            _context.SaveChanges();
        }

        public class CreateGenreModel
        {
            public string Name { get; set; }
        }
    }
}
