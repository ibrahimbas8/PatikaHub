using FluentValidation;

namespace MovieStoreWebApi.Applications.UserOperations.Commands
{
  public class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
  {
    public DeleteUserCommandValidator()
    {
      RuleFor(command => command.UserId).GreaterThan(0);
    } 
  }
}