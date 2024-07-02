using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Techprimelab.Models
{
	public class Project
	{
		[Key]
		public int ProjectId { get; set; }

		public string ProjectName { get; set; }

		public int ReasonId { get; set; }

		public int TypeId { get; set; }

		public int DivisionId { get; set; }

		public int CategoryId { get; set; }

		public int PriorityId { get; set; }

		public int DepartmentId { get; set; }

		public int LocationId { get; set;}

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public int StatusId { get; set; }

	}
}
