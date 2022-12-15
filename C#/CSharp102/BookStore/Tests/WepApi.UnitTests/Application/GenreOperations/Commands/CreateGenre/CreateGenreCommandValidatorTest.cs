using System;
using FluentAssertions;
using TestSetup;
using WepApi.Application.GenreOperations.Commands.CreateGenre;
using WepApi.Application.GenreOperations.CreateGenre;
using Xunit;

namespace Application.GenreOperations.Commands.CreateGenre
{
    public class CreateGenreCommandValidatorTest : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("a")]
        [InlineData("aa")]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(string Name)
        {
            //arrange
           CreateGenreCommand command = new CreateGenreCommand(null);
           command.Model = new CreateGenreModel()
           {
                Name = Name
           };

           //act
           CreateGenreCommandValidator validations = new CreateGenreCommandValidator();
           var result = validations.Validate(command);

           //assert
           result.Errors.Count.Should().BeGreaterThan(0);
        }
    }
}