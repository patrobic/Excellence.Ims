using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims.Data
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
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
