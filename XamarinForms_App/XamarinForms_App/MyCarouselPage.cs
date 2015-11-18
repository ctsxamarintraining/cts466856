using System;

using Xamarin.Forms;

namespace XamarinForms_App
{
	public class MyCarouselPage : CarouselPage
	{
		public MyCarouselPage ()
		{
			this.Children.Add (new ContentPage {
				Title = "C1 ",

				Content = new StackLayout { 
					Children = {
						new Label { Text = "Hello CarouselPage1" }
					}
				}
			});
			this.Children.Add (new ContentPage {
				Title = "C2 ",

				Content = new StackLayout { 
					Children = {
						new Label { Text = "Hello CarouselPage2" }
					}
				}
			});
			this.Children.Add (new ContentPage {
				Title = "C3 ",

				Content = new StackLayout { 
					Children = {
						new Label { Text = "Hello CarouselPage3" }
					}
				}
			});
			this.Children.Add (new ContentPage {
				Title = "C4 ",

				Content = new StackLayout { 
					Children = {
						new Label { Text = "Hello CarouselPage4" }
					}
				}
			});
			this.Children.Add (new ContentPage {
				Title = "C5 ",

				Content = new StackLayout { 
					Children = {
						new Label { Text = "Hello CarouselPage5" }
					}
				}
			});
		}
	}
}


