using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using SQLite;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace XamarinForms_App
{
	public partial class FootballPlayerListPage : ContentPage
	{
		public FootballPlayerListPage ()
		{

			// add new player button
			ToolbarItem addButton = new ToolbarItem {
				Text = "ADD"
			};
			this.ToolbarItems.Add (addButton);
			addButton.Clicked += (object sender, EventArgs e) => {
				this.Navigation.PushAsync (new NewPlayerPage ());
			};
				
			this.BindingContext = new FootballPlayerListViewModel ();
			InitializeComponent ();

			this.FootballPlayerListView.ItemSelected += (sender, e) => {
				// go to details
			};

		}

	}
}

