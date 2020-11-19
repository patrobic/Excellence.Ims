using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Excellence.Ims.DataAccess.Tables
{
    [Table("Product")]
    public class ProductInfo : IIdentifiable, IMeasurable
    {
        #region Primitive

        [Required]
        public int Id { get; set; }

        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

        public bool IsFeatured { get; set; }
        public bool Published { get; set; }
        public bool Visibility { get; set; }
        public bool InStock { get; set; }
        public bool BackordersAllowed { get; set; }
        public bool TaxStatus { get; set; }

        #endregion

        #region Foreign - One

        public Product Product { get; set; } // not necessary? since we have Id.
        public ShippingClass ShippingClass { get; set; }
        public Warranty Warranty { get; set; }

        #endregion

        #region Foreign - Many

        #endregion

        #region Inverse

        #endregion

    }
}
