using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMS.Classes
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options)
        { }

        public virtual DbSet<Item> Items { get; set; }
        
        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Item_Product> Item_Product { get; set; }

        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }

    }
}
