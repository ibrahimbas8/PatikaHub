

using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WepApi.DBOperations;

namespace WepApi.Application.AuthorOperations.Queries.GetAuthorDetail
{
    public class GetAuthorDetailQuery
    {
        public int AuthorId { get; set; } 
        public readonly IBookStoreDbContext _context;
        public readonly IMapper _mapper;  

        public GetAuthorDetailQuery(IBookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public AuthorDetailViewModel Handle(){
            var author = _context.Authors.SingleOrDefault(x => x.AuthorId == AuthorId);

            if(author is null){
                throw new InvalidOperationException("Yazar bulunamadı");
            }
            return _mapper.Map<AuthorDetailViewModel>(author); 
        }
    }
    public class AuthorDetailViewModel{
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirdthDate { get; set; }
    }
}