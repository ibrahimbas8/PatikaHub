using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieStoreWebApi.Application.ActorOperations.Commands;
using MovieStoreWebApi.Application.ActorOperations.Queries;
using MovieStoreWebApi.DbOperations;
using static MovieStoreWebApi.Application.ActorOperations.Commands.CreateActorCommand;

namespace MovieStoreWebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]s")]
    public class ActorController : ControllerBase
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public ActorController(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult GetAuthor()
        {
            GetActorsQuery query = new GetActorsQuery(_context, _mapper);
            var obj = query.Handle();
            return Ok(obj);
        }
        [HttpGet("id")]
        public ActionResult GetAuthorDetail(int id)
        {
            GetActorDetailQuery query = new GetActorDetailQuery(_context, _mapper);
            query.ActorId = id;
            GetActorDetailQueryValidator validations = new GetActorDetailQueryValidator();
            validations.ValidateAndThrow(query);

            var obj = query.Handle(); 
            return Ok(obj);
        }
        [HttpPost]
        public IActionResult AddActor([FromBody] CreateActorModel newAuthor)
        {
            CreateActorCommand command = new CreateActorCommand(_context, _mapper);
            command.Model = newAuthor;
            CreateActorCommandValidator validator = new CreateActorCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
                
            return Ok();
        }
        [HttpDelete("id")]
        public IActionResult DeleteActor(int id)
        {
            DeleteActorCommand command = new DeleteActorCommand(_context);
            command.Id = id;

            DeleteActorCommandValidator validations = new DeleteActorCommandValidator();
            validations.ValidateAndThrow(command);

            command.Handle();
            return Ok();
        }
        [HttpPut("id")]
        public IActionResult UpdateAuthor(int id, [FromBody] UpdateActorModel updateAuthor)
        {
            UpdateActorCommand command = new UpdateActorCommand(_context);
            command.Id = id ; 
            command.Model = updateAuthor;
            UpdateActorCommandValidator validations = new UpdateActorCommandValidator();
            validations.ValidateAndThrow(command);

            command.Handle();
            return Ok();
        }
    }
}
