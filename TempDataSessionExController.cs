using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class TempDataSessionExController : Controller
    {
        // GET: TempDataSessionEx
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string txtname,string txtprice)
        {
            TempData["uname"] = txtname;
            Session["Name"] = txtprice;
            return RedirectToAction("Details");
        }
        public ViewResult Details()
        {
            return View();
        }
        public ViewResult Register()
        {
            return View();
        }

    }
}