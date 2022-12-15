using System;
using System.Linq;
using WepApi.DBOperations;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using WepApi.TokenOperations;
using WepApi.TokenOperations.Model;

namespace WepApi.UserOperations.Commands.CreateToken
{
    public class CreateTokenCommand
    {
        public CreateTokenModel Model{get; set;}
        private readonly IBookStoreDbContext _dbContext;
        private readonly IMapper _mapper; 
        private readonly IConfiguration _configration;

        public CreateTokenCommand(IBookStoreDbContext dbContext, IMapper mapper, IConfiguration configration)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _configration = configration;
        }
        public Token Handle()
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Email == Model.Email && x.Password == Model.Password);
            if(user is not null)
            {
                TokenHandler handler = new TokenHandler(_configration);
                Token token = handler.CreateAccessToken(user);

                user.RefreshToken = token.RefreshToken;
                user.RefreshTokenExpireDate = token.Expiration.AddMinutes(5);

                _dbContext.SaveChanges();
                return token;
            }
            else{
                throw new InvalidOperationException("Email veya şifre hatalı");
            }
        }
    }
    public class CreateTokenModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}