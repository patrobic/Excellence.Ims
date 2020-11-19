using System;
using System.ComponentModel.DataAnnotations;

namespace Excellence.Ims.DataAccess.Tables
{
    public class UpcCode : IIdentifiable, ICreatable
    {
        #region Primitive

        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }

        public string Upc { get; set; }

        #endregion

        #region Foreign - One

        public Product Product { get; set; }
        public Supplier Supplier { get; set; }

        #endregion

        #region Foreign - Many

        #endregion

        #region Inverse

        #endregion
    }
}
