using System;
using FluentValidation;

namespace MovieStoreWebApi.Applications.OrderOperations.Commands
{
  public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
  {
    public CreateOrderCommandValidator()
    {
      RuleFor(command => command.Model.BuyerId).GreaterThan(0);
      RuleFor(command => command.Model.MovieId).GreaterThan(0);
    }
  }
}