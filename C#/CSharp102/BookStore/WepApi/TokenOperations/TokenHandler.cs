using System;
using Microsoft.Extensions.Configuration;
using WepApi.Entities;
using WepApi.TokenOperations.Model;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;

namespace WepApi.TokenOperations
{
    public class TokenHandler
    {
        public IConfiguration Configration{get; set;}
        public TokenHandler(IConfiguration configration)
        {
            Configration = configration;
        }
        public Token CreateAccessToken(User user)
        {
            Token tokenModel = new Token();
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configration["Token:SecurityKey"]));
            
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            tokenModel.Expiration = DateTime.Now.AddMinutes(15);
            JwtSecurityToken securityToken = new JwtSecurityToken(
                issuer : Configration["Token : Issuer"],
                audience : Configration["Token : Audince"],
                expires : tokenModel.Expiration,
                notBefore : DateTime.Now,
                signingCredentials : credentials
            );
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            //Token yaratılıyor
            tokenModel.AccessToken = tokenHandler.WriteToken(securityToken);
            tokenModel.RefreshToken = CreateRefreshToken();
            
            return tokenModel;
        }
        
        public string CreateRefreshToken()
        {
            return Guid.NewGuid().ToString();
        }
    }
}