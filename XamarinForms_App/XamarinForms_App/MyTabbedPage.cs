using System;

using Xamarin.Forms;

namespace XamarinForms_App
{
	public class MyTabbedPage : TabbedPage
	{
		public MyTabbedPage ()
		{
			this.SetBinding(ContentPage.TitleProperty, "ThisPageTitle");
			this.Children.Add (new ContentPage {
				Title = "T1 ",
				BackgroundColor = Color.Lime,
				Content = new StackLayout { 
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					Children = {
						new Label { Text = "Hello TabbedPage1" }
					}
				}
			});
			this.Children.Add (new ContentPage {
				Title = "T2 ",
				BackgroundColor = Color.Gray,
				Content = new StackLayout { 
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					Children = {
						new Label { Text = "Hello TabbedPage2" }
					}
				}
			});
			this.Children.Add (new ContentPage {
				Title = "T3 ",
				BackgroundColor = Color.Blue,
				Content = new StackLayout { 
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					Children = {
						new Label { Text = "Hello TabbedPage3" }
					}
				}
			});
			this.Children.Add (new ContentPage {
				Title = "T4 ",
				BackgroundColor = Color.Red,
				Content = new StackLayout { 
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					Children = {
						new Label { Text = "Hello TabbedPage4" }
					}
				}
			});
		}
	}
}


