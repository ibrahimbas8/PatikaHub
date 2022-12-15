using AutoMapper;
using MovieStoreWebApi.DbOperations;
using MovieStoreWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieStoreWebApi.Application.DirectorOperations.Commands
{
    public class UpdateDirectorCommand
    {
        public readonly IMovieStoreDbContext _context;
        public int Id { get; set; }
        public UpdateDirectorModel Model { get; set; }
        public UpdateDirectorCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var director =  _context.Directors.SingleOrDefault(x => x.Id == Id);
            if(director is null)
                throw new InvalidOperationException("Güncellenecek yönetmen bulunamadı");
                 
            director.Name = Model.Name != default ? Model.Name : director.Name;
            director.LastName = Model.LastName != default ? Model.LastName : director.LastName;
            _context.SaveChanges();
        }
    }
    public class UpdateDirectorModel
        {
            public string Name { get; set; }
            public string LastName { get; set; }
        }
}
