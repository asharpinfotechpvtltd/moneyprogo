using System.ComponentModel.DataAnnotations;

namespace moneyprogo.Models
{
	public class CoinsLog
	{
		[Key]
		public int ID { get; set; }
		public string Code { get; set; }
		public int Coins { get; set; }
		public DateTime date{get;set;}
}
}
