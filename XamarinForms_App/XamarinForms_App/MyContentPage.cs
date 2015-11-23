using System;

using Xamarin.Forms;
using SQLite;
using System.IO;
using System.Collections.ObjectModel;

namespace XamarinForms_App
{
	public class MyContentPage : ContentPage
	{

		public MyContentPage ()
		{
//			Content = new StackLayout { 
//				Children = {
//					new Label { Text = "Hello ContentPage" }
//				}
//			};

			this.BackgroundImage = "Images/244340_windows-8-logon-background.png";
			this.SetBinding(ContentPage.TitleProperty, "ThisPageTitle");
			BackgroundColor = Color.Black;
			Button btn = new Button{ Text = "Go_to_NewPage",TextColor = Color.Black};
			btn.Clicked += (sender, e) => 
					this.Navigation.PushAsync(new FootballPlayerListPage());
				;
			Content = new StackLayout {
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					
					//new Label { Text = "The Page",TextColor = Color.Black }
					btn
				}
			};
		}
	}
}


