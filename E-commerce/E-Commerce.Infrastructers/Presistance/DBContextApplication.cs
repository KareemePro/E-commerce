using E_Commerce.Domian;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Infrastructers.Presistance
{
    public class DBContextApplication:DbContext
    {
        public DBContextApplication(DbContextOptions<DBContextApplication> options) : base(options) 
        { 
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

    }
}
