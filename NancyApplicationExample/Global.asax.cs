using System;
using System.Web;
using System.Web.Http;
using Castle.Windsor;
using Castle.Windsor.Installer;
using NancyApplicationExample.App;

namespace NancyApplicationExample
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            IWindsorContainer container = new WindsorContainer();
            container.Install(FromAssembly.This());
            GlobalConfiguration.Configuration.DependencyResolver = new WindsorDependencyResolver(container);
        }

        protected void Application_Error(Object sender, EventArgs e)
        {

        }
    }
}