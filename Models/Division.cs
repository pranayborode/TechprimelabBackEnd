using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Techprimelab.Models
{
	[Table("Divisions")]
	public class Division
	{
		[Key]
		public int DivisionId { get; set; }

		public string DivisionName { get; set;}
	}
}
