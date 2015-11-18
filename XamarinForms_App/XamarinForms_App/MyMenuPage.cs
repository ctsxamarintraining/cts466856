using System;

using Xamarin.Forms;

namespace XamarinForms_App
{
	public class MyMenuPage : ContentPage
	{
		public MyMenuPage (ListView PageList)
		{

			Label header = new Label {
				Text = "MasterPage",
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Center
			};

			Content = new StackLayout {
				Children = {
					header,
					PageList
				}
			};

		}
	}
}


