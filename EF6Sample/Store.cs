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
    
    public partial class Store
    {
        public Store()
        {
            this.Unified_Receipts = new HashSet<Unified_Receipt>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Franchisee { get; set; }
        public string Zipcode { get; set; }
        public Nullable<int> Years_in_Business { get; set; }
    
        public virtual Franchisee Franchisee1 { get; set; }
        public virtual ICollection<Unified_Receipt> Unified_Receipts { get; set; }
    }
}
