﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA44_Team10A_SportsFacBookingSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BookingSystemEntities : DbContext
    {
        public BookingSystemEntities()
            : base("name=BookingSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BookingTransaction> BookingTransactions { get; set; }
        public virtual DbSet<Facility> Facilities { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
