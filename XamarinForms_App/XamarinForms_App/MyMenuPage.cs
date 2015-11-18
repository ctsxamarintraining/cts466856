using System;

using Xamarin.Forms;

namespace XamarinForms_App
{
	public class MyMenuPage : ContentPage
	{
		public MyMenuPage (ListView PageList)
		{
			Title ="my app";
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


