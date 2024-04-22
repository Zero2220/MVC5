using Eterna.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectImage> ProjectImages { get; set; }

        public DbSet<Slide> Slides { get; set; }
    }
}
