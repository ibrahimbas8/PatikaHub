using System;
using System.Linq;
using FluentAssertions;
using TestSetup;
using WepApi.Application.AuthorOperations.Commands.UpdateAuthor;
using WepApi.DBOperations;
using Xunit;

namespace Application.AuthorOperations.Commands.UpdateAuthor
{
    public class UpdateAuthorCommandTest:IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;

        public UpdateAuthorCommandTest(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
        }

        [Fact]
        public void WhenGivenAuthorIdIsNotinDB_InvalidOperationException_ShouldBeReturn()
        {
            UpdateAuthorCommand command = new UpdateAuthorCommand(_context);
            command.AuthorId=0;

            FluentActions.Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Yazar Bulunamadı");
        }

        /*[Fact]
        public void WhenGivenAuthorIdIsinDB_InvalidOperationException_ShouldBeReturn()
        {
            UpdateAuthorCommand command = new UpdateAuthorCommand(_context);
            command.Model = new UpdateAuthorModel(){Name = "Sigmund", Surname="Freud", BirdthDate=DateTime.Now.Date.AddYears(-50)};
            command.AuthorId=1;

            FluentActions.Invoking(() => command.Handle()).Invoke();
            
            var author=_context.Authors.SingleOrDefault(author=>author.AuthorId == command.AuthorId);
            author.Should().NotBeNull(null);
        }*/
    }
}