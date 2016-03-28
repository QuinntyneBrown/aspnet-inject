using Chloe.Components;
using Chloe.Components.Contracts;
using Chloe.Web.Components;
using Microsoft.Practices.Unity;
using System.Web.Mvc;
using Unity.Mvc5;

namespace Chloe.Web
{
    public static class UnityConfig
    {
        public static IUnityContainer Container;

        public static void RegisterComponents()
        {
			Container = new UnityContainer();

            Container.RegisterType<IHelloWorld, HelloWorld>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(Container));
        }
    }
}