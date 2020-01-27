using Autofac;
using Autofac.Integration.Mvc;
using Employees.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employees.Web.App_Start
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<SqlPersonData>().As<IPersonData>().InstancePerRequest();
            builder.RegisterType<SqlEmployeeData>().As<IEmployeeData>().InstancePerRequest();
            builder.RegisterType<SqlUserData>().As<IUserData>().InstancePerRequest();

            builder.RegisterType<EmployeeDbContext>().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}