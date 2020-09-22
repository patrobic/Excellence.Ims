using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMS
{
    public class Item
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public IList<PurchaseOrder_Item> PurchaseOrder_Items { get; set; }

    }
}
