namespace Excellence.Ims.DataAccess.Tables
{
    public class ManufactureOrderLine : IOrderLine
    {
        #region Primitive

        public int ProductId { get; set; }
        public int OrderId { get; set; }

        #endregion

        #region Foreign - One

        public Product Product { get; set; }
        public ManufactureOrder Order { get; set; }

        #endregion

        #region Foreign - Many

        #endregion

        #region Inverse

        #endregion

    }
}
