using Excellence.Ims.DataAccess.Tables.Supply;
using System;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Property
{
    public class Category : BaseName
    {
        public virtual ICollection<Product> Products { get; set; }
    }
}
