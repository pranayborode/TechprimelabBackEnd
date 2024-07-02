using Techprimelab.Models;
using Techprimelab.Models.DTO;

namespace Techprimelab.Services.Interfaces
{
    public interface IProjectService
    {
		int AddProject(Project project);
		IEnumerable<Project> GetAllProjects();
		Project GetProjectById(int projectId);
		int UpdateProject(Project project);
		int UpdateProjectStatus(int projectId, int statusId);

		
		IEnumerable<Category> GetAllCategory();
		IEnumerable<Department> GetAllDepartment();
		IEnumerable<Division> GetAllDivision();
		IEnumerable<Location> GetAllLocation();
		IEnumerable<Priority> GetAllPriority();
		IEnumerable<Types> GetAllTypes();

		IEnumerable<Reason> getAllReason();

		public IEnumerable<ProjectDto> GetAllProjectsDto();

	}
}
