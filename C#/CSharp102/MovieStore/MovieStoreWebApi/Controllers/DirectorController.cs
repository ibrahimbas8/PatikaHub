
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieStoreWebApi.Application.DirectorOperations.Commands;
using MovieStoreWebApi.Application.DirectorOperations.Queries;
using MovieStoreWebApi.DbOperations;
using static MovieStoreWebApi.Application.DirectorOperations.Commands.CreateDirectorCommand;

namespace MovieStoreWebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]s")]
    public class DirectorController : ControllerBase
    {
        
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public DirectorController(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult GetDirector()
        {
            GetDirectorsQuery query = new GetDirectorsQuery(_context, _mapper);
            var obj = query.Handle();
            return Ok(obj);
        }
        [HttpGet("id")]
        public ActionResult GetDirectorDetail(int id)
        {
            GetDirectorDetailQuery query = new GetDirectorDetailQuery(_context, _mapper);
            query.DirectorId = id;
            GetDirectorDetailQueryValidator validations = new GetDirectorDetailQueryValidator();
            validations.ValidateAndThrow(query);

            var obj = query.Handle(); 
            return Ok(obj);
        }
        [HttpPost]
        public IActionResult AddDirector([FromBody] CreateDirectorModel newDirector)
        {
            CreateDirectorCommand command = new CreateDirectorCommand(_context, _mapper);
            command.Model = newDirector;
            CreateDirectorCommandValidator validator = new CreateDirectorCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
                
            return Ok();
        }
        [HttpDelete("id")]
        public IActionResult DeleteDirector(int id)
        {
            DeleteDirectorCommand command = new DeleteDirectorCommand(_context);
            command.Id = id;

            DeleteDirectorCommandValidator validations = new DeleteDirectorCommandValidator();
            validations.ValidateAndThrow(command);

            command.Handle();
            return Ok();
        }
        [HttpPut("id")]
        public IActionResult UpdateDirector(int id, [FromBody] UpdateDirectorModel updateDirector)
        {
            UpdateDirectorCommand command = new UpdateDirectorCommand(_context);
            command.Id = id ; 
            command.Model = updateDirector;
            UpdateDirectorCommandValidator validations = new UpdateDirectorCommandValidator();
            validations.ValidateAndThrow(command);

            command.Handle();
            return Ok();
        }
    }
}
