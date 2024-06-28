using Techprimelab.Repository.Interfaces;
using Techprimelab.Services.Interfaces;

namespace Techprimelab.Services
{
	public class DashboardService : IDashboardService
	{

		private readonly IDashboardRepository _dashboardRepository;

        public DashboardService(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository;
        }

        public async Task<int> GetTotalProjectsCountAsync()
		{
			return await _dashboardRepository.GetTotalProjectsCountAsync();
		}
		

		public async Task<int> GetCountProjectsByStatusNameAsync(string statusName)
		{
			return await _dashboardRepository.GetCountProjectsByStatusNameAsync(statusName);
		}

		public async Task<int> GetDelayedProjectsCountAsync()
		{
			return await _dashboardRepository.GetDelayedProjectsCountAsync();
		}

		public async Task<object> GetChartDataAsync()
		{
			return await _dashboardRepository.GetChartDataAsync();
		}
	}
}
