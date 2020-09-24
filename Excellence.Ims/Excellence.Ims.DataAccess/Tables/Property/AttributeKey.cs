using System;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Property
{
    public class AttributeKey : BaseName
    {
        public virtual ICollection<AttributeValue> AttributeValues { get; set; }
        public Category Category { get; set; }
    }
}
