using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.SubClass
{
    //public class Physical
    //{
    //    public float Length { get; set; }
    //    public float Width { get; set; }
    //    public float Height { get; set; }
    //    public float Weight { get; set; }
    //}

    //public abstract class BaseIdPhysical : BaseDate
    //{
    //    [Required]
    //    public int Id { get; set; }
    //}

    //public abstract class BaseNamePhysical : BaseIdDate
    //{
    //    [Required]
    //    public string Name { get; set; }
    //}

    //public abstract class BaseDescPhysical : BaseNameDate
    //{
    //    [Required]
    //    public string Description { get; set; }
    //}

    public interface IMeasurable
    {
        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
    }
}
