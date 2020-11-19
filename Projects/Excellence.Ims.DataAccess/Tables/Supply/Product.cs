using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Type = Excellence.Ims.DataAccess.Tables.Type;

namespace Excellence.Ims.DataAccess.Tables
{
    public class Product : IItem
    {
        #region Primitive

        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }

        [Required]
        public string Sku { get; set; }
        [Required]
        public Type Type { get; set; }
        [Column(TypeName = "money"), Required]
        public decimal Price { get; set; }

        #endregion

        #region Foreign - One

        public Location Location { get; set; }

        public ProductInfo ProductInfo { get; set; }
        public Product Parent { get; set; }

        #endregion

        #region Foreign - Many

        public virtual ICollection<Bundling> Bundling { get; set; }
        public virtual ICollection<Product> UpSells { get; set; }
        public virtual ICollection<Product> CrossSells { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<AttributeValue> Attributes { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }

        #endregion

        #region Inverse

        public virtual ICollection<Product> Children { get; set; }
        public virtual ICollection<Product> UpSoldBy { get; set; }
        public virtual ICollection<Product> CrossSoldBy { get; set; }

        #endregion
    }
}
