using System.ComponentModel.DataAnnotations;

namespace moneyprogo.Models
{
	public class Coins
	{
		[Key]
		public int ID { get; set; }
		public string Code { get; set; }
		public int TotalCoins { get; set; }
	}
}
