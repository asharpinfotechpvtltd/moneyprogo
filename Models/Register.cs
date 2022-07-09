using System.ComponentModel.DataAnnotations;

namespace moneyprogo.Models
{
	public class Register
	{
		[Key]
		public int Id { get; set; }
		public string Code { get; set; }
		public string TeamCode { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Mobile { get; set; }
		public string Password { get; set; }
		public string Address { get; set; }
		public DateTime Date { get; set; }
		public string Status { get; set; }
		public int Franchise { get; set; }
	}
}
