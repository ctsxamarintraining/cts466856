using System;
using SQLite;

namespace XamarinForms_App
{
	public class TheCustomerDetails
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Date_of_birth { get; set; }
		public string Gender { get; set; }
		public string Description { get; set; }
		public string Country { get; set; }


		public TheCustomerDetails (string name, string dob, string gender, string description, string country)
		{
			this.Name = name;
			this.Date_of_birth = dob;
			this.Gender = gender;
			this.Description = description;
			this.Country = country;
		}
	}
}

