using Techprimelab.Data;
using Techprimelab.Models;
using Techprimelab.Repository.Interfaces;

namespace Techprimelab.Repository
{
	public class UserRepository : IUserRepository
	{

		private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
		{
            _context = context;
        }

		public User GetUserByEmailAndPassword(string userEmail, string password)
		{
			
			return _context.Users.SingleOrDefault(u => u.UserEmail == userEmail && u.Password == password);
		}

		public User Login(User user)
		{
			var _user = _context.Users.Where(x => x.UserEmail == user.UserEmail).FirstOrDefault();
			return _user;

		}
	}
}
