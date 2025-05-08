using DotNetCoreWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreWebAPI.Repositories
{
    public class DotNetCoreWebAPIDBContext : DbContext
    {
        public DotNetCoreWebAPIDBContext(DbContextOptions<DotNetCoreWebAPIDBContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<UserModel> Users { get; set; } = null!;
    }
}
