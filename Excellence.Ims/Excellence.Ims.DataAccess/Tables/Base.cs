using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables
{
    public abstract class BaseId
    {
        public int Id { get; set; }
    }

    public abstract class BaseName : BaseId
    {
        public string Name { get; set; }
    }

    public abstract class BaseDesc : BaseName
    {
        public string Description { get; set; }
    }

    public abstract class BaseDate
    {
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime CompleteDate { get; set; }
    }

    public abstract class BaseIdDate : BaseDate
    {
        public int Id { get; set; }
    }

    public abstract class BaseNameDate : BaseIdDate
    {
        public string Name { get; set; }
    }

    public abstract class BaseDescDate : BaseNameDate
    {
        public string Description { get; set; }
    }
}
