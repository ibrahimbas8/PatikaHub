using AutoMapper;
using FluentValidation;
using MovieStoreWebApi.DbOperations;
using MovieStoreWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieStoreWebApi.Application.GenreOperations.Commands
{
    public class DeleteGenreCommandValidator :  AbstractValidator<DeleteGenreCommand>
    {
        public DeleteGenreCommandValidator()
        {
            RuleFor(command => command.Id).GreaterThan(0);            
        }
    }
}
