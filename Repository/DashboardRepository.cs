using Microsoft.EntityFrameworkCore;
using Techprimelab.Data;
using Techprimelab.Repository.Interfaces;

namespace Techprimelab.Repository
{
	public class DashboardRepository : IDashboardRepository
	{

		private readonly ApplicationDbContext _context;

		public DashboardRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		//Total projects
		public async Task<int> GetTotalProjectsCountAsync()
		{
			return await _context.Projects.CountAsync();
		}

		// Get: Count of project by status name 
		public async Task<int> GetCountProjectsByStatusNameAsync(string statusName)
		{
			var statusId = await _context.Statuses
				.Where(s => s.StatusName == statusName)
				.Select(s => s.StatusId)
				.SingleOrDefaultAsync();

			return await _context.Projects.CountAsync(p => p.StatusId == statusId);
		}


		//Total projects where the status is Running and
		//the end date is less than todays date
		public async Task<int> GetDelayedProjectsCountAsync()
		{
			return await _context.Projects
				.CountAsync(p => p.StatusId == _context.Statuses
				.SingleOrDefault(s => s.StatusName == "Running")
				.StatusId && p.EndDate < DateTime.Now);
		}

		public async Task<object> GetChartDataAsync()
		{
			return await _context.Projects
				.GroupBy(p => p.DepartmentId)
				.Select(g => new
				{
					Department = g.Key,
					TotalProjects = g.Count(),
					ClosedProjects = g.Count(p => p.StatusId == _context.Statuses.SingleOrDefault(s => s.StatusName == "Closed").StatusId)
				}).ToListAsync();
		}

	}
}
