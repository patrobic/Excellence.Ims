using Excellence.Ims.DataAccess.Tables.Retail;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Supply
{
    public class ProductInfo
    {
        [Key] 
        public int ProductId { get; set; }
        
        public Product Product { get; set; }
        public ShippingClass ShippingClass { get; set; }
        public Warranty Warranty { get; set; }
        public int Weight { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsFeatured { get; set; }
        public bool Published { get; set; }
        public bool Visibility { get; set; }
        public bool InStock { get; set; }
        public bool BackordersAllowed { get; set; }
        public bool TaxStatus { get; set; }
    }
}
