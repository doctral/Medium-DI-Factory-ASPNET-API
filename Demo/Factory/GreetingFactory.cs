using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demo.Service.Factory;

namespace Demo.Factory
{
	public class GreetingFactory : IGreetingFactory
	{
		private readonly Func<GreetingType, IGreetingService> factory;
		public GreetingFactory(Func<GreetingType, IGreetingService> _factory)
		{
			factory = _factory;
		}
		public IGreetingService Create(GreetingType greetingType)
		{
			return factory(greetingType);
		}
	}
}