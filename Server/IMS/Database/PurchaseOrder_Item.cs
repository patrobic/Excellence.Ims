using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMS
{
    public class PurchaseOrder_Item
    {

        public int PurchaseOrderId { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

    }
}
