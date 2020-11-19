using Excellence.Ims.DataAccess.Tables.Interface;

namespace Excellence.Ims.DataAccess.Tables
{
    public interface IOrder : IDescribable, ICompletable, IValueable
    {
        public decimal Value { get; set; }
    }

    public interface IOrderLine : IDescribable, ICompletable
    {
        public int Quantity { get; set; }
        public decimal PriceAdjustment { get; set; }
    }

}
