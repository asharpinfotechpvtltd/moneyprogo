using System.ComponentModel.DataAnnotations;

namespace moneyprogo.Models
{
	public class Withdrawal
	{
		[Key]
		public int Id { get; set; }
		public string Code { get; set; }
		public string WithdrawalAmount { get; set; }
		public string Status { get; set; }
		public DateTime date { get; set; }
		public string BankName { get; set; }
	}
}
