using FluentValidation;

namespace MovieStoreWebApi.Application.GenreOperations.Commands
{
  public class CreateGenreCommandValidator : AbstractValidator<CreateGenreCommand>
  {
    public CreateGenreCommandValidator()
    {
      RuleFor(command => command.Model.Name).NotEmpty().MinimumLength(3);
    } 
  }
}