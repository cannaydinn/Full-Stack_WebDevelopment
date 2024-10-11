using Microsoft.EntityFrameworkCore;
using Survivor.Entities;

namespace Survivor.Context
{
    public class SurvivorDbContext : DbContext
    {
        public SurvivorDbContext(DbContextOptions<SurvivorDbContext> options) : base(options) 
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryEntitiy>().HasMany(x => x.Competitors).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<CategoryEntitiy> Categories => Set<CategoryEntitiy>();
        public DbSet<CompetitorEntitiy> Competitors => Set<CompetitorEntitiy>();
    }
}
