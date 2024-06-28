using System.ComponentModel.DataAnnotations;

namespace Techprimelab.Models
{
	public class Status
	{
		[Key]
		public int StatusId { get; set; }

		public string StatusName { get; set; }
	}
}
