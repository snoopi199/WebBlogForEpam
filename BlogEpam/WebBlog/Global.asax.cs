using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using WebBlog.CR.Ninject;

namespace WebBlog.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            NinjectModule registrations = new NinjectRegistrations();
            NinjectModule registrations2 = new Registrator();
            var karnel = new StandardKernel(registrations,registrations2);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(karnel));



        }
    }
}
