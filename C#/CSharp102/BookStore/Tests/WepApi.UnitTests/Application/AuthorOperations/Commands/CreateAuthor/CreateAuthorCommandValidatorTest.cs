using System;
using FluentAssertions;
using TestSetup;
using WepApi.Application.AuthorOperations.Commands.CreateAuthor;
using WepApi.Application.GenreOperations.Commands.CreateGenre;
using Xunit;

namespace Application.AuthorOperations.Commands.CreateAuthor
{
    public class CreateAuthorCommandValidatorTest : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData("","")]
        [InlineData(" "," ")]
        [InlineData("","asd")]
        [InlineData("aa","aaa")]
        [InlineData("aa","a ")]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(string name, string surname)
        {
            CreateAuthorCommand command = new CreateAuthorCommand(null);
            command.Model=new CreateAuthorModel()
            {
                Name=name,
                Surname=surname,
                BirdthDate= DateTime.Now.Date.AddYears(-10)
            };

            CreateAuthorCommandValidator validator = new CreateAuthorCommandValidator();
            var result = validator.Validate(command);

            result.Errors.Count.Should().BeGreaterThan(0);
        }

        [Theory]
        [InlineData("ibrahim","")]
        [InlineData("ibrahim","baş")]
        [InlineData("ibrahim","  ")]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnError(string name, string surname)
        {
            CreateAuthorCommand command = new CreateAuthorCommand(null);
            command.Model=new CreateAuthorModel()
            {
                Name=name,
                Surname=surname,
                BirdthDate=DateTime.Now.Date.AddYears(-10)
            };

            CreateAuthorCommandValidator validator = new CreateAuthorCommandValidator();
            var result = validator.Validate(command);

            result.Errors.Count.Should().Be(0);
        }
    }
}