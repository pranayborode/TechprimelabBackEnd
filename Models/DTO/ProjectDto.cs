using System.ComponentModel.DataAnnotations.Schema;

namespace Techprimelab.Models.DTO
{
	public class ProjectDto
	{
		public int ProjectId { get; set; }

		public string ProjectName { get; set; }

		public int ReasonId { get; set; }
		public string ReasonName { get; set; }

		public int TypeId { get; set; }
		public string TypeName { get; set; }

		public int DivisionId { get; set; }
		public string DivisionName { get; set; }

		public int CategoryId { get; set; }
		public string CategoryName { get; set; }

		public int PriorityId { get; set; }
		public string PriorityName { get; set; }

		public int DepartmentId { get; set; }
		public string DepartmentName { get; set; }

		public int LocationId { get; set; }
		public string LocationName { get; set; }

		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public int StatusId { get; set; }
		public string StatusName { get; set; }

	}
}
