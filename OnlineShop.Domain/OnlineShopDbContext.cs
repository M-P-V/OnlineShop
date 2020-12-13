using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain.Models;

namespace OnlineShop.Domain
{
    public class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        
        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Attribute> Attributes { get; set; }

        public DbSet<AttributeValue> AttributeValues { get; set; }
    }
}
