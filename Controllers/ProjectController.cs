using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using Techprimelab.Models;
using Techprimelab.Services;
using Techprimelab.Services.Interfaces;

namespace Techprimelab.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class ProjectController : Controller
	{
		private readonly IProjectService _projectService;

		public ProjectController(IProjectService projectService)
		{
			_projectService = projectService;
		}

		[HttpPost]
		[Route("AddProject")]
		public IActionResult AddProject([FromBody] Project project)
		{
			try
			{
				/*if (project == null)
					return StatusCode(StatusCodes.Status500InternalServerError);*/

				int result = _projectService.AddProject(project);

				if (result >= 1)
				{
					return StatusCode(StatusCodes.Status201Created);
				}
				else
				{
					return StatusCode(StatusCodes.Status500InternalServerError);
				}

			} catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status422UnprocessableEntity, ex);
			}
		}

		[HttpGet]
		[Route("GetAllProjects")]
		public IActionResult GetAllProjects()
		{
			try
			{
				var result = _projectService.GetAllProjectsDto();
				return new ObjectResult(result);

			} catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status204NoContent, ex);
			}

		}

		[HttpGet]
		[Route("GetProjectById/{projectId}")]
		public IActionResult GetProjectById(int projectId)
		{
			try
			{
				var project = _projectService.GetProjectById(projectId);
				if (project != null)
				{
					return new ObjectResult(project);
				}
				else
				{
					return StatusCode(StatusCodes.Status204NoContent);
				}
			} catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status422UnprocessableEntity, ex);
			}
		}

		[HttpPut]
		[Route("UpdateProject")]
		public IActionResult UpdateProject([FromBody] Project project)
		{

			try
			{
				if (project == null)
					return StatusCode(StatusCodes.Status500InternalServerError);

				var result = _projectService.UpdateProject(project);

				if(result == 1)
				{
					return StatusCode(StatusCodes.Status200OK);
				}
				else
				{
					return StatusCode(StatusCodes.Status500InternalServerError);
				}
			}catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status400BadRequest, ex);
			}
		}

		[HttpPut("UpdateProjectStatus/{projectId}")]
		public IActionResult UpdateProjectStatus(int projectId, [FromBody] int statusId)
		{
			try
			{
				var result = _projectService.UpdateProjectStatus(projectId, statusId);	
				if(result == 1)
				{
					return StatusCode(StatusCodes.Status200OK);
				}
				else
				{
					return StatusCode(StatusCodes.Status500InternalServerError);
				}
			}catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status400BadRequest, ex);
			}
		}


		[HttpGet]
		[Route("Category")]
		public IActionResult GetAllCategory()
		{
			try
			{
				var result = _projectService.GetAllCategory();
				return new ObjectResult(result);

			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status204NoContent, ex);
			}

		}

		[HttpGet]
		[Route("Department")]
		public IActionResult GetAllDepartment()
		{
			try
			{
				var result = _projectService.GetAllDepartment();
				return new ObjectResult(result);

			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status204NoContent, ex);
			}

		}

		[HttpGet]
		[Route("Division")]
		public IActionResult GetAllDivision()
		{
			try
			{
				var result = _projectService.GetAllDivision();
				return new ObjectResult(result);

			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status204NoContent, ex);
			}

		}

		[HttpGet]
		[Route("Location")]
		public IActionResult GetAllLocation()
		{
			try
			{
				var result = _projectService.GetAllLocation();
				return new ObjectResult(result);

			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status204NoContent, ex);
			}

		}

		[HttpGet]
		[Route("Priority")]
		public IActionResult GetAllPriority()
		{
			try
			{
				var result = _projectService.GetAllPriority();
				return new ObjectResult(result);

			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status204NoContent, ex);
			}

		}

		[HttpGet]
		[Route("Reason")]
		public IActionResult getAllReason()
		{
			try
			{
				var result = _projectService.getAllReason();
				return new ObjectResult(result);

			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status204NoContent, ex);
			}

		}

		[HttpGet]
		[Route("Types")]
		public IActionResult GetAllTypes()
		{
			try
			{
				var result = _projectService.GetAllTypes();
				return new ObjectResult(result);

			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status204NoContent, ex);
			}

		}


	}
}
