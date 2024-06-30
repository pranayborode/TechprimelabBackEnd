using Microsoft.EntityFrameworkCore;
using Techprimelab.Data;
using Techprimelab.Models;
using Techprimelab.Repository.Interfaces;

namespace Techprimelab.Repository
{
	public class ProjectRepository : IProjectRepository
	{
		private readonly ApplicationDbContext _context;

        public ProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int AddProject(Project project)
		{

			_context.Projects.Add(project);
			return _context.SaveChanges();
		}

		public Project GetProjectById(int projectId)
		{
			return _context.Projects.Find(projectId);
		}

		public IEnumerable<Project> GetAllProjects()
		{
			return _context.Projects.ToList();
				/*.Include(p => p.Category)
				.Include(p => p.Department)
				.Include(p => p.Division)
				.Include(p => p.Location)
				.Include(p => p.Priority)
				.Include(p => p.Reason)
				.Include(p => p.Status)
				.Include(p => p.Types)
				.ToList();*/
		}

		public int UpdateProject(Project project)
		{
			_context.Projects.Update(project);
			return _context.SaveChanges();
		}

		public int UpdateProjectStatus(int projectId, int statusId)
		{
			var project = _context.Projects.Find(projectId);

			if(project != null)
			{
				project.StatusId = statusId;
				return _context.SaveChanges();
			}

			return 0;
		}

		/*	public int DeleteProject(int projectId)
			{
				throw new NotImplementedException();
			}*/

		public IEnumerable<Category> GetAllCategory()
		{
			return _context.Categories.ToList();
		}

		public IEnumerable<Department> GetAllDepartment()
		{
			return _context.Departments.ToList();
		}

		public IEnumerable<Division> GetAllDivision()
		{
			return _context.Divisions.ToList();
		}

		public IEnumerable<Location> GetAllLocation()
		{
			return _context.Locations.ToList();
		}

		public IEnumerable<Priority> GetAllPriority()
		{
			return _context.Priorities.ToList();
		}

	
		public IEnumerable<Types> GetAllTypes()
		{
			return _context.Types.ToList();
		}

		public IEnumerable<Reason> getAllReasons()
		{
			return _context.Reasons.ToList();
		}

	}
}


/*var projectDto = (from pro in _context.Projects
							   join c in _context.Categories on pro.CategoryId equals c.CategoryId into categoryGroup
							   from cat in categoryGroup.DefaultIfEmpty()
							   join dp in _context.Departments on pro.DepartmentId equals dp.DepartmentId into departmentGroup
							   from dept in departmentGroup.DefaultIfEmpty()
							   join di in _context.Divisions on pro.DivisionId equals di.DivisionId into divisionGroup
							   from div in divisionGroup.DefaultIfEmpty()
							   join lo in _context.Locations on pro.LocationId equals lo.LocationId into locationGroup
							   from loc in locationGroup.DefaultIfEmpty()
							   join pi in _context.Priorities on pro.PriorityId equals pi.PriorityId into priorityGroup
							   from pri in priorityGroup.DefaultIfEmpty()
							   join re in _context.Reasons on pro.ReasonId equals re.ReasonId into reasonGroup
							   from rea in reasonGroup.DefaultIfEmpty()
							   join st in _context.Statuses on pro.StatusId equals st.StatusId into statusGroup
							   from stat in statusGroup.DefaultIfEmpty()
							   join tp in _context.Types on pro.TypeId equals tp.TypeId into typeGroup
							   from typ in typeGroup.DefaultIfEmpty()
							   select new ProjectDto
							   {
								   ProjectId = pro.ProjectId,
								   ProjectName = pro.ProjectName,
								   ReasonId = pro.ReasonId,
								   TypeId = pro.TypeId,
								   DivisionId = pro.DivisionId,
								   CategoryId = pro.CategoryId,
								   PriorityId = pro.PriorityId,
								   DepartmentId = pro.DepartmentId,
								   LocationId = pro.LocationId,
								   StartDate = pro.StartDate,
								   EndDate = pro.EndDate,
								   StatusId = pro.StatusId,
								   Reason = rea,
								   Types = typ,
								   Division = div,
								   Category = cat,
								   Priority = pri,
								   Department = dept,
								   Location = loc,
								   Status = stat
							   }).ToList();
			return projectDto;*/