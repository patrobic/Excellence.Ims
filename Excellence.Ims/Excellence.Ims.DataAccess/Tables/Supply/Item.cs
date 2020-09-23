using Excellence.Ims.DataAccess.Tables.Property;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Supply
{
    public class Item : Base
    {
        public Category Category { get; set; } // TODO change to Category table type
        public virtual ICollection<Product> Product { get; set; } // REMOVE?

        // public int Item_ProductId { get; set; }
        public virtual ICollection<Item_Product> Item_Product { get; set; }
    }
}
