using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
namespace QLBHWS.Models
{
    [MetadataType(typeof(ChungLoai.ChungLoaiMetadata))]
    public partial class ChungLoai
    {
        class ChungLoaiMetadata
        {
            [Display(Name ="Chủng loại ID")]
            public int ID;

            [Display(Name ="Mã số")]
            [MaxLength(10,ErrorMessage ="{0} tối đa là {1} ký tự")]
            [Required(ErrorMessage ="{0} không được để trống")]
            public string MaSo;

            [Display(Name ="Tên chủng loại")]
            [MaxLength(100, ErrorMessage = "{0} tối đa là {1} ký tự")]
            [Required(ErrorMessage = "{0} không được để trống")]
            public string Ten;
        }
    }

    [MetadataType(typeof(HangHoa.HangHoaMetadata))]
    public partial class HangHoa
    {
        class HangHoaMetadata
        {
            [Display(Name ="Hàng hóa ID")]
            public int ID;

            [Display(Name ="Mã số")]
            [MaxLength(10,ErrorMessage ="{0} tối đa là {1} ký tự")]
            [MinLength(2,ErrorMessage ="{0} tối Thiểu là {2} ký tự")]
            [Required(ErrorMessage ="{0} không được để trống")]
            public string MaSo;

            [Display(Name ="Tên Hàng")]
            [MaxLength(200,ErrorMessage ="{0} tối đa là {1} ký tự")]
            [Required(ErrorMessage ="{0} không được để trống")]
            public string Ten;

            [Display(Name ="Đơn vị tính")]
            [MaxLength(50,ErrorMessage ="{0} tối đa là {1} ký tự")]
            public string DonViTinh;

            [Display(Name ="Mô tả")]
            public string MoTa;

            [Display(Name ="Thông số kỹ thuật")]
            public string ThongSoKyThuat;

            [Display(Name ="Tên hình")]
            public string TenHinh;

            [Display(Name ="Giá Bán")]
            [Required(ErrorMessage ="{0} không được để trống")]
            [Range(0,int.MaxValue,ErrorMessage ="{0} phải từ {1} đến {2}")]
            [DisplayFormat(DataFormatString ="{0:#,##0VND}")]
            public int GiaBan;

            [Display(Name ="Chủng loại")]
            public Nullable<int> ChungLoaiID;

            [Display(Name ="Ngày tạo")]
            [Required(ErrorMessage ="{0} không được để trống")]
            [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}")]
            public System.DateTime NgayTao;

            [Display(Name ="Ngày cập nhật")]
            [Required(ErrorMessage ="{0} không được để trống")]
            [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}")]
            public System.DateTime NgayCapNhat;
        }
    }
    [MetadataType(typeof(HoaDon.HoaDonMetadata))]
    public partial class HoaDon
    {
        class HoaDonMetadata
        {
            [Display(Name ="Hóa đơn ID")]
            public int ID;
            [Display(Name ="Ngày đặt hàng")]
            public System.DateTime NgayDatHang;
            [Display(Name ="Họ tên khách hàng")]
            [MaxLength(50,ErrorMessage ="{0} tối đa là {1} ký tự")]
            public string HoTenKhach;
            [MaxLength(150,ErrorMessage ="{0} tối đa là {1} ký tự")]
            [Display(Name ="Địa chỉ")]
            public string DiaChi;
            [Display(Name ="Điện thoại")]
            [MaxLength(30,ErrorMessage ="{0} tối đa là {1} ký tự")]
            public string DienThoai;
            [Display(Name ="Email")]
            [EmailAddress(ErrorMessage ="{0} không hợp lệ")]
            [MaxLength(50,ErrorMessage ="{0} tối đa là {1} ký tự")]
            public string Email;
            [Display(Name ="Tổng tiền")]
            [DisplayFormat(DataFormatString ="{0:#,##0VND}")]
            public int TongTien;
        }
    }
}