using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using System.Reflection;
using IRepository;
using Autofac.Integration.WebApi;
using Autofac.Integration.Mvc;
using System.Web.Compilation;

namespace ZzhIOC
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private void setUpResolveRules(ContainerBuilder builder)
        {
            var iRepository = Assembly.Load("IRepository");
            var repository = Assembly.Load("Repository");
            builder.RegisterAssemblyTypes(iRepository, repository)
             .Where(t => t.Name.EndsWith("Repository"))
             .AsImplementedInterfaces();
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //构造AutoFac容器builder
            var builder = new ContainerBuilder();
            HttpConfiguration config = GlobalConfiguration.Configuration;
            setUpResolveRules(builder);
            builder.RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
