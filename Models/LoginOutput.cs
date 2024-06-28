namespace Techprimelab.Models
{
	public class LoginOutput
	{
		public int UserId { get; set; }
		public string? UserEmail { get; set; }
		public string? Password { get; set; }
		public string? Token { get; set; }
	}
}
