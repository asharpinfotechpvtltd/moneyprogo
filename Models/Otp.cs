using System.ComponentModel.DataAnnotations;

namespace moneyprogo.Models
{
    public class Otp
    {
        [Key]
        public int ID { get; set; }
        public int OTP { get; set; }
        public string Code { get; set; }
        public string FranchiseCode { get; set; }
        public double Amount { get; set; }
    }
}

