using BCG.CD.Dynamic.UI.PdfWeb.GlobalLogger;
using System.Web;
using System.Web.Mvc;

namespace BCG.CD.Dynamic.UI.PdfWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new LogHandler());
        }
    }
}
