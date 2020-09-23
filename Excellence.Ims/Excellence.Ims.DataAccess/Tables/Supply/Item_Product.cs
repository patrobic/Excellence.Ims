using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Supply
{
    public class Item_Product
    {
        [Key]
        public ICollection<Item> Item { get; set; }
        [Key]
        public ICollection<Product> Product { get; set; }
    }
}
