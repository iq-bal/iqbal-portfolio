using System.ComponentModel.DataAnnotations;

namespace portfolio.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0,100)]
        public int ProficiencyLevel { get; set; }
    }
}
