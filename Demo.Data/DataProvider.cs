using Demo.Entities;
using System.Collections.Generic;

namespace Demo.Data
{
	public class DataProvider
	{
		public static IList<Person> GetAllData()
		{
			return new List<Person>() {
				new Person(1, "John", "Joshua"),
				new Person(2, "John", "Emily"),
				new Person(3, "Amanda", "Joy"),
				new Person(4, "Dus", "Troy"),
				new Person(5, "Ted", "Troy")
			};
		}
	}
}
