﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CAT_207.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ef_dbContainer : DbContext
    {
        public ef_dbContainer()
            : base("name=ef_dbContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ANAL_DOC_C190> ANAL_DOC_C190 { get; set; }
        public virtual DbSet<DEVOLUCAO_C113> DEVOLUCAO_C113 { get; set; }
        public virtual DbSet<DOC_FISCAL_C100> DOC_FISCAL_C100 { get; set; }
        public virtual DbSet<ENQUADRAMENTO_5D> ENQUADRAMENTO_5D { get; set; }
        public virtual DbSet<ENTIDADE_0000> ENTIDADE_0000 { get; set; }
        public virtual DbSet<ENTIDADE_COMPL_0005> ENTIDADE_COMPL_0005 { get; set; }
        public virtual DbSet<GIA> GIA { get; set; }
        public virtual DbSet<ITEM_0200> ITEM_0200 { get; set; }
        public virtual DbSet<ITENS_DOC_C170> ITENS_DOC_C170 { get; set; }
        public virtual DbSet<PARTICIPANTE_0150> PARTICIPANTE_0150 { get; set; }
        public virtual DbSet<IVA> IVA { get; set; }
        public virtual DbSet<ARQUIVOS_GERADOS> ARQUIVOS_GERADOS { get; set; }
        public virtual DbSet<ENQ_OP> ENQ_OP { get; set; }
        public virtual DbSet<v_Sintegra> v_Sintegra { get; set; }
        public virtual DbSet<v_150_C100_C190_ENQ_OP> v_150_C100_C190_ENQ_OP { get; set; }
    }
}
