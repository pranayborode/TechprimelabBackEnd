using Microsoft.EntityFrameworkCore;
using Techprimelab.Data;
using Techprimelab.Models.DTO;
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

		public async Task<List<DepartmentSuccessDto>> GetChartDataAsync()
		{
			var closedStatusId = await _context.Statuses
	   .Where(s => s.StatusName == "Closed")
	   .Select(s => s.StatusId)
	   .SingleOrDefaultAsync();

			var departmentSuccessData = await _context.Projects
		.GroupBy(p => p.DepartmentId)
		.Select(g => new
		{
			DepartmentId = g.Key,
			TotalProjects = g.Count(),
			TotalProjectsClosed = g.Count(p => p.StatusId == closedStatusId),
			SuccessPercentage = g.Count(p => p.StatusId == closedStatusId) * 100.0 / g.Count()
		})
		.Join(_context.Departments, 
			projectGroup => projectGroup.DepartmentId,
			department => department.DepartmentId, 
			(projectGroup, department) => new DepartmentSuccessDto
			{
				DepartmentName = department.DepartmentName,
				TotalProjects = projectGroup.TotalProjects,
				TotalProjectsClosed = projectGroup.TotalProjectsClosed,
				SuccessPercentage = projectGroup.SuccessPercentage
			})
		.ToListAsync();
			return departmentSuccessData;
		}

	}
}
