using Excellence.Ims.DataAccess.Tables.Supply;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Order
{
    public class ManufactureOrderLine : BaseOrderLine
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public ManufactureOrder Order { get; set; }
        public int OrderId { get; set; }
    }
}
