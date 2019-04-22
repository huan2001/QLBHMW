using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLBHWS.Models;
using PagedList;
using System.Data.Entity;

namespace QLBHWS.Controllers
{
    public class HangHoa2Controller : Controller
    {

        QLBanHang2DbContext db = new QLBanHang2DbContext();
        // GET: HangHoa2/List?page=1
        public ActionResult List(int? page=1)
        {
            var pageIndex = (page < 1) ? 1 : page.Value;
            int pageSize = 6;
            int n = (pageIndex - 1) * pageSize;
            int totalCount = db.HangHoas.Count();
            dynamic items = db.HangHoas.OrderBy(p => p.ID).Skip(n).Take(pageSize).ToList();
            var onePageOfData = new StaticPagedList<HangHoa>(items, pageIndex, pageSize, totalCount);
            ViewBag.HangHoa2Act = "active";
            if (Request.IsAjaxRequest())
            {
                return PartialView("_ListPartial",onePageOfData);
            }
            return View("List",onePageOfData);
        }
    }
}