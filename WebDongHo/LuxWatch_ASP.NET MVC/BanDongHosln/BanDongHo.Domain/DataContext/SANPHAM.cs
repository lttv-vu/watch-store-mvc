
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
    using System.Collections.Generic;
    
public partial class SANPHAM
{

    public SANPHAM()
    {

        this.CHITIETDONHANGs = new HashSet<CHITIETDONHANG>();

        this.CHITIETKMs = new HashSet<CHITIETKM>();

    }


    public int MASP { get; set; }

    public string TENSP { get; set; }

    public string HINHLON { get; set; }

    public string HINHNHO { get; set; }

    public string MOTA { get; set; }

    public Nullable<int> MATH { get; set; }

    public string DANHGIA { get; set; }

    public Nullable<int> SOLUONG { get; set; }

    public string MALOAISP { get; set; }

    public Nullable<double> DONGIA { get; set; }



    public virtual ICollection<CHITIETDONHANG> CHITIETDONHANGs { get; set; }

    public virtual ICollection<CHITIETKM> CHITIETKMs { get; set; }

    public virtual LOAISANPHAM LOAISANPHAM { get; set; }

    public virtual THUONGHIEU THUONGHIEU { get; set; }

}

}
