using System;

namespace XamarinForms_App
{
	public class FootballPlayer
	{
		public FootballPlayer (string fname,string lname,DateTime dob,string ctry,string desc)
		{
			FirstName = fname;
			LastName = lname;
			Date_of_Birth = dob;
			Country = ctry;
			Description = desc;
			Isfavourite = false;
			age = (DateTime.Now - Date_of_Birth);
		}

		public string FirstName { get; set;}
		public string LastName { get; private set;}
		public DateTime Date_of_Birth { get; private set;}
		public string Country { get; private set;}
		public string Description { get; private set;}
		public bool Isfavourite { get; set;}
		public TimeSpan age{ get; private set;}
	}
}

