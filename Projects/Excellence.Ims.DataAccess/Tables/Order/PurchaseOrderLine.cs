using System;

namespace Excellence.Ims.DataAccess.Tables
{
    public class PurchaseOrderLine : IOrderLine
    {
        #region Primitive

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime CompleteDate { get; set; }
        public bool Complete { get; set; }

        public int Quantity { get; set; }
        public decimal PriceAdjustment { get; set; }

        public int ItemId { get; set; }
        public int OrderId { get; set; }

        #endregion

        #region Foreign - One

        public Item Item { get; set; }
        public PurchaseOrder Order { get; set; }

        #endregion

        #region Foreign - Many

        #endregion

        #region Inverse

        #endregion
    }
}
