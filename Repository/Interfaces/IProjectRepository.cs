using Techprimelab.Models;
using Techprimelab.Models.DTO;


namespace Techprimelab.Repository.Interfaces
{
	public interface IProjectRepository
	{
		int AddProject(Project project);
		IEnumerable<Project> GetAllProjects();
		Project GetProjectById(int projectId);
		int UpdateProject(Project project);
		int UpdateProjectStatus(int projectId, int statusId);
		//int DeleteProject(int projectId);


		IEnumerable<Category> GetAllCategory();
		IEnumerable<Department> GetAllDepartment();
		IEnumerable<Division> GetAllDivision();
		IEnumerable<Location> GetAllLocation();
		IEnumerable<Priority> GetAllPriority();
		IEnumerable<Types> GetAllTypes();

		IEnumerable<Reason> getAllReasons();

		public IEnumerable<ProjectDto> GetAllProjectsDto();

	}
}
