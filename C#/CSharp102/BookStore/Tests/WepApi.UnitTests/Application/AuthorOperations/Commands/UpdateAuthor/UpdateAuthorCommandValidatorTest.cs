using System;
using FluentAssertions;
using TestSetup;
using WepApi.Application.AuthorOperations.Commands.UpdateAuthor;
using Xunit;

namespace Application.AuthorOperations.Commands.UpdateAuthor
{
    public class UpdateAuthorCommandValidatorTests:IClassFixture<CommonTestFixture>
    {
        [InlineData(" "," ")]
        [InlineData(" ","name")]
        [InlineData("nam","na ")]
        [Theory]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(string name, string surname)
        {
            UpdateAuthorCommand command = new UpdateAuthorCommand(null);
            command.Model= new UpdateAuthorModel(){Name=name,Surname=surname, BirdthDate=DateTime.Now.Date.AddYears(-10)};

            UpdateAuthorCommandValidator validations = new UpdateAuthorCommandValidator();
            var result = validations.Validate(command);

            result.Errors.Count.Should().BeGreaterThan(0);
        }

        [InlineData("İbrahim","bas")]
        [InlineData("İbrahim","baş")]
        [Theory]
        public void WhenInvalidInputsAreGiven_Validator_ShouldNotBeReturnErrors(string name, string surname)
        {
            UpdateAuthorCommand command = new UpdateAuthorCommand(null);
            command.Model= new UpdateAuthorModel(){Name=name,Surname=surname,  BirdthDate=DateTime.Now.Date.AddYears(-10)};

            UpdateAuthorCommandValidator validations = new UpdateAuthorCommandValidator();
            var result = validations.Validate(command);

            result.Errors.Count.Should().Be(0);
        }
    }
}