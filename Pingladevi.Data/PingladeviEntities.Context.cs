﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pingladevi.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PingladeviEntities1 : DbContext
    {
        public PingladeviEntities1()
            : base("name=PingladeviEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Pavati> Tbl_Pavati { get; set; }

        public System.Data.Entity.DbSet<Pingladevi.Models.PavatiModel> PavatiModels { get; set; }
    }
}
