using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Techprimelab.Models;
using Techprimelab.Repository.Interfaces;
using Techprimelab.Services.Interfaces;

namespace Techprimelab.Services
{
	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;
		private readonly IConfiguration _configuration;

        public UserService(
			IUserRepository userRepository,
			 IConfiguration configuration)
        {
			_userRepository = userRepository;
			_configuration = configuration;	
        }


        public LoginOutput Login(User user)
		{
			var _user = _userRepository.GetUserByEmailAndPassword(user.UserEmail, user.Password);

			if (_user != null)
			{
				var token = GenerateToken(user);

				return new LoginOutput
				{
					Token = token,
					UserId = user.UserId,
					UserEmail = user.UserEmail
				};
			}
			else
			{
				return null;
			}
		}

		private string GenerateToken(User user)
		{
			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
			var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

			var claims = new[]
			{
				new Claim(ClaimTypes.Email,user.UserEmail),
					new Claim("UserId",user.UserId.ToString()),

			};

			var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],
				_configuration["Jwt:Audience"],
				claims,
				expires: DateTime.Now.AddHours(1),
				signingCredentials: credentials);

			return new JwtSecurityTokenHandler().WriteToken(token);

		}
	}
}
