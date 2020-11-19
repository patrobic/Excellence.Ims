namespace Excellence.Ims.DataAccess.Tables
{
    public class PurchaseOrderLine : IOrderLine
    {
        #region Primitive

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
