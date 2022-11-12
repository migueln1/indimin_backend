using Indimin.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Indimin.Infrastructure.Data
{
    public class IndiminDbContext : DbContext
    {
        public IndiminDbContext(DbContextOptions oprions)
            :base(oprions) {}

        public DbSet<Citizen> Citizens => Set<Citizen>();
        public DbSet<DailyTask> Tasks => Set<DailyTask>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
