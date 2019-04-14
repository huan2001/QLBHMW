using QLBHWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLBHWS.Controllers
{
    public class DemoController : Controller
    {
        QLBanHang2DbContext db = new QLBanHang2DbContext();
        // GET: Demo
        public ViewResult TestModel()
        {
            var item = db.ChungLoais.ToList();
            return View(item);
        }
    }
}