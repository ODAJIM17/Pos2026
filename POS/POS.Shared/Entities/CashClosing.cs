using System.ComponentModel.DataAnnotations;

namespace POS.Shared.Entities
{
    public class CashClosing
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal InitialBalance { get; set; }
        public decimal TotalCash { get; set; }
        public decimal TotalCard { get; set; }
        public decimal TotalCheck { get; set; }
        public decimal TotalAdjustment { get; set; }
        public decimal FinalBalance { get; set; }
        public decimal FinalCash { get; set; }
        public User User { get; set; } = null!;
        public int UserId { get; set; }

        [MaxLength(150, ErrorMessage = "Field {0} can not exceed {1} characters")]
        public string Notes { get; set; } = string.Empty;
    }
}