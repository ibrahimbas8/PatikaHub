using FluentValidation;

namespace MovieStoreWebApi.Applications.MovieOperations.Queries
{
  public class GetMovieDetailQueryValidator : AbstractValidator<GetMovieDetailQuery>
  {
    public GetMovieDetailQueryValidator()
    {
      RuleFor(command => command.MovieId).GreaterThan(0);
    }
  }
}