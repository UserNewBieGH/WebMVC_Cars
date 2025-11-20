using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnWeb_BanXeMVC.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Brands()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}