using DependencyInjectionProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace DependencyInjectionProject.Context
{
    public class TeacherDbContext : DbContext
    {
        public TeacherDbContext(DbContextOptions<TeacherDbContext> options) : base(options)
        {

        }

        public DbSet<Teacher> Teachers => Set<Teacher>();
    }
}
}
