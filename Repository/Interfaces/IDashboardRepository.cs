using Techprimelab.Models.DTO;

namespace Techprimelab.Repository.Interfaces
{
	public interface IDashboardRepository
	{
		Task<int> GetTotalProjectsCountAsync();
		Task<int> GetCountProjectsByStatusNameAsync(string statusName);
		Task<int> GetDelayedProjectsCountAsync();

		Task<List<DepartmentSuccessDto>> GetChartDataAsync();

	}
}
