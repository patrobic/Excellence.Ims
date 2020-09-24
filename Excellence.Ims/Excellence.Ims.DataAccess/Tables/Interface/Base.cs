using System;
using System.ComponentModel.DataAnnotations;

namespace Excellence.Ims.DataAccess.Tables
{
    //public abstract class BaseId
    //{
    //    [Required]
    //    public int Id { get; set; }
    //}

    //public abstract class BaseName : BaseId
    //{
    //    [Required]
    //    public string Name { get; set; }
    //}

    //public abstract class BaseDesc : BaseName
    //{
    //    [Required]
    //    public string Description { get; set; }
    //}

    public interface IIdentifiable
    {
        [Required]
        public int Id { get; set; }
    }

    public interface INameable : IIdentifiable
    {
        [Required]
        public string Name { get; set; }
    }

    public interface IDescribable : INameable
    {
        [Required]
        public string Description { get; set; }
    }
}
