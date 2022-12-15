using System;
using System.Linq;
using FluentAssertions;
using TestSetup;
using WepApi.Application.GenreOperations.DeleteGenre;
using WepApi.DBOperations;
using WepApi.Entities;
using Xunit;

namespace Application.GenreOperations.Commands.DeleteGenre
{
    public class DeleteGenreCommandTest : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;
        public DeleteGenreCommandTest(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
        }
        [Fact]
        public void WhenGivenGenreIdIsNotinDB_InvalidOperationException_ShouldBeReturn()
        {
            DeleteGenreCommand command = new DeleteGenreCommand(_context);
            command.GenreId=0;

             FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kitap Türü bulunamadı");
        }
        /*[Fact]
        public void  WhenGivenGenreIdinDB_Genre_ShouldBeRemove()
        {

           DeleteGenreCommand command = new DeleteGenreCommand(_context);
           command.GenreId = 1;

            //act
            FluentActions.Invoking(() => command.Handle()).Invoke();

            //assert
            var genre = _context.Books.SingleOrDefault(x=> x.Id == command.GenreId);
            genre.Should().BeNull();
        }*/
    }
}