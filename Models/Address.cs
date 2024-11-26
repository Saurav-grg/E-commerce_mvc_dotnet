using System.ComponentModel.DataAnnotations;
namespace Ecom_mvc.Models
{
    public class Address : BaseModel
    {
        [Key]
        public int AddressId { get; set; }

        public int UserId { get; set; }

        [Required]
        [MaxLength(200)]
        public required string AddressLine1 { get; set; }

        [MaxLength(200)]
        public string? AddressLine2 { get; set; }

        [Required]
        [MaxLength(100)]
        public required string City { get; set; }

        [Required]
        [MaxLength(100)]
        public required string State { get; set; }

        [Required]
        [MaxLength(20)]
        public required string ZipCode { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Country { get; set; }

        // Navigation property
        public required User User { get; set; }
    }
}