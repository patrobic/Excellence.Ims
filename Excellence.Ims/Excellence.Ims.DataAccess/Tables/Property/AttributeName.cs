using System;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Property
{
    public class AttributeName : BaseId
    {
        public string Name { get; set; }
        public Category Category { get; set; }
    }
}
