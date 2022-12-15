using System;
using System.Linq;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using MovieStoreWebApi.TokenOperations;
using MovieStoreWebApi.DbOperations;
using MovieStoreWebApi.Entities;
using MovieStoreWebApi.TokenOperations.Models;

namespace MovieStoreWebApi.Applications.UserOperations.Commands
{
  public class CreateTokenCommand
  {
    private readonly IMovieStoreDbContext _context;
    public CreateTokenModel Model { get; set; }
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;
    public CreateTokenCommand(IMovieStoreDbContext context, IMapper mapper, IConfiguration configuration)
    {
      _context = context;
      _mapper = mapper;
      _configuration = configuration;
    }
    public Token Handle()
    {
      var user = _context.Users.FirstOrDefault(x => x.Email == Model.Email && x.Password == Model.Password);
      if(user is not null)
      {
        TokenHandler handler = new TokenHandler(_configuration);
        Token token = handler.CreateAccessToken(user);

        user.RefreshToken = token.Refreshtoken;
        user.RefreshTokenExpireDate = token.Expiration.AddMinutes(5);
        _context.SaveChanges();
        return token;
      }
      else
        throw new InvalidOperationException("Kullanıcı adı veya parola yanlış!");
    }

  public class CreateTokenModel{
    public string Email { get; set; }
    public string Password { get; set; }
  }
  }  
}