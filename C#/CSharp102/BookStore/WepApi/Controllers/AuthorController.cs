using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WepApi.Application.AuthorOperations.Commands.CreateAuthor;
using WepApi.Application.AuthorOperations.Commands.DeleteAuthor;
using WepApi.Application.AuthorOperations.Commands.UpdateAuthor;
using WepApi.Application.AuthorOperations.Queries.GetAuthorDetail;
using WepApi.Application.AuthorOperations.Queries.GetAuthors;
using WepApi.Application.GenreOperations.Commands.CreateGenre;
using WepApi.DBOperations;
namespace WepApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class AuthorController : ControllerBase
    {
        private readonly IBookStoreDbContext _context;
        private readonly IMapper _mapper;
        public AuthorController(IBookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
         [HttpGet]
        public ActionResult GetAuthor()
        {
            GetAuthorQuery query = new GetAuthorQuery(_context, _mapper);
            var obj = query.Handle(); 
            return Ok(obj);
        }
        [HttpGet("id")]
        public ActionResult GetAuthorDetail(int id)
        {
            GetAuthorDetailQuery query = new GetAuthorDetailQuery(_context, _mapper);
            query.AuthorId = id;
            GetAuthorDetailQueryValidator validations = new GetAuthorDetailQueryValidator();
            validations.ValidateAndThrow(query);

            var obj = query.Handle(); 
            return Ok(obj);
        }

        [HttpPost]
        public IActionResult AddAuthor([FromBody] CreateAuthorModel newAuthor)
        {
            CreateAuthorCommand command = new CreateAuthorCommand(_context);
            command.Model = newAuthor;

            CreateAuthorCommandValidator validations = new CreateAuthorCommandValidator();
            validations.ValidateAndThrow(command);

            command.Handle();
            return Ok();
        }

        [HttpDelete("id")]
        public IActionResult DeleteAuthor(int id)
        {
            DeleteAuthorCommand command = new DeleteAuthorCommand(_context);
            command.AuthorId = id;

            DeleteAuthorCommandValidator validations = new DeleteAuthorCommandValidator();
            validations.ValidateAndThrow(command);

            command.Handle();
            return Ok();
        }
        [HttpPut("id")]
        public IActionResult UpdateAuthor(int id, [FromBody] UpdateAuthorModel updateAuthor)
        {
            UpdateAuthorCommand command = new UpdateAuthorCommand(_context);
            command.AuthorId = id ; 
            command.Model = updateAuthor;
            UpdateAuthorCommandValidator validations = new UpdateAuthorCommandValidator();
            validations.ValidateAndThrow(command);

            command.Handle();
            return Ok();
        }
    }
}