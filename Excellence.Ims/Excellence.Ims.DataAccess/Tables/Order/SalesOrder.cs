using Excellence.Ims.DataAccess.Tables.Contact;
using Excellence.Ims.DataAccess.Tables.Misc;
using Excellence.Ims.DataAccess.Tables.Supply;
using System;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Order
{
    public class SalesOrder : BaseOrder
    {
        public virtual ICollection<SalesOrderLine> Lines { get; set; }
        public Client Client { get; set; }
        public Project Project { get; set; }
    }
}
