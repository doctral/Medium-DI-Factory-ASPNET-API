namespace Demo.Service.Factory
{
	public class JohnGreetingService : IGreetingService
	{
		public string SayHello()
		{
			return "Greeting from John";
		}
	}
}
