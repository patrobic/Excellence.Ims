using Excellence.Ims.DataAccess.Tables;
using Excellence.Ims.DataAccess.Tables.Property;
using Excellence.Ims.DataAccess.Tables.Retail;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Text;
using Attribute = Excellence.Ims.DataAccess.Tables.Property.Attribute;
using Type = Excellence.Ims.DataAccess.Tables.Retail.Type;

namespace Excellence.Ims.DataAccess.Tables.Supply
{
    public class Product : BaseNamed
    {
        public string Sku { get; set; }
        public Type Type { get; set; }
        public Product Parent { get; set; }
        public virtual ICollection<Product> Children { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        public ProductInfo ProductInfo { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Attribute> Attributes { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }

       // public int Item_ProductId { get; set; }
        public virtual ICollection<Item_Product> Item_Product { get; set; }

        public virtual ICollection<Item> Item { get; set; } // REMOVE?
        public virtual ICollection<Product> UpSoldBy { get; set; }
        public virtual ICollection<Product> UpSells { get; set; }
        public virtual ICollection<Product> CrossSoldBy { get; set; }
        public virtual ICollection<Product> CrossSells { get; set; }
    }
}
