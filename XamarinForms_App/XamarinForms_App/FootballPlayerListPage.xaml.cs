using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using SQLite;
using System.IO;
using System.Diagnostics;

namespace XamarinForms_App
{
	public partial class FootballPlayerListPage : ContentPage
	{
		private string folderPath = Path.Combine (App.folderPath, "FootballPlayerDB.db3");


		protected override void OnAppearing ()
		{
			(this.BindingContext as FootballPlayerListViewModel).PlayerViewModelList = UpdateList ();
		}

		public ObservableCollection<FootballPlayerViewModel> UpdateList(){

			ObservableCollection<FootballPlayerViewModel> updatedlist = new ObservableCollection<FootballPlayerViewModel> ();

			SQLiteConnection connection = new SQLiteConnection (folderPath);
			//	var list = connection.Table<FootballPlayer> ();//
			var list = connection.Query<FootballPlayer> ("SELECT * FROM FootballPlayer ORDER BY ISFAVOURITE,FIRSTNAME");
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
			connection.Dispose ();
			return updatedlist;
		}

		public FootballPlayerListPage ()
		{

			// add new player
			ToolbarItem addButton = new ToolbarItem {
				Text = "ADD"
			};
			this.ToolbarItems.Add (addButton);
			addButton.Clicked += (object sender, EventArgs e) => {
				this.Navigation.PushAsync (new NewPlayerPage ());
			};


			// set binding context to list view model
			this.BindingContext = new FootballPlayerListViewModel ();

			// local listview list = observable collection in binding context or list view model
			(this.BindingContext as FootballPlayerListViewModel).PlayerViewModelList = new ObservableCollection<FootballPlayerViewModel> ();

			(this.BindingContext as FootballPlayerListViewModel).PlayerViewModelList = UpdateList ();

			InitializeComponent ();

			this.FootballPlayerListView.ItemSelected += (sender, e) => {
				(this.BindingContext as FootballPlayerListViewModel).SelectedPlayer = (e.SelectedItem as FootballPlayerViewModel);
				this.Navigation.PushAsync (new PlayerDetailsPage (e.SelectedItem));
			};

			MessagingCenter.Subscribe<FootballPlayerViewModel> (this, "DBChanged", (obj) => {
				(this.BindingContext as FootballPlayerListViewModel).PlayerViewModelList = UpdateList ();
			});

		}

	}
}

