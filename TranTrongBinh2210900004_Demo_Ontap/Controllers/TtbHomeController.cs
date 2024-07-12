using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TranTrongBinh2210900004_Demo_Ontap.Controllers
{
    public class TtbHomeController : Controller
    {
        public ActionResult TtbIndex()
        {
            return View();
        }

        public ActionResult TtbAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult TtbContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}