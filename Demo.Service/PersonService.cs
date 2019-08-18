using System.Collections.Generic;
using Demo.Entities;
using Demo.Repository;

namespace Demo.Service
{
	public class PersonService : IPersonService
	{
		private IPersonRepository personRepository;
		public PersonService(IPersonRepository _personRepository)
		{
			personRepository = _personRepository;
		}
		public IList<Person> GetAllPersons()
		{
			return personRepository.GetAllPersons();
		}

		public Person GetPersonById(int id)
		{
			return personRepository.GetPersonById(id);
		}

		public IList<Person> GetPersonByLastName(string lastName)
		{
			return personRepository.GetPersonByLastName(lastName);
		}

		public IList<Person> GetPersonsByFirstName(string firstName)
		{
			return personRepository.GetPersonsByFirstName(firstName);
		}
	}
}
