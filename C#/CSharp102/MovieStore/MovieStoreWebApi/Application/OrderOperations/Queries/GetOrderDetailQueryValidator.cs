using FluentValidation;

namespace MovieStoreWebApi.Applications.OrderOperations.Queries
{
  public class GetOrderDetailQueryValidator : AbstractValidator<GetOrderDetailQuery>
  {
    public GetOrderDetailQueryValidator()
    {
      RuleFor(command => command.OrderId).GreaterThan(0);
    }
  }
}