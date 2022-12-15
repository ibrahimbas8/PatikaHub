using AutoMapper;
using MovieStoreWebApi.DbOperations;
using MovieStoreWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieStoreWebApi.Application.ActorOperations.Queries
{
    public class GetActorsQuery
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;

        public GetActorsQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<ActorViewModel> Handle()
        {
            var actor = _context.Actors.OrderBy(x => x.Id);
            List<ActorViewModel> returnObj = _mapper.Map<List<ActorViewModel>>(actor);
            return returnObj;
        }

        public class ActorViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
        }
    }
}
