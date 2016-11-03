using Autofac;
using Autofac.Integration.WebApi;
using Knots.Common.Interfaces.Repos;
using Knots.Common.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Knots.MVC.Host
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            /*****/
            // http://docs.autofac.org/en/latest/integration/webapi.html

            var builder = new ContainerBuilder();

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;
            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            // OPTIONAL: Register the Autofac filter provider.
            //builder.RegisterWebApiFilterProvider(config);

            builder.RegisterType<Knots.Services.KnotsService>().As<IKnotsService>();
            builder.RegisterType<Knots.Repos.KnotsRepo>().As<IKnotsRepo>();


            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            /*****/



            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            

        }
    }
}
