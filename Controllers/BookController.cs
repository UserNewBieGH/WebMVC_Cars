using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnWeb_BanXeMVC.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index() //Form đặt lịch
        {
            return View();
        }
        public ActionResult Book()
        {
            return View("Succesfully");
        }
        }
}