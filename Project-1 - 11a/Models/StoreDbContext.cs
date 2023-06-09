

using System.Data.Entity;

namespace Project_1___11a.Model
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public StoreDbContext() : base("StoreDbContext")
        {

        }
    }
}
