﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class team_web_projectEntities : DbContext
    {
        public team_web_projectEntities()
            : base("name=team_web_projectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<member> member { get; set; }
        public virtual DbSet<order_detail> order_detail { get; set; }
        public virtual DbSet<order_form> order_form { get; set; }
        public virtual DbSet<product> product { get; set; }
        public virtual DbSet<shopping_cart> shopping_cart { get; set; }
    }
}
