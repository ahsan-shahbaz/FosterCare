//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AIFosterCare.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public long OrderDetailId { get; set; }
        public long OrderId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public bool IsDispatched { get; set; }
        public System.DateTime AddedOn { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
    }
}