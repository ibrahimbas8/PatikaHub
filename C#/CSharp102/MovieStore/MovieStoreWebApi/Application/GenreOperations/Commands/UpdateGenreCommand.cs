using AutoMapper;
using MovieStoreWebApi.DbOperations;
using MovieStoreWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieStoreWebApi.Application.GenreOperations.Commands
{
    public class UpdateGenreCommand
    {
        public readonly IMovieStoreDbContext _context;
        public int Id { get; set; }
        public UpdateGenreModel Model { get; set; }
        public UpdateGenreCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var genre =  _context.Genres.SingleOrDefault(x => x.Id == Id);
            if(genre is null)
                throw new InvalidOperationException("Güncellenecek tür bulunamadı");
                 
            genre.Name = Model.Name != default ? Model.Name : genre.Name;
            _context.SaveChanges();
        }
    }
    public class UpdateGenreModel
        {
            public string Name { get; set; }
        }
}
