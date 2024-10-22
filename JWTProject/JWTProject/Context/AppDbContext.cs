using JWTProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace JWTProject.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<UserEntity> Users => Set<UserEntity>();

    }
}
