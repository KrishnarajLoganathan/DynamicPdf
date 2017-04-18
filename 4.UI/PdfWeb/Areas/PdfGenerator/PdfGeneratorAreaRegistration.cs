using System.Web.Mvc;

namespace BCG.CD.Dynamic.UI.PdfWeb.Areas.PdfGenerator
{
    public class PdfGeneratorAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "PdfGenerator";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "PdfGenerator_default",
                "PdfGenerator/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}