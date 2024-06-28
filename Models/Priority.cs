using System.ComponentModel.DataAnnotations;

namespace Techprimelab.Models
{
	public class Priority
	{
		[Key]
		public int PriorityId { get; set; }

		public string PriorityName { get; set; }
	}
}
