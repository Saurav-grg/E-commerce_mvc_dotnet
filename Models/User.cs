using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Ecom_mvc.Models
{
    public class User : BaseModel
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(256)]
        public string FirebaseUserId { get; set; }

        [Required]
        [MaxLength(256)]
        public string Email { get; set; }

        public string Name { get; set; }

        public string ProfilePictureUrl { get; set; }

        // Navigation properties
        public ICollection<Order> Orders { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}