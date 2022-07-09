using System.ComponentModel.DataAnnotations;

namespace moneyprogo.Models
{
	public class Profit
	{
		[Key]
		public int Id { get; set; }
		public double TotalProfit { get; set; }
		public DateTime date{get;set;}
		public string Code { get; set; }
}
}
