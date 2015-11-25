using System;
using SQLite;

namespace XamarinForms_App
{
	public class FootballPlayer
	{
		public FootballPlayer()
		{
		}
		public FootballPlayer (string fname,string lname,string dob,string ctry,string desc)
		{
			FirstName = fname;
			LastName = lname;
			Date_of_Birth = dob;
			Country = ctry;
			Description = desc;
			Isfavourite = false;
		}
		[PrimaryKey,AutoIncrement]
		public int Id{ get; set;}
		public string FirstName { get; set;}
		public string LastName { get;  set;}
		public string Date_of_Birth { get; set;}
		public string Country { get;  set;}
		public string Description { get; set;}
		public bool Isfavourite { get; set;}
	}
}

