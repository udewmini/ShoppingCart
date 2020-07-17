using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ShoppingCart.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace ShoppingCart.Business.ManagerClasses
{
    public interface IUserManager
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
    }

    public class UserManager : IUserManager
    {
        
        private readonly BaseManager basemanager = null;
        private readonly AppSetting _appSettings;

        public UserManager(IOptions<AppSetting> appSettings)
        {
            _appSettings = appSettings.Value;
            basemanager = new BaseManager();
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var mylist = GetAll();
            var user = mylist.SingleOrDefault(x => x.Email == model.Email && x.Password == model.Password);

            

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = generateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

        public IEnumerable<User> GetAll()
        {

            var userList = basemanager.UserRepository.GetAll().ToList();
            return userList;
        }

        private string generateJwtToken(User user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
               
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
