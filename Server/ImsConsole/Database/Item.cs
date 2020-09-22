using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMS.Classes
{
    public class Item : Base
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ICollection<Item> Items { get; set; }

    }
}
