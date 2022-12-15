using AutoMapper;
using FluentValidation;
using MovieStoreWebApi.DbOperations;
using MovieStoreWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieStoreWebApi.Application.ActorOperations.Commands
{
    public class DeleteActorCommandValidator :  AbstractValidator<DeleteActorCommand>
    {
        public DeleteActorCommandValidator()
        {
            RuleFor(command => command.Id).GreaterThan(0);            
        }
    }
}
