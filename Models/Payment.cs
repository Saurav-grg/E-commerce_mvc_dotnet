using System.ComponentModel.DataAnnotations;
namespace Ecom_mvc.Models
{
    public class Payment : BaseModel
    {
        [Key]
        public int PaymentId { get; set; }

        public int OrderId { get; set; }

        [Required]
        [MaxLength(50)]
        public string PaymentMethod { get; set; }

        [Required]
        [MaxLength(100)]
        public string TransactionId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public PaymentStatus Status { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        // Navigation property
        public Order Order { get; set; }
    }

    public enum PaymentStatus
    {
        Pending,
        Success,
        Failed
    }
}