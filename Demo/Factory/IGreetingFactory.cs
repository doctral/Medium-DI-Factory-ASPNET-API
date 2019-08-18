using Demo.Service.Factory;

namespace Demo.Factory
{
	public interface IGreetingFactory
	{
		IGreetingService Create(GreetingType greetingType);
	}
}