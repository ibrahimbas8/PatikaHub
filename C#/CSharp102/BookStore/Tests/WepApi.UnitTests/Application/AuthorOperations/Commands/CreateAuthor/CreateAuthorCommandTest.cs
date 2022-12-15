using System;
using System.Linq;
using AutoMapper;
using FluentAssertions;
using TestSetup;
using WepApi.Application.AuthorOperations.Commands.CreateAuthor;
using WepApi.DBOperations;
using WepApi.Entities;
using Xunit;

namespace Application.AuthorOperations.Commands.CreateAuthor
{
    public class CreateAuthorCommandTest : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;
        public CreateAuthorCommandTest(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
        }
        /*[Fact]
        public void WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldBeReturn()
        {
            //arrange
            var author = new Author(){Name = "Test_WhenAlreadyExistBookTitleIsGiven_In", Surname = "adsasdads", BirdthDate = new System.DateTime(1990,01,10)};
            _context.Authors.Add(author);
            _context.SaveChanges();

            CreateAuthorCommand command = new CreateAuthorCommand(_context);
            command.Model = new CreateAuthorModel(){Name = author.Name};
            //act -- assert
            FluentActions
            .Invoking(() => command.Handle())
            .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Yazar zaten mevcut");  
        }*/
        [Fact]
        public void WhenValidInputsAreGiven_Book_ShouldBeCreated()
        {
            //arrange
            CreateAuthorCommand command = new CreateAuthorCommand(_context);
            CreateAuthorModel model = new CreateAuthorModel(){Name = "Test_WhenAlreadyExistBookTitleIsGiven_In", Surname = "adsasdads", BirdthDate = new System.DateTime(1990,01,10)};
            command.Model = model;

            //act 
            FluentActions.Invoking(() => command.Handle()).Invoke();

            //assert
            var author = _context.Authors.SingleOrDefault(author => author.Name == model.Name);
            author.Should().NotBeNull();
            author.Name.Should().Be(model.Name);
            author.Surname.Should().Be(model.Surname);
            author.BirdthDate.Should().Be(model.BirdthDate);
        }
    }
}