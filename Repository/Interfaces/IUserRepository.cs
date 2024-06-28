using Techprimelab.Models;

namespace Techprimelab.Repository.Interfaces
{
	public interface IUserRepository
	{
		User Login(User users);
		User GetUserByEmailAndPassword(string username, string password);
	}
}
