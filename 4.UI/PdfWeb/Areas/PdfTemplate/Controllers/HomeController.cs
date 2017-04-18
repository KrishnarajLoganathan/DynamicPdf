using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BCG.CD.Dynamic.UI.PdfWeb.Areas.PdfTemplate.Controllers
{
    public class HomeController : Controller
    {
        // GET: PdfTemplate/Home
        public ActionResult Index()
        {
            ViewBag.Message = RouteData.Values["area"];
            throw new Exception("Custom Error");
            //return View();
        }
    }
}