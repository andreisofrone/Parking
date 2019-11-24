using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Domain.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

       // public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {                
                //TODO: MOVE THIS TO appsettings.json
                optionsBuilder.UseSqlServer("Server=DESKTOP-94M20HI\\SQLEXPRESS;Database=Parking;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
