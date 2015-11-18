using System;

using Xamarin.Forms;

namespace XamarinForms_App
{
	public class MyTabbedPage : TabbedPage
	{
		public MyTabbedPage ()
		{
			this.Children.Add (new ContentPage {
				Title = "T1 ",
				
				Content = new StackLayout { 
					Children = {
						new Label { Text = "Hello TabbedPage1" }
					}
				}
			});
			this.Children.Add (new ContentPage {
				Title = "T2 ",

				Content = new StackLayout { 
					Children = {
						new Label { Text = "Hello TabbedPage2" }
					}
				}
			});
			this.Children.Add (new ContentPage {
				Title = "T3 ",

				Content = new StackLayout { 
					Children = {
						new Label { Text = "Hello TabbedPage3" }
					}
				}
			});
			this.Children.Add (new ContentPage {
				Title = "T4 ",

				Content = new StackLayout { 
					Children = {
						new Label { Text = "Hello TabbedPage4" }
					}
				}
			});
		}
	}
}


