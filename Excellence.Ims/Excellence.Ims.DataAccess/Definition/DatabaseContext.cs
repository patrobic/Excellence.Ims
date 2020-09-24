using Excellence.Ims.DataAccess.Tables;
using Excellence.Ims.DataAccess.Tables.Contact;
using Excellence.Ims.DataAccess.Tables.Order;
using Excellence.Ims.DataAccess.Tables.Property;
using Excellence.Ims.DataAccess.Tables.Retail;
using Excellence.Ims.DataAccess.Tables.Storage;
using Excellence.Ims.DataAccess.Tables.Supply;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AttributeValue = Excellence.Ims.DataAccess.Tables.Property.AttributeValue;
using Type = Excellence.Ims.DataAccess.Tables.Retail.Type;

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
            
            DbLinker dbLinker = new DbLinker(builder);
            dbLinker.LinkDb();

            DbInitializer dbInitializer = new DbInitializer(this);
            dbInitializer.Initialize();
        }

        #region Supply

        public DbSet<Item> Item { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductInfo> ProductInfo { get; set; }
        public DbSet<Bundling> Bundling { get; set; } // Many-To-Many Join Table

        #endregion

        #region Order

        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<ManufactureOrder> ManufactureOrder { get; set; }
        public DbSet<SalesOrder> SalesOrder { get; set; }

        public DbSet<PurchaseOrderLine> PurchaseOrderLine { get; set; }
        public DbSet<ManufactureOrderLine> ManufactureOrderLine { get; set; }
        public DbSet<SalesOrderLine> SalesOrderLine { get; set; }

        #endregion

        #region Contact

        public DbSet<Client> Client { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Supplier> Supplier { get; set; }

        #endregion

        #region Property

        public DbSet<Category> Category { get; set; }
        public DbSet<AttributeKey> AttributeName { get; set; }
        public DbSet<AttributeValue> AttributeValue { get; set; }
        public DbSet<Tag> Tag { get; set; }

        #endregion

        #region Storage
        public DbSet<Location> Location { get; set; }

        #endregion

        #region Retail

        //public DbSet<Type> Type { get; set; }
        public DbSet<ShippingClass> ShippingClass { get; set; }
        public DbSet<Warranty> Warranty { get; set; }

        #endregion
    }
}
