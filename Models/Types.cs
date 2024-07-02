using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Techprimelab.Models
{
	[Table("Types")]
	public class Types
	{
		[Key]
		public int TypeId { get; set; }

		public string TypeName { get; set; }
	}
}
