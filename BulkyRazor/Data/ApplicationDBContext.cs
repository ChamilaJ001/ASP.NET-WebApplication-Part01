using BulkyRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyRazor.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Comedy", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Action", DisplayOrder = 2 }
                );
        }
    }
}
