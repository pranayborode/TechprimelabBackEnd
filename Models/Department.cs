using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Techprimelab.Models
{
	[Table("Departments")]
	public class Department
	{
		[Key]
		public int DepartmentId { get; set; }

		public string DepartmentName { get; set; }
	}
}
