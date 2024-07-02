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


		public int GetTotalProjectsCount()
		{
			return _context.Projects.Count();
		}

		public int GetCountProjectsByStatusName(string statusName)
		{
			var statusId =  _context.Statuses
				.Where(s => s.StatusName == statusName)
				.Select(s => s.StatusId)
				.SingleOrDefault();

			return _context.Projects.Count(p => p.StatusId == statusId);
		}

		public int GetDelayedProjectsCount()
		{
			return _context.Projects
			.Count(p => p.StatusId == _context.Statuses
			.SingleOrDefault(s => s.StatusName == "Running")
			.StatusId && p.EndDate < DateTime.Now);
		}

		public List<DepartmentSuccessDto> GetChartData()
		{
			var closedStatusId = _context.Statuses
				   .Where(s => s.StatusName == "Closed")
				   .Select(s => s.StatusId)
				   .SingleOrDefault();

			var departmentSuccessData = _context.Projects
				.GroupBy(p => p.DepartmentId)
				.Select(g => new
				{
					DepartmentId = g.Key,
					TotalProjects = g.Count(),
					TotalProjectsClosed = g.Count(p => p.StatusId == closedStatusId),
					Percentage = g.Count(p => p.StatusId == closedStatusId) * 100.0 / g.Count()
				})
				.Join(_context.Departments,
					projectGroup => projectGroup.DepartmentId,
					department => department.DepartmentId,
					(projectGroup, department) => new DepartmentSuccessDto
					{
						DepartmentName = department.DepartmentName,
						TotalProjects = projectGroup.TotalProjects,
						TotalProjectsClosed = projectGroup.TotalProjectsClosed,
						Percentage = projectGroup.Percentage
					})
				.ToList();

			return departmentSuccessData;
		}
	}
}
