using System.ComponentModel.DataAnnotations;
namespace Ecom_mvc.Models
{
    public class Order : BaseModel
    {
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }

        public OrderStatus Status { get; set; }
        public enum OrderStatus { Pending, Processing, Shipped, Delivered, Cancelled }
        public int ShippingAddressId { get; set; }

        public int BillingAddressId { get; set; }

        // Navigation properties
        public required User User { get; set; }
        public required Address ShippingAddress { get; set; }
        public required Address BillingAddress { get; set; }
        public required ICollection<OrderItem> OrderItems { get; set; }
        public required ICollection<Payment> Payments { get; set; }
    }
}