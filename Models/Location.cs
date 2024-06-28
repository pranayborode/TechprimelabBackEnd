using System.ComponentModel.DataAnnotations;

namespace Techprimelab.Models
{
	public class Location
	{
		[Key]
		public int LocationId { get; set; }

		public string LocationName { get; set; }
	}
}
