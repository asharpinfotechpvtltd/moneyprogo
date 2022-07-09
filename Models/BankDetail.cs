using System.ComponentModel.DataAnnotations;

namespace moneyprogo.Models
{
	public class BankDetail
	{
		[Key]
		public int Id { get; set; }
		public string Code { get; set; }
		public string Bankname { get; set; }
		public string Accountholdername { get; set; }
		public string AccountNumber { get; set; }
		public string IFSCCODE { get; set; }
		public string BranchName { get; set; }
		public string BranchCode { get; set; }
	}
}
