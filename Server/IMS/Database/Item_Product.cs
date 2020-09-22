using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMS
{
    public class Item_Product
    {

        public int ItemId { get; set; }

        public Item Item { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

    }
}
