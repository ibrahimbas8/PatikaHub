using AutoMapper;
using FluentValidation;
using MovieStoreWebApi.DbOperations;
using MovieStoreWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieStoreWebApi.Application.DirectorOperations.Commands
{
    public class DeleteDirectorCommandValidator :  AbstractValidator<DeleteDirectorCommand>
    {
        public DeleteDirectorCommandValidator()
        {
            RuleFor(command => command.Id).GreaterThan(0);            
        }
    }
}
