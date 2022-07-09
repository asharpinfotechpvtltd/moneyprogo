using System.ComponentModel.DataAnnotations;

namespace moneyprogo.Models
{
	public class AdminLogin
	{
        [Key]
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
	}
}
