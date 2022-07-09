using System.ComponentModel.DataAnnotations;

namespace moneyprogo.Models
{
	public class SendEcash
	{
		[Key]
		public int Id { get; set; }
		public string Code { get; set; }
		public double Amount { get; set; }
	}
}
