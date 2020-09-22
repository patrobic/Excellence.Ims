using System;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Product> Product { get; set; }

    }
}
