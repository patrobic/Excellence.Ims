using Excellence.Ims.DataAccess.Tables.Supply;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Order
{
    public class SalesOrderLine : BaseOrderLine
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public SalesOrder Order { get; set; }
        public int OrderId { get; set; }
    }
}
