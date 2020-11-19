namespace Excellence.Ims.DataAccess.Tables
{
    public class SalesOrderLine : IOrderLine
    {
        #region Primitive

        #endregion

        #region Foreign - One
        
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        #endregion

        #region Foreign - Many

        public Product Product { get; set; }
        public SalesOrder Order { get; set; }

        #endregion

        #region Inverse

        #endregion
    }
}
