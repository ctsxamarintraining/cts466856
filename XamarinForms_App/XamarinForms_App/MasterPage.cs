using System;
using System.Reflection;
using Xamarin.Forms;

namespace XamarinForms_App
{
	public class MasterPage : MasterDetailPage
	{
		public MasterPage ()
		{
			NavigationPage.SetHasBackButton (this, false);
			MenuContent[] PageListItemSource = new MenuContent[] {
				new MenuContent (typeof(MyContentPage), "HomePage"),
				new MenuContent (typeof(MyTabbedPage), "TheTabbedPage"),
				new MenuContent (typeof(MyCarouselPage), "TheCarouselPage")
			};

			ListView PageList = new ListView {
				//ItemsSource = new string[]{ "MyContentPage" , "MyTabbedPage" , "MyCarouselPage"}
				ItemsSource = PageListItemSource
			};

			this.Master = new MyMenuPage (PageList);

			PageList.ItemSelected += (sender, args) => {

				// Set the BindingContext of the detail page.			
				Type presentPageType = (PageList.SelectedItem as MenuContent).ThisPageType;
				this.Detail = new NavigationPage(Activator.CreateInstance(presentPageType) as Page);
				//this.Detail.BindingContext = args.SelectedItem;

				// Show the detail page.
				this.IsPresented = false;
			};

			PageList.SelectedItem = PageListItemSource [0];
		}
	}
}


