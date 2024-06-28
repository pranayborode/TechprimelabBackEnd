namespace Techprimelab.Repository.Interfaces
{
	public interface IDashboardRepository
	{
		Task<int> GetTotalProjectsCountAsync();
		Task<int> GetCountProjectsByStatusNameAsync(string statusName);
		Task<int> GetDelayedProjectsCountAsync();

		Task<object> GetChartDataAsync();

	}
}
