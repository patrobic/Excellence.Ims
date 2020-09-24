using System;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Storage
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
