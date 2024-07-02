using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Techprimelab.Models
{
	[Table("Locations")]
	public class Location
	{
		[Key]
		public int LocationId { get; set; }

		public string LocationName { get; set; }
	}
}
