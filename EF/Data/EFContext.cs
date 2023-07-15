using Pizza.Models;
using Microsoft.EntityFrameworkCore;

namespace Pizza.Data
{
    public class EFContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-00R7P8O\SQLEXPRESS; Database=WPFapplications; Integrated Security =True; TrustServerCertificate=True;");
        }
    }
}
