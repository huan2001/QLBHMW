using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLBHWS.Models;
namespace QLBHWS.Controllers
{
    public class ChungLoaiController : Controller
    {
        QLBanHang2DbContext db = new QLBanHang2DbContext();
        // GET: ChungLoai

            [ChildActionOnly] // ngăn không cho gọi trực tiếp từ bên ngoài vào
        public PartialViewResult _ChungLoai1Partial()
        {
            List<ChungLoai> item = db.ChungLoais.ToList();
            ViewBag.ChungLoais = item;
            ViewBag.TieuDe = "Danh sách sản phẩm";
            return PartialView();
        }
    }
}