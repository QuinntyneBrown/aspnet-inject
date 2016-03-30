using Chloe.Components;
using Chloe.Components.Contracts;
using Chloe.Http;
using Chloe.Http.Contracts;
using Chloe.Web.Components;
using Microsoft.Practices.Unity;
using System.Web.Mvc;
using Unity.Mvc5;

namespace Chloe.Web
{
    public static class UnityConfig
    {


        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IChloeHttpClient, ChloeHttpClient>();
            container.RegisterType<IAngularYouTubeVideos, AngularYouTubeVideos>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}