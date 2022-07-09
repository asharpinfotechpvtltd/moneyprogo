using System.ComponentModel.DataAnnotations;

namespace moneyprogo.Models
{
	public class Point
	{
		[Key]
		public int Id { get; set; }
		public string Code { get; set; }
		public double Points { get; set; }
		public string Earnedfrom { get; set; }
		public DateTime date{get;set;}
}
}
