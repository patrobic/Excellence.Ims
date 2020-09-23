using Excellence.Ims.DataAccess.Tables.Supply;
using System;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Order
{
    public class SalesOrder : BaseOrder<SalesOrder, Product>
    {

    }

    public class SalesOrderLine : BaseOrderLine<SalesOrder, Product>
    {

    }
}
