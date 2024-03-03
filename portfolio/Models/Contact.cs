using System.ComponentModel.DataAnnotations;

namespace portfolio.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }

        public string Message { get; set; }
    }
}
