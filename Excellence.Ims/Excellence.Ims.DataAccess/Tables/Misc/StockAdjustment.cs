using Excellence.Ims.DataAccess.Tables.Supply;
using System;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Misc
{
    public class StockAdjustment : BaseDate
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public string Reason { get; set; }
    }
}
