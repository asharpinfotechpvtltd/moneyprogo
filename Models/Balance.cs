using System.ComponentModel.DataAnnotations;

namespace moneyprogo.Models
{
	public class Balance
	{
		[Key]
		public int Id { get; set; }
		public string Code { get; set; }
		public double Amount { get; set; }
		public DateTime date{get;set;}
}
}
