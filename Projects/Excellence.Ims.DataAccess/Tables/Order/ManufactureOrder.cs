using Excellence.Ims.DataAccess.Tables.Contact;
using Excellence.Ims.DataAccess.Tables.Misc;
using Excellence.Ims.DataAccess.Tables.Supply;
using System;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Order
{
    public class ManufactureOrder : BaseOrder
    {
        public virtual ICollection<ManufactureOrderLine> Lines { get; set; }
        public Employee Employee{ get; set; }
        public Project Project { get; set; }
    }
}
