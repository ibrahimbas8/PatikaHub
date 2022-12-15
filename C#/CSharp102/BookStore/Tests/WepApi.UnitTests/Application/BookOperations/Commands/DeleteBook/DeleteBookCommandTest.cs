using System;
using System.Linq;
using FluentAssertions;
using TestSetup;
using WepApi.BookOperations.DeleteBook;
using WepApi.DBOperations;
using WepApi.Entities;
using Xunit;

namespace Application.BookOperations.Commands.DeleteBook
{
    public class DeleteBookCommandTest : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;
        public DeleteBookCommandTest(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
        }
        [Fact]
        public void WhenAlreadyExistBookIdIsGiven_InvalidOperationException_ShouldBeReturn()
        {
            DeleteBookCommand command = new DeleteBookCommand(_context);

             FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Silinecek kitap bulunamadı");
        }
        
        [Fact]
        public void WhenValidInputsAreGiven_Book_ShouldBeCreated()
        {
            //arrange
           var book = new Book() {Title="Lord Of The Rings", PageCount=100, PublishDate=new System.DateTime(1990,05,22), GenreId=2, AuthorId=1};
           _context.Add(book);
           _context.SaveChanges();

           DeleteBookCommand command = new DeleteBookCommand(_context);
           command.BookId = book.Id;

            //act
            FluentActions.Invoking(() => command.Handle()).Invoke();

            //assert
            book = _context.Books.SingleOrDefault(x=> x.Id == book.Id);
            book.Should().BeNull();

        }
    }
}