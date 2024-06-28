using Techprimelab.Models;

namespace Techprimelab.Services.Interfaces
{
	public interface IUserService
	{
		LoginOutput Login(User user);

		
	}
}
