using System;
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

        public string Status { get; set; }

        public int ShippingAddressId { get; set; }

        public int BillingAddressId { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}