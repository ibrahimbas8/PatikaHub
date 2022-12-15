using AutoMapper;
using MovieStoreWebApi.DbOperations;
using MovieStoreWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieStoreWebApi.Application.ActorOperations.Commands
{
    public class DeleteActorCommand
    {
        public readonly IMovieStoreDbContext _context;
        public int Id { get; set; }
        public DeleteActorCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var actor =  _context.Actors.SingleOrDefault(x => x.Id == Id);
            if(actor is null)
                throw new InvalidOperationException("Silinecek aktör bulunamadı");

             _context.Actors.Remove(actor);
             _context.SaveChanges();
        }
    }
}
