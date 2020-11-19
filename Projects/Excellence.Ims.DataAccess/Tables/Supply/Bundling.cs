namespace Excellence.Ims.DataAccess.Tables
{
    public class Bundling
    {
        #region Local

        public int Quantity { get; set; }
        public int ItemId { get; set; }
        public int ProductId { get; set; }

        #endregion

        #region Foreign - One

        public virtual Item Item { get; set; }
        public virtual Product Product { get; set; }

        #endregion

        #region Foreign - Many

        #endregion

        #region Inverse

        #endregion
    }
}
