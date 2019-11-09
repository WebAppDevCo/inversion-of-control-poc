using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Configuration;
using Unity;
using Microsoft.Practices.Unity.Configuration;
using IocPoc.DiOne.Infrastructure;

namespace IocPoc.DiOne
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RegisterUnityContainer();
        }

        private void RegisterUnityContainer()
        {
            var container = new UnityContainer();
            UnityConfigurationSection section = ConfigurationManager.GetSection("unity") as UnityConfigurationSection;
            section.Configure(container, "UnitySection");

            System.Web.Http.GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
