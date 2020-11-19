using System;

namespace Excellence.Ims.DataAccess.Tables
{
    public class SalesOrderLine : IOrderLine
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

        public int ProductId { get; set; }
        public int OrderId { get; set; }

        #endregion

        #region Foreign - One

        public Product Product { get; set; }
        public SalesOrder Order { get; set; }

        #endregion

        #region Foreign - Many

        #endregion

        #region Inverse

        #endregion
    }
}
