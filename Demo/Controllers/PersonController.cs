using Demo.Entities;
using Demo.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace Demo.Controllers
{
	[RoutePrefix("person")]
	public class PersonController : ApiController
	{
		private IPersonService personService;

		public PersonController(IPersonService _personService)
		{
			personService = _personService;
		}

		[HttpGet]
		[Route("")]
		public IList<Person> GetAllPerson()
		{
			return personService.GetAllPersons();
		}

		[HttpGet]
		[Route("{id:int}")]
		public Person GetPersonById(int id)
		{
			return personService.GetPersonById(id);
		}

	}
}