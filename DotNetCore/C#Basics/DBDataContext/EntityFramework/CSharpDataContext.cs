using C_Basics.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace C_Basics.DBDataContext.EntityFramework
{
    public class CSharpDataContext : DbContext
    {
        public CSharpDataContext(DbContextOptions<CSharpDataContext> options)
            : base(options)
        {
        }
        public CSharpDataContext()
        {
            
        }

        // Define DbSet properties for your entities
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<UserModel> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure entity relationships, constraints, etc.
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductId);
                entity.Property(e => e.ProductName).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<UserModel>(entity =>
            {
                entity.HasKey(e => e.UserId);
                entity.Property(e => e.UserName).IsRequired().HasMaxLength(50);
            });
        }
    }
}
