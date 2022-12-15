using AutoMapper;
using MovieStoreWebApi.DbOperations;
using MovieStoreWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieStoreWebApi.Application.DirectorOperations.Commands
{
    public class CreateDirectorCommand
    {
        public CreateDirectorModel Model{get; set;}
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;

        public CreateDirectorCommand(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var director =  _context.Directors.SingleOrDefault(x => x.Name == Model.Name && x.LastName == Model.LastName);
            if(director is not null)
                throw new InvalidOperationException("Yönetmen zaten mevcut");
            
            director = new Director();
            director.Name = Model.Name;
            director.LastName = Model.LastName;

            _context.Directors.Add(director);
            _context.SaveChanges();
        }

        public class CreateDirectorModel
        {
            public string Name { get; set; }
            public string LastName { get; set; }
        }
    }
}
