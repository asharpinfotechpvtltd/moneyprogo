using System.ComponentModel.DataAnnotations;

namespace moneyprogo.Models
{
    public class ProfitLog
    {
        [Key]
        public int ID { get; set; }
        public double TotalProfit { get; set; }
        public DateTime date { get; set; }

    }
}
