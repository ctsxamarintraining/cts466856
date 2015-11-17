using System;

using Xamarin.Forms;

namespace XamarinFormApp1
{
	public class NewTabbedPage : TabbedPage
	{
		public NewTabbedPage ()
		{
			this.Title = "TabbedPage";
//			this.Children.Add (new ContentPage {
//				Title = "Blue ",
//
//				Content = new StackLayout {
//					Children = {
//						new Label { Text = "Blue" },
//						new BoxView { Color = Color.Blue,
//							VerticalOptions = LayoutOptions.FillAndExpand},
//						//new BoxView { Color = Color.Red}
//					}
//				}
//			});

			this.Children.Add (new NewContentPage(Color.Black,"Black"));
			this.Children.Add (new NewContentPage(Color.Red,"Red"));
			this.Children.Add (new NewContentPage(Color.Aqua,"Aqua"));
			this.Children.Add (new NewContentPage(Color.Yellow,"yellow"));

		}
	}
}

