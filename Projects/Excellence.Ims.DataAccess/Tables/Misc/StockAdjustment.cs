using System;
using System.ComponentModel.DataAnnotations;

namespace Excellence.Ims.DataAccess.Tables
{
    public class StockAdjustment : IDescribable, ICreatable
    {
        #region Primitive

        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }

        public int Quantity { get; set; }
        public string Reason { get; set; }

        #endregion

        #region Foreign - One

        public Product Product { get; set; }

        #endregion

        #region Foreign - Many

        #endregion

        #region Inverse

        #endregion
    }
}
