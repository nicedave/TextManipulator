using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TextManipulator.Controllers;

namespace TextManipulator
{
    public class AutofacConfig
    {
        public static void BuildContainer()
        {
            var builder = new ContainerBuilder();

            var config = GlobalConfiguration.Configuration;
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<LargestWordFinder>().As<ITextManipulatorAlgorithm>().InstancePerRequest();
            builder.RegisterType<AlgorithmsManager>().As<IAlgorithmsManager>().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}