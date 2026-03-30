using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TPlab3.Controllers
{
    public class StartController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            string action = requestContext.RouteData.Values["action"] as string;
            object idValue = requestContext.RouteData.Values["id"];

            int id = -1;

            if (idValue != null)
            {
                int.TryParse(idValue.ToString(), out id);
            }

            if (action == "start" && id == 0)
            {
                HttpContext.Current.Response.Redirect("/Database/Index");
            }
            else
            {
                HttpContext.Current.Response.Write("Ошибка");
                HttpContext.Current.Response.Write("<br/>");
                HttpContext.Current.Response.Write(HttpContext.Current.Request.Url.ToString());
            }
        }
    }
}