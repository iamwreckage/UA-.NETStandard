﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Opc.Ua.GdsServer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gdsdbEntities : DbContext
    {
        public gdsdbEntities()
            : base("name=gdsdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ApplicationName> ApplicationNames { get; set; }
        public DbSet<ServerEndpoint> ServerEndpoints { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<CertificateStore> CertificateStores { get; set; }
        public DbSet<CertificateRequest> CertificateRequests { get; set; }
    }
}
