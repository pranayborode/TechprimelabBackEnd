using Techprimelab.Models;
using Techprimelab.Models.DTO;
using Techprimelab.Repository.Interfaces;
using Techprimelab.Services.Interfaces;

namespace Techprimelab.Services
{
	public class ProjectService : IProjectService
	{
		private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
			_projectRepository = projectRepository;
        }

        public int AddProject(Project project)
		{
			return _projectRepository.AddProject(project);
		}

		
		public IEnumerable<Project> GetAllProjects()
		{
			return _projectRepository.GetAllProjects();
		}

		

		public Project GetProjectById(int projectId)
		{
			return _projectRepository.GetProjectById(projectId);
		}

		public int UpdateProject(Project project)
		{
			return _projectRepository.UpdateProject(project);
		}

		public int UpdateProjectStatus(int projectId, int statusId)
		{
			return _projectRepository.UpdateProjectStatus(projectId, statusId);
		}


		public IEnumerable<Category> GetAllCategory()
		{
			return _projectRepository.GetAllCategory();
		}

		public IEnumerable<Department> GetAllDepartment()
		{
			return _projectRepository.GetAllDepartment();
		}

		public IEnumerable<Division> GetAllDivision()
		{
			return _projectRepository.GetAllDivision();
		}

		public IEnumerable<Location> GetAllLocation()
		{
			return _projectRepository.GetAllLocation();
		}

		public IEnumerable<Priority> GetAllPriority()
		{
			return _projectRepository.GetAllPriority();
		}
		public IEnumerable<Reason> getAllReason()
		{
			return _projectRepository.getAllReasons();
		}

		public IEnumerable<Types> GetAllTypes()
		{
			return _projectRepository.GetAllTypes();
		}

		public IEnumerable<ProjectDto> GetAllProjectsDto()
		{
			return _projectRepository.GetAllProjectsDto();
		}
	}
}
