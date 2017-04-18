using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using BCG.CD.Dynamic.UI.PdfWeb;
namespace CDPdfWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var exception = Server.GetLastError();
            if (exception is HttpException)
            {
                var httpException = (HttpException)exception;
                Response.StatusCode = httpException.GetHttpCode();
            }
            else
            {
                Server.ClearError();
                Response.Clear();
                Response.Redirect("~/Views/Shared/Error.aspx");// "~/Error.html
                Response.End();
                
                //return RedirectToAction("ApplicationError", "home", new { area = "" });
                //return RedirectToAction("action", "controller", new { area = "area" });
                //return RedirectToRoute("Area_namedRoute",model);
            }

        }

    }
}
