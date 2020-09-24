using Excellence.Ims.DataAccess.Tables.Order;
using Excellence.Ims.DataAccess.Tables.Retail;
using Excellence.Ims.DataAccess.Tables.Storage;
using Excellence.Ims.DataAccess.Tables.Supply;
using Microsoft.EntityFrameworkCore;

namespace Excellence.Ims.DataAccess
{
    public class DbLinker
    {
        private ModelBuilder _builder;

        public DbLinker(ModelBuilder builder)
        {
            _builder = builder;
        }

        public void LinkDb()
        {
            OrderLinking();
            ProductLinking();
   
            OnModelCreatingEnums();
        }

        private void OrderLinking()
        {
            _builder.Entity<PurchaseOrderLine>().HasOne(x => x.Order).WithMany(x => x.Lines).HasForeignKey(x => x.OrderId);
            _builder.Entity<ManufactureOrderLine>().HasOne(x => x.Order).WithMany(x => x.Lines).HasForeignKey(x => x.OrderId);
            _builder.Entity<SalesOrderLine>().HasOne(x => x.Order).WithMany(x => x.Lines).HasForeignKey(x => x.OrderId);

            _builder.Entity<PurchaseOrderLine>().HasKey(p => new { p.OrderId, p.ItemId }).HasName("Id");
            _builder.Entity<ManufactureOrderLine>().HasKey(p => new { p.OrderId, p.ProductId }).HasName("Id");
            _builder.Entity<SalesOrderLine>().HasKey(p => new { p.OrderId, p.ProductId }).HasName("Id");
        }

        private void ProductLinking()
        {
            _builder.Entity<Product>().HasOne(x => x.Parent).WithMany(x => x.Children);
            _builder.Entity<Product>().HasMany(x => x.CrossSoldBy).WithMany(x => x.CrossSells);
            _builder.Entity<Product>().HasMany(x => x.UpSoldBy).WithMany(x => x.UpSells);

            _builder.Entity<Bundling>().HasOne(x => x.Item).WithMany(x => x.Bundling).HasForeignKey(x => x.ItemId);
            _builder.Entity<Bundling>().HasOne(x => x.Product).WithMany(x => x.Bundling).HasForeignKey(x => x.ProductId);

            _builder.Entity<Location>().HasOne(x => x.Parent).WithMany(x => x.Children);

            //_builder.Entity<Item>().HasMany(x => x.Bundling).WithOne(x => x.Item).HasForeignKey(x => x.ItemId);
            //_builder.Entity<Product>().HasMany(x => x.Bundling).WithOne(x => x.Product).HasForeignKey(x => x.ProductId);

            // Direct Item-Product Linkage
            //_builder.Entity<Product>().HasMany(x => x.Item).WithMany(x => x.Product); // Forward
            //_builder.Entity<Item>().HasMany(x => x.Product).WithMany(x => x.Item); // Reverse (probably redundant)

            // set Composity Key for Bundling Table
            _builder.Entity<Bundling>().HasKey(x => new { x.ItemId, x.ProductId }).HasName("Id");

            // Configure Table Splitting/Vertical Partitionning mapping between Product & ProductInfo
            _builder.Entity<Product>().HasOne(x => x.ProductInfo).WithOne().HasForeignKey<ProductInfo>(x => x.Id);
        }

        private void OnModelCreatingEnums()
        {
            _builder.Entity<Product>().Property(e => e.Type).HasConversion(x => (int)x, x => (Type)x);
        }

    }
}
