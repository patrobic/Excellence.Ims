using System.Collections.Generic;

namespace Excellence.Ims.DataAccess.Tables
{
    public class AttributeKey : BaseName
    {
        public virtual ICollection<AttributeValue> AttributeValues { get; set; }
        public Category Category { get; set; }
    }
}
