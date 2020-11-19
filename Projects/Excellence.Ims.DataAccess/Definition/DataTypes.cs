using Excellence.Ims.DataAccess.Tables;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims.DataAccess.Definition
{
    public static class DataTypes
    {
        public static List<System.Type> Types { get; set; } = new List<System.Type>
        {
            typeof(ShippingClass),
            typeof(Warranty),
            typeof(Type),
        };
    }
}
