using System.ComponentModel.DataAnnotations;

namespace Ecom_mvc.Models;
public class Product : BaseModel
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int StockQuantity { get; set; }

        [Required]
        [MaxLength(100)]
        public string CategoryName { get; set; } = "uncategorized";

        // Navigation properties
        public ICollection<OrderItem> OrderItems { get; set; }
    }
