using FluentValidation;

namespace MovieStoreWebApi.Application.DirectorOperations.Commands
{
  public class CreateDirectorCommandValidator : AbstractValidator<CreateDirectorCommand>
  {
    public CreateDirectorCommandValidator()
    {
      RuleFor(command => command.Model.Name).NotEmpty().MinimumLength(3);
      RuleFor(command => command.Model.LastName).NotEmpty().MinimumLength(3);
    } 
  }
}