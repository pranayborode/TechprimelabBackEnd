using System.ComponentModel.DataAnnotations;

namespace Techprimelab.Models
{
	public class User
	{
		[Key]
		public int UserId { get; set; }
		public string UserEmail { get; set; }
		public string Password { get; set; }

	}
}
