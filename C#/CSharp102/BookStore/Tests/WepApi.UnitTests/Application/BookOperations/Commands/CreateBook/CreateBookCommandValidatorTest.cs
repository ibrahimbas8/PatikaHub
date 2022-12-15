using System;
using FluentAssertions;
using TestSetup;
using WepApi.BookOperations.CreateBook;
using Xunit;
using static WepApi.BookOperations.CreateBook.CreateBookCommand;

namespace Application.BookOperations.Commands.CreateBook
{
    public class CreateBookCommandValidatorTest : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData("",0,0,0)]
        [InlineData("LOTR",0,0,0)]
        [InlineData("LOTR",100,0,0)]
        [InlineData("LOTRr",0,1,2)]
        [InlineData("LOTRr",100,0,2)]
        [InlineData("",100,0,0)]
        [InlineData("",100,1,0)]
        [InlineData("",100,1,2)]
        [InlineData("",100,0,2)]
        [InlineData("",0,0,2)]
        [InlineData("",0,1,0)]
        [InlineData("",0,1,2)]
        [InlineData("lor",100,1,2)]
        [InlineData("LOTRr",0,0,2)]
        [InlineData(" ",100, 1,2)]

        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(string Title,int PageCount, int GenreId, int AuthorId)
        {
            //arrange
           CreateBookCommand command = new CreateBookCommand(null,null);
           command.Model = new CreateBookModel()
           {
                Title=Title,
                PageCount=PageCount,     
                PublishDate = DateTime.Now.Date.AddYears(-1),
                GenreId = GenreId, 
                AuthorId = AuthorId
           };

           //act
           CreateBookCommandValidator validations = new CreateBookCommandValidator();
           var result = validations.Validate(command);

           //assert
           result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnError()
        {
           CreateBookCommand command = new CreateBookCommand(null,null);
           command.Model = new CreateBookModel()
           {
                Title= "LOTRr",
                PageCount= 100,     
                PublishDate = DateTime.Now.Date,
                GenreId = 1, 
                AuthorId = 2
           };

            CreateBookCommandValidator validations = new CreateBookCommandValidator();
            var result = validations.Validate(command);

           result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputAreGiven_Validator_ShouldNotBeReturnError()
        {
           CreateBookCommand command = new CreateBookCommand(null,null);
           command.Model = new CreateBookModel()
           {
                Title= "LOTRr",
                PageCount= 100,     
                PublishDate = DateTime.Now.Date.AddYears(-2),
                GenreId = 1, 
                AuthorId = 2
           };

            CreateBookCommandValidator validations = new CreateBookCommandValidator();
            var result = validations.Validate(command);

           result.Errors.Count.Should().Be(0);
        }

        
    }
}