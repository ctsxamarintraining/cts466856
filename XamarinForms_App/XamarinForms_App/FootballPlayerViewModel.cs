using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using SQLite;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;

namespace XamarinForms_App
{
	public class FootballPlayerViewModel : INotifyPropertyChanged
	{
		string firstName;
		public string FirstName { 
			get {
				return firstName;
			}
			set{
				if(firstName != value)
				{
					firstName = value;
					OnPropertyChanged ("FirstName");
				}
			}
		}
		string lastName;
		public string LastName {
			get {
				return lastName;
			}
			set {
				if (lastName != value) {
					lastName = value;
					OnPropertyChanged ("LastName");
				}
			}
		}

		string date_of_Birth;
		public string Date_of_Birth {
			get {
				return date_of_Birth;
			}
			set{
				if(date_of_Birth != value)
				{
					date_of_Birth = value;
					OnPropertyChanged ("Date_of_Birth");
				}
			}
		}
		string country;
		public string Country {
			get {
				return country;
			}
			set{
				if(country != value)
				{
					country = value;
					OnPropertyChanged ("Country");
				}
			}
		}
		string description;
		public string Description {
			get {
				return description;
			}
			set{
				if(description != value)
				{
					description = value;
					OnPropertyChanged ("Description");
				}
			}
		}
		bool isfavourite;
		public bool Isfavourite {
			get {
				return isfavourite;
			}
			set{
				if(isfavourite != value)
				{
					isfavourite = value;
					OnPropertyChanged ("Isfavourite");
				}
			}
		}
		string theage;
		public string age{ 
			get {
				return theage;
			}
			set{
				if(theage != value)
				{
					theage = value;
					OnPropertyChanged ("age");
				}
			}}

		public ICommand SaveCommand;
		public ICommand FavouriteCommand{ get; set;}
		public ICommand DeleteCommand;


		public FootballPlayerViewModel ()
		{
			this.SaveCommand = new Command (() => {
				
			});

			this.FavouriteCommand  = new Command<FootballPlayerViewModel>(execute: (FootballPlayerViewModel theplayer) => 
				{

					using(SQLiteConnection connection = new SQLiteConnection(Path.Combine(App.folderPath,"FootballPlayerDB.db3"))){
						
						List<FootballPlayer> newplayerlist = connection.Query<FootballPlayer>("SELECT * FROM FootballPlayer WHERE FirstName = ? and LastName = ?",theplayer.FirstName,theplayer.LastName);

						newplayerlist[0].Isfavourite = !(newplayerlist[0].Isfavourite);
						connection.Update(newplayerlist[0]);

						Debug.WriteLine(newplayerlist.Count);
					}
				});
			this.DeleteCommand = new Command(()=>{
				using(SQLiteConnection connection = new SQLiteConnection(Path.Combine(App.folderPath,"FootballPlayerDB.db3"))){
					var theplayer = new FootballPlayer(
						firstName,
						lastName,
						date_of_Birth,
						country,
						description
					);
					theplayer.Isfavourite = isfavourite;
					connection.Delete(theplayer);
				}
			});

//			this.DeleteCommand = new Command<FootballPlayerViewModel> (execute: (FootballPlayerViewModel selectedplayer) => {
//
//				using(SQLiteConnection connection = new SQLiteConnection(Path.Combine(App.folderPath,"FootballPlayerDB.db3"))){
//					var theplayer = new FootballPlayer(
//						selectedplayer.FirstName,
//						selectedplayer.LastName,
//						selectedplayer.Date_of_Birth,
//						selectedplayer.Country,
//						selectedplayer.Description
//					);
//					theplayer.Isfavourite = selectedplayer.Isfavourite;
//					connection.Delete(theplayer);
//				}
//			});

		}


		protected virtual void OnPropertyChanged (string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
			}
		}


		#region INotifyPropertyChanged implementation
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
	}
}

