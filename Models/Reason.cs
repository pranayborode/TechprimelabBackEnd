using System.ComponentModel.DataAnnotations;

namespace Techprimelab.Models
{
	public class Reason
	{
		[Key]
		public int ReasonId { get; set; }

		public string ReasonName { get; set;}
	}
}
