using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Techprimelab.Models
{
	[Table("Statuses")]
	public class Status
	{
		[Key]
		public int StatusId { get; set; }

		public string StatusName { get; set; }
	}
}
