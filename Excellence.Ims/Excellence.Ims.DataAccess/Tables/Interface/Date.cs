using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Interface
{
    //public abstract class BaseDate
    //{
    //    public DateTime CreateDate { get; set; }
    //    public DateTime ModifyDate { get; set; }
    //    public DateTime CompleteDate { get; set; }
    //}

    //public abstract class BaseIdDate : BaseDate
    //{
    //    [Required]
    //    public int Id { get; set; }
    //}

    //public abstract class BaseNameDate : BaseIdDate
    //{
    //    [Required]
    //    public string Name { get; set; }
    //}

    //public abstract class BaseDescDate : BaseNameDate
    //{
    //    [Required]
    //    public string Description { get; set; }
    //}

    //public interface IDateable
    //{
    //    public DateTime CreateDate { get; set; }
    //    public DateTime ModifyDate { get; set; }
    //    public DateTime CompleteDate { get; set; }
    //}

    public interface ICreatable
    {
        public DateTime CreateDate { get; set; }
    }

    public interface IModifiable : ICreatable
    {
        public DateTime ModifyDate { get; set; }
    }

    public interface ICompletable : ICreatable
    {
        public bool Complete { get; set; }
        public DateTime CompleteDate { get; set; }
    }
}
