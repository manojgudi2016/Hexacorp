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
    
    public partial class Franchisee
    {
        public Franchisee()
        {
            this.Stores = new HashSet<Store>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    
        public virtual ICollection<Store> Stores { get; set; }
    }
}
