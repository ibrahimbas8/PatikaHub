using System;
using System.Linq;
using AutoMapper;
using FluentAssertions;
using TestSetup;
using WepApi.Application.AuthorOperations.Queries.GetAuthorDetail;
using WepApi.DBOperations;
using Xunit;

namespace Application.AuthorOperations.Queries.GetAuthorDetail
{
    public class GetAuthorDetailQueryTest:IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetAuthorDetailQueryTest(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        }

        [Fact]
        public void WhenGivenBookIdIsNotinDB_InvalidOperationException_ShouldBeReturn()
        {
            GetAuthorDetailQuery command = new GetAuthorDetailQuery(_context,_mapper);
            command.AuthorId=0;
                        
            FluentActions
            .Invoking(() => command.Handle())
            .Should().Throw<InvalidOperationException>().And.Message.Should()
            .Be("Yazar bulunamadı");
        }
        /*[Fact]
        public void WhenGivenBookIdIsinDB_InvalidOperationException_ShouldBeReturn()
        {
            GetAuthorDetailQuery command = new GetAuthorDetailQuery(_context,_mapper);
            command.AuthorId=1;
            
            FluentActions.Invoking(()=> command.Handle()).Invoke();

            var author=_context.Books.SingleOrDefault(author=>author.Id == command.AuthorId);
            author.Should().NotBeNull();
        }*/
    }
}