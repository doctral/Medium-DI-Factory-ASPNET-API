using System.Collections.Generic;
using System.Linq;
using Demo.Data;
using Demo.Entities;

namespace Demo.Repository
{
	public class PersonRepository : IPersonRepository
	{
		public IList<Person> GetAllPersons()
		{
			return DataProvider.GetAllData();
		}

		public Person GetPersonById(int id)
		{
			return DataProvider.GetAllData().Where(x => x.Id == id).FirstOrDefault();
		}

		public IList<Person> GetPersonByLastName(string lastName)
		{
			return DataProvider.GetAllData().Where(x => x.LastName == lastName).ToList();
		}

		public IList<Person> GetPersonsByFirstName(string firstName)
		{
			return DataProvider.GetAllData().Where(x => x.FirstName == firstName).ToList();
		}
	}
}
