using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Techprimelab.Models
{
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
	}
}
