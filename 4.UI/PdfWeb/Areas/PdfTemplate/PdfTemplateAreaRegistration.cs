using System.Web.Mvc;

namespace BCG.CD.Dynamic.UI.PdfWeb.Areas.PdfTemplate
{
    public class PdfTemplateAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "PdfTemplate";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "PdfTemplate_default",
                "PdfTemplate/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}