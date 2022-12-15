using FluentValidation;

namespace MovieStoreWebApi.Applications.UserOperations.Queries
{
  public class GetUserDetailQueryValidator : AbstractValidator<GetUserDetailQuery>
  {
    public GetUserDetailQueryValidator()
    {
      RuleFor(query => query.UserId).GreaterThan(0);
    } 
  }
}