using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BCG.CD.Dynamic.UI.PdfWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Area_Default",
                url: "",//"{controller}/{action}/{id}"
                defaults: new { area = "PdfTemplate", controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "BCG.CD.Dynamic.UI.PdfWeb.Areas.PdfTemplate.Controllers" }
            );
        }
    }
}
