using System;

using Xamarin.Forms;

namespace XamarinForms_App
{
	public class MyCarouselPage : CarouselPage
	{
		public MyCarouselPage ()
		{
			this.SetBinding(ContentPage.TitleProperty, "ThisPageTitle");
			this.Children.Add (new ContentPage {
				Title = "C1 ",
				BackgroundColor = Color.FromRgb(127,200,64),
				Content = new StackLayout { 
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					Children = {
						new Label { Text = "Hello CarouselPage1", }
					}
				}
			});

			this.Children.Add (new ContentPage {
				Title = "C2 ",
				BackgroundColor = Color.FromRgb(200,64,127),
				Content = new StackLayout { 
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					Children = {
						new Label { Text = "Hello CarouselPage2" }
					}
				}
			});

			this.Children.Add (new ContentPage {
				Title = "C3 ",
				BackgroundColor = Color.FromRgb(64,127,200),
				Content = new StackLayout { 
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					Children = {
						new Label { Text = "Hello CarouselPage3" }
					}
				}
			});

			this.Children.Add (new ContentPage {
				Title = "C4 ",
				BackgroundColor = Color.FromRgb(64,200,64),
				Content = new StackLayout { 
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					Children = {
						new Label { Text = "Hello CarouselPage4" }
					}
				}
			});

			this.Children.Add (new ContentPage {
				Title = "C5 ",
				BackgroundColor = Color.FromRgb(127,0,64),
				Content = new StackLayout { 
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					Children = {
						new Label { Text = "Hello CarouselPage5" }
					}
				}
			});
		}
	}
}


