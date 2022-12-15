using AutoMapper;
using MovieStoreWebApi.DbOperations;
using System;
using System.Linq;

namespace MovieStoreWebApi.Application.GenreOperations.Queries
{
    public class GetGenreDetailQuery
    {
        public int GenreId { get; set; }
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;

        public GetGenreDetailQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public GenreDetailViewModel Handle()
        {
            var genre = _context.Actors.SingleOrDefault(x => x.Id == GenreId);
            if (genre is null)
            {
                throw new InvalidOperationException("Tür bulunamadı");
            }
            return _mapper.Map<GenreDetailViewModel>(genre);
        }
        public class GenreDetailViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
