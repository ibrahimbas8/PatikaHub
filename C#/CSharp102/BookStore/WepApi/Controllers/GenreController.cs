using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WepApi.DBOperations;
using WepApi.BookOperations.GetBooks;
using WepApi.BookOperations.CreateBook;
using static WepApi.BookOperations.CreateBook.CreateBookCommand;
using WepApi.BookOperations.GetBookDetail;
using WepApi.BookOperations.UpdateBook;
using WepApi.BookOperations.DeleteBook;
using AutoMapper;
using FluentValidation.Results;
using FluentValidation;
using WepApi.Application.GenreOperations.Queries.GetGenres;
using WepApi.Application.GenreOperations.Queries.GetGenreDetail;
using WepApi.Application.GenreOperations.CreateGenre;
using WepApi.Application.GenreOperations.Commands.CreateGenre;
using WepApi.Application.GenreOperations.UpdateGenre;
using WepApi.Application.GenreOperations.DeleteGenre;

namespace WepApi.Controllers{
    [ApiController]
    [Route("[controller]s")]
    public class GenreController : ControllerBase
    {
        private readonly IBookStoreDbContext _context;
        private readonly IMapper _mapper;

        public GenreController(IBookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult GetGenres()
        {
            GetGenresQuery query = new GetGenresQuery(_context, _mapper);
            var obj = query.Handle(); 
            return Ok(obj);
        }

        [HttpGet("id")]
        public ActionResult GetGenreDetail(int id)
        {
            GetGenreDetailQuery query = new GetGenreDetailQuery(_context, _mapper);
            query.GenreId = id;
            GetGenreDetailQueryValidator validations = new GetGenreDetailQueryValidator();
            validations.ValidateAndThrow(query);

            var obj = query.Handle(); 
            return Ok(obj);
        }

        [HttpPost]
        public IActionResult AddGenre([FromBody] CreateGenreModel newGenre)
        {
            CreateGenreCommand command = new CreateGenreCommand(_context);
            command.Model = newGenre;

            CreateGenreCommandValidator validations = new CreateGenreCommandValidator();
            validations.ValidateAndThrow(command);

            command.Handle();
            return Ok();
        }

        [HttpPut("id")]
        public IActionResult UpdateGenre(int id, [FromBody] UpdateGenreModel updateGenre)
        {
            UpdateGenreCommand command = new UpdateGenreCommand(_context);
            command.GenreId = id ; 
            command.Model = updateGenre;
            UpdateGenreCommandValidator validations = new UpdateGenreCommandValidator();
            validations.ValidateAndThrow(command);

            command.Handle();
            return Ok();
        }

        [HttpDelete("id")]
        public IActionResult DeleteGenre(int id)
        {
            DeleteGenreCommand command = new DeleteGenreCommand(_context);
            command.GenreId = id;

            DeleteGenreCommandValidator validations = new DeleteGenreCommandValidator();
            validations.ValidateAndThrow(command);

            command.Handle();
            return Ok();
        }
    }
}