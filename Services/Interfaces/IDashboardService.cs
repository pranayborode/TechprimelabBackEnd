using Techprimelab.Models.DTO;

namespace Techprimelab.Services.Interfaces
{
	public interface IDashboardService
	{
		int GetTotalProjectsCount();
		int GetCountProjectsByStatusName(string statusName);
		int GetDelayedProjectsCount();
		List<DepartmentSuccessDto> GetChartData();
	}
}
