using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Techprimelab.Models
{
	[Table("Reasons")]
	public class Reason
	{
		[Key]
		
		public int ReasonId { get; set; }

		public string ReasonName { get; set;}
	}
}
