using Excellence.Ims.DataAccess.Tables.Property;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Supply
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; } // TODO change to Category table type
        public virtual ICollection<Product> Product { get; set; }

    }
}
