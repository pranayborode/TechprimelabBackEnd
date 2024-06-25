using Microsoft.EntityFrameworkCore;
namespace Techprimelab.Data
{
	public class ApplicationDbContext : DbContext
	{

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options) 
		{
		
		}


	}
}
