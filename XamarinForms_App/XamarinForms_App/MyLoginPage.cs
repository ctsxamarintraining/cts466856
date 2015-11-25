using System;

using Xamarin.Forms;

namespace XamarinForms_App
{
	public class MyLoginPage : ContentPage
	{
		public MyLoginPage ()
		{
			Title = "Login";
			Entry UserNameEntry = new Entry {
				Placeholder = "User Name"
			};
			Entry PasswordEntry = new Entry {
				Placeholder = "Password",
				IsPassword = true
			};
			Button SignIn = new Button {
				Text = "Sign in",
				BorderColor = Color.Blue,
				BorderRadius = 5,
			};
			SignIn.Clicked += (sender, e) => {
				if (UserNameEntry.Text == "User1" && PasswordEntry.Text == "123") {
					UserNameEntry.Text = "";
					PasswordEntry.Text = "";
					this.Navigation.PushModalAsync (new MasterPage ());
				} else if (UserNameEntry.Text == "" || PasswordEntry.Text == "")
					this.DisplayAlert ("Warning", "Incomplete Fields", "ok");
				else {
					this.DisplayAlert ("Warning", "Incorrect Fields", "ok");
					UserNameEntry.Text = "";
					PasswordEntry.Text = "";
				}
			};
			Content = new StackLayout { 
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Image {
						BackgroundColor = Color.FromRgb (220, 220, 220),
						Aspect = Aspect.AspectFit,
						Source = ImageSource.FromFile ("Images/login2.png")
					},
					UserNameEntry,
					PasswordEntry,
					SignIn
				}
			};
		}
	}
}


