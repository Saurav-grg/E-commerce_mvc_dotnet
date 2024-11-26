using System.ComponentModel.DataAnnotations;

namespace Ecom_mvc.Models;
public class Product : BaseModel
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(200)]
        public required string Name { get; set; }
        public required string ImageUrl { get; set; }
        [Required]
        public required string Description { get; set; }

        [Required]
        public required decimal Price { get; set; }

        [Required]
        public int? StockQuantity { get; set; } = 0;
        [Required]
        [MaxLength(100)]
        public ProductCategory Category { get; set; }
        public enum ProductCategory
        {
            phones,cameras,computers,headphones,gaming
        }
        // Navigation properties
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
