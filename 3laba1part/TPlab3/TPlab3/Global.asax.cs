using System.Web.Mvc;
using System.Web.Routing;
using TPlab3.Controllers;

namespace TPlab3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory());
        }
    }

    public class CustomControllerFactory : DefaultControllerFactory
    {
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            if (controllerName != null && controllerName.ToLower() == "start")
            {
                return new StartController();
            }

            return base.CreateController(requestContext, controllerName);
        }
    }
}