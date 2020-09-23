using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Order
{
    public abstract class BaseOrder<OrderT, ProductT> : BaseNamed
    {
        public DateTime OrderDate { get; set; }
        public decimal Value { get; set; }
        public bool Complete { get; set; }
        public ICollection<BaseOrderLine<OrderT, ProductT>> Products { get; set; }
    }

    public abstract class BaseOrderLine<OrderT, ProductT>
    {
        public int Quantity { get; set; }
        public decimal PriceAdjustment { get; set; }
        public ProductT Product { get; set; }
        public OrderT Order { get; set; }
    }

}
