using System.ComponentModel.DataAnnotations;
namespace Ecom_mvc.Models
{
 public class OrderItem : BaseModel
    {
        [Key]
        public int OrderItemId { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        // Navigation properties
        public required Order Order { get; set; }
        public required Product Product { get; set; }
    }}