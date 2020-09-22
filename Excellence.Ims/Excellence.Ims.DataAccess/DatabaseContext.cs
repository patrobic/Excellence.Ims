using Excellence.Ims.DataAccess.Tables;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Item> Item { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductInfo> ProductInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Item>().ToTable("Item");
            //modelBuilder.Entity<Product>().ToTable("Product");
            //modelBuilder.Entity<ProductInfo>().ToTable("ProductInfo");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string str = Configuration.GetConnectionString("DefaultConnection");
            //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
            //{
            //    DataSource = "CORE-V1",
            //    InitialCatalog = "Excellence.Ims.Test",
            //    UserID = "excellence",
            //    Password = "excellence"
            //};

            //optionsBuilder.UseSqlServer(options);
        }
    }
}
