using FluentValidation;

namespace MovieStoreWebApi.Application.ActorOperations.Commands
{
  public class UpdateActorCommandValidator : AbstractValidator<UpdateActorCommand>
  {
    public UpdateActorCommandValidator()
    {
      RuleFor(command => command.Model.Name).NotEmpty().MinimumLength(3);
      RuleFor(command => command.Model.LastName).NotEmpty().MinimumLength(3);
    } 
  }
}