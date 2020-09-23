using Excellence.Ims.DataAccess.Tables.Supply;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Order
{
    public class PurchaseOrderLine : BaseOrderLine
    {
        public Item Item { get; set; }
        public int ItemId { get; set; }
        public PurchaseOrder Order { get; set; }
        public int OrderId { get; set; }
    }
}
