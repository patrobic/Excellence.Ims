using Excellence.Ims.DataAccess.Tables.Supply;
using System;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Order
{
    public class PurchaseOrder : BaseOrder<PurchaseOrder, Item>
    {

    }

    public class PurchaseOrderLine : BaseOrderLine<PurchaseOrder, Item>
    {

    }
}
