
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
    
public partial class DONHANG
{

    public DONHANG()
    {

        this.CHITIETDONHANGs = new HashSet<CHITIETDONHANG>();

    }


    public int MADH { get; set; }

    public Nullable<int> MAKH { get; set; }

    public string TRANGTHAI { get; set; }

    public string DIACHIGIAO { get; set; }

    public string SDT { get; set; }

    public Nullable<System.DateTime> NGAYDAT { get; set; }

    public Nullable<System.DateTime> NGAYGIAO { get; set; }

    public string MOTA { get; set; }

    public Nullable<double> TONGTIEN { get; set; }



    public virtual ICollection<CHITIETDONHANG> CHITIETDONHANGs { get; set; }

    public virtual KHACHHANG KHACHHANG { get; set; }

}

}
