using Excellence.Ims.DataAccess.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Text;

namespace Excellence.Ims.DataAccess
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Sku { get; set; }
        //public Type Type { get; set; }
        public Product? Parent { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        public ICollection<Item> Item { get; set; }
    }
}
