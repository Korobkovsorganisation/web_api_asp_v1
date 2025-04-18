using System.Collections.Generic;
using System.Reflection.Emit;
using web_api_asp_v1.Models;
using Microsoft.EntityFrameworkCore;

namespace web_api_asp_v1.Data
{
    // StoreContext.cs
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.UserID)
                .UseIdentityColumn();
            // Настройка связей и ограничений
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}
