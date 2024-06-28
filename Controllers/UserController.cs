using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Techprimelab.Models;
using Techprimelab.Services.Interfaces;

namespace Techprimelab.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;
		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		
		[HttpPost]
		[Route("Login")]
		public IActionResult Login([FromBody] User user)
		{
			try
			{
				var result = _userService.Login(user);

				if (result != null)
				{
					return Ok(result);
				}
				else
				{
					return StatusCode(StatusCodes.Status500InternalServerError);
				}
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status400BadRequest, ex);
			}
		}
	}
}

