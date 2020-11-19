using System.Collections.Generic;

namespace Excellence.Ims.DataAccess.Tables
{
    public class Location : BaseDesc
    {
        #region Primitive


        #endregion

        #region Foreign - One

        public Location? Parent { get; set; }

        #endregion

        #region Foreign - Many

        public virtual ICollection<Location> Children { get; set; }
 
        #endregion

        #region Inverse

        #endregion

    }
}
