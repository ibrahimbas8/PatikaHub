using FluentValidation;

namespace MovieStoreWebApi.Application.GenreOperations.Queries
{
  public class GetGenreDetailQueryValidator : AbstractValidator<GetGenreDetailQuery>
  {
    public GetGenreDetailQueryValidator()
    {
      RuleFor(query => query.GenreId).GreaterThan(0);
    } 
  }
}