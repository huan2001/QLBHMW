//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLBHWS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDonChiTiet
    {
        public int HoaDonID { get; set; }
        public int HangHoaID { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int ThanhTien { get; set; }
    
        public virtual HangHoa HangHoa { get; set; }
        public virtual HoaDon HoaDon { get; set; }
    }
}
