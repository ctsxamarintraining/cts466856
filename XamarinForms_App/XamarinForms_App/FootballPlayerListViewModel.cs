using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace XamarinForms_App
{
	public class FootballPlayerListViewModel
	{

		public string FirstName { get; set;}
		public string LastName { get; private set;}
		public DateTime Date_of_Birth { get; private set;}
		public string Country { get; private set;}
		public string Description { get; private set;}
		public bool Isfavourite { get; set;}
		public TimeSpan age{ get; private set;}

		public FootballPlayerListViewModel ()
		{
			Football_Player_List = new ObservableCollection<FootballPlayer> ();
			Football_Player_List.Add (new FootballPlayer("fname","lname",DateTime.Now,"ctry","desc"));
		}

		public ObservableCollection<FootballPlayer> Football_Player_List{ get; set;}


	}
}

