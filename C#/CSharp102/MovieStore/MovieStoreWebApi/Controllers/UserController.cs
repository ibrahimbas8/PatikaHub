using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
//using MovieStoreWebApi.Applications.UserOperations.Commands.CreateToken;
using MovieStoreWebApi.Applications.UserOperations.Commands;
using MovieStoreWebApi.Applications.UserOperations.Commands.RefreshToken;
//using MovieStoreWebApi.Applications.UserOperations.Commands.RefreshToken;
using MovieStoreWebApi.Applications.UserOperations.Queries;
using MovieStoreWebApi.DbOperations;
using MovieStoreWebApi.TokenOperations.Models;
using static MovieStoreWebApi.Applications.UserOperations.Commands.CreateTokenCommand;
//using MovieStoreWebApi.TokenOperations.Models;
//using static MovieStoreWebApi.Applications.UserOperations.Commands.CreateToken.CreateTokenCommand;

namespace WebApi.Controllers
{
  [ApiController]
  [Route("[controller]s")]
  public class UserController : ControllerBase
  {
    private readonly IMovieStoreDbContext _context;
    private readonly IMapper _mapper;
    readonly IConfiguration _configuration;
    public UserController(IMovieStoreDbContext context, IMapper mapper, IConfiguration configuration)
    {
      _context = context;
      _mapper = mapper;
      _configuration = configuration;
    }
    [HttpPost]
    public IActionResult CreateUser([FromBody] CreateUserModel newUser)
    {
      CreateUserCommand command = new CreateUserCommand(_context, _mapper);
      command.Model = newUser;
      command.Handle();
      return Ok();
    }

    [HttpPost("connect/token")]
    public ActionResult<Token> CreateToken([FromBody] CreateTokenModel login)
    {
      CreateTokenCommand command = new CreateTokenCommand(_context, _mapper, _configuration);      
      command.Model = login;
      var token = command.Handle();
      return token;      
    }

    [HttpGet("refreshToken")]
    public ActionResult<Token> RefreshToken([FromQuery] string token)
    {
      RefreshTokenCommand command = new RefreshTokenCommand(_context, _configuration);      
      command.RefreshToken = token;
      var resultToken = command.Handle();
      return resultToken;      
    }

    [HttpGet("{id}")]
    public IActionResult GetUserDetail(int id)
    { 
      UserDetailViewModel result; 
      
      GetUserDetailQuery query = new GetUserDetailQuery(_context, _mapper);
      query.UserId = id;
      GetUserDetailQueryValidator validator = new GetUserDetailQueryValidator();
      validator.ValidateAndThrow(query);
      result = query.Handle();
      
      return Ok(result);
    }

    [HttpGet]
    public IActionResult GetUsers()
    {
      GetUsersQuery query = new GetUsersQuery(_context, _mapper);
      var result = query.Handle();
      return Ok(result);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateUser(int id,[FromBody] UpdateUserModel updatedUser)
    {      
      UpdateUserCommand command = new UpdateUserCommand(_context);
      command.UserId = id; 
      command.Model = updatedUser; 

      UpdateUserCommandValidator validator = new UpdateUserCommandValidator();
      validator.ValidateAndThrow(command);
      command.Handle();
      return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteUser(int id)
    {      
      DeleteUserCommand command = new DeleteUserCommand(_context);
      command.UserId = id;
      DeleteUserCommandValidator validator = new DeleteUserCommandValidator();
      validator.ValidateAndThrow(command);
      command.Handle();      
      return Ok();
    }
  }
}