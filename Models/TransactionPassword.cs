using System.ComponentModel.DataAnnotations;

namespace moneyprogo.Models
{
	public class TransactionPassword
	{
		[Key]
		public int Id { get; set; }
		public string Code { get; set; }
		public string Password { get; set; }
	}
}
