using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Excellence.Ims.DataAccess.Tables
{
    public class Item : IItem
    {
        #region Primitive

        [Required, Display(Name = "Id")]
        public int Id { get; set; }
        [Required, Display(Name = "Item Name")]
        public string Name { get; set; }
        [Display(Name = "Item Description")]
        public string Description { get; set; }

        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }

        #endregion

        #region Foreign - One

        public Location Location { get; set; }

        #endregion

        #region Foreign - Many

        public virtual ICollection<Bundling> Bundling { get; set; }
        public virtual ICollection<Category> Categories { get; set; }

        #endregion

        #region Inverse

        #endregion
    }
}
