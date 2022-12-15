using AutoMapper;
using MovieStoreWebApi.DbOperations;
using MovieStoreWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieStoreWebApi.Application.ActorOperations.Commands
{
    public class CreateActorCommand
    {
        public CreateActorModel Model{get; set;}
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;

        public CreateActorCommand(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var actor =  _context.Actors.SingleOrDefault(x => x.Name == Model.Name && x.LastName == Model.LastName);
            if(actor is not null)
                throw new InvalidOperationException("Aktör zaten mevcut");
            
            actor = new Actor();
            actor.Name = Model.Name;
            actor.LastName = Model.LastName;

            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public class CreateActorModel
        {
            public string Name { get; set; }
            public string LastName { get; set; }
        }
    }
}
