﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanCoffeeABC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLCoffee_ABCEntities : DbContext
    {
        public QLCoffee_ABCEntities()
            : base("name=QLCoffee_ABCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tAnhSP> tAnhSPs { get; set; }
        public virtual DbSet<tChiTietHDB> tChiTietHDBs { get; set; }
        public virtual DbSet<tDanhMucSP> tDanhMucSPs { get; set; }
        public virtual DbSet<tHangSX> tHangSXes { get; set; }
        public virtual DbSet<tHoaDonBan> tHoaDonBans { get; set; }
        public virtual DbSet<tKhachHang> tKhachHangs { get; set; }
        public virtual DbSet<tKichThuoc> tKichThuocs { get; set; }
        public virtual DbSet<tLoaiSP> tLoaiSPs { get; set; }
        public virtual DbSet<tNguyenLieu> tNguyenLieux { get; set; }
        public virtual DbSet<tNguyenLieuSP> tNguyenLieuSPs { get; set; }
        public virtual DbSet<tNhanVien> tNhanViens { get; set; }
        public virtual DbSet<tTinTuc> tTinTucs { get; set; }
        public virtual DbSet<tUser> tUsers { get; set; }
    }
}
