using System.Web.Mvc;

namespace WebApplication4.Areas.Cursado
{
    public class CursadoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Cursado";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Cursado_default",
                "Cursado/{controller}/{action}/{id}",
                new { controller="Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] {"WebApplication4.Areas.Cursado.Controllers"}

            );
        }
    }
}