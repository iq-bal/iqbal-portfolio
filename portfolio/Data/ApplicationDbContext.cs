using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using portfolio.Models;

namespace portfolio.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        public DbSet<About> About { get; set; }
        public DbSet<Skill> Skills { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Contact> Contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<About>().HasData(
                new Models.About { Id = 1, email = "moon2007093@stud.kuet.ac.bd", title = "CS Undergrad, Minimalist, Love to read", details = "I'm a CS undergrad who finds joy in coding. I like keeping things simple, turning complex problems into clean lines of logic. In the world of bits and bytes, I'm on a mission to make technology elegant and efficient.\r\n\r\nWhen I'm not immersed in code, I'm immersed in books. I love the simplicity of a well-crafted sentence as much as I love a clean piece of code. In a nutshell, a minimalist navigating the worlds of logic and language." }
            );

            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, Name = "C#", ProficiencyLevel = 4 },
                new Skill { Id = 2, Name = "JavaScript", ProficiencyLevel = 3 }
            );

            modelBuilder.Entity<Project>().HasData(
                new Project { Id = 1, Title = "Virtual CR", ImageUrl = "https://raw.githubusercontent.com/iq-bal/portfolio/master/assets/dp-bw.jpeg", 
                GithubUrl="https://github.com"
                }
            );
        }
    }
}
