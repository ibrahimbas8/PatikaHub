using AutoMapper;
using MovieStoreWebApi.DbOperations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieStoreWebApi.Application.DirectorOperations.Queries
{
    public class GetDirectorsQuery
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;

        public GetDirectorsQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<DirectorViewModel> Handle()
        {
            var director = _context.Directors.OrderBy(x => x.Id);
            List<DirectorViewModel> returnObj = _mapper.Map<List<DirectorViewModel>>(director);
            return returnObj;
        }

        public class DirectorViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
        }
    }
}
