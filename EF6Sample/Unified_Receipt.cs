//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF6Sample
{
    using System;
    using System.Collections.Generic;
    
    public partial class Unified_Receipt
    {
        public int Register_ID { get; set; }
        public int Store_ID { get; set; }
        public int Sequence { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Cashier_ID { get; set; }
    
        public virtual Store Store { get; set; }
    }
}
