﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_DVT> tb_DVT { get; set; }
        public virtual DbSet<tb_HANGHOA> tb_HANGHOA { get; set; }
        public virtual DbSet<tb_HOADON> tb_HOADON { get; set; }
        public virtual DbSet<tb_HOADON_CT> tb_HOADON_CT { get; set; }
        public virtual DbSet<tb_KHACHHANG> tb_KHACHHANG { get; set; }
        public virtual DbSet<tb_KHO> tb_KHO { get; set; }
        public virtual DbSet<tb_NHACUNGCAP> tb_NHACUNGCAP { get; set; }
        public virtual DbSet<tb_NHAPHANG> tb_NHAPHANG { get; set; }
        public virtual DbSet<tb_NHOMHH> tb_NHOMHH { get; set; }
        public virtual DbSet<tb_TONKHO> tb_TONKHO { get; set; }
    }
}
