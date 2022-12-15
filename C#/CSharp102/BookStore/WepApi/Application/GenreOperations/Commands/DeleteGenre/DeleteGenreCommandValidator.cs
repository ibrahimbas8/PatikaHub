using FluentValidation;
using WepApi.Application.GenreOperations.CreateGenre;

namespace WepApi.Application.GenreOperations.DeleteGenre
{
    public class DeleteGenreCommandValidator: AbstractValidator<DeleteGenreCommand>
    {
        public DeleteGenreCommandValidator()
        {
            RuleFor(command => command.GenreId).GreaterThan(0);
            
        }
    }
}