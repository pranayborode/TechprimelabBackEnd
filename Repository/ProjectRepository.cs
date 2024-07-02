using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System;
using Techprimelab.Data;
using Techprimelab.Models;
using Techprimelab.Models.DTO;
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

		public IEnumerable<ProjectDto> GetAllProjectsDto()
		{
			var projectDto = (from pro in _context.Projects
							  join c in _context.Categories on pro.CategoryId equals c.CategoryId 

							  join dp in _context.Departments on pro.DepartmentId equals dp.DepartmentId 

							  join di in _context.Divisions on pro.DivisionId equals di.DivisionId 

							  join lo in _context.Locations on pro.LocationId equals lo.LocationId 

							  join pi in _context.Priorities on pro.PriorityId equals pi.PriorityId 

							  join re in _context.Reasons on pro.ReasonId equals re.ReasonId

							  join st in _context.Statuses on pro.StatusId equals st.StatusId 

							  join tp in _context.Types on pro.TypeId equals tp.TypeId 

							  select new ProjectDto
							  {
								  ProjectId = pro.ProjectId,
								  ProjectName = pro.ProjectName,
								  StartDate = pro.StartDate,
								  EndDate = pro.EndDate,
								  ReasonName = re.ReasonName,
								  ReasonId = re.ReasonId,
								  TypeName = tp.TypeName,
								  TypeId = tp.TypeId,
								  DivisionName = di.DivisionName,
								  DivisionId = di.DivisionId,
								  CategoryName = c.CategoryName,
								  CategoryId = c.CategoryId,
								  PriorityName = pi.PriorityName,
								  PriorityId = pi.PriorityId,
								  DepartmentName = dp.DepartmentName,
								  DepartmentId = dp.DepartmentId,
								  LocationName = lo.LocationName,
								  LocationId = lo.LocationId,
								  StatusName = st.StatusName,
								  StatusId = st.StatusId
							  }).ToList();
			return projectDto; 
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
							 
							   join dp in _context.Departments on pro.DepartmentId equals dp.DepartmentId into departmentGroup
							  
							   join di in _context.Divisions on pro.DivisionId equals di.DivisionId into divisionGroup
							 
							   join lo in _context.Locations on pro.LocationId equals lo.LocationId into locationGroup
							 
							   join pi in _context.Priorities on pro.PriorityId equals pi.PriorityId into priorityGroup
							  
							   join re in _context.Reasons on pro.ReasonId equals re.ReasonId into reasonGroup
							
							   join st in _context.Statuses on pro.StatusId equals st.StatusId into statusGroup
							 
							   join tp in _context.Types on pro.TypeId equals tp.TypeId into typeGroup
							 
							   select new ProjectDto
							   {
								   ProjectId = pro.ProjectId,
								   ProjectName = pro.ProjectName,
								 
								   StartDate = pro.StartDate,
								   EndDate = pro.EndDate,
								  
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