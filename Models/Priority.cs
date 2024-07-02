using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Techprimelab.Models
{
	[Table("Priorities")]
	public class Priority
	{
		[Key]
		public int PriorityId { get; set; }

		public string PriorityName { get; set; }
	}
}
