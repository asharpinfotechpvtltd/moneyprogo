using System.ComponentModel.DataAnnotations;

namespace moneyprogo.Models
{
	public class Removedcoinslog
	{
		[Key]
		public int Id { get; set; }
		public string code { get; set; }
		public int coins { get; set; }
		public DateTime purchaseddate { get; set; }
		public DateTime currentdate { get; set; }
	}
}
