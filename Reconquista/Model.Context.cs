﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reconquista
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ReconquistaEntities : DbContext
    {
        public ReconquistaEntities()
            : base("name=ReconquistaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Anexo> Anexo { get; set; }
        public virtual DbSet<Bem> Bem { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Cliente_Bem> Cliente_Bem { get; set; }
        public virtual DbSet<Telefone> Telefone { get; set; }
    }
}