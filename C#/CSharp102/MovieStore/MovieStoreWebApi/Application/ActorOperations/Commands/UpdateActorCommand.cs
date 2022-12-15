using AutoMapper;
using MovieStoreWebApi.DbOperations;
using MovieStoreWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieStoreWebApi.Application.ActorOperations.Commands
{
    public class UpdateActorCommand
    {
        public readonly IMovieStoreDbContext _context;
        public int Id { get; set; }
        public UpdateActorModel Model { get; set; }
        public UpdateActorCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var actor =  _context.Actors.SingleOrDefault(x => x.Id == Id);
            if(actor is null)
                throw new InvalidOperationException("Güncellenecek aktör bulunamadı");
                 
            actor.Name = Model.Name != default ? Model.Name : actor.Name;
            actor.LastName = Model.LastName != default ? Model.LastName : actor.LastName;
            _context.SaveChanges();
        }
    }
    public class UpdateActorModel
        {
            public string Name { get; set; }
            public string LastName { get; set; }
        }
}
