using AutoMapper;
using MovieStoreWebApi.DbOperations;
using System;
using System.Linq;

namespace MovieStoreWebApi.Application.DirectorOperations.Queries
{
    public class GetDirectorDetailQuery
    {
        public int DirectorId { get; set; }
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;

        public GetDirectorDetailQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public DirectorDetailViewModel Handle()
        {
            var director = _context.Actors.SingleOrDefault(x => x.Id == DirectorId);
            if (director is null)
            {
                throw new InvalidOperationException("Yönetmen bulunamadı");
            }
            return _mapper.Map<DirectorDetailViewModel>(director);
        }
        public class DirectorDetailViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
        }
    }
}
