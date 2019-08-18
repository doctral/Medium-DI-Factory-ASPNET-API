using Demo.Entities;
using System.Collections.Generic;

namespace Demo.Repository
{
	public interface IPersonRepository
	{
		IList<Person> GetAllPersons();
		IList<Person> GetPersonsByFirstName(string firstName);
		IList<Person> GetPersonByLastName(string lastName);
		Person GetPersonById(int id);
	}
}
