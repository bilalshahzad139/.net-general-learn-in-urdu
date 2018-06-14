using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PdfTesterWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //System.Web.HttpContext.Current.Server.MapPath("~");

            var mainPath = Server.MapPath("~/docs");
            MyPdfHelper.PdfHelper.GeneratePdfTesting(mainPath);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}