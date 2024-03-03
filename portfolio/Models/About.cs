using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System.ComponentModel.DataAnnotations;

namespace portfolio.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string details { get; set; }
    }
}
