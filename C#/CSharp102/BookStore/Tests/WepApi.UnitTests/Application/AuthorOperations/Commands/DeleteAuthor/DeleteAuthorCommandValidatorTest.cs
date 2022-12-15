using FluentAssertions;
using TestSetup;
using WepApi.Application.AuthorOperations.Commands.DeleteAuthor;
using Xunit;

namespace Application.AuthorOperations.Commands.DeleteAuthor
{
    public class DeleteAuthorCommandValidatorTest:IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void WhenInvalidAuthorIdisGiven_Validator_ShouldBeReturnError(int authorid)
        {
            DeleteAuthorCommand command = new DeleteAuthorCommand(null);
            command.AuthorId=authorid;

            DeleteAuthorCommandValidator validator = new DeleteAuthorCommandValidator();
            var result = validator.Validate(command);
            
            result.Errors.Count.Should().BeGreaterThan(0);
        }

        [Theory]
        [InlineData(1)]
        public void WhenInvalidAuthorIdisGiven_Validator_ShouldNotBeReturnError(int authorid)
        {
            DeleteAuthorCommand command = new DeleteAuthorCommand(null);
            command.AuthorId=authorid;

            DeleteAuthorCommandValidator validator = new DeleteAuthorCommandValidator();
            var result = validator.Validate(command);
            
            result.Errors.Count.Should().Be(0);
        }
    }
}