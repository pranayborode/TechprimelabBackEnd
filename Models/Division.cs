using System.ComponentModel.DataAnnotations;

namespace Techprimelab.Models
{
	public class Division
	{
		[Key]
		public int DivisionId { get; set; }

		public string DivisionName { get; set;}
	}
}
