using Techprimelab.Models.DTO;

namespace Techprimelab.Repository.Interfaces
{
	public interface IDashboardRepository
	{
		
		int GetTotalProjectsCount();
		int GetCountProjectsByStatusName(string statusName);
		int GetDelayedProjectsCount();
		List<DepartmentSuccessDto> GetChartData();
	}
}
