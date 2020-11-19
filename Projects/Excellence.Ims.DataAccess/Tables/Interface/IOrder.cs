namespace Excellence.Ims.DataAccess.Tables
{
    public interface IOrder : IDescribable, ICompletable, IValueable
    {

    }

    public interface IOrderLine : IDescribable, ICompletable
    {
        public int Quantity { get; set; }
        public decimal PriceAdjustment { get; set; }
    }
}
