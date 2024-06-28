using System.ComponentModel.DataAnnotations;

namespace Techprimelab.Models
{
	public class Types
	{
		[Key]
		public int TypeId { get; set; }

		public string TypeName { get; set; }
	}
}
