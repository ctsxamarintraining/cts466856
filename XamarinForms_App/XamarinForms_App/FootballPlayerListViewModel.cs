using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SQLite;
using System.IO;

namespace XamarinForms_App
{
	public class FootballPlayerListViewModel : INotifyPropertyChanged
	{
		//		private FootballPlayerViewModel selectedplayerItem;
		//		public FootballPlayerViewModel SelectedPlayer{
		//			set{
		//				if (selectedplayerItem.Equals( value)) {
		//					selectedplayerItem = value;
		//					OnPropertyChanged ("SelectedPlayer");
		//				}
		//			}
		//			get{
		//				return selectedplayerItem;
		//			}
		//		}

		private ObservableCollection<FootballPlayerViewModel> thePlayerViewModelList;

		public ObservableCollection<FootballPlayerViewModel> PlayerViewModelList {
			set {
				if (thePlayerViewModelList != value) {
					thePlayerViewModelList = value;
					OnPropertyChanged ("PlayerViewModelList");
				}
			}
			get {
				return thePlayerViewModelList;
			}
		}

		public FootballPlayerListViewModel ()
		{	
			using (SQLiteConnection connection = new SQLiteConnection (Path.Combine (App.folderPath, "FootballPlayerDB.db3"))) {
				connection.CreateTable<FootballPlayer> ();
			}

			UpdateTheList ();
			MessagingCenter.Subscribe<FootballPlayerViewModel> (this, "DBChanged", (obj) => {
				UpdateTheList ();
			}, null);

			MessagingCenter.Subscribe<NewPlayerPage> (this, "DBChanged", (obj) => {
				UpdateTheList ();
			}, null);
		}

		private void UpdateTheList ()
		{

			ObservableCollection<FootballPlayerViewModel> updatedlist = new ObservableCollection<FootballPlayerViewModel> ();

			using (SQLiteConnection connection = new SQLiteConnection (Path.Combine (App.folderPath, "FootballPlayerDB.db3"))) {
				var list = connection.Query<FootballPlayer> ("SELECT * FROM FootballPlayer ORDER BY ISFAVOURITE DESC,FIRSTNAME ASC");				

				foreach (var item in list) {
					var pvm = new FootballPlayerViewModel ();
					pvm.FirstName = item.FirstName;
					pvm.LastName = item.LastName;
					pvm.Date_of_Birth = item.Date_of_Birth;
					pvm.Country = item.Country;
					pvm.Description = item.Description;
					pvm.Isfavourite = item.Isfavourite;
					pvm.age = (DateTime.Now - DateTime.Parse (item.Date_of_Birth)).ToString ();

					updatedlist.Add (pvm);
				}
			}
			PlayerViewModelList = updatedlist;
		}

		protected virtual void OnPropertyChanged (string propertyName)
		{
			if (PropertyChanged != null) {
				PropertyChanged (this,
					new PropertyChangedEventArgs (propertyName));
				//OnPropertyChanged ("PropertyChanged");
			}
		}

		#region INotifyPropertyChanged implementation
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
	}
}

