using Microsoft.EntityFrameworkCore;
using MyFirstDb.Entities;

namespace MyFirstDb.Context
{
    public class PatikaFirstDbContext : DbContext
    {
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options)
        {

        }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // windows authentication
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-BR8RA9E\SQLEXPRESS ; database=PatikaCodeFirstDb1; TrustServerCertificate= true; trusted_connection = true;");

            // sql server
            //optionsBuilder.UseSqlServer(@"Server= ; database=PatikaCodeFirstDb1; TrustServerCertificate= true; uid=sa; pwd=sa; trusted_connection = true;");
            base.OnConfiguring(optionsBuilder);
        }
        */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<MovieEntity> Movies => Set<MovieEntity>();
        public DbSet<GameEntity> Games => Set<GameEntity>();
    }
}
