using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BCG.CD.Dynamic.Core.PdfLogging;

namespace BCG.CD.Dynamic.UI.PdfWeb.GlobalLogger
{
    public class LogHandler : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            Exception ex = filterContext.Exception;
            filterContext.ExceptionHandled = true;
            var model = new HandleErrorInfo(filterContext.Exception, "Home", "ApplicationError");

            Logger.Log(ex);//Log to log4net

            filterContext.Result = new ViewResult()
            {
                ViewName = "ApplicationError",
                ViewData = new ViewDataDictionary (){ { "Error", model } }
            };
        }
    }
}