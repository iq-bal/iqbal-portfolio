using System.ComponentModel.DataAnnotations;

namespace portfolio.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string ImageUrl { get; set; }

        public string GithubUrl { get; set; }
    }
}
