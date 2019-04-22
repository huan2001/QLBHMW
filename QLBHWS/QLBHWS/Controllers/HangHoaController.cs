using QLBHWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace QLBHWS.Controllers
{
    public class HangHoaController : Controller
    {
        QLBanHang2DbContext db = new QLBanHang2DbContext();

        // GET: HangHoa
        public PartialViewResult _HotThisWeekPartial()
        {
            //đọc 12 sản phẩm đầu
            var item = db.HangHoas.Take(20).ToList();
            //truyền liệu qua model
            return PartialView(item);
        }

        public ActionResult ChiTiet(int? id)
        {
            if (id==null || id<1)
                return RedirectToAction("Index","Home");
            try
            {
                HangHoa item = db.HangHoas.Include(p => p.ChungLoai).SingleOrDefault(p => p.ID == id);
                if (item==null) throw new Exception($"Mặt hàng có id={id} không tồn tại");
                return View(item);
            }
            catch (Exception ex)
            {
                string caubaoloi = $"Lỗi truy cập dữ liệu.<br/>Lý do: {ex.Message}";
                return View(viewName:"BaoLoi",model:caubaoloi);
            }
           
        }

        public ViewResult XemDanhSach()
        {
            List<HangHoa> item = db.HangHoas.Take(6).ToList();
            ViewBag.HangHoa = item;
            ViewBag.HangHoaAct = "active";
            return View("List");
        }
        public ViewResult TraCuuTheoChungLoai(int? id)
        {
            ChungLoai chungloaiItem = db.ChungLoais.Find(id);
            ViewBag.TieuDe = $"Sản phẩm của loại hàng:{chungloaiItem.Ten}";
            List<HangHoa> item = db.HangHoas.Where(p=>p.ChungLoaiID==id).Take(6).ToList();
            ViewBag.HangHoa = item;
            TempData["CLID"] = id;
            return View("List");
        }
        public ViewResult TraCuuTheoTen(string Ten)
        {
            
            
            List<HangHoa> item = db.HangHoas.Where(p => p.Ten.Contains(Ten)).ToList();
            ViewBag.HangHoa = item;
            if (item!=null)
            {
                ViewBag.TieuDe = $"Các Sản phẩm tìm được với:<span class='info'> {Ten}</span> ({item.Count} mặt hàng)";
            }
            else
            {
                ViewBag.TieuDe = $"không tìm thấy mặt hàng có tên:<span class='info'> {Ten}</span> ({item.Count} mặt hàng)";
            }
            return View("List");
        }
    }
}