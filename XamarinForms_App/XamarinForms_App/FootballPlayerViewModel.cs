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
		string theage;
		bool isfavourite;
		string description;
		string country;
		string date_of_Birth;
		string lastName;

		public string FirstName { 
			get {
				return firstName;
			}
			set {
				if (firstName != value) {
					firstName = value;
					OnPropertyChanged ("FirstName");
				}
			}
		}


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


		public string Date_of_Birth {
			get {
				return date_of_Birth;
			}
			set {
				if (date_of_Birth != value) {
					date_of_Birth = value;
					OnPropertyChanged ("Date_of_Birth");
				}
			}
		}


		public string Country {
			get {
				return country;
			}
			set {
				if (country != value) {
					country = value;
					OnPropertyChanged ("Country");
				}
			}
		}


		public string Description {
			get {
				return description;
			}
			set {
				if (description != value) {
					description = value;
					OnPropertyChanged ("Description");
				}
			}
		}


		public bool Isfavourite {
			get {
				return isfavourite;
			}
			set {
				if (isfavourite != value) {
					isfavourite = value;
					OnPropertyChanged ("Isfavourite");
				}
			}
		}



		public string age { 
			get {
				return theage;
			}
			set {
				if (theage != value) {
					theage = value;
					OnPropertyChanged ("age");
				}
			}
		}

		public ICommand SaveCommand{ get; set; }

		public ICommand FavouriteCommand{ get; set; }

		public ICommand DeleteCommand{ get; set; }


		public FootballPlayerViewModel ()
		{
			this.SaveCommand = new Command (() => {
				
			});

			this.FavouriteCommand = new Command<FootballPlayerViewModel> (execute: (FootballPlayerViewModel theplayer) => {

				using ( SQLiteConnection connection = new SQLiteConnection (Path.Combine (App.folderPath, "FootballPlayerDB.db3"))) {
						
					List<FootballPlayer> newplayerlist = connection.Query<FootballPlayer> ("SELECT * FROM FootballPlayer WHERE FirstName = ? and LastName = ?", theplayer.FirstName, theplayer.LastName);

					newplayerlist [0].Isfavourite = !(newplayerlist [0].Isfavourite);
					connection.Update (newplayerlist [0]);

					MessagingCenter.Send(this,"DBChanged");

					Debug.WriteLine (newplayerlist.Count);
				}



			});

			this.DeleteCommand = new Command<FootballPlayerViewModel> (execute: (FootballPlayerViewModel theplayer) => {
				
				using (SQLiteConnection connection = new SQLiteConnection (Path.Combine (App.folderPath, "FootballPlayerDB.db3"))) {

					List<FootballPlayer> newplayerlist = connection.Query<FootballPlayer> ("SELECT * FROM FootballPlayer WHERE FirstName = ? and LastName = ?", theplayer.FirstName, theplayer.LastName);
					connection.Delete (newplayerlist [0]);

					MessagingCenter.Send(this,"DBChanged");

					Debug.WriteLine (newplayerlist.Count);
				}

			});

		}


		protected virtual void OnPropertyChanged (string propertyName)
		{
			if (PropertyChanged != null) {
				PropertyChanged (this,
					new PropertyChangedEventArgs (propertyName));
			}
		}


		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion
	}
}

