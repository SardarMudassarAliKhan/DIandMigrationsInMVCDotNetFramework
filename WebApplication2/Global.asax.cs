using Autofac;
using Autofac.Integration.Mvc;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebApplication2.Data;
using WebApplication2.IRepository;
using WebApplication2.Service;

namespace WebApplication2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();

            // Register MVC controllers
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // Register DbContext for DI
            builder.RegisterType<MyDbContext>().AsSelf().InstancePerRequest();

            // Register your services here
            builder.RegisterType<ProductService>().As<IProductService>();

            // Build the Autofac container
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            // Regular MVC application start
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
