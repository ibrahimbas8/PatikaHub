using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WepApi.DBOperations;
using WepApi.Common;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace WepApi.BookOperations.GetBookDetail
{
    public class GetBookDetailQuery
    {
        private readonly IBookStoreDbContext _dbContext;
        private readonly IMapper _mapper; 

        public int BookId { get; set; }
        public GetBookDetailQuery(IBookStoreDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public BookDetailViewModel Handle()
        {
            var book =  _dbContext.Books.Include(x => x.Genre).Include(x => x.Author).Where(book => book.Id == BookId).SingleOrDefault();
            if(book is null)
                throw new InvalidOperationException("Kitap Bulunamadı...");

            BookDetailViewModel vm = _mapper.Map<BookDetailViewModel>(book);
            return vm;
        }
    }
    public class BookDetailViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
    }
}