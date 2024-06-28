
using Microsoft.EntityFrameworkCore;
using Techprimelab.Models;
namespace Techprimelab.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options) 
		{
		
		}
		public DbSet<User> Users { get; set; }
		public DbSet<Project> Projects { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Division> Divisions { get; set; }
		public DbSet<Location> Locations { get; set; }	
		public DbSet<Priority> Priorities { get; set; }
		public DbSet<Reason> Reasons { get; set; }
		public DbSet<Status> Statuses { get; set; }
		public DbSet<Types> Types { get; set; }
		
	}
}
