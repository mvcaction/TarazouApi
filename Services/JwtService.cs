using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Tarazou4.Entities;

namespace Services
{
    public class JwtService : IJwtService
    {
        public string Generate(User user)
        {
            var secretkey = Encoding.UTF8.GetBytes("asdfdsasdfcdsdfdsd");
            var signingcredential = new SigningCredentials(new SymmetricSecurityKey(secretkey), SecurityAlgorithms.HmacSha256Signature);
            var claims = getclaims(user);
            var descriptor = new SecurityTokenDescriptor
            {
                Issuer = "MyWeb",
                Audience = "MyWeb",
                IssuedAt = DateTime.Now,
                NotBefore = DateTime.Now.AddMinutes(0),
                Expires = DateTime.Now.AddHours(1),
                SigningCredentials = signingcredential,
                Subject = new ClaimsIdentity(claims)


            };
            var tokenhandler = new JwtSecurityTokenHandler();
            var securitykey = tokenhandler.CreateToken(descriptor);
            var jwt = tokenhandler.WriteToken(securitykey);
            return jwt;
        }
        public IEnumerable<Claim> getclaims(User user)
        {
            var list = new List<Claim>
           { new Claim(ClaimTypes.Name,user.Username),
              new Claim(ClaimTypes.NameIdentifier,user.Id.ToString())


            };


            return list;
        }

    }
}
