﻿

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace BanDongHo.Domain.DataContext
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class BANDONGHOEntities : DbContext
{
    public BANDONGHOEntities()
        : base("name=BANDONGHOEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public DbSet<CHITIETDONHANG> CHITIETDONHANGs { get; set; }

    public DbSet<CHITIETKM> CHITIETKMs { get; set; }

    public DbSet<DONHANG> DONHANGs { get; set; }

    public DbSet<KHACHHANG> KHACHHANGs { get; set; }

    public DbSet<KHUYENMAI> KHUYENMAIs { get; set; }

    public DbSet<LOAISANPHAM> LOAISANPHAMs { get; set; }

    public DbSet<LOAITK> LOAITKs { get; set; }

    public DbSet<SANPHAM> SANPHAMs { get; set; }

    public DbSet<TAIKHOAN> TAIKHOANs { get; set; }

    public DbSet<THUONGHIEU> THUONGHIEUx { get; set; }

}

}

