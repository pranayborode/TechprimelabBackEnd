	namespace Techprimelab.Models.DTO
{
	public class DepartmentSuccessDto
	{
		public string DepartmentName { get; set; }
		public int TotalProjects { get; set; }
		public int TotalProjectsClosed { get; set; }
		public double SuccessPercentage { get; set; }
	}
}
