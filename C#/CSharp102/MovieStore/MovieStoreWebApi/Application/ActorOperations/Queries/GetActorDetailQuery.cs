using AutoMapper;
using MovieStoreWebApi.DbOperations;
using MovieStoreWebApi.Entities;
using System;
using System.Linq;

namespace MovieStoreWebApi.Application.ActorOperations.Queries
{
    public class GetActorDetailQuery
    {
        public int ActorId { get; set; }
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;

        public GetActorDetailQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ActorDetailViewModel Handle()
        {
            var actor = _context.Actors.SingleOrDefault(x => x.Id == ActorId);
            if (actor is null)
            {
                throw new InvalidOperationException("Aktör bulunamadı");
            }
            return _mapper.Map<ActorDetailViewModel>(actor);
        }
        public class ActorDetailViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
        }
    }
}
