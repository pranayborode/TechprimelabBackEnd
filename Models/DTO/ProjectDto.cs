using System.ComponentModel.DataAnnotations.Schema;

namespace Techprimelab.Models.DTO
{
	public class ProjectDto
	{
		public int ProjectId { get; set; }

		public string ProjectName { get; set; }

		public int ReasonId { get; set; }

		public int TypeId { get; set; }

		public int DivisionId { get; set; }

		public int CategoryId { get; set; }

		public int PriorityId { get; set; }

		public int DepartmentId { get; set; }

		public int LocationId { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public int StatusId { get; set; }

		[ForeignKey("ReasonId")]
		public Reason Reason { get; set; }

		[ForeignKey("TypeId")]
		public Types Types { get; set; }

		[ForeignKey("DivisionId")]
		public Division Division { get; set; }

		[ForeignKey("CategoryId")]
		public Category Category { get; set; }

		[ForeignKey("PriorityId")]
		public Priority Priority { get; set; }

		[ForeignKey("DepartmentId")]
		public Department Department { get; set; }

		[ForeignKey("LocationId")]
		public Location Location { get; set; }

		[ForeignKey("StatusId")]
		public Status Status { get; set; }
	}
}
