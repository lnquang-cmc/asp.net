//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public System.Guid OrderDetailsID { get; set; }
        public Nullable<System.Guid> ProductID { get; set; }
        public Nullable<int> QuantityOrdered { get; set; }
        public Nullable<int> Price { get; set; }
        public string OrderCode { get; set; }
        public Nullable<System.Guid> OrderID { get; set; }
        public string Status { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}