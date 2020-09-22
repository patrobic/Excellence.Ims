using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMS
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=EFCore-SchoolDB;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item_Product>().HasKey(sc => new { sc.ItemId, sc.ProductId });
            modelBuilder.Entity<PurchaseOrder_Item>().HasKey(sc => new { sc.PurchaseOrderId, sc.ItemId });
        }

        public virtual DbSet<Item> Items { get; set; }
        
        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Item_Product> Item_Product { get; set; }

        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }

    }
}
