using Demo.Factory;
using Demo.Service.Factory;
using System.Text;
using System.Web.Http;

namespace Demo.Controllers
{
	[RoutePrefix("greeting")]
	public class GreetingController : ApiController
	{
		private IGreetingFactory greetingFactory;
		public GreetingController(IGreetingFactory _greetingFactory)
		{
			greetingFactory = _greetingFactory;
		}

		[HttpGet]
		[Route("")]
		public string GetGreeting()
		{
			IGreetingService service1 = greetingFactory.Create(GreetingType.EMILY);
			IGreetingService service2 = greetingFactory.Create(GreetingType.JOHN);
			IGreetingService service3 = greetingFactory.Create(GreetingType.JOSHUA);
			StringBuilder sb = new StringBuilder();
			sb.Append(service1.SayHello() + "\n");
			sb.Append(service2.SayHello()+"\n");
			sb.Append(service3.SayHello());
			return sb.ToString();
		}

	}
}