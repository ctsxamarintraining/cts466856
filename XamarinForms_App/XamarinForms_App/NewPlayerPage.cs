using System;
using SQLite;
using Xamarin.Forms;
using System.IO;
using System.Diagnostics;

namespace XamarinForms_App
{
	public class NewPlayerPage : ContentPage
	{
		public NewPlayerPage ()
		{
			this.BindingContext = new FootballPlayerViewModel ();

			BackgroundColor = Color.FromHex ("#008080");
			Title = "Player Details";

			Entry Player_FName = new Entry {
				Placeholder = "First Name"
			};

			Entry Player_LName = new Entry {
				Placeholder = "Last Name"
			};

			DatePicker Date_of_Birth = new DatePicker {
				MaximumDate = DateTime.Now
			};
					
			Editor Description_Editor = new Editor ();

			string[] Country_Picker_array = new string[] { 
				"Argentina", "Australia", 
				"Belgium", "Brazil", 
				"Canada", "China", "Croatia", 
				"Denmark", 
				"Ecuador", "Egypt", "El Salvador", "England", "Ethiopia", 
				"Germany", 
				"India", "Italy", 
				"Japan", 
				"Malasya", 
				"Netherlands", "NewZealand", 
				"Qatar", 
				"South Africa"
			};

			Picker Country_Picker = new Picker ();

			foreach (string country_string in Country_Picker_array)
				Country_Picker.Items.Add (country_string);



			Button Save_Button = new Button {
				Text = "Save Details",
				BackgroundColor = Color.White,
				BorderRadius = 5,
				HorizontalOptions = LayoutOptions.Center
			};

			//Save_Button.Command = this.SetBinding (Button.CommandProperty,"SaveCommand");

			Save_Button.Clicked += (object sender, EventArgs e) => {
				
				Player_FName.Unfocus ();
				Player_LName.Unfocus ();
				Description_Editor.Unfocus ();
				Country_Picker.Unfocus ();
				Date_of_Birth.Unfocus ();

				if (Player_FName.Text == null || Player_LName.Text == null) {
					DisplayAlert ("Warning", "Empty Player Name field", "Return");
				} else if (Country_Picker.SelectedIndex == -1) {
					DisplayAlert ("Warning", "Empty Country field", "Return");
				} else if (Description_Editor.Text == null)
					DisplayAlert ("Warning", "Empty Description field", "Return");
				else {

					saveToDataBase (new FootballPlayer (
						Player_FName.Text,
						Player_LName.Text,
						Date_of_Birth.Date.ToString("MMMM dd, yyyy"),
						Country_Picker_array [Country_Picker.SelectedIndex],
						Description_Editor.Text
					));


				}
			};


			StackLayout content_stacklayout = new StackLayout ();

			ScrollView Customer_Details_ScrollView = new ScrollView {
				WidthRequest = ((content_stacklayout.Width * 2) / 3),
				VerticalOptions = LayoutOptions.Center,
				Content = new StackLayout { 
					VerticalOptions = LayoutOptions.Center,
					Children = {
												
						new Label {
							Text = "Player Name :"
						},
						Player_FName,
						Player_LName,
						new Label {
							Text = "Date of Birth :"
						},
						Date_of_Birth,
						new Label {
							Text = "Description :"
						},
						Description_Editor,
						new Label {
							Text = "Country :"
						},
						Country_Picker,
						Save_Button
					}
				}
			};

			content_stacklayout.Children.Add (Customer_Details_ScrollView);
			Content = content_stacklayout;

		}

		public void saveToDataBase (FootballPlayer PlayerDetails)
		{
			
			//DisplayAlert ("folder",folderPath,"ok");
			if (PlayerDetails != null) {
				try {
					using (SQLiteConnection connection = new SQLiteConnection (Path.Combine (App.folderPath, "FootballPlayerDB.db3"))) {
						connection.Insert (PlayerDetails);

					}
					MessagingCenter.Send (this, "DBChanged");
					this.Navigation.PopAsync ();
				} catch (SQLiteException ex) {
					DisplayAlert ("Error", ex.Message, "return");
				}
			}
		}

	}
}


