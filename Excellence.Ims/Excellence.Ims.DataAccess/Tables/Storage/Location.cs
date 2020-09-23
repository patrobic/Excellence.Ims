using System;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Storage
{
    public class Location : BaseDesc
    {
        public Location? Parent { get; set; }
        public virtual ICollection<Location> Children { get; set; }
    }
}
