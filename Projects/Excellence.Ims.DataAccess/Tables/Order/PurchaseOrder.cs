using System.Collections.Generic;

namespace Excellence.Ims.DataAccess.Tables
{
    public class PurchaseOrder : IOrder
    {
        #region Primitive

        #endregion

        #region Foreign - One
        
        public Supplier Supplier { get; set; }
        public Project Project { get; set; }

        #endregion

        #region Foreign - Many

        public virtual ICollection<PurchaseOrderLine> Lines { get; set; }

        #endregion

        #region Inverse

        #endregion
    }
}
