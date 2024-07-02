	using Techprimelab.Models.DTO;
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

			

		public int GetTotalProjectsCount()
		{
			return _dashboardRepository.GetTotalProjectsCount();
		}

		public int GetCountProjectsByStatusName(string statusName)
		{
			return _dashboardRepository.GetCountProjectsByStatusName(statusName);
		}

		public int GetDelayedProjectsCount()
		{
			return _dashboardRepository.GetDelayedProjectsCount();
		}

		public List<DepartmentSuccessDto> GetChartData()
		{
			return _dashboardRepository.GetChartData();
		}
	}
	}
