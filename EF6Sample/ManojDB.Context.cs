﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Manoj_PlaygroundEntities : DbContext
    {
        public Manoj_PlaygroundEntities()
            : base("name=Manoj_PlaygroundEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Franchisee> Franchisees { get; set; }
        public virtual DbSet<Name> Names { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Unified_Receipt> Unified_Receipts { get; set; }
    }
}
