using System.ComponentModel.DataAnnotations;

namespace moneyprogo.Models
{
	public class Notice
	{
		[Key]
		public int Id { get; set; }
		public string Message { get; set; }
	}
}
