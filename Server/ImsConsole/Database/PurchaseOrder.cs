using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMS.Classes
{
    public class PurchaseOrder : Base
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ICollection<Item> Items { get; set; }

    }
}
