using FluentValidation;

namespace MovieStoreWebApi.Applications.OrderOperations.Commands
{
  public class DeleteOrderCommandValidator : AbstractValidator<DeleteOrderCommand>
  {
    public DeleteOrderCommandValidator()
    {
      RuleFor(command => command.OrderId).GreaterThan(0);
    }
  }
}