using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLKS.Models.Entities;

namespace QLKS.Controllers
{
    public class ServiceController : Controller
    {
        Models.EF.QLKS qlks = new Models.EF.QLKS();
        // GET: Service
        public ActionResult Index()
        {
            List<tLoaiPhong> _list = new List<tLoaiPhong>();
            _list = qlks.tLoaiPhong.ToList();
            return View(_list);
        }
    }
}