using Excellence.Ims.DataAccess.Tables.Contact;
using Excellence.Ims.DataAccess.Tables.Misc;
using Excellence.Ims.DataAccess.Tables.Supply;
using System;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Order
{
    public class PurchaseOrder : BaseOrder
    {
        public virtual ICollection<PurchaseOrderLine> Lines { get; set; }
        public Supplier Supplier { get; set; }
        public Project Project { get; set; }
    }
}
