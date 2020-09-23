using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Order
{
    public abstract class BaseOrder : BaseDescDate
    {
        public decimal Value { get; set; }
        public bool Complete { get; set; }
    }

    public abstract class BaseOrderLine : BaseIdDate
    {
        public int Quantity { get; set; }
        public decimal PriceAdjustment { get; set; }
        public bool Complete { get; set; }
    }

}
