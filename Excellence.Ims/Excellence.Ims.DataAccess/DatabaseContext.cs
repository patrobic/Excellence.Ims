using Excellence.Ims.DataAccess.Tables;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Excellence.Ims.DataAccess
{
    public class DatabaseContext : IdentityDbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Item { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductInfo> ProductInfo { get; set; }
    }
}
