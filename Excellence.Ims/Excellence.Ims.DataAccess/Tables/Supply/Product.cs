using Excellence.Ims.DataAccess.Tables;
using Excellence.Ims.DataAccess.Tables.Property;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Text;
using Attribute = Excellence.Ims.DataAccess.Tables.Property.Attribute;

namespace Excellence.Ims.DataAccess.Tables.Supply
{
    public class Product : BaseNamed
    {
        public string Sku { get; set; }
        public Type Type { get; set; }
        //[ForeignKey("Id")]
        //public Product? Parent { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        public ProductInfo ProductInfo { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Attribute> Attributes { get; set; }
        public ICollection<Tag> Tags { get; set; }



        public ICollection<Item> Item { get; set; }
        public ICollection<Product> UpSells { get; set; }
        public ICollection<Product> CrossSells { get; set; }
    }
}
