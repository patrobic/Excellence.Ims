using System.Collections.Generic;

namespace Excellence.Ims.DataAccess.Tables
{
    public class SalesOrder : IOrder
    {
        #region Primitive

        #endregion

        #region Foreign - One
        
        public Client Client { get; set; }
        public Project Project { get; set; }

        #endregion

        #region Foreign - Many

        public virtual ICollection<SalesOrderLine> Lines { get; set; }

        #endregion

        #region Inverse

        #endregion
    }
}
