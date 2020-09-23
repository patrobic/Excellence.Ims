using Excellence.Ims.DataAccess.Tables.Property;
using Excellence.Ims.DataAccess.Tables.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Supply
{
    public class Item : BaseDescDate
    {
        public Category Category { get; set; }
        public Location Location { get; set; }

        public virtual ICollection<Item_Product> Item_Product { get; set; }
    }
}
