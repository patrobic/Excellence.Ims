using Excellence.Ims.DataAccess.Tables.Supply;
using System;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Order
{
    public class ManufactureOrder : BaseOrder<ManufactureOrder, Product>
    {

    }

    public class ManufactureOrderLine : BaseOrderLine<ManufactureOrder, Product>
    {

    }
}
