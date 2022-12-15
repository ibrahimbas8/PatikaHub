using System;
using FluentValidation;

namespace MovieStoreWebApi.Applications.OrderOperations.Commands
{
  public class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
  {
    public UpdateOrderCommandValidator()
    {
      RuleFor(command => command.Model.MovieId).GreaterThan(0);
      RuleFor(command => command.Model.BuyerId).GreaterThan(0);
    }
  }
}