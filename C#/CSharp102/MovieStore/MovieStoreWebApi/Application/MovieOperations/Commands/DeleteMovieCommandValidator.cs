using FluentValidation;

namespace MovieStoreWebApi.Applications.MovieOperations.Commands
{
  public class DeleteMovieCommandValidator : AbstractValidator<DeleteMovieCommand>
  {
    public DeleteMovieCommandValidator()
    {
      RuleFor(command => command.MovieId).GreaterThan(0);
    }
  }
}