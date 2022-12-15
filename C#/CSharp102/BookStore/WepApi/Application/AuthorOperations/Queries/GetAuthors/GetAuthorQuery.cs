using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WepApi.DBOperations;

namespace WepApi.Application.AuthorOperations.Queries.GetAuthors
{
    public class GetAuthorQuery
    {
        public readonly IBookStoreDbContext _context;
        public readonly IMapper _mapper;  

        public GetAuthorQuery(IBookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<AuthorViewModel> Handle(){
            var author = _context.Authors.OrderBy(x => x.AuthorId);
            List<AuthorViewModel> returnObj = _mapper.Map<List<AuthorViewModel>>(author);
            return returnObj;
        }
    }
    public class AuthorViewModel{
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirdthDate { get; set; }
    }
}