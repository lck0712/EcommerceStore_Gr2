//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcommerceStore_Gr2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CartDetail
    {
        public int CartDetailID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> CartID { get; set; }
        public string ProductType { get; set; }
        public decimal UnitPrice { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string Status { get; set; }
    
        public virtual Cart Cart { get; set; }
        public virtual Product Product { get; set; }
    }
}
