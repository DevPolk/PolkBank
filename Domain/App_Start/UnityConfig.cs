using Persistence.Interfaces;
using Persistence.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Domain
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<INewsRepository, NewsRepository>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}