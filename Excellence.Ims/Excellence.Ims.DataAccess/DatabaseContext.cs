using Excellence.Ims.DataAccess.Tables;
using Excellence.Ims.DataAccess.Tables.Contact;
using Excellence.Ims.DataAccess.Tables.Order;
using Excellence.Ims.DataAccess.Tables.Property;
using Excellence.Ims.DataAccess.Tables.Storage;
using Excellence.Ims.DataAccess.Tables.Supply;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

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

            builder.Entity<PurchaseOrderLine>().HasOne(x => x.Order).WithMany(x => x.Lines).HasForeignKey(x => x.OrderId);
            builder.Entity<ManufactureOrderLine>().HasOne(x => x.Order).WithMany(x => x.Lines).HasForeignKey(x => x.OrderId);
            builder.Entity<SalesOrderLine>().HasOne(x => x.Order).WithMany(x => x.Lines).HasForeignKey(x => x.OrderId);

            builder.Entity<Item_Product>().HasOne(x => x.Item).WithMany(x => x.Item_Product).HasForeignKey(x => x.ItemId);
            builder.Entity<Item_Product>().HasOne(x => x.Product).WithMany(x => x.Item_Product).HasForeignKey(x => x.ProductId);
            builder.Entity<Item>().HasMany(x => x.Item_Product).WithOne(x => x.Item).HasForeignKey(x => x.ItemId);
            builder.Entity<Product>().HasMany(x => x.Item_Product).WithOne(x => x.Product).HasForeignKey(x => x.ProductId);

            // Direct Item-Product Linkage
            builder.Entity<Product>().HasMany(x => x.Item).WithMany(x => x.Product); // Forward
            builder.Entity<Item>().HasMany(x => x.Product).WithMany(x => x.Item); // Reverse (probably redundant)

            builder.Entity<Item_Product>().HasKey(p => new { p.ItemId, p.ProductId}).HasName("Id");
            builder.Entity<PurchaseOrderLine>().HasKey(p => new { p.OrderId, p.ItemId }).HasName("Id");
            builder.Entity<ManufactureOrderLine>().HasKey(p => new { p.OrderId, p.ProductId }).HasName("Id");
            builder.Entity<SalesOrderLine>().HasKey(p => new { p.OrderId, p.ProductId }).HasName("Id");

            builder.Entity<Product>().HasOne(x => x.Parent).WithMany(x => x.Children);
            builder.Entity<Product>().HasMany(x => x.CrossSoldBy).WithMany(x => x.CrossSells);
            builder.Entity<Product>().HasMany(x => x.UpSoldBy).WithMany(x => x.UpSells);

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
