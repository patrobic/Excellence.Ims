using Excellence.Ims.DataAccess.Tables;
using Excellence.Ims.DataAccess.Tables.Contact;
using Excellence.Ims.DataAccess.Tables.Order;
using Excellence.Ims.DataAccess.Tables.Property;
using Excellence.Ims.DataAccess.Tables.Storage;
using Excellence.Ims.DataAccess.Tables.Supply;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Excellence.Ims.DataAccess
{
    public class DatabaseContext : IdentityDbContext
    {
        public DatabaseContext()
        {

        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=blog.db");

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<BaseOrderLine>().HasKey(p => new { p.Order, p.Product });

            builder.Entity<PurchaseOrderLine>().HasKey(p => new { p.Order, p.Product });
            builder.Entity<ManufactureOrderLine>().HasKey(p => new { p.Order, p.Product });
            builder.Entity<SalesOrderLine>().HasKey(p => new { p.Order, p.Product });
        }

        // Supply
        public DbSet<Item> Item { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductInfo> ProductInfo { get; set; }

        // Order
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<ManufactureOrder> ManufactureOrder { get; set; }
        public DbSet<SalesOrder> SalesOrder { get; set; }

        public DbSet<PurchaseOrderLine> PurchaseOrderLine { get; set; }
        public DbSet<ManufactureOrderLine> ManufactureOrderLine { get; set; }
        public DbSet<SalesOrderLine> SalesOrderLine { get; set; }

        // Contact
        public DbSet<Client> Client { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Supplier> Supplier { get; set; }

        // Property
        public DbSet<Attribute> Attribute { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Category> Category { get; set; }

        // Storage
        public DbSet<Location> Location { get; set; }
    }

}
