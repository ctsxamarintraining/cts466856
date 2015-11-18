using System;
using System.Reflection;
using Xamarin.Forms;

namespace XamarinForms_App
{
	public class MasterPage : MasterDetailPage
	{
		public MasterPage ()
		{
			ListView PageList = new ListView {
				//ItemsSource = new string[]{ "MyContentPage" , "MyTabbedPage" , "MyCarouselPage"}
				ItemsSource = new MenuContent[]{
					new MenuContent(Type(MyContentPage),"TheContentPage"),
					new MenuContent(Type(MyTabbedPage),"TheTabbedPage"),
					new MenuContent(Type(MyCarouselPage),"TheCarouselPage")
				}
			};

			this.Master = new MyMenuPage (PageList);

			PageList.ItemSelected += (sender, args) => {

				// Set the BindingContext of the detail page.
//				if (PageList.SelectedItem.ToString () == "ContentPage")
//					this.Detail = new NavigationPage (new NewContentPage ());
//				else if (PageList.SelectedItem.ToString () == "TabbedPage")
//					this.Detail = new NavigationPage (new NewTabbedPage ());
//				else if (PageList.SelectedItem.ToString () == "CarouselPage")
//					this.Detail = new NavigationPage (new NewCarouselPage ());

				Type presentPageType = (PageList.SelectedItem as MenuContent).ThisPageType;
				this.Detail = new NavigationPage(presentPageType);

				this.Detail.BindingContext = args.SelectedItem;

				// Show the detail page.
				this.IsPresented = false;
			};

		}
	}
}


