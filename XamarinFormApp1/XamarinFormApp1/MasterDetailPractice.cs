using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinFormApp1
{
	public class MasterDetailPractice : MasterDetailPage
	{
		public MasterDetailPractice ()
		{
			Label header = new Label {
				Text = "MasterDetailPage",
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Center
			};

			MenuContent[] OptionArray = {
				new MenuContent ("ContentPage", Color.Aqua),
				new MenuContent ("TabbedPage", Color.FromRgb (0, 255, 0)),
				new MenuContent ("CarouselPage", Color.FromRgb (0, 0, 255))
			};

			ListView listView = new ListView {
				ItemsSource = OptionArray
			};

			this.Master = new ContentPage {
				Title = header.Text,
				Content = new StackLayout {
					Children = {
						header,
						listView
					}
				}
			};

//			this.Detail = new NavigationPage (new MenuPage ());

			listView.ItemSelected += (sender, args) => {

				// Set the BindingContext of the detail page.
				if (listView.SelectedItem.ToString () == "ContentPage")
					this.Detail = new NavigationPage (new NewContentPage (Color.Blue,"Blue"));
				else if (listView.SelectedItem.ToString () == "TabbedPage")
					this.Detail = new NavigationPage (new NewTabbedPage ());
				else if (listView.SelectedItem.ToString () == "CarouselPage")
					this.Detail = new NavigationPage (new NewCarouselPage ());

				// Show the detail page.
				this.IsPresented = false;
			};

			// Initialize the ListView selection.
			listView.SelectedItem = OptionArray [0];
		}
			

	}
}


