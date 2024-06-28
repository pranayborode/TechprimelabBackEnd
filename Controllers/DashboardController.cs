using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Techprimelab.Services.Interfaces;

namespace Techprimelab.Controllers
{
	[ApiController]
	[Authorize]
	[Route("api/[controller]")]
	public class DashboardController : Controller
	{
		private readonly IDashboardService _dashboardService;

		public DashboardController(IDashboardService dashboardService)
		{
			_dashboardService = dashboardService;
		}

		[HttpGet]
		[Route("TotalProjects")]
		public async Task<IActionResult> GetToatalProjectsCount()
		{
			try
			{
				var count = await _dashboardService.GetTotalProjectsCountAsync();
				return Ok(count);
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex);
			}
		}

		[HttpGet]
		[Route("CountByStatusName/{statusName}")]
		public async Task<IActionResult> CountProjectsByStatusName(string statusName)
		{
			try
			{
				var count = await _dashboardService.GetCountProjectsByStatusNameAsync(statusName);
				return Ok(count);
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex);
			}
		}

		[HttpGet]
		[Route("DelayedProjectsCount")]
		public async Task<IActionResult> GetDelayedProjectsCount()
		{
			try
			{
				var count = await _dashboardService.GetDelayedProjectsCountAsync();
				return Ok(count);
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex);
			}
		}

		[HttpGet]
		[Route("ChartData")]
		public async Task<IActionResult> GetChartData()
		{
			var data = await _dashboardService.GetChartDataAsync();
			return Ok(data);
		}

	}
}
