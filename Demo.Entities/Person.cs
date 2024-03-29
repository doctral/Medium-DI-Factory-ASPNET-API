﻿namespace Demo.Entities
{
	public class Person
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Person(int id, string firstName, string lastName)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
		}

		public override string ToString()
		{
			return "Id: " + Id + ", FirstName: " + FirstName + ", LastName: " + LastName;
		}
	}
}
