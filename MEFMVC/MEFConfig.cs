using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace MEFMVC
{
    public static class MefConfig
    {
        public static void RegisterMe()
        {
            var container = ConfigureContainer();
            ControllerBuilder.Current.SetControllerFactory(new MEFControllerFactory(container));
            var dependencyResolover = System.Web.Http.GlobalConfiguration.Configuration.DependencyResolver;
        }

        private static CompositionContainer ConfigureContainer()
        {
            var assemblyCatalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var container = new CompositionContainer(assemblyCatalog);
            return container;
        }
    }
}
