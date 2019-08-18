using Demo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Service
{
	public interface IPersonService
	{
		IList<Person> GetAllPersons();
		IList<Person> GetPersonsByFirstName(string firstName);
		IList<Person> GetPersonByLastName(string lastName);
		Person GetPersonById(int id);
	}
}
