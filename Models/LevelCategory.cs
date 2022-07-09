using System.ComponentModel.DataAnnotations;

namespace moneyprogo.Models
{
	public class LevelCategory
	{
		[Key]
		public int Id { get; set; }
		public string Code { get; set; }
		public string Levels { get; set; }
	}
}
