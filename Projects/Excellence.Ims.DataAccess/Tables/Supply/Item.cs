using Excellence.Ims.DataAccess.Tables.Property;
using Excellence.Ims.DataAccess.Tables.Storage;
using System.Collections.Generic;

namespace Excellence.Ims.DataAccess.Tables.Supply
{
    public class Item : BaseDescDate
    {
        #region Primitive

        #endregion

        #region Foreign - One

        public Location Location { get; set; }

        #endregion

        #region Foreign - Many

        public virtual ICollection<Bundling> Bundling { get; set; }
        public virtual ICollection<Category> Categories { get; set; }

        #endregion

        #region Inverse

        #endregion
    }
}
