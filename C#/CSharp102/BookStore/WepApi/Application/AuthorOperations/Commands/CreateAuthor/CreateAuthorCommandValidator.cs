using FluentValidation;
using WepApi.Application.AuthorOperations.Commands.CreateAuthor;

namespace WepApi.Application.GenreOperations.Commands.CreateGenre
{
    public class CreateAuthorCommandValidator: AbstractValidator<CreateAuthorCommand>
    {
        public CreateAuthorCommandValidator()
        {
            RuleFor(command => command.Model.Name).NotEmpty().MinimumLength(4);
            
        }
    }
}