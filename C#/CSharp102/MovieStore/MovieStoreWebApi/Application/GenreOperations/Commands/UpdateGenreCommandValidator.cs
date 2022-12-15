using FluentValidation;

namespace MovieStoreWebApi.Application.GenreOperations.Commands
{
  public class UpdateGenreCommandValidator : AbstractValidator<UpdateGenreCommand>
  {
    public UpdateGenreCommandValidator()
    {
      RuleFor(command => command.Model.Name).NotEmpty().MinimumLength(3);
    } 
  }
}