namespace Techprimelab.Services.Interfaces
{
	public interface IDashboardService
	{
		Task<int> GetTotalProjectsCountAsync();
		Task<int> GetCountProjectsByStatusNameAsync(string statusName);
		Task<int> GetDelayedProjectsCountAsync();
		Task<object> GetChartDataAsync();
	}
}
