using System;
using SQLite;
using Xamarin.Forms;
using System.IO;

namespace XamarinForms_App
{
	public class MyCustomerPage : ContentPage
	{
		private string folderPath = Path.Combine(App.folderPath,"CustomerDetailsDB.db3");

		public MyCustomerPage ()
		{
			createTheDataBase (folderPath);

			BackgroundColor = Color.FromHex ("#008080");
			Title = "Details Page";

			Entry Customer_Name = new Entry {
				Placeholder = "Name"
			};

			DatePicker Date_of_Birth = new DatePicker {
				MaximumDate = DateTime.Now
			};

			Label Gender_Label = new Label {
				Text = "Gender : Male"
			};

			Switch Gender_Switch = new Switch {
				HorizontalOptions = LayoutOptions.Center
			};
			Gender_Switch.Toggled += (object sender, ToggledEventArgs e) => {

				if (e.Value == false)
					Gender_Label.Text = String.Format ("Gender : Male");
				else
					Gender_Label.Text = "Gender : Female";
			};


			Editor Description_Editor = new Editor ();

			string[] Country_Picker_array = new string[] { 
				"India", "Britain", "Australia", "America", "Maldives"
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

			Save_Button.Clicked += (object sender, EventArgs e) => {
				
				Customer_Name.Unfocus();
				Description_Editor.Unfocus();
				Country_Picker.Unfocus();
				Date_of_Birth.Unfocus();

				if (Customer_Name.Text == null) {
					DisplayAlert ("Warning", "Empty Customer Name field", "Return");
				} else if (Country_Picker.SelectedIndex == -1) {
					DisplayAlert ("Warning", "Empty Country field", "Return");
				} else if (Description_Editor.Text == null)
					DisplayAlert ("Warning", "Empty Description field", "Return");
				else {
					string theGender;
					if (Gender_Switch.IsToggled) {
						theGender = "Female";
					} else {
						theGender = "Male";
					}
					TheCustomerDetails Cust_details = new TheCustomerDetails(
						Customer_Name.Text,
						Date_of_Birth.Date.ToString(),
						theGender,
						Description_Editor.Text,
						Country_Picker_array[Country_Picker.SelectedIndex]
					);
					saveToDataBase(Cust_details);
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
							Text = "Customer Name :"
						},
						Customer_Name,
						new Label {
							Text = "Date of Birth :"
						},
						Date_of_Birth,
						Gender_Label,
						Gender_Switch,
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

		public void saveToDataBase(TheCustomerDetails cust_details){
			
			//DisplayAlert ("folder",folderPath,"ok");
			if (cust_details != null) {
				try {
					using(SQLiteConnection connection = new SQLiteConnection (folderPath)){
						connection.Insert (cust_details);
						this.Navigation.PushAsync(new FootballPlayerListPage());
					}
				}
				catch(SQLiteException ex){
					DisplayAlert ("Error",ex.Message,"return");
				}
			}
		}

		public void createTheDataBase( string thefolderpath){
			using(SQLiteConnection connection = new SQLiteConnection (thefolderpath)){
				connection.CreateTable<TheCustomerDetails>();
			}
		}

	}
}


