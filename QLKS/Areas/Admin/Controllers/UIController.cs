using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKS.Areas.Admin.Controllers
{
    public class UIController : Controller
    {
        // GET: Admin/UI
        public ActionResult Index()
        {
            return View();
        }
    }
}