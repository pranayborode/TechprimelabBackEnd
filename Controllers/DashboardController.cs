using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Techprimelab.Models.DTO;
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
		public IActionResult GetToatalProjectsCount()
		{
			try
			{
				var count =  _dashboardService.GetTotalProjectsCount();
				return Ok(count);
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex);
			}
		}

		[HttpGet]
		[Route("CountByStatusName/{statusName}")]
		public IActionResult CountProjectsByStatusName(string statusName)
		{
			try
			{
				var count =  _dashboardService.GetCountProjectsByStatusName(statusName);
				return Ok(count);
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex);
			}
		}

		[HttpGet]
		[Route("DelayedProjectsCount")]
		public IActionResult GetDelayedProjectsCount()
		{
			try
			{
				var count = _dashboardService.GetDelayedProjectsCount();
				return Ok(count);
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex);
			}
		}
		

		[HttpGet]
		[Route("ChartData")]
		public ActionResult<IEnumerable<DepartmentSuccessDto>>GetChartData()
		{
			var departmentSuccessData =  _dashboardService.GetChartData();
			return Ok(departmentSuccessData);
		}

	}
}
