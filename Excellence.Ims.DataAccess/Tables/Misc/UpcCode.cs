using Excellence.Ims.DataAccess.Tables.Contact;
using Excellence.Ims.DataAccess.Tables.Supply;
using System;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Misc
{
    public class UpcCode : BaseId
    {
        public Product Product { get; set; }
        public string Upc { get; set; }
        public Supplier Supplier { get; set; }
    }
}
