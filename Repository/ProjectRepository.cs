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
			//To Set Default Status as Registered while creating project.
			/*project.StatusId = _context.Statuses
				.SingleOrDefault(s => s.StatusName == "Registered").StatusId;*/

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
