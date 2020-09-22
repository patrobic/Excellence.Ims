using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMS.Classes
{
    public class Item_Product : Base
    {

        public Item Items { get; set; }

        public Product Products { get; set; }

        public int Quantity { get; set; }

    }
}
