using System.Collections.Generic;

namespace Excellence.Ims.DataAccess.Tables
{
    public class ManufactureOrder : IOrder
    {
        #region Primitive

        #endregion

        #region Foreign - One

        public Employee Employee { get; set; }
        public Project Project { get; set; }

        #endregion

        #region Foreign - Many

        public virtual ICollection<ManufactureOrderLine> Lines { get; set; }
 
        #endregion

        #region Inverse

        #endregion
    }
}
