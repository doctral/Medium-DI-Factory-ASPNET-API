using Demo.Factory;
using Demo.Repository;
using Demo.Service;
using Demo.Service.Factory;
using System;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Demo
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

			// register all your components with the container here
			// it is NOT necessary to register your controllers

			// e.g. container.RegisterType<ITestService, TestService>();
			container.RegisterType<IPersonRepository, PersonRepository>();
			container.RegisterType<IPersonService, PersonService>();

			// register factory components here
			container.RegisterType<IGreetingService, EmilyGreetingService>(GreetingType.EMILY.ToString());
			container.RegisterType<IGreetingService, JohnGreetingService>(GreetingType.JOHN.ToString());
			container.RegisterType<IGreetingService, JoshuaGreetingService>(GreetingType.JOSHUA.ToString());

			// define the factory strategy
			Func<GreetingType, IGreetingService> factory = (greetingType)
				=> container.Resolve<IGreetingService>(greetingType.ToString());

			// register the factory
			var _factory = new GreetingFactory(factory);
			container.RegisterInstance<IGreetingFactory>(_factory);
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}