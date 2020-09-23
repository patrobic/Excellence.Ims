using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables
{
    public abstract class Base
    {
        public int Id { get; set; }
    }

    public abstract class BaseNamed : Base
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
