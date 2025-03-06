using System.ComponentModel.DataAnnotations;

namespace UnitedBanking.Models
{
    public class Balance
    {
        public int BalanceId { get; set; }
        public int BalanceAmount { get; set; }
        public int TransactionAmount { get; set; }
        public int TransactionName { get; set; }
        
        [Required]
        [DataType (DataType.Date)]
        public int TransactionDate { get; set; }
    }

}
